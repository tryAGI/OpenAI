using tryAGI.OpenAI.OpenAISharp;

namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [TestCategory("Explicit")]
    public async Task OpenAISharp_Live_PrimaryWebSocket_StartsGptLive1Session()
    {
        if (!string.Equals(
                Environment.GetEnvironmentVariable("OPENAI_LIVE_E2E"),
                "true",
                StringComparison.OrdinalIgnoreCase))
        {
            throw new AssertInconclusiveException("Set OPENAI_LIVE_E2E=true to run the metered GPT-Live E2E test.");
        }

        var apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY") is { Length: > 0 } value
            ? value
            : throw new AssertInconclusiveException("OPENAI_API_KEY environment variable is not found.");

        using var client = OpenAIClient.Create(apiKey);
        await using var session = await client.Realtime.ConnectAsync(new OpenAIRealtimeConnectOptions
        {
            Model = "gpt-live-1",
            SessionKind = OpenAIRealtimeSessionKind.Live,
        });

        await session.StartLiveSessionAsync(new OpenAILiveSessionConfiguration
        {
            Model = "gpt-live-1",
            Instructions = "Acknowledge startup briefly.",
            Audio = new OpenAILiveAudioConfiguration
            {
                Output = new OpenAILiveAudioOutputConfiguration { Voice = "marin" },
            },
            Delegation = OpenAILiveDelegation.Client(),
        });

        using var timeout = new CancellationTokenSource(TimeSpan.FromSeconds(30));
        var started = await session.ReceiveEventAsync(timeout.Token);

        started.Should().NotBeNull();
        started!.Type.Should().Be("session.started");
        started.RawJson.Should().Contain("\"model\":\"gpt-live-1\"");
    }
}
