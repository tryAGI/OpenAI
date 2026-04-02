#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class ComputerToolCallOutputResourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.ComputerToolCallOutputResource>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.ComputerToolCallOutputResource Read(
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
            if (__jsonProps.Contains("acknowledged_safety_checks")) __score0++;
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

            global::tryAGI.OpenAI.ComputerToolCallOutput? computerToolCallOutput = default;
            global::tryAGI.OpenAI.ComputerToolCallOutputResourceVariant2? computerToolCallOutputResourceVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        computerToolCallOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ComputerToolCallOutput>(__rawJson, options);
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
                        computerToolCallOutputResourceVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ComputerToolCallOutputResourceVariant2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (computerToolCallOutput == null && computerToolCallOutputResourceVariant2 == null)
            {
                try
                {
                    computerToolCallOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ComputerToolCallOutput>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    computerToolCallOutputResourceVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ComputerToolCallOutputResourceVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::tryAGI.OpenAI.ComputerToolCallOutputResource(
                computerToolCallOutput,

                computerToolCallOutputResourceVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.ComputerToolCallOutputResource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsComputerToolCallOutput)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerToolCallOutput, typeof(global::tryAGI.OpenAI.ComputerToolCallOutput), options);
            }
            else if (value.IsComputerToolCallOutputResourceVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerToolCallOutputResourceVariant2, typeof(global::tryAGI.OpenAI.ComputerToolCallOutputResourceVariant2), options);
            }
        }
    }
}