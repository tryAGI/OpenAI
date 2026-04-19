using System.Net.WebSockets;

namespace tryAGI.OpenAI.Realtime;

public sealed partial class OpenAiRealtimeClient
{
    partial void Initialized(ClientWebSocket client)
    {
        client.Options.SetRequestHeader("OpenAI-Beta", "realtime=v1");
    }
}
