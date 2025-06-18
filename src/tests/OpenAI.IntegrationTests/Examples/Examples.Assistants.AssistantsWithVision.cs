using System.Diagnostics.CodeAnalysis;

namespace tryAGI.OpenAI.IntegrationTests.Examples;

public partial class Examples
{
    [Test]
    [Explicit]
    [Experimental("OPENAI_BETA_001")]
    public async Task AssistantsWithVision()
    {
        using var api = GetAuthenticatedClient();

        ImagesResponse appleImage = await api.Images.CreateImageAsync(
            prompt: "picture of apple",
            responseFormat: CreateImageRequestResponseFormat.B64Json);
        byte[] appleBytes = appleImage.Data?[0].Bytes ?? [];

        FileInfo appleFileInfo = new($"{Guid.NewGuid()}.png");
        
        await File.WriteAllBytesAsync(appleFileInfo.FullName, appleBytes);
        
        Console.WriteLine($"Apple image available at:\n{new Uri(appleFileInfo.FullName).AbsoluteUri}");
        
        Console.WriteLine($"Orange image available at:\n{new Uri("https://raw.githubusercontent.com/tryAGI/OpenAI/d237b700b03fe9913a6ff53fa623041e87705f2f/assets/orange.png")}");
        
        OpenAIFile pictureOfAppleFile = await api.Files.CreateFileAsync(
            file: appleBytes,
            filename: appleFileInfo.Name,
            purpose: CreateFileRequestPurpose.Vision);

        AssistantObject assistant = await api.Assistants.CreateAssistantAsync(
            model: AssistantSupportedModels.Gpt4o,
            instructions: "When asked a question, attempt to answer very concisely. " +
                          "Prefer one-sentence answers whenever feasible.");

        ThreadObject thread = await api.Assistants.CreateThreadAsync(new CreateThreadRequest
        {
            Messages = [
                "Hello, assistant! Please compare these two images for me:",
                pictureOfAppleFile,
                new Uri("https://raw.githubusercontent.com/tryAGI/OpenAI/d237b700b03fe9913a6ff53fa623041e87705f2f/assets/orange.png"),
            ]
        });
        
        var streamingUpdates = api.Assistants.CreateRunAsStreamAsync(
            threadId: thread.Id,
            assistantId: assistant.Id,
            instructions: "When possible, try to sneak in puns if you're asked to compare things.");
        
        await foreach (AssistantStreamEvent streamingUpdate in streamingUpdates)
        {
            if (streamingUpdate.Error is {} error)
            {
                Console.WriteLine("--- Error ---");
                Console.WriteLine($"Message: {error.Data.Message}");
                Console.WriteLine($"Code: {error.Data.Code}");
                Console.WriteLine($"Type: {error.Data.Type}");
            }
            if (streamingUpdate.Run?.Value1 is not null)
            {
                Console.WriteLine("--- Run created! ---");
            }
            if (streamingUpdate.Message?.Value3 is {} delta)
            {
                foreach (var deltaVariation in delta.Data.Delta.Content ?? [])
                {
                    if (deltaVariation.Value1?.ImageFile is {} imageFile)
                    {
                        Console.WriteLine();
                        Console.WriteLine(imageFile?.FileId);
                    }
                    if (deltaVariation.Value2?.Text is {} text)
                    {
                        Console.Write(text.Value);
                    }
                    if (deltaVariation.Value3?.Refusal is {} refusal)
                    {
                        Console.WriteLine();
                        Console.WriteLine(refusal);
                    }
                    if (deltaVariation.Value4?.ImageUrl is {} imageUrl)
                    {
                        Console.WriteLine();
                        Console.WriteLine(imageUrl.Url);
                    }
                }
            }
        }

        _ = await api.Files.DeleteFileAsync(pictureOfAppleFile.Id);
        _ = await api.Assistants.DeleteThreadAsync(thread.Id);
        _ = await api.Assistants.DeleteAssistantAsync(assistant.Id);
    }
}
