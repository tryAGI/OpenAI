using System.Net;
using System.Net.Http.Headers;

namespace FreeLLM;

/// <summary>
/// Parsed rate-limit information captured from provider response headers.
/// </summary>
public sealed class FreeLlmRateLimitSnapshot
{
    internal FreeLlmRateLimitSnapshot(
        DateTimeOffset observedAt,
        TimeSpan? retryAfter,
        DateTimeOffset? resetAt,
        long? remainingRequests,
        long? limitRequests,
        long? remainingTokens,
        long? limitTokens)
    {
        ObservedAt = observedAt;
        RetryAfter = retryAfter;
        ResetAt = resetAt;
        RemainingRequests = remainingRequests;
        LimitRequests = limitRequests;
        RemainingTokens = remainingTokens;
        LimitTokens = limitTokens;
    }

    public DateTimeOffset ObservedAt { get; }

    public TimeSpan? RetryAfter { get; }

    public DateTimeOffset? ResetAt { get; }

    public long? RemainingRequests { get; }

    public long? LimitRequests { get; }

    public long? RemainingTokens { get; }

    public long? LimitTokens { get; }
}

/// <summary>
/// Current status for a routed provider.
/// </summary>
public sealed class FreeLlmProviderStatus
{
    internal FreeLlmProviderStatus(
        string providerId,
        DateTimeOffset? cooldownUntil,
        FreeLlmRateLimitSnapshot? rateLimitSnapshot,
        string? lastError)
    {
        ProviderId = providerId;
        CooldownUntil = cooldownUntil;
        RateLimitSnapshot = rateLimitSnapshot;
        LastError = lastError;
    }

    public string ProviderId { get; }

    public DateTimeOffset? CooldownUntil { get; }

    public FreeLlmRateLimitSnapshot? RateLimitSnapshot { get; }

    public string? LastError { get; }
}

internal sealed class FreeLlmResponseTrackingHandler : DelegatingHandler
{
    private readonly FreeLlmProviderRuntimeState _state;

    public FreeLlmResponseTrackingHandler(
        FreeLlmProviderRuntimeState state,
        HttpMessageHandler innerHandler)
        : base(innerHandler)
    {
        _state = state ?? throw new ArgumentNullException(nameof(state));
    }

    protected override async Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        var response = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
        _state.ObserveResponse(response);
        return response;
    }
}

internal sealed class FreeLlmProviderRuntimeState
{
    private readonly object _lock = new();
    private readonly TimeProvider _timeProvider;
    private readonly TimeSpan _rateLimitCooldown;
    private readonly TimeSpan _transientFailureCooldown;

    private DateTimeOffset? _cooldownUntil;
    private FreeLlmRateLimitSnapshot? _lastRateLimitSnapshot;
    private string? _lastError;

    public FreeLlmProviderRuntimeState(
        TimeProvider timeProvider,
        TimeSpan rateLimitCooldown,
        TimeSpan transientFailureCooldown)
    {
        _timeProvider = timeProvider;
        _rateLimitCooldown = rateLimitCooldown;
        _transientFailureCooldown = transientFailureCooldown;
    }

    public bool IsCoolingDown(DateTimeOffset now)
    {
        lock (_lock)
        {
            return _cooldownUntil is { } cooldownUntil && cooldownUntil > now;
        }
    }

    public FreeLlmProviderStatus GetStatus(string providerId)
    {
        lock (_lock)
        {
            return new FreeLlmProviderStatus(
                providerId: providerId,
                cooldownUntil: _cooldownUntil,
                rateLimitSnapshot: _lastRateLimitSnapshot,
                lastError: _lastError);
        }
    }

    public void ObserveResponse(HttpResponseMessage response)
    {
        ArgumentNullException.ThrowIfNull(response);

        var now = _timeProvider.GetUtcNow();
        var snapshot = FreeLlmRateLimitParser.Parse(response.Headers, now);

        lock (_lock)
        {
            if (snapshot is not null)
            {
                _lastRateLimitSnapshot = snapshot;
            }

            if (response.StatusCode == HttpStatusCode.TooManyRequests)
            {
                _lastError = "429 Too Many Requests";
                ApplyCooldown(GetCooldownUntil(snapshot, now, _rateLimitCooldown));
            }
            else if ((int)response.StatusCode >= 500)
            {
                _lastError = $"{(int)response.StatusCode} {response.ReasonPhrase}";
                ApplyCooldown(now + _transientFailureCooldown);
            }
        }
    }

    public void ObserveException(Exception exception, DateTimeOffset now)
    {
        ArgumentNullException.ThrowIfNull(exception);

        lock (_lock)
        {
            _lastError = exception.Message;
        }

        switch (exception)
        {
            case tryAGI.OpenAI.ApiException openAiException:
                ObserveApiException(openAiException.StatusCode, openAiException.ResponseHeaders, now);
                return;

            case Google.Gemini.ApiException geminiException:
                ObserveApiException(geminiException.StatusCode, geminiException.ResponseHeaders, now);
                return;

            case TimeoutException:
            case HttpRequestException:
                lock (_lock)
                {
                    ApplyCooldown(now + _transientFailureCooldown);
                }
                return;
        }
    }

