namespace OpenAI.IntegrationTests.Examples;

public partial class Examples
{
    [Test]
    [Explicit]
    public async Task AlpacaArtAssessor()
    {
        using var api = GetAuthenticatedClient();
        
        // First, we create an image using dall-e-3:
        ImagesResponse imageResult = await api.Images.CreateImageAsync(
            prompt: "a majestic alpaca on a mountain ridge, backed by an expansive blue sky accented with sparse clouds",
            model: CreateImageRequestModel.DallE3,
            style: CreateImageRequestStyle.Vivid,
            quality: CreateImageRequestQuality.Hd,
            size: CreateImageRequestSize.x1792x1024);
        Image imageGeneration = imageResult.Data[0];
        Console.WriteLine($"Majestic alpaca available at:\n{imageGeneration.Url}");

        // Now, we'll ask a cranky art critic to evaluate the image using gpt vision:
        CreateChatCompletionResponse chatCompletion = await api.Chat.CreateChatCompletionAsync(
            messages: [
                ("Assume the role of a cranky art critic. When asked to describe or " +
                 "evaluate imagery, focus on criticizing elements of subject, composition, and other details.").AsSystemMessage(),
                "describe the following image in a few sentences",
                new Uri(imageGeneration.Url ?? string.Empty),
            ],
            model: ChatClient.LatestSmartModel,
            maxTokens: 2048);

        string chatResponseText = chatCompletion.Choices[0].Message.Content ?? string.Empty;
        Console.WriteLine($"Art critique of majestic alpaca:\n{chatResponseText}");

        // Finally, we'll get some text-to-speech for that critical evaluation using tts-1-hd:
        byte[] ttsResult = await api.Audio.CreateSpeechAsync(
            input: chatResponseText,
            model: CreateSpeechRequestModel.Tts1Hd,
            voice: CreateSpeechRequestVoice.Fable,
            speed: 0.9f,
            responseFormat: CreateSpeechRequestResponseFormat.Opus);
        FileInfo ttsFileInfo = new($"{chatCompletion.Id}.opus");
        
        await File.WriteAllBytesAsync(ttsFileInfo.FullName, ttsResult);
        
        Console.WriteLine($"Alpaca evaluation audio available at:\n{new Uri(ttsFileInfo.FullName).AbsoluteUri}");
    }
}
