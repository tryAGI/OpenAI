using System.Net;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace tryAGI.OpenAI;

/// <summary>
/// Parsed rate-limit information captured from provider response headers.
/// </summary>
public sealed class OpenAiRateLimitSnapshot
{
    internal OpenAiRateLimitSnapshot(
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

    /// <summary>
    /// Gets when the snapshot was observed.
    /// </summary>
    public DateTimeOffset ObservedAt { get; }

    /// <summary>
    /// Gets the parsed retry-after duration, if present.
    /// </summary>
    public TimeSpan? RetryAfter { get; }

    /// <summary>
    /// Gets the parsed reset time, if present.
    /// </summary>
    public DateTimeOffset? ResetAt { get; }

    /// <summary>
    /// Gets the remaining request budget, if present.
    /// </summary>
    public long? RemainingRequests { get; }

    /// <summary>
    /// Gets the request limit, if present.
    /// </summary>
    public long? LimitRequests { get; }

    /// <summary>
    /// Gets the remaining token budget, if present.
    /// </summary>
    public long? RemainingTokens { get; }

    /// <summary>
    /// Gets the token limit, if present.
    /// </summary>
    public long? LimitTokens { get; }
}

internal static class OpenAiRateLimitRegistry
{
    private static readonly ConditionalWeakTable<HttpClient, OpenAiProviderRuntimeState> Registry = new();

    public static void Register(HttpClient client, OpenAiProviderRuntimeState state)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentNullException.ThrowIfNull(state);

        lock (Registry)
        {
            Registry.Remove(client);
            Registry.Add(client, state);
        }
    }

    public static bool TryGet(HttpClient client, out OpenAiProviderRuntimeState? state)
    {
        ArgumentNullException.ThrowIfNull(client);

        lock (Registry)
        {
            return Registry.TryGetValue(client, out state);
        }
    }

    public static void Unregister(HttpClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        lock (Registry)
        {
            Registry.Remove(client);
        }
    }
}

internal sealed class OpenAiProviderRuntimeState
{
    private readonly object _lock = new();
    private readonly TimeProvider _timeProvider;
    private readonly TimeSpan _rateLimitCooldown;
    private readonly TimeSpan _transientFailureCooldown;

    private DateTimeOffset? _cooldownUntil;
    private OpenAiRateLimitSnapshot? _lastRateLimitSnapshot;
    private string? _lastError;

    public OpenAiProviderRuntimeState(
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

    public OpenAiRoutedProviderStatus GetStatus(string providerId)
    {
        lock (_lock)
        {
            return new OpenAiRoutedProviderStatus(
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
        var snapshot = OpenAiRateLimitParser.Parse(response.Headers, now);

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

            if (exception is ApiException apiException)
            {
                var snapshot = OpenAiRateLimitParser.Parse(apiException.ResponseHeaders, now);
                if (snapshot is not null)
                {
                    _lastRateLimitSnapshot = snapshot;
                }

                if (apiException.StatusCode == HttpStatusCode.TooManyRequests)
                {
                    ApplyCooldown(GetCooldownUntil(snapshot, now, _rateLimitCooldown));
                    return;
                }

                if (apiException.StatusCode == HttpStatusCode.RequestTimeout ||
                    (int)apiException.StatusCode >= 500)
                {
                    ApplyCooldown(now + _transientFailureCooldown);
                    return;
                }
            }

            if (exception is TimeoutException or HttpRequestException)
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
        OpenAiRateLimitSnapshot? snapshot,
        DateTimeOffset now,
        TimeSpan fallbackCooldown)
        => snapshot?.ResetAt ??
           (snapshot?.RetryAfter is { } retryAfter ? now + retryAfter : now + fallbackCooldown);
}

internal static class OpenAiRateLimitParser
{
    // Manual header parsing is kept here until AutoSDK exposes response header support directly.
    // See: https://github.com/tryAGI/AutoSDK/issues/31

    public static OpenAiRateLimitSnapshot? Parse(HttpResponseHeaders headers, DateTimeOffset observedAt)
    {
        ArgumentNullException.ThrowIfNull(headers);
        return Parse(headers.Select(static header => new KeyValuePair<string, IEnumerable<string>>(header.Key, header.Value)), observedAt);
    }

    public static OpenAiRateLimitSnapshot? Parse(
        IReadOnlyDictionary<string, IEnumerable<string>>? headers,
        DateTimeOffset observedAt)
    {
        if (headers is null || headers.Count == 0)
        {
            return null;
        }

        return Parse(headers.AsEnumerable(), observedAt);
    }

    private static OpenAiRateLimitSnapshot? Parse(
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
            TryParseInt64(GetFirstHeaderValue(headerList, "ratelimit-remaining"));
        var limitRequests =
            TryParseInt64(GetFirstHeaderValue(headerList, "x-ratelimit-limit-requests")) ??
            TryParseInt64(GetFirstHeaderValue(headerList, "ratelimit-limit"));
        var remainingTokens = TryParseInt64(GetFirstHeaderValue(headerList, "x-ratelimit-remaining-tokens"));
        var limitTokens = TryParseInt64(GetFirstHeaderValue(headerList, "x-ratelimit-limit-tokens"));

        if (retryAfter is null &&
            resetAt is null &&
            remainingRequests is null &&
            limitRequests is null &&
            remainingTokens is null &&
            limitTokens is null)
        {
            return null;
        }

        return new OpenAiRateLimitSnapshot(
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
        string name)
    {
        foreach (var header in headers)
        {
            if (string.Equals(header.Key, name, StringComparison.OrdinalIgnoreCase))
            {
                return header.Value.FirstOrDefault();
            }
        }

        return null;
    }

    private static long? TryParseInt64(string? value)
        => long.TryParse(value, out var parsed) ? parsed : null;

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

        if (DateTimeOffset.TryParse(value, out var absolute))
        {
            var delta = absolute - observedAt;
            return delta > TimeSpan.Zero ? delta : TimeSpan.Zero;
        }

        return TryParseDuration(value);
    }

    private static DateTimeOffset? TryParseReset(string? value, DateTimeOffset observedAt)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return null;
        }

        if (DateTimeOffset.TryParse(value, out var absolute))
        {
            return absolute;
        }

        if (double.TryParse(value, out var numeric))
        {
            // Some providers return unix seconds, others return seconds until reset.
            if (numeric > 946684800d)
            {
                return DateTimeOffset.FromUnixTimeSeconds((long)numeric);
            }

            return observedAt + TimeSpan.FromSeconds(numeric);
        }

        if (TryParseDuration(value) is { } duration)
        {
            return observedAt + duration;
        }

        return null;
    }

    private static TimeSpan? TryParseDuration(string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return null;
        }

        value = value.Trim();

        if (value.EndsWith("ms", StringComparison.OrdinalIgnoreCase) &&
            double.TryParse(value[..^2], out var milliseconds))
        {
            return TimeSpan.FromMilliseconds(milliseconds);
        }

        if (value.EndsWith('s') &&
            double.TryParse(value[..^1], out var seconds))
        {
            return TimeSpan.FromSeconds(seconds);
        }

        if (value.EndsWith('m') &&
            double.TryParse(value[..^1], out var minutes))
        {
            return TimeSpan.FromMinutes(minutes);
        }

        return null;
    }
}

public sealed partial class ChatClient
{
    partial void ProcessResponse(HttpClient client, HttpResponseMessage response)
    {
        if (OpenAiRateLimitRegistry.TryGet(client, out var state) && state is not null)
        {
            state.ObserveResponse(response);
        }
    }
}
