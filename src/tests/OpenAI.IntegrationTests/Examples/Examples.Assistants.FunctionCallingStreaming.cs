using System.Diagnostics.CodeAnalysis;

namespace tryAGI.OpenAI.IntegrationTests.Examples;

public partial class Examples
{
    [Test]
    [Explicit]
    [Experimental("OPENAI_BETA_001")]
    public async Task Assistants_FunctionCallingStreaming()
    {
        using var api = GetAuthenticatedClient();
        
        var service = new FunctionCallingService();
        IList<ChatCompletionTool> tools = service.AsTools().AsOpenAiTools();
        
        AssistantObject assistant = await api.Assistants.CreateAssistantAsync(
            model: AssistantSupportedModels.Gpt4o,
            name: "Example: Function Calling",
            instructions: "Don't make assumptions about what values to plug into functions."
                          + " Ask for clarification if a user request is ambiguous.",
            tools: tools.Select(x => new OneOf<AssistantToolsCode, AssistantToolsFileSearch, AssistantToolsFunction>(new AssistantToolsFunction
            {
                Function = x.Function,
            })).ToArray());

        ThreadObject thread = await api.Assistants.CreateThreadAsync(new CreateThreadRequest
        {
            Messages = ["What's the weather like today?"],
        });
        
        var streamingUpdates = api.Assistants.CreateRunAsStreamAsync(
            threadId: thread.Id,
            assistantId: assistant.Id);

        RunObject? currentRun;
        do
        {
            currentRun = null;
            List<SubmitToolOutputsRunRequestToolOutput> outputsToSubmit = [];
            
            await foreach (AssistantStreamEvent streamingUpdate in streamingUpdates)
            {
                if (streamingUpdate.Run?.Value1 is { Data: {} newRun })
                {
                    Console.WriteLine("--- Run created! ---");
                        
                    currentRun = newRun;
                }
                if (streamingUpdate.Run?.Value4 is { Data.RequiredAction: {} requiredAction })
                {
                    foreach (RunToolCallObject toolCall in requiredAction.SubmitToolOutputs.ToolCalls)
                    {
                        var json = await service.CallAsync(
                            functionName: toolCall.Function.Name,
                            argumentsAsJson: toolCall.Function.Arguments);
                        outputsToSubmit.Add(new SubmitToolOutputsRunRequestToolOutput
                        {
                            ToolCallId = toolCall.Id,
                            Output = json,
                        });
                    }
                }
                if (streamingUpdate.Message?.Value3 is {} delta)
                {
                    foreach (var deltaVariation in delta.Data.Delta.Content ?? [])
                    {
                        if (deltaVariation.Value1?.ImageFile is {} imageFile)
                        {
                            Console.WriteLine();
                            Console.WriteLine(imageFile.FileId);
                        }
                        if (deltaVariation.Value2?.Text is {} text)
                        {
                            Console.Write(text?.Value);
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

            if (outputsToSubmit.Count > 0)
            {
                // streamingUpdates = await api.Assistants.SubmitToolOuputsToRunAsStreamAsync(
                //     threadId: currentRun.ThreadId,
                //     runId: currentRun.Id,
                //     outputsToSubmit);
            }
        }
        while (currentRun?.Status is RunObjectStatus.Queued or RunObjectStatus.InProgress or RunObjectStatus.RequiresAction);
        
        _ = await api.Assistants.DeleteThreadAsync(thread.Id);
        _ = await api.Assistants.DeleteAssistantAsync(assistant.Id);
    }
}
