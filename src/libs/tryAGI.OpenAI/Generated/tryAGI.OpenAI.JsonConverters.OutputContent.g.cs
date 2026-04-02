#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class OutputContentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.OutputContent>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.OutputContent Read(
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
            if (__jsonProps.Contains("annotations")) __score0++;
            if (__jsonProps.Contains("logprobs")) __score0++;
            if (__jsonProps.Contains("text")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("refusal")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("text")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::tryAGI.OpenAI.OutputTextContent? outputText = default;
            global::tryAGI.OpenAI.RefusalContent? refusal = default;
            global::tryAGI.OpenAI.ReasoningTextContent? reasoningText = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        outputText = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.OutputTextContent>(__rawJson, options);
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
                        refusal = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RefusalContent>(__rawJson, options);
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
                        reasoningText = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ReasoningTextContent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (outputText == null && refusal == null && reasoningText == null)
            {
                try
                {
                    outputText = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.OutputTextContent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    refusal = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RefusalContent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    reasoningText = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ReasoningTextContent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::tryAGI.OpenAI.OutputContent(
                outputText,

                refusal,

                reasoningText
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.OutputContent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsOutputText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputText, typeof(global::tryAGI.OpenAI.OutputTextContent), options);
            }
            else if (value.IsRefusal)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Refusal, typeof(global::tryAGI.OpenAI.RefusalContent), options);
            }
            else if (value.IsReasoningText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReasoningText, typeof(global::tryAGI.OpenAI.ReasoningTextContent), options);
            }
        }
    }
}