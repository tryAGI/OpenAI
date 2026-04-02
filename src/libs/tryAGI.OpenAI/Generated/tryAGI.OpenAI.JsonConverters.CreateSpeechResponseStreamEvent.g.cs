#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class CreateSpeechResponseStreamEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.CreateSpeechResponseStreamEvent>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.CreateSpeechResponseStreamEvent Read(
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
            if (__jsonProps.Contains("audio")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("usage")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::tryAGI.OpenAI.SpeechAudioDeltaEvent? speechAudioDelta = default;
            global::tryAGI.OpenAI.SpeechAudioDoneEvent? speechAudioDone = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        speechAudioDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.SpeechAudioDeltaEvent>(__rawJson, options);
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
                        speechAudioDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.SpeechAudioDoneEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (speechAudioDelta == null && speechAudioDone == null)
            {
                try
                {
                    speechAudioDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.SpeechAudioDeltaEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    speechAudioDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.SpeechAudioDoneEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::tryAGI.OpenAI.CreateSpeechResponseStreamEvent(
                speechAudioDelta,

                speechAudioDone
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.CreateSpeechResponseStreamEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsSpeechAudioDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SpeechAudioDelta, typeof(global::tryAGI.OpenAI.SpeechAudioDeltaEvent), options);
            }
            else if (value.IsSpeechAudioDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SpeechAudioDone, typeof(global::tryAGI.OpenAI.SpeechAudioDoneEvent), options);
            }
        }
    }
}