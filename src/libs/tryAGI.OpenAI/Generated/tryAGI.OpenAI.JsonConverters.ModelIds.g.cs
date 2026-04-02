#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class ModelIdsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.ModelIds>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.ModelIds Read(
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
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::tryAGI.OpenAI.ModelIdsShared? shared = default;
            global::tryAGI.OpenAI.ModelIdsResponses? responses = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        shared = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ModelIdsShared>(__rawJson, options);
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

                        responses = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ModelIdsResponses>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (shared == null && responses == null)
            {
                try
                {

                    shared = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ModelIdsShared>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    responses = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ModelIdsResponses>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::tryAGI.OpenAI.ModelIds(
                shared,

                responses
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.ModelIds value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsShared)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Shared, typeof(global::tryAGI.OpenAI.ModelIdsShared), options);
            }
            else if (value.IsResponses)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Responses, typeof(global::tryAGI.OpenAI.ModelIdsResponses), options);
            }
        }
    }
}