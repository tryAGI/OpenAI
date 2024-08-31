namespace OpenAI.IntegrationTests.Examples;

public partial class Examples
{
    [Test]
    [Explicit]
    // TODO: Does not work yet
    public async Task VerboseTranscription()
    {
        using var api = GetAuthenticatedClient();
        
        OneOf<CreateTranscriptionResponseJson, CreateTranscriptionResponseVerboseJson> response = await api.Audio.CreateTranscriptionAsync(
            file: H.Resources.audio_houseplant_care_mp3.AsBytes(),
            filename: H.Resources.audio_houseplant_care_mp3.FileName,
            model: CreateTranscriptionRequestModel.Whisper1,
            responseFormat: CreateTranscriptionRequestResponseFormat.VerboseJson,
            timestampGranularities: [
                CreateTranscriptionRequestTimestampGranularitie.Word,
                CreateTranscriptionRequestTimestampGranularitie.Segment
            ]);

        response.Value2.Should().NotBeNull();
        
        Console.WriteLine("Transcription:");
        Console.WriteLine($"{response.Value2!.Text}");

        Console.WriteLine();
        Console.WriteLine($"Words:");
        foreach (TranscriptionWord word in response.Value2.Words ?? [])
        {
            Console.WriteLine($"  {word.Word,15} : {word.Start * 1000,5:0} - {word.End * 1000,5:0}");
        }

        Console.WriteLine();
        Console.WriteLine($"Segments:");
        foreach (TranscriptionSegment segment in response.Value2.Segments ?? [])
        {
            Console.WriteLine($"  {segment.Text,90} : {segment.Start * 1000,5:0} - {segment.End * 1000,5:0}");
        }
    }
}
