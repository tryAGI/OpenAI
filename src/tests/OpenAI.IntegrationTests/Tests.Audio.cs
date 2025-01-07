using System.Diagnostics;

namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CreateSpeech_Url()
    {
        var api = GetAuthorizedApi();
        var response = await api.Audio.CreateSpeechAsync(
            model: CreateSpeechRequestModel.Tts1,
            input: "Create speech test is successful.",
            voice: CreateSpeechRequestVoice.Alloy,
            responseFormat: CreateSpeechRequestResponseFormat.Mp3,
            speed: 1.0);
        response.Should().NotBeNull();

        var path = Path.Combine(Path.GetTempPath(), "mp3.mp3");
        await File.WriteAllBytesAsync(path, response);
        
        Process.Start(new ProcessStartInfo(path)
        {
            UseShellExecute = true,
        });
        
        var response2 = await api.Audio.CreateTranslationAsync(
            file: response,
            filename: "mp3.mp3",
            model: CreateTranslationRequestModel.Whisper1,
            prompt: null,
            responseFormat: AudioResponseFormat.Json,
            temperature: 0.0);
        response2.Should().NotBeNull();
        response2.Object.Should().BeOfType<CreateTranslationResponseJson>();
        response2.IsValue1.Should().BeTrue();
        response2.Value1.Should().NotBeNull();
        response2.Value1!.Text.Should().Be("Create speech test is successful.");
        
        var response3 = await api.Audio.CreateTranscriptionAsync(
            file: response,
            filename: "mp3.mp3",
            model: CreateTranscriptionRequestModel.Whisper1,
            language: "en",   
            prompt: null,
            responseFormat: AudioResponseFormat.Json,
            temperature: 0.0);
        response3.Should().NotBeNull();
        response3.Object.Should().BeOfType<CreateTranscriptionResponseJson>();
        response3.IsValue1.Should().BeTrue();
        response3.Value1.Should().NotBeNull();
        response3.Value1!.Text.Should().Be("Create speech test is successful.");
    }
}
