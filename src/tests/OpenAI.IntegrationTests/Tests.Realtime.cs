namespace OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Realtime()
    {
        using var realtimeConversationClient = GetAuthenticatedRealtimeClient();
        using var cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(15));
        var cancellationToken = cancellationTokenSource.Token;
        
        // await realtimeConversationClient.SendAsync("Hello, WebSocket!");
        await realtimeConversationClient.CreateResponseAsync(new RealtimeResponseCreate
        {
            Type = RealtimeResponseCreateType.ResponseCreate,
            Response = new RealtimeResponseCreateResponse
            {
                Modalities = [RealtimeResponseCreateResponseModalitie.Text],
                Instructions = "Please assist the user.",
            }
        }, cancellationToken);

        await foreach (RealtimeServerEvent receivedMessage in realtimeConversationClient.ReceiveUpdatesAsync(cancellationToken))
        {
            Console.WriteLine(value: "Message received. Type:" + receivedMessage.Type);
        }
    }
}
