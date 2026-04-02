#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class ResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.Response>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.Response Read(
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
            if (__jsonProps.Contains("metadata")) __score0++;
            if (__jsonProps.Contains("prompt_cache_key")) __score0++;
            if (__jsonProps.Contains("prompt_cache_retention")) __score0++;
            if (__jsonProps.Contains("safety_identifier")) __score0++;
            if (__jsonProps.Contains("service_tier")) __score0++;
            if (__jsonProps.Contains("temperature")) __score0++;
            if (__jsonProps.Contains("top_logprobs")) __score0++;
            if (__jsonProps.Contains("top_p")) __score0++;
            if (__jsonProps.Contains("user")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("background")) __score1++;
            if (__jsonProps.Contains("max_output_tokens")) __score1++;
            if (__jsonProps.Contains("max_tool_calls")) __score1++;
            if (__jsonProps.Contains("model")) __score1++;
            if (__jsonProps.Contains("previous_response_id")) __score1++;
            if (__jsonProps.Contains("prompt")) __score1++;
            if (__jsonProps.Contains("reasoning")) __score1++;
            if (__jsonProps.Contains("text")) __score1++;
            if (__jsonProps.Contains("tool_choice")) __score1++;
            if (__jsonProps.Contains("tools")) __score1++;
            if (__jsonProps.Contains("truncation")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("completed_at")) __score2++;
            if (__jsonProps.Contains("conversation")) __score2++;
            if (__jsonProps.Contains("created_at")) __score2++;
            if (__jsonProps.Contains("error")) __score2++;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("incomplete_details")) __score2++;
            if (__jsonProps.Contains("instructions")) __score2++;
            if (__jsonProps.Contains("object")) __score2++;
            if (__jsonProps.Contains("output")) __score2++;
            if (__jsonProps.Contains("output_text")) __score2++;
            if (__jsonProps.Contains("parallel_tool_calls")) __score2++;
            if (__jsonProps.Contains("status")) __score2++;
            if (__jsonProps.Contains("usage")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::tryAGI.OpenAI.ModelResponseProperties? modelProperties = default;
            global::tryAGI.OpenAI.ResponseProperties? properties = default;
            global::tryAGI.OpenAI.ResponseVariant3? responseVariant3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        modelProperties = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ModelResponseProperties>(__rawJson, options);
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
                        properties = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseProperties>(__rawJson, options);
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
                        responseVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseVariant3>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (modelProperties == null && properties == null && responseVariant3 == null)
            {
                try
                {
                    modelProperties = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ModelResponseProperties>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    properties = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseProperties>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseVariant3>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::tryAGI.OpenAI.Response(
                modelProperties,

                properties,

                responseVariant3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.Response value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsModelProperties)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ModelProperties, typeof(global::tryAGI.OpenAI.ModelResponseProperties), options);
            }
            else if (value.IsProperties)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Properties, typeof(global::tryAGI.OpenAI.ResponseProperties), options);
            }
            else if (value.IsResponseVariant3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseVariant3, typeof(global::tryAGI.OpenAI.ResponseVariant3), options);
            }
        }
    }
}