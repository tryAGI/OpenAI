# Text To Speech

Convert text to speech audio using streaming.

This example assumes `using tryAGI.OpenAI;` is in scope and `apiKey` contains your tryAGI.OpenAI API key.

```csharp
using var client = new OpenAiClient(apiKey);

using var memoryStream = new MemoryStream();
await foreach (var streamEvent in client.Audio.CreateSpeechAsync(
    model: CreateSpeechRequestModel.Gpt4oMiniTts,
    input: "Hello! This is a text-to-speech test.",
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

byte[] audio = memoryStream.ToArray();

Console.WriteLine($"Generated {audio.Length} bytes of audio.");
```