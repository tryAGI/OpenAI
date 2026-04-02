#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class RealtimeTurnDetectionRealtimeTurnDetection1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1 Read(
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
            if (__jsonProps.Contains("create_response")) __score0++;
            if (__jsonProps.Contains("idle_timeout_ms")) __score0++;
            if (__jsonProps.Contains("interrupt_response")) __score0++;
            if (__jsonProps.Contains("prefix_padding_ms")) __score0++;
            if (__jsonProps.Contains("silence_duration_ms")) __score0++;
            if (__jsonProps.Contains("threshold")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("create_response")) __score1++;
            if (__jsonProps.Contains("eagerness")) __score1++;
            if (__jsonProps.Contains("interrupt_response")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1ServerVad? serverVad = default;
            global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVad? semanticVad = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        serverVad = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1ServerVad>(__rawJson, options);
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
                        semanticVad = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVad>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (serverVad == null && semanticVad == null)
            {
                try
                {
                    serverVad = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1ServerVad>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    semanticVad = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVad>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1(
                serverVad,

                semanticVad
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsServerVad)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ServerVad, typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1ServerVad), options);
            }
            else if (value.IsSemanticVad)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SemanticVad, typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVad), options);
            }
        }
    }
}