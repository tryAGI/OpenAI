
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextOrphans_3B40ADE221074F9B : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextOrphans_3B40ADE221074F9B Default { get; } = new(DefaultOptions);

        private SourceGenerationContextOrphans_3B40ADE221074F9B(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaConversationParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaReasoningModeEnumJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaTextResponseFormatConfigurationJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaToolJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ToolsItem18JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.Format3JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.EnvironmentVariant15JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.NetworkPolicy4JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.SkillsItem3JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.NetworkPolicy5JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaFiltersJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.FiltersItem2JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaInputItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaToolCallCallerJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaFunctionAndCustomToolCallOutputJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaToolCallCallerParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaMCPToolCallErrorJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchOperationParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallOutputOutcomeParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.EnvironmentVariant16JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OutputsVariant1Item2JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaToolSearchOutputToolJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ToolsItem19JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnnotationsItem4JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ContentItem6JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OutputVariant2Item2JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchToolCallActionJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaComputerActionJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaOutputMessageContentJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaAnnotationJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaInputContentJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaModelIdsResponsesJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaModelIdsSharedJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaMisalignmentErrorTypeJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaCustomToolCallOutputResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.Operation2JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.Outcome2JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.EnvironmentVariant17JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ContentItem7JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaFunctionToolCallOutputResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaComputerToolCallOutputResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaResponseJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.Input5JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.Output9JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheDiagnosticsJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaOutputItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaOutputContentJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerErrorCodeJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerInputJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerInputItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ContentVariant1Item2JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerRequiredInputJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerPendingReasonJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaInputParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaResponsesServerEventJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaResponsesClientEventJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaResponsesClientEventResponseCreateJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaCreateResponseJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaCreateModelResponsePropertiesJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputItem>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.BetaImageGenToolModel?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.BetaImageGenToolSize?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParam>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, global::tryAGI.OpenAI.BetaMCPToolFilter>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum, global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum2?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutput>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.BetaImageGenToolCallSizeVariant1?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item2>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputContent>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputItem>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutput>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputItem>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant1Item2>, string>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDelta2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseAudioDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDone2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDelta2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDone2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDelta2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDone2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsCompleted2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallInWsProgress2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsInterpreting2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCompactionWsCompacting2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCompleted2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsAdded2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsDone2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseCreatedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCreated2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsCompleted2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallInWsProgress2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsSearching2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDelta2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsAdded2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDelta2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDone2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDelta2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDone2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseInWsProgress2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsFailed2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseIncompleteEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsIncomplete2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsAdded2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsDone2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsAdded2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsDone2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDelta2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDone2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDelta2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDone2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDelta2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDone2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDelta2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDone2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsCompleted2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallInWsProgress2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsSearching2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsCompleted2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsGenerating2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallInWsProgress2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallPartialWsImage2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDelta2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDone2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsCompleted2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsFailed2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallInWsProgress2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsCompleted2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsFailed2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsInWsProgress2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputTextAnnotationWsAdded2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseQueuedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsQueued2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDelta2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDone2>());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.BetaSpecificFunctionShellParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaSpecificFunctionShellParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaSpecificApplyPatchParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaSpecificApplyPatchParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceCustomType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceCustomType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceMCPType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceMCPType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceFunctionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceFunctionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceTypesType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceTypesType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceAllowedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceAllowedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceAllowedMode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceAllowedMode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceOptions)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceOptions?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningSummary)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningSummary?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningContext)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningContext?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningGenerateSummary)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningGenerateSummary?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningEffortEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningEffortEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningModeEnumEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningModeEnumEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaVerbosityEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaVerbosityEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFormatJsonObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFormatJsonObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchemaType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchemaType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFormatTextType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFormatTextType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCallableToolAllowedCaller)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCallableToolAllowedCaller?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchPreviewToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchPreviewToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaSearchContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaSearchContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaSearchContextSize)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaSearchContextSize?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApproximateLocationType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApproximateLocationType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchExecutionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchExecutionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaNamespaceToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaNamespaceToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaNamespaceToolParamToolDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaNamespaceToolParamToolDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomToolParamFormatDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomToolParamFormatDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomGrammarFormatParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomGrammarFormatParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaGrammarSyntax1)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaGrammarSyntax1?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomTextFormatParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomTextFormatParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerReferenceParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerReferenceParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalEnvironmentParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalEnvironmentParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamNetworkPolicyDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamNetworkPolicyDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamSkillDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamSkillDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInlineSkillParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInlineSkillParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInlineSkillSourceParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInlineSkillSourceParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInlineSkillSourceParamMediaType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInlineSkillSourceParamMediaType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaSkillReferenceParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaSkillReferenceParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerMemoryLimit)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerMemoryLimit?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolModel)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolModel?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolQuality)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolQuality?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolSize)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolSize?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolOutputFormat)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolOutputFormat?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolModeration)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolModeration?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolBackground)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolBackground?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenActionEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenActionEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputFidelity)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputFidelity?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgrammaticToolCallingParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgrammaticToolCallingParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolConnectorId)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolConnectorId?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum2)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum2?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchToolSearchContextSize)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchToolSearchContextSize?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchApproximateLocationWebSearchApproximateLocationType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchApproximateLocationWebSearchApproximateLocationType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerUsePreviewToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerUsePreviewToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerEnvironment)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerEnvironment?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileSearchToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileSearchToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompoundFilterType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompoundFilterType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComparisonFilterType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComparisonFilterType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaRankerVersionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaRankerVersionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputItemDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputItemDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramOutputItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramOutputItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramOutputItemStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramOutputItemStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaItemReferenceParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaItemReferenceParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompactionTriggerItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompactionTriggerItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaItemDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaItemDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolCallCallerDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolCallCallerDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramToolCallCallerType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramToolCallCallerType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaDirectToolCallCallerType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaDirectToolCallCallerType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomToolCallOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomToolCallOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutputDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutputDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputFileContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputFileContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileInputDetail)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileInputDetail?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheBreakpointConfigMode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheBreakpointConfigMode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputImageContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputImageContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageDetail)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageDetail?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputTextContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputTextContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolCallCallerParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolCallCallerParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramToolCallCallerParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramToolCallCallerParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaDirectToolCallCallerParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaDirectToolCallCallerParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolCallErrorDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolCallErrorDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaHTTPErrorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaHTTPErrorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolExecutionErrorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolExecutionErrorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPProtocolErrorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPProtocolErrorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPApprovalResponseType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPApprovalResponseType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPApprovalRequestType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPApprovalRequestType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPListToolsType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPListToolsType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCallOutputStatusParam)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCallOutputStatusParam?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchOperationParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchOperationParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCallStatusParam)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCallStatusParam?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallItemStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallItemStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputOutcomeParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputOutcomeParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallItemParamEnvironmentVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallItemParamEnvironmentVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallOutputStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallOutputStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellExecActionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellExecActionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterOutputImageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterOutputImageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogsType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogsType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallSizeVariant1)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallSizeVariant1?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallQuality)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallQuality?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageOutputFormat)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageOutputFormat?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageBackground)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageBackground?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallModerationDetailsModerationStage)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallModerationDetailsModerationStage?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompactionSummaryItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompactionSummaryItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningItemType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningItemType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningItemStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningItemStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningTextContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningTextContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaSummaryTextContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaSummaryTextContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAdditionalToolsItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAdditionalToolsItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAdditionalToolsItemParamRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAdditionalToolsItemParamRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionCallItemStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionCallItemStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputToolDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputToolDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputNamespaceToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputNamespaceToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputNamespaceToolParamToolDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputNamespaceToolParamToolDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputFunctionToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputFunctionToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchCallItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchCallItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputTextContentParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputTextContentParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputTextContentParamAnnotationDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputTextContentParamAnnotationDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerFileCitationParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerFileCitationParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaUrlCitationParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaUrlCitationParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileCitationParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileCitationParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentAction1)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentAction1?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAgentMessageItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAgentMessageItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAgentMessageItemParamContentItemDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAgentMessageItemParamContentItemDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaEncryptedContentParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaEncryptedContentParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputImageContentParamAutoParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputImageContentParamAutoParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheBreakpointParamMode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheBreakpointParamMode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaDetailEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaDetailEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputTextContentParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputTextContentParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputFileContentParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputFileContentParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileDetailEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileDetailEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchToolCallActionDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchToolCallActionDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchActionFindType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchActionFindType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchActionOpenPageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchActionOpenPageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchActionSearchType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchActionSearchType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchActionSearchSourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchActionSearchSourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerCallOutputItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerCallOutputItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerScreenshotImageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerScreenshotImageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerActionDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerActionDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWaitParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWaitParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaTypeParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaTypeParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaScrollParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaScrollParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaScreenshotParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaScreenshotParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMoveParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMoveParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaKeyPressActionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaKeyPressActionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaDragParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaDragParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaDoubleClickActionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaDoubleClickActionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaClickParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaClickParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaClickButtonType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaClickButtonType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileSearchToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileSearchToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileSearchToolCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileSearchToolCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputMessageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputMessageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputMessageRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputMessageRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputMessageStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputMessageStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMessagePhase)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMessagePhase?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputMessageContentDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputMessageContentDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaRefusalContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaRefusalContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputTextContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputTextContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAnnotationDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAnnotationDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFilePathType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFilePathType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerFileCitationBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerFileCitationBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaUrlCitationBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaUrlCitationBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileCitationBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileCitationBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputMessageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputMessageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputMessageRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputMessageRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputMessageStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputMessageStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputContentDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputContentDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaEasyInputMessageRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaEasyInputMessageRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaEasyInputMessageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaEasyInputMessageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheModeEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheModeEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheTTLEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheTTLEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaModelIdsResponsesEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaModelIdsResponsesEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaModelIdsSharedEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaModelIdsSharedEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMisalignmentErrorTypeEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMisalignmentErrorTypeEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionCallOutputStatusEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionCallOutputStatusEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPApprovalResponseResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPApprovalResponseResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCallOutputStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCallOutputStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOperationDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOperationDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentOutcomeDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentOutcomeDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputStatusEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputStatusEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallEnvironmentVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallEnvironmentVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerReferenceResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerReferenceResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalEnvironmentResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalEnvironmentResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompactionBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompactionBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramOutputStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramOutputStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAdditionalToolsType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAdditionalToolsType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMessageRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMessageRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentAction)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentAction?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAgentMessageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAgentMessageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAgentMessageContentItemDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAgentMessageContentItemDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaEncryptedContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaEncryptedContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerScreenshotContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerScreenshotContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaTextContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaTextContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallOutputStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallOutputStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerCallOutputStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerCallOutputStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolCallOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolCallOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolCallOutputStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolCallOutputStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseQueuedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseQueuedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseVariant3Truncation)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseVariant3Truncation?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseVariant3Object)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseVariant3Object?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseVariant3Status)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseVariant3Status?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseVariant3IncompleteDetailsReason)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseVariant3IncompleteDetailsReason?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationInputDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationInputDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationOutputDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationOutputDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationErrorBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationErrorBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationResultBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationResultBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationInputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationInputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheDiagnosticsDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheDiagnosticsDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCacheMissReasonTypeEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCacheMissReasonTypeEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputItemDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputItemDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseErrorCode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseErrorCode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCyberAccessProgramEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCyberAccessProgramEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaServiceTierResponsesEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaServiceTierResponsesEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaModelResponsePropertiesPromptCacheRetention)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaModelResponsePropertiesPromptCacheRetention?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallFailedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallFailedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventPartType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventPartType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEventPartType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEventPartType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseTextDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseTextDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseTextDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseTextDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseRefusalDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseRefusalDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseRefusalDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseRefusalDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseOutputItemDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseOutputItemDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseOutputItemAddedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseOutputItemAddedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseInProgressEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseInProgressEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCreatedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCreatedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseContentPartDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseContentPartDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputContentDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputContentDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseContentPartAddedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseContentPartAddedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCompletedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCompletedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseAudioDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseAudioDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseAudioDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseAudioDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseIncompleteEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseIncompleteEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFailedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFailedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerFailedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerFailedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerFailedEventErrorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerFailedEventErrorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerErrorCodeEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerErrorCodeEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerInputItemDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerInputItemDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaUserMessageItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaUserMessageItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaUserMessageItemParamRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaUserMessageItemParamRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaUserMessageItemParamContentVariant1ItemDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaUserMessageItemParamContentVariant1ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerPendingEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerPendingEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredFunctionToolCallOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredFunctionToolCallOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredCustomToolCallOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredCustomToolCallOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredComputerToolCallOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredComputerToolCallOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredShellToolCallOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredShellToolCallOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutputExecution)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutputExecution?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredMcpApprovalResponseType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredMcpApprovalResponseType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerPendingReasonEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerPendingReasonEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerAcceptedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerAcceptedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaIncludeEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaIncludeEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseInjectFailedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseInjectFailedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseInjectFailedEventErrorCode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseInjectFailedEventErrorCode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseInjectCreatedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseInjectCreatedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseWsErrorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseWsErrorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponsesClientEventDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponsesClientEventDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseInjectEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseInjectEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreateVariant1Type)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreateVariant1Type?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCreateResponseVariant3Truncation)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCreateResponseVariant3Truncation?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationMode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationMode?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaSpecificFunctionShellParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaSpecificFunctionShellParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaSpecificFunctionShellParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaSpecificFunctionShellParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaSpecificApplyPatchParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaSpecificApplyPatchParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaSpecificApplyPatchParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaSpecificApplyPatchParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaSpecificProgrammaticToolCallingParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaSpecificProgrammaticToolCallingParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceCustomType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceCustomTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceCustomType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceCustomTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceMCPType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceMCPTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceMCPType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceMCPTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceFunctionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceFunctionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceFunctionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceFunctionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceTypesType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceTypesTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceTypesType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceTypesTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceAllowedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceAllowedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceAllowedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceAllowedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceAllowedMode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceAllowedModeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceAllowedMode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceAllowedModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceOptions))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceOptionsJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceOptions?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceOptionsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningSummary))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningSummaryJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningSummary?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningSummaryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningContext))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningContextJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningContext?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningContextNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningGenerateSummary))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningGenerateSummaryJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningGenerateSummary?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningGenerateSummaryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningEffortEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningEffortEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningEffortEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningEffortEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningModeEnumEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningModeEnumEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningModeEnumEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningModeEnumEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaVerbosityEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaVerbosityEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaVerbosityEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaVerbosityEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFormatJsonObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseFormatJsonObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFormatJsonObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseFormatJsonObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchemaType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaTextResponseFormatJsonSchemaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchemaType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaTextResponseFormatJsonSchemaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFormatTextType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseFormatTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFormatTextType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseFormatTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCallableToolAllowedCaller))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCallableToolAllowedCallerJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCallableToolAllowedCaller?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCallableToolAllowedCallerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchPreviewToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchPreviewToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchPreviewToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchPreviewToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaSearchContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaSearchContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaSearchContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaSearchContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaSearchContextSize))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaSearchContextSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaSearchContextSize?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaSearchContextSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApproximateLocationType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApproximateLocationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApproximateLocationType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApproximateLocationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolSearchToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolSearchToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchExecutionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolSearchExecutionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchExecutionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolSearchExecutionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaNamespaceToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaNamespaceToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaNamespaceToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaNamespaceToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaNamespaceToolParamToolDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaNamespaceToolParamToolDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaNamespaceToolParamToolDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaNamespaceToolParamToolDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCustomToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCustomToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomToolParamFormatDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCustomToolParamFormatDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomToolParamFormatDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCustomToolParamFormatDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomGrammarFormatParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCustomGrammarFormatParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomGrammarFormatParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCustomGrammarFormatParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaGrammarSyntax1))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaGrammarSyntax1JsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaGrammarSyntax1?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaGrammarSyntax1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomTextFormatParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCustomTextFormatParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomTextFormatParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCustomTextFormatParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerReferenceParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerReferenceParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerReferenceParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerReferenceParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalEnvironmentParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaLocalEnvironmentParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalEnvironmentParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaLocalEnvironmentParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerAutoParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerAutoParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamNetworkPolicyDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerAutoParamNetworkPolicyDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamNetworkPolicyDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerAutoParamNetworkPolicyDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamSkillDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerAutoParamSkillDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamSkillDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerAutoParamSkillDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInlineSkillParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInlineSkillParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInlineSkillParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInlineSkillParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInlineSkillSourceParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInlineSkillSourceParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInlineSkillSourceParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInlineSkillSourceParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInlineSkillSourceParamMediaType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInlineSkillSourceParamMediaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInlineSkillSourceParamMediaType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInlineSkillSourceParamMediaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaSkillReferenceParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaSkillReferenceParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaSkillReferenceParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaSkillReferenceParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerNetworkPolicyAllowlistParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerNetworkPolicyAllowlistParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerNetworkPolicyDisabledParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerNetworkPolicyDisabledParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerMemoryLimit))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerMemoryLimitJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerMemoryLimit?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerMemoryLimitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaLocalShellToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaLocalShellToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolModel))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolModelJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolModel?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolQuality))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolQuality?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolSize))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolSize?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolOutputFormat))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolOutputFormat?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolModeration))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolModerationJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolModeration?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolModerationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolBackground))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolBackgroundJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolBackground?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolBackgroundNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenActionEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenActionEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenActionEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenActionEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputFidelity))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputFidelityJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputFidelity?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputFidelityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgrammaticToolCallingParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaProgrammaticToolCallingParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgrammaticToolCallingParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaProgrammaticToolCallingParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCodeInterpreterToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCodeInterpreterToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAutoCodeInterpreterToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAutoCodeInterpreterToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolConnectorId))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPToolConnectorIdJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolConnectorId?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPToolConnectorIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum2))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPToolRequireApprovalVariant1Enum2JsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum2?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPToolRequireApprovalVariant1Enum2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchToolSearchContextSize))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchToolSearchContextSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchToolSearchContextSize?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchToolSearchContextSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchApproximateLocationWebSearchApproximateLocationType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchApproximateLocationWebSearchApproximateLocationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchApproximateLocationWebSearchApproximateLocationType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchApproximateLocationWebSearchApproximateLocationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerUsePreviewToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerUsePreviewToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerUsePreviewToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerUsePreviewToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerEnvironment))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerEnvironmentJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerEnvironment?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerEnvironmentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileSearchToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFileSearchToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileSearchToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFileSearchToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompoundFilterType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCompoundFilterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompoundFilterType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCompoundFilterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComparisonFilterType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComparisonFilterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComparisonFilterType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComparisonFilterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaRankerVersionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaRankerVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaRankerVersionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaRankerVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputItemDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputItemDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramOutputItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaProgramOutputItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramOutputItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaProgramOutputItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramOutputItemStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaProgramOutputItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramOutputItemStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaProgramOutputItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaProgramItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaProgramItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaItemReferenceParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaItemReferenceParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaItemReferenceParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaItemReferenceParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompactionTriggerItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCompactionTriggerItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompactionTriggerItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCompactionTriggerItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaItemDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaItemDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCustomToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCustomToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolCallCallerDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolCallCallerDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolCallCallerDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolCallCallerDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramToolCallCallerType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaProgramToolCallCallerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramToolCallCallerType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaProgramToolCallCallerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaDirectToolCallCallerType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaDirectToolCallCallerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaDirectToolCallCallerType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaDirectToolCallCallerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomToolCallOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCustomToolCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomToolCallOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCustomToolCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutputDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionAndCustomToolCallOutputDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutputDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionAndCustomToolCallOutputDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputFileContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputFileContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputFileContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputFileContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileInputDetail))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFileInputDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileInputDetail?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFileInputDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheBreakpointConfigMode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheBreakpointConfigModeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheBreakpointConfigMode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheBreakpointConfigModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputImageContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputImageContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputImageContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputImageContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageDetail))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageDetail?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputTextContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputTextContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputTextContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputTextContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolCallCallerParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolCallCallerParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolCallCallerParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolCallCallerParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramToolCallCallerParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaProgramToolCallCallerParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramToolCallCallerParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaProgramToolCallCallerParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaDirectToolCallCallerParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaDirectToolCallCallerParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaDirectToolCallCallerParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaDirectToolCallCallerParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPToolCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPToolCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolCallErrorDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPToolCallErrorDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolCallErrorDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPToolCallErrorDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaHTTPErrorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaHTTPErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaHTTPErrorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaHTTPErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolExecutionErrorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPToolExecutionErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolExecutionErrorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPToolExecutionErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPProtocolErrorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPProtocolErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPProtocolErrorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPProtocolErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPApprovalResponseType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPApprovalResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPApprovalResponseType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPApprovalResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPApprovalRequestType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPApprovalRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPApprovalRequestType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPApprovalRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPListToolsType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPListToolsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPListToolsType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPListToolsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchToolCallOutputItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchToolCallOutputItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCallOutputStatusParam))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchCallOutputStatusParamJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCallOutputStatusParam?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchCallOutputStatusParamNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchToolCallItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchToolCallItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchOperationParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchOperationParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchOperationParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchOperationParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchUpdateFileOperationParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchUpdateFileOperationParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchDeleteFileOperationParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchDeleteFileOperationParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchCreateFileOperationParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchCreateFileOperationParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCallStatusParam))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchCallStatusParamJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCallStatusParam?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchCallStatusParamNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallOutputItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallOutputItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallItemStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallItemStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputOutcomeParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallOutputOutcomeParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputOutcomeParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallOutputOutcomeParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallOutputExitOutcomeParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallOutputExitOutcomeParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallOutputTimeoutOutcomeParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallOutputTimeoutOutcomeParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallItemParamEnvironmentVariant1DiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallItemParamEnvironmentVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallItemParamEnvironmentVariant1DiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallItemParamEnvironmentVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaLocalShellToolCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaLocalShellToolCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallOutputStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaLocalShellToolCallOutputStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallOutputStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaLocalShellToolCallOutputStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaLocalShellToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaLocalShellToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaLocalShellToolCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaLocalShellToolCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellExecActionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaLocalShellExecActionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellExecActionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaLocalShellExecActionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCodeInterpreterToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCodeInterpreterToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCodeInterpreterToolCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCodeInterpreterToolCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterOutputImageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCodeInterpreterOutputImageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterOutputImageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCodeInterpreterOutputImageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogsType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCodeInterpreterOutputLogsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogsType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCodeInterpreterOutputLogsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallSizeVariant1))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolCallSizeVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallSizeVariant1?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolCallSizeVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallQuality))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolCallQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallQuality?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolCallQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageOutputFormat))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageOutputFormat?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageBackground))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageBackgroundJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageBackground?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageBackgroundNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallModerationDetailsModerationStage))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolCallModerationDetailsModerationStageJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallModerationDetailsModerationStage?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolCallModerationDetailsModerationStageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompactionSummaryItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCompactionSummaryItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompactionSummaryItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCompactionSummaryItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningItemType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningItemType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningItemStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningItemStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningTextContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningTextContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningTextContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningTextContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaSummaryTextContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaSummaryTextContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaSummaryTextContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaSummaryTextContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseConfigurationUpdateItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseConfigurationUpdateItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAdditionalToolsItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAdditionalToolsItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAdditionalToolsItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAdditionalToolsItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAdditionalToolsItemParamRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAdditionalToolsItemParamRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAdditionalToolsItemParamRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAdditionalToolsItemParamRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolSearchOutputItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolSearchOutputItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionCallItemStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionCallItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionCallItemStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionCallItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputToolDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolSearchOutputToolDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputToolDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolSearchOutputToolDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputNamespaceToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolSearchOutputNamespaceToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputNamespaceToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolSearchOutputNamespaceToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputNamespaceToolParamToolDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolSearchOutputNamespaceToolParamToolDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputNamespaceToolParamToolDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolSearchOutputNamespaceToolParamToolDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputFunctionToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolSearchOutputFunctionToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputFunctionToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolSearchOutputFunctionToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchCallItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolSearchCallItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchCallItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolSearchCallItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMultiAgentCallOutputItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMultiAgentCallOutputItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputTextContentParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaOutputTextContentParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputTextContentParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaOutputTextContentParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputTextContentParamAnnotationDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaOutputTextContentParamAnnotationDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputTextContentParamAnnotationDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaOutputTextContentParamAnnotationDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerFileCitationParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerFileCitationParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerFileCitationParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerFileCitationParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaUrlCitationParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaUrlCitationParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaUrlCitationParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaUrlCitationParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileCitationParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFileCitationParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileCitationParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFileCitationParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentAction1))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMultiAgentAction1JsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentAction1?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMultiAgentAction1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMultiAgentCallItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMultiAgentCallItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAgentMessageItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAgentMessageItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAgentMessageItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAgentMessageItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAgentMessageItemParamContentItemDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAgentMessageItemParamContentItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAgentMessageItemParamContentItemDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAgentMessageItemParamContentItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaEncryptedContentParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaEncryptedContentParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaEncryptedContentParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaEncryptedContentParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputImageContentParamAutoParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputImageContentParamAutoParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputImageContentParamAutoParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputImageContentParamAutoParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheBreakpointParamMode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheBreakpointParamModeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheBreakpointParamMode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheBreakpointParamModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaDetailEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaDetailEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaDetailEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaDetailEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputTextContentParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputTextContentParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputTextContentParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputTextContentParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionCallOutputItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionCallOutputItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputFileContentParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputFileContentParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputFileContentParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputFileContentParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileDetailEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFileDetailEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileDetailEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFileDetailEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionToolCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionToolCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchToolCallActionDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchToolCallActionDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchToolCallActionDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchToolCallActionDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchActionFindType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchActionFindTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchActionFindType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchActionFindTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchActionOpenPageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchActionOpenPageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchActionOpenPageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchActionOpenPageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchActionSearchType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchActionSearchTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchActionSearchType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchActionSearchTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchActionSearchSourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchActionSearchSourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchActionSearchSourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchActionSearchSourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerCallOutputItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerCallOutputItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerCallOutputItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerCallOutputItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerScreenshotImageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerScreenshotImageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerScreenshotImageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerScreenshotImageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerToolCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerToolCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerActionDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerActionDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerActionDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerActionDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWaitParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWaitParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWaitParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWaitParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaTypeParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaTypeParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaTypeParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaTypeParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaScrollParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaScrollParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaScrollParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaScrollParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaScreenshotParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaScreenshotParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaScreenshotParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaScreenshotParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMoveParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMoveParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMoveParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMoveParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaKeyPressActionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaKeyPressActionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaKeyPressActionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaKeyPressActionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaDragParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaDragParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaDragParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaDragParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaDoubleClickActionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaDoubleClickActionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaDoubleClickActionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaDoubleClickActionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaClickParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaClickParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaClickParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaClickParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaClickButtonType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaClickButtonTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaClickButtonType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaClickButtonTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileSearchToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFileSearchToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileSearchToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFileSearchToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileSearchToolCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFileSearchToolCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileSearchToolCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFileSearchToolCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputMessageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaOutputMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputMessageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaOutputMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputMessageRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaOutputMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputMessageRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaOutputMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputMessageStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaOutputMessageStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputMessageStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaOutputMessageStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMessagePhase))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMessagePhaseJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMessagePhase?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMessagePhaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputMessageContentDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaOutputMessageContentDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputMessageContentDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaOutputMessageContentDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaRefusalContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaRefusalContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaRefusalContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaRefusalContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputTextContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaOutputTextContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputTextContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaOutputTextContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAnnotationDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAnnotationDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAnnotationDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAnnotationDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFilePathType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFilePathTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFilePathType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFilePathTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerFileCitationBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerFileCitationBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerFileCitationBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerFileCitationBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaUrlCitationBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaUrlCitationBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaUrlCitationBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaUrlCitationBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileCitationBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFileCitationBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileCitationBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFileCitationBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputMessageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputMessageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputMessageRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputMessageRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputMessageStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputMessageStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputMessageStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputMessageStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputContentDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputContentDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputContentDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputContentDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaEasyInputMessageRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaEasyInputMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaEasyInputMessageRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaEasyInputMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaEasyInputMessageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaEasyInputMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaEasyInputMessageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaEasyInputMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheModeEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheModeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheModeEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheModeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheTTLEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheTTLEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheTTLEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheTTLEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaModelIdsResponsesEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaModelIdsResponsesEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaModelIdsResponsesEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaModelIdsResponsesEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaModelIdsSharedEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaModelIdsSharedEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaModelIdsSharedEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaModelIdsSharedEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMisalignmentErrorTypeEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMisalignmentErrorTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMisalignmentErrorTypeEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMisalignmentErrorTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionCallOutputStatusEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionCallOutputStatusEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionCallOutputStatusEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionCallOutputStatusEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPApprovalResponseResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPApprovalResponseResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPApprovalResponseResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPApprovalResponseResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchToolCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchToolCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCallOutputStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchCallOutputStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCallOutputStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchCallOutputStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOperationDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchToolCallOperationDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOperationDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchToolCallOperationDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchUpdateFileOperationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchUpdateFileOperationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchDeleteFileOperationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchDeleteFileOperationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchCreateFileOperationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchCreateFileOperationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentOutcomeDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallOutputContentOutcomeDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentOutcomeDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallOutputContentOutcomeDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallOutputExitOutcomeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallOutputExitOutcomeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallOutputTimeoutOutcomeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallOutputTimeoutOutcomeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputStatusEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallOutputStatusEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputStatusEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallOutputStatusEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallEnvironmentVariant1DiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallEnvironmentVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallEnvironmentVariant1DiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallEnvironmentVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerReferenceResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerReferenceResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerReferenceResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerReferenceResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalEnvironmentResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaLocalEnvironmentResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalEnvironmentResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaLocalEnvironmentResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompactionBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCompactionBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompactionBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCompactionBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaProgramOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaProgramOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramOutputStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaProgramOutputStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramOutputStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaProgramOutputStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaProgramTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaProgramTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAdditionalToolsType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAdditionalToolsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAdditionalToolsType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAdditionalToolsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMessageRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMessageRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolSearchOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolSearchOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolSearchCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolSearchCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMultiAgentCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMultiAgentCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentAction))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMultiAgentActionJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentAction?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMultiAgentActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMultiAgentCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMultiAgentCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAgentMessageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAgentMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAgentMessageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAgentMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAgentMessageContentItemDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAgentMessageContentItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAgentMessageContentItemDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAgentMessageContentItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaEncryptedContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaEncryptedContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaEncryptedContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaEncryptedContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerScreenshotContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerScreenshotContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerScreenshotContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerScreenshotContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaTextContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaTextContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaTextContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaTextContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionToolCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionToolCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallOutputStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionToolCallOutputStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallOutputStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionToolCallOutputStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerCallOutputStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerCallOutputStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerCallOutputStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerCallOutputStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolCallOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerToolCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolCallOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerToolCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolCallOutputStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerToolCallOutputStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolCallOutputStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerToolCallOutputStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseCustomToolCallInputDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseCustomToolCallInputDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseCustomToolCallInputDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseCustomToolCallInputDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseQueuedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseQueuedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseQueuedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseQueuedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseVariant3Truncation))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseVariant3TruncationJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseVariant3Truncation?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseVariant3TruncationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseVariant3Object))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseVariant3ObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseVariant3Object?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseVariant3ObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseVariant3Status))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseVariant3StatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseVariant3Status?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseVariant3StatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseVariant3IncompleteDetailsReason))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseVariant3IncompleteDetailsReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseVariant3IncompleteDetailsReason?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseVariant3IncompleteDetailsReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationInputDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaModerationInputDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationInputDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaModerationInputDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationOutputDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaModerationOutputDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationOutputDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaModerationOutputDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationErrorBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaModerationErrorBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationErrorBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaModerationErrorBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationResultBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaModerationResultBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationResultBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaModerationResultBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationInputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaModerationInputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationInputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaModerationInputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheDiagnosticsDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheDiagnosticsDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheDiagnosticsDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheDiagnosticsDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheUnavailableDiagnosticsBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheUnavailableDiagnosticsBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheHitDiagnosticsBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheHitDiagnosticsBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheMissDiagnosticsBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheMissDiagnosticsBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCacheMissReasonTypeEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCacheMissReasonTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCacheMissReasonTypeEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCacheMissReasonTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputItemDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaOutputItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputItemDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaOutputItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseErrorCode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseErrorCode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCyberAccessProgramEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCyberAccessProgramEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCyberAccessProgramEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCyberAccessProgramEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaServiceTierResponsesEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaServiceTierResponsesEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaServiceTierResponsesEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaServiceTierResponsesEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaModelResponsePropertiesPromptCacheRetention))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaModelResponsePropertiesPromptCacheRetentionJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaModelResponsePropertiesPromptCacheRetention?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaModelResponsePropertiesPromptCacheRetentionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseOutputTextAnnotationAddedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseOutputTextAnnotationAddedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseMCPListToolsInProgressEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseMCPListToolsInProgressEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseMCPListToolsFailedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseMCPListToolsFailedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseMCPListToolsCompletedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseMCPListToolsCompletedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseMCPCallInProgressEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseMCPCallInProgressEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallFailedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseMCPCallFailedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallFailedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseMCPCallFailedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseMCPCallCompletedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseMCPCallCompletedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseMCPCallArgumentsDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseMCPCallArgumentsDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseMCPCallArgumentsDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseMCPCallArgumentsDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseImageGenCallPartialImageEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseImageGenCallPartialImageEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseImageGenCallInProgressEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseImageGenCallInProgressEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseImageGenCallGeneratingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseImageGenCallGeneratingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseImageGenCallCompletedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseImageGenCallCompletedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseReasoningTextDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseReasoningTextDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseReasoningTextDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseReasoningTextDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseReasoningSummaryTextDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseReasoningSummaryTextDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseReasoningSummaryTextDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseReasoningSummaryTextDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseReasoningSummaryPartDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseReasoningSummaryPartDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseReasoningSummaryPartDoneEventStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseReasoningSummaryPartDoneEventStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventPartType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseReasoningSummaryPartDoneEventPartTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventPartType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseReasoningSummaryPartDoneEventPartTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseReasoningSummaryPartAddedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseReasoningSummaryPartAddedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEventPartType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseReasoningSummaryPartAddedEventPartTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEventPartType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseReasoningSummaryPartAddedEventPartTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseTextDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseTextDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseTextDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseTextDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseTextDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseTextDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseTextDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseTextDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseRefusalDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseRefusalDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseRefusalDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseRefusalDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseRefusalDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseRefusalDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseRefusalDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseRefusalDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseOutputItemDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseOutputItemDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseOutputItemDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseOutputItemDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseOutputItemAddedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseOutputItemAddedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseOutputItemAddedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseOutputItemAddedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseInProgressEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseInProgressEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseInProgressEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseInProgressEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseShellCallOutputContentDoneStreamingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseShellCallOutputContentDoneStreamingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseShellCallOutputContentDeltaStreamingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseShellCallOutputContentDeltaStreamingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseShellCallCommandDoneStreamingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseShellCallCommandDoneStreamingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseShellCallCommandDeltaStreamingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseShellCallCommandDeltaStreamingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseShellCallCommandAddedStreamingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseShellCallCommandAddedStreamingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseFunctionCallArgumentsDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseFunctionCallArgumentsDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseFunctionCallArgumentsDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseFunctionCallArgumentsDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseFileSearchCallSearchingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseFileSearchCallSearchingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseFileSearchCallInProgressEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseFileSearchCallInProgressEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseFileSearchCallCompletedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseFileSearchCallCompletedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCreatedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseCreatedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCreatedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseCreatedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseContentPartDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseContentPartDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseContentPartDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseContentPartDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputContentDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaOutputContentDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputContentDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaOutputContentDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseContentPartAddedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseContentPartAddedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseContentPartAddedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseContentPartAddedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCompletedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseCompletedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCompletedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseCompletedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseCompactionCompactingStreamingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseCompactionCompactingStreamingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseCodeInterpreterCallInterpretingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseCodeInterpreterCallInterpretingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseCodeInterpreterCallInProgressEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseCodeInterpreterCallInProgressEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseCodeInterpreterCallCompletedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseCodeInterpreterCallCompletedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseCodeInterpreterCallCodeDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseCodeInterpreterCallCodeDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseCodeInterpreterCallCodeDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseCodeInterpreterCallCodeDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseAudioTranscriptDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseAudioTranscriptDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseAudioTranscriptDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseAudioTranscriptDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseAudioDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseAudioDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseAudioDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseAudioDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseAudioDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseAudioDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseAudioDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseAudioDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseIncompleteEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseIncompleteEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseIncompleteEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseIncompleteEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFailedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseFailedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFailedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseFailedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseWebSearchCallCompletedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseWebSearchCallCompletedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseWebSearchCallSearchingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseWebSearchCallSearchingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseWebSearchCallInProgressEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseWebSearchCallInProgressEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerFailedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerFailedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerFailedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerFailedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerFailedEventErrorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerFailedEventErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerFailedEventErrorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerFailedEventErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerErrorCodeEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerErrorCodeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerErrorCodeEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerErrorCodeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerInputItemDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerInputItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerInputItemDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerInputItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaUserMessageItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaUserMessageItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaUserMessageItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaUserMessageItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaUserMessageItemParamRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaUserMessageItemParamRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaUserMessageItemParamRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaUserMessageItemParamRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaUserMessageItemParamContentVariant1ItemDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaUserMessageItemParamContentVariant1ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaUserMessageItemParamContentVariant1ItemDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaUserMessageItemParamContentVariant1ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerPendingEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerPendingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerPendingEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerPendingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredFunctionToolCallOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerRequiredInputRequiredFunctionToolCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredFunctionToolCallOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerRequiredInputRequiredFunctionToolCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredCustomToolCallOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerRequiredInputRequiredCustomToolCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredCustomToolCallOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerRequiredInputRequiredCustomToolCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredComputerToolCallOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerRequiredInputRequiredComputerToolCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredComputerToolCallOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerRequiredInputRequiredComputerToolCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredShellToolCallOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerRequiredInputRequiredShellToolCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredShellToolCallOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerRequiredInputRequiredShellToolCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerRequiredInputRequiredToolSearchOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerRequiredInputRequiredToolSearchOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutputExecution))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerRequiredInputRequiredToolSearchOutputExecutionJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutputExecution?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerRequiredInputRequiredToolSearchOutputExecutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredMcpApprovalResponseType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerRequiredInputRequiredMcpApprovalResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredMcpApprovalResponseType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerRequiredInputRequiredMcpApprovalResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerRequiredInputDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerRequiredInputDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerPendingReasonEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerPendingReasonEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerPendingReasonEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerPendingReasonEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerAcceptedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerAcceptedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerAcceptedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerAcceptedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseSteerEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaIncludeEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaIncludeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaIncludeEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaIncludeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponsesServerEventDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponsesServerEventDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseInjectFailedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseInjectFailedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseInjectFailedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseInjectFailedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseInjectFailedEventErrorCode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseInjectFailedEventErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseInjectFailedEventErrorCode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseInjectFailedEventErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseInjectCreatedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseInjectCreatedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseInjectCreatedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseInjectCreatedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseWsErrorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseWsErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseWsErrorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseWsErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponsesClientEventDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponsesClientEventDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponsesClientEventDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponsesClientEventDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseInjectEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseInjectEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseInjectEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseInjectEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreateVariant1Type))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponsesClientEventResponseCreateVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreateVariant1Type?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponsesClientEventResponseCreateVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCreateResponseVariant3Truncation))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCreateResponseVariant3TruncationJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCreateResponseVariant3Truncation?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCreateResponseVariant3TruncationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationMode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaModerationModeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationMode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaModerationModeNullableJsonConverter();
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
                if (type == typeof(float))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Single(options);
                }
                if (type == typeof(global::System.Collections.Generic.Dictionary<string, bool>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_651A92249C8DF755(options);
                }
                if (type == typeof(global::System.Collections.Generic.Dictionary<string, double>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_3D6C2C32ACF6EA76(options);
                }
                if (type == typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaModerationInputType>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_4F141A7F6E6ABA43(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AnnotationsItem4>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_0184095532870624(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaAnnotation>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_28627596212A6D1F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaCallableToolAllowedCaller>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_EAE69C9361FEA0E6(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaComputerAction>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_BB2D4630248C3D9E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaComputerCallSafetyCheckParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_2E52A3FB7F4656C7(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaContainerNetworkPolicyDomainSecretParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_2DA866CD6D65D4EE(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaContextManagementParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_F5E1164BB954D5D9(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaCoordParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_868D74A12316CA57(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFileSearchToolCallResultsVariant1Item>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_42298D19FAC7AD3F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutput>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_DA242A6FEE39F720(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFunctionShellCallOutputContent>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_53F81CC8ECF8CE82(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_64C1847A1BA830A6(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaIncludeEnum>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_A7D538BB28F1B882(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputContent>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_0870B3270BE4551B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_C513BD57C3065594(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaLocalSkillParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_D386F3831B29642B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaLogProb>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_BCFC6F2E7FEDB48B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaMCPListToolsTool>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_669F3B648E25BED6(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaOutputItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_FB056AA29F9C1B39(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaOutputMessageContent>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_28425893C798AE0F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaOutputTextContent>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_BABAE7834F1D20C8(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaOutputTextContentParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_E4482AE89AAB8662(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaReasoningTextContent>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_5F5D07C079C7D728(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaResponseLogProb>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_5C7E0CDDF91816E3(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaResponseLogProbTopLogprob>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_DAB5721F01046A19(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaResponseSteerInputItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_F62F620E637ACDFA(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaResponseSteerRequiredInput>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_EC64B117F29997D5(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaSearchContentType>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_7C85385FBE0CEB3E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaSummaryTextContent>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_89FA55441C675A73(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaTool>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_D6AF8FE2BB293ED3(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaToolSearchOutputTool>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_E2E6C6FCCABA15C3(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaTopLogProb>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_D95F66A199316195(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaWebSearchActionSearchSource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_69AD0CFC0D9EFC59(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem6>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_BCC9988549A1BB10(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem7>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_685777B8ED7C8820(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant1Item2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_1BBFB82CCD7197C7(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FiltersItem2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_2C996200A138DC7E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_A588C663D689201D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_D2B011C856F44B65(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputsVariant1Item2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_083CA171AC868424(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillsItem3>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_3F2038DF7B013DC9(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem18>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_E375E849C1462BFC(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem19>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_1FC805B09DB949B0(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<long>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_FFC153334BACEC95(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<object>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_3C7D8BEF5867F4EF(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_05BF36C073875770(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDelta2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_D75BC9FE7315DC6B(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDone2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_87211B6C6EA2DCB7(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDelta2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_3F4B9EFB940089F8(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDone2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_BEFDFCEBECA7407C(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDelta2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_23C622B70DC47CDF(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDone2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_4BE434EB6F7E80B6(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsCompleted2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_4A8505D32739FA51(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallInWsProgress2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_572B2C7E0218F9C3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsInterpreting2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_FCAE2E08275346C5(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCompactionWsCompacting2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_D374361C082915FC(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCompleted2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_D3216CB3E0B31975(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsAdded2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_9C8BCB301F10B50E(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsDone2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_DB8A97074CF6CEB3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCreatedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCreated2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_EC010B4473E0D6A4(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDelta2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_73AEC7EC6BD8C05F(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDone2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_B5FA39D4A22CA0EB(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsFailed2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_DBC984BCDC84CB5B(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsCompleted2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_B287963543375D9D(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallInWsProgress2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_9115333422658473(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsSearching2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_2E949E515191F1FE(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDelta2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_7FDFFCC644A0C884(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_FA790D60B20724F9(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsCompleted2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_BD7D8E41086D269B(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsGenerating2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_3A53945DE892516C(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallInWsProgress2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_E271361205E56A68(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallPartialWsImage2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_9C0F94711C178854(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseInWsProgress2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_88A5C0FCFBBD7FC9(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseIncompleteEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsIncomplete2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_BF85A6056C96C8BD(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDelta2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_4D0AFAC1DF36DC12(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDone2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_6E885ABE4AEAA13D(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsCompleted2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_4CD78C9FF64D16CB(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsFailed2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_AE168B653A794EB2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallInWsProgress2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_9E72DD1E463E1B8D(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsCompleted2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_FABEB602415B7A25(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsFailed2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_D9C583F8B0407E49(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsInWsProgress2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_DC794DFA9DFC19DF(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsAdded2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_4944C6043218F521(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsDone2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_17090BE6CEE5623A(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputTextAnnotationWsAdded2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_BB5378FCCC7CD254(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseQueuedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsQueued2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_880CD36B1BB93072(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsAdded2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_2B1F34A401DBE601(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsDone2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_C5D28A9399E2BBF1(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDelta2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_8BC1BC537E1D82CA(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDone2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_E44EF6F4119CD7AF(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDelta2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_AFE50829A0203ED2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDone2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_33D83EEDD2FF7B62(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDelta2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_6DD077518E087841(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDone2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_9F4B05F6BCAAAE95(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsAdded2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_2DBECD1210B176AA(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDelta2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_D4856E704B6B4A0B(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDone2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_6741818E03920ACF(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDelta2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_6BDBFF1B8BB8F5E4(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDone2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_E81390156E4261DC(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDelta2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_CFACAC007340705D(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDone2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_D649E5A3A0B72776(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsCompleted2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_16D85DE4527EDE32(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallInWsProgress2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_6B6354FA28CFB76D(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsSearching2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_E99E9FBDC7D60C8C(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnnotationsItem4))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_AnnotationsItem42(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.BetaImageGenToolCallSizeVariant1?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_FEF821324AD8E282(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.BetaImageGenToolModel?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_C236CB9A53D5F0E5(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.BetaImageGenToolSize?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_F928175D16C32167(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAccessProgramsBody))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaAccessProgramsBody(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAccessProgramsParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaAccessProgramsParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAdditionalTools))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaAdditionalTools(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAdditionalToolsItemParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaAdditionalToolsItemParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAdditionalToolsItemParamRole))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaAdditionalToolsItemParamRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAdditionalToolsItemParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaAdditionalToolsItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAdditionalToolsType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaAdditionalToolsType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAgentMessage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaAgentMessage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAgentMessageContentItemDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaAgentMessageContentItemDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAgentMessageContentItemDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaAgentMessageContentItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAgentMessageItemParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaAgentMessageItemParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAgentMessageItemParamContentItemDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaAgentMessageItemParamContentItemDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAgentMessageItemParamContentItemDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaAgentMessageItemParamContentItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAgentMessageItemParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaAgentMessageItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAgentMessageType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaAgentMessageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAgentTag))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaAgentTag(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAgentTagParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaAgentTagParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAnnotation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaAnnotation(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAnnotationDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaAnnotationDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAnnotationDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaAnnotationDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchCallOutputStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaApplyPatchCallOutputStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchCallOutputStatusParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaApplyPatchCallOutputStatusParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchCallStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaApplyPatchCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchCallStatusParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaApplyPatchCallStatusParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaApplyPatchCreateFileOperation(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaApplyPatchCreateFileOperationParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaApplyPatchCreateFileOperationParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaApplyPatchCreateFileOperationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaApplyPatchDeleteFileOperation(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaApplyPatchDeleteFileOperationParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaApplyPatchDeleteFileOperationParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaApplyPatchDeleteFileOperationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchOperationParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaApplyPatchOperationParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchOperationParamDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaApplyPatchOperationParamDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchOperationParamDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaApplyPatchOperationParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCall))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaApplyPatchToolCall(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallItemParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaApplyPatchToolCallItemParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallItemParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaApplyPatchToolCallItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOperationDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaApplyPatchToolCallOperationDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOperationDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaApplyPatchToolCallOperationDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOutput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaApplyPatchToolCallOutput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputItemParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaApplyPatchToolCallOutputItemParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputItemParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaApplyPatchToolCallOutputItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaApplyPatchToolCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaApplyPatchToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaApplyPatchToolParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaApplyPatchToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaApplyPatchUpdateFileOperation(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaApplyPatchUpdateFileOperationParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaApplyPatchUpdateFileOperationParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaApplyPatchUpdateFileOperationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApproximateLocation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaApproximateLocation(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApproximateLocationType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaApproximateLocationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaAutoCodeInterpreterToolParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaAutoCodeInterpreterToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCacheMissReasonTypeEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCacheMissReasonTypeEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCallableToolAllowedCaller))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCallableToolAllowedCaller2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaClickButtonType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaClickButtonType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaClickParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaClickParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaClickParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaClickParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterOutputImage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCodeInterpreterOutputImage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterOutputImageType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCodeInterpreterOutputImageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogs))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCodeInterpreterOutputLogs(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogsType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCodeInterpreterOutputLogsType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCodeInterpreterTool(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolCall))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCodeInterpreterToolCall(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolCallStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCodeInterpreterToolCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolCallType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCodeInterpreterToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCodeInterpreterToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCompactionBody))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCompactionBody(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCompactionBodyType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCompactionBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCompactionSummaryItemParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCompactionSummaryItemParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCompactionSummaryItemParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCompactionSummaryItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCompactionTriggerItemParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCompactionTriggerItemParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCompactionTriggerItemParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCompactionTriggerItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComparisonFilter))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaComparisonFilter(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComparisonFilterType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaComparisonFilterType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCompoundFilter))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCompoundFilter(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCompoundFilterFilterDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCompoundFilterFilterDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCompoundFilterType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCompoundFilterType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerAction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaComputerAction2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerActionDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaComputerActionDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerActionDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaComputerActionDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerCallOutputItemParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaComputerCallOutputItemParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerCallOutputItemParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaComputerCallOutputItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerCallOutputStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaComputerCallOutputStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerCallSafetyCheckParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaComputerCallSafetyCheckParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerEnvironment))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaComputerEnvironment2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerScreenshotContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaComputerScreenshotContent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerScreenshotContentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaComputerScreenshotContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerScreenshotImage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaComputerScreenshotImage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerScreenshotImageType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaComputerScreenshotImageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaComputerTool(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerToolCall))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaComputerToolCall(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerToolCallOutput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaComputerToolCallOutput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerToolCallOutputResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaComputerToolCallOutputResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerToolCallOutputResourceVariant2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaComputerToolCallOutputResourceVariant2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerToolCallOutputStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaComputerToolCallOutputStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerToolCallOutputType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaComputerToolCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerToolCallStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaComputerToolCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerToolCallType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaComputerToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerToolType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaComputerToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerUsePreviewTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaComputerUsePreviewTool(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerUsePreviewToolType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaComputerUsePreviewToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerAutoParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaContainerAutoParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamNetworkPolicyDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaContainerAutoParamNetworkPolicyDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamNetworkPolicyDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaContainerAutoParamNetworkPolicyDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamSkillDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaContainerAutoParamSkillDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamSkillDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaContainerAutoParamSkillDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaContainerAutoParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerFileCitationBody))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaContainerFileCitationBody(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerFileCitationBodyType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaContainerFileCitationBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerFileCitationParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaContainerFileCitationParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerFileCitationParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaContainerFileCitationParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerMemoryLimit))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaContainerMemoryLimit2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaContainerNetworkPolicyAllowlistParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaContainerNetworkPolicyAllowlistParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaContainerNetworkPolicyDisabledParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaContainerNetworkPolicyDisabledParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyDomainSecretParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaContainerNetworkPolicyDomainSecretParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerReferenceParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaContainerReferenceParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerReferenceParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaContainerReferenceParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerReferenceResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaContainerReferenceResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerReferenceResourceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaContainerReferenceResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContextManagementParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaContextManagementParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaConversationParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaConversationParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaConversationParam2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaConversationParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCoordParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCoordParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCreateModelResponseProperties))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCreateModelResponseProperties2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCreateModelResponsePropertiesVariant2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCreateModelResponsePropertiesVariant2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCreateResponse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCreateResponse2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCreateResponseVariant3))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCreateResponseVariant3(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.BetaCreateResponseVariant3Truncation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCreateResponseVariant3Truncation2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::tryAGI.OpenAI.BetaCustomGrammarFormatParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCustomGrammarFormatParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCustomGrammarFormatParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCustomGrammarFormatParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCustomTextFormatParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCustomTextFormatParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCustomTextFormatParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCustomTextFormatParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCustomToolCall))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCustomToolCall(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCustomToolCallOutput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCustomToolCallOutput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCustomToolCallOutputResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCustomToolCallOutputResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCustomToolCallOutputResourceVariant2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCustomToolCallOutputResourceVariant2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCustomToolCallOutputType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCustomToolCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCustomToolCallType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCustomToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCustomToolParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCustomToolParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCustomToolParamFormatDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCustomToolParamFormatDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCustomToolParamFormatDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCustomToolParamFormatDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCustomToolParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCustomToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCyberAccessProgramEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaCyberAccessProgramEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaDetailEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaDetailEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaDirectToolCallCaller))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaDirectToolCallCaller(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaDirectToolCallCallerParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaDirectToolCallCallerParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaDirectToolCallCallerParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaDirectToolCallCallerParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaDirectToolCallCallerType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaDirectToolCallCallerType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaDoubleClickAction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaDoubleClickAction(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaDoubleClickActionType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaDoubleClickActionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaDragParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaDragParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaDragParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaDragParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaEasyInputMessage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaEasyInputMessage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaEasyInputMessageRole))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaEasyInputMessageRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaEasyInputMessageType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaEasyInputMessageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaEmptyModelParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaEmptyModelParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaEncryptedContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaEncryptedContent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaEncryptedContentParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaEncryptedContentParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaEncryptedContentParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaEncryptedContentParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaEncryptedContentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaEncryptedContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaErrorPayload))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaErrorPayload(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFileCitationBody))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFileCitationBody(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFileCitationBodyType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFileCitationBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFileCitationParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFileCitationParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFileCitationParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFileCitationParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFileDetailEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFileDetailEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFileInputDetail))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFileInputDetail2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFilePath))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFilePath(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFilePathType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFilePathType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFileSearchTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFileSearchTool(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFileSearchToolCall))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFileSearchToolCall(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFileSearchToolCallResultsVariant1Item))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFileSearchToolCallResultsVariant1Item(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFileSearchToolCallStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFileSearchToolCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFileSearchToolCallType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFileSearchToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFileSearchToolType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFileSearchToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFilters))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFilters(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionAndCustomToolCallOutput2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutputDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionAndCustomToolCallOutputDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutputDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionAndCustomToolCallOutputDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionCallItemStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionCallItemStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionCallOutputItemParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionCallOutputItemParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionCallOutputItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionCallOutputStatusEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionCallOutputStatusEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionCallStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellAction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionShellAction(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellActionParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionShellActionParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCall))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionShellCall(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallEnvironmentVariant1Discriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionShellCallEnvironmentVariant1Discriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallEnvironmentVariant1DiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionShellCallEnvironmentVariant1DiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallItemParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionShellCallItemParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallItemParamEnvironmentVariant1Discriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionShellCallItemParamEnvironmentVariant1Discriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallItemParamEnvironmentVariant1DiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionShellCallItemParamEnvironmentVariant1DiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallItemParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionShellCallItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallItemStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionShellCallItemStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionShellCallOutput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionShellCallOutputContent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentOutcomeDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionShellCallOutputContentOutcomeDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentOutcomeDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionShellCallOutputContentOutcomeDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionShellCallOutputContentParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcome))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionShellCallOutputExitOutcome(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionShellCallOutputExitOutcomeParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionShellCallOutputExitOutcomeParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionShellCallOutputExitOutcomeType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputItemParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionShellCallOutputItemParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputItemParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionShellCallOutputItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputOutcomeParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionShellCallOutputOutcomeParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputOutcomeParamDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionShellCallOutputOutcomeParamDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputOutcomeParamDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionShellCallOutputOutcomeParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputStatusEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionShellCallOutputStatusEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcome))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionShellCallOutputTimeoutOutcome(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionShellCallOutputTimeoutOutcomeParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionShellCallOutputTimeoutOutcomeParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionShellCallOutputTimeoutOutcomeType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionShellCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionShellCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionShellCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionShellToolParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParamEnvironmentVariant1Discriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionShellToolParamEnvironmentVariant1Discriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionShellToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionTool(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionToolCall))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionToolCall(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallOutput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionToolCallOutput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallOutputResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionToolCallOutputResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallOutputResourceVariant2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionToolCallOutputResourceVariant2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallOutputStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionToolCallOutputStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallOutputType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionToolCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionToolCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionToolParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionToolParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionToolParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionToolType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFunctionToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaGrammarSyntax1))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaGrammarSyntax12(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaHTTPError))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaHTTPError(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaHTTPErrorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaHTTPErrorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaHybridSearchOptions))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaHybridSearchOptions(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageBackground))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaImageBackground2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageDetail))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaImageDetail2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenActionEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaImageGenActionEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaImageGenTool(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolBackground))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaImageGenToolBackground2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolCall))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaImageGenToolCall(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallError))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaImageGenToolCallError(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallModerationDetails))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaImageGenToolCallModerationDetails(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallModerationDetailsModerationStage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaImageGenToolCallModerationDetailsModerationStage2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallQuality))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaImageGenToolCallQuality2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallSizeVariant1))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaImageGenToolCallSizeVariant12(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaImageGenToolCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaImageGenToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolInputImageMask))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaImageGenToolInputImageMask(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolModel))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaImageGenToolModel2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolModeration))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaImageGenToolModeration2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolOutputFormat))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaImageGenToolOutputFormat2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolQuality))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaImageGenToolQuality2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolSize))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaImageGenToolSize2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaImageGenToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageOutputFormat))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaImageOutputFormat2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaIncludeEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaIncludeEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInlineSkillParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInlineSkillParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInlineSkillParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInlineSkillParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInlineSkillSourceParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInlineSkillSourceParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInlineSkillSourceParamMediaType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInlineSkillSourceParamMediaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInlineSkillSourceParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInlineSkillSourceParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInputContent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputContentDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInputContentDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputContentDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInputContentDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputFidelity))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInputFidelity2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputFileContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInputFileContent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputFileContentParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInputFileContentParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputFileContentParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInputFileContentParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputFileContentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInputFileContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputImageContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInputImageContent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputImageContentParamAutoParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInputImageContentParamAutoParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputImageContentParamAutoParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInputImageContentParamAutoParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputImageContentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInputImageContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInputItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputItemDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInputItemDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputItemDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInputItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputMessage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInputMessage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputMessageRole))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInputMessageRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputMessageStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInputMessageStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputMessageType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInputMessageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInputParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputTextContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInputTextContent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputTextContentParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInputTextContentParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputTextContentParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInputTextContentParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputTextContentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInputTextContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaItemDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaItemDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaItemDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaItemReferenceParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaItemReferenceParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaItemReferenceParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaItemReferenceParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaKeyPressAction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaKeyPressAction(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaKeyPressActionType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaKeyPressActionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaLocalEnvironmentParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaLocalEnvironmentParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaLocalEnvironmentParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaLocalEnvironmentParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaLocalEnvironmentResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaLocalEnvironmentResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaLocalEnvironmentResourceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaLocalEnvironmentResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaLocalShellExecAction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaLocalShellExecAction(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaLocalShellExecActionType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaLocalShellExecActionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCall))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaLocalShellToolCall(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallOutput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaLocalShellToolCallOutput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallOutputStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaLocalShellToolCallOutputStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallOutputType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaLocalShellToolCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaLocalShellToolCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaLocalShellToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaLocalShellToolParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaLocalShellToolParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaLocalShellToolParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaLocalShellToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaLocalSkillParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaLocalSkillParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaLogProb))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaLogProb(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPApprovalRequest))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMCPApprovalRequest(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPApprovalRequestType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMCPApprovalRequestType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPApprovalResponse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMCPApprovalResponse(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPApprovalResponseResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMCPApprovalResponseResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPApprovalResponseResourceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMCPApprovalResponseResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPApprovalResponseType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMCPApprovalResponseType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPListTools))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMCPListTools(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPListToolsTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMCPListToolsTool(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPListToolsType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMCPListToolsType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPProtocolError))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMCPProtocolError(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPProtocolErrorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMCPProtocolErrorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMCPTool(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPToolCall))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMCPToolCall(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPToolCallError))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMCPToolCallError(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPToolCallErrorDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMCPToolCallErrorDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPToolCallErrorDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMCPToolCallErrorDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPToolCallStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMCPToolCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPToolCallType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMCPToolCallType2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPToolConnectorId))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMCPToolConnectorId2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPToolExecutionError))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMCPToolExecutionError(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPToolExecutionErrorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMCPToolExecutionErrorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPToolFilter))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMCPToolFilter(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMCPToolRequireApprovalVariant1Enum(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMCPToolRequireApprovalVariant1Enum22(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPToolType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMCPToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMessagePhase))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMessagePhase2_3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMessageRole))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMessageRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMisalignmentErrorDetailsResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMisalignmentErrorDetailsResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMisalignmentErrorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMisalignmentErrorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMisalignmentErrorTypeEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMisalignmentErrorTypeEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMisalignmentSteer))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMisalignmentSteer(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaModelIdsResponses))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaModelIdsResponses2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaModelIdsResponsesEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaModelIdsResponsesEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaModelIdsShared))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaModelIdsShared2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaModelIdsSharedEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaModelIdsSharedEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaModelResponseProperties))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaModelResponseProperties(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.BetaModelResponsePropertiesPromptCacheRetention))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaModelResponsePropertiesPromptCacheRetention2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::tryAGI.OpenAI.BetaModeration))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaModeration(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaModerationConfigParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaModerationConfigParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaModerationErrorBody))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaModerationErrorBody(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaModerationErrorBodyType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaModerationErrorBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaModerationInputDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaModerationInputDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaModerationInputDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaModerationInputDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaModerationInputType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaModerationInputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaModerationMode))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaModerationMode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaModerationOutputDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaModerationOutputDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaModerationOutputDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaModerationOutputDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaModerationParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaModerationParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaModerationPolicyParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaModerationPolicyParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaModerationResultBody))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaModerationResultBody(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaModerationResultBodyType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaModerationResultBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMoveParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMoveParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMoveParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMoveParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMultiAgentAction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMultiAgentAction2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMultiAgentAction1))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMultiAgentAction12(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMultiAgentCall))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMultiAgentCall(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallItemParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMultiAgentCallItemParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallItemParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMultiAgentCallItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallOutput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMultiAgentCallOutput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMultiAgentCallOutputItemParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMultiAgentCallOutputItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallOutputType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMultiAgentCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMultiAgentCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMultiAgentParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaMultiAgentParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaNamespaceToolParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaNamespaceToolParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaNamespaceToolParamToolDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaNamespaceToolParamToolDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaNamespaceToolParamToolDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaNamespaceToolParamToolDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaNamespaceToolParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaNamespaceToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaOutputContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaOutputContent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaOutputContentDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaOutputContentDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaOutputContentDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaOutputContentDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaOutputItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaOutputItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaOutputItemDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaOutputItemDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaOutputItemDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaOutputItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaOutputMessage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaOutputMessage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaOutputMessageContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaOutputMessageContent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaOutputMessageContentDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaOutputMessageContentDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaOutputMessageContentDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaOutputMessageContentDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaOutputMessageRole))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaOutputMessageRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaOutputMessageStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaOutputMessageStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaOutputMessageType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaOutputMessageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaOutputTextContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaOutputTextContent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaOutputTextContentParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaOutputTextContentParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaOutputTextContentParamAnnotationDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaOutputTextContentParamAnnotationDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaOutputTextContentParamAnnotationDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaOutputTextContentParamAnnotationDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaOutputTextContentParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaOutputTextContentParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaOutputTextContentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaOutputTextContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaProgram))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaProgram(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaProgramItemParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaProgramItemParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaProgramItemParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaProgramItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaProgramOutput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaProgramOutput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaProgramOutputItemParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaProgramOutputItemParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaProgramOutputItemParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaProgramOutputItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaProgramOutputItemStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaProgramOutputItemStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaProgramOutputStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaProgramOutputStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaProgramOutputType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaProgramOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaProgramToolCallCaller))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaProgramToolCallCaller(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaProgramToolCallCallerParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaProgramToolCallCallerParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaProgramToolCallCallerParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaProgramToolCallCallerParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaProgramToolCallCallerType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaProgramToolCallCallerType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaProgramType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaProgramType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaProgrammaticToolCallingParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaProgrammaticToolCallingParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaProgrammaticToolCallingParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaProgrammaticToolCallingParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaPromptCacheBreakpointConfig))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaPromptCacheBreakpointConfig(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaPromptCacheBreakpointConfigMode))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaPromptCacheBreakpointConfigMode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaPromptCacheBreakpointParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaPromptCacheBreakpointParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaPromptCacheBreakpointParamMode))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaPromptCacheBreakpointParamMode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBody))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaPromptCacheComparisonResponseNotFoundDiagnosticsBody(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBodyType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaPromptCacheComparisonResponseNotFoundDiagnosticsBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaPromptCacheDiagnostics))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaPromptCacheDiagnostics2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaPromptCacheDiagnosticsDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaPromptCacheDiagnosticsDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaPromptCacheDiagnosticsDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaPromptCacheDiagnosticsDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBody))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaPromptCacheHitDiagnosticsBody(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBodyType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaPromptCacheHitDiagnosticsBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBody))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaPromptCacheMissDiagnosticsBody(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBodyType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaPromptCacheMissDiagnosticsBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaPromptCacheModeEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaPromptCacheModeEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaPromptCacheOptions))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaPromptCacheOptions(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaPromptCacheOptionsParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaPromptCacheOptionsParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaPromptCacheTTLEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaPromptCacheTTLEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBody))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaPromptCacheUnavailableDiagnosticsBody(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBodyType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaPromptCacheUnavailableDiagnosticsBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaPromptVariant1))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaPromptVariant1(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaRankerVersionType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaRankerVersionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaRankingOptions))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaRankingOptions(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaReasoning))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaReasoning(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaReasoningContext))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaReasoningContext2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaReasoningEffortEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaReasoningEffortEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaReasoningGenerateSummary))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaReasoningGenerateSummary2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaReasoningItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaReasoningItem(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaReasoningItemStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaReasoningItemStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaReasoningItemType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaReasoningItemType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaReasoningModeEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaReasoningModeEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaReasoningModeEnumEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaReasoningModeEnumEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaReasoningSummary))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaReasoningSummary2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaReasoningTextContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaReasoningTextContent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaReasoningTextContentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaReasoningTextContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaRefusalContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaRefusalContent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaRefusalContentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaRefusalContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponse2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseAudioDeltaEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseAudioDeltaEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseAudioDeltaEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseAudioDoneEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseAudioDoneEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseAudioDoneEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseAudioDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseAudioTranscriptDeltaEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseAudioTranscriptDeltaEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseAudioTranscriptDoneEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseAudioTranscriptDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseCodeInterpreterCallCodeDeltaEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseCodeInterpreterCallCodeDeltaEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseCodeInterpreterCallCodeDoneEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseCodeInterpreterCallCodeDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseCodeInterpreterCallCompletedEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseCodeInterpreterCallCompletedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseCodeInterpreterCallInProgressEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseCodeInterpreterCallInProgressEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseCodeInterpreterCallInterpretingEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseCodeInterpreterCallInterpretingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseCompactionCompactingStreamingEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseCompactionCompactingStreamingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseCompletedEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseCompletedEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseCompletedEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseCompletedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseConfigurationUpdateItemParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParamReasoning))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseConfigurationUpdateItemParamReasoning(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseConfigurationUpdateItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseContentPartAddedEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseContentPartAddedEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseContentPartAddedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseContentPartDoneEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseContentPartDoneEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseContentPartDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseConversation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseConversation(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseCreatedEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseCreatedEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseCreatedEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseCreatedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseCustomToolCallInputDeltaEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseCustomToolCallInputDeltaEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseCustomToolCallInputDoneEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseCustomToolCallInputDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseErrorCode))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseErrorCode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseErrorVariant1))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseErrorVariant1(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseFailedEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseFailedEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseFailedEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseFailedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseFileSearchCallCompletedEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseFileSearchCallCompletedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseFileSearchCallInProgressEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseFileSearchCallInProgressEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseFileSearchCallSearchingEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseFileSearchCallSearchingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseFormatJsonObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseFormatJsonObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseFormatJsonObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseFormatJsonObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseFormatJsonSchemaSchema))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseFormatJsonSchemaSchema(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseFormatText))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseFormatText(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseFormatTextType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseFormatTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseFunctionCallArgumentsDeltaEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseFunctionCallArgumentsDeltaEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseFunctionCallArgumentsDoneEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseFunctionCallArgumentsDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseImageGenCallCompletedEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseImageGenCallCompletedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseImageGenCallGeneratingEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseImageGenCallGeneratingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseImageGenCallInProgressEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseImageGenCallInProgressEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseImageGenCallPartialImageEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseImageGenCallPartialImageEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseInProgressEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseInProgressEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseInProgressEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseInProgressEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseIncompleteEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseIncompleteEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseIncompleteEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseIncompleteEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseInjectCreatedEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseInjectCreatedEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseInjectCreatedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseInjectEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseInjectEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseInjectEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseInjectEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseInjectFailedEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseInjectFailedEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseInjectFailedEventError))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseInjectFailedEventError(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseInjectFailedEventErrorCode))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseInjectFailedEventErrorCode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseInjectFailedEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseInjectFailedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseLogProb))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseLogProb(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseLogProbTopLogprob))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseLogProbTopLogprob(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseMCPCallArgumentsDeltaEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseMCPCallArgumentsDeltaEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseMCPCallArgumentsDoneEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseMCPCallArgumentsDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseMCPCallCompletedEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseMCPCallCompletedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseMCPCallFailedEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallFailedEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseMCPCallFailedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseMCPCallInProgressEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseMCPCallInProgressEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseMCPListToolsCompletedEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseMCPListToolsCompletedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseMCPListToolsFailedEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseMCPListToolsFailedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseMCPListToolsInProgressEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseMCPListToolsInProgressEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseOutputItemAddedEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseOutputItemAddedEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseOutputItemAddedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseOutputItemDoneEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseOutputItemDoneEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseOutputItemDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseOutputTextAnnotationAddedEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseOutputTextAnnotationAddedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsePromptCacheOptionsParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsePromptCacheOptionsParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseProperties))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseProperties(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseQueuedEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseQueuedEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseQueuedEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseQueuedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseReasoningSummaryPartAddedEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEventPart))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseReasoningSummaryPartAddedEventPart(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEventPartType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseReasoningSummaryPartAddedEventPartType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseReasoningSummaryPartAddedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseReasoningSummaryPartDoneEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventPart))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseReasoningSummaryPartDoneEventPart(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventPartType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseReasoningSummaryPartDoneEventPartType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseReasoningSummaryPartDoneEventStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseReasoningSummaryPartDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseReasoningSummaryTextDeltaEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseReasoningSummaryTextDeltaEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseReasoningSummaryTextDoneEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseReasoningSummaryTextDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseReasoningTextDeltaEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseReasoningTextDeltaEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseReasoningTextDoneEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseReasoningTextDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseRefusalDeltaEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseRefusalDeltaEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseRefusalDeltaEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseRefusalDoneEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseRefusalDoneEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseRefusalDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseShellCallCommandAddedStreamingEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseShellCallCommandAddedStreamingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseShellCallCommandDeltaStreamingEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseShellCallCommandDeltaStreamingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseShellCallCommandDoneStreamingEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseShellCallCommandDoneStreamingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseShellCallOutputContentDeltaStreamingEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseShellCallOutputContentDeltaStreamingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseShellCallOutputContentDoneStreamingEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseShellCallOutputContentDoneStreamingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerAcceptedEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseSteerAcceptedEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerAcceptedEventSteer))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseSteerAcceptedEventSteer(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerAcceptedEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseSteerAcceptedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerErrorCode))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseSteerErrorCode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerErrorCodeEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseSteerErrorCodeEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseSteerEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseSteerEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerFailedEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseSteerFailedEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerFailedEventError))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseSteerFailedEventError(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerFailedEventErrorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseSteerFailedEventErrorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerFailedEventSteer))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseSteerFailedEventSteer(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerFailedEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseSteerFailedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerInput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseSteerInput2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerInputItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseSteerInputItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerInputItemDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseSteerInputItemDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerInputItemDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseSteerInputItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerPendingEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseSteerPendingEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerPendingEventSteer))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseSteerPendingEventSteer(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerPendingEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseSteerPendingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerPendingReason))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseSteerPendingReason2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerPendingReasonEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseSteerPendingReasonEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseSteerRequiredInput2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseSteerRequiredInputDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseSteerRequiredInputDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutputType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredComputerToolCallOutput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseSteerRequiredInputRequiredComputerToolCallOutput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredComputerToolCallOutputType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseSteerRequiredInputRequiredComputerToolCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredCustomToolCallOutput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseSteerRequiredInputRequiredCustomToolCallOutput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredCustomToolCallOutputType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseSteerRequiredInputRequiredCustomToolCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredFunctionToolCallOutput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseSteerRequiredInputRequiredFunctionToolCallOutput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredFunctionToolCallOutputType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseSteerRequiredInputRequiredFunctionToolCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredMcpApprovalResponse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseSteerRequiredInputRequiredMcpApprovalResponse(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredMcpApprovalResponseType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseSteerRequiredInputRequiredMcpApprovalResponseType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredShellToolCallOutput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseSteerRequiredInputRequiredShellToolCallOutput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredShellToolCallOutputType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseSteerRequiredInputRequiredShellToolCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseSteerRequiredInputRequiredToolSearchOutput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutputExecution))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseSteerRequiredInputRequiredToolSearchOutputExecution2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutputType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseSteerRequiredInputRequiredToolSearchOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseStreamOptionsVariant1))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseStreamOptionsVariant1(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseTextDeltaEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseTextDeltaEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseTextDeltaEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseTextDeltaEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseTextDoneEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseTextDoneEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseTextDoneEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseTextDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseTextParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseTextParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseUsage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseUsage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseUsageInputTokensDetails))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseUsageInputTokensDetails(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseUsageOutputTokensDetails))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseUsageOutputTokensDetails(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseVariant3))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseVariant3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseVariant3IncompleteDetails))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseVariant3IncompleteDetails(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseVariant3IncompleteDetailsReason))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseVariant3IncompleteDetailsReason2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseVariant3Object))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseVariant3Object2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseVariant3Status))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseVariant3Status2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseVariant3Truncation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseVariant3Truncation2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseWebSearchCallCompletedEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseWebSearchCallCompletedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseWebSearchCallInProgressEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseWebSearchCallInProgressEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseWebSearchCallSearchingEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseWebSearchCallSearchingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseWsError))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseWsError(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseWsErrorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponseWsErrorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesClientEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesClientEvent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesClientEventDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesClientEventDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesClientEventDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesClientEventDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreate))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesClientEventResponseCreate2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreateVariant1))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesClientEventResponseCreateVariant1(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreateVariant1Type))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesClientEventResponseCreateVariant1Type2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEvent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDelta2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseAudioTranscriptWsDelta2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDone2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseAudioTranscriptWsDone2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDelta2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseAudioWsDelta2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDone2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseAudioWsDone2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDelta2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDelta2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDone2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDone2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallInWsProgress2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseCodeInterpreterCallInWsProgress2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsCompleted2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseCodeInterpreterCallWsCompleted2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsInterpreting2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseCodeInterpreterCallWsInterpreting2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCompactionWsCompacting2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseCompactionWsCompacting2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsAdded2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseContentPartWsAdded2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsDone2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseContentPartWsDone2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDelta2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseCustomToolCallInputWsDelta2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDone2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseCustomToolCallInputWsDone2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallInWsProgress2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseFileSearchCallInWsProgress2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsCompleted2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseFileSearchCallWsCompleted2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsSearching2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseFileSearchCallWsSearching2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDelta2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDelta2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallInWsProgress2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseImageGenCallInWsProgress2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallPartialWsImage2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseImageGenCallPartialWsImage2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsCompleted2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseImageGenCallWsCompleted2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsGenerating2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseImageGenCallWsGenerating2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseInWsProgress2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseInWsProgress2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDelta2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDelta2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDone2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDone2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallInWsProgress2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseMcpCallInWsProgress2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsCompleted2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseMcpCallWsCompleted2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsFailed2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseMcpCallWsFailed2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsInWsProgress2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseMcpListToolsInWsProgress2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsCompleted2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseMcpListToolsWsCompleted2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsFailed2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseMcpListToolsWsFailed2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsAdded2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseOutputItemWsAdded2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsDone2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseOutputItemWsDone2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputTextAnnotationWsAdded2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseOutputTextAnnotationWsAdded2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsAdded2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseReasoningSummaryPartWsAdded2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsDone2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseReasoningSummaryPartWsDone2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDelta2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDelta2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDone2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDone2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDelta2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseReasoningTextWsDelta2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDone2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseReasoningTextWsDone2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDelta2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseRefusalWsDelta2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDone2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseRefusalWsDone2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsAdded2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseShellCallCommandWsAdded2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDelta2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseShellCallCommandWsDelta2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDone2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseShellCallCommandWsDone2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDelta2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseShellCallOutputContentWsDelta2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDone2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseShellCallOutputContentWsDone2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDelta2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseTextWsDelta2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDone2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseTextWsDone2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallInWsProgress2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseWebSearchCallInWsProgress2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsCompleted2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseWebSearchCallWsCompleted2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsSearching2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseWebSearchCallWsSearching2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCompleted2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseWsCompleted2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCreated2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseWsCreated2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsFailed2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseWsFailed2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsIncomplete2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseWsIncomplete2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsQueued2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventBetaResponseWsQueued2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaResponsesServerEventDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaScreenshotParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaScreenshotParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaScreenshotParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaScreenshotParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaScrollParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaScrollParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaScrollParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaScrollParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaSearchContentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaSearchContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaSearchContextSize))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaSearchContextSize2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaServiceTierResponsesEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaServiceTierResponsesEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaShellCallOutputDelta))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaShellCallOutputDelta(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaSkillReferenceParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaSkillReferenceParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaSkillReferenceParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaSkillReferenceParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaSpecificApplyPatchParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaSpecificApplyPatchParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaSpecificApplyPatchParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaSpecificApplyPatchParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaSpecificFunctionShellParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaSpecificFunctionShellParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaSpecificFunctionShellParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaSpecificFunctionShellParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaSpecificProgrammaticToolCallingParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaSpecificProgrammaticToolCallingParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaSummaryTextContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaSummaryTextContent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaSummaryTextContentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaSummaryTextContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaTextContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaTextContent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaTextContentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaTextContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaTextResponseFormatConfiguration))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaTextResponseFormatConfiguration2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchema))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaTextResponseFormatJsonSchema(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchemaType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaTextResponseFormatJsonSchemaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaTool2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolCallCaller))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolCallCaller(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolCallCallerDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolCallCallerDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolCallCallerDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolCallCallerDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolCallCallerParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolCallCallerParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolCallCallerParamDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolCallCallerParamDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolCallCallerParamDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolCallCallerParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolChoiceAllowed))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolChoiceAllowed(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolChoiceAllowedMode))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolChoiceAllowedMode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolChoiceAllowedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolChoiceAllowedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolChoiceCustom))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolChoiceCustom(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolChoiceCustomType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolChoiceCustomType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolChoiceFunction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolChoiceFunction(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolChoiceFunctionType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolChoiceFunctionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolChoiceMCP))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolChoiceMCP(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolChoiceMCPType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolChoiceMCPType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolChoiceOptions))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolChoiceOptions2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolChoiceParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolChoiceParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolChoiceTypes))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolChoiceTypes(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolChoiceTypesType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolChoiceTypesType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolSearchCall))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolSearchCall(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolSearchCallItemParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolSearchCallItemParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolSearchCallItemParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolSearchCallItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolSearchCallType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolSearchCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolSearchExecutionType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolSearchExecutionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolSearchOutput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolSearchOutput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputFunctionToolParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolSearchOutputFunctionToolParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputFunctionToolParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolSearchOutputFunctionToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputItemParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolSearchOutputItemParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputItemParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolSearchOutputItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputNamespaceToolParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolSearchOutputNamespaceToolParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputNamespaceToolParamToolDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolSearchOutputNamespaceToolParamToolDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputNamespaceToolParamToolDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolSearchOutputNamespaceToolParamToolDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputNamespaceToolParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolSearchOutputNamespaceToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolSearchOutputTool2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputToolDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolSearchOutputToolDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputToolDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolSearchOutputToolDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolSearchOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolSearchToolParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolSearchToolParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolSearchToolParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaToolSearchToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaTopLogProb))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaTopLogProb(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaTypeParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaTypeParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaTypeParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaTypeParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaUrlCitationBody))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaUrlCitationBody(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaUrlCitationBodyType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaUrlCitationBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaUrlCitationParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaUrlCitationParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaUrlCitationParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaUrlCitationParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaUserMessageItemParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaUserMessageItemParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaUserMessageItemParamContentVariant1ItemDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaUserMessageItemParamContentVariant1ItemDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaUserMessageItemParamContentVariant1ItemDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaUserMessageItemParamContentVariant1ItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaUserMessageItemParamRole))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaUserMessageItemParamRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaUserMessageItemParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaUserMessageItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaVerbosityEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaVerbosityEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWaitParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaWaitParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWaitParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaWaitParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchActionFind))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaWebSearchActionFind(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchActionFindType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaWebSearchActionFindType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchActionOpenPage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaWebSearchActionOpenPage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchActionOpenPageType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaWebSearchActionOpenPageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchActionSearch))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaWebSearchActionSearch(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchActionSearchSource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaWebSearchActionSearchSource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchActionSearchSourceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaWebSearchActionSearchSourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchActionSearchType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaWebSearchActionSearchType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchApproximateLocationWebSearchApproximateLocation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaWebSearchApproximateLocationWebSearchApproximateLocation(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchApproximateLocationWebSearchApproximateLocationType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaWebSearchApproximateLocationWebSearchApproximateLocationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchCallStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaWebSearchCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchPreviewTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaWebSearchPreviewTool(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchPreviewToolType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaWebSearchPreviewToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaWebSearchTool(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchToolCall))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaWebSearchToolCall(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchToolCallAction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaWebSearchToolCallAction2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchToolCallActionDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaWebSearchToolCallActionDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchToolCallActionDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaWebSearchToolCallActionDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchToolCallType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaWebSearchToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchToolFilters))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaWebSearchToolFilters(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchToolSearchContextSize))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaWebSearchToolSearchContextSize2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchToolType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaWebSearchToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContentItem6))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_ContentItem62(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContentItem7))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_ContentItem72(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContentVariant1Item2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_ContentVariant1Item22(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentVariant15))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_EnvironmentVariant15(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentVariant16))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_EnvironmentVariant16(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentVariant17))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_EnvironmentVariant17(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FiltersItem2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_FiltersItem22(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Format3))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_Format32(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Input5))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_Input52(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.NetworkPolicy4))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NetworkPolicy42(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.NetworkPolicy5))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NetworkPolicy52(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant1Item2>, string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_A76B4D078E30C14E(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<string>, global::tryAGI.OpenAI.BetaMCPToolFilter>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_7158C76B7E4EE28D(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum, global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum2?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_70F91A4647BF4C91(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_33CE3604D32F85AE(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, double?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_569B880384C23575(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutput>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_6D1B5BDB3BF79946(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputContent>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_4B0D5D5EA94A21CF(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputItem>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_635A9AD4B4EE8F6F(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item2>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_414E704B5707CE5A(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_F891446D11C80FC4(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Operation2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_Operation22(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Outcome2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_Outcome22(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Output9))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_Output92(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputVariant2Item2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_OutputVariant2Item22(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputsVariant1Item2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_OutputsVariant1Item22(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SkillsItem3))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SkillsItem32(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolsItem18))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_ToolsItem182(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolsItem19))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_ToolsItem192(options);
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
                if (type == typeof(float?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableSingle(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDelta2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_809A6DBB6F30F9C9(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDone2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_0323BFB3BAD5860F(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDelta2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_4068A088EDB2D48C(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDone2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_437E09D473EF1445(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDelta2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_01BBB717D8929B9C(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDone2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_7D131A5A12849301(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsCompleted2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_6D3E506078634FFA(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallInWsProgress2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_6483087DB4649614(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsInterpreting2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_B71FEB22D338B1E1(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCompactionWsCompacting2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_2F9F8E7160FC8D89(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCompleted2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_47560533D1D53471(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsAdded2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_4F2E3A9C50830981(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsDone2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_1E1451FB93EF399F(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCreatedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCreated2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_C3594C50ED5FDD63(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDelta2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_C050C5D04A6BD1A3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDone2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_5CA1B0B032384E8E(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsFailed2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_45A24C979941A6EB(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsCompleted2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_33C14A17F11AB2E0(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallInWsProgress2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_B407BDBC5499F6C9(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsSearching2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_E858989C14959DBF(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDelta2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_DE5C1E599D53D00D(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_46D1764526CB3496(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsCompleted2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_C56C7FD38FBB034D(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsGenerating2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_13C4A6A81342A6C0(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallInWsProgress2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_9CCA62DCA455D8DB(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallPartialWsImage2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_3CF470FC07D490C3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseInWsProgress2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_33B44C9DCE74E9B0(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseIncompleteEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsIncomplete2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_14DD50AC6D9011C1(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDelta2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_12A8D0D770D85C7E(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDone2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_82B4E318AB1B272B(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsCompleted2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_8F9A77BAAE641C5F(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsFailed2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_6D3C2E217078B5DB(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallInWsProgress2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_C88E72298AC48DA9(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsCompleted2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_6A7034017341CC2A(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsFailed2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_5F1ABCEB4C9A839D(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsInWsProgress2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_5BF06C6FFE17561C(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsAdded2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_BDFD6CB2C74168A1(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsDone2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_8FBE527BCD280935(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputTextAnnotationWsAdded2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_E8A751C5A17CCC09(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseQueuedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsQueued2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_E381353A21D9D42D(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsAdded2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_956C052CC7FE6401(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsDone2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_43219765FAE2A934(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDelta2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_E5C2687DB993C2DF(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDone2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_F46F58508B8E6D20(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDelta2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_19456EAFED948B5D(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDone2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_9662200A9A7285C9(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDelta2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_7E5246D14A3946CB(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDone2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_7571A4B3F9433ECB(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsAdded2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_80A9B29287617226(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDelta2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_7927AB624CDDAFE0(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDone2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_D68996370207B56F(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDelta2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_078D959017EE1A64(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDone2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_1EDAC5B5C3E36B2F(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDelta2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_8B59853585A2BEB3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDone2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_82CF19723F115192(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsCompleted2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_B247B30F41F11A45(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallInWsProgress2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_8A6FC8F18CA0478F(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsSearching2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_EF124700B3C6D463(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnnotationsItem4?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableAnnotationsItem42(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.BetaImageGenToolModel?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_69552AA6DD483460(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.BetaImageGenToolSize?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_7D0057FCBF1FF89F(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAdditionalToolsItemParamRole?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaAdditionalToolsItemParamRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAdditionalToolsItemParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaAdditionalToolsItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAdditionalToolsType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaAdditionalToolsType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAgentMessageContentItemDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaAgentMessageContentItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAgentMessageItemParamContentItemDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaAgentMessageItemParamContentItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAgentMessageItemParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaAgentMessageItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAgentMessageType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaAgentMessageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAnnotationDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaAnnotationDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchCallOutputStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaApplyPatchCallOutputStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchCallOutputStatusParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaApplyPatchCallOutputStatusParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchCallStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaApplyPatchCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchCallStatusParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaApplyPatchCallStatusParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaApplyPatchCreateFileOperationParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaApplyPatchCreateFileOperationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaApplyPatchDeleteFileOperationParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaApplyPatchDeleteFileOperationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchOperationParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaApplyPatchOperationParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchOperationParamDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaApplyPatchOperationParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallItemParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaApplyPatchToolCallItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOperationDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaApplyPatchToolCallOperationDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputItemParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaApplyPatchToolCallOutputItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaApplyPatchToolCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaApplyPatchToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaApplyPatchToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaApplyPatchUpdateFileOperationParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaApplyPatchUpdateFileOperationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaApproximateLocationType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaApproximateLocationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaAutoCodeInterpreterToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCacheMissReasonTypeEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaCacheMissReasonTypeEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCallableToolAllowedCaller?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaCallableToolAllowedCaller2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaClickButtonType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaClickButtonType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaClickParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaClickParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterOutputImageType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaCodeInterpreterOutputImageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogsType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaCodeInterpreterOutputLogsType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolCallStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaCodeInterpreterToolCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolCallType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaCodeInterpreterToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaCodeInterpreterToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCompactionBodyType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaCompactionBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCompactionSummaryItemParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaCompactionSummaryItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCompactionTriggerItemParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaCompactionTriggerItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComparisonFilterType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaComparisonFilterType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCompoundFilterType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaCompoundFilterType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerAction?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaComputerAction2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerActionDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaComputerActionDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerCallOutputItemParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaComputerCallOutputItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerCallOutputStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaComputerCallOutputStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerEnvironment?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaComputerEnvironment2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerScreenshotContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaComputerScreenshotContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerScreenshotImageType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaComputerScreenshotImageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerToolCallOutputResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaComputerToolCallOutputResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerToolCallOutputStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaComputerToolCallOutputStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerToolCallOutputType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaComputerToolCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerToolCallStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaComputerToolCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerToolCallType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaComputerToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerToolType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaComputerToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerUsePreviewToolType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaComputerUsePreviewToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamNetworkPolicyDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaContainerAutoParamNetworkPolicyDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamSkillDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaContainerAutoParamSkillDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaContainerAutoParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerFileCitationBodyType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaContainerFileCitationBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerFileCitationParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaContainerFileCitationParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerMemoryLimit?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaContainerMemoryLimit2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaContainerNetworkPolicyAllowlistParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaContainerNetworkPolicyDisabledParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerReferenceParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaContainerReferenceParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerReferenceResourceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaContainerReferenceResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCreateModelResponseProperties?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaCreateModelResponseProperties2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCreateResponse?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaCreateResponse2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.BetaCreateResponseVariant3Truncation?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaCreateResponseVariant3Truncation2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::tryAGI.OpenAI.BetaCustomGrammarFormatParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaCustomGrammarFormatParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCustomTextFormatParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaCustomTextFormatParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCustomToolCallOutputResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaCustomToolCallOutputResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCustomToolCallOutputType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaCustomToolCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCustomToolCallType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaCustomToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCustomToolParamFormatDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaCustomToolParamFormatDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCustomToolParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaCustomToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCyberAccessProgramEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaCyberAccessProgramEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaDetailEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaDetailEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaDirectToolCallCallerParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaDirectToolCallCallerParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaDirectToolCallCallerType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaDirectToolCallCallerType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaDoubleClickActionType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaDoubleClickActionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaDragParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaDragParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaEasyInputMessageRole?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaEasyInputMessageRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaEasyInputMessageType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaEasyInputMessageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaEncryptedContentParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaEncryptedContentParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaEncryptedContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaEncryptedContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFileCitationBodyType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFileCitationBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFileCitationParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFileCitationParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFileDetailEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFileDetailEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFileInputDetail?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFileInputDetail2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFilePathType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFilePathType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFileSearchToolCallStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFileSearchToolCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFileSearchToolCallType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFileSearchToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFileSearchToolType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFileSearchToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutput?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFunctionAndCustomToolCallOutput2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutputDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFunctionAndCustomToolCallOutputDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionCallItemStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFunctionCallItemStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFunctionCallOutputItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionCallOutputStatusEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFunctionCallOutputStatusEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionCallStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFunctionCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallEnvironmentVariant1DiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFunctionShellCallEnvironmentVariant1DiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallItemParamEnvironmentVariant1DiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFunctionShellCallItemParamEnvironmentVariant1DiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallItemParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFunctionShellCallItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallItemStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFunctionShellCallItemStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentOutcomeDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFunctionShellCallOutputContentOutcomeDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFunctionShellCallOutputExitOutcomeParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFunctionShellCallOutputExitOutcomeType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputItemParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFunctionShellCallOutputItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputOutcomeParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFunctionShellCallOutputOutcomeParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputOutcomeParamDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFunctionShellCallOutputOutcomeParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputStatusEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFunctionShellCallOutputStatusEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFunctionShellCallOutputTimeoutOutcomeParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFunctionShellCallOutputTimeoutOutcomeType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFunctionShellCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFunctionShellCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFunctionShellCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFunctionShellToolParamEnvironmentVariant1DiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFunctionShellToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallOutputResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFunctionToolCallOutputResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallOutputStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFunctionToolCallOutputStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallOutputType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFunctionToolCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFunctionToolCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFunctionToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionToolParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFunctionToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFunctionToolType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFunctionToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaGrammarSyntax1?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaGrammarSyntax12(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaHTTPErrorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaHTTPErrorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageBackground?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaImageBackground2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageDetail?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaImageDetail2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenActionEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaImageGenActionEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolBackground?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaImageGenToolBackground2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallModerationDetailsModerationStage?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaImageGenToolCallModerationDetailsModerationStage2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallQuality?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaImageGenToolCallQuality2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallSizeVariant1?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaImageGenToolCallSizeVariant12(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaImageGenToolCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaImageGenToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolModel?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaImageGenToolModel2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolModeration?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaImageGenToolModeration2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolOutputFormat?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaImageGenToolOutputFormat2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolQuality?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaImageGenToolQuality2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolSize?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaImageGenToolSize2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageGenToolType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaImageGenToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageOutputFormat?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaImageOutputFormat2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaIncludeEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaIncludeEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInlineSkillParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaInlineSkillParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInlineSkillSourceParamMediaType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaInlineSkillSourceParamMediaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInlineSkillSourceParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaInlineSkillSourceParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputContent?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaInputContent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputContentDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaInputContentDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputFidelity?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaInputFidelity2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputFileContentParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaInputFileContentParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputFileContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaInputFileContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputImageContentParamAutoParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaInputImageContentParamAutoParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputImageContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaInputImageContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableBetaInputItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputItemDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaInputItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputMessageRole?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaInputMessageRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputMessageStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaInputMessageStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputMessageType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaInputMessageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaInputParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputTextContentParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaInputTextContentParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputTextContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaInputTextContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaItemDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaItemReferenceParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaItemReferenceParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaKeyPressActionType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaKeyPressActionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaLocalEnvironmentParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaLocalEnvironmentParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaLocalEnvironmentResourceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaLocalEnvironmentResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaLocalShellExecActionType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaLocalShellExecActionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallOutputStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaLocalShellToolCallOutputStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallOutputType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaLocalShellToolCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaLocalShellToolCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaLocalShellToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaLocalShellToolParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaLocalShellToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPApprovalRequestType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaMCPApprovalRequestType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPApprovalResponseResourceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaMCPApprovalResponseResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPApprovalResponseType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaMCPApprovalResponseType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPListToolsType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaMCPListToolsType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPProtocolErrorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaMCPProtocolErrorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPToolCallErrorDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaMCPToolCallErrorDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPToolCallStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaMCPToolCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPToolCallType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaMCPToolCallType2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPToolConnectorId?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaMCPToolConnectorId2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPToolExecutionErrorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaMCPToolExecutionErrorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum2?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaMCPToolRequireApprovalVariant1Enum22(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMCPToolType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaMCPToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMessagePhase?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaMessagePhase2_3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMessageRole?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaMessageRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMisalignmentErrorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaMisalignmentErrorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMisalignmentErrorTypeEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaMisalignmentErrorTypeEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaModelIdsResponses?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaModelIdsResponses2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaModelIdsResponsesEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaModelIdsResponsesEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaModelIdsShared?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaModelIdsShared2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaModelIdsSharedEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaModelIdsSharedEnum2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.BetaModelResponsePropertiesPromptCacheRetention?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaModelResponsePropertiesPromptCacheRetention2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::tryAGI.OpenAI.BetaModerationErrorBodyType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaModerationErrorBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaModerationInputDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaModerationInputDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaModerationInputType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaModerationInputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaModerationMode?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaModerationMode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaModerationOutputDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaModerationOutputDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaModerationResultBodyType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaModerationResultBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMoveParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaMoveParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMultiAgentAction?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaMultiAgentAction2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMultiAgentAction1?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaMultiAgentAction12(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallItemParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaMultiAgentCallItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaMultiAgentCallOutputItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallOutputType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaMultiAgentCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaMultiAgentCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaNamespaceToolParamToolDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaNamespaceToolParamToolDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaNamespaceToolParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaNamespaceToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaOutputContent?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaOutputContent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaOutputContentDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaOutputContentDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaOutputItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaOutputItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaOutputItemDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaOutputItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaOutputMessageContent?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaOutputMessageContent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaOutputMessageContentDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaOutputMessageContentDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaOutputMessageRole?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaOutputMessageRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaOutputMessageStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaOutputMessageStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaOutputMessageType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaOutputMessageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaOutputTextContentParamAnnotationDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaOutputTextContentParamAnnotationDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaOutputTextContentParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaOutputTextContentParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaOutputTextContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaOutputTextContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaProgramItemParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaProgramItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaProgramOutputItemParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaProgramOutputItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaProgramOutputItemStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaProgramOutputItemStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaProgramOutputStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaProgramOutputStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaProgramOutputType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaProgramOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaProgramToolCallCallerParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaProgramToolCallCallerParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaProgramToolCallCallerType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaProgramToolCallCallerType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaProgramType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaProgramType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaProgrammaticToolCallingParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaProgrammaticToolCallingParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaPromptCacheBreakpointConfigMode?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaPromptCacheBreakpointConfigMode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaPromptCacheBreakpointParamMode?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaPromptCacheBreakpointParamMode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBodyType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaPromptCacheComparisonResponseNotFoundDiagnosticsBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaPromptCacheDiagnostics?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaPromptCacheDiagnostics2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaPromptCacheDiagnosticsDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaPromptCacheDiagnosticsDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBodyType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaPromptCacheHitDiagnosticsBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBodyType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaPromptCacheMissDiagnosticsBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaPromptCacheModeEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaPromptCacheModeEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaPromptCacheTTLEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaPromptCacheTTLEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBodyType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaPromptCacheUnavailableDiagnosticsBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaRankerVersionType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaRankerVersionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaReasoningContext?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableBetaReasoningContext2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaReasoningEffortEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableBetaReasoningEffortEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaReasoningGenerateSummary?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableBetaReasoningGenerateSummary2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaReasoningItemStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaReasoningItemStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaReasoningItemType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaReasoningItemType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaReasoningModeEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableBetaReasoningModeEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaReasoningModeEnumEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaReasoningModeEnumEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaReasoningSummary?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableBetaReasoningSummary2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaReasoningTextContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaReasoningTextContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaRefusalContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaRefusalContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponse?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponse2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseAudioDeltaEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseAudioDeltaEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseAudioDoneEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseAudioDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseAudioTranscriptDeltaEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseAudioTranscriptDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseCodeInterpreterCallCodeDeltaEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseCodeInterpreterCallCodeDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseCodeInterpreterCallCompletedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseCodeInterpreterCallInProgressEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseCodeInterpreterCallInterpretingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseCompactionCompactingStreamingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseCompletedEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseCompletedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseConfigurationUpdateItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseContentPartAddedEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseContentPartAddedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseContentPartDoneEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseContentPartDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseCreatedEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseCreatedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseCustomToolCallInputDeltaEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseCustomToolCallInputDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseErrorCode?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseErrorCode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseFailedEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseFailedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseFileSearchCallCompletedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseFileSearchCallInProgressEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseFileSearchCallSearchingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseFormatJsonObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseFormatJsonObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseFormatTextType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseFormatTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseFunctionCallArgumentsDeltaEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseFunctionCallArgumentsDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseImageGenCallCompletedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseImageGenCallGeneratingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseImageGenCallInProgressEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseImageGenCallPartialImageEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseInProgressEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseInProgressEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseIncompleteEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseIncompleteEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseInjectCreatedEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseInjectCreatedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseInjectEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseInjectEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseInjectFailedEventErrorCode?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseInjectFailedEventErrorCode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseInjectFailedEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseInjectFailedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseMCPCallArgumentsDeltaEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseMCPCallArgumentsDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseMCPCallCompletedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallFailedEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseMCPCallFailedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseMCPCallInProgressEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseMCPListToolsCompletedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseMCPListToolsFailedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseMCPListToolsInProgressEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseOutputItemAddedEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseOutputItemAddedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseOutputItemDoneEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseOutputItemDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseOutputTextAnnotationAddedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseQueuedEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseQueuedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEventPartType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseReasoningSummaryPartAddedEventPartType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseReasoningSummaryPartAddedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventPartType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseReasoningSummaryPartDoneEventPartType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseReasoningSummaryPartDoneEventStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseReasoningSummaryPartDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseReasoningSummaryTextDeltaEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseReasoningSummaryTextDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseReasoningTextDeltaEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseReasoningTextDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseRefusalDeltaEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseRefusalDeltaEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseRefusalDoneEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseRefusalDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseShellCallCommandAddedStreamingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseShellCallCommandDeltaStreamingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseShellCallCommandDoneStreamingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseShellCallOutputContentDeltaStreamingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseShellCallOutputContentDoneStreamingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerAcceptedEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseSteerAcceptedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerErrorCode?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseSteerErrorCode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerErrorCodeEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseSteerErrorCodeEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseSteerEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerFailedEventErrorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseSteerFailedEventErrorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerFailedEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseSteerFailedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerInput?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseSteerInput2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerInputItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseSteerInputItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerInputItemDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseSteerInputItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerPendingEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseSteerPendingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerPendingReason?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseSteerPendingReason2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerPendingReasonEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseSteerPendingReasonEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInput?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseSteerRequiredInput2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseSteerRequiredInputDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutputType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredComputerToolCallOutputType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseSteerRequiredInputRequiredComputerToolCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredCustomToolCallOutputType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseSteerRequiredInputRequiredCustomToolCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredFunctionToolCallOutputType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseSteerRequiredInputRequiredFunctionToolCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredMcpApprovalResponseType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseSteerRequiredInputRequiredMcpApprovalResponseType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredShellToolCallOutputType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseSteerRequiredInputRequiredShellToolCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutputExecution?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseSteerRequiredInputRequiredToolSearchOutputExecution2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutputType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseSteerRequiredInputRequiredToolSearchOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseTextDeltaEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseTextDeltaEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseTextDoneEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseTextDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseVariant3IncompleteDetailsReason?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseVariant3IncompleteDetailsReason2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseVariant3Object?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseVariant3Object2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseVariant3Status?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseVariant3Status2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseVariant3Truncation?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseVariant3Truncation2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseWebSearchCallCompletedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseWebSearchCallInProgressEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseWebSearchCallSearchingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseWsErrorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponseWsErrorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesClientEvent?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponsesClientEvent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesClientEventDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponsesClientEventDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreate?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponsesClientEventResponseCreate2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreateVariant1Type?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponsesClientEventResponseCreateVariant1Type2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEvent?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponsesServerEvent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponsesServerEventDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaResponsesServerEventDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaScreenshotParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaScreenshotParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaScrollParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaScrollParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaSearchContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaSearchContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaSearchContextSize?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaSearchContextSize2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaServiceTierResponsesEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaServiceTierResponsesEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaSkillReferenceParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaSkillReferenceParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaSpecificApplyPatchParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableBetaSpecificApplyPatchParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaSpecificFunctionShellParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableBetaSpecificFunctionShellParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableBetaSpecificProgrammaticToolCallingParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaSummaryTextContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaSummaryTextContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaTextContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaTextContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaTextResponseFormatConfiguration?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaTextResponseFormatConfiguration2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchemaType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaTextResponseFormatJsonSchemaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaTool?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableBetaTool2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolCallCallerDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaToolCallCallerDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolCallCallerParamDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaToolCallCallerParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolChoiceAllowedMode?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableBetaToolChoiceAllowedMode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolChoiceAllowedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableBetaToolChoiceAllowedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolChoiceCustomType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableBetaToolChoiceCustomType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolChoiceFunctionType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableBetaToolChoiceFunctionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolChoiceMCPType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableBetaToolChoiceMCPType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolChoiceOptions?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableBetaToolChoiceOptions2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolChoiceTypesType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableBetaToolChoiceTypesType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaToolDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolSearchCallItemParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaToolSearchCallItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolSearchCallType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaToolSearchCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolSearchExecutionType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaToolSearchExecutionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputFunctionToolParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaToolSearchOutputFunctionToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputItemParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaToolSearchOutputItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputNamespaceToolParamToolDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaToolSearchOutputNamespaceToolParamToolDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputNamespaceToolParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaToolSearchOutputNamespaceToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputTool?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaToolSearchOutputTool2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputToolDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaToolSearchOutputToolDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaToolSearchOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolSearchToolParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaToolSearchToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaTypeParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaTypeParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaUrlCitationBodyType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaUrlCitationBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaUrlCitationParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaUrlCitationParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaUserMessageItemParamContentVariant1ItemDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaUserMessageItemParamContentVariant1ItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaUserMessageItemParamRole?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaUserMessageItemParamRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaUserMessageItemParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaUserMessageItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaVerbosityEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaVerbosityEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWaitParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaWaitParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchActionFindType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaWebSearchActionFindType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchActionOpenPageType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaWebSearchActionOpenPageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchActionSearchSourceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaWebSearchActionSearchSourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchActionSearchType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaWebSearchActionSearchType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchApproximateLocationWebSearchApproximateLocationType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaWebSearchApproximateLocationWebSearchApproximateLocationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchCallStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaWebSearchCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchPreviewToolType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaWebSearchPreviewToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchToolCallAction?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaWebSearchToolCallAction2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchToolCallActionDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaWebSearchToolCallActionDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchToolCallType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaWebSearchToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchToolSearchContextSize?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaWebSearchToolSearchContextSize2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaWebSearchToolType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaWebSearchToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContentItem6?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableContentItem62(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContentItem7?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableContentItem72(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContentVariant1Item2?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableContentVariant1Item22(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FiltersItem2?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableFiltersItem22(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Format3?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableFormat32(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Input5?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableInput52(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.NetworkPolicy4?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableNetworkPolicy42(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.NetworkPolicy5?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableNetworkPolicy52(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant1Item2>, string>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_03CCB6AA8AF82537(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_01848C29385428F2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, double?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_528BFF85AF3E2294(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutput>>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_25ED6167D89F8165(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputContent>>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_3714EE7D75548939(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item2>>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_E5B26BDD7B1F1BCD(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParam>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_BC31F48C4D4D6F8C(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Operation2?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableOperation22(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Outcome2?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableOutcome22(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Output9?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableOutput92(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputVariant2Item2?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableOutputVariant2Item22(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputsVariant1Item2?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableOutputsVariant1Item22(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SkillsItem3?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableSkillsItem32(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolsItem18?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableToolsItem182(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolsItem19?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableToolsItem192(options);
                }
                if (type == typeof(int?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaModerationInputType>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_170E0CBF8B38E6FD(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.AnnotationsItem4>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_BF0E29777C39F972(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaAnnotation>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_FC86392F3B26F72B(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaCallableToolAllowedCaller>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_6B927CB1EA97EDA8(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaComputerAction>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_6FE62D15834DE935(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaComputerCallSafetyCheckParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_A71D7C3FFEA3AE1F(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaContainerNetworkPolicyDomainSecretParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_D1BCB1597AD6A845(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaContextManagementParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_9F49DBFB095FA59D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaCoordParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_AAF4D3C452705FD6(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaFileSearchToolCallResultsVariant1Item>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_56D49F7484FB7DB7(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutput>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_DB1F2D2405884033(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaFunctionShellCallOutputContent>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_70BB2B18D4D9F87B(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_718EE663A731CBE9(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaIncludeEnum>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_ED8075A28B92927C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaInputContent>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_A5341A47B9272091(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaInputItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_ACBF9E486B2E2B45(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaLocalSkillParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_71B03C1937496CFF(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaLogProb>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_35D765866FD83CC4(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaMCPListToolsTool>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_950A162069AA47C8(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaOutputItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_3ECDDB9221A2C84C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaOutputMessageContent>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_C55D517A2F531110(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaOutputTextContent>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_C385920D6AAC2BF6(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaOutputTextContentParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_114654B191CDFE86(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaReasoningTextContent>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_C2BB7ADC42B116B3(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaResponseLogProb>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_4A22E33B88B561B9(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaResponseLogProbTopLogprob>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_0FA946A99A5EF80B(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaResponseSteerInputItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_7E32602BA1223058(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaResponseSteerRequiredInput>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_A340D96C4EEA858A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaSearchContentType>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_E3D78B09BB121678(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaSummaryTextContent>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_91E05EA18B72824E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaTool>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_F50A81EFA7CA3AAE(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaToolSearchOutputTool>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_6F936E79CCA88294(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaTopLogProb>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_8286E5F200E2BCE7(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaWebSearchActionSearchSource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_102E682B4C407A63(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentItem6>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_25EC9E9FA7360A33(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentItem7>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_191EB91C785C52D0(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentVariant1Item2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_1D40687DF04E8D73(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.FiltersItem2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_ABF2149A5D315966(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<string, double?>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_E3941FEAF2607AE9(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputVariant2Item2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_BA7C2017DACB1010(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputsVariant1Item2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_AF3FC0159F5803E4(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.SkillsItem3>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_0A38409D7E2D219A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ToolsItem18>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_3F8D5F0D02B3DA77(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ToolsItem19>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_F169D9ED442B6A98(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<long>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_2BCC53E1C7DA84DD(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_3F34DBFD50DE05D2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentVariant1Item2>, string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_D03756B78CF1F1CF(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.List<string>, global::tryAGI.OpenAI.BetaMCPToolFilter>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_71AA2D78283B8378(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, double?, bool?, global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<string, double?>>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_C8EB3E0743925723(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutput>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_64C643A991861525(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaInputContent>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_7036CC8C122A0666(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaInputItem>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_BA0478FC8A7D99C6(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputVariant2Item2>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_2762AC723EF31498(options);
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