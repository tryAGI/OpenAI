using System.Runtime.CompilerServices;
using System.Text.Json;
using Meai = Microsoft.Extensions.AI;

namespace tryAGI.OpenAI;

public sealed partial class OpenAiClient : Meai.IChatClient
{
    object? Meai.IChatClient.GetService(Type serviceType, object? serviceKey)
    {
        if (serviceKey is not null)
        {
            return null;
        }

        if (serviceType == typeof(Meai.IChatClient) || serviceType.IsInstanceOfType(this))
        {
            return this;
        }

        return null;
    }

    async Task<Meai.ChatResponse> Meai.IChatClient.GetResponseAsync(
        IEnumerable<Meai.ChatMessage> chatMessages,
        Meai.ChatOptions? options,
        CancellationToken cancellationToken)
    {
        var request = CreateRequest(chatMessages, options, stream: false);

        var response = await Chat.CreateChatCompletionAsync(
            request: request,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        return ConvertResponse(response, options);
    }

    async IAsyncEnumerable<Meai.ChatResponseUpdate> Meai.IChatClient.GetStreamingResponseAsync(
        IEnumerable<Meai.ChatMessage> chatMessages,
        Meai.ChatOptions? options,
        [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        var request = CreateRequest(chatMessages, options, stream: true);

        // Accumulate tool call chunks by index so we can emit complete arguments
        var toolCallBuilders = new Dictionary<int, (string Id, string Name, System.Text.StringBuilder Args)>();

        await foreach (var chunk in Chat.CreateChatCompletionAsStreamAsync(
            request: request,
            cancellationToken: cancellationToken).ConfigureAwait(false))
        {
            var choice = chunk.Choices.Count > 0 ? chunk.Choices[0] : null;
            if (choice is null)
            {
                // Last chunk with usage only
                if (chunk.Usage is { } usage)
                {
                    yield return new Meai.ChatResponseUpdate
                    {
                        ModelId = chunk.Model,
                        CreatedAt = chunk.Created,
                        Contents = [new Meai.UsageContent(CreateUsageDetails(usage))],
                    };
                }
                continue;
            }

            var update = new Meai.ChatResponseUpdate
            {
                Role = choice.Delta.Role switch
                {
                    ChatCompletionStreamResponseDeltaRole.Assistant => Meai.ChatRole.Assistant,
                    ChatCompletionStreamResponseDeltaRole.System => Meai.ChatRole.System,
                    ChatCompletionStreamResponseDeltaRole.User => Meai.ChatRole.User,
                    ChatCompletionStreamResponseDeltaRole.Tool => Meai.ChatRole.Tool,
                    _ => null,
                },
                ModelId = chunk.Model,
                CreatedAt = chunk.Created,
                ResponseId = chunk.Id,
            };

            // Text content
            if (!string.IsNullOrEmpty(choice.Delta.Content))
            {
                update.Contents.Add(new Meai.TextContent(choice.Delta.Content));
            }

            // Tool call chunks — accumulate arguments by index
            if (choice.Delta.ToolCalls is { Count: > 0 } toolCallChunks)
            {
                foreach (var tc in toolCallChunks)
                {
                    var index = tc.Index;
                    if (!toolCallBuilders.TryGetValue(index, out var builder))
                    {
                        builder = (
                            Id: tc.Id ?? string.Empty,
                            Name: tc.Function?.Name ?? string.Empty,
                            Args: new System.Text.StringBuilder());
                        toolCallBuilders[index] = builder;
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(tc.Id))
                            toolCallBuilders[index] = builder with { Id = tc.Id! };
                        if (!string.IsNullOrEmpty(tc.Function?.Name))
                            toolCallBuilders[index] = builder with { Name = tc.Function!.Name };
                    }

                    if (!string.IsNullOrEmpty(tc.Function?.Arguments))
                    {
                        toolCallBuilders[index].Args.Append(tc.Function!.Arguments);
                    }
                }
            }

            // Finish reason — emit accumulated tool calls when finished
            if (choice.FinishReason is { } finishReason)
            {
                update.FinishReason = ConvertFinishReason(finishReason);

                // Emit complete tool calls with fully accumulated arguments
                foreach (var (_, builder) in toolCallBuilders)
                {
                    update.Contents.Add(new Meai.FunctionCallContent(
                        callId: builder.Id,
                        name: builder.Name,
                        arguments: ParseArguments(builder.Args.ToString())));
                }

                toolCallBuilders.Clear();
            }

            // Usage on final chunk
            if (chunk.Usage is { } streamUsage)
            {
                update.Contents.Add(new Meai.UsageContent(CreateUsageDetails(streamUsage)));
            }

            yield return update;
        }
    }

    private CreateChatCompletionRequest CreateRequest(
        IEnumerable<Meai.ChatMessage> chatMessages,
        Meai.ChatOptions? options,
        bool stream)
    {
        var messages = new List<ChatCompletionRequestMessage>();
        foreach (var msg in chatMessages)
        {
            messages.AddRange(ConvertMessage(msg));
        }

        var variant2 = new CreateChatCompletionRequestVariant2
        {
            Messages = messages,
            Model = options?.ModelId ?? "gpt-4o-mini",
        };

        if (options is not null)
        {
            variant2.MaxCompletionTokens = options.MaxOutputTokens;
            variant2.FrequencyPenalty = (double?)options.FrequencyPenalty;
            variant2.PresencePenalty = (double?)options.PresencePenalty;

            if (options.StopSequences is { Count: > 0 } stops)
            {
                variant2.Stop = string.Join(",", stops);
            }

            if (options.Tools is { Count: > 0 } tools)
            {
                variant2.Tools = ConvertTools(tools);
            }

            if (options.ResponseFormat is Meai.ChatResponseFormatJson)
            {
                variant2.ResponseFormat = new ResponseFormatJsonObject
                {
                    Type = ResponseFormatJsonObjectType.JsonObject,
                };
            }

            if (options.Temperature is { } temperature)
            {
                variant2.AdditionalProperties ??= new Dictionary<string, object>();
                variant2.AdditionalProperties["temperature"] = (double)temperature;
            }

            if (options.TopP is { } topP)
            {
                variant2.AdditionalProperties ??= new Dictionary<string, object>();
                variant2.AdditionalProperties["top_p"] = (double)topP;
            }

            if (options.Seed is { } seed)
            {
                variant2.AdditionalProperties ??= new Dictionary<string, object>();
                variant2.AdditionalProperties["seed"] = seed;
            }
        }

        if (stream)
        {
            variant2.Stream = true;
            variant2.StreamOptions = new ChatCompletionStreamOptionsVariant1
            {
                IncludeUsage = true,
            };
        }

        return new CreateChatCompletionRequest
        {
            Value2 = variant2,
        };
    }

    private static IList<ChatCompletionRequestMessage> ConvertMessage(Meai.ChatMessage message)
    {
        var result = new List<ChatCompletionRequestMessage>();

        if (message.Role == Meai.ChatRole.System)
        {
            var text = string.Concat(message.Contents.OfType<Meai.TextContent>().Select(c => c.Text));
            result.Add(new ChatCompletionRequestSystemMessage
            {
                Role = ChatCompletionRequestSystemMessageRole.System,
                Content = text,
            });
        }
        else if (message.Role == Meai.ChatRole.User)
        {
            var hasNonText = message.Contents.Any(c => c is Meai.DataContent);
            if (hasNonText)
            {
                var parts = new List<ChatCompletionRequestUserMessageContentPart>();
                foreach (var content in message.Contents)
                {
                    if (content is Meai.TextContent textContent)
                    {
                        parts.Add(new ChatCompletionRequestMessageContentPartText
                        {
                            Type = ChatCompletionRequestMessageContentPartTextType.Text,
                            Text = textContent.Text ?? string.Empty,
                        });
                    }
                    else if (content is Meai.DataContent dataContent &&
                             dataContent.HasTopLevelMediaType("image"))
                    {
                        string url;
                        if (dataContent.Uri is not null)
                        {
                            url = dataContent.Uri.ToString();
                        }
                        else
                        {
                            url = $"data:{dataContent.MediaType};base64,{Convert.ToBase64String(dataContent.Data.ToArray())}";
                        }

                        parts.Add(new ChatCompletionRequestMessageContentPartImage
                        {
                            Type = ChatCompletionRequestMessageContentPartImageType.ImageUrl,
                            ImageUrl = new ChatCompletionRequestMessageContentPartImageImageUrl
                            {
                                Url = url,
                            },
                        });
                    }
                }
                result.Add(new ChatCompletionRequestUserMessage
                {
                    Role = ChatCompletionRequestUserMessageRole.User,
                    Content = parts,
                });
            }
            else
            {
                var text = string.Concat(message.Contents.OfType<Meai.TextContent>().Select(c => c.Text));
                result.Add(new ChatCompletionRequestUserMessage
                {
                    Role = ChatCompletionRequestUserMessageRole.User,
                    Content = text,
                });
            }
        }
        else if (message.Role == Meai.ChatRole.Assistant)
        {
            var assistantMsg = new ChatCompletionRequestAssistantMessage
            {
                Role = ChatCompletionRequestAssistantMessageRole.Assistant,
            };

            var textParts = message.Contents.OfType<Meai.TextContent>().ToList();
            if (textParts.Count > 0)
            {
                assistantMsg.Content = string.Concat(textParts.Select(t => t.Text));
            }

            var toolCalls = message.Contents.OfType<Meai.FunctionCallContent>().ToList();
            if (toolCalls.Count > 0)
            {
                assistantMsg.ToolCalls = toolCalls.Select<Meai.FunctionCallContent, ChatCompletionMessageToolCallsItem>(tc =>
                    new ChatCompletionMessageToolCall
                    {
                        Id = tc.CallId,
                        Type = ChatCompletionMessageToolCallType.Function,
                        Function = new ChatCompletionMessageToolCallFunction
                        {
                            Name = tc.Name,
                            Arguments = tc.Arguments is not null
                                ? JsonSerializer.Serialize(tc.Arguments)
                                : "{}",
                        },
                    }).ToList();
            }

            result.Add(assistantMsg);
        }
        else if (message.Role == Meai.ChatRole.Tool)
        {
            foreach (var content in message.Contents)
            {
                if (content is Meai.FunctionResultContent functionResult)
                {
                    result.Add(new ChatCompletionRequestToolMessage
                    {
                        Role = ChatCompletionRequestToolMessageRole.Tool,
                        Content = functionResult.Result?.ToString() ?? string.Empty,
                        ToolCallId = functionResult.CallId,
                    });
                }
            }
        }

        return result;
    }

    private static IList<OneOf<ChatCompletionTool, CustomToolChatCompletions>> ConvertTools(
        IList<Meai.AITool> tools)
    {
        var result = new List<OneOf<ChatCompletionTool, CustomToolChatCompletions>>();
        foreach (var tool in tools)
        {
            if (tool is Meai.AIFunction function)
            {
                var parameters = function.JsonSchema is { } schema
                    ? JsonSerializer.Deserialize<object>(schema.GetRawText())
                    : new { type = "object", properties = new { } };

                result.Add(new ChatCompletionTool
                {
                    Type = ChatCompletionToolType.Function,
                    Function = new FunctionObject
                    {
                        Name = function.Name,
                        Description = function.Description,
                        Parameters = parameters,
                        Strict = false,
                    },
                });
            }
        }
        return result;
    }

    private static Meai.ChatResponse ConvertResponse(
        CreateChatCompletionResponse response,
        Meai.ChatOptions? options)
    {
        var messages = new List<Meai.ChatMessage>();
        Meai.ChatFinishReason? finishReason = null;

        foreach (var choice in response.Choices)
        {
            var msg = new Meai.ChatMessage
            {
                Role = Meai.ChatRole.Assistant,
            };

            if (!string.IsNullOrEmpty(choice.Message.Content))
            {
                msg.Contents.Add(new Meai.TextContent(choice.Message.Content));
            }

            if (choice.Message.ToolCalls is { Count: > 0 } toolCalls)
            {
                foreach (var toolCall in toolCalls)
                {
                    if (toolCall.IsFunction && toolCall.Function is { } functionCall)
                    {
                        msg.Contents.Add(new Meai.FunctionCallContent(
                            callId: functionCall.Id,
                            name: functionCall.Function.Name,
                            arguments: ParseArguments(functionCall.Function.Arguments)));
                    }
                }
            }

            messages.Add(msg);
            finishReason = ConvertFinishReason(choice.FinishReason);
        }

        var chatResponse = new Meai.ChatResponse(messages)
        {
            ModelId = response.Model,
            CreatedAt = response.Created,
            ResponseId = response.Id,
            FinishReason = finishReason,
        };

        if (response.Usage is { } usage)
        {
            chatResponse.Usage = CreateUsageDetails(usage);
        }

        return chatResponse;
    }

    private static Meai.UsageDetails CreateUsageDetails(CompletionUsage usage) =>
        new()
        {
            InputTokenCount = usage.PromptTokens,
            OutputTokenCount = usage.CompletionTokens,
            TotalTokenCount = usage.TotalTokens,
        };

    private static Meai.ChatFinishReason? ConvertFinishReason(
        CreateChatCompletionResponseChoiceFinishReason reason)
    {
        return reason switch
        {
            CreateChatCompletionResponseChoiceFinishReason.Stop => Meai.ChatFinishReason.Stop,
            CreateChatCompletionResponseChoiceFinishReason.Length => Meai.ChatFinishReason.Length,
            CreateChatCompletionResponseChoiceFinishReason.ToolCalls => Meai.ChatFinishReason.ToolCalls,
            CreateChatCompletionResponseChoiceFinishReason.ContentFilter => Meai.ChatFinishReason.ContentFilter,
            _ => null,
        };
    }

    private static Meai.ChatFinishReason? ConvertFinishReason(
        CreateChatCompletionStreamResponseChoiceFinishReason finishReason)
    {
        return finishReason switch
        {
            CreateChatCompletionStreamResponseChoiceFinishReason.Stop => Meai.ChatFinishReason.Stop,
            CreateChatCompletionStreamResponseChoiceFinishReason.Length => Meai.ChatFinishReason.Length,
            CreateChatCompletionStreamResponseChoiceFinishReason.ToolCalls => Meai.ChatFinishReason.ToolCalls,
            CreateChatCompletionStreamResponseChoiceFinishReason.ContentFilter => Meai.ChatFinishReason.ContentFilter,
            _ => null,
        };
    }

    private static IDictionary<string, object?>? ParseArguments(string? json)
    {
        if (string.IsNullOrEmpty(json))
        {
            return null;
        }

        try
        {
            return JsonSerializer.Deserialize<Dictionary<string, object?>>(json);
        }
        catch
        {
            return null;
        }
    }
}
