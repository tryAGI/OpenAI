namespace OpenAI.IntegrationTests.Examples;

public partial class Examples
{
    [Test]
    [Explicit]
    public async Task CuriousCreatureCreator()
    {
        using var api = GetAuthenticatedClient();

        // First, we'll use gpt-4o to have a creative helper imagine a twist on a household pet
        CreateChatCompletionResponse creativeWriterResult = await api.Chat.CreateChatCompletionAsync(
            model: CreateChatCompletionRequestModel.Gpt4o,
            messages:
            [
                "You're a creative helper that specializes in brainstorming designs for concepts that fuse ordinary, mundane items with a fantastical touch. In particular, you can provide good one-paragraph descriptions of concept images.".AsSystemMessage(),
                "Imagine a household pet. Now add in a subtle touch of magic or 'different'. What do you imagine? Provide a one-paragraph description of a picture of this new creature, focusing on the details of the imagery such that it'd be suitable for creating a picture.",
            ],
            maxCompletionTokens: 2048);
        string description = creativeWriterResult.Choices[0].Message.Content ?? string.Empty;
        Console.WriteLine($"Creative helper's creature description:\n{description}");

        // Asynchronously, in parallel to the next steps, we'll get the creative description in the voice of Onyx
        byte[] imageDescriptionAudio = await api.Audio.CreateSpeechAsync(
            model: CreateSpeechRequestModel.Tts1Hd,
            input: description,
            voice: CreateSpeechRequestVoice.Onyx,
            speed: 1.1f,
            responseFormat: CreateSpeechRequestResponseFormat.Opus);
        FileInfo audioFileInfo = new FileInfo($"{creativeWriterResult.Id}-description.opus");
        
        await File.WriteAllBytesAsync(audioFileInfo.FullName, imageDescriptionAudio);
        
        Console.WriteLine($"Spoken description available at:\n{new Uri(audioFileInfo.FullName).AbsoluteUri}");

        // Meanwhile, we'll use dall-e-3 to generate a rendition of our LLM artist's vision
        ImagesResponse imageGenerationResult = await api.Images.CreateImageAsync(
            prompt: description,
            model: CreateImageRequestModel.DallE3,
            size: CreateImageRequestSize.x1792x1024,
            quality: CreateImageRequestQuality.Hd);
        Uri imageLocation = new Uri(imageGenerationResult.Data[0].Url ?? string.Empty);
        Console.WriteLine($"Creature image available at:\n{imageLocation.AbsoluteUri}");

        // Now, we'll use gpt vision to get a hopelessly taken assessment from a usually exigent art connoisseur
        CreateChatCompletionResponse criticalAppraisalResult = await api.Chat.CreateChatCompletionAsync(
            messages: [
                "Assume the role of an art critic. Although usually cranky and occasionally even referred to as a 'curmudgeon', you're somehow entirely smitten with the subject presented to you and, despite your best efforts, can't help but lavish praise when you're asked to appraise a provided image.".AsSystemMessage(),
                "Evaluate this image for me. What is it, and what do you think of it?",
                imageLocation,
            ],
            model: ChatClient.LatestSmartModel,
            maxCompletionTokens: 2048);
        string appraisal = criticalAppraisalResult.Choices[0].Message.Content ?? string.Empty;
        Console.WriteLine($"Critic's appraisal:\n{appraisal}");

        // Finally, we'll get that art expert's laudations in the voice of Fable
        byte[] appraisalAudioResult = await api.Audio.CreateSpeechAsync(
            input: appraisal,
            model: CreateSpeechRequestModel.Tts1Hd,
            voice: CreateSpeechRequestVoice.Fable,
            speed: 0.9f,
            responseFormat: CreateSpeechRequestResponseFormat.Opus);
        FileInfo criticAudioFileInfo = new($"{criticalAppraisalResult.Id}-appraisal.opus");
        
        await File.WriteAllBytesAsync(criticAudioFileInfo.FullName, appraisalAudioResult);
        
        Console.WriteLine($"Critical appraisal available at:\n{new Uri(criticAudioFileInfo.FullName).AbsoluteUri}");
    }
}
