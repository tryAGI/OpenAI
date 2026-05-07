#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class RealtimeTranslationServerEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.RealtimeTranslationServerEvent>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.RealtimeTranslationServerEvent Read(
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
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("error")) __score0++;
            if (__jsonProps.Contains("error.code")) __score0++;
            if (__jsonProps.Contains("error.event_id")) __score0++;
            if (__jsonProps.Contains("error.message")) __score0++;
            if (__jsonProps.Contains("error.param")) __score0++;
            if (__jsonProps.Contains("error.type")) __score0++;
            if (__jsonProps.Contains("event_id")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("event_id")) __score1++;
            if (__jsonProps.Contains("session")) __score1++;
            if (__jsonProps.Contains("session.audio")) __score1++;
            if (__jsonProps.Contains("session.expires_at")) __score1++;
            if (__jsonProps.Contains("session.id")) __score1++;
            if (__jsonProps.Contains("session.model")) __score1++;
            if (__jsonProps.Contains("session.type")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("event_id")) __score2++;
            if (__jsonProps.Contains("session")) __score2++;
            if (__jsonProps.Contains("session.audio")) __score2++;
            if (__jsonProps.Contains("session.expires_at")) __score2++;
            if (__jsonProps.Contains("session.id")) __score2++;
            if (__jsonProps.Contains("session.model")) __score2++;
            if (__jsonProps.Contains("session.type")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("event_id")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("delta")) __score4++;
            if (__jsonProps.Contains("elapsed_ms")) __score4++;
            if (__jsonProps.Contains("event_id")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("delta")) __score5++;
            if (__jsonProps.Contains("elapsed_ms")) __score5++;
            if (__jsonProps.Contains("event_id")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("channels")) __score6++;
            if (__jsonProps.Contains("delta")) __score6++;
            if (__jsonProps.Contains("elapsed_ms")) __score6++;
            if (__jsonProps.Contains("event_id")) __score6++;
            if (__jsonProps.Contains("format")) __score6++;
            if (__jsonProps.Contains("sample_rate")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }

            global::tryAGI.OpenAI.RealtimeServerEventError? error = default;
            global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionCreated? sessionCreated = default;
            global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionUpdated? sessionUpdated = default;
            global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionClosed? sessionClosed = default;
            global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionInputTranscriptDelta? sessionInputTranscriptDelta = default;
            global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputTranscriptDelta? sessionOutputTranscriptDelta = default;
            global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDelta? sessionOutputAudioDelta = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventError> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventError).Name}");
                        error = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionCreated> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionCreated).Name}");
                        sessionCreated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionUpdated> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionUpdated).Name}");
                        sessionUpdated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionClosed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionClosed> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionClosed).Name}");
                        sessionClosed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionInputTranscriptDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionInputTranscriptDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionInputTranscriptDelta).Name}");
                        sessionInputTranscriptDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputTranscriptDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputTranscriptDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputTranscriptDelta).Name}");
                        sessionOutputTranscriptDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDelta).Name}");
                        sessionOutputAudioDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (error == null && sessionCreated == null && sessionUpdated == null && sessionClosed == null && sessionInputTranscriptDelta == null && sessionOutputTranscriptDelta == null && sessionOutputAudioDelta == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventError> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventError).Name}");
                    error = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionCreated> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionCreated).Name}");
                    sessionCreated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionUpdated> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionUpdated).Name}");
                    sessionUpdated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionClosed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionClosed> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionClosed).Name}");
                    sessionClosed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionInputTranscriptDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionInputTranscriptDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionInputTranscriptDelta).Name}");
                    sessionInputTranscriptDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputTranscriptDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputTranscriptDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputTranscriptDelta).Name}");
                    sessionOutputTranscriptDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDelta).Name}");
                    sessionOutputAudioDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::tryAGI.OpenAI.RealtimeTranslationServerEvent(
                error,

                sessionCreated,

                sessionUpdated,

                sessionClosed,

                sessionInputTranscriptDelta,

                sessionOutputTranscriptDelta,

                sessionOutputAudioDelta
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.RealtimeTranslationServerEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error!, typeInfo);
            }
            else if (value.IsSessionCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionCreated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionCreated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionCreated!, typeInfo);
            }
            else if (value.IsSessionUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionUpdated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionUpdated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionUpdated!, typeInfo);
            }
            else if (value.IsSessionClosed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionClosed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionClosed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionClosed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionClosed!, typeInfo);
            }
            else if (value.IsSessionInputTranscriptDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionInputTranscriptDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionInputTranscriptDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionInputTranscriptDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionInputTranscriptDelta!, typeInfo);
            }
            else if (value.IsSessionOutputTranscriptDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputTranscriptDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputTranscriptDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputTranscriptDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionOutputTranscriptDelta!, typeInfo);
            }
            else if (value.IsSessionOutputAudioDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionOutputAudioDelta!, typeInfo);
            }
        }
    }
}