using System.Reflection;
using tryAGI.OpenAI.OpenAISharp;

namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void OpenAISharp_BuildUri_RealtimeSession_AddsModelQuery()
    {
        var uri = BuildOpenAISharpUri(new OpenAIRealtimeConnectOptions
        {
            Model = OpenAIRealtimeModelIds.GptRealtime2,
        });

        uri.ToString().Should().Be("wss://api.openai.com/v1/realtime?existing=1&model=gpt-realtime-2");
    }

    [TestMethod]
    public void OpenAISharp_BuildUri_TranscriptionSession_UsesIntentInsteadOfModel()
    {
        var uri = BuildOpenAISharpUri(new OpenAIRealtimeConnectOptions
        {
            Model = OpenAIRealtimeModelIds.GptRealtimeWhisper,
            SessionKind = OpenAIRealtimeSessionKind.Transcription,
        });

        uri.ToString().Should().Be("wss://api.openai.com/v1/realtime?existing=1&intent=transcription");
        uri.Query.Should().NotContain("model=");
    }

    [TestMethod]
    public void OpenAISharp_BuildUri_TranslationSession_AppendsTranslationsPathAndModel()
    {
        var uri = BuildOpenAISharpUri(new OpenAIRealtimeConnectOptions
        {
            Model = OpenAIRealtimeModelIds.GptRealtimeTranslate,
            SessionKind = OpenAIRealtimeSessionKind.Translation,
        });

        uri.ToString().Should().Be("wss://api.openai.com/v1/realtime/translations?existing=1&model=gpt-realtime-translate");
    }

    private static Uri BuildOpenAISharpUri(OpenAIRealtimeConnectOptions options)
    {
        using var client = OpenAIClient.Create(new OpenAIConfig
        {
            ApiKey = "test-api-key",
            BaseUrl = new Uri("wss://api.openai.com/v1/realtime?existing=1"),
        });
        var method = client.Realtime.GetType().GetMethod("BuildUri", BindingFlags.Instance | BindingFlags.NonPublic);
        method.Should().NotBeNull();

        return (Uri)method!.Invoke(client.Realtime, [options])!;
    }
}
