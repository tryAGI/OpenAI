#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class ChatCompletionToolChoiceOptionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.ChatCompletionToolChoiceOption>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.ChatCompletionToolChoiceOption Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

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
            var __score1 = 0;
            if (__jsonProps.Contains("allowed_tools")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("function")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("custom")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum? toolChoiceMode = default;
            global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoice? allowedTools = default;
            global::tryAGI.OpenAI.ChatCompletionNamedToolChoice? functionToolChoice = default;
            global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustom? customToolChoice = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        toolChoiceMode = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum>(__rawJson, options);
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
                        allowedTools = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoice>(__rawJson, options);
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
                        functionToolChoice = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ChatCompletionNamedToolChoice>(__rawJson, options);
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
                        customToolChoice = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustom>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (toolChoiceMode == null && allowedTools == null && functionToolChoice == null && customToolChoice == null)
            {
                try
                {
                    toolChoiceMode = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    allowedTools = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoice>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    functionToolChoice = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ChatCompletionNamedToolChoice>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    customToolChoice = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustom>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::tryAGI.OpenAI.ChatCompletionToolChoiceOption(
                toolChoiceMode,

                allowedTools,

                functionToolChoice,

                customToolChoice
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.ChatCompletionToolChoiceOption value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsToolChoiceMode)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolChoiceMode, typeof(global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum), options);
            }
            else if (value.IsAllowedTools)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AllowedTools, typeof(global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoice), options);
            }
            else if (value.IsFunctionToolChoice)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionToolChoice, typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoice), options);
            }
            else if (value.IsCustomToolChoice)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomToolChoice, typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustom), options);
            }
        }
    }
}