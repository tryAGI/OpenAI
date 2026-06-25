using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Logging;

namespace tryAGI.OpenAI.OpenAISharp.Realtime;

/// <summary>
/// Represents a realtime OpenAI WebSocket session.
/// </summary>
public sealed class OpenAIRealtimeSession : IAsyncDisposable
{
    private readonly ClientWebSocket _webSocket;
    private readonly ILogger _logger;
    private readonly SemaphoreSlim _receiveLock = new(1, 1);
    private bool _disposed;

    /// <summary>
    /// Status code from the server-initiated close frame, or null if the WebSocket
    /// has not received a close frame yet. Set inside <c>ReceiveTextMessageAsync</c>
    /// when the server closes; consumers can read it after <c>ReadEventsAsync</c>
    /// finishes to learn why the session ended.
    /// </summary>
    public WebSocketCloseStatus? LastCloseStatus { get; private set; }

    /// <summary>
    /// Description text from the server-initiated close frame (often a JSON-ish blob
    /// containing the OpenAI error <c>type</c> / <c>code</c> / <c>message</c>),
    /// or null if no close frame has been received.
    /// </summary>
    public string? LastCloseStatusDescription { get; private set; }

    internal OpenAIRealtimeSession(ClientWebSocket webSocket, ILogger logger)
    {
        _webSocket = webSocket;
        _logger = logger;
    }

    /// <summary>
    /// Sends a client event over the WebSocket using source-generated metadata.
    /// </summary>
    public Task SendEventAsync(OpenAIRealtimeClientEvent payload, CancellationToken cancellationToken = default)
    {
        var json = JsonSerializer.Serialize(payload, JsonContext.Default.OpenAIRealtimeClientEvent);
        return SendTextAsync(json, cancellationToken);
    }

    /// <summary>
    /// Sends PCM16 audio bytes as an input audio buffer append event.
    /// </summary>
    public Task SendInputAudioAsync(ReadOnlyMemory<byte> audioBytes, CancellationToken cancellationToken = default)
    {
        var message = new OpenAIRealtimeInputAudioBufferAppendEvent
        {
            Audio = Convert.ToBase64String(audioBytes.Span)
        };

        return SendEventAsync(message, cancellationToken);
    }

    /// <summary>
    /// Sends PCM16 audio samples as an input audio buffer append event.
    /// </summary>
    public Task SendInputAudioAsync(ReadOnlySpan<short> samples, CancellationToken cancellationToken = default)
    {
        var bytes = MemoryMarshal.AsBytes(samples);
        var message = new OpenAIRealtimeInputAudioBufferAppendEvent
        {
            Audio = Convert.ToBase64String(bytes)
        };

        return SendEventAsync(message, cancellationToken);
    }

    /// <summary>
    /// Commits the current input audio buffer.
    /// </summary>
    public Task CommitInputAudioAsync(CancellationToken cancellationToken = default)
        => SendEventAsync(new OpenAIRealtimeInputAudioBufferCommitEvent(), cancellationToken);

    /// <summary>
    /// Clears the current input audio buffer.
    /// </summary>
    public Task ClearInputAudioAsync(CancellationToken cancellationToken = default)
        => SendEventAsync(new OpenAIRealtimeInputAudioBufferClearEvent(), cancellationToken);

    /// <summary>
    /// Clears the current output audio buffer for transports that support server-side playback buffers.
    /// </summary>
    public Task ClearOutputAudioAsync(CancellationToken cancellationToken = default)
        => SendEventAsync(new OpenAIRealtimeOutputAudioBufferClearEvent(), cancellationToken);

    /// <summary>
    /// Sends PCM16 audio bytes to a dedicated translation session.
    /// </summary>
    public Task SendSessionInputAudioAsync(ReadOnlyMemory<byte> audioBytes, CancellationToken cancellationToken = default)
    {
        var message = new OpenAIRealtimeSessionInputAudioBufferAppendEvent
        {
            Audio = Convert.ToBase64String(audioBytes.Span)
        };

        return SendEventAsync(message, cancellationToken);
    }

    /// <summary>
    /// Sends PCM16 audio samples to a dedicated translation session.
    /// </summary>
    public Task SendSessionInputAudioAsync(ReadOnlySpan<short> samples, CancellationToken cancellationToken = default)
    {
        var bytes = MemoryMarshal.AsBytes(samples);
        var message = new OpenAIRealtimeSessionInputAudioBufferAppendEvent
        {
            Audio = Convert.ToBase64String(bytes)
        };

        return SendEventAsync(message, cancellationToken);
    }

    /// <summary>
    /// Sends a session update event.
    /// </summary>
    public Task SendSessionUpdateAsync(OpenAIRealtimeSessionUpdate session, CancellationToken cancellationToken = default)
        => SendEventAsync(new OpenAIRealtimeSessionUpdateEvent { Session = session }, cancellationToken);

    /// <summary>
    /// Sends a response.create event.
    /// </summary>
    public Task SendResponseCreateAsync(OpenAIRealtimeResponse response, CancellationToken cancellationToken = default)
        => SendEventAsync(new OpenAIRealtimeResponseCreateEvent { Response = response }, cancellationToken);

