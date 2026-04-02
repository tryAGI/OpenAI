#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class FunctionToolCallOutputResourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.FunctionToolCallOutputResource>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.FunctionToolCallOutputResource Read(
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
            if (__jsonProps.Contains("call_id")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("output")) __score0++;
            if (__jsonProps.Contains("status")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("created_by")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("status")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::tryAGI.OpenAI.FunctionToolCallOutput? functionToolCallOutput = default;
            global::tryAGI.OpenAI.FunctionToolCallOutputResourceVariant2? functionToolCallOutputResourceVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        functionToolCallOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.FunctionToolCallOutput>(__rawJson, options);
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
                        functionToolCallOutputResourceVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.FunctionToolCallOutputResourceVariant2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (functionToolCallOutput == null && functionToolCallOutputResourceVariant2 == null)
            {
                try
                {
                    functionToolCallOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.FunctionToolCallOutput>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    functionToolCallOutputResourceVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.FunctionToolCallOutputResourceVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::tryAGI.OpenAI.FunctionToolCallOutputResource(
                functionToolCallOutput,

                functionToolCallOutputResourceVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.FunctionToolCallOutputResource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsFunctionToolCallOutput)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionToolCallOutput, typeof(global::tryAGI.OpenAI.FunctionToolCallOutput), options);
            }
            else if (value.IsFunctionToolCallOutputResourceVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionToolCallOutputResourceVariant2, typeof(global::tryAGI.OpenAI.FunctionToolCallOutputResourceVariant2), options);
            }
        }
    }
}