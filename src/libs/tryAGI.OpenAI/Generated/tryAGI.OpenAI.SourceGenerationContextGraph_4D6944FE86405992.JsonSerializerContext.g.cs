
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_4D6944FE86405992 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_4D6944FE86405992 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_4D6944FE86405992(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.RealtimeAudioFormatsJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.RealtimeTruncationJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.VoiceIdsOrCustomVoiceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.VoiceIdsSharedJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.AudioTranscriptionResponseModel?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<int?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestMaxResponseOutputTokens?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<int?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseMaxOutputTokens?>());
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

                    || typeToConvert == typeof(global::tryAGI.OpenAI.NoiseReductionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.NoiseReductionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmAudioFormatType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmAudioFormatType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmuAudioFormatType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmuAudioFormatType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmaAudioFormatType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmaAudioFormatType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeFunctionToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeFunctionToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestModalitie)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestModalitie?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestMaxResponseOutputTokens)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestMaxResponseOutputTokens?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseIncludeItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseIncludeItem?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseOutputModalitie)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseOutputModalitie?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseMaxOutputTokens)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseMaxOutputTokens?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTruncationEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTruncationEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTruncationEnumType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTruncationEnumType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VoiceIdsSharedEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VoiceIdsSharedEnum?);
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.NoiseReductionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.NoiseReductionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.NoiseReductionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.NoiseReductionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmAudioFormatType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeAudioFormatsPcmAudioFormatTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmAudioFormatType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeAudioFormatsPcmAudioFormatTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmuAudioFormatType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeAudioFormatsPcmuAudioFormatTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmuAudioFormatType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeAudioFormatsPcmuAudioFormatTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmaAudioFormatType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeAudioFormatsPcmaAudioFormatTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmaAudioFormatType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeAudioFormatsPcmaAudioFormatTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeFunctionToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeFunctionToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeFunctionToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeFunctionToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestModalitie))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestModalitieJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestModalitie?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestModalitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestTracingEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestTracingEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestMaxResponseOutputTokens))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestMaxResponseOutputTokensJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestMaxResponseOutputTokens?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestMaxResponseOutputTokensNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseIncludeItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseIncludeItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseOutputModalitie))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseOutputModalitieJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseOutputModalitie?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseOutputModalitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseTracingEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseTracingEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseMaxOutputTokens))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseMaxOutputTokensJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseMaxOutputTokens?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseMaxOutputTokensNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTruncationEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTruncationEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTruncationEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTruncationEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTruncationEnumType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTruncationEnumTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTruncationEnumType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTruncationEnumTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VoiceIdsSharedEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VoiceIdsSharedEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VoiceIdsSharedEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VoiceIdsSharedEnumNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeFunctionTool>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_7BFEA1C8021795E2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateRequestModalitie>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_44C8A2CAB8D21376(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateRequestTool>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_985CCF1E5253FD77(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateResponseIncludeItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_C1172FF86ACD4E4E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateResponseOutputModalitie>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_8FB3D85D9B9481B1(options);
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
                if (type == typeof(global::tryAGI.OpenAI.NoiseReductionType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_NoiseReductionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_570BDB5E70896CC3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_8E0DF4C28172592D(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestMaxResponseOutputTokens?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_57E6ACBA3F36CE72(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseMaxOutputTokens?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_109B7759CDDC6CBC(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptVariant1))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_PromptVariant1(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeAudioFormats))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeAudioFormats2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmAudioFormat))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeAudioFormatsPcmAudioFormat(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmAudioFormatType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeAudioFormatsPcmAudioFormatType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmaAudioFormat))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeAudioFormatsPcmaAudioFormat(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmaAudioFormatType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeAudioFormatsPcmaAudioFormatType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmuAudioFormat))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeAudioFormatsPcmuAudioFormat(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmuAudioFormatType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeAudioFormatsPcmuAudioFormatType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeFunctionTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeFunctionTool(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeFunctionToolType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeFunctionToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequest))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeSessionCreateRequest(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestClientSecret))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateRequestClientSecret(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestInputAudioTranscription))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateRequestInputAudioTranscription(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestMaxResponseOutputTokens))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateRequestMaxResponseOutputTokens2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestModalitie))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateRequestModalitie2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateRequestTool(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestToolType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateRequestToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateRequestTracingEnum2_3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateRequestTracingEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestTurnDetection))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateRequestTurnDetection(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateResponse(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudio))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateResponseAudio(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioInput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateResponseAudioInput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioInputNoiseReduction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateResponseAudioInputNoiseReduction(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioInputTurnDetection))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateResponseAudioInputTurnDetection(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioOutput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateResponseAudioOutput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseIncludeItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateResponseIncludeItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseMaxOutputTokens))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateResponseMaxOutputTokens2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseOutputModalitie))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateResponseOutputModalitie2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateResponseTracingEnum2_3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateResponseTracingEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseTurnDetection))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateResponseTurnDetection(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTruncation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTruncation2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTruncationEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTruncationEnum2_3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTruncationEnum2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTruncationEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTruncationEnumTokenLimits))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTruncationEnumTokenLimits(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTruncationEnumType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTruncationEnumType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VoiceIdsOrCustomVoice))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_VoiceIdsOrCustomVoice2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VoiceIdsOrCustomVoiceVariant2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_VoiceIdsOrCustomVoiceVariant2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VoiceIdsShared))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_VoiceIdsShared2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VoiceIdsSharedEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_VoiceIdsSharedEnum2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.NoiseReductionType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableNoiseReductionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_C47D1E3F5FBD022F(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_7CF88A1076F762A1(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestMaxResponseOutputTokens?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_70B2EAF72DCDCE89(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseMaxOutputTokens?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_5C4C0A32D13DDABC(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeAudioFormats?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeAudioFormats2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmAudioFormatType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeAudioFormatsPcmAudioFormatType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmaAudioFormatType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeAudioFormatsPcmaAudioFormatType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmuAudioFormatType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeAudioFormatsPcmuAudioFormatType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeFunctionToolType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeFunctionToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestMaxResponseOutputTokens?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeSessionCreateRequestMaxResponseOutputTokens2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestModalitie?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeSessionCreateRequestModalitie2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestToolType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeSessionCreateRequestToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeSessionCreateRequestTracingEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseIncludeItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeSessionCreateResponseIncludeItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseMaxOutputTokens?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeSessionCreateResponseMaxOutputTokens2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseOutputModalitie?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeSessionCreateResponseOutputModalitie2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeSessionCreateResponseTracingEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTruncation?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeTruncation2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTruncationEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeTruncationEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTruncationEnumType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeTruncationEnumType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VoiceIdsOrCustomVoice?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableVoiceIdsOrCustomVoice2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VoiceIdsShared?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableVoiceIdsShared2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VoiceIdsSharedEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableVoiceIdsSharedEnum2(options);
                }
                if (type == typeof(int?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeFunctionTool>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_06D6E8841CC80CA0(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionCreateRequestModalitie>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_FE0E34BB0CBFDBC4(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionCreateRequestTool>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_4238357461C7FA51(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionCreateResponseIncludeItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_15C6A4CA809E4F8E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionCreateResponseOutputModalitie>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_1B6B4FCABE137048(options);
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