using System.Diagnostics.CodeAnalysis;

namespace tryAGI.OpenAI.IntegrationTests.Examples;

public partial class Examples
{
    [Test]
    [Explicit]
    [Experimental("OPENAI_BETA_001")]
    public async Task Assistants_AllTools()
    {
        using var api = GetAuthenticatedClient();
        
        OpenAIFile favoriteNumberFile = await api.Files.CreateFileAsync(
            file: """
                  This file contains the favorite numbers for individuals.

                  John Doe: 14
                  Bob Doe: 32
                  Jane Doe: 44
                  """u8.ToArray(),
            filename: "favorite_numbers.txt",
            purpose: CreateFileRequestPurpose.Assistants);
        
        var service = new AllToolsService();
        IList<ChatCompletionTool> tools = service.AsTools().AsOpenAiTools();
        
        AssistantObject assistant = await api.Assistants.CreateAssistantAsync(
            model: AssistantSupportedModels.Gpt4o,
            instructions: "Use functions to resolve family relations into the names of people. Use file search to "
                          + " look up the favorite numbers of people. Use code interpreter to create graphs of lines.",
            tools: tools
                .Select(x => new OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>(new AssistantToolsFunction
                {
                    Function = x.Function,
                }))
                .Concat([
                    new AssistantToolsFileSearch(),
                    new AssistantToolsCode()
                ])
                .ToArray(),
            toolResources: new CreateAssistantRequestToolResources
            {
                FileSearch = new CreateAssistantRequestToolResourcesFileSearch
                {
                    VectorStores = new List<CreateAssistantRequestToolResourcesFileSearchVectorStore>
                    {
                        new()
                        {
                            FileIds = [favoriteNumberFile.Id],
                        },
                    },
                },
            });

        RunObject run = await api.Assistants.CreateThreadAndRunAsync(
            assistantId: assistant.Id,
            new CreateThreadRequest
            {
                Messages = [
                    "Create a graph of a line with a slope that's my father's favorite number "
                    + "and an offset that's my mother's favorite number.",
                    "Include people's names in your response and cite where you found them."
                ],
            });
        
        // Poll the run until it is no longer queued or in progress.
        while (run.Status is RunObjectStatus.Queued or RunObjectStatus.InProgress or RunObjectStatus.RequiresAction)
        {
            await Task.Delay(TimeSpan.FromSeconds(1));
            run = await api.Assistants.GetRunAsync(run.ThreadId, run.Id);

            // If the run requires action, resolve them.
            if (run.Status == RunObjectStatus.RequiresAction)
            {
                List<SubmitToolOutputsRunRequestToolOutput> toolOutputs = [];

                foreach (RunToolCallObject toolCall in run.RequiredAction?.SubmitToolOutputs.ToolCalls ?? [])
                {
                    var json = await service.CallAsync(
                        functionName: toolCall.Function.Name,
                        argumentsAsJson: toolCall.Function.Arguments);
                    toolOutputs.Add(new SubmitToolOutputsRunRequestToolOutput
                    {
                        ToolCallId = toolCall.Id,
                        Output = json,
                    });
                }

                // Submit the tool outputs to the assistant, which returns the run to the queued state.
                run = await api.Assistants.SubmitToolOuputsToRunAsync(
                    threadId: run.ThreadId,
                    runId: run.Id,
                    toolOutputs: toolOutputs);
            }
        }
        
        // With the run complete, list the messages and display their content
        if (run.Status == RunObjectStatus.Completed)
        {
            ListMessagesResponse messages
                = await api.Assistants.ListMessagesAsync(run.ThreadId, order: ListMessagesOrder.Asc);

            foreach (MessageObject message in messages.Data)
            {
                Console.WriteLine($"[{message.Role.ToString().ToUpper()}]: ");
                foreach (global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageContentTextObject, global::tryAGI.OpenAI.MessageContentRefusalObject> contentItem in message.Content)
                {
                    if (contentItem.Value1?.ImageFile is {} imageFile)
                    {
                        OpenAIFile imageInfo = await api.Files.RetrieveFileAsync(imageFile.FileId);
                        byte[] imageBytes = await api.Files.DownloadFileAsync(imageFile.FileId);
        
                        FileInfo fileInfo = new($"{imageInfo.Filename}.png");
        
                        await File.WriteAllBytesAsync(fileInfo.FullName, imageBytes);
        
                        Console.WriteLine($"<image: {new Uri(fileInfo.FullName).AbsoluteUri}>");
                    }
                    if (contentItem.Value2?.ImageUrl is {} imageUrl)
                    {
                        Console.WriteLine($" <Image URL> {imageUrl.Url}");
                    }
                    if (contentItem.Value3?.Text is {} text)
                    {
                        Console.WriteLine($"{text.Value}");
                        
                        // Include annotations, if any.
                        if (text.Annotations.Count > 0)
                        {
                            Console.WriteLine();
                            foreach (global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject> annotation in text.Annotations)
                            {
                                if (annotation.Value1?.FileCitation is {} fileCitation)
                                {
                                    Console.WriteLine($"* File citation, file ID: {fileCitation.FileId}");
                                    //Console.WriteLine($"* Text to replace: {fileCitation}");
                                    //Console.WriteLine($"* Message content index range: {fileCitation.StartIndex}-{fileCitation.EndIndex}");
                                }
                                if (annotation.Value2?.FilePath is {} filePath)
                                {
                                    Console.WriteLine($"* File output, new file ID: {filePath.FileId}");
                                    //Console.WriteLine($"* Text to replace: {filePath.Text}");
                                    //Console.WriteLine($"* Message content index range: {filePath.StartIndex}-{filePath.EndIndex}");
                                }
                            }
                        }
                    }
                    if (contentItem.Value4?.Refusal is {} refusal)
                    {
                        Console.WriteLine($"Refusal: {refusal}");
                    }
                }
                Console.WriteLine();
            }
            
            
            // List run steps for details about tool calls
            ListRunStepsResponse runSteps = await api.Assistants.ListRunStepsAsync(
                threadId: run.ThreadId,
                runId: run.Id,
                order: ListRunStepsOrder.Asc);
            foreach (RunStepObject step in runSteps.Data)
            {
                Console.WriteLine($"Run step: {step.Status}");
                foreach (var toolCall in step.StepDetails.Value2?.ToolCalls ?? [])
                {
                    if (toolCall.Value1?.CodeInterpreter is {} codeInterpreter)
                    {
                        //Console.WriteLine($" --> Tool call: {codeInterpreter.Type}");
                        foreach (var output in codeInterpreter.Outputs)
                        {
                            if (output.Value1?.Logs is {} logs)
                            {
                                Console.WriteLine($"    --> Output: {logs}");
                            }
                            if (output.Value2?.Image is {} image)
                            {
                                Console.WriteLine($"    --> Output: {image.FileId}");
                            }
                        }
                    }
                    if (toolCall.Value2?.FileSearch is {} fileSearch)
                    {
                        //Console.WriteLine($" --> Tool call: {fileSearch.Type}");
                        foreach (var output in fileSearch.Results ?? [])
                        {
                            Console.WriteLine($"    --> Output: {output.FileId}");
                        }
                    }
                    if (toolCall.Value3?.Function is {} tool)
                    {
                        //Console.WriteLine($" --> Tool call: {tool.Type}");
                    }
                }
            }
        }
        else
        {
            throw new NotImplementedException(run.Status.ToString());
        }
        
        // Optionally, delete any persistent resources you no longer need.
        _ = await api.Assistants.DeleteThreadAsync(run.ThreadId);
        _ = await api.Assistants.DeleteAssistantAsync(assistant.Id);
        _ = await api.Files.DeleteFileAsync(favoriteNumberFile.Id);
    }
}
