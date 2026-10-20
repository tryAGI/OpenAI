
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextOrphans_AA815EAD7253A41C : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextOrphans_AA815EAD7253A41C Default { get; } = new(DefaultOptions);

        private SourceGenerationContextOrphans_AA815EAD7253A41C(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.RealtimeTranslationServerEventJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.RealtimeTruncationJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.RealtimeTurnDetectionRealtimeTurnDetection1JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.VoiceIdsOrCustomVoiceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.VoiceIdsSharedJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.AudioTranscriptionModel?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.AudioTranscriptionResponseModel?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.TranscriptTextUsageTokens, global::tryAGI.OpenAI.TranscriptTextUsageDuration>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, global::tryAGI.OpenAI.MCPToolFilter>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum, global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<int?, global::tryAGI.OpenAI.RealtimeBetaResponseMaxOutputTokens?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<int?, global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsMaxOutputTokens?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsConversation?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.TranscriptTextUsageTokens, global::tryAGI.OpenAI.TranscriptTextUsageDuration>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA, global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA, global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RealtimeMCPProtocolError, global::tryAGI.OpenAI.RealtimeMCPToolExecutionError, global::tryAGI.OpenAI.RealtimeMCPHTTPError>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<int?, global::tryAGI.OpenAI.RealtimeResponseMaxOutputTokens?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RealtimeFunctionTool, global::tryAGI.OpenAI.MCPTool>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<int?, global::tryAGI.OpenAI.RealtimeResponseCreateParamsMaxOutputTokens?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::tryAGI.OpenAI.RealtimeResponseCreateParamsConversation?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.TranscriptTextUsageTokens, global::tryAGI.OpenAI.TranscriptTextUsageDuration>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA, global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA, global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA>());
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

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemCreateType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemCreateType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaClientEventResponseCreateType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaClientEventResponseCreateType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetailsType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetailsType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetailsReason)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetailsReason?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseModalitie)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseModalitie?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseOutputAudioFormat)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseOutputAudioFormat?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseMaxOutputTokens)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseMaxOutputTokens?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsModalitie)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsModalitie?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsOutputAudioFormat)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsOutputAudioFormat?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsMaxOutputTokens)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsMaxOutputTokens?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsConversation)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsConversation?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemCreatedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemCreatedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionCompletedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionCompletedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionDeltaType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionDeltaType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemRetrievedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemRetrievedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseCreatedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseCreatedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseDoneType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseDoneType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseOutputItemAddedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseOutputItemAddedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseOutputItemDoneType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseOutputItemDoneType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventConversationItemCreateType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventConversationItemCreateType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventConversationItemDeleteType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventConversationItemDeleteType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventConversationItemRetrieveType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventConversationItemRetrieveType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventConversationItemTruncateType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventConversationItemTruncateType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferAppendType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferAppendType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferClearType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferClearType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferCommitType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferCommitType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventOutputAudioBufferClearType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventOutputAudioBufferClearType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventResponseCancelType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventResponseCancelType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventResponseCreateType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventResponseCreateType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventSessionUpdateType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventSessionUpdateType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutputObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutputObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutputStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutputStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantContentItemType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantContentItemType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemContentItemType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemContentItemType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItemType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItemType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItemDetail)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItemDetail?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeFunctionToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeFunctionToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeMCPApprovalRequestType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeMCPApprovalRequestType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeMCPApprovalResponseType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeMCPApprovalResponseType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeMCPHTTPErrorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeMCPHTTPErrorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeMCPListToolsType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeMCPListToolsType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeMCPProtocolErrorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeMCPProtocolErrorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeMCPToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeMCPToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeMCPToolExecutionErrorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeMCPToolExecutionErrorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeReasoningEffort)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeReasoningEffort?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeResponseObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeResponseObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeResponseStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeResponseStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeResponseStatusDetailsType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeResponseStatusDetailsType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeResponseStatusDetailsReason)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeResponseStatusDetailsReason?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeResponseOutputModalitie)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeResponseOutputModalitie?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeResponseMaxOutputTokens)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeResponseMaxOutputTokens?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeResponseCreateParamsOutputModalitie)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeResponseCreateParamsOutputModalitie?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeResponseCreateParamsMaxOutputTokens)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeResponseCreateParamsMaxOutputTokens?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeResponseCreateParamsConversation)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeResponseCreateParamsConversation?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationCreatedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationCreatedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemAddedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemAddedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreatedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreatedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemDeletedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemDeletedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemDoneType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemDoneType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionCompletedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionCompletedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionDeltaType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionDeltaType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegmentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegmentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemRetrievedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemRetrievedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemTruncatedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemTruncatedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventErrorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventErrorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferClearedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferClearedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCommittedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCommittedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceivedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceivedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStartedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStartedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStoppedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStoppedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggeredType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggeredType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsCompletedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsCompletedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsFailedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsFailedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgressType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgressType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferClearedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferClearedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStartedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStartedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStoppedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStoppedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdatedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdatedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdatedRateLimitName)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdatedRateLimitName?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDeltaType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDeltaType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDoneType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDoneType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDeltaType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDeltaType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDoneType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDoneType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAddedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAddedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAddedPartType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAddedPartType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDoneType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDoneType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDonePartType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDonePartType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseCreatedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseCreatedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseDoneType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseDoneType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDeltaType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDeltaType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDoneType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDoneType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDeltaType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDeltaType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDoneType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDoneType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallCompletedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallCompletedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallFailedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallFailedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallInProgressType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallInProgressType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAddedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAddedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemDoneType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemDoneType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseTextDeltaType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseTextDeltaType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseTextDoneType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseTextDoneType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventSessionCreatedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventSessionCreatedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventSessionUpdatedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventSessionUpdatedType?)

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

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionClosedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionClosedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionCreatedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionCreatedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionInputTranscriptDeltaType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionInputTranscriptDeltaType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDeltaType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDeltaType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDeltaFormat)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDeltaFormat?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputTranscriptDeltaType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputTranscriptDeltaType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionUpdatedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionUpdatedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationSessionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationSessionType?)

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

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextUsageDurationType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextUsageDurationType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextUsageTokensType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextUsageTokensType?)

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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemCreateType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaClientEventConversationItemCreateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemCreateType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaClientEventConversationItemCreateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaClientEventResponseCreateType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaClientEventResponseCreateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaClientEventResponseCreateType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaClientEventResponseCreateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetailsType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseStatusDetailsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetailsType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseStatusDetailsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetailsReason))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseStatusDetailsReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetailsReason?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseStatusDetailsReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseModalitie))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseModalitieJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseModalitie?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseModalitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseOutputAudioFormat))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseOutputAudioFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseOutputAudioFormat?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseOutputAudioFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseMaxOutputTokens))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseMaxOutputTokensJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseMaxOutputTokens?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseMaxOutputTokensNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsModalitie))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseCreateParamsModalitieJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsModalitie?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseCreateParamsModalitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsOutputAudioFormat))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseCreateParamsOutputAudioFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsOutputAudioFormat?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseCreateParamsOutputAudioFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseCreateParamsToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseCreateParamsToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsMaxOutputTokens))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseCreateParamsMaxOutputTokensJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsMaxOutputTokens?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseCreateParamsMaxOutputTokensNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsConversation))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseCreateParamsConversationJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsConversation?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseCreateParamsConversationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemCreatedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventConversationItemCreatedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemCreatedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventConversationItemCreatedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionCompletedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventConversationItemInputAudioTranscriptionCompletedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionCompletedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventConversationItemInputAudioTranscriptionCompletedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionDeltaType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventConversationItemInputAudioTranscriptionDeltaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionDeltaType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventConversationItemInputAudioTranscriptionDeltaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemRetrievedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventConversationItemRetrievedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemRetrievedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventConversationItemRetrievedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseCreatedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseCreatedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseCreatedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseCreatedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseDoneType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseDoneTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseDoneType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseDoneTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseOutputItemAddedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseOutputItemAddedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseOutputItemAddedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseOutputItemAddedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseOutputItemDoneType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseOutputItemDoneTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseOutputItemDoneType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseOutputItemDoneTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventConversationItemCreateType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventConversationItemCreateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventConversationItemCreateType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventConversationItemCreateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventConversationItemDeleteType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventConversationItemDeleteTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventConversationItemDeleteType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventConversationItemDeleteTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventConversationItemRetrieveType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventConversationItemRetrieveTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventConversationItemRetrieveType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventConversationItemRetrieveTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventConversationItemTruncateType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventConversationItemTruncateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventConversationItemTruncateType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventConversationItemTruncateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferAppendType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventInputAudioBufferAppendTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferAppendType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventInputAudioBufferAppendTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferClearType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventInputAudioBufferClearTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferClearType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventInputAudioBufferClearTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferCommitType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventInputAudioBufferCommitTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferCommitType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventInputAudioBufferCommitTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventOutputAudioBufferClearType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventOutputAudioBufferClearTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventOutputAudioBufferClearType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventOutputAudioBufferClearTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventResponseCancelType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventResponseCancelTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventResponseCancelType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventResponseCancelTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventResponseCreateType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventResponseCreateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventResponseCreateType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventResponseCreateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventSessionUpdateType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventSessionUpdateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeClientEventSessionUpdateType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventSessionUpdateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemFunctionCallObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemFunctionCallObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemFunctionCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemFunctionCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemFunctionCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemFunctionCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutputObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemFunctionCallOutputObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutputObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemFunctionCallOutputObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemFunctionCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemFunctionCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutputStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemFunctionCallOutputStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutputStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemFunctionCallOutputStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageAssistantObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageAssistantObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageAssistantTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageAssistantTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageAssistantStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageAssistantStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageAssistantRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageAssistantRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantContentItemType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageAssistantContentItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantContentItemType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageAssistantContentItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageSystemObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageSystemObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageSystemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageSystemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageSystemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageSystemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageSystemRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageSystemRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemContentItemType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageSystemContentItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemContentItemType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageSystemContentItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageUserObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageUserObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageUserTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageUserTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageUserStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageUserStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageUserRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageUserRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItemType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageUserContentItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItemType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageUserContentItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItemDetail))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageUserContentItemDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItemDetail?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeConversationItemMessageUserContentItemDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeFunctionToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeFunctionToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeFunctionToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeFunctionToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeMCPApprovalRequestType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeMCPApprovalRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeMCPApprovalRequestType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeMCPApprovalRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeMCPApprovalResponseType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeMCPApprovalResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeMCPApprovalResponseType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeMCPApprovalResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeMCPHTTPErrorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeMCPHTTPErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeMCPHTTPErrorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeMCPHTTPErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeMCPListToolsType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeMCPListToolsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeMCPListToolsType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeMCPListToolsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeMCPProtocolErrorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeMCPProtocolErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeMCPProtocolErrorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeMCPProtocolErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeMCPToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeMCPToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeMCPToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeMCPToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeMCPToolExecutionErrorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeMCPToolExecutionErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeMCPToolExecutionErrorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeMCPToolExecutionErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeReasoningEffort))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeReasoningEffort?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeResponseObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeResponseObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeResponseStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeResponseStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeResponseStatusDetailsType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeResponseStatusDetailsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeResponseStatusDetailsType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeResponseStatusDetailsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeResponseStatusDetailsReason))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeResponseStatusDetailsReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeResponseStatusDetailsReason?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeResponseStatusDetailsReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeResponseOutputModalitie))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeResponseOutputModalitieJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeResponseOutputModalitie?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeResponseOutputModalitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeResponseMaxOutputTokens))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeResponseMaxOutputTokensJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeResponseMaxOutputTokens?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeResponseMaxOutputTokensNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeResponseCreateParamsOutputModalitie))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeResponseCreateParamsOutputModalitieJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeResponseCreateParamsOutputModalitie?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeResponseCreateParamsOutputModalitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeResponseCreateParamsMaxOutputTokens))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeResponseCreateParamsMaxOutputTokensJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeResponseCreateParamsMaxOutputTokens?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeResponseCreateParamsMaxOutputTokensNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeResponseCreateParamsConversation))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeResponseCreateParamsConversationJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeResponseCreateParamsConversation?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeResponseCreateParamsConversationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationCreatedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationCreatedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationCreatedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationCreatedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemAddedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemAddedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemAddedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemAddedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreatedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemCreatedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreatedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemCreatedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemDeletedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemDeletedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemDeletedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemDeletedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemDoneType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemDoneTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemDoneType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemDoneTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionCompletedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemInputAudioTranscriptionCompletedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionCompletedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemInputAudioTranscriptionCompletedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionDeltaType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemInputAudioTranscriptionDeltaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionDeltaType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemInputAudioTranscriptionDeltaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemInputAudioTranscriptionFailedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemInputAudioTranscriptionFailedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegmentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemInputAudioTranscriptionSegmentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegmentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemInputAudioTranscriptionSegmentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemRetrievedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemRetrievedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemRetrievedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemRetrievedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemTruncatedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemTruncatedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemTruncatedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationItemTruncatedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventErrorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventErrorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferClearedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventInputAudioBufferClearedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferClearedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventInputAudioBufferClearedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCommittedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventInputAudioBufferCommittedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCommittedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventInputAudioBufferCommittedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceivedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventInputAudioBufferDtmfEventReceivedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceivedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventInputAudioBufferDtmfEventReceivedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStartedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventInputAudioBufferSpeechStartedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStartedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventInputAudioBufferSpeechStartedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStoppedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventInputAudioBufferSpeechStoppedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStoppedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventInputAudioBufferSpeechStoppedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggeredType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventInputAudioBufferTimeoutTriggeredTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggeredType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventInputAudioBufferTimeoutTriggeredTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsCompletedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventMCPListToolsCompletedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsCompletedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventMCPListToolsCompletedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsFailedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventMCPListToolsFailedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsFailedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventMCPListToolsFailedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgressType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventMCPListToolsInProgressTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgressType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventMCPListToolsInProgressTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferClearedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventOutputAudioBufferClearedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferClearedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventOutputAudioBufferClearedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStartedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventOutputAudioBufferStartedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStartedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventOutputAudioBufferStartedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStoppedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventOutputAudioBufferStoppedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStoppedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventOutputAudioBufferStoppedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdatedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventRateLimitsUpdatedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdatedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventRateLimitsUpdatedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdatedRateLimitName))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventRateLimitsUpdatedRateLimitNameJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdatedRateLimitName?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventRateLimitsUpdatedRateLimitNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDeltaType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseAudioDeltaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDeltaType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseAudioDeltaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDoneType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseAudioDoneTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDoneType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseAudioDoneTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDeltaType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseAudioTranscriptDeltaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDeltaType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseAudioTranscriptDeltaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDoneType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseAudioTranscriptDoneTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDoneType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseAudioTranscriptDoneTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAddedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseContentPartAddedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAddedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseContentPartAddedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAddedPartType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseContentPartAddedPartTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAddedPartType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseContentPartAddedPartTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDoneType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseContentPartDoneTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDoneType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseContentPartDoneTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDonePartType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseContentPartDonePartTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDonePartType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseContentPartDonePartTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseCreatedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseCreatedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseCreatedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseCreatedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseDoneType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseDoneTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseDoneType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseDoneTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDeltaType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseFunctionCallArgumentsDeltaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDeltaType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseFunctionCallArgumentsDeltaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDoneType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseFunctionCallArgumentsDoneTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDoneType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseFunctionCallArgumentsDoneTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDeltaType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseMCPCallArgumentsDeltaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDeltaType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseMCPCallArgumentsDeltaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDoneType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseMCPCallArgumentsDoneTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDoneType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseMCPCallArgumentsDoneTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallCompletedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseMCPCallCompletedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallCompletedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseMCPCallCompletedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallFailedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseMCPCallFailedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallFailedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseMCPCallFailedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallInProgressType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseMCPCallInProgressTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallInProgressType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseMCPCallInProgressTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAddedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseOutputItemAddedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAddedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseOutputItemAddedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemDoneType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseOutputItemDoneTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemDoneType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseOutputItemDoneTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseTextDeltaType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseTextDeltaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseTextDeltaType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseTextDeltaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseTextDoneType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseTextDoneTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseTextDoneType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseTextDoneTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventSessionCreatedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventSessionCreatedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventSessionCreatedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventSessionCreatedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventSessionUpdatedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventSessionUpdatedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeServerEventSessionUpdatedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventSessionUpdatedTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranslationServerEventDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranslationServerEventDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionClosedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranslationServerEventSessionClosedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionClosedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranslationServerEventSessionClosedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionCreatedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranslationServerEventSessionCreatedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionCreatedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranslationServerEventSessionCreatedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionInputTranscriptDeltaType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranslationServerEventSessionInputTranscriptDeltaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionInputTranscriptDeltaType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranslationServerEventSessionInputTranscriptDeltaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDeltaType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranslationServerEventSessionOutputAudioDeltaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDeltaType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranslationServerEventSessionOutputAudioDeltaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDeltaFormat))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranslationServerEventSessionOutputAudioDeltaFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDeltaFormat?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranslationServerEventSessionOutputAudioDeltaFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputTranscriptDeltaType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranslationServerEventSessionOutputTranscriptDeltaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputTranscriptDeltaType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranslationServerEventSessionOutputTranscriptDeltaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionUpdatedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranslationServerEventSessionUpdatedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionUpdatedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranslationServerEventSessionUpdatedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationSessionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranslationSessionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RealtimeTranslationSessionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RealtimeTranslationSessionTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextUsageDurationType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TranscriptTextUsageDurationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextUsageDurationType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TranscriptTextUsageDurationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextUsageTokensType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TranscriptTextUsageTokensTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextUsageTokensType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TranscriptTextUsageTokensTypeNullableJsonConverter();
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
        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
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
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LogProbProperties>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_3750EB76E7D1C7B6(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.MCPListToolsTool>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_3D1B888BE0613A48(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeFunctionTool, global::tryAGI.OpenAI.MCPTool>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_E57DBB50EBD7946A(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsModalitie>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_E3DFF6541D569E66(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsTool>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_F1BD159C703753EE(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeBetaResponseModalitie>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_4D0527D6DFC74298(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_CF8DE5043938F55F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantContentItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_3099B5F4B5DFE5AE(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemContentItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_2DBCEB5FD7BAF3AC(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_314301B232CB3E33(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeResponseCreateParamsOutputModalitie>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_59D9B890D6FD6C90(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeResponseOutputModalitie>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_E4A64D79636081AB(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdatedRateLimit>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_990024FD86667C62(options);
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
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionLanguage>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_6C42539DFDAB3193(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<long>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_FFC153334BACEC95(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_05BF36C073875770(options);
                }
                if (type == typeof(global::System.DateTimeOffset))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_DateTimeOffset(options);
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
                if (type == typeof(global::tryAGI.OpenAI.LogProbProperties))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_LogProbProperties(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MCPListToolsTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MCPListToolsTool(options);
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
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeMCPProtocolError, global::tryAGI.OpenAI.RealtimeMCPToolExecutionError, global::tryAGI.OpenAI.RealtimeMCPHTTPError>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_C2911EBCBA65F7E3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA, global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_5B3CFAE59259EB39(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGATracingEnum2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_685FE089EEEF418E(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA, global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_3AEA832E7DC05D91(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingTracingConfigurationEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingTracingConfigurationEnum2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_3E9682197C3EDA67(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_39CACFCBC1CBB46B(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.TranscriptTextUsageTokens, global::tryAGI.OpenAI.TranscriptTextUsageDuration>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_DE27E23B1BD046E0(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsMaxOutputTokens?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_C4A677053AFC0C42(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeBetaResponseMaxOutputTokens?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_651325880EC4D52B(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeResponseCreateParamsMaxOutputTokens?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_9E8DE2C9DD0FF205(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeResponseMaxOutputTokens?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_F2E1CE740C9DF9B0(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAMaxOutputTokens?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_679C8DF89AE5E67A(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAMaxOutputTokens?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_B843E66BCBB09CE6(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsConversation?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_B6D8D862B665CCDE(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.RealtimeResponseCreateParamsConversation?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_C021E20591C3BD31(options);
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
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemCreate))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaClientEventConversationItemCreate(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemCreateType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaClientEventConversationItemCreateType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaClientEventResponseCreate))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaClientEventResponseCreate(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaClientEventResponseCreateType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaClientEventResponseCreateType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaResponse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaResponse(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseCreateParams))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaResponseCreateParams(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsConversation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaResponseCreateParamsConversation2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsMaxOutputTokens))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaResponseCreateParamsMaxOutputTokens2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsModalitie))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaResponseCreateParamsModalitie2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsOutputAudioFormat))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaResponseCreateParamsOutputAudioFormat2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaResponseCreateParamsTool(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsToolType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaResponseCreateParamsToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseMaxOutputTokens))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaResponseMaxOutputTokens2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseModalitie))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaResponseModalitie2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaResponseObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseOutputAudioFormat))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaResponseOutputAudioFormat2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaResponseStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetails))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaResponseStatusDetails(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetailsError))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaResponseStatusDetailsError(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetailsReason))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaResponseStatusDetailsReason2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetailsType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaResponseStatusDetailsType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseUsage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaResponseUsage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseUsageInputTokenDetails))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaResponseUsageInputTokenDetails(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseUsageInputTokenDetailsCachedTokensDetails))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaResponseUsageInputTokenDetailsCachedTokensDetails(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseUsageOutputTokenDetails))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaResponseUsageOutputTokenDetails(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemCreated))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaServerEventConversationItemCreated(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemCreatedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaServerEventConversationItemCreatedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionCompleted))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaServerEventConversationItemInputAudioTranscriptionCompleted(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionCompletedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaServerEventConversationItemInputAudioTranscriptionCompletedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionDelta))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaServerEventConversationItemInputAudioTranscriptionDelta(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionDeltaType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaServerEventConversationItemInputAudioTranscriptionDeltaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemRetrieved))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaServerEventConversationItemRetrieved(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemRetrievedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaServerEventConversationItemRetrievedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseCreated))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaServerEventResponseCreated(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseCreatedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaServerEventResponseCreatedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseDone))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaServerEventResponseDone(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseDoneType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaServerEventResponseDoneType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseOutputItemAdded))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaServerEventResponseOutputItemAdded(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseOutputItemAddedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaServerEventResponseOutputItemAddedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseOutputItemDone))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaServerEventResponseOutputItemDone(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseOutputItemDoneType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeBetaServerEventResponseOutputItemDoneType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeClientEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeClientEvent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeClientEventConversationItemCreate))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeClientEventConversationItemCreate(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeClientEventConversationItemCreateType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeClientEventConversationItemCreateType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeClientEventConversationItemDelete))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeClientEventConversationItemDelete(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeClientEventConversationItemDeleteType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeClientEventConversationItemDeleteType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeClientEventConversationItemRetrieve))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeClientEventConversationItemRetrieve(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeClientEventConversationItemRetrieveType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeClientEventConversationItemRetrieveType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeClientEventConversationItemTruncate))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeClientEventConversationItemTruncate(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeClientEventConversationItemTruncateType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeClientEventConversationItemTruncateType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeClientEventDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeClientEventDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeClientEventDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeClientEventDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferAppend))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeClientEventInputAudioBufferAppend(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferAppendType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeClientEventInputAudioBufferAppendType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferClear))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeClientEventInputAudioBufferClear(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferClearType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeClientEventInputAudioBufferClearType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferCommit))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeClientEventInputAudioBufferCommit(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferCommitType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeClientEventInputAudioBufferCommitType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeClientEventOutputAudioBufferClear))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeClientEventOutputAudioBufferClear(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeClientEventOutputAudioBufferClearType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeClientEventOutputAudioBufferClearType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeClientEventResponseCancel))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeClientEventResponseCancel(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeClientEventResponseCancelType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeClientEventResponseCancelType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeClientEventResponseCreate))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeClientEventResponseCreate(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeClientEventResponseCreateType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeClientEventResponseCreateType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeClientEventSessionUpdate))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeClientEventSessionUpdate(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeClientEventSessionUpdateType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeClientEventSessionUpdateType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeConversationItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeConversationItemDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeConversationItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCall))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeConversationItemFunctionCall(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeConversationItemFunctionCallObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeConversationItemFunctionCallOutput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutputObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeConversationItemFunctionCallOutputObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutputStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeConversationItemFunctionCallOutputStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutputType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeConversationItemFunctionCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeConversationItemFunctionCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeConversationItemFunctionCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistant))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeConversationItemMessageAssistant(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantContentItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeConversationItemMessageAssistantContentItem(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantContentItemType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeConversationItemMessageAssistantContentItemType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeConversationItemMessageAssistantObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantRole))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeConversationItemMessageAssistantRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeConversationItemMessageAssistantStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeConversationItemMessageAssistantType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageSystem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeConversationItemMessageSystem(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemContentItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeConversationItemMessageSystemContentItem(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemContentItemType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeConversationItemMessageSystemContentItemType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeConversationItemMessageSystemObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemRole))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeConversationItemMessageSystemRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeConversationItemMessageSystemStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeConversationItemMessageSystemType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUser))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeConversationItemMessageUser(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeConversationItemMessageUserContentItem(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItemDetail))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeConversationItemMessageUserContentItemDetail2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItemType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeConversationItemMessageUserContentItemType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeConversationItemMessageUserObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserRole))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeConversationItemMessageUserRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeConversationItemMessageUserStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeConversationItemMessageUserType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeFunctionTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeFunctionTool(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeFunctionToolType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeFunctionToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeMCPApprovalRequest))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeMCPApprovalRequest(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeMCPApprovalRequestType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeMCPApprovalRequestType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeMCPApprovalResponse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeMCPApprovalResponse(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeMCPApprovalResponseType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeMCPApprovalResponseType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeMCPHTTPError))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeMCPHTTPError(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeMCPHTTPErrorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeMCPHTTPErrorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeMCPListTools))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeMCPListTools(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeMCPListToolsType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeMCPListToolsType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeMCPProtocolError))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeMCPProtocolError(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeMCPProtocolErrorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeMCPProtocolErrorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeMCPToolCall))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeMCPToolCall(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeMCPToolCallType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeMCPToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeMCPToolExecutionError))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeMCPToolExecutionError(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeMCPToolExecutionErrorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeMCPToolExecutionErrorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeReasoning))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeReasoning(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeReasoningEffort))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeReasoningEffort2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeResponse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeResponse(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeResponseAudio))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeResponseAudio(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeResponseAudioOutput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeResponseAudioOutput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeResponseCreateParams))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeResponseCreateParams(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeResponseCreateParamsAudio))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeResponseCreateParamsAudio(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeResponseCreateParamsAudioOutput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeResponseCreateParamsAudioOutput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeResponseCreateParamsConversation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeResponseCreateParamsConversation2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeResponseCreateParamsMaxOutputTokens))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeResponseCreateParamsMaxOutputTokens2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeResponseCreateParamsOutputModalitie))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeResponseCreateParamsOutputModalitie2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeResponseMaxOutputTokens))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeResponseMaxOutputTokens2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeResponseObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeResponseObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeResponseOutputModalitie))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeResponseOutputModalitie2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeResponseStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeResponseStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeResponseStatusDetails))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeResponseStatusDetails(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeResponseStatusDetailsError))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeResponseStatusDetailsError(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeResponseStatusDetailsReason))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeResponseStatusDetailsReason2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeResponseStatusDetailsType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeResponseStatusDetailsType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeResponseUsage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeResponseUsage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeResponseUsageInputTokenDetails))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeResponseUsageInputTokenDetails(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeResponseUsageInputTokenDetailsCachedTokensDetails))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeResponseUsageInputTokenDetailsCachedTokensDetails(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeResponseUsageOutputTokenDetails))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeResponseUsageOutputTokenDetails(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEvent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationCreated))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventConversationCreated(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationCreatedConversation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventConversationCreatedConversation(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationCreatedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventConversationCreatedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemAdded))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventConversationItemAdded(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemAddedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventConversationItemAddedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreated))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventConversationItemCreated(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreatedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventConversationItemCreatedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemDeleted))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventConversationItemDeleted(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemDeletedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventConversationItemDeletedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemDone))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventConversationItemDone(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemDoneType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventConversationItemDoneType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventConversationItemInputAudioTranscriptionCompleted(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionCompletedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventConversationItemInputAudioTranscriptionCompletedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionDelta))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventConversationItemInputAudioTranscriptionDelta(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionDeltaType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventConversationItemInputAudioTranscriptionDeltaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailed))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventConversationItemInputAudioTranscriptionFailed(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailedError))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventConversationItemInputAudioTranscriptionFailedError(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventConversationItemInputAudioTranscriptionFailedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegment))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventConversationItemInputAudioTranscriptionSegment(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegmentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventConversationItemInputAudioTranscriptionSegmentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemRetrieved))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventConversationItemRetrieved(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemRetrievedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventConversationItemRetrievedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemTruncated))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventConversationItemTruncated(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemTruncatedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventConversationItemTruncatedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventError))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventError(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventErrorError))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventErrorError(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventErrorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventErrorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCleared))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventInputAudioBufferCleared(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferClearedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventInputAudioBufferClearedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCommitted))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventInputAudioBufferCommitted(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCommittedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventInputAudioBufferCommittedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceived))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventInputAudioBufferDtmfEventReceived(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceivedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventInputAudioBufferDtmfEventReceivedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStarted))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventInputAudioBufferSpeechStarted(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStartedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventInputAudioBufferSpeechStartedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStopped))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventInputAudioBufferSpeechStopped(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStoppedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventInputAudioBufferSpeechStoppedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggered))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventInputAudioBufferTimeoutTriggered(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggeredType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventInputAudioBufferTimeoutTriggeredType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsCompleted))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventMCPListToolsCompleted(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsCompletedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventMCPListToolsCompletedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsFailed))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventMCPListToolsFailed(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsFailedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventMCPListToolsFailedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgress))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventMCPListToolsInProgress(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgressType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventMCPListToolsInProgressType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferCleared))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventOutputAudioBufferCleared(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferClearedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventOutputAudioBufferClearedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStarted))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventOutputAudioBufferStarted(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStartedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventOutputAudioBufferStartedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStopped))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventOutputAudioBufferStopped(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStoppedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventOutputAudioBufferStoppedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdated))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventRateLimitsUpdated(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdatedRateLimit))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventRateLimitsUpdatedRateLimit(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdatedRateLimitName))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventRateLimitsUpdatedRateLimitName2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdatedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventRateLimitsUpdatedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDelta))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventResponseAudioDelta(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDeltaType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventResponseAudioDeltaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDone))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventResponseAudioDone(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDoneType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventResponseAudioDoneType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDelta))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventResponseAudioTranscriptDelta(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDeltaType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventResponseAudioTranscriptDeltaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDone))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventResponseAudioTranscriptDone(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDoneType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventResponseAudioTranscriptDoneType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAdded))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventResponseContentPartAdded(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAddedPart))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventResponseContentPartAddedPart(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAddedPartType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventResponseContentPartAddedPartType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAddedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventResponseContentPartAddedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDone))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventResponseContentPartDone(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDonePart))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventResponseContentPartDonePart(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDonePartType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventResponseContentPartDonePartType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDoneType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventResponseContentPartDoneType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseCreated))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventResponseCreated(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseCreatedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventResponseCreatedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseDone))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventResponseDone(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseDoneType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventResponseDoneType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDelta))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventResponseFunctionCallArgumentsDelta(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDeltaType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventResponseFunctionCallArgumentsDeltaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDone))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventResponseFunctionCallArgumentsDone(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDoneType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventResponseFunctionCallArgumentsDoneType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDelta))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventResponseMCPCallArgumentsDelta(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDeltaType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventResponseMCPCallArgumentsDeltaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDone))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventResponseMCPCallArgumentsDone(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDoneType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventResponseMCPCallArgumentsDoneType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallCompleted))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventResponseMCPCallCompleted(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallCompletedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventResponseMCPCallCompletedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallFailed))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventResponseMCPCallFailed(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallFailedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventResponseMCPCallFailedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallInProgress))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventResponseMCPCallInProgress(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallInProgressType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventResponseMCPCallInProgressType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAdded))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventResponseOutputItemAdded(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAddedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventResponseOutputItemAddedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemDone))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventResponseOutputItemDone(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemDoneType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventResponseOutputItemDoneType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseTextDelta))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventResponseTextDelta(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseTextDeltaType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventResponseTextDeltaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseTextDone))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventResponseTextDone(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseTextDoneType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventResponseTextDoneType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventSessionCreated))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventSessionCreated(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventSessionCreatedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventSessionCreatedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventSessionUpdated))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventSessionUpdated(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventSessionUpdatedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RealtimeServerEventSessionUpdatedType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTranslationServerEvent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTranslationServerEventDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTranslationServerEventDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionClosed))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTranslationServerEventSessionClosed(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionClosedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTranslationServerEventSessionClosedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionCreated))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTranslationServerEventSessionCreated(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionCreatedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTranslationServerEventSessionCreatedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionInputTranscriptDelta))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTranslationServerEventSessionInputTranscriptDelta(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionInputTranscriptDeltaType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTranslationServerEventSessionInputTranscriptDeltaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDelta))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTranslationServerEventSessionOutputAudioDelta(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDeltaFormat))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTranslationServerEventSessionOutputAudioDeltaFormat2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDeltaType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTranslationServerEventSessionOutputAudioDeltaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputTranscriptDelta))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTranslationServerEventSessionOutputTranscriptDelta(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputTranscriptDeltaType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTranslationServerEventSessionOutputTranscriptDeltaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionUpdated))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTranslationServerEventSessionUpdated(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionUpdatedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTranslationServerEventSessionUpdatedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranslationSession))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTranslationSession(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranslationSessionAudio))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTranslationSessionAudio(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranslationSessionAudioInput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTranslationSessionAudioInput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranslationSessionAudioInputNoiseReduction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTranslationSessionAudioInputNoiseReduction(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranslationSessionAudioInputTranscription))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTranslationSessionAudioInputTranscription(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranslationSessionAudioOutput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTranslationSessionAudioOutput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranslationSessionType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RealtimeTranslationSessionType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.TranscriptTextUsageDuration))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_TranscriptTextUsageDuration(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TranscriptTextUsageDurationType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_TranscriptTextUsageDurationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TranscriptTextUsageTokens))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_TranscriptTextUsageTokens(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TranscriptTextUsageTokensInputTokenDetails))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_TranscriptTextUsageTokensInputTokenDetails(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TranscriptTextUsageTokensType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_TranscriptTextUsageTokensType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TranscriptionLanguage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_TranscriptionLanguage(options);
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
                if (type == typeof(bool?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableBoolean(options);
                }
                if (type == typeof(double?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableDouble(options);
                }
                if (type == typeof(global::System.DateTimeOffset?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableDateTimeOffset(options);
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
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA, global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_DBC05B50B78DEDED(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_C8889130C8D4F808(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.TranscriptTextUsageTokens, global::tryAGI.OpenAI.TranscriptTextUsageDuration>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_D0ABE68F8D52139B(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsMaxOutputTokens?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_C432FE7C49DFC44D(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeBetaResponseMaxOutputTokens?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_EEA90182A05A4A41(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeResponseCreateParamsMaxOutputTokens?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_FCDB7B2AD5B2A54E(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeResponseMaxOutputTokens?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_C70E40EE9DED179F(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAMaxOutputTokens?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_A70AD6BCB38B3067(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAMaxOutputTokens?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_12D81038389C0A49(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsConversation?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_D9544A59264ADC3D(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.RealtimeResponseCreateParamsConversation?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_8E6C15AA6BFBEF52(options);
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
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaClientEventConversationItemCreateType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeBetaClientEventConversationItemCreateType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaClientEventResponseCreateType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeBetaClientEventResponseCreateType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsConversation?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeBetaResponseCreateParamsConversation2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsMaxOutputTokens?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeBetaResponseCreateParamsMaxOutputTokens2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsModalitie?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeBetaResponseCreateParamsModalitie2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsOutputAudioFormat?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeBetaResponseCreateParamsOutputAudioFormat2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsToolType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeBetaResponseCreateParamsToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseMaxOutputTokens?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeBetaResponseMaxOutputTokens2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseModalitie?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeBetaResponseModalitie2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeBetaResponseObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseOutputAudioFormat?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeBetaResponseOutputAudioFormat2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeBetaResponseStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetailsReason?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeBetaResponseStatusDetailsReason2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaResponseStatusDetailsType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeBetaResponseStatusDetailsType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemCreatedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeBetaServerEventConversationItemCreatedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionCompletedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeBetaServerEventConversationItemInputAudioTranscriptionCompletedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemInputAudioTranscriptionDeltaType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeBetaServerEventConversationItemInputAudioTranscriptionDeltaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventConversationItemRetrievedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeBetaServerEventConversationItemRetrievedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseCreatedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeBetaServerEventResponseCreatedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseDoneType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeBetaServerEventResponseDoneType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseOutputItemAddedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeBetaServerEventResponseOutputItemAddedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaServerEventResponseOutputItemDoneType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeBetaServerEventResponseOutputItemDoneType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeClientEvent?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeClientEvent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeClientEventConversationItemCreateType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeClientEventConversationItemCreateType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeClientEventConversationItemDeleteType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeClientEventConversationItemDeleteType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeClientEventConversationItemRetrieveType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeClientEventConversationItemRetrieveType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeClientEventConversationItemTruncateType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeClientEventConversationItemTruncateType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeClientEventDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeClientEventDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferAppendType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeClientEventInputAudioBufferAppendType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferClearType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeClientEventInputAudioBufferClearType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferCommitType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeClientEventInputAudioBufferCommitType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeClientEventOutputAudioBufferClearType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeClientEventOutputAudioBufferClearType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeClientEventResponseCancelType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeClientEventResponseCancelType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeClientEventResponseCreateType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeClientEventResponseCreateType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeClientEventSessionUpdateType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeClientEventSessionUpdateType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeConversationItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeConversationItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeConversationItemFunctionCallObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutputObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeConversationItemFunctionCallOutputObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutputStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeConversationItemFunctionCallOutputStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutputType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeConversationItemFunctionCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeConversationItemFunctionCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeConversationItemFunctionCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantContentItemType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeConversationItemMessageAssistantContentItemType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeConversationItemMessageAssistantObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantRole?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeConversationItemMessageAssistantRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeConversationItemMessageAssistantStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeConversationItemMessageAssistantType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemContentItemType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeConversationItemMessageSystemContentItemType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeConversationItemMessageSystemObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemRole?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeConversationItemMessageSystemRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeConversationItemMessageSystemStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeConversationItemMessageSystemType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItemDetail?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeConversationItemMessageUserContentItemDetail2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItemType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeConversationItemMessageUserContentItemType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeConversationItemMessageUserObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserRole?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeConversationItemMessageUserRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeConversationItemMessageUserStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUserType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeConversationItemMessageUserType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeFunctionToolType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeFunctionToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeMCPApprovalRequestType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeMCPApprovalRequestType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeMCPApprovalResponseType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeMCPApprovalResponseType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeMCPHTTPErrorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeMCPHTTPErrorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeMCPListToolsType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeMCPListToolsType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeMCPProtocolErrorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeMCPProtocolErrorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeMCPToolCallType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeMCPToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeMCPToolExecutionErrorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeMCPToolExecutionErrorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeReasoningEffort?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeReasoningEffort2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeResponseCreateParamsConversation?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeResponseCreateParamsConversation2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeResponseCreateParamsMaxOutputTokens?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeResponseCreateParamsMaxOutputTokens2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeResponseCreateParamsOutputModalitie?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeResponseCreateParamsOutputModalitie2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeResponseMaxOutputTokens?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeResponseMaxOutputTokens2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeResponseObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeResponseObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeResponseOutputModalitie?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeResponseOutputModalitie2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeResponseStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeResponseStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeResponseStatusDetailsReason?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeResponseStatusDetailsReason2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeResponseStatusDetailsType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeResponseStatusDetailsType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEvent?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEvent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationCreatedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventConversationCreatedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemAddedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventConversationItemAddedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreatedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventConversationItemCreatedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemDeletedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventConversationItemDeletedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemDoneType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventConversationItemDoneType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionCompletedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventConversationItemInputAudioTranscriptionCompletedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionDeltaType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventConversationItemInputAudioTranscriptionDeltaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventConversationItemInputAudioTranscriptionFailedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegmentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventConversationItemInputAudioTranscriptionSegmentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemRetrievedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventConversationItemRetrievedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemTruncatedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventConversationItemTruncatedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventErrorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventErrorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferClearedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventInputAudioBufferClearedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCommittedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventInputAudioBufferCommittedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceivedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventInputAudioBufferDtmfEventReceivedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStartedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventInputAudioBufferSpeechStartedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStoppedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventInputAudioBufferSpeechStoppedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggeredType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventInputAudioBufferTimeoutTriggeredType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsCompletedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventMCPListToolsCompletedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsFailedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventMCPListToolsFailedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgressType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventMCPListToolsInProgressType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferClearedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventOutputAudioBufferClearedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStartedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventOutputAudioBufferStartedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStoppedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventOutputAudioBufferStoppedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdatedRateLimitName?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventRateLimitsUpdatedRateLimitName2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdatedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventRateLimitsUpdatedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDeltaType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventResponseAudioDeltaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDoneType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventResponseAudioDoneType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDeltaType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventResponseAudioTranscriptDeltaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDoneType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventResponseAudioTranscriptDoneType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAddedPartType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventResponseContentPartAddedPartType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAddedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventResponseContentPartAddedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDonePartType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventResponseContentPartDonePartType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDoneType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventResponseContentPartDoneType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseCreatedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventResponseCreatedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseDoneType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventResponseDoneType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDeltaType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventResponseFunctionCallArgumentsDeltaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDoneType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventResponseFunctionCallArgumentsDoneType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDeltaType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventResponseMCPCallArgumentsDeltaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDoneType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventResponseMCPCallArgumentsDoneType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallCompletedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventResponseMCPCallCompletedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallFailedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventResponseMCPCallFailedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallInProgressType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventResponseMCPCallInProgressType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAddedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventResponseOutputItemAddedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemDoneType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventResponseOutputItemDoneType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseTextDeltaType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventResponseTextDeltaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseTextDoneType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventResponseTextDoneType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventSessionCreatedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventSessionCreatedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeServerEventSessionUpdatedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeServerEventSessionUpdatedType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEvent?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeTranslationServerEvent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeTranslationServerEventDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionClosedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeTranslationServerEventSessionClosedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionCreatedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeTranslationServerEventSessionCreatedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionInputTranscriptDeltaType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeTranslationServerEventSessionInputTranscriptDeltaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDeltaFormat?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeTranslationServerEventSessionOutputAudioDeltaFormat2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDeltaType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeTranslationServerEventSessionOutputAudioDeltaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputTranscriptDeltaType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeTranslationServerEventSessionOutputTranscriptDeltaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionUpdatedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeTranslationServerEventSessionUpdatedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranslationSessionType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRealtimeTranslationSessionType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.TranscriptTextUsageDurationType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableTranscriptTextUsageDurationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TranscriptTextUsageTokensType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableTranscriptTextUsageTokensType2(options);
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
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CallableToolAllowedCaller>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_A0102E6B0439FF50(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.LogProbProperties>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_83B8D4C49AD71453(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.MCPListToolsTool>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_213D8E9FE90E98D9(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeFunctionTool, global::tryAGI.OpenAI.MCPTool>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_C74C5F6F3081F1DC(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsModalitie>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_1344152FD97ADBA5(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsTool>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_110F6010BF4B92E3(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeBetaResponseModalitie>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_1940CD1926235542(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeConversationItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_109D5712E99AA5DD(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistantContentItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_CEBA939888C338A5(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeConversationItemMessageSystemContentItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_3E645FF0E72F74BC(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeConversationItemMessageUserContentItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_0FBD50970D63F513(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeResponseCreateParamsOutputModalitie>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_A223B423A9B65A0A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeResponseOutputModalitie>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_577C0314CBCFB38C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdatedRateLimit>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_E90E8E01B12455F8(options);
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
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.TranscriptionLanguage>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_2B6860664FDA6466(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<long>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_2BCC53E1C7DA84DD(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_3F34DBFD50DE05D2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.List<string>, global::tryAGI.OpenAI.MCPToolFilter>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_209335A1CF98F53C(options);
                }
                global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? additional = null;
                ResolveAdditionalTypeInfo(type, options, ref additional);
                return additional;
            }

            static partial void ResolveAdditionalTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options,
                ref global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? result);
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