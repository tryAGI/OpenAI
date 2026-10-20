
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextOrphans_F8E4A398A5210EF4 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextOrphans_F8E4A398A5210EF4 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextOrphans_F8E4A398A5210EF4(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.RealtimeTurnDetectionRealtimeTurnDetection1JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.VoiceIdsSharedJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.AudioTranscriptionResponseModel?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.RealtimeSessionModel?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RealtimeSessionTracingTracingConfigurationEnum?, global::tryAGI.OpenAI.RealtimeSessionTracingTracingConfigurationEnum2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<int?, global::tryAGI.OpenAI.RealtimeSessionMaxResponseOutputTokens?>());
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

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventSessionCreatedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventSessionCreatedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventSessionUpdatedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventSessionUpdatedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeFunctionToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeFunctionToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionModalitie)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionModalitie?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionModel)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionModel?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionInputAudioFormat)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionInputAudioFormat?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionOutputAudioFormat)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionOutputAudioFormat?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionTracingTracingConfigurationEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionTracingTracingConfigurationEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionMaxResponseOutputTokens)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionMaxResponseOutputTokens?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionIncludeVariant1Item)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionIncludeVariant1Item?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagerness)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagerness?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1DiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1DiscriminatorType?)

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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventSessionCreatedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventSessionCreatedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventSessionCreatedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventSessionCreatedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventSessionUpdatedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventSessionUpdatedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventSessionUpdatedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventSessionUpdatedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeFunctionToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeFunctionToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeFunctionToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeFunctionToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionModalitie))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionModalitieJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionModalitie?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionModalitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionModel))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionModelJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionModel?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionInputAudioFormat))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionInputAudioFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionInputAudioFormat?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionInputAudioFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionOutputAudioFormat))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionOutputAudioFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionOutputAudioFormat?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionOutputAudioFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionTracingTracingConfigurationEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionTracingTracingConfigurationEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionTracingTracingConfigurationEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionTracingTracingConfigurationEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionMaxResponseOutputTokens))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionMaxResponseOutputTokensJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionMaxResponseOutputTokens?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionMaxResponseOutputTokensNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionIncludeVariant1Item))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionIncludeVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionIncludeVariant1Item?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionIncludeVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagerness))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagernessJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagerness?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagernessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1DiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTurnDetectionRealtimeTurnDetection1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1DiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTurnDetectionRealtimeTurnDetection1DiscriminatorTypeNullableJsonConverter();
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
                if (type == typeof(bool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Boolean(options);
                }
                if (type == typeof(double))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Double(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeFunctionTool>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_7BFEA1C8021795E2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionIncludeVariant1Item>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_BA254B87D3C258ED(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionModalitie>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_91AAABB28F0F8210(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_05BF36C073875770(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.AudioTranscriptionResponseModel?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_EC3C6F2753247E18(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.RealtimeSessionModel?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_0A8C8E19CA7031C7(options);
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
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionTracingTracingConfigurationEnum?, global::tryAGI.OpenAI.RealtimeSessionTracingTracingConfigurationEnum2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_9A786EA9100AE63B(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionMaxResponseOutputTokens?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_8ABE68620E32301D(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptVariant1))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_PromptVariant1(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventSessionCreated))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaServerEventSessionCreated(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventSessionCreatedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaServerEventSessionCreatedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventSessionUpdated))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaServerEventSessionUpdated(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventSessionUpdatedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaServerEventSessionUpdatedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeFunctionTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeFunctionTool(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeFunctionToolType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeFunctionToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSession))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeSession(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionIncludeVariant1Item))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionIncludeVariant1Item2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionInputAudioFormat))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionInputAudioFormat2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionInputAudioNoiseReduction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionInputAudioNoiseReduction(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionMaxResponseOutputTokens))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionMaxResponseOutputTokens2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionModalitie))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionModalitie2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionModel))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionModel2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionOutputAudioFormat))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionOutputAudioFormat2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionTracingTracingConfigurationEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionTracingTracingConfigurationEnum2_3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionTracingTracingConfigurationEnum2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionTracingTracingConfigurationEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTurnDetectionRealtimeTurnDetection1(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1Discriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTurnDetectionRealtimeTurnDetection1Discriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1DiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTurnDetectionRealtimeTurnDetection1DiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVad))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTurnDetectionRealtimeTurnDetection1SemanticVad(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagerness))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagerness2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1ServerVad))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTurnDetectionRealtimeTurnDetection1ServerVad(options);
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
                if (type == typeof(bool?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableBoolean(options);
                }
                if (type == typeof(double?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableDouble(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.AudioTranscriptionResponseModel?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_EC5D489765B0A1D7(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.RealtimeSessionModel?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_C78671C50648ED52(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AudioTranscriptionResponseModel?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableAudioTranscriptionResponseModel2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.NoiseReductionType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableNoiseReductionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionMaxResponseOutputTokens?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_681612A6F7F339B4(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventSessionCreatedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeBetaServerEventSessionCreatedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventSessionUpdatedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeBetaServerEventSessionUpdatedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeFunctionToolType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeFunctionToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionIncludeVariant1Item?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeSessionIncludeVariant1Item2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionInputAudioFormat?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeSessionInputAudioFormat2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionMaxResponseOutputTokens?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeSessionMaxResponseOutputTokens2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionModalitie?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeSessionModalitie2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionModel?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeSessionModel2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeSessionObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionOutputAudioFormat?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeSessionOutputAudioFormat2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionTracingTracingConfigurationEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeSessionTracingTracingConfigurationEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1DiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeTurnDetectionRealtimeTurnDetection1DiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagerness?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagerness2(options);
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
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionIncludeVariant1Item>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_E1E3611B7AF3B26B(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionModalitie>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_C8F89B1336EDBE29(options);
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