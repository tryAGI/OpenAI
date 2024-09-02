namespace OpenAI.IntegrationTests.Examples;

public partial class Examples
{
    [Test]
    [Explicit]
    public async Task AssistantsWithVision()
    {
        using var api = GetAuthenticatedClient();

        ImagesResponse appleImage = await api.Images.CreateImageAsync(
            prompt: "picture of apple",
            responseFormat: CreateImageRequestResponseFormat.B64Json);
        byte[] appleBytes = appleImage.Data[0].Bytes;

        FileInfo appleFileInfo = new($"{Guid.NewGuid()}.png");
        
        await File.WriteAllBytesAsync(appleFileInfo.FullName, appleBytes);
        
        Console.WriteLine($"Apple image available at:\n{new Uri(appleFileInfo.FullName).AbsoluteUri}");
        
        ImagesResponse orangeImage = await api.Images.CreateImageAsync(
            prompt: "picture of orange",
            responseFormat: CreateImageRequestResponseFormat.B64Json);
        byte[] orangeBytes = orangeImage.Data[0].Bytes;

        FileInfo orangeFileInfo = new($"{Guid.NewGuid()}.png");
        
        await File.WriteAllBytesAsync(orangeFileInfo.FullName, orangeBytes);
        
        Console.WriteLine($"Orange image available at:\n{new Uri(orangeFileInfo.FullName).AbsoluteUri}");
        
        OpenAIFile pictureOfAppleFile = await api.Files.CreateFileAsync(
            file: appleBytes,
            filename: appleFileInfo.Name,
            purpose: CreateFileRequestPurpose.Vision);
        OpenAIFile pictureOfOrangeFile = await api.Files.CreateFileAsync(
            file: orangeBytes,
            filename: orangeFileInfo.Name,
            purpose: CreateFileRequestPurpose.Vision);

        AssistantObject assistant = await api.Assistants.CreateAssistantAsync(
            model: CreateAssistantRequestModel.Gpt4o,
            instructions: "When asked a question, attempt to answer very concisely. " +
                          "Prefer one-sentence answers whenever feasible.");

        ThreadObject thread = await api.Assistants.CreateThreadAsync(new CreateThreadRequest
        {
            Messages = [
                "Hello, assistant! Please compare these two images for me:",
                pictureOfAppleFile,
                pictureOfOrangeFile,
            ]
        });
        
        var streamingUpdates = api.Assistants.CreateRunAsStreamAsync(
            threadId: thread.Id,
            assistantId: assistant.Id,
            instructions: "When possible, try to sneak in puns if you're asked to compare things.");
        
        await foreach (AssistantStreamEvent streamingUpdate in streamingUpdates)
        {
            if (streamingUpdate.Run is {} run)
            {
                if (run.Value1 is { Event: RunStreamEventVariant1Event.ThreadRunCreated })
                {
                    Console.WriteLine("--- Run created! ---");
                }
            }
            if (streamingUpdate.Message is {} message)
            {
                if (message.Value3 is
                    {
                        Event: MessageStreamEventVariant3Event.ThreadMessageDelta
                    } delta)
                {
                    foreach (var deltaVariation in delta.Data.Delta.Content ?? [])
                    {
                        if (deltaVariation.Value1 is {} imageFile)
                        {
                            Console.WriteLine();
                            Console.WriteLine(imageFile.ImageFile?.FileId);
                        }
                        if (deltaVariation.Value2 is {} text)
                        {
                            Console.Write(text.Text?.Value);
                        }
                        if (deltaVariation.Value3 is {} refusal)
                        {
                            Console.WriteLine();
                            Console.WriteLine(refusal.Refusal);
                        }
                        if (deltaVariation.Value4 is {} imageUrl)
                        {
                            Console.WriteLine();
                            Console.WriteLine(imageUrl.ImageUrl?.Url);
                        }
                    }
                }
            }
        }

        _ = await api.Files.DeleteFileAsync(pictureOfAppleFile.Id);
        _ = await api.Assistants.DeleteThreadAsync(thread.Id);
        _ = await api.Assistants.DeleteAssistantAsync(assistant.Id);
    }
}
