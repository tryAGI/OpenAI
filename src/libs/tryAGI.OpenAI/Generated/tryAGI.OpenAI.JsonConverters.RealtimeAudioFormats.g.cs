#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class RealtimeAudioFormatsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.RealtimeAudioFormats>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.RealtimeAudioFormats Read(
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
            if (__jsonProps.Contains("rate")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("type")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::tryAGI.OpenAI.RealtimeAudioFormatsPcmAudioFormat? pcmAudioFormat = default;
            global::tryAGI.OpenAI.RealtimeAudioFormatsPcmuAudioFormat? pcmuAudioFormat = default;
            global::tryAGI.OpenAI.RealtimeAudioFormatsPcmaAudioFormat? pcmaAudioFormat = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        pcmAudioFormat = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeAudioFormatsPcmAudioFormat>(__rawJson, options);
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
                        pcmuAudioFormat = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeAudioFormatsPcmuAudioFormat>(__rawJson, options);
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
                        pcmaAudioFormat = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeAudioFormatsPcmaAudioFormat>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (pcmAudioFormat == null && pcmuAudioFormat == null && pcmaAudioFormat == null)
            {
                try
                {
                    pcmAudioFormat = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeAudioFormatsPcmAudioFormat>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    pcmuAudioFormat = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeAudioFormatsPcmuAudioFormat>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    pcmaAudioFormat = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeAudioFormatsPcmaAudioFormat>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::tryAGI.OpenAI.RealtimeAudioFormats(
                pcmAudioFormat,

                pcmuAudioFormat,

                pcmaAudioFormat
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.RealtimeAudioFormats value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsPcmAudioFormat)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PcmAudioFormat, typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmAudioFormat), options);
            }
            else if (value.IsPcmuAudioFormat)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PcmuAudioFormat, typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmuAudioFormat), options);
            }
            else if (value.IsPcmaAudioFormat)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PcmaAudioFormat, typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmaAudioFormat), options);
            }
        }
    }
}