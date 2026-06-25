using System.Net.WebSockets;
using Microsoft.Extensions.Logging;
using tryAGI.OpenAI.OpenAISharp.Realtime;

namespace tryAGI.OpenAI.OpenAISharp.Services;

/// <summary>
/// Service for OpenAI realtime WebSocket sessions.
/// </summary>
public sealed class OpenAIRealtimeService
{
    private static readonly Action<ILogger, Uri, Exception?> ConnectingRealtimeSession =
        LoggerMessage.Define<Uri>(
            LogLevel.Information,
            new EventId(1, nameof(ConnectingRealtimeSession)),
            "[OpenAI] Connecting realtime session: {Uri}");

    private static readonly Action<ILogger, Exception?> ConnectedRealtimeSession =
        LoggerMessage.Define(
            LogLevel.Information,
            new EventId(2, nameof(ConnectedRealtimeSession)),
            "[OpenAI] Connected realtime session.");

    private readonly OpenAIConfig _config;
    private readonly ILogger _logger;

    internal OpenAIRealtimeService(OpenAIConfig config, ILogger logger)
    {
        _config = config;
        _logger = logger;
    }

    /// <summary>
    /// Opens a realtime WebSocket session.
    /// </summary>
    public async Task<OpenAIRealtimeSession> ConnectAsync(
        OpenAIRealtimeConnectOptions options,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(options);

        if (string.IsNullOrWhiteSpace(options.Model))
        {
            throw new OpenAIException("Model must be provided for OpenAI realtime sessions.");
        }

        var apiKey = options.ApiKey ?? _config.ApiKey;
        if (string.IsNullOrWhiteSpace(apiKey))
        {
            throw new OpenAIException("ApiKey must be provided for OpenAI realtime sessions.");
        }

        var uri = BuildUri(options);
        var webSocket = new ClientWebSocket();
        webSocket.Options.KeepAliveInterval = _config.KeepAliveInterval;

        var subProtocols = new HashSet<string>(StringComparer.Ordinal);
        ApplyAuthentication(webSocket, options, apiKey, subProtocols);
        ApplyHeaders(webSocket, options, subProtocols);

        using var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
        cts.CancelAfter(_config.ConnectTimeout);

        ConnectingRealtimeSession(_logger, uri, null);
        await webSocket.ConnectAsync(uri, cts.Token).ConfigureAwait(false);
        ConnectedRealtimeSession(_logger, null);

        return new OpenAIRealtimeSession(webSocket, _logger);
    }

    private Uri BuildUri(OpenAIRealtimeConnectOptions options)
    {
        if (!Uri.TryCreate(_config.BaseUrl, UriKind.Absolute, out var baseUri))
        {
            throw new OpenAIException($"Invalid OpenAI BaseUrl: '{_config.BaseUrl}'.");
        }

        baseUri = ApplySessionKindPath(baseUri, options.SessionKind);

        var query = new List<string>();
        if (!string.IsNullOrWhiteSpace(baseUri.Query))
        {
            var existing = baseUri.Query.TrimStart('?');
            if (!string.IsNullOrWhiteSpace(existing))
            {
                query.Add(existing);
            }
        }

        if (options.SessionKind == OpenAIRealtimeSessionKind.Transcription)
        {
            query.Add("intent=transcription");
        }
        else
        {
            query.Add($"model={Uri.EscapeDataString(options.Model)}");
        }

        var builder = new UriBuilder(baseUri)
        {
            Query = string.Join("&", query)
        };

        return builder.Uri;
    }

    private static Uri ApplySessionKindPath(Uri baseUri, OpenAIRealtimeSessionKind sessionKind)
    {
        if (sessionKind != OpenAIRealtimeSessionKind.Translation)
        {
            return baseUri;
        }

        var path = baseUri.AbsolutePath.TrimEnd('/');
        if (!path.EndsWith("/translations", StringComparison.Ordinal))
        {
            path += "/translations";
        }

        return new UriBuilder(baseUri)
        {
            Path = path,
        }.Uri;
    }

    private void ApplyAuthentication(
        ClientWebSocket webSocket,
        OpenAIRealtimeConnectOptions options,
        string apiKey,
        HashSet<string> subProtocols)
    {
        var organizationId = options.OrganizationId ?? _config.OrganizationId;
        var projectId = options.ProjectId ?? _config.ProjectId;
        var safetyIdentifier = options.SafetyIdentifier ?? _config.SafetyIdentifier;

        if (options.UseSubprotocolAuthentication)
        {
            AddSubProtocol(webSocket, subProtocols, "realtime");
            AddSubProtocol(webSocket, subProtocols, $"openai-insecure-api-key.{apiKey}");

            if (!string.IsNullOrWhiteSpace(organizationId))
            {
                AddSubProtocol(webSocket, subProtocols, $"openai-organization.{organizationId}");
            }

            if (!string.IsNullOrWhiteSpace(projectId))
            {
                AddSubProtocol(webSocket, subProtocols, $"openai-project.{projectId}");
            }

            return;
        }

        webSocket.Options.SetRequestHeader("Authorization", $"Bearer {apiKey}");

        if (!string.IsNullOrWhiteSpace(organizationId))
        {
            webSocket.Options.SetRequestHeader("OpenAI-Organization", organizationId);
        }

        if (!string.IsNullOrWhiteSpace(projectId))
        {
            webSocket.Options.SetRequestHeader("OpenAI-Project", projectId);
        }

        if (!string.IsNullOrWhiteSpace(safetyIdentifier))
        {
            webSocket.Options.SetRequestHeader("OpenAI-Safety-Identifier", safetyIdentifier);
        }
    }

    private void ApplyHeaders(
        ClientWebSocket webSocket,
        OpenAIRealtimeConnectOptions options,
        HashSet<string> subProtocols)
    {
        var useBetaHeader = options.UseBetaHeader ?? _config.UseBetaHeader;
        if (useBetaHeader)
        {
            var value = string.IsNullOrWhiteSpace(options.BetaHeaderValue)
                ? _config.BetaHeaderValue
                : options.BetaHeaderValue;
            webSocket.Options.SetRequestHeader("OpenAI-Beta", value);
        }

        if (options.AdditionalHeaders != null)
        {
            foreach (var header in options.AdditionalHeaders)
            {
                webSocket.Options.SetRequestHeader(header.Key, header.Value);
            }
        }

        if (options.AdditionalSubProtocols != null)
        {
            foreach (var subprotocol in options.AdditionalSubProtocols)
            {
                AddSubProtocol(webSocket, subProtocols, subprotocol);
            }
        }
    }

    private static void AddSubProtocol(ClientWebSocket webSocket, HashSet<string> subProtocols, string subprotocol)
    {
        if (string.IsNullOrWhiteSpace(subprotocol))
        {
            return;
        }

        if (subProtocols.Add(subprotocol))
        {
            webSocket.Options.AddSubProtocol(subprotocol);
        }
    }
}