    private void ObserveApiException(
        HttpStatusCode statusCode,
        IReadOnlyDictionary<string, IEnumerable<string>>? headers,
        DateTimeOffset now)
    {
        var snapshot = FreeLlmRateLimitParser.Parse(headers, now);

        lock (_lock)
        {
            if (snapshot is not null)
            {
                _lastRateLimitSnapshot = snapshot;
            }

            if (statusCode == HttpStatusCode.TooManyRequests)
            {
                ApplyCooldown(GetCooldownUntil(snapshot, now, _rateLimitCooldown));
            }
            else if (statusCode == HttpStatusCode.RequestTimeout || (int)statusCode >= 500)
            {
                ApplyCooldown(now + _transientFailureCooldown);
            }
        }
    }

    private void ApplyCooldown(DateTimeOffset cooldownUntil)
    {
        if (_cooldownUntil is null || cooldownUntil > _cooldownUntil)
        {
            _cooldownUntil = cooldownUntil;
        }
    }

    private static DateTimeOffset GetCooldownUntil(
        FreeLlmRateLimitSnapshot? snapshot,
        DateTimeOffset now,
        TimeSpan fallbackCooldown)
        => snapshot?.ResetAt ??
           (snapshot?.RetryAfter is { } retryAfter ? now + retryAfter : now + fallbackCooldown);
}

internal static class FreeLlmRateLimitParser
{
    public static FreeLlmRateLimitSnapshot? Parse(HttpResponseHeaders headers, DateTimeOffset observedAt)
    {
        ArgumentNullException.ThrowIfNull(headers);
        return Parse(headers.Select(static header => new KeyValuePair<string, IEnumerable<string>>(header.Key, header.Value)), observedAt);
    }

    public static FreeLlmRateLimitSnapshot? Parse(
        IReadOnlyDictionary<string, IEnumerable<string>>? headers,
        DateTimeOffset observedAt)
    {
        if (headers is null || headers.Count == 0)
        {
            return null;
        }

        return Parse(headers.AsEnumerable(), observedAt);
    }

    private static FreeLlmRateLimitSnapshot? Parse(
        IEnumerable<KeyValuePair<string, IEnumerable<string>>> headers,
        DateTimeOffset observedAt)
    {
        var headerList = headers.ToArray();

        var retryAfter = TryParseRetryAfter(GetFirstHeaderValue(headerList, "Retry-After"), observedAt);
        var resetAt =
            TryParseReset(GetFirstHeaderValue(headerList, "x-ratelimit-reset-requests"), observedAt) ??
            TryParseReset(GetFirstHeaderValue(headerList, "x-ratelimit-reset"), observedAt) ??
            TryParseReset(GetFirstHeaderValue(headerList, "x-ratelimit-reset-tokens"), observedAt);

        var remainingRequests =
            TryParseInt64(GetFirstHeaderValue(headerList, "x-ratelimit-remaining-requests")) ??
            TryParseInt64(GetFirstHeaderValue(headerList, "ratelimit-remaining-requests"));
        var limitRequests =
            TryParseInt64(GetFirstHeaderValue(headerList, "x-ratelimit-limit-requests")) ??
            TryParseInt64(GetFirstHeaderValue(headerList, "ratelimit-limit-requests"));
        var remainingTokens =
            TryParseInt64(GetFirstHeaderValue(headerList, "x-ratelimit-remaining-tokens")) ??
            TryParseInt64(GetFirstHeaderValue(headerList, "ratelimit-remaining-tokens"));
        var limitTokens =
            TryParseInt64(GetFirstHeaderValue(headerList, "x-ratelimit-limit-tokens")) ??
            TryParseInt64(GetFirstHeaderValue(headerList, "ratelimit-limit-tokens"));

        if (retryAfter is null &&
            resetAt is null &&
            remainingRequests is null &&
            limitRequests is null &&
            remainingTokens is null &&
            limitTokens is null)
        {
            return null;
        }

        return new FreeLlmRateLimitSnapshot(
            observedAt: observedAt,
            retryAfter: retryAfter,
            resetAt: resetAt,
            remainingRequests: remainingRequests,
            limitRequests: limitRequests,
            remainingTokens: remainingTokens,
            limitTokens: limitTokens);
    }

    private static string? GetFirstHeaderValue(
        IEnumerable<KeyValuePair<string, IEnumerable<string>>> headers,
        string headerName)
        => headers.FirstOrDefault(header =>
               string.Equals(header.Key, headerName, StringComparison.OrdinalIgnoreCase))
           .Value?
           .FirstOrDefault();

    private static TimeSpan? TryParseRetryAfter(string? value, DateTimeOffset observedAt)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return null;
        }

        if (int.TryParse(value, out var seconds))
        {
            return TimeSpan.FromSeconds(seconds);
        }

        if (DateTimeOffset.TryParse(value, out var retryAt))
        {
            var retryAfter = retryAt - observedAt;
            return retryAfter > TimeSpan.Zero ? retryAfter : TimeSpan.Zero;
        }

        return null;
    }

    private static DateTimeOffset? TryParseReset(string? value, DateTimeOffset observedAt)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return null;
        }

        if (DateTimeOffset.TryParse(value, out var timestamp))
        {
            return timestamp;
        }

        if (long.TryParse(value, out var unixSeconds))
        {
            if (unixSeconds > 1_000_000_000_000L)
            {
                return DateTimeOffset.FromUnixTimeMilliseconds(unixSeconds);
            }

            if (unixSeconds > 1_000_000_000L)
            {
                return DateTimeOffset.FromUnixTimeSeconds(unixSeconds);
            }

            return observedAt.AddSeconds(unixSeconds);
        }

        if (double.TryParse(value, out var seconds))
        {
            return observedAt.AddSeconds(seconds);
        }

        return null;
    }

    private static long? TryParseInt64(string? value)
        => long.TryParse(value, out var parsed) ? parsed : null;
}
