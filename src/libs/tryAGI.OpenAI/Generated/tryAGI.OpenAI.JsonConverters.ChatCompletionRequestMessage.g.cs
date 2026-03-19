#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class ChatCompletionRequestMessageJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.ChatCompletionRequestMessage>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.ChatCompletionRequestMessage Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("content")) __score0++;
            if (__jsonProps.Contains("role")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("content")) __score1++;
            if (__jsonProps.Contains("role")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("content")) __score2++;
            if (__jsonProps.Contains("role")) __score2++;
            if (__jsonProps.Contains("name")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("content")) __score3++;
            if (__jsonProps.Contains("refusal")) __score3++;
            if (__jsonProps.Contains("role")) __score3++;
            if (__jsonProps.Contains("name")) __score3++;
            if (__jsonProps.Contains("audio")) __score3++;
            if (__jsonProps.Contains("tool_calls")) __score3++;
            if (__jsonProps.Contains("function_call")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("role")) __score4++;
            if (__jsonProps.Contains("content")) __score4++;
            if (__jsonProps.Contains("tool_call_id")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("role")) __score5++;
            if (__jsonProps.Contains("content")) __score5++;
            if (__jsonProps.Contains("name")) __score5++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }

            global::tryAGI.OpenAI.ChatCompletionRequestDeveloperMessage? developer = default;
            global::tryAGI.OpenAI.ChatCompletionRequestSystemMessage? system = default;
            global::tryAGI.OpenAI.ChatCompletionRequestUserMessage? user = default;
            global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessage? assistant = default;
            global::tryAGI.OpenAI.ChatCompletionRequestToolMessage? tool = default;
            global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessage? function = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ChatCompletionRequestDeveloperMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ChatCompletionRequestDeveloperMessage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ChatCompletionRequestDeveloperMessage).Name}");
                        developer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ChatCompletionRequestSystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ChatCompletionRequestSystemMessage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ChatCompletionRequestSystemMessage).Name}");
                        system = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ChatCompletionRequestUserMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ChatCompletionRequestUserMessage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ChatCompletionRequestUserMessage).Name}");
                        user = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessage).Name}");
                        assistant = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ChatCompletionRequestToolMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ChatCompletionRequestToolMessage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ChatCompletionRequestToolMessage).Name}");
                        tool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessage).Name}");
                        function = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (developer == null && system == null && user == null && assistant == null && tool == null && function == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ChatCompletionRequestDeveloperMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ChatCompletionRequestDeveloperMessage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ChatCompletionRequestDeveloperMessage).Name}");
                    developer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ChatCompletionRequestSystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ChatCompletionRequestSystemMessage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ChatCompletionRequestSystemMessage).Name}");
                    system = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ChatCompletionRequestUserMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ChatCompletionRequestUserMessage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ChatCompletionRequestUserMessage).Name}");
                    user = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessage).Name}");
                    assistant = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ChatCompletionRequestToolMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ChatCompletionRequestToolMessage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ChatCompletionRequestToolMessage).Name}");
                    tool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessage).Name}");
                    function = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::tryAGI.OpenAI.ChatCompletionRequestMessage(
                developer,

                system,

                user,

                assistant,

                tool,

                function
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.ChatCompletionRequestMessage value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsDeveloper)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ChatCompletionRequestDeveloperMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ChatCompletionRequestDeveloperMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ChatCompletionRequestDeveloperMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Developer, typeInfo);
            }
            else if (value.IsSystem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ChatCompletionRequestSystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ChatCompletionRequestSystemMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ChatCompletionRequestSystemMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.System, typeInfo);
            }
            else if (value.IsUser)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ChatCompletionRequestUserMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ChatCompletionRequestUserMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ChatCompletionRequestUserMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.User, typeInfo);
            }
            else if (value.IsAssistant)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Assistant, typeInfo);
            }
            else if (value.IsTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ChatCompletionRequestToolMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ChatCompletionRequestToolMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ChatCompletionRequestToolMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeInfo);
            }
            else if (value.IsFunction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function, typeInfo);
            }
        }
    }
}