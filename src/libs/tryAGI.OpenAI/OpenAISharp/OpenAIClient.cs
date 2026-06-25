using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using tryAGI.OpenAI.OpenAISharp.Services;

namespace tryAGI.OpenAI.OpenAISharp;

/// <summary>
/// Main client for interacting with OpenAI Realtime API.
/// </summary>
public sealed class OpenAIClient : IDisposable
{
    private bool _disposed;

    /// <summary>
    /// The configuration used by this client.
    /// </summary>
    public OpenAIConfig Config { get; }

    /// <summary>
    /// Realtime WebSocket service.
    /// </summary>
    public OpenAIRealtimeService Realtime { get; }

    private OpenAIClient(OpenAIConfig config, ILogger logger)
    {
        Config = config;
        Realtime = new OpenAIRealtimeService(config, logger);
    }

    /// <summary>
    /// Creates a client using an API key and default configuration.
    /// </summary>
    public static OpenAIClient Create(string apiKey)
        => Create(OpenAIConfig.FromApiKey(apiKey));

    /// <summary>
    /// Creates a client with the specified configuration.
    /// </summary>
    public static OpenAIClient Create(OpenAIConfig config)
        => Create(config, NullLogger.Instance);

    /// <summary>
    /// Creates a client with the specified configuration and logger.
    /// </summary>
    public static OpenAIClient Create(OpenAIConfig config, ILogger logger)
        => new(config, logger);

    /// <inheritdoc />
    public void Dispose()
    {
        if (_disposed)
        {
            return;
        }

        _disposed = true;
    }
}
