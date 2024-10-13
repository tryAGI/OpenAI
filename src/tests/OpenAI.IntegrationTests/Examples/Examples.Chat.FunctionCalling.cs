namespace OpenAI.IntegrationTests.Examples;

public partial class Examples
{
    [Test]
    [Explicit]
    public async Task FunctionCalling()
    {
        using var api = GetAuthenticatedClient();
        
        List<ChatCompletionRequestMessage> messages = [
            "What's the weather like today?",
        ];

        var service = new FunctionCallingService();
        IList<ChatCompletionTool> tools = service.AsTools().AsOpenAiTools();

        bool requiresAction;

        do
        {
            requiresAction = false;
            CreateChatCompletionResponse chatCompletion = await api.Chat.CreateChatCompletionAsync(
                messages,
                model: CreateChatCompletionRequestModel.Gpt4o20240806,
                tools: tools);

            switch (chatCompletion.Choices[0].FinishReason)
            {
                case CreateChatCompletionResponseChoiceFinishReason.Stop:
                    {
                        // Add the assistant message to the conversation history.
                        messages.Add(chatCompletion.Choices[0].Message.AsRequestMessage());
                        break;
                    }

                case CreateChatCompletionResponseChoiceFinishReason.ToolCalls:
                    {
                        // First, add the assistant message with tool calls to the conversation history.
                        messages.Add(chatCompletion.Choices[0].Message.AsRequestMessage());

                        // Then, add a new tool message for each tool call that is resolved.
                        foreach (ChatCompletionMessageToolCall toolCall in chatCompletion.Choices[0].Message.ToolCalls ?? [])
                        {
                            var json = await service.CallAsync(
                                functionName: toolCall.Function.Name,
                                argumentsAsJson: toolCall.Function.Arguments);
                            messages.Add(json.AsToolMessage(toolCall.Id));
                        }

                        requiresAction = true;
                        break;
                    }

                case CreateChatCompletionResponseChoiceFinishReason.Length:
                    throw new NotImplementedException("Incomplete model output due to MaxTokens parameter or token limit exceeded.");

                case CreateChatCompletionResponseChoiceFinishReason.ContentFilter:
                    throw new NotImplementedException("Omitted content due to a content filter flag.");

                case CreateChatCompletionResponseChoiceFinishReason.FunctionCall:
                    throw new NotImplementedException("Deprecated in favor of tool calls.");

                default:
                    throw new NotImplementedException(chatCompletion.Choices[0].FinishReason.ToString());
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
