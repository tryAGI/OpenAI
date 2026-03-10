namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CreateSpeech_Url()
    {
        var api = GetAuthorizedApi();

        using var memoryStream = new MemoryStream();
        await foreach (var streamEvent in api.Audio.CreateSpeechAsStreamAsync(
            model: CreateSpeechRequestModel.Gpt4oMiniTts,
            input: "Create speech test is successful.",
            voice: (VoiceIdsShared)VoiceIdsSharedEnum.Alloy,
            responseFormat: CreateSpeechRequestResponseFormat.Mp3,
            speed: 1.0,
            streamFormat: CreateSpeechRequestStreamFormat.Sse))
        {
            if (streamEvent.SpeechAudioDelta is { } delta)
            {
                byte[] chunk = Convert.FromBase64String(delta.Audio);
                memoryStream.Write(chunk, 0, chunk.Length);
            }
        }

        byte[] response = memoryStream.ToArray();
        response.Should().NotBeNull();
        response.Length.Should().BeGreaterThan(0);

        Console.WriteLine($"Generated {response.Length} bytes of audio.");
    }
}
