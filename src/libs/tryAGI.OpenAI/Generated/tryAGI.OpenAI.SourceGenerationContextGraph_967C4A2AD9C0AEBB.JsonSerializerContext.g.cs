
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_967C4A2AD9C0AEBB : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_967C4A2AD9C0AEBB Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_967C4A2AD9C0AEBB(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.Session2JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.RealtimeTruncationJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.RealtimeTurnDetectionRealtimeTurnDetection1JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.VoiceIdsOrCustomVoiceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.VoiceIdsSharedJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.AudioTranscriptionModel?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.AudioTranscriptionResponseModel?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, global::tryAGI.OpenAI.MCPToolFilter>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum, global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA, global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA, global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RealtimeFunctionTool, global::tryAGI.OpenAI.MCPTool>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAModel?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RealtimeFunctionTool, global::tryAGI.OpenAI.MCPTool>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<int?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAMaxOutputTokens?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAModel?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingTracingConfigurationEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingTracingConfigurationEnum2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RealtimeFunctionTool, global::tryAGI.OpenAI.MCPTool>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<int?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAMaxOutputTokens?>());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.AudioTranscriptionModel)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AudioTranscriptionModel?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AudioTranscriptionDelay)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AudioTranscriptionDelay?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AudioTranscriptionResponseModel)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AudioTranscriptionResponseModel?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolConnectorId)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolConnectorId?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.NoiseReductionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.NoiseReductionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmAudioFormatType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmAudioFormatType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmuAudioFormatType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmuAudioFormatType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmaAudioFormatType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsPcmaAudioFormatType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeCreateClientSecretRequestExpiresAfterAnchor)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeCreateClientSecretRequestExpiresAfterAnchor?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeCreateClientSecretResponseSessionDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeCreateClientSecretResponseSessionDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeFunctionToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeFunctionToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeReasoningEffort)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeReasoningEffort?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAOutputModalitie)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAOutputModalitie?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAModel)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAModel?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAIncludeItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAIncludeItem?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAMaxOutputTokens)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAMaxOutputTokens?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAOutputModalitie)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAOutputModalitie?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAModel)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAModel?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAIncludeItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAIncludeItem?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingTracingConfigurationEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingTracingConfigurationEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAMaxOutputTokens)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAMaxOutputTokens?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAIncludeItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAIncludeItem?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAIncludeItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAIncludeItem?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTruncationEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTruncationEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTruncationEnumType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTruncationEnumType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagerness)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagerness?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1DiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1DiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceFunctionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceFunctionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceMCPType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceMCPType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceOptions)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceOptions?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VoiceIdsSharedEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VoiceIdsSharedEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CallableToolAllowedCaller)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CallableToolAllowedCaller?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.AudioTranscriptionModel))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AudioTranscriptionModelJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AudioTranscriptionModel?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AudioTranscriptionModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AudioTranscriptionDelay))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AudioTranscriptionDelayJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AudioTranscriptionDelay?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AudioTranscriptionDelayNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AudioTranscriptionResponseModel))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AudioTranscriptionResponseModelJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AudioTranscriptionResponseModel?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AudioTranscriptionResponseModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolConnectorId))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPToolConnectorIdJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolConnectorId?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPToolConnectorIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPToolRequireApprovalVariant1Enum2JsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPToolRequireApprovalVariant1Enum2NullableJsonConverter();
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeCreateClientSecretRequestExpiresAfterAnchor))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeCreateClientSecretRequestExpiresAfterAnchorJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeCreateClientSecretRequestExpiresAfterAnchor?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeCreateClientSecretRequestExpiresAfterAnchorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeCreateClientSecretResponseSessionDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeCreateClientSecretResponseSessionDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeCreateClientSecretResponseSessionDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeCreateClientSecretResponseSessionDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeFunctionToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeFunctionToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeFunctionToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeFunctionToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeReasoningEffort))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeReasoningEffort?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestGATypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestGATypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAOutputModalitie))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestGAOutputModalitieJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAOutputModalitie?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestGAOutputModalitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAModel))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestGAModelJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAModel?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestGAModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAIncludeItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestGAIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAIncludeItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestGAIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestGATracingEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestGATracingEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAMaxOutputTokens))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestGAMaxOutputTokensJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAMaxOutputTokens?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestGAMaxOutputTokensNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseGATypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseGATypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseGAObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseGAObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAOutputModalitie))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseGAOutputModalitieJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAOutputModalitie?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseGAOutputModalitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAModel))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseGAModelJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAModel?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseGAModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAIncludeItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseGAIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAIncludeItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseGAIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingTracingConfigurationEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseGATracingTracingConfigurationEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingTracingConfigurationEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseGATracingTracingConfigurationEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAMaxOutputTokens))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseGAMaxOutputTokensJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAMaxOutputTokens?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseGAMaxOutputTokensNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateRequestGATypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateRequestGATypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAIncludeItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateRequestGAIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAIncludeItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateRequestGAIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateResponseGATypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateResponseGATypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAIncludeItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateResponseGAIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAIncludeItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateResponseGAIncludeItemNullableJsonConverter();
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceFunctionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceFunctionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceFunctionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceFunctionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceMCPType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceMCPTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceMCPType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceMCPTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceOptions))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceOptionsJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceOptions?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceOptionsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VoiceIdsSharedEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VoiceIdsSharedEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VoiceIdsSharedEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VoiceIdsSharedEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CallableToolAllowedCaller))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CallableToolAllowedCallerJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CallableToolAllowedCaller?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CallableToolAllowedCallerNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CallableToolAllowedCaller>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_910023668A7B8D0B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeFunctionTool, global::tryAGI.OpenAI.MCPTool>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_E57DBB50EBD7946A(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAIncludeItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_1EE7671040E4F48C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAOutputModalitie>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_1336C8A54D025F0C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAIncludeItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_9E042FD213F8467A(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAOutputModalitie>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_ED3497A2CC700008(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAIncludeItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_E189269D972D32B4(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAIncludeItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_858D49B768E91713(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_05BF36C073875770(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.AudioTranscriptionModel?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_13F5F4F9C54BA711(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.AudioTranscriptionResponseModel?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_EC3C6F2753247E18(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAModel?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_F1C5BEFADCB57B0E(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAModel?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_C9B35199FE48552F(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AudioTranscription))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AudioTranscription(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AudioTranscriptionDelay))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AudioTranscriptionDelay2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AudioTranscriptionModel))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AudioTranscriptionModel2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AudioTranscriptionResponse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AudioTranscriptionResponse(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AudioTranscriptionResponseModel))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AudioTranscriptionResponseModel2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CallableToolAllowedCaller))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CallableToolAllowedCaller2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MCPTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MCPTool(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.MCPToolConnectorId))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MCPToolConnectorId2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::tryAGI.OpenAI.MCPToolFilter))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MCPToolFilter(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MCPToolRequireApprovalVariant1Enum(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MCPToolRequireApprovalVariant1Enum22(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MCPToolType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MCPToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.NoiseReductionType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_NoiseReductionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<string>, global::tryAGI.OpenAI.MCPToolFilter>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_A7B4DB888D6EF634(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum, global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_AE78E24B968C5FEC(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeFunctionTool, global::tryAGI.OpenAI.MCPTool>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_EC21B8C895D61C89(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA, global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_5B3CFAE59259EB39(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_685FE089EEEF418E(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingTracingConfigurationEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingTracingConfigurationEnum2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_3E9682197C3EDA67(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_39CACFCBC1CBB46B(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAMaxOutputTokens?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_679C8DF89AE5E67A(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAMaxOutputTokens?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_B843E66BCBB09CE6(options);
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
                if (type == typeof(global::tryAGI.OpenAI.RealtimeCreateClientSecretRequest))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeCreateClientSecretRequest(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeCreateClientSecretRequestExpiresAfter))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeCreateClientSecretRequestExpiresAfter(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeCreateClientSecretRequestExpiresAfterAnchor))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeCreateClientSecretRequestExpiresAfterAnchor2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeCreateClientSecretResponse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeCreateClientSecretResponse(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeCreateClientSecretResponseSessionDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeCreateClientSecretResponseSessionDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeCreateClientSecretResponseSessionDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeCreateClientSecretResponseSessionDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeFunctionTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeFunctionTool(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeFunctionToolType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeFunctionToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeReasoning))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeReasoning(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeReasoningEffort))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeReasoningEffort2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeSessionCreateRequestGA(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAAudio))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateRequestGAAudio(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAAudioInput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateRequestGAAudioInput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAAudioInputNoiseReduction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateRequestGAAudioInputNoiseReduction(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAAudioOutput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateRequestGAAudioOutput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAIncludeItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateRequestGAIncludeItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAMaxOutputTokens))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateRequestGAMaxOutputTokens2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAModel))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateRequestGAModel2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAOutputModalitie))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateRequestGAOutputModalitie2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateRequestGATracingEnum2_3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateRequestGATracingEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateRequestGAType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeSessionCreateResponseGA(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAAudio))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateResponseGAAudio(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAAudioInput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateResponseGAAudioInput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAAudioInputNoiseReduction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateResponseGAAudioInputNoiseReduction(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAAudioOutput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateResponseGAAudioOutput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAIncludeItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateResponseGAIncludeItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAMaxOutputTokens))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateResponseGAMaxOutputTokens2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAModel))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateResponseGAModel2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateResponseGAObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAOutputModalitie))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateResponseGAOutputModalitie2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingTracingConfigurationEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateResponseGATracingTracingConfigurationEnum2_3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingTracingConfigurationEnum2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateResponseGATracingTracingConfigurationEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeSessionCreateResponseGAType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeTranscriptionSessionCreateRequestGA(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAAudio))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTranscriptionSessionCreateRequestGAAudio(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAAudioInput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTranscriptionSessionCreateRequestGAAudioInput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAAudioInputNoiseReduction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTranscriptionSessionCreateRequestGAAudioInputNoiseReduction(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAIncludeItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTranscriptionSessionCreateRequestGAIncludeItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTranscriptionSessionCreateRequestGAType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeTranscriptionSessionCreateResponseGA(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAAudio))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTranscriptionSessionCreateResponseGAAudio(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAAudioInput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTranscriptionSessionCreateResponseGAAudioInput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAAudioInputNoiseReduction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTranscriptionSessionCreateResponseGAAudioInputNoiseReduction(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAAudioInputTurnDetection))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTranscriptionSessionCreateResponseGAAudioInputTurnDetection(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAIncludeItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTranscriptionSessionCreateResponseGAIncludeItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTranscriptionSessionCreateResponseGAType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.Session2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Session22(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceFunction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ToolChoiceFunction(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceFunctionType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolChoiceFunctionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceMCP))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ToolChoiceMCP(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceMCPType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolChoiceMCPType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceOptions))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ToolChoiceOptions2(options);
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
                if (type == typeof(long))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Int64(options);
                }
                if (type == typeof(bool?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableBoolean(options);
                }
                if (type == typeof(double?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableDouble(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.AudioTranscriptionModel?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_6EE9B779FD7F561B(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.AudioTranscriptionResponseModel?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_EC5D489765B0A1D7(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAModel?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_37D0FD8F91E157A3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAModel?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_A354850995A84FC9(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AudioTranscriptionDelay?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableAudioTranscriptionDelay2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AudioTranscriptionModel?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableAudioTranscriptionModel2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AudioTranscriptionResponseModel?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableAudioTranscriptionResponseModel2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CallableToolAllowedCaller?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableCallableToolAllowedCaller2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.MCPToolConnectorId?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMCPToolConnectorId2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMCPToolRequireApprovalVariant1Enum22(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MCPToolType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMCPToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.NoiseReductionType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableNoiseReductionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeFunctionTool, global::tryAGI.OpenAI.MCPTool>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_982AFE7CF0981952(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA, global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_9E5604C54E1A6F8E(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_D6F7C8D2BBDA5C78(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_C8889130C8D4F808(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAMaxOutputTokens?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_A70AD6BCB38B3067(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAMaxOutputTokens?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_12D81038389C0A49(options);
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
                if (type == typeof(global::tryAGI.OpenAI.RealtimeCreateClientSecretRequestExpiresAfterAnchor?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeCreateClientSecretRequestExpiresAfterAnchor2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeCreateClientSecretResponseSessionDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeCreateClientSecretResponseSessionDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeFunctionToolType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeFunctionToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeReasoningEffort?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeReasoningEffort2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAIncludeItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeSessionCreateRequestGAIncludeItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAMaxOutputTokens?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeSessionCreateRequestGAMaxOutputTokens2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAModel?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeSessionCreateRequestGAModel2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAOutputModalitie?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeSessionCreateRequestGAOutputModalitie2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeSessionCreateRequestGATracingEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeSessionCreateRequestGAType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAIncludeItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeSessionCreateResponseGAIncludeItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAMaxOutputTokens?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeSessionCreateResponseGAMaxOutputTokens2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAModel?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeSessionCreateResponseGAModel2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeSessionCreateResponseGAObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAOutputModalitie?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeSessionCreateResponseGAOutputModalitie2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingTracingConfigurationEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeSessionCreateResponseGATracingTracingConfigurationEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeSessionCreateResponseGAType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAIncludeItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeTranscriptionSessionCreateRequestGAIncludeItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeTranscriptionSessionCreateRequestGAType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAIncludeItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeTranscriptionSessionCreateResponseGAIncludeItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeTranscriptionSessionCreateResponseGAType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1DiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeTurnDetectionRealtimeTurnDetection1DiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagerness?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagerness2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Session2?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableSession22(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceFunctionType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableToolChoiceFunctionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceMCPType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableToolChoiceMCPType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceOptions?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableToolChoiceOptions2(options);
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
                if (type == typeof(long?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt64(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CallableToolAllowedCaller>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_A0102E6B0439FF50(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeFunctionTool, global::tryAGI.OpenAI.MCPTool>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_C74C5F6F3081F1DC(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAIncludeItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_F4C8BAD8BB2460A1(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAOutputModalitie>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_FDE0684BE0CE8575(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAIncludeItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_647DD0E7EEB9C648(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAOutputModalitie>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_48D4CA990A8EC3FE(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAIncludeItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_2D841FF49124F9A3(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAIncludeItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_8450EDE56BFBFF47(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_3F34DBFD50DE05D2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.List<string>, global::tryAGI.OpenAI.MCPToolFilter>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_209335A1CF98F53C(options);
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