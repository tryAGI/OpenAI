namespace OpenAI.IntegrationTests.Examples;

public partial class Examples
{
    [Test]
    [Explicit]
    public async Task SimpleTranslation()
    {
        using var api = GetAuthenticatedClient();
        
        OneOf<CreateTranslationResponseJson, CreateTranslationResponseVerboseJson> response = await api.Audio.CreateTranslationAsync(
            file: H.Resources.audio_french_wav.AsBytes(),
            filename: H.Resources.audio_french_wav.FileName,
            model: CreateTranslationRequestModel.Whisper1);

        Console.WriteLine($"{response.Value1?.Text}");
    }
}
