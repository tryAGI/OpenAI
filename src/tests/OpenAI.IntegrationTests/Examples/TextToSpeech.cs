/*
order: 70
title: Text To Speech
slug: text-to-speech

Convert text to speech audio using streaming.
*/

namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_TextToSpeech()
    {
        using var client = GetAuthenticatedClient();

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
    }
}
