namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [Test]
    [Explicit]
    public async Task Realtime()
    {
        using var realtimeConversationClient = GetAuthenticatedRealtimeClient();
        using var cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(15));
        var cancellationToken = cancellationTokenSource.Token;
        
        await realtimeConversationClient.SendAsync(new RealtimeResponseCreate
        {
            Type = RealtimeResponseCreateType.ResponseCreate,
            Response = new RealtimeResponseCreateResponse
            {
                Modalities = [RealtimeResponseCreateResponseModalitie.Text],
                Instructions = "Please assist the user.",
            }
        }.ToJson(realtimeConversationClient.JsonSerializerContext), cancellationToken);

        await foreach (RealtimeServerEvent receivedMessage in realtimeConversationClient.ReceiveUpdatesAsync(cancellationToken))
        {
            if (receivedMessage.IsSessionCreated)
            {
                Console.WriteLine($"Session created. ID: {receivedMessage.SessionCreated.EventId}");
                Console.WriteLine(receivedMessage.SessionCreated.Session?.ToJson(realtimeConversationClient.JsonSerializerContext));
            }
            else if (receivedMessage.IsResponseCreated)
            {
                Console.WriteLine($"Response created. ID: {receivedMessage.ResponseCreated.EventId}");
                Console.WriteLine(receivedMessage.ResponseCreated.Response?.ToJson(realtimeConversationClient.JsonSerializerContext));
            }
            else if (receivedMessage.IsRateLimitsUpdated)
            {
                Console.WriteLine($"Response updated. ID: {receivedMessage.RateLimitsUpdated.EventId}");
                Console.WriteLine(receivedMessage.RateLimitsUpdated.ToJson(realtimeConversationClient.JsonSerializerContext));
            }
            else if (receivedMessage.IsError)
            {
                Console.WriteLine($"Error. ID: {receivedMessage.Error.EventId}");
                Console.WriteLine(receivedMessage.Error.Error?.ToJson(realtimeConversationClient.JsonSerializerContext));
            }
            else
            {
                Console.WriteLine($"Unknown message: {receivedMessage.ToJson(realtimeConversationClient.JsonSerializerContext)}");
            }
        }
    }
}
