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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

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
            if (__jsonProps.Contains("rate")) __score0++;
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmAudioFormat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeAudioFormatsPcmAudioFormat> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmAudioFormat).Name}");
                        pcmAudioFormat = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmuAudioFormat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeAudioFormatsPcmuAudioFormat> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmuAudioFormat).Name}");
                        pcmuAudioFormat = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmaAudioFormat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeAudioFormatsPcmaAudioFormat> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmaAudioFormat).Name}");
                        pcmaAudioFormat = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmAudioFormat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeAudioFormatsPcmAudioFormat> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmAudioFormat).Name}");
                    pcmAudioFormat = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmuAudioFormat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeAudioFormatsPcmuAudioFormat> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmuAudioFormat).Name}");
                    pcmuAudioFormat = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmaAudioFormat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeAudioFormatsPcmaAudioFormat> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmaAudioFormat).Name}");
                    pcmaAudioFormat = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPcmAudioFormat)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmAudioFormat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeAudioFormatsPcmAudioFormat?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmAudioFormat).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PcmAudioFormat, typeInfo);
            }
            else if (value.IsPcmuAudioFormat)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmuAudioFormat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeAudioFormatsPcmuAudioFormat?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmuAudioFormat).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PcmuAudioFormat, typeInfo);
            }
            else if (value.IsPcmaAudioFormat)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmaAudioFormat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeAudioFormatsPcmaAudioFormat?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmaAudioFormat).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PcmaAudioFormat, typeInfo);
            }
        }
    }
}