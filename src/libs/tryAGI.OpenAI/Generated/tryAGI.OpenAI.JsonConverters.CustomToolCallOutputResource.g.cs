#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class CustomToolCallOutputResourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.CustomToolCallOutputResource>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.CustomToolCallOutputResource Read(
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
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("created_by")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("status")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::tryAGI.OpenAI.CustomToolCallOutput? customToolCallOutput = default;
            global::tryAGI.OpenAI.CustomToolCallOutputResourceVariant2? customToolCallOutputResourceVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        customToolCallOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.CustomToolCallOutput>(__rawJson, options);
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
                        customToolCallOutputResourceVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.CustomToolCallOutputResourceVariant2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (customToolCallOutput == null && customToolCallOutputResourceVariant2 == null)
            {
                try
                {
                    customToolCallOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.CustomToolCallOutput>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    customToolCallOutputResourceVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.CustomToolCallOutputResourceVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::tryAGI.OpenAI.CustomToolCallOutputResource(
                customToolCallOutput,

                customToolCallOutputResourceVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.CustomToolCallOutputResource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsCustomToolCallOutput)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomToolCallOutput, typeof(global::tryAGI.OpenAI.CustomToolCallOutput), options);
            }
            else if (value.IsCustomToolCallOutputResourceVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomToolCallOutputResourceVariant2, typeof(global::tryAGI.OpenAI.CustomToolCallOutputResourceVariant2), options);
            }
        }
    }
}