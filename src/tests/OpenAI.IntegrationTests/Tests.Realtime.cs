namespace OpenAI.IntegrationTests;

public partial class Tests
{
    [Test]
    [Explicit]
    public async Task Realtime()
    {
        using var realtimeConversationClient = GetAuthenticatedRealtimeClient();
        using var cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(15));
        var cancellationToken = cancellationTokenSource.Token;
        
        // await realtimeConversationClient.SendAsync("Hello, WebSocket!");
        await realtimeConversationClient.SendAsync(new RealtimeResponseCreate
        {
            Type = RealtimeResponseCreateType.ResponseCreate,
            Response = new RealtimeResponseCreateResponse
            {
                Modalities = [RealtimeResponseCreateResponseModalitie.Text],
                Instructions = "Please assist the user.",
            }
        }.ToJson(realtimeConversationClient.JsonSerializerContext), cancellationToken);

        await foreach (RealtimeServerEventBase receivedMessage in realtimeConversationClient.ReceiveUpdatesAsync(cancellationToken))
        {
            Console.WriteLine(value: "Message received. Type:" + receivedMessage.Type);
        }
    }
}
