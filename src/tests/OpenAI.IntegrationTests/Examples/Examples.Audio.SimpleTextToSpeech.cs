namespace tryAGI.OpenAI.IntegrationTests.Examples;

public partial class Examples
{
    [Test]
    [Explicit]
    public async Task SimpleTextToSpeech()
    {
        using var api = GetAuthenticatedClient();
        
        byte[] bytes = await api.Audio.CreateSpeechAsync(
            model: CreateSpeechRequestModel.Tts1,
            input: "Overwatering is a common issue for those taking care of houseplants. To prevent it, it is"
                   + " crucial to allow the soil to dry out between waterings. Instead of watering on a fixed schedule,"
                   + " consider using a moisture meter to accurately gauge the soil’s wetness. Should the soil retain"
                   + " moisture, it is wise to postpone watering for a couple more days. When in doubt, it is often safer"
                   + " to water sparingly and maintain a less-is-more approach.",
            voice: VoiceIdsSharedEnum.Alloy);

        FileInfo fileInfo = new($"{Guid.NewGuid()}.mp3");
        
        await File.WriteAllBytesAsync(fileInfo.FullName, bytes);
        
        Console.WriteLine($"Audio available at:\n{new Uri(fileInfo.FullName).AbsoluteUri}");
    }
}
