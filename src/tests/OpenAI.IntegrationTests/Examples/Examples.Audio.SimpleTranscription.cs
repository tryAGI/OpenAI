namespace tryAGI.OpenAI.IntegrationTests.Examples;

public partial class Examples
{
    [Test]
    [Explicit]
    public async Task SimpleTranscription()
    {
        using var api = GetAuthenticatedClient();
        
        OneOf<CreateTranscriptionResponseJson, CreateTranscriptionResponseVerboseJson> response = await api.Audio.CreateTranscriptionAsync(
            file: H.Resources.audio_houseplant_care_mp3.AsBytes(),
            filename: H.Resources.audio_houseplant_care_mp3.FileName,
            model: CreateTranscriptionRequestModel.Whisper1);

        Console.WriteLine($"{response.Value1?.Text}");
    }
}