    /// <summary>
    /// Sends a conversation.item.create event.
    /// </summary>
    public Task SendConversationItemCreateAsync(OpenAIRealtimeConversationItem item, CancellationToken cancellationToken = default)
        => SendEventAsync(new OpenAIRealtimeConversationItemCreateEvent { Item = item }, cancellationToken);

    /// <summary>
    /// Sends a conversation.item.delete event.
    /// </summary>
    public Task SendConversationItemDeleteAsync(string itemId, CancellationToken cancellationToken = default)
        => SendEventAsync(new OpenAIRealtimeConversationItemDeleteEvent { ItemId = itemId }, cancellationToken);

    /// <summary>
    /// Sends a conversation.item.truncate event.
    /// </summary>
    public Task SendConversationItemTruncateAsync(string itemId, int? contentIndex = null, int? audioEndMs = null, CancellationToken cancellationToken = default)
        => SendEventAsync(new OpenAIRealtimeConversationItemTruncateEvent { ItemId = itemId, ContentIndex = contentIndex, AudioEndMs = audioEndMs }, cancellationToken);

    /// <summary>
    /// Sends a response.cancel event to cancel the current in-progress response.
    /// </summary>
    public Task SendResponseCancelAsync(CancellationToken cancellationToken = default)
        => SendEventAsync(new OpenAIRealtimeResponseCancelEvent(), cancellationToken);

    /// <summary>
    /// Sends a transcription_session.update event for audio input configuration.
    /// </summary>
    public Task SendTranscriptionSessionUpdateAsync(
        OpenAIRealtimeTranscriptionSessionUpdate session,
        CancellationToken cancellationToken = default)
        => SendEventAsync(new OpenAIRealtimeTranscriptionSessionUpdateEvent { Session = session }, cancellationToken);

    /// <summary>
    /// Reads a single realtime event from the WebSocket.
    /// </summary>
    public async Task<OpenAIRealtimeEvent?> ReceiveEventAsync(CancellationToken cancellationToken = default)
    {
        var json = await ReceiveTextMessageAsync(cancellationToken);
        if (json == null)
        {
            return null;
        }

        return OpenAIRealtimeEventParser.Parse(json);
    }

    /// <summary>
    /// Streams realtime events until the WebSocket closes.
    /// </summary>
    public async IAsyncEnumerable<OpenAIRealtimeEvent> ReadEventsAsync(
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        while (_webSocket.State == WebSocketState.Open && !cancellationToken.IsCancellationRequested)
        {
            var json = await ReceiveTextMessageAsync(cancellationToken);
            if (json == null)
            {
                yield break;
            }

            yield return OpenAIRealtimeEventParser.Parse(json);
        }
    }

    private async Task SendTextAsync(string json, CancellationToken cancellationToken)
    {
        var payload = Encoding.UTF8.GetBytes(json);
        await _webSocket.SendAsync(
            new ArraySegment<byte>(payload),
            WebSocketMessageType.Text,
            endOfMessage: true,
            cancellationToken);
    }

    private async Task<string?> ReceiveTextMessageAsync(CancellationToken cancellationToken)
    {
        await _receiveLock.WaitAsync(cancellationToken);
        try
        {
            var buffer = new byte[8192];
            using var ms = new MemoryStream();

            while (true)
            {
                var result = await _webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), cancellationToken);

                if (result.MessageType == WebSocketMessageType.Close)
                {
                    LastCloseStatus = result.CloseStatus;
                    LastCloseStatusDescription = result.CloseStatusDescription;
                    _logger.LogWarning(
                        "[OpenAI] WebSocket closed by server: {Status} {Description}",
                        result.CloseStatus,
                        result.CloseStatusDescription);
                    return null;
                }

                if (result.MessageType == WebSocketMessageType.Binary)
                {
                    _logger.LogDebug("[OpenAI] Ignoring binary message with {Length} bytes", result.Count);
                    while (!result.EndOfMessage)
                    {
                        result = await _webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), cancellationToken);
                        if (result.MessageType == WebSocketMessageType.Close)
                        {
                            LastCloseStatus = result.CloseStatus;
                            LastCloseStatusDescription = result.CloseStatusDescription;
                            return null;
                        }
                    }

                    continue;
                }

                ms.Write(buffer, 0, result.Count);

                if (result.EndOfMessage)
                {
                    break;
                }
            }

            return Encoding.UTF8.GetString(ms.ToArray());
        }
        finally
        {
            _receiveLock.Release();
        }
    }

    public async ValueTask DisposeAsync()
    {
        if (_disposed)
        {
            return;
        }

        _disposed = true;

        if (_webSocket.State == WebSocketState.Open)
        {
            try
            {
                await _webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Closing", CancellationToken.None);
            }
            catch (WebSocketException ex)
            {
                _logger.LogWarning(ex, "[OpenAI] WebSocket close failed.");
            }
        }

        _receiveLock.Dispose();
        _webSocket.Dispose();
    }
}
