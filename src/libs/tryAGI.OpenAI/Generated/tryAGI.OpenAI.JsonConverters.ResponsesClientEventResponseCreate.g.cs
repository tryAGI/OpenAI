#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class ResponsesClientEventResponseCreateJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.ResponsesClientEventResponseCreate>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.ResponsesClientEventResponseCreate Read(
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
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1? responsesClientEventResponseCreateVariant1 = default;
            global::tryAGI.OpenAI.CreateResponse? createResponse = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        responsesClientEventResponseCreateVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1>(__rawJson, options);
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
                        createResponse = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.CreateResponse>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (responsesClientEventResponseCreateVariant1 == null && createResponse == null)
            {
                try
                {
                    responsesClientEventResponseCreateVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    createResponse = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.CreateResponse>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::tryAGI.OpenAI.ResponsesClientEventResponseCreate(
                responsesClientEventResponseCreateVariant1,

                createResponse
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.ResponsesClientEventResponseCreate value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsResponsesClientEventResponseCreateVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponsesClientEventResponseCreateVariant1, typeof(global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1), options);
            }
            else if (value.IsCreateResponse)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateResponse, typeof(global::tryAGI.OpenAI.CreateResponse), options);
            }
        }
    }
}