using System.Text;

namespace OpenAI.IntegrationTests.Examples;

public partial class Examples
{
    [Test]
    [Explicit]
    public async Task FunctionCallingStreaming()
    {
        using var api = GetAuthenticatedClient();
        
        List<ChatCompletionRequestMessage> messages = [
            "What's the weather like today?",
        ];

        var service = new FunctionCallingService();
        IList<ChatCompletionTool> tools = service.AsTools();

        bool requiresAction;

        do
        {
            requiresAction = false;
            Dictionary<int, string> indexToToolCallId = [];
            Dictionary<int, string> indexToFunctionName = [];
            Dictionary<int, StringBuilder> indexToFunctionArguments = [];
            StringBuilder contentBuilder = new();
            IAsyncEnumerable<CreateChatCompletionStreamResponse> chatUpdates
                = api.Chat.CreateChatCompletionAsStreamAsync(
                    messages,
                    model: CreateChatCompletionRequestModel.Gpt4o20240806,
                    tools: tools);

            await foreach (CreateChatCompletionStreamResponse chatUpdate in chatUpdates)
            {
                // Accumulate the text content as new updates arrive.
                if (!string.IsNullOrEmpty(chatUpdate.Choices[0].Delta.Content))
                {
                    contentBuilder.Append(chatUpdate.Choices[0].Delta.Content);
                }

                // Build the tool calls as new updates arrive.
                foreach (ChatCompletionMessageToolCallChunk toolCallUpdate in chatUpdate.Choices[0].Delta.ToolCalls ?? [])
                {
                    // Keep track of which tool call ID belongs to this update index.
                    if (toolCallUpdate.Id is not null)
                    {
                        indexToToolCallId[toolCallUpdate.Index] = toolCallUpdate.Id;
                    }

                    // Keep track of which function name belongs to this update index.
                    if (toolCallUpdate.Function?.Name is {} functionName)
                    {
                        indexToFunctionName[toolCallUpdate.Index] = functionName;
                    }

                    // Keep track of which function arguments belong to this update index,
                    // and accumulate the arguments string as new updates arrive.
                    if (toolCallUpdate.Function?.Arguments is not null)
                    {
                        StringBuilder argumentsBuilder
                            = indexToFunctionArguments.TryGetValue(toolCallUpdate.Index, out StringBuilder? existingBuilder)
                                ? existingBuilder
                                : new StringBuilder();
                        argumentsBuilder.Append(toolCallUpdate.Function?.Arguments);
                        indexToFunctionArguments[toolCallUpdate.Index] = argumentsBuilder;
                    }
                }

                switch (chatUpdate.Choices[0].FinishReason)
                {
                    case CreateChatCompletionStreamResponseChoiceFinishReason.Stop:
                        {
                            // Add the assistant message to the conversation history.
                            messages.Add(contentBuilder.ToString().AsAssistantMessage());
                            break;
                        }

                    case CreateChatCompletionStreamResponseChoiceFinishReason.ToolCalls:
                        {
                            // First, collect the accumulated function arguments into complete tool calls to be processed
                            List<ChatCompletionMessageToolCall> toolCalls = [];
                            foreach ((int index, string toolCallId) in indexToToolCallId)
                            {
                                toolCalls.Add(new ChatCompletionMessageToolCall
                                {
                                    Id = toolCallId,
                                    Function = new ChatCompletionMessageToolCallFunction
                                    {
                                        Name = indexToFunctionName[index],
                                        Arguments = indexToFunctionArguments[index].ToString(),
                                    },
                                    Type = ChatCompletionMessageToolCallType.Function,
                                });
                            }

                            // Next, add the assistant message with tool calls to the conversation history.
                            var content = contentBuilder.Length > 0
                                ? new OneOf<string, IList<ChatCompletionRequestAssistantMessageContentPart>>(contentBuilder.ToString())
                                : (OneOf<string, IList<ChatCompletionRequestAssistantMessageContentPart>>?)null;
                            messages.Add(new ChatCompletionRequestAssistantMessage
                            {
                                Content = content,
                                Role = ChatCompletionRequestAssistantMessageRole.Assistant,
                                ToolCalls = toolCalls,
                            });

                            // Then, add a new tool message for each tool call to be resolved.
                            foreach (ChatCompletionMessageToolCall toolCall in toolCalls)
                            {
                                var json = await service.CallAsync(
                                    functionName: toolCall.Function.Name,
                                    argumentsAsJson: toolCall.Function.Arguments);
                                messages.Add(json.AsToolMessage(toolCall.Id));
                            }

                            requiresAction = true;
                            break;
                        }

                    case CreateChatCompletionStreamResponseChoiceFinishReason.Length:
                        throw new NotImplementedException("Incomplete model output due to MaxTokens parameter or token limit exceeded.");

                    case CreateChatCompletionStreamResponseChoiceFinishReason.ContentFilter:
                        throw new NotImplementedException("Omitted content due to a content filter flag.");

                    case CreateChatCompletionStreamResponseChoiceFinishReason.FunctionCall:
                        throw new NotImplementedException("Deprecated in favor of tool calls.");

                    case null:
                        break;
                }
            }
        } while (requiresAction);

        foreach (ChatCompletionRequestMessage requestMessage in messages)
        {
            if (requestMessage.System is { } systemMessage)
            {
                Console.WriteLine($"[SYSTEM]:");
                Console.WriteLine($"{systemMessage.Content.Value1}");
                Console.WriteLine();
            }
            else if (requestMessage.User is { } userMessage)
            {
                Console.WriteLine($"[USER]:");
                Console.WriteLine($"{userMessage.Content.Value1}");
                Console.WriteLine();
            }
            else if (requestMessage.Assistant is { Content: not null } assistantMessage)
            {
                Console.WriteLine($"[ASSISTANT]:");
                Console.WriteLine($"{assistantMessage.Content?.Value1}");
                Console.WriteLine();
            }
            else if (requestMessage.Tool is not null)
            {
                // Do not print any tool messages; let the assistant summarize the tool results instead.
            }
        }
    }
}
