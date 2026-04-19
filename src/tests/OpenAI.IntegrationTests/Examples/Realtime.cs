/*
order: 75
title: Realtime
slug: realtime

Connect to the Realtime API with the generated WebSocket client and wait for the initial session event.
*/

using tryAGI.OpenAI.Realtime;

namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_Realtime()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("OPENAI_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("OPENAI_API_KEY environment variable is not found.");
        var model =
            Environment.GetEnvironmentVariable("OPENAI_REALTIME_MODEL") is { Length: > 0 } modelValue
                ? modelValue
                : "gpt-4o-realtime-preview";

        using var client = new OpenAiRealtimeClient(apiKey);
        using var cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(30));
        var cancellationToken = cancellationTokenSource.Token;

        await client.ConnectAsync(model: model, cancellationToken: cancellationToken);
        client.IsConnected.Should().BeTrue();

        await foreach (var serverEvent in client.ReceiveUpdatesAsync(cancellationToken))
        {
            if (serverEvent.IsSessionCreated)
            {
                serverEvent.SessionCreated.Should().NotBeNull();
                Console.WriteLine(serverEvent.SessionCreated!.EventId);
                return;
            }

            if (serverEvent.IsError)
            {
                throw new AssertFailedException(
                    $"Realtime connection returned an error: {serverEvent.Error!.Error.Message}");
            }
        }

        throw new AssertFailedException("Realtime connection did not produce a session.created event before timing out.");
    }
}
