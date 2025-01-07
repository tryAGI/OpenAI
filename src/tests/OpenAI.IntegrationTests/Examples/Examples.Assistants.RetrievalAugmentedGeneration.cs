using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace tryAGI.OpenAI.IntegrationTests.Examples;

public partial class Examples
{
    [Test]
    [Explicit]
    [Experimental("OPENAI_BETA_001")]
    public async Task RetrievalAugmentedGeneration()
    {
        using var api = GetAuthenticatedClient();
        
        // First, let's contrive a document we'll use retrieval with and upload it.
        string document = /* language=json */
            """
            {
                "description": "This document contains the sale history data for Contoso products.",
                "sales": [
                    {
                        "month": "January",
                        "by_product": {
                            "113043": 15,
                            "113045": 12,
                            "113049": 2
                        }
                    },
                    {
                        "month": "February",
                        "by_product": {
                            "113045": 22
                        }
                    },
                    {
                        "month": "March",
                        "by_product": {
                            "113045": 16,
                            "113055": 5
                        }
                    }
                ]
            }
            """;

        OpenAIFile salesFile = await api.Files.CreateFileAsync(
            file: Encoding.UTF8.GetBytes(document),
            filename: "monthly_sales.json",
            purpose: CreateFileRequestPurpose.Assistants);

        AssistantObject assistant = await api.Assistants.CreateAssistantAsync(
            model: CreateAssistantRequestModel.Gpt4o,
            name: "Example: Contoso sales RAG",
            instructions: "You are an assistant that looks up sales data and helps visualize the information based"
                          + " on user queries. When asked to generate a graph, chart, or other visualization, use"
                          + " the code interpreter tool to do so.",
            tools:
            [
                new AssistantToolsFileSearch(),
                new AssistantToolsCode(),
            ],
            toolResources: new CreateAssistantRequestToolResources
            {
                FileSearch = new CreateAssistantRequestToolResourcesFileSearch
                {
                    VectorStores =
                    [
                        new CreateAssistantRequestToolResourcesFileSearchVectorStore
                        {
                            FileIds = [salesFile.Id],
                        }
                    ],
                }
            });

        // Now we'll create a thread with a user query about the data already associated with the assistant, then run it
        RunObject threadRun = await api.Assistants.CreateThreadAndRunAsync(
            assistantId: assistant.Id,
            thread: new CreateThreadRequest
            {
                Messages = new List<CreateMessageRequest>
                {
                    new()
                    {
                        Role = CreateMessageRequestRole.User,
                        Content = "How well did product 113045 sell in February? Graph its trend over time.",
                    },
                },
            });

        // Check back to see when the run is done
        do
        {
            await Task.Delay(TimeSpan.FromSeconds(1));
            
            threadRun = await api.Assistants.GetRunAsync(
                threadId: threadRun.ThreadId,
                runId: threadRun.Id);
        } while (threadRun.Status is RunObjectStatus.Queued or RunObjectStatus.InProgress);

        // Finally, we'll print out the full history for the thread that includes the augmented generation
        // TODO: IAsyncEnumerable pagination
        ListMessagesResponse messages
            = await api.Assistants.ListMessagesAsync(
                threadId: threadRun.ThreadId); //  ListOrder.OldestFirst
        
        foreach (MessageObject message in messages.Data)
        {
            Console.Write($"[{message.Role.ToString().ToUpper()}]: ");
            foreach (ContentItem2 contentItem in message.Content)
            {
                if (contentItem.Text is {} text)
                {
                    Console.WriteLine($"{text.Text.Value}");
        
                    if (text.Text.Annotations.Count > 0)
                    {
                        Console.WriteLine();
                    }
        
                    // Include annotations, if any.
                    foreach (AnnotationsItem annotation in text.Text.Annotations)
                    {
                        if (annotation.FileCitation is {} citation &&
                            !string.IsNullOrEmpty(citation.FileCitation.FileId))
                        {
                            Console.WriteLine($"* File citation, file ID: {citation.FileCitation.FileId}");
                        }
                        if (annotation.FilePath is {} path &&
                            !string.IsNullOrEmpty(path.FilePath.FileId))
                        {
                            Console.WriteLine($"* File output, new file ID: {path.FilePath.FileId}");
                        }
                    }
                }
                if (contentItem.ImageFile is {} imageFile)
                {
                    OpenAIFile imageInfo = await api.Files.RetrieveFileAsync(imageFile.ImageFile.FileId);
                    byte[] imageBytes = await api.Files.DownloadFileAsync(imageFile.ImageFile.FileId);
        
                    FileInfo fileInfo = new($"{imageInfo.Filename}.png");
        
                    await File.WriteAllBytesAsync(fileInfo.FullName, imageBytes);
        
                    Console.WriteLine($"<image: {new Uri(fileInfo.FullName).AbsoluteUri}>");
                }
            }
            Console.WriteLine();
        }
        
        // Optionally, delete any persistent resources you no longer need.
        _ = await api.Assistants.DeleteThreadAsync(threadRun.ThreadId);
        _ = await api.Assistants.DeleteAssistantAsync(assistant.Id);
        _ = await api.Files.DeleteFileAsync(salesFile.Id);
    }
}
