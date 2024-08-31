using System.Text;

namespace OpenAI.IntegrationTests.Examples;

public partial class Examples
{
    [Test]
    [Explicit]
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
            foreach (OneOf<
                MessageContentImageFileObject, 
                MessageContentImageUrlObject, 
                MessageContentTextObject, 
                MessageContentRefusalObject> contentItem in message.Content)
            {
                if (contentItem.IsValue3)
                {
                    Console.WriteLine($"{contentItem.Value3.Text.Value}");
        
                    if (contentItem.Value3.Text.Annotations.Count > 0)
                    {
                        Console.WriteLine();
                    }
        
                    // Include annotations, if any.
                    foreach (OneOf<
                        MessageContentTextAnnotationsFileCitationObject,
                        MessageContentTextAnnotationsFilePathObject> annotation in contentItem.Value3.Text.Annotations)
                    {
                        if (annotation.IsValue1 && !string.IsNullOrEmpty(annotation.Value1.FileCitation.FileId))
                        {
                            Console.WriteLine($"* File citation, file ID: {annotation.Value1.FileCitation.FileId}");
                        }
                        if (annotation.IsValue2 && !string.IsNullOrEmpty(annotation.Value2.FilePath.FileId))
                        {
                            Console.WriteLine($"* File output, new file ID: {annotation.Value2.FilePath.FileId}");
                        }
                    }
                }
                if (contentItem.IsValue1)
                {
                    OpenAIFile imageInfo = await api.Files.RetrieveFileAsync(contentItem.Value1.ImageFile.FileId);
                    byte[] imageBytes = await api.Files.DownloadFileAsync(contentItem.Value1.ImageFile.FileId);
        
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
