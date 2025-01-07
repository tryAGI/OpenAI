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
            model: CreateAssistantRequestModel.Gpt4o,
            name: "Example: Function Calling",
            instructions: "Don't make assumptions about what values to plug into functions."
                          + " Ask for clarification if a user request is ambiguous.",
            tools: tools.Select(x => new ToolsItem2(new AssistantToolsFunction
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
                if (streamingUpdate.ThreadRunCreated is { Data: {} newRun })
                {
                    Console.WriteLine("--- Run created! ---");
                        
                    currentRun = newRun;
                }
                if (streamingUpdate.ThreadRunRequiresAction is { Data.RequiredAction: {} requiredAction })
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
                if (streamingUpdate.ThreadMessageDelta is {} delta)
                {
                    foreach (var deltaVariation in delta.Data.Delta.Content ?? [])
                    {
                        if (deltaVariation.ImageFile is {} imageFile)
                        {
                            Console.WriteLine();
                            Console.WriteLine(imageFile.ImageFile?.FileId);
                        }
                        if (deltaVariation.Text is {} text)
                        {
                            Console.Write(text.Text?.Value);
                        }
                        if (deltaVariation.Refusal is {} refusal)
                        {
                            Console.WriteLine();
                            Console.WriteLine(refusal.Refusal);
                        }
                        if (deltaVariation.ImageUrl is {} imageUrl)
                        {
                            Console.WriteLine();
                            Console.WriteLine(imageUrl.ImageUrl?.Url);
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
