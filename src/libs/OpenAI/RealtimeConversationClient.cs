using System.Net.WebSockets;
using System.Runtime.CompilerServices;

namespace OpenAI;

public partial class RealtimeConversationClient
{
    partial void Authorized(
        global::System.Net.WebSockets.ClientWebSocket client)
    {
        client.Options.SetRequestHeader("OpenAI-Beta", "realtime=v1");
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async IAsyncEnumerable<RealtimeServerEventBase> ReceiveUpdatesAsync(
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        if (!IsConnected)
        {
            await ConnectAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        
        var buffer = new byte[1024 * 1024]; // 1MB buffer size
        var arraySegment = new ArraySegment<byte>(buffer);

        while (_clientWebSocket.State == WebSocketState.Open)
        {
            if (cancellationToken.IsCancellationRequested)
            {
                yield break;
            }
            
            WebSocketReceiveResult result;

            try
            {
                result = await _clientWebSocket.ReceiveAsync(arraySegment, cancellationToken).ConfigureAwait(false);
            }
            catch (WebSocketException wex)
            {
                Console.WriteLine($"WebSocket error: {wex.Message}");
                yield break;
            }
            catch (OperationCanceledException)
            {
                yield break;
            }

            if (result.MessageType == WebSocketMessageType.Text)
            {
                string json = global::System.Text.Encoding.UTF8.GetString(buffer, 0, result.Count);
                var @event = global::OpenAI.RealtimeServerEventBase.FromJson(json, JsonSerializerContext) ??
                             throw new global::System.InvalidOperationException($"Response deserialization failed for \"{json}\" ");

                yield return @event;
            }
            else if (result.MessageType == WebSocketMessageType.Close)
            {
                await _clientWebSocket.CloseAsync(
                    closeStatus: WebSocketCloseStatus.NormalClosure,
                    statusDescription: "Closing",
                    cancellationToken: cancellationToken).ConfigureAwait(false);
                yield break;
            }
        }
    }
}