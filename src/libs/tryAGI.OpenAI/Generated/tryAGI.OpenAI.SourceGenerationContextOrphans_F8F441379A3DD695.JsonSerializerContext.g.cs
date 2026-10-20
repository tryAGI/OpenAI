
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextOrphans_F8F441379A3DD695 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextOrphans_F8F441379A3DD695 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextOrphans_F8F441379A3DD695(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.AudioTranscriptionResponseModel?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::tryAGI.OpenAI.AudioTranscriptionResponseModel)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AudioTranscriptionResponseModel?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventTranscriptionSessionUpdatedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventTranscriptionSessionUpdatedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseModalitie)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseModalitie?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.AudioTranscriptionResponseModel))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AudioTranscriptionResponseModelJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AudioTranscriptionResponseModel?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AudioTranscriptionResponseModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventTranscriptionSessionUpdatedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventTranscriptionSessionUpdatedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventTranscriptionSessionUpdatedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventTranscriptionSessionUpdatedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseModalitie))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateResponseModalitieJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseModalitie?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateResponseModalitieNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }
        private sealed class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::System.Collections.Generic.Dictionary<string, string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_FC0ACBA26C044EC8(options);
                }
                if (type == typeof(global::System.Collections.Generic.Dictionary<string, object>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_8219E7AD6AEFA4B4(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<object>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_92E1ACA86984772C(options);
                }
                if (type == typeof(global::System.Text.Json.JsonElement?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_NullableJsonElement(options);
                }
                if (type == typeof(global::System.Collections.Generic.IDictionary<string, object>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_7024F6984ED20EB8(options);
                }
                if (type == typeof(string))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_String(options);
                }
                if (type == typeof(object))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Object(options);
                }
                if (type == typeof(global::System.Text.Json.JsonElement))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_JsonElement(options);
                }
                if (type == typeof(double))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Double(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseModalitie>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_F22AFE7F9BA370E3(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_05BF36C073875770(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.AudioTranscriptionResponseModel?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_EC3C6F2753247E18(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AudioTranscriptionResponse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AudioTranscriptionResponse(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AudioTranscriptionResponseModel))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AudioTranscriptionResponseModel2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventTranscriptionSessionUpdated))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventTranscriptionSessionUpdated(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventTranscriptionSessionUpdatedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventTranscriptionSessionUpdatedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeTranscriptionSessionCreateResponse(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseClientSecret))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTranscriptionSessionCreateResponseClientSecret(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseModalitie))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTranscriptionSessionCreateResponseModalitie2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseTurnDetection))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTranscriptionSessionCreateResponseTurnDetection(options);
                }
                if (type == typeof(int))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(double?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableDouble(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.AudioTranscriptionResponseModel?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_EC5D489765B0A1D7(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AudioTranscriptionResponseModel?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableAudioTranscriptionResponseModel2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventTranscriptionSessionUpdatedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventTranscriptionSessionUpdatedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseModalitie?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeTranscriptionSessionCreateResponseModalitie2(options);
                }
                if (type == typeof(int?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseModalitie>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_EBF0541900868A8D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_3F34DBFD50DE05D2(options);
                }
                return null;
            }
        }


        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new SharedMetadataResolver(),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}