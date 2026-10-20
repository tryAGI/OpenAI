
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextOrphans_E8B29B5E6F73FE77 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextOrphans_E8B29B5E6F73FE77 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextOrphans_E8B29B5E6F73FE77(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OutputsVariant1ItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.FiltersItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ComputerActionJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ComputerToolCallOutputResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ConversationParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.CreateModelResponsePropertiesJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.CreateResponseJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.CustomToolCallOutputResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.FunctionAndCustomToolCallOutputJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.FunctionToolCallOutputResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.InputContentJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.InputItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.InputParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.MCPToolCallErrorJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ModelIdsResponsesJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ModelIdsSharedJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OutputContentJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OutputItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OutputMessageContentJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ResponseJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ResponseSteerErrorCodeJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ResponseSteerInputJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ResponseSteerInputItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ResponseSteerPendingReasonJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ResponseSteerRequiredInputJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ResponsesClientEventJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ResponsesClientEventResponseCreateJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ResponsesServerEventJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.TextResponseFormatConfigurationJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ToolJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ToolChoiceParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ToolSearchOutputToolJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.WebSearchToolCallActionJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.MisalignmentErrorTypeJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnnotationJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ToolCallCallerJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ToolCallCallerParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.Filters2JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.NetworkPolicy2JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.NetworkPolicy3JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.SkillsItem2JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.EnvironmentVariant1JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.Format2JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ToolsItem13JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.EnvironmentVariant12JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OutcomeJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OperationJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OutputVariant2ItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ToolsItem14JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.EnvironmentVariant13JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputOutcomeParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ApplyPatchOperationParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ReasoningModeEnumJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.PromptCacheDiagnosticsJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.Input4JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.Output5JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ContentVariant1ItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::tryAGI.OpenAI.AutoCodeInterpreterToolParam>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContent>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.ImageGenToolModel?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.ImageGenToolSize?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, global::tryAGI.OpenAI.MCPToolFilter>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum, global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseAudioDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDelta2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseAudioDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDone2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDelta2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDone2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDelta2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDone2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsCompleted2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallInWsProgress2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsInterpreting2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCompactionWsCompacting2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCompleted2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseContentPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsAdded2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseContentPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsDone2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseCreatedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCreated2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsCompleted2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallInWsProgress2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsSearching2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDelta2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsAdded2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDelta2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDone2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDelta2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDone2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseInWsProgress2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsFailed2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseIncompleteEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsIncomplete2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsAdded2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsDone2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsAdded2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsDone2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDelta2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDone2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDelta2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDone2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDelta2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseRefusalDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDone2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDelta2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDone2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsCompleted2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallInWsProgress2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsSearching2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsCompleted2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsGenerating2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallInWsProgress2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDelta2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDone2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsCompleted2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsFailed2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallInWsProgress2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsCompleted2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsFailed2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsInWsProgress2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputTextAnnotationWsAdded2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseQueuedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsQueued2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDelta2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDone2>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.ImageGenToolCallSizeVariant1?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant1Item>, string>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?>());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComparisonFilterType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComparisonFilterType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CompoundFilterType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CompoundFilterType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerActionDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerActionDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerScreenshotImageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerScreenshotImageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerToolCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerToolCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerToolCallOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerToolCallOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerToolCallOutputStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerToolCallOutputStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateResponseVariant3Truncation)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateResponseVariant3Truncation?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolCallOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolCallOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EasyInputMessageRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EasyInputMessageRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EasyInputMessageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EasyInputMessageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FilePathType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FilePathType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchToolCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchToolCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionAndCustomToolCallOutputDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionAndCustomToolCallOutputDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolCallOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolCallOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolCallOutputStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolCallOutputStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolModel)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolModel?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolQuality)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolQuality?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolSize)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolSize?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolOutputFormat)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolOutputFormat?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolModeration)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolModeration?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolBackground)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolBackground?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputContentDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputContentDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputItemDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputItemDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ItemDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellToolCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellToolCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellToolCallOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellToolCallOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellToolCallOutputStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellToolCallOutputStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPApprovalRequestType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPApprovalRequestType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPApprovalResponseType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPApprovalResponseType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPApprovalResponseResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPApprovalResponseResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPListToolsType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPListToolsType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolConnectorId)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolConnectorId?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolCallErrorDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolCallErrorDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessagePhase)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessagePhase?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModelIdsResponsesEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModelIdsResponsesEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModelIdsSharedEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModelIdsSharedEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModelResponsePropertiesPromptCacheRetention)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModelResponsePropertiesPromptCacheRetention?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputContentDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputContentDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputItemDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputItemDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputMessageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputMessageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputMessageRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputMessageRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputMessageStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputMessageStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputMessageContentDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputMessageContentDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningSummary)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningSummary?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningContext)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningContext?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningGenerateSummary)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningGenerateSummary?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningItemType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningItemType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningItemStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningItemStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseVariant3Truncation)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseVariant3Truncation?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseVariant3Object)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseVariant3Object?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseVariant3Status)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseVariant3Status?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseVariant3IncompleteDetailsReason)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseVariant3IncompleteDetailsReason?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseAudioDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseAudioDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseAudioDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseAudioDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCompletedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCompletedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseContentPartAddedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseContentPartAddedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseContentPartDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseContentPartDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCreatedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCreatedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseErrorCode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseErrorCode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFailedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFailedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatTextType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatTextType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseImageGenCallCompletedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseImageGenCallCompletedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseImageGenCallInProgressEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseImageGenCallInProgressEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseInProgressEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseInProgressEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseIncompleteEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseIncompleteEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPCallCompletedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPCallCompletedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPCallFailedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPCallFailedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPCallInProgressEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPCallInProgressEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPListToolsFailedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPListToolsFailedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseOutputItemAddedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseOutputItemAddedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseOutputItemDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseOutputItemDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseQueuedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseQueuedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventPartType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventPartType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventPartType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventPartType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningTextDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningTextDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningTextDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningTextDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseRefusalDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseRefusalDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseRefusalDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseRefusalDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerAcceptedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerAcceptedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerErrorCodeEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerErrorCodeEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerFailedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerFailedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerFailedEventErrorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerFailedEventErrorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerInputItemDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerInputItemDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerPendingEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerPendingEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerPendingReasonEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerPendingReasonEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredFunctionToolCallOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredFunctionToolCallOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredCustomToolCallOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredCustomToolCallOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredComputerToolCallOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredComputerToolCallOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredShellToolCallOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredShellToolCallOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredApplyPatchToolCallOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredApplyPatchToolCallOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutputExecution)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutputExecution?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredMcpApprovalResponseType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredMcpApprovalResponseType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseTextDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseTextDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseTextDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseTextDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseWsErrorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseWsErrorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponsesClientEventDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponsesClientEventDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1Type)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1Type?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponsesServerEventDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponsesServerEventDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ServiceTierResponsesEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ServiceTierResponsesEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TextResponseFormatJsonSchemaType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TextResponseFormatJsonSchemaType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceAllowedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceAllowedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceAllowedMode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceAllowedMode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceCustomType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceCustomType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceFunctionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceFunctionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceMCPType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceMCPType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceOptions)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceOptions?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceTypesType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceTypesType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchOutputToolDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchOutputToolDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VerbosityEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VerbosityEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionFindType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionFindType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionOpenPageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionOpenPageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionSearchType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionSearchType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionSearchSourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionSearchSourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchApproximateLocationWebSearchApproximateLocation1Type)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchApproximateLocationWebSearchApproximateLocation1Type?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchToolSearchContextSize)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchToolSearchContextSize?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchToolCallActionDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchToolCallActionDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModerationInputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModerationInputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModerationResultBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModerationResultBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheTTLEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheTTLEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheModeEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheModeEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParamMode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParamMode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModerationMode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModerationMode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SkillReferenceParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SkillReferenceParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InlineSkillSourceParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InlineSkillSourceParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InlineSkillSourceParamMediaType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InlineSkillSourceParamMediaType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InlineSkillParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InlineSkillParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.IncludeEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.IncludeEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputTextContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputTextContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileCitationBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileCitationBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UrlCitationBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UrlCitationBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerFileCitationBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerFileCitationBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AnnotationDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AnnotationDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputTextContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputTextContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SummaryTextContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SummaryTextContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningTextContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningTextContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RefusalContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RefusalContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageDetail)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageDetail?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputImageContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputImageContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileInputDetail)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileInputDetail?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputFileContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputFileContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DirectToolCallCallerType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DirectToolCallCallerType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProgramToolCallCallerType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProgramToolCallCallerType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolCallCallerDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolCallCallerDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DirectToolCallCallerParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DirectToolCallCallerParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProgramToolCallCallerParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProgramToolCallCallerParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolCallCallerParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolCallCallerParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallOutputStatusEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallOutputStatusEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolCallModerationDetailsModerationStage)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolCallModerationDetailsModerationStage?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenActionEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenActionEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageBackground)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageBackground?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageOutputFormat)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageOutputFormat?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolCallSizeVariant1)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolCallSizeVariant1?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolCallQuality)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolCallQuality?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ClickButtonType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ClickButtonType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ClickParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ClickParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DoubleClickActionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DoubleClickActionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DragParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DragParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.KeyPressActionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.KeyPressActionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MoveParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MoveParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ScreenshotParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ScreenshotParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ScrollParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ScrollParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TypeParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TypeParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WaitParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WaitParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerCallOutputStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerCallOutputStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchExecutionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchExecutionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CallableToolAllowedCaller)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CallableToolAllowedCaller?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RankerVersionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RankerVersionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerEnvironment)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerEnvironment?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUsePreviewToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUsePreviewToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerMemoryLimit)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerMemoryLimit?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AutoCodeInterpreterToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AutoCodeInterpreterToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProgrammaticToolCallingParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProgrammaticToolCallingParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputFidelity)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputFidelity?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerAutoParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerAutoParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerAutoParamNetworkPolicyDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerAutoParamNetworkPolicyDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerAutoParamSkillDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerAutoParamSkillDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LocalEnvironmentParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LocalEnvironmentParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerReferenceParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerReferenceParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellToolParamEnvironmentVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellToolParamEnvironmentVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomTextFormatParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomTextFormatParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GrammarSyntax1)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GrammarSyntax1?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomGrammarFormatParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomGrammarFormatParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolParamFormatDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolParamFormatDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.NamespaceToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.NamespaceToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.NamespaceToolParamToolDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.NamespaceToolParamToolDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApproximateLocationType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApproximateLocationType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SearchContextSize)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SearchContextSize?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SearchContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SearchContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchPreviewToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchPreviewToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AdditionalToolsType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AdditionalToolsType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProgramType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProgramType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProgramOutputStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProgramOutputStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProgramOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProgramOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CompactionBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CompactionBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterOutputLogsType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterOutputLogsType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterOutputImageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterOutputImageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellExecActionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellExecActionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LocalEnvironmentResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LocalEnvironmentResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerReferenceResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerReferenceResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallEnvironmentVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallEnvironmentVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputStatusEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputStatusEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputContentOutcomeDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputContentOutcomeDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperationType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperationType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOperationDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOperationDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCallOutputStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCallOutputStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPProtocolErrorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPProtocolErrorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolExecutionErrorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolExecutionErrorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HTTPErrorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HTTPErrorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DetailEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DetailEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallItemStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallItemStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerCallOutputItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerCallOutputItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputTextContentParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputTextContentParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputImageContentParamAutoParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputImageContentParamAutoParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileDetailEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileDetailEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputFileContentParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputFileContentParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallOutputItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallOutputItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchCallItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchCallItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchOutputFunctionToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchOutputFunctionToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchOutputNamespaceToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchOutputNamespaceToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchOutputNamespaceToolParamToolDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchOutputNamespaceToolParamToolDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchOutputItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchOutputItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AdditionalToolsItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AdditionalToolsItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AdditionalToolsItemParamRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AdditionalToolsItemParamRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CompactionSummaryItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CompactionSummaryItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallItemStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallItemStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallItemParamEnvironmentVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallItemParamEnvironmentVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputOutcomeParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputOutcomeParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCallStatusParam)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCallStatusParam?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchOperationParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchOperationParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCallOutputStatusParam)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCallOutputStatusParam?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CompactionTriggerItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CompactionTriggerItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ItemReferenceParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ItemReferenceParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProgramItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProgramItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProgramOutputItemStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProgramOutputItemStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProgramOutputItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProgramOutputItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SpecificProgrammaticToolCallingParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SpecificProgrammaticToolCallingParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SpecificApplyPatchParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SpecificApplyPatchParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SpecificFunctionShellParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SpecificFunctionShellParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CyberAccessProgramEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CyberAccessProgramEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningModeEnumEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningModeEnumEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CacheMissReasonTypeEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CacheMissReasonTypeEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheDiagnosticsDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheDiagnosticsDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModerationErrorBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModerationErrorBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModerationInputDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModerationInputDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModerationOutputDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModerationOutputDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UserMessageItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UserMessageItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UserMessageItemParamRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UserMessageItemParamRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UserMessageItemParamContentVariant1ItemDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UserMessageItemParamContentVariant1ItemDiscriminatorType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CodeInterpreterToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CodeInterpreterToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CodeInterpreterToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CodeInterpreterToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CodeInterpreterToolCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CodeInterpreterToolCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CodeInterpreterToolCallOutputsVariant1ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CodeInterpreterToolCallOutputsVariant1ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComparisonFilterType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComparisonFilterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComparisonFilterType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComparisonFilterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CompoundFilterType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CompoundFilterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CompoundFilterType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CompoundFilterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerActionDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerActionDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerActionDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerActionDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerScreenshotImageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerScreenshotImageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerScreenshotImageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerScreenshotImageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerToolCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerToolCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerToolCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerToolCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerToolCallOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerToolCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerToolCallOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerToolCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerToolCallOutputStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerToolCallOutputStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerToolCallOutputStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerToolCallOutputStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateResponseVariant3Truncation))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateResponseVariant3TruncationJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateResponseVariant3Truncation?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateResponseVariant3TruncationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CustomToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CustomToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolCallOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CustomToolCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolCallOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CustomToolCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EasyInputMessageRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EasyInputMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EasyInputMessageRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EasyInputMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EasyInputMessageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EasyInputMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EasyInputMessageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EasyInputMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FilePathType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FilePathTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FilePathType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FilePathTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileSearchToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileSearchToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchToolCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileSearchToolCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchToolCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileSearchToolCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionAndCustomToolCallOutputDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionAndCustomToolCallOutputDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionAndCustomToolCallOutputDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionAndCustomToolCallOutputDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionToolCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionToolCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolCallOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionToolCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolCallOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionToolCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolCallOutputStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionToolCallOutputStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolCallOutputStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionToolCallOutputStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolModel))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolModelJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolModel?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolQuality))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolQuality?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolSize))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolSize?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolOutputFormat))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolOutputFormat?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolModeration))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolModerationJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolModeration?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolModerationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolBackground))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolBackgroundJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolBackground?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolBackgroundNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputContentDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputContentDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputContentDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputContentDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputItemDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputItemDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputMessageStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputMessageStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ItemDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ItemDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LocalShellToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LocalShellToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellToolCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LocalShellToolCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellToolCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LocalShellToolCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellToolCallOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LocalShellToolCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellToolCallOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LocalShellToolCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellToolCallOutputStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LocalShellToolCallOutputStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellToolCallOutputStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LocalShellToolCallOutputStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPApprovalRequestType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPApprovalRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPApprovalRequestType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPApprovalRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPApprovalResponseType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPApprovalResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPApprovalResponseType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPApprovalResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPApprovalResponseResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPApprovalResponseResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPApprovalResponseResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPApprovalResponseResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPListToolsType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPListToolsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPListToolsType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPListToolsTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolCallErrorDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPToolCallErrorDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolCallErrorDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPToolCallErrorDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessagePhase))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessagePhaseJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessagePhase?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessagePhaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModelIdsResponsesEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModelIdsResponsesEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModelIdsResponsesEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModelIdsResponsesEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModelIdsSharedEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModelIdsSharedEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModelIdsSharedEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModelIdsSharedEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModelResponsePropertiesPromptCacheRetention))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModelResponsePropertiesPromptCacheRetentionJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModelResponsePropertiesPromptCacheRetention?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModelResponsePropertiesPromptCacheRetentionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OutputContentDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OutputContentDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OutputContentDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OutputContentDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OutputItemDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OutputItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OutputItemDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OutputItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OutputMessageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OutputMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OutputMessageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OutputMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OutputMessageRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OutputMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OutputMessageRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OutputMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OutputMessageStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OutputMessageStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OutputMessageStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OutputMessageStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OutputMessageContentDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OutputMessageContentDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OutputMessageContentDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OutputMessageContentDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningSummary))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningSummaryJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningSummary?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningSummaryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningContext))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningContextJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningContext?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningContextNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningGenerateSummary))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningGenerateSummaryJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningGenerateSummary?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningGenerateSummaryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningEffortEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningEffortEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningItemType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningItemType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningItemStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningItemStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseVariant3Truncation))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseVariant3TruncationJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseVariant3Truncation?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseVariant3TruncationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseVariant3Object))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseVariant3ObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseVariant3Object?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseVariant3ObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseVariant3Status))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseVariant3StatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseVariant3Status?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseVariant3StatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseVariant3IncompleteDetailsReason))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseVariant3IncompleteDetailsReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseVariant3IncompleteDetailsReason?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseVariant3IncompleteDetailsReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseAudioDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseAudioDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseAudioDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseAudioDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseAudioDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseAudioDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseAudioDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseAudioDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseAudioTranscriptDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseAudioTranscriptDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseAudioTranscriptDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseAudioTranscriptDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseCodeInterpreterCallCodeDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseCodeInterpreterCallCodeDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseCodeInterpreterCallCodeDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseCodeInterpreterCallCodeDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseCodeInterpreterCallCompletedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseCodeInterpreterCallCompletedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseCodeInterpreterCallInProgressEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseCodeInterpreterCallInProgressEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseCodeInterpreterCallInterpretingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseCodeInterpreterCallInterpretingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCompletedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseCompletedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCompletedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseCompletedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseConfigurationUpdateItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseConfigurationUpdateItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseContentPartAddedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseContentPartAddedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseContentPartAddedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseContentPartAddedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseContentPartDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseContentPartDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseContentPartDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseContentPartDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCreatedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseCreatedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCreatedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseCreatedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseCustomToolCallInputDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseCustomToolCallInputDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseCustomToolCallInputDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseCustomToolCallInputDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseErrorCode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseErrorCode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFailedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFailedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFailedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFailedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFileSearchCallCompletedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFileSearchCallCompletedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFileSearchCallInProgressEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFileSearchCallInProgressEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFileSearchCallSearchingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFileSearchCallSearchingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFormatJsonObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFormatJsonObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatTextType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFormatTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatTextType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFormatTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFunctionCallArgumentsDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFunctionCallArgumentsDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFunctionCallArgumentsDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFunctionCallArgumentsDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseImageGenCallCompletedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseImageGenCallCompletedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseImageGenCallCompletedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseImageGenCallCompletedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseImageGenCallGeneratingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseImageGenCallGeneratingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseImageGenCallInProgressEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseImageGenCallInProgressEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseImageGenCallInProgressEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseImageGenCallInProgressEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseImageGenCallPartialImageEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseImageGenCallPartialImageEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseInProgressEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseInProgressEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseInProgressEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseInProgressEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseIncompleteEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseIncompleteEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseIncompleteEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseIncompleteEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseMCPCallArgumentsDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseMCPCallArgumentsDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseMCPCallArgumentsDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseMCPCallArgumentsDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPCallCompletedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseMCPCallCompletedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPCallCompletedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseMCPCallCompletedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPCallFailedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseMCPCallFailedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPCallFailedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseMCPCallFailedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPCallInProgressEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseMCPCallInProgressEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPCallInProgressEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseMCPCallInProgressEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseMCPListToolsCompletedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseMCPListToolsCompletedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPListToolsFailedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseMCPListToolsFailedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPListToolsFailedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseMCPListToolsFailedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseMCPListToolsInProgressEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseMCPListToolsInProgressEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseOutputItemAddedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseOutputItemAddedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseOutputItemAddedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseOutputItemAddedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseOutputItemDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseOutputItemDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseOutputItemDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseOutputItemDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseOutputTextAnnotationAddedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseOutputTextAnnotationAddedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseQueuedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseQueuedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseQueuedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseQueuedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryPartAddedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryPartAddedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventPartType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryPartAddedEventPartTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventPartType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryPartAddedEventPartTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryPartDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryPartDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryPartDoneEventStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryPartDoneEventStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventPartType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryPartDoneEventPartTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventPartType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryPartDoneEventPartTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryTextDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryTextDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryTextDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryTextDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningTextDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseReasoningTextDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningTextDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseReasoningTextDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningTextDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseReasoningTextDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningTextDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseReasoningTextDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseRefusalDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseRefusalDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseRefusalDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseRefusalDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseRefusalDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseRefusalDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseRefusalDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseRefusalDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerAcceptedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseSteerAcceptedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerAcceptedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseSteerAcceptedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerErrorCodeEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseSteerErrorCodeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerErrorCodeEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseSteerErrorCodeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseSteerEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseSteerEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerFailedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseSteerFailedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerFailedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseSteerFailedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerFailedEventErrorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseSteerFailedEventErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerFailedEventErrorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseSteerFailedEventErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerInputItemDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseSteerInputItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerInputItemDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseSteerInputItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerPendingEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseSteerPendingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerPendingEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseSteerPendingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerPendingReasonEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseSteerPendingReasonEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerPendingReasonEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseSteerPendingReasonEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredFunctionToolCallOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseSteerRequiredInputRequiredFunctionToolCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredFunctionToolCallOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseSteerRequiredInputRequiredFunctionToolCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredCustomToolCallOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseSteerRequiredInputRequiredCustomToolCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredCustomToolCallOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseSteerRequiredInputRequiredCustomToolCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredComputerToolCallOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseSteerRequiredInputRequiredComputerToolCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredComputerToolCallOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseSteerRequiredInputRequiredComputerToolCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredShellToolCallOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseSteerRequiredInputRequiredShellToolCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredShellToolCallOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseSteerRequiredInputRequiredShellToolCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredApplyPatchToolCallOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseSteerRequiredInputRequiredApplyPatchToolCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredApplyPatchToolCallOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseSteerRequiredInputRequiredApplyPatchToolCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseSteerRequiredInputRequiredToolSearchOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseSteerRequiredInputRequiredToolSearchOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutputExecution))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseSteerRequiredInputRequiredToolSearchOutputExecutionJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutputExecution?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseSteerRequiredInputRequiredToolSearchOutputExecutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredMcpApprovalResponseType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseSteerRequiredInputRequiredMcpApprovalResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredMcpApprovalResponseType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseSteerRequiredInputRequiredMcpApprovalResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseSteerRequiredInputDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseSteerRequiredInputDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseTextDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseTextDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseTextDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseTextDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseTextDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseTextDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseTextDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseTextDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseWebSearchCallCompletedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseWebSearchCallCompletedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseWebSearchCallInProgressEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseWebSearchCallInProgressEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseWebSearchCallSearchingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseWebSearchCallSearchingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseWsErrorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseWsErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseWsErrorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseWsErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponsesClientEventDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponsesClientEventDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponsesClientEventDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponsesClientEventDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1Type))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponsesClientEventResponseCreateVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1Type?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponsesClientEventResponseCreateVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponsesServerEventDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponsesServerEventDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponsesServerEventDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponsesServerEventDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ServiceTierResponsesEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ServiceTierResponsesEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ServiceTierResponsesEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ServiceTierResponsesEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TextResponseFormatJsonSchemaType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TextResponseFormatJsonSchemaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TextResponseFormatJsonSchemaType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TextResponseFormatJsonSchemaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceAllowedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceAllowedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceAllowedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceAllowedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceAllowedMode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceAllowedModeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceAllowedMode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceAllowedModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceCustomType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceCustomTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceCustomType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceCustomTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceTypesType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceTypesTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceTypesType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceTypesTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchOutputToolDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolSearchOutputToolDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchOutputToolDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolSearchOutputToolDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VerbosityEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VerbosityEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VerbosityEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VerbosityEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionFindType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchActionFindTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionFindType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchActionFindTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionOpenPageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchActionOpenPageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionOpenPageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchActionOpenPageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionSearchType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchActionSearchTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionSearchType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchActionSearchTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionSearchSourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchActionSearchSourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionSearchSourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchActionSearchSourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchApproximateLocationWebSearchApproximateLocation1Type))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchApproximateLocationWebSearchApproximateLocation1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchApproximateLocationWebSearchApproximateLocation1Type?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchApproximateLocationWebSearchApproximateLocation1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchToolSearchContextSize))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchToolSearchContextSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchToolSearchContextSize?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchToolSearchContextSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchToolCallActionDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchToolCallActionDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchToolCallActionDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchToolCallActionDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MisalignmentErrorTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MisalignmentErrorTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModerationInputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModerationInputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModerationInputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModerationInputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModerationResultBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModerationResultBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModerationResultBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModerationResultBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheTTLEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheTTLEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheTTLEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheTTLEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheModeEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheModeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheModeEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheModeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParamMode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheBreakpointParamModeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParamMode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheBreakpointParamModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModerationMode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModerationModeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModerationMode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModerationModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SkillReferenceParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SkillReferenceParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SkillReferenceParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SkillReferenceParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InlineSkillSourceParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InlineSkillSourceParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InlineSkillSourceParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InlineSkillSourceParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InlineSkillSourceParamMediaType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InlineSkillSourceParamMediaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InlineSkillSourceParamMediaType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InlineSkillSourceParamMediaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InlineSkillParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InlineSkillParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InlineSkillParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InlineSkillParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerNetworkPolicyDisabledParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerNetworkPolicyDisabledParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerNetworkPolicyAllowlistParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerNetworkPolicyAllowlistParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.IncludeEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.IncludeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.IncludeEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.IncludeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheBreakpointConfigModeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheBreakpointConfigModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputTextContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputTextContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputTextContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputTextContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileCitationBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileCitationBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileCitationBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileCitationBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UrlCitationBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UrlCitationBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UrlCitationBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UrlCitationBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerFileCitationBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerFileCitationBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerFileCitationBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerFileCitationBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AnnotationDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AnnotationDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AnnotationDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AnnotationDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OutputTextContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OutputTextContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OutputTextContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OutputTextContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SummaryTextContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SummaryTextContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SummaryTextContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SummaryTextContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningTextContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningTextContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningTextContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningTextContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RefusalContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RefusalContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RefusalContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RefusalContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageDetail))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageDetail?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputImageContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputImageContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputImageContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputImageContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileInputDetail))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileInputDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileInputDetail?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileInputDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputFileContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputFileContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputFileContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputFileContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DirectToolCallCallerType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DirectToolCallCallerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DirectToolCallCallerType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DirectToolCallCallerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProgramToolCallCallerType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProgramToolCallCallerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProgramToolCallCallerType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProgramToolCallCallerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolCallCallerDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolCallCallerDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolCallCallerDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolCallCallerDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DirectToolCallCallerParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DirectToolCallCallerParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DirectToolCallCallerParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DirectToolCallCallerParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProgramToolCallCallerParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProgramToolCallCallerParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProgramToolCallCallerParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProgramToolCallCallerParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolCallCallerParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolCallCallerParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolCallCallerParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolCallCallerParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallOutputStatusEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionCallOutputStatusEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallOutputStatusEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionCallOutputStatusEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolCallModerationDetailsModerationStage))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolCallModerationDetailsModerationStageJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolCallModerationDetailsModerationStage?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolCallModerationDetailsModerationStageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenActionEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenActionEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenActionEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenActionEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageBackground))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageBackgroundJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageBackground?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageBackgroundNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageOutputFormat))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageOutputFormat?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolCallSizeVariant1))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolCallSizeVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolCallSizeVariant1?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolCallSizeVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolCallQuality))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolCallQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolCallQuality?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolCallQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ClickButtonType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ClickButtonTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ClickButtonType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ClickButtonTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ClickParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ClickParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ClickParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ClickParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DoubleClickActionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DoubleClickActionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DoubleClickActionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DoubleClickActionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DragParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DragParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DragParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DragParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.KeyPressActionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.KeyPressActionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.KeyPressActionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.KeyPressActionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MoveParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MoveParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MoveParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MoveParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ScreenshotParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ScreenshotParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ScreenshotParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ScreenshotParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ScrollParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ScrollParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ScrollParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ScrollParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TypeParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TypeParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TypeParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TypeParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WaitParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WaitParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WaitParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WaitParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerCallOutputStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerCallOutputStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerCallOutputStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerCallOutputStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchExecutionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolSearchExecutionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchExecutionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolSearchExecutionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolSearchCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolSearchCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CallableToolAllowedCaller))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CallableToolAllowedCallerJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CallableToolAllowedCaller?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CallableToolAllowedCallerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RankerVersionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RankerVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RankerVersionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RankerVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileSearchToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileSearchToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerEnvironment))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerEnvironmentJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerEnvironment?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerEnvironmentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUsePreviewToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerUsePreviewToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUsePreviewToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerUsePreviewToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerMemoryLimit))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerMemoryLimitJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerMemoryLimit?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerMemoryLimitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AutoCodeInterpreterToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AutoCodeInterpreterToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AutoCodeInterpreterToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AutoCodeInterpreterToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AutoCodeInterpreterToolParamNetworkPolicyDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AutoCodeInterpreterToolParamNetworkPolicyDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProgrammaticToolCallingParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProgrammaticToolCallingParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProgrammaticToolCallingParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProgrammaticToolCallingParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputFidelity))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputFidelityJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputFidelity?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputFidelityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LocalShellToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LocalShellToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerAutoParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerAutoParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerAutoParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerAutoParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerAutoParamNetworkPolicyDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerAutoParamNetworkPolicyDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerAutoParamNetworkPolicyDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerAutoParamNetworkPolicyDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerAutoParamSkillDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerAutoParamSkillDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerAutoParamSkillDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerAutoParamSkillDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LocalEnvironmentParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LocalEnvironmentParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LocalEnvironmentParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LocalEnvironmentParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerReferenceParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerReferenceParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerReferenceParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerReferenceParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellToolParamEnvironmentVariant1DiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellToolParamEnvironmentVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellToolParamEnvironmentVariant1DiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellToolParamEnvironmentVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CustomTextFormatParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CustomTextFormatParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CustomTextFormatParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CustomTextFormatParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GrammarSyntax1))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GrammarSyntax1JsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GrammarSyntax1?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GrammarSyntax1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CustomGrammarFormatParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CustomGrammarFormatParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CustomGrammarFormatParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CustomGrammarFormatParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CustomToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CustomToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolParamFormatDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CustomToolParamFormatDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolParamFormatDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CustomToolParamFormatDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.NamespaceToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.NamespaceToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.NamespaceToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.NamespaceToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.NamespaceToolParamToolDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.NamespaceToolParamToolDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.NamespaceToolParamToolDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.NamespaceToolParamToolDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolSearchToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolSearchToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApproximateLocationType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApproximateLocationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApproximateLocationType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApproximateLocationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SearchContextSize))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SearchContextSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SearchContextSize?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SearchContextSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SearchContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SearchContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SearchContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SearchContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchPreviewToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchPreviewToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchPreviewToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchPreviewToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolSearchOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolSearchOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AdditionalToolsType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AdditionalToolsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AdditionalToolsType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AdditionalToolsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProgramType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProgramTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProgramType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProgramTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProgramOutputStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProgramOutputStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProgramOutputStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProgramOutputStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProgramOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProgramOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProgramOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProgramOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CompactionBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CompactionBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CompactionBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CompactionBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterOutputLogsType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CodeInterpreterOutputLogsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterOutputLogsType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CodeInterpreterOutputLogsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterOutputImageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CodeInterpreterOutputImageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterOutputImageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CodeInterpreterOutputImageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellExecActionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LocalShellExecActionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellExecActionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LocalShellExecActionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LocalEnvironmentResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LocalEnvironmentResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LocalEnvironmentResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LocalEnvironmentResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerReferenceResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerReferenceResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerReferenceResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerReferenceResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallEnvironmentVariant1DiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallEnvironmentVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallEnvironmentVariant1DiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallEnvironmentVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputStatusEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputStatusEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputStatusEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputStatusEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputTimeoutOutcomeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputTimeoutOutcomeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputExitOutcomeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputExitOutcomeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputContentOutcomeDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputContentOutcomeDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputContentOutcomeDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputContentOutcomeDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperationType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchCreateFileOperationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperationType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchCreateFileOperationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchDeleteFileOperationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchDeleteFileOperationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchUpdateFileOperationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchUpdateFileOperationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOperationDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchToolCallOperationDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOperationDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchToolCallOperationDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCallOutputStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchCallOutputStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCallOutputStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchCallOutputStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchToolCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchToolCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPProtocolErrorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPProtocolErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPProtocolErrorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPProtocolErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolExecutionErrorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPToolExecutionErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolExecutionErrorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPToolExecutionErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HTTPErrorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HTTPErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HTTPErrorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HTTPErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPToolCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPToolCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DetailEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DetailEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DetailEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DetailEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallItemStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionCallItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallItemStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionCallItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerCallOutputItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerCallOutputItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerCallOutputItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerCallOutputItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputTextContentParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputTextContentParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputTextContentParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputTextContentParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputImageContentParamAutoParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputImageContentParamAutoParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputImageContentParamAutoParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputImageContentParamAutoParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileDetailEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileDetailEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileDetailEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileDetailEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputFileContentParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputFileContentParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputFileContentParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputFileContentParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallOutputItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionCallOutputItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallOutputItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionCallOutputItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionCallOutputItemParamOutputVariant2ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionCallOutputItemParamOutputVariant2ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchCallItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolSearchCallItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchCallItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolSearchCallItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchOutputFunctionToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolSearchOutputFunctionToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchOutputFunctionToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolSearchOutputFunctionToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchOutputNamespaceToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolSearchOutputNamespaceToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchOutputNamespaceToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolSearchOutputNamespaceToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchOutputNamespaceToolParamToolDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolSearchOutputNamespaceToolParamToolDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchOutputNamespaceToolParamToolDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolSearchOutputNamespaceToolParamToolDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchOutputItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolSearchOutputItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchOutputItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolSearchOutputItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AdditionalToolsItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AdditionalToolsItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AdditionalToolsItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AdditionalToolsItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AdditionalToolsItemParamRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AdditionalToolsItemParamRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AdditionalToolsItemParamRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AdditionalToolsItemParamRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CompactionSummaryItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CompactionSummaryItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CompactionSummaryItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CompactionSummaryItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallItemStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallItemStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallItemParamEnvironmentVariant1DiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallItemParamEnvironmentVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallItemParamEnvironmentVariant1DiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallItemParamEnvironmentVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputTimeoutOutcomeParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputTimeoutOutcomeParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputExitOutcomeParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputExitOutcomeParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputOutcomeParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputOutcomeParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputOutcomeParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputOutcomeParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCallStatusParam))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchCallStatusParamJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCallStatusParam?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchCallStatusParamNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchCreateFileOperationParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchCreateFileOperationParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchDeleteFileOperationParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchDeleteFileOperationParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchUpdateFileOperationParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchUpdateFileOperationParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchOperationParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchOperationParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchOperationParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchOperationParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchToolCallItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchToolCallItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCallOutputStatusParam))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchCallOutputStatusParamJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCallOutputStatusParam?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchCallOutputStatusParamNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchToolCallOutputItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchToolCallOutputItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CompactionTriggerItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CompactionTriggerItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CompactionTriggerItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CompactionTriggerItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ItemReferenceParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ItemReferenceParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ItemReferenceParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ItemReferenceParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProgramItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProgramItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProgramItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProgramItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProgramOutputItemStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProgramOutputItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProgramOutputItemStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProgramOutputItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProgramOutputItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProgramOutputItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProgramOutputItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProgramOutputItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SpecificProgrammaticToolCallingParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SpecificProgrammaticToolCallingParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SpecificProgrammaticToolCallingParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SpecificProgrammaticToolCallingParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SpecificApplyPatchParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SpecificApplyPatchParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SpecificApplyPatchParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SpecificApplyPatchParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SpecificFunctionShellParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SpecificFunctionShellParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SpecificFunctionShellParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SpecificFunctionShellParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CyberAccessProgramEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CyberAccessProgramEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CyberAccessProgramEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CyberAccessProgramEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningModeEnumEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningModeEnumEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningModeEnumEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningModeEnumEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CacheMissReasonTypeEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CacheMissReasonTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CacheMissReasonTypeEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CacheMissReasonTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheMissDiagnosticsBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheMissDiagnosticsBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheHitDiagnosticsBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheHitDiagnosticsBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheComparisonResponseNotFoundDiagnosticsBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheComparisonResponseNotFoundDiagnosticsBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheUnavailableDiagnosticsBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheUnavailableDiagnosticsBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheDiagnosticsDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheDiagnosticsDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheDiagnosticsDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheDiagnosticsDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModerationErrorBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModerationErrorBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModerationErrorBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModerationErrorBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModerationInputDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModerationInputDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModerationInputDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModerationInputDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModerationOutputDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModerationOutputDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModerationOutputDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModerationOutputDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseCompactionCompactingStreamingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseCompactionCompactingStreamingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseShellCallCommandAddedStreamingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseShellCallCommandAddedStreamingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseShellCallCommandDeltaStreamingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseShellCallCommandDeltaStreamingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseShellCallCommandDoneStreamingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseShellCallCommandDoneStreamingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseShellCallOutputContentDeltaStreamingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseShellCallOutputContentDeltaStreamingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseShellCallOutputContentDoneStreamingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseShellCallOutputContentDoneStreamingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UserMessageItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UserMessageItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UserMessageItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UserMessageItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UserMessageItemParamRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UserMessageItemParamRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UserMessageItemParamRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UserMessageItemParamRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UserMessageItemParamContentVariant1ItemDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UserMessageItemParamContentVariant1ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UserMessageItemParamContentVariant1ItemDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UserMessageItemParamContentVariant1ItemDiscriminatorTypeNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ModerationInputType>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_C52BF211024DDFD3(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Annotation>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_1A1CAD1829DC041F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CallableToolAllowedCaller>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_910023668A7B8D0B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ComputerAction>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_FA44726624AEC096(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ComputerCallSafetyCheckParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_347CCA779EEF64D4(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContainerNetworkPolicyDomainSecretParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_57C01D3546E0935C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant1Item>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_6C672DD6D26A6317(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContextManagementParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_BB505C01F2E99038(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CoordParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_5ADE68DDF0DCBBAC(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FileSearchToolCallResultsVariant1Item>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_9E20E2A0C7C8F578(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FiltersItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_33EE83DB0267626E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_1E0200DE4AF2754B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionShellCallOutputContent>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_3BD0C0C02844B739(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionShellCallOutputContentParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_ECFF433A88839BCC(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.IncludeEnum>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_53E0B963EC4B43F7(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContent>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_3761A4CD1A5F3989(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_2F5F50C018B5E017(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LocalSkillParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_BCC356108F578405(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LogProb>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_55AE7E4369715D72(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.MCPListToolsTool>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_3D1B888BE0613A48(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_A588C663D689201D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_BB4A1E6EB679DC2E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputMessageContent>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_4088EE0D1B7B9B77(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_71DB0338DF8A80C1(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputsVariant1Item>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_4020B6D03582E2F0(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ReasoningTextContent>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_C044A8E3468215A3(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseLogProb>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_7500516A7BCF5A5D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseLogProbTopLogprob>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_3380B9280F33DE6D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseSteerInputItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_FA7261BBB67A88E2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseSteerRequiredInput>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_434E62B5B0D6310B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SearchContentType>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_5D0601242F2C095C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillsItem2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_47F7021679FC8889(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SummaryTextContent>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_54F2FBB838B6E036(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Tool>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_D5D517C0FFB4C526(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolSearchOutputTool>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_D1A5D248753C5131(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem13>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_2FEB8A1A70F07854(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem14>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_E945B8145897B071(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TopLogProb>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_E400EC8643C0A721(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.WebSearchActionSearchSource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_533BA600C532907C(options);
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
                if (type == typeof(global::tryAGI.OpenAI.AccessProgramsBody))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AccessProgramsBody(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AccessProgramsParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AccessProgramsParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AdditionalTools))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AdditionalTools(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AdditionalToolsItemParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AdditionalToolsItemParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AdditionalToolsItemParamRole))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AdditionalToolsItemParamRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AdditionalToolsItemParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AdditionalToolsItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AdditionalToolsType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AdditionalToolsType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDelta2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_FE715550EF5BB2C6(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDone2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_75E882513065D132(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDelta2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_E805BBB2D15E41BF(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDone2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_7CC7D75528B3E499(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDelta2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_7339053D8E292F7A(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDone2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_9C72D9A8E16BDB2B(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsCompleted2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_A1E5D1F859786EDF(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallInWsProgress2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_160D66447DCC623B(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsInterpreting2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_A6087FC009A78A9F(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCompactionWsCompacting2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_94A1EA2C74E08C27(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCompleted2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_E4D8D9AC6E76A7AE(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsAdded2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_4BC8F8A0CAA1AB12(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsDone2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_681A45B19B5DAA19(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCreatedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCreated2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_E9A17B6E4A26D558(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDelta2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_5E9BB8550C2CD4C7(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDone2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_52AACE1BBFC2ECD6(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsFailed2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_E8935837D9245EFA(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsCompleted2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_6355F3655BB0B935(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallInWsProgress2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_CCB3F458195CABD2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsSearching2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_E439D4C38C2BDA57(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDelta2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_135BD495C963ECCF(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_1904EB64DA7DA7F6(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsCompleted2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_BCBC14C5BCF3463A(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsGenerating2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_EEA309E52A1DD6C7(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallInWsProgress2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_BEA9290A7B526EE0(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_851BA75FA3C1400E(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseInWsProgress2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_0219736D79AF3DE1(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseIncompleteEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsIncomplete2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_1069C6ECCE866DDB(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDelta2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_D711CE25F750BB16(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDone2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_13DD37152F2AFDAE(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsCompleted2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_365CED2E4CD04E94(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsFailed2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_F2A8412BDF12D5C2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallInWsProgress2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_96AF16344CAA96DF(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsCompleted2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_2F08E3A642748488(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsFailed2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_BA0467C61CE45369(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsInWsProgress2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_90F33C27A5AA1D3F(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsAdded2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_2D0EBE5D8951EF44(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsDone2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_483D936910665F56(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputTextAnnotationWsAdded2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_6FEC45BF0D6AC7B0(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseQueuedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsQueued2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_46DEAA0CF8FEB43C(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsAdded2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_F8FE30BF21A43B78(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsDone2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_299B17D6F7A8748E(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDelta2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_BA8CA42B3D16D2F0(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDone2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_1D6146B581F9FB6F(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDelta2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_5010A61219EE0978(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDone2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_0915906E7D4721A2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDelta2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_AF4946399C013208(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDone2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_7B44E30D2CA89798(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsAdded2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_85F3547415E3CBE4(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDelta2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_EC870F364FCADC38(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDone2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_9795D82460C86D54(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDelta2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_A4A550A2248B6387(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDone2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_689687C1FC6293F8(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDelta2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_D2C4DB1440F40834(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDone2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_B5B38DAE267D72F8(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsCompleted2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_165829464C04BB8F(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallInWsProgress2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_CDBEDE9964D04D39(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsSearching2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_00E87079DADCE51C(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Annotation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_Annotation(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnnotationDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AnnotationDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnnotationDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AnnotationDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenToolCallSizeVariant1?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_02AC337CBA12908E(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenToolModel?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_9E5A4F0B6EBF35BC(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenToolSize?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_571EE018EA62AAA5(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchCallOutputStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchCallOutputStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchCallOutputStatusParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchCallOutputStatusParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchCallStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchCallStatusParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchCallStatusParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchCreateFileOperation(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchCreateFileOperationParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchCreateFileOperationParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperationType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchCreateFileOperationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchDeleteFileOperation(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchDeleteFileOperationParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchDeleteFileOperationParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchDeleteFileOperationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchOperationParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchOperationParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchOperationParamDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchOperationParamDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchOperationParamDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchOperationParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchToolCall))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ApplyPatchToolCall(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallItemParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ApplyPatchToolCallItemParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallItemParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchToolCallItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOperationDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchToolCallOperationDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOperationDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchToolCallOperationDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ApplyPatchToolCallOutput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ApplyPatchToolCallOutputItemParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchToolCallOutputItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutputType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchToolCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchToolParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchToolParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchToolParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchUpdateFileOperation(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchUpdateFileOperationParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchUpdateFileOperationParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchUpdateFileOperationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApproximateLocation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApproximateLocation(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApproximateLocationType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApproximateLocationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AutoCodeInterpreterToolParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AutoCodeInterpreterToolParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AutoCodeInterpreterToolParamNetworkPolicyDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AutoCodeInterpreterToolParamNetworkPolicyDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AutoCodeInterpreterToolParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AutoCodeInterpreterToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CacheMissReasonTypeEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_CacheMissReasonTypeEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CallableToolAllowedCaller))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CallableToolAllowedCaller2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ClickButtonType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ClickButtonType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ClickParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ClickParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ClickParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ClickParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CodeInterpreterOutputImage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CodeInterpreterOutputImage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CodeInterpreterOutputImageType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_CodeInterpreterOutputImageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CodeInterpreterOutputLogs))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CodeInterpreterOutputLogs(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CodeInterpreterOutputLogsType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_CodeInterpreterOutputLogsType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CodeInterpreterTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CodeInterpreterTool(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CodeInterpreterToolCall))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CodeInterpreterToolCall(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallOutputsVariant1ItemDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CodeInterpreterToolCallOutputsVariant1ItemDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CodeInterpreterToolCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CodeInterpreterToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CodeInterpreterToolType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CodeInterpreterToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CompactionBody))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CompactionBody(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CompactionBodyType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_CompactionBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CompactionSummaryItemParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CompactionSummaryItemParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CompactionSummaryItemParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_CompactionSummaryItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CompactionTriggerItemParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CompactionTriggerItemParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CompactionTriggerItemParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_CompactionTriggerItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComparisonFilter))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ComparisonFilter(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComparisonFilterType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ComparisonFilterType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CompoundFilter))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CompoundFilter(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CompoundFilterFilterDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CompoundFilterFilterDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CompoundFilterType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CompoundFilterType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerAction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ComputerAction2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerActionDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ComputerActionDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerActionDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ComputerActionDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerCallOutputItemParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ComputerCallOutputItemParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerCallOutputItemParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ComputerCallOutputItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerCallOutputStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ComputerCallOutputStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerCallSafetyCheckParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ComputerCallSafetyCheckParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerEnvironment))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ComputerEnvironment2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerScreenshotImage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ComputerScreenshotImage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerScreenshotImageType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ComputerScreenshotImageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ComputerTool(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerToolCall))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ComputerToolCall(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerToolCallOutput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ComputerToolCallOutput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerToolCallOutputResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ComputerToolCallOutputResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerToolCallOutputResourceVariant2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ComputerToolCallOutputResourceVariant2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerToolCallOutputStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ComputerToolCallOutputStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerToolCallOutputType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ComputerToolCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerToolCallStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ComputerToolCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerToolCallType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ComputerToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerToolType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ComputerToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUsePreviewTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ComputerUsePreviewTool(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUsePreviewToolType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ComputerUsePreviewToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContainerAutoParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ContainerAutoParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContainerAutoParamNetworkPolicyDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ContainerAutoParamNetworkPolicyDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContainerAutoParamNetworkPolicyDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ContainerAutoParamNetworkPolicyDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContainerAutoParamSkillDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ContainerAutoParamSkillDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContainerAutoParamSkillDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ContainerAutoParamSkillDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContainerAutoParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ContainerAutoParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContainerFileCitationBody))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ContainerFileCitationBody(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContainerFileCitationBodyType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ContainerFileCitationBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContainerMemoryLimit))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ContainerMemoryLimit2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ContainerNetworkPolicyAllowlistParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ContainerNetworkPolicyAllowlistParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ContainerNetworkPolicyDisabledParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ContainerNetworkPolicyDisabledParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyDomainSecretParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ContainerNetworkPolicyDomainSecretParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContainerReferenceParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ContainerReferenceParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContainerReferenceParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ContainerReferenceParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContainerReferenceResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ContainerReferenceResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContainerReferenceResourceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ContainerReferenceResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContentVariant1Item))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_ContentVariant1Item2_3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContextManagementParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ContextManagementParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ConversationParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ConversationParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ConversationParam2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ConversationParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CoordParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_CoordParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModelResponseProperties))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateModelResponseProperties2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModelResponsePropertiesVariant2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateModelResponsePropertiesVariant2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateResponse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateResponse2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateResponseVariant3))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateResponseVariant3(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.CreateResponseVariant3Truncation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateResponseVariant3Truncation2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::tryAGI.OpenAI.CustomGrammarFormatParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_CustomGrammarFormatParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CustomGrammarFormatParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_CustomGrammarFormatParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CustomTextFormatParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_CustomTextFormatParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CustomTextFormatParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_CustomTextFormatParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CustomToolCall))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CustomToolCall(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CustomToolCallOutput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CustomToolCallOutput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CustomToolCallOutputResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CustomToolCallOutputResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CustomToolCallOutputResourceVariant2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CustomToolCallOutputResourceVariant2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CustomToolCallOutputType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CustomToolCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CustomToolCallType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CustomToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CustomToolParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_CustomToolParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CustomToolParamFormatDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_CustomToolParamFormatDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CustomToolParamFormatDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_CustomToolParamFormatDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CustomToolParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_CustomToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CyberAccessProgramEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_CyberAccessProgramEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DetailEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DetailEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DirectToolCallCaller))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DirectToolCallCaller(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DirectToolCallCallerParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DirectToolCallCallerParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DirectToolCallCallerParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DirectToolCallCallerParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DirectToolCallCallerType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DirectToolCallCallerType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DoubleClickAction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_DoubleClickAction(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DoubleClickActionType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DoubleClickActionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DragParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_DragParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DragParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DragParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EasyInputMessage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_EasyInputMessage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EasyInputMessageRole))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_EasyInputMessageRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EasyInputMessageType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_EasyInputMessageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EmptyModelParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_EmptyModelParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentVariant1))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_EnvironmentVariant1(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentVariant12))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_EnvironmentVariant12(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentVariant13))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_EnvironmentVariant13(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ErrorPayload))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ErrorPayload(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FileCitationBody))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FileCitationBody(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FileCitationBodyType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FileCitationBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FileDetailEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FileDetailEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FileInputDetail))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FileInputDetail2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FilePath))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FilePath(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FilePathType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FilePathType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FileSearchTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FileSearchTool(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FileSearchToolCall))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FileSearchToolCall(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FileSearchToolCallResultsVariant1Item))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FileSearchToolCallResultsVariant1Item(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FileSearchToolCallStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FileSearchToolCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FileSearchToolCallType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FileSearchToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FileSearchToolType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FileSearchToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Filters2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_Filters2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FiltersItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FiltersItem2_3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Format2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_Format22(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FunctionAndCustomToolCallOutput2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionAndCustomToolCallOutputDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FunctionAndCustomToolCallOutputDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionAndCustomToolCallOutputDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FunctionAndCustomToolCallOutputDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionCallItemStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionCallItemStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionCallOutputItemParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FunctionCallOutputItemParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionCallOutputItemParamOutputVariant2ItemDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionCallOutputItemParamOutputVariant2ItemDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionCallOutputItemParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionCallOutputItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionCallOutputStatusEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FunctionCallOutputStatusEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionCallStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FunctionCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellAction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionShellAction(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellActionParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionShellActionParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCall))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FunctionShellCall(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallEnvironmentVariant1Discriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionShellCallEnvironmentVariant1Discriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallEnvironmentVariant1DiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionShellCallEnvironmentVariant1DiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallItemParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FunctionShellCallItemParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallItemParamEnvironmentVariant1Discriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionShellCallItemParamEnvironmentVariant1Discriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallItemParamEnvironmentVariant1DiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionShellCallItemParamEnvironmentVariant1DiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallItemParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionShellCallItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallItemStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionShellCallItemStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FunctionShellCallOutput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionShellCallOutputContent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputContentOutcomeDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionShellCallOutputContentOutcomeDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputContentOutcomeDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionShellCallOutputContentOutcomeDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputContentParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionShellCallOutputContentParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcome))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionShellCallOutputExitOutcome(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionShellCallOutputExitOutcomeParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionShellCallOutputExitOutcomeParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionShellCallOutputExitOutcomeType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputItemParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FunctionShellCallOutputItemParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputItemParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionShellCallOutputItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputOutcomeParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionShellCallOutputOutcomeParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputOutcomeParamDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionShellCallOutputOutcomeParamDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputOutcomeParamDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionShellCallOutputOutcomeParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputStatusEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionShellCallOutputStatusEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcome))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionShellCallOutputTimeoutOutcome(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionShellCallOutputTimeoutOutcomeParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionShellCallOutputTimeoutOutcomeParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionShellCallOutputTimeoutOutcomeType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionShellCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionShellCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionShellCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellToolParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionShellToolParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellToolParamEnvironmentVariant1Discriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionShellToolParamEnvironmentVariant1Discriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellToolParamEnvironmentVariant1DiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionShellToolParamEnvironmentVariant1DiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellToolParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionShellToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionTool(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionToolCall))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FunctionToolCall(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionToolCallOutput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FunctionToolCallOutput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionToolCallOutputResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FunctionToolCallOutputResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionToolCallOutputResourceVariant2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FunctionToolCallOutputResourceVariant2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionToolCallOutputStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FunctionToolCallOutputStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionToolCallOutputType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FunctionToolCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionToolCallStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FunctionToolCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionToolCallType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FunctionToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionToolParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionToolParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionToolParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionToolType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GrammarSyntax1))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_GrammarSyntax12(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HTTPError))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_HTTPError(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HTTPErrorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HTTPErrorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HybridSearchOptions))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HybridSearchOptions(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageBackground))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ImageBackground2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageDetail))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ImageDetail2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenActionEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ImageGenActionEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ImageGenTool(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenToolBackground))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ImageGenToolBackground2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenToolCall))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ImageGenToolCall(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenToolCallError))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ImageGenToolCallError(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenToolCallModerationDetails))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ImageGenToolCallModerationDetails(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenToolCallModerationDetailsModerationStage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ImageGenToolCallModerationDetailsModerationStage2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenToolCallQuality))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ImageGenToolCallQuality2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenToolCallSizeVariant1))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ImageGenToolCallSizeVariant12(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenToolCallStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ImageGenToolCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenToolCallType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ImageGenToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenToolInputImageMask))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ImageGenToolInputImageMask(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenToolModel))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ImageGenToolModel2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenToolModeration))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ImageGenToolModeration2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenToolOutputFormat))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ImageGenToolOutputFormat2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenToolQuality))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ImageGenToolQuality2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenToolSize))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ImageGenToolSize2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenToolType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ImageGenToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageOutputFormat))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ImageOutputFormat2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.IncludeEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_IncludeEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InlineSkillParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InlineSkillParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InlineSkillParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InlineSkillParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InlineSkillSourceParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InlineSkillSourceParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InlineSkillSourceParamMediaType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InlineSkillSourceParamMediaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InlineSkillSourceParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InlineSkillSourceParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Input4))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_Input42(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InputContent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContentDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InputContentDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContentDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InputContentDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputFidelity))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InputFidelity2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputFileContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InputFileContent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputFileContentParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InputFileContentParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputFileContentParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InputFileContentParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputFileContentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InputFileContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputImageContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InputImageContent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputImageContentParamAutoParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InputImageContentParamAutoParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputImageContentParamAutoParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InputImageContentParamAutoParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputImageContentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InputImageContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InputItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputItemDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InputItemDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputItemDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InputItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputMessage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InputMessage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputMessageRole))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InputMessageRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputMessageStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InputMessageStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputMessageType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InputMessageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InputParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputTextContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InputTextContent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputTextContentParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InputTextContentParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputTextContentParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InputTextContentParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputTextContentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InputTextContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Item))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Item2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ItemDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ItemDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ItemDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ItemReferenceParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ItemReferenceParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ItemReferenceParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ItemReferenceParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.KeyPressAction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_KeyPressAction(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.KeyPressActionType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_KeyPressActionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LocalEnvironmentParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LocalEnvironmentParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LocalEnvironmentParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LocalEnvironmentParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LocalEnvironmentResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LocalEnvironmentResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LocalEnvironmentResourceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LocalEnvironmentResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LocalShellExecAction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_LocalShellExecAction(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LocalShellExecActionType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LocalShellExecActionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LocalShellToolCall))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_LocalShellToolCall(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LocalShellToolCallOutput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_LocalShellToolCallOutput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LocalShellToolCallOutputStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_LocalShellToolCallOutputStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LocalShellToolCallOutputType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_LocalShellToolCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LocalShellToolCallStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_LocalShellToolCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LocalShellToolCallType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_LocalShellToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LocalShellToolParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LocalShellToolParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LocalShellToolParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LocalShellToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LocalSkillParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LocalSkillParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LogProb))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LogProb(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MCPApprovalRequest))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MCPApprovalRequest(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MCPApprovalRequestType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MCPApprovalRequestType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MCPApprovalResponse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MCPApprovalResponse(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MCPApprovalResponseResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MCPApprovalResponseResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MCPApprovalResponseResourceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MCPApprovalResponseResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MCPApprovalResponseType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MCPApprovalResponseType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MCPListTools))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MCPListTools(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MCPListToolsTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MCPListToolsTool(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MCPListToolsType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MCPListToolsType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MCPProtocolError))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MCPProtocolError(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MCPProtocolErrorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_MCPProtocolErrorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MCPTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MCPTool(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MCPToolCall))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MCPToolCall(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MCPToolCallError))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MCPToolCallError(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MCPToolCallErrorDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MCPToolCallErrorDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MCPToolCallErrorDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MCPToolCallErrorDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MCPToolCallStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MCPToolCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MCPToolCallType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MCPToolCallType2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.MCPToolConnectorId))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MCPToolConnectorId2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::tryAGI.OpenAI.MCPToolExecutionError))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MCPToolExecutionError(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MCPToolExecutionErrorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_MCPToolExecutionErrorType2(options);
                }
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
                if (type == typeof(global::tryAGI.OpenAI.MessagePhase))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessagePhase2_3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageRole))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_MessageRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MisalignmentErrorDetailsResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MisalignmentErrorDetailsResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MisalignmentErrorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_MisalignmentErrorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_MisalignmentErrorTypeEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MisalignmentSteer))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_MisalignmentSteer(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ModelIdsResponses))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ModelIdsResponses2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ModelIdsResponsesEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ModelIdsResponsesEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ModelIdsShared))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ModelIdsShared2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ModelIdsSharedEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ModelIdsSharedEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ModelResponseProperties))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ModelResponseProperties(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.ModelResponsePropertiesPromptCacheRetention))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ModelResponsePropertiesPromptCacheRetention2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::tryAGI.OpenAI.Moderation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_Moderation(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ModerationConfigParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ModerationConfigParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ModerationErrorBody))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ModerationErrorBody(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ModerationErrorBodyType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ModerationErrorBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ModerationInputDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ModerationInputDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ModerationInputDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ModerationInputDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ModerationInputType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ModerationInputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ModerationMode))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ModerationMode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ModerationOutputDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ModerationOutputDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ModerationOutputDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ModerationOutputDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ModerationParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ModerationParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ModerationPolicyParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ModerationPolicyParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ModerationResultBody))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ModerationResultBody(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ModerationResultBodyType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ModerationResultBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MoveParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MoveParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MoveParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_MoveParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.NamespaceToolParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_NamespaceToolParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.NamespaceToolParamToolDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_NamespaceToolParamToolDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.NamespaceToolParamToolDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_NamespaceToolParamToolDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.NamespaceToolParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_NamespaceToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.NetworkPolicy2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_NetworkPolicy22(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.NetworkPolicy3))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_NetworkPolicy32(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant1Item>, string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_5717ADBAC4F47766(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<string>, global::tryAGI.OpenAI.MCPToolFilter>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_A7B4DB888D6EF634(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum, global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_AE78E24B968C5FEC(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_33CE3604D32F85AE(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, double?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_569B880384C23575(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_C8BF530047E0FBA3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContent>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_18DCA4CF6CCC543D(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_8660AC06E08C7E4C(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_C01C7D7052AB4511(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.AutoCodeInterpreterToolParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_5A33374B4B36D875(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Operation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_Operation2_3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Outcome))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_Outcome2_3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Output5))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_Output52(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_OutputContent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputContentDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_OutputContentDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputContentDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_OutputContentDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_OutputItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputItemDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_OutputItemDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputItemDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_OutputItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputMessage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_OutputMessage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputMessageContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_OutputMessageContent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputMessageContentDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_OutputMessageContentDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputMessageContentDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_OutputMessageContentDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputMessageRole))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_OutputMessageRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputMessageStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_OutputMessageStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputMessageType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_OutputMessageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputTextContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_OutputTextContent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputTextContentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_OutputTextContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputVariant2Item))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_OutputVariant2Item2_3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputsVariant1Item))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_OutputsVariant1Item2_3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Program))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Program(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ProgramItemParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ProgramItemParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ProgramItemParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ProgramItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ProgramOutput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ProgramOutput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ProgramOutputItemParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ProgramOutputItemParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ProgramOutputItemParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ProgramOutputItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ProgramOutputItemStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ProgramOutputItemStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ProgramOutputStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ProgramOutputStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ProgramOutputType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ProgramOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ProgramToolCallCaller))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ProgramToolCallCaller(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ProgramToolCallCallerParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ProgramToolCallCallerParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ProgramToolCallCallerParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ProgramToolCallCallerParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ProgramToolCallCallerType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ProgramToolCallCallerType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ProgramType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ProgramType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ProgrammaticToolCallingParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ProgrammaticToolCallingParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ProgrammaticToolCallingParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ProgrammaticToolCallingParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfig))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_PromptCacheBreakpointConfig(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_PromptCacheBreakpointConfigMode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_PromptCacheBreakpointParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParamMode))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_PromptCacheBreakpointParamMode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBody))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_PromptCacheComparisonResponseNotFoundDiagnosticsBody(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBodyType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_PromptCacheComparisonResponseNotFoundDiagnosticsBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheDiagnostics))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_PromptCacheDiagnostics2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheDiagnosticsDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_PromptCacheDiagnosticsDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheDiagnosticsDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_PromptCacheDiagnosticsDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBody))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_PromptCacheHitDiagnosticsBody(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBodyType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_PromptCacheHitDiagnosticsBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBody))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_PromptCacheMissDiagnosticsBody(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBodyType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_PromptCacheMissDiagnosticsBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheModeEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_PromptCacheModeEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheOptions))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_PromptCacheOptions(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheOptionsParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_PromptCacheOptionsParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheTTLEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_PromptCacheTTLEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBody))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_PromptCacheUnavailableDiagnosticsBody(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBodyType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_PromptCacheUnavailableDiagnosticsBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptVariant1))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_PromptVariant1(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RankerVersionType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RankerVersionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RankingOptions))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RankingOptions(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Reasoning))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Reasoning(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningContext))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ReasoningContext2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ReasoningEffortEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningGenerateSummary))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ReasoningGenerateSummary2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ReasoningItem(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningItemStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ReasoningItemStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningItemType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ReasoningItemType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningModeEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ReasoningModeEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningModeEnumEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ReasoningModeEnumEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningSummary))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ReasoningSummary2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningTextContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ReasoningTextContent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningTextContentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ReasoningTextContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RefusalContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RefusalContent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RefusalContentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RefusalContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Response))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_Response2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseAudioDeltaEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseAudioDeltaEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseAudioDeltaEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseAudioDeltaEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseAudioDoneEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseAudioDoneEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseAudioDoneEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseAudioDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseAudioTranscriptDeltaEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseAudioTranscriptDeltaEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseAudioTranscriptDoneEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseAudioTranscriptDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseCodeInterpreterCallCodeDeltaEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseCodeInterpreterCallCodeDeltaEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseCodeInterpreterCallCodeDoneEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseCodeInterpreterCallCodeDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseCodeInterpreterCallCompletedEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseCodeInterpreterCallCompletedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseCodeInterpreterCallInProgressEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseCodeInterpreterCallInProgressEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseCodeInterpreterCallInterpretingEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseCodeInterpreterCallInterpretingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseCompactionCompactingStreamingEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseCompactionCompactingStreamingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseCompletedEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseCompletedEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseCompletedEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseCompletedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ResponseConfigurationUpdateItemParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamReasoning))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseConfigurationUpdateItemParamReasoning(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseConfigurationUpdateItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseContentPartAddedEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseContentPartAddedEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseContentPartAddedEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseContentPartAddedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseContentPartDoneEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseContentPartDoneEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseContentPartDoneEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseContentPartDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseConversation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseConversation(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseCreatedEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseCreatedEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseCreatedEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseCreatedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseCustomToolCallInputDeltaEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseCustomToolCallInputDeltaEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseCustomToolCallInputDoneEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseCustomToolCallInputDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseErrorCode))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseErrorCode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseErrorVariant1))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseErrorVariant1(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFailedEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseFailedEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFailedEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseFailedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseFileSearchCallCompletedEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseFileSearchCallCompletedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseFileSearchCallInProgressEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseFileSearchCallInProgressEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseFileSearchCallSearchingEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseFileSearchCallSearchingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ResponseFormatJsonObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseFormatJsonObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchemaSchema))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseFormatJsonSchemaSchema(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFormatText))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ResponseFormatText(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFormatTextType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseFormatTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseFunctionCallArgumentsDeltaEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseFunctionCallArgumentsDeltaEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseFunctionCallArgumentsDoneEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseFunctionCallArgumentsDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseImageGenCallCompletedEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseImageGenCallCompletedEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseImageGenCallCompletedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseImageGenCallGeneratingEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseImageGenCallGeneratingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseImageGenCallInProgressEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseImageGenCallInProgressEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseImageGenCallInProgressEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseImageGenCallPartialImageEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseImageGenCallPartialImageEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseInProgressEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseInProgressEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseInProgressEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseInProgressEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseIncompleteEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseIncompleteEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseIncompleteEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseIncompleteEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseLogProb))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseLogProb(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseLogProbTopLogprob))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseLogProbTopLogprob(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseMCPCallArgumentsDeltaEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseMCPCallArgumentsDeltaEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseMCPCallArgumentsDoneEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseMCPCallArgumentsDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseMCPCallCompletedEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseMCPCallCompletedEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseMCPCallCompletedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseMCPCallFailedEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseMCPCallFailedEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseMCPCallFailedEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseMCPCallFailedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseMCPCallInProgressEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseMCPCallInProgressEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseMCPCallInProgressEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseMCPListToolsCompletedEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseMCPListToolsCompletedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseMCPListToolsFailedEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseMCPListToolsFailedEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseMCPListToolsFailedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseMCPListToolsInProgressEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseMCPListToolsInProgressEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseOutputItemAddedEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseOutputItemAddedEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseOutputItemAddedEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseOutputItemAddedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseOutputItemDoneEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseOutputItemDoneEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseOutputItemDoneEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseOutputItemDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseOutputTextAnnotationAddedEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseOutputTextAnnotationAddedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsePromptCacheOptionsParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ResponsePromptCacheOptionsParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseProperties))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ResponseProperties(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseQueuedEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseQueuedEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseQueuedEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseQueuedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseReasoningSummaryPartAddedEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventPart))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseReasoningSummaryPartAddedEventPart(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventPartType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseReasoningSummaryPartAddedEventPartType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseReasoningSummaryPartAddedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseReasoningSummaryPartDoneEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventPart))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseReasoningSummaryPartDoneEventPart(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventPartType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseReasoningSummaryPartDoneEventPartType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseReasoningSummaryPartDoneEventStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseReasoningSummaryPartDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseReasoningSummaryTextDeltaEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseReasoningSummaryTextDeltaEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseReasoningSummaryTextDoneEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseReasoningSummaryTextDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseReasoningTextDeltaEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseReasoningTextDeltaEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseReasoningTextDeltaEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseReasoningTextDoneEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseReasoningTextDoneEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseReasoningTextDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseRefusalDeltaEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseRefusalDeltaEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseRefusalDeltaEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseRefusalDeltaEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseRefusalDoneEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseRefusalDoneEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseRefusalDoneEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseRefusalDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseShellCallCommandAddedStreamingEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseShellCallCommandAddedStreamingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseShellCallCommandDeltaStreamingEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseShellCallCommandDeltaStreamingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseShellCallCommandDoneStreamingEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseShellCallCommandDoneStreamingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseShellCallOutputContentDeltaStreamingEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseShellCallOutputContentDeltaStreamingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseShellCallOutputContentDoneStreamingEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseShellCallOutputContentDoneStreamingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerAcceptedEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseSteerAcceptedEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerAcceptedEventSteer))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseSteerAcceptedEventSteer(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerAcceptedEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseSteerAcceptedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerErrorCode))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseSteerErrorCode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerErrorCodeEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseSteerErrorCodeEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseSteerEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseSteerEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerFailedEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseSteerFailedEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerFailedEventError))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseSteerFailedEventError(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerFailedEventErrorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseSteerFailedEventErrorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerFailedEventSteer))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseSteerFailedEventSteer(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerFailedEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseSteerFailedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerInput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseSteerInput2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerInputItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseSteerInputItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerInputItemDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseSteerInputItemDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerInputItemDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseSteerInputItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerPendingEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseSteerPendingEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerPendingEventSteer))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseSteerPendingEventSteer(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerPendingEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseSteerPendingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerPendingReason))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseSteerPendingReason2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerPendingReasonEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseSteerPendingReasonEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseSteerRequiredInput2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseSteerRequiredInputDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseSteerRequiredInputDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredApplyPatchToolCallOutput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseSteerRequiredInputRequiredApplyPatchToolCallOutput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredApplyPatchToolCallOutputType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseSteerRequiredInputRequiredApplyPatchToolCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredComputerToolCallOutput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseSteerRequiredInputRequiredComputerToolCallOutput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredComputerToolCallOutputType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseSteerRequiredInputRequiredComputerToolCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredCustomToolCallOutput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseSteerRequiredInputRequiredCustomToolCallOutput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredCustomToolCallOutputType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseSteerRequiredInputRequiredCustomToolCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredFunctionToolCallOutput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseSteerRequiredInputRequiredFunctionToolCallOutput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredFunctionToolCallOutputType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseSteerRequiredInputRequiredFunctionToolCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredMcpApprovalResponse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseSteerRequiredInputRequiredMcpApprovalResponse(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredMcpApprovalResponseType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseSteerRequiredInputRequiredMcpApprovalResponseType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredShellToolCallOutput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseSteerRequiredInputRequiredShellToolCallOutput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredShellToolCallOutputType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseSteerRequiredInputRequiredShellToolCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseSteerRequiredInputRequiredToolSearchOutput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutputExecution))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseSteerRequiredInputRequiredToolSearchOutputExecution2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutputType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseSteerRequiredInputRequiredToolSearchOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseStreamOptionsVariant1))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ResponseStreamOptionsVariant1(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseTextDeltaEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseTextDeltaEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseTextDeltaEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseTextDeltaEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseTextDoneEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseTextDoneEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseTextDoneEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseTextDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseTextParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseTextParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseUsage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseUsage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseUsageInputTokensDetails))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseUsageInputTokensDetails(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseUsageOutputTokensDetails))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseUsageOutputTokensDetails(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseVariant3))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseVariant3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseVariant3IncompleteDetails))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseVariant3IncompleteDetails(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseVariant3IncompleteDetailsReason))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseVariant3IncompleteDetailsReason2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseVariant3Object))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseVariant3Object2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseVariant3Status))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseVariant3Status2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseVariant3Truncation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseVariant3Truncation2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseWebSearchCallCompletedEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseWebSearchCallCompletedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseWebSearchCallInProgressEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseWebSearchCallInProgressEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseWebSearchCallSearchingEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseWebSearchCallSearchingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseWsError))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseWsError(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseWsErrorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseWsErrorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesClientEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesClientEvent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesClientEventDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesClientEventDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesClientEventDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesClientEventDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesClientEventResponseCreate))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesClientEventResponseCreate2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesClientEventResponseCreateVariant1(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1Type))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesClientEventResponseCreateVariant1Type2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEvent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDelta2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseAudioTranscriptWsDelta2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDone2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseAudioTranscriptWsDone2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDelta2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseAudioWsDelta2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDone2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseAudioWsDone2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDelta2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseCodeInterpreterCallCodeWsDelta2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDone2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseCodeInterpreterCallCodeWsDone2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallInWsProgress2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseCodeInterpreterCallInWsProgress2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsCompleted2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseCodeInterpreterCallWsCompleted2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsInterpreting2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseCodeInterpreterCallWsInterpreting2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseCompactionWsCompacting2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseCompactionWsCompacting2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsAdded2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseContentPartWsAdded2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsDone2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseContentPartWsDone2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDelta2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseCustomToolCallInputWsDelta2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDone2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseCustomToolCallInputWsDone2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallInWsProgress2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseFileSearchCallInWsProgress2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsCompleted2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseFileSearchCallWsCompleted2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsSearching2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseFileSearchCallWsSearching2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDelta2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseFunctionCallArgumentsWsDelta2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseFunctionCallArgumentsWsDone2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallInWsProgress2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseImageGenCallInWsProgress2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseImageGenCallPartialWsImage2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsCompleted2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseImageGenCallWsCompleted2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsGenerating2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseImageGenCallWsGenerating2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseInWsProgress2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseInWsProgress2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDelta2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseMcpCallArgumentsWsDelta2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDone2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseMcpCallArgumentsWsDone2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallInWsProgress2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseMcpCallInWsProgress2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsCompleted2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseMcpCallWsCompleted2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsFailed2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseMcpCallWsFailed2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsInWsProgress2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseMcpListToolsInWsProgress2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsCompleted2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseMcpListToolsWsCompleted2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsFailed2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseMcpListToolsWsFailed2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsAdded2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseOutputItemWsAdded2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsDone2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseOutputItemWsDone2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseOutputTextAnnotationWsAdded2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseOutputTextAnnotationWsAdded2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsAdded2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseReasoningSummaryPartWsAdded2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsDone2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseReasoningSummaryPartWsDone2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDelta2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseReasoningSummaryTextWsDelta2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDone2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseReasoningSummaryTextWsDone2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDelta2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseReasoningTextWsDelta2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDone2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseReasoningTextWsDone2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDelta2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseRefusalWsDelta2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDone2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseRefusalWsDone2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsAdded2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseShellCallCommandWsAdded2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDelta2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseShellCallCommandWsDelta2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDone2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseShellCallCommandWsDone2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDelta2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseShellCallOutputContentWsDelta2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDone2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseShellCallOutputContentWsDone2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDelta2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseTextWsDelta2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDone2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseTextWsDone2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallInWsProgress2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseWebSearchCallInWsProgress2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsCompleted2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseWebSearchCallWsCompleted2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsSearching2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseWebSearchCallWsSearching2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseWsCompleted2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseWsCompleted2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseWsCreated2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseWsCreated2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseWsFailed2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseWsFailed2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseWsIncomplete2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseWsIncomplete2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventResponseWsQueued2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponsesServerEventResponseWsQueued2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ScreenshotParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ScreenshotParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ScreenshotParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ScreenshotParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ScrollParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ScrollParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ScrollParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ScrollParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SearchContentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SearchContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SearchContextSize))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SearchContextSize2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ServiceTierResponsesEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ServiceTierResponsesEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ShellCallOutputDelta))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ShellCallOutputDelta(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SkillReferenceParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SkillReferenceParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SkillReferenceParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SkillReferenceParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SkillsItem2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SkillsItem22(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SpecificApplyPatchParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SpecificApplyPatchParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SpecificApplyPatchParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SpecificApplyPatchParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SpecificFunctionShellParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SpecificFunctionShellParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SpecificFunctionShellParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SpecificFunctionShellParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SpecificProgrammaticToolCallingParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SpecificProgrammaticToolCallingParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SpecificProgrammaticToolCallingParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SpecificProgrammaticToolCallingParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SummaryTextContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SummaryTextContent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SummaryTextContentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SummaryTextContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TextResponseFormatConfiguration))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_TextResponseFormatConfiguration2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TextResponseFormatJsonSchema))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_TextResponseFormatJsonSchema(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TextResponseFormatJsonSchemaType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_TextResponseFormatJsonSchemaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Tool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Tool2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolCallCaller))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ToolCallCaller(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolCallCallerDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolCallCallerDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolCallCallerDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolCallCallerDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolCallCallerParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ToolCallCallerParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolCallCallerParamDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolCallCallerParamDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolCallCallerParamDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolCallCallerParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceAllowed))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolChoiceAllowed(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceAllowedMode))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolChoiceAllowedMode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceAllowedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolChoiceAllowedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceCustom))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolChoiceCustom(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceCustomType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolChoiceCustomType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolChoiceParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceTypes))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolChoiceTypes(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceTypesType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolChoiceTypesType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolSearchCall))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ToolSearchCall(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolSearchCallItemParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ToolSearchCallItemParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolSearchCallItemParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolSearchCallItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolSearchCallType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolSearchCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolSearchExecutionType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolSearchExecutionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolSearchOutput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ToolSearchOutput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolSearchOutputFunctionToolParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolSearchOutputFunctionToolParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolSearchOutputFunctionToolParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolSearchOutputFunctionToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolSearchOutputItemParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ToolSearchOutputItemParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolSearchOutputItemParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolSearchOutputItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolSearchOutputNamespaceToolParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolSearchOutputNamespaceToolParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolSearchOutputNamespaceToolParamToolDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolSearchOutputNamespaceToolParamToolDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolSearchOutputNamespaceToolParamToolDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolSearchOutputNamespaceToolParamToolDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolSearchOutputNamespaceToolParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolSearchOutputNamespaceToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolSearchOutputTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolSearchOutputTool2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolSearchOutputToolDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolSearchOutputToolDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolSearchOutputToolDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolSearchOutputToolDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolSearchOutputType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolSearchOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolSearchToolParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolSearchToolParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolSearchToolParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolSearchToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolsItem13))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolsItem132(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolsItem14))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolsItem142(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TopLogProb))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_TopLogProb(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TypeParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_TypeParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TypeParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_TypeParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UrlCitationBody))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UrlCitationBody(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UrlCitationBodyType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UrlCitationBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UserMessageItemParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UserMessageItemParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UserMessageItemParamContentVariant1ItemDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_UserMessageItemParamContentVariant1ItemDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UserMessageItemParamContentVariant1ItemDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_UserMessageItemParamContentVariant1ItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UserMessageItemParamRole))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_UserMessageItemParamRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UserMessageItemParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_UserMessageItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VerbosityEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_VerbosityEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WaitParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_WaitParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WaitParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WaitParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchActionFind))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebSearchActionFind(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchActionFindType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebSearchActionFindType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchActionOpenPage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebSearchActionOpenPage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchActionOpenPageType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebSearchActionOpenPageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchActionSearch))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebSearchActionSearch(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchActionSearchSource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebSearchActionSearchSource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchActionSearchSourceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebSearchActionSearchSourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchActionSearchType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebSearchActionSearchType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchApproximateLocationWebSearchApproximateLocation1))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebSearchApproximateLocationWebSearchApproximateLocation1(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchApproximateLocationWebSearchApproximateLocation1Type))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebSearchApproximateLocationWebSearchApproximateLocation1Type2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchCallStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebSearchCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchPreviewTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebSearchPreviewTool(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchPreviewToolType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebSearchPreviewToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebSearchTool(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchToolCall))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_WebSearchToolCall(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchToolCallAction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebSearchToolCallAction2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchToolCallActionDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebSearchToolCallActionDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchToolCallActionDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebSearchToolCallActionDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchToolCallType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebSearchToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchToolFilters))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebSearchToolFilters(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchToolSearchContextSize))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebSearchToolSearchContextSize2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchToolType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebSearchToolType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.AdditionalToolsItemParamRole?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAdditionalToolsItemParamRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AdditionalToolsItemParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAdditionalToolsItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AdditionalToolsType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAdditionalToolsType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDelta2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_0C7B20A9E3E5ED76(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDone2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_1705CBAA166557B1(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDelta2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_EDAAFD2A44799654(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDone2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_40A57DC1E91CBA36(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDelta2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_2013CDB7FD0AD339(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDone2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_4CCAF2679476B528(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsCompleted2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_C805BC17A6A11449(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallInWsProgress2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_DE317F5747BBD4C7(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsInterpreting2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_B069E51D7D3E3BBF(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCompactionWsCompacting2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_A590F4C3A2B3D732(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCompleted2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_D8119B933FD382FB(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsAdded2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_8ADDC36A110F398B(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsDone2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_946A424EBEB34809(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCreatedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCreated2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_08DD6E315C42B8D8(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDelta2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_7DEFB064F03B6F4B(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDone2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_7662ADF99DB1D393(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsFailed2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_A8A3D60764FA7C29(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsCompleted2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_2438EB750B1A474F(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallInWsProgress2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_ED98421DB868246E(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsSearching2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_7A764B1091F1493C(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDelta2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_FDEA586DBC0ABB7A(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_DE1D0C4BED809B0C(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsCompleted2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_1D7FA34D9DF6E3F1(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsGenerating2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_7CDA826E60EC4B95(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallInWsProgress2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_A126DBAA728C1D6E(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_695FC46B0FC75FD7(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseInWsProgress2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_30CD95E00C6F3115(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseIncompleteEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsIncomplete2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_6905C3A8E4460AF2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDelta2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_4E90DCE591EDDC6B(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDone2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_BF4ECF4F4E73B616(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsCompleted2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_0C13AB6BAFC9CF5B(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsFailed2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_76D996C72BD2114E(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallInWsProgress2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_96C78C61AFE32C67(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsCompleted2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_ADC10B503B3E3BED(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsFailed2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_142683A042D4AC78(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsInWsProgress2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_4B356173730B2589(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsAdded2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_20C62109C8D3DEFB(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsDone2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_05C49D30B8DC7771(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputTextAnnotationWsAdded2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_2A4E79282A2B70DB(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseQueuedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsQueued2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_313ED3B6C2B39D01(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsAdded2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_B21BA9B5C5F5DAE0(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsDone2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_A85F929916381195(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDelta2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_98DA8EB2BA5986EF(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDone2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_D8FD05E60E30FBAC(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDelta2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_9926A0E3EDBEB661(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDone2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_88BAFCAD4E39E764(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDelta2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_D8BD23F59787ACE2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDone2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_BEDE6CD167FA8BD9(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsAdded2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_51339A4BF7D72008(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDelta2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_7970AAB1FACE4EAC(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDone2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_0A8AD0168F2BF108(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDelta2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_E36C829CB896523E(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDone2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_293DEEFCE45CE57F(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDelta2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_070A2A504F7C7DBB(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDone2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_EA7D13D05E48EE2C(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsCompleted2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_EBAEC694BB74CEEF(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallInWsProgress2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_2E0B2523ED86223F(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsSearching2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_F1377E3486153EC8(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnnotationDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAnnotationDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenToolModel?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_ABEA0F8B3FC57D87(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenToolSize?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_1BD7EE6D21EC0B36(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchCallOutputStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableApplyPatchCallOutputStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchCallOutputStatusParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableApplyPatchCallOutputStatusParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchCallStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableApplyPatchCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchCallStatusParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableApplyPatchCallStatusParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableApplyPatchCreateFileOperationParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperationType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableApplyPatchCreateFileOperationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableApplyPatchDeleteFileOperationParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableApplyPatchDeleteFileOperationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchOperationParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableApplyPatchOperationParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchOperationParamDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableApplyPatchOperationParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallItemParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableApplyPatchToolCallItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOperationDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableApplyPatchToolCallOperationDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableApplyPatchToolCallOutputItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutputType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableApplyPatchToolCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableApplyPatchToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchToolParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableApplyPatchToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableApplyPatchUpdateFileOperationParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableApplyPatchUpdateFileOperationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApproximateLocationType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableApproximateLocationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AutoCodeInterpreterToolParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAutoCodeInterpreterToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CacheMissReasonTypeEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCacheMissReasonTypeEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CallableToolAllowedCaller?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableCallableToolAllowedCaller2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ClickButtonType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableClickButtonType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ClickParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableClickParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CodeInterpreterOutputImageType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCodeInterpreterOutputImageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CodeInterpreterOutputLogsType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCodeInterpreterOutputLogsType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableCodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableCodeInterpreterToolCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableCodeInterpreterToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CodeInterpreterToolType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableCodeInterpreterToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CompactionBodyType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCompactionBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CompactionSummaryItemParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCompactionSummaryItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CompactionTriggerItemParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCompactionTriggerItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComparisonFilterType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableComparisonFilterType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CompoundFilterType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableCompoundFilterType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerAction?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableComputerAction2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerActionDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableComputerActionDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerCallOutputItemParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableComputerCallOutputItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerCallOutputStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableComputerCallOutputStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerEnvironment?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableComputerEnvironment2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerScreenshotImageType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableComputerScreenshotImageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerToolCallOutputResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableComputerToolCallOutputResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerToolCallOutputStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableComputerToolCallOutputStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerToolCallOutputType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableComputerToolCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerToolCallStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableComputerToolCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerToolCallType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableComputerToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerToolType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableComputerToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUsePreviewToolType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableComputerUsePreviewToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContainerAutoParamNetworkPolicyDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableContainerAutoParamNetworkPolicyDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContainerAutoParamSkillDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableContainerAutoParamSkillDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContainerAutoParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableContainerAutoParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContainerFileCitationBodyType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableContainerFileCitationBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContainerMemoryLimit?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableContainerMemoryLimit2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableContainerNetworkPolicyAllowlistParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableContainerNetworkPolicyDisabledParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContainerReferenceParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableContainerReferenceParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContainerReferenceResourceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableContainerReferenceResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContentVariant1Item?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableContentVariant1Item2_3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateModelResponseProperties?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableCreateModelResponseProperties2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateResponse?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateResponse2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.CreateResponseVariant3Truncation?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateResponseVariant3Truncation2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::tryAGI.OpenAI.CustomGrammarFormatParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCustomGrammarFormatParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CustomTextFormatParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCustomTextFormatParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CustomToolCallOutputResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCustomToolCallOutputResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CustomToolCallOutputType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCustomToolCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CustomToolCallType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCustomToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CustomToolParamFormatDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCustomToolParamFormatDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CustomToolParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCustomToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CyberAccessProgramEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCyberAccessProgramEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DetailEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableDetailEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DirectToolCallCallerParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableDirectToolCallCallerParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DirectToolCallCallerType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableDirectToolCallCallerType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DoubleClickActionType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableDoubleClickActionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DragParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableDragParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EasyInputMessageRole?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableEasyInputMessageRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EasyInputMessageType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableEasyInputMessageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FileCitationBodyType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFileCitationBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FileDetailEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFileDetailEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FileInputDetail?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFileInputDetail2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FilePathType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFilePathType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FileSearchToolCallStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFileSearchToolCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FileSearchToolCallType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFileSearchToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FileSearchToolType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFileSearchToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FiltersItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableFiltersItem2_3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Format2?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFormat22(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionAndCustomToolCallOutput2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionAndCustomToolCallOutputDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionAndCustomToolCallOutputDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionCallItemStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionCallItemStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionCallOutputItemParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionCallOutputItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionCallOutputStatusEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionCallOutputStatusEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionCallStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallEnvironmentVariant1DiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionShellCallEnvironmentVariant1DiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallItemParamEnvironmentVariant1DiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionShellCallItemParamEnvironmentVariant1DiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallItemParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionShellCallItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallItemStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionShellCallItemStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputContentOutcomeDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionShellCallOutputContentOutcomeDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionShellCallOutputExitOutcomeParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionShellCallOutputExitOutcomeType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputItemParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionShellCallOutputItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputOutcomeParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionShellCallOutputOutcomeParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputOutcomeParamDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionShellCallOutputOutcomeParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputStatusEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionShellCallOutputStatusEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionShellCallOutputTimeoutOutcomeParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionShellCallOutputTimeoutOutcomeType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionShellCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionShellCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionShellCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellToolParamEnvironmentVariant1DiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionShellToolParamEnvironmentVariant1DiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellToolParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionShellToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionToolCallOutputResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableFunctionToolCallOutputResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionToolCallOutputStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionToolCallOutputStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionToolCallOutputType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionToolCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionToolCallStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionToolCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionToolCallType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionToolParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionToolType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GrammarSyntax1?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableGrammarSyntax12(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HTTPErrorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHTTPErrorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageBackground?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableImageBackground2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageDetail?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableImageDetail2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenActionEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableImageGenActionEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenToolBackground?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableImageGenToolBackground2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenToolCallModerationDetailsModerationStage?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableImageGenToolCallModerationDetailsModerationStage2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenToolCallQuality?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableImageGenToolCallQuality2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenToolCallSizeVariant1?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableImageGenToolCallSizeVariant12(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenToolCallStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableImageGenToolCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenToolCallType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableImageGenToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenToolModel?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableImageGenToolModel2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenToolModeration?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableImageGenToolModeration2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenToolOutputFormat?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableImageGenToolOutputFormat2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenToolQuality?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableImageGenToolQuality2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenToolSize?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableImageGenToolSize2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenToolType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableImageGenToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageOutputFormat?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableImageOutputFormat2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.IncludeEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableIncludeEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InlineSkillParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInlineSkillParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InlineSkillSourceParamMediaType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInlineSkillSourceParamMediaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InlineSkillSourceParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInlineSkillSourceParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Input4?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInput42(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContent?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInputContent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContentDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInputContentDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputFidelity?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInputFidelity2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputFileContentParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInputFileContentParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputFileContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInputFileContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputImageContentParamAutoParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInputImageContentParamAutoParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputImageContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInputImageContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInputItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputItemDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInputItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputMessageRole?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInputMessageRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputMessageStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInputMessageStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputMessageType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInputMessageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInputParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputTextContentParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInputTextContentParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputTextContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInputTextContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Item?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ItemDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ItemReferenceParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableItemReferenceParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.KeyPressActionType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableKeyPressActionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LocalEnvironmentParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLocalEnvironmentParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LocalEnvironmentResourceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLocalEnvironmentResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LocalShellExecActionType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLocalShellExecActionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LocalShellToolCallOutputStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLocalShellToolCallOutputStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LocalShellToolCallOutputType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLocalShellToolCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LocalShellToolCallStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLocalShellToolCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LocalShellToolCallType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLocalShellToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LocalShellToolParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLocalShellToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MCPApprovalRequestType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMCPApprovalRequestType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MCPApprovalResponseResourceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMCPApprovalResponseResourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MCPApprovalResponseType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMCPApprovalResponseType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MCPListToolsType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMCPListToolsType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MCPProtocolErrorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMCPProtocolErrorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MCPToolCallErrorDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMCPToolCallErrorDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MCPToolCallStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMCPToolCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MCPToolCallType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMCPToolCallType2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.MCPToolConnectorId?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMCPToolConnectorId2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::tryAGI.OpenAI.MCPToolExecutionErrorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMCPToolExecutionErrorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMCPToolRequireApprovalVariant1Enum22(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MCPToolType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMCPToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessagePhase?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessagePhase2_3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageRole?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MisalignmentErrorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMisalignmentErrorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMisalignmentErrorTypeEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ModelIdsResponses?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableModelIdsResponses2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ModelIdsResponsesEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableModelIdsResponsesEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ModelIdsShared?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableModelIdsShared2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ModelIdsSharedEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableModelIdsSharedEnum2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.ModelResponsePropertiesPromptCacheRetention?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableModelResponsePropertiesPromptCacheRetention2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::tryAGI.OpenAI.ModerationErrorBodyType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableModerationErrorBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ModerationInputDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableModerationInputDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ModerationInputType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableModerationInputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ModerationMode?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableModerationMode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ModerationOutputDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableModerationOutputDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ModerationResultBodyType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableModerationResultBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MoveParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMoveParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.NamespaceToolParamToolDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableNamespaceToolParamToolDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.NamespaceToolParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableNamespaceToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.NetworkPolicy2?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableNetworkPolicy22(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.NetworkPolicy3?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableNetworkPolicy32(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentVariant1Item>, string>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_0F9577EC9A97849C(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_01848C29385428F2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, double?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_528BFF85AF3E2294(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput>>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_0ED20A191E885510(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContent>>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_361064B48081D2B5(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item>>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_7AA4182A852EE9F7(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.AutoCodeInterpreterToolParam>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_A6CAFCBC284F6CBF(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Operation?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableOperation2_3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Outcome?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableOutcome2_3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Output5?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableOutput52(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputContent?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableOutputContent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputContentDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableOutputContentDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableOutputItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputItemDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableOutputItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputMessageContent?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableOutputMessageContent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputMessageContentDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableOutputMessageContentDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputMessageRole?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableOutputMessageRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputMessageStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableOutputMessageStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputMessageType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableOutputMessageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputTextContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableOutputTextContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputVariant2Item?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableOutputVariant2Item2_3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputsVariant1Item?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableOutputsVariant1Item2_3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ProgramItemParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableProgramItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ProgramOutputItemParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableProgramOutputItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ProgramOutputItemStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableProgramOutputItemStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ProgramOutputStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableProgramOutputStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ProgramOutputType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableProgramOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ProgramToolCallCallerParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableProgramToolCallCallerParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ProgramToolCallCallerType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableProgramToolCallCallerType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ProgramType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableProgramType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ProgrammaticToolCallingParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableProgrammaticToolCallingParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePromptCacheBreakpointConfigMode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParamMode?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePromptCacheBreakpointParamMode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBodyType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePromptCacheComparisonResponseNotFoundDiagnosticsBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheDiagnostics?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePromptCacheDiagnostics2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheDiagnosticsDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePromptCacheDiagnosticsDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBodyType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePromptCacheHitDiagnosticsBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBodyType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePromptCacheMissDiagnosticsBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheModeEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePromptCacheModeEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheTTLEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePromptCacheTTLEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBodyType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePromptCacheUnavailableDiagnosticsBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RankerVersionType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRankerVersionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningContext?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableReasoningContext2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableReasoningEffortEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningGenerateSummary?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableReasoningGenerateSummary2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningItemStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableReasoningItemStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningItemType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableReasoningItemType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningModeEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableReasoningModeEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningModeEnumEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableReasoningModeEnumEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningSummary?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableReasoningSummary2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningTextContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableReasoningTextContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RefusalContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRefusalContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Response?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponse2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseAudioDeltaEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseAudioDeltaEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseAudioDoneEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseAudioDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseAudioTranscriptDeltaEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseAudioTranscriptDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseCodeInterpreterCallCodeDeltaEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseCodeInterpreterCallCodeDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseCodeInterpreterCallCompletedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseCodeInterpreterCallInProgressEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseCodeInterpreterCallInterpretingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseCompactionCompactingStreamingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseCompletedEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseCompletedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseConfigurationUpdateItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseContentPartAddedEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseContentPartAddedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseContentPartDoneEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseContentPartDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseCreatedEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseCreatedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseCustomToolCallInputDeltaEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseCustomToolCallInputDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseErrorCode?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseErrorCode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFailedEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseFailedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseFileSearchCallCompletedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseFileSearchCallInProgressEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseFileSearchCallSearchingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseFormatJsonObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFormatTextType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseFormatTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseFunctionCallArgumentsDeltaEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseFunctionCallArgumentsDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseImageGenCallCompletedEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseImageGenCallCompletedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseImageGenCallGeneratingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseImageGenCallInProgressEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseImageGenCallInProgressEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseImageGenCallPartialImageEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseInProgressEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseInProgressEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseIncompleteEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseIncompleteEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseMCPCallArgumentsDeltaEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseMCPCallArgumentsDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseMCPCallCompletedEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseMCPCallCompletedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseMCPCallFailedEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseMCPCallFailedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseMCPCallInProgressEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseMCPCallInProgressEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseMCPListToolsCompletedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseMCPListToolsFailedEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseMCPListToolsFailedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseMCPListToolsInProgressEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseOutputItemAddedEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseOutputItemAddedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseOutputItemDoneEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseOutputItemDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseOutputTextAnnotationAddedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseQueuedEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseQueuedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventPartType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseReasoningSummaryPartAddedEventPartType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseReasoningSummaryPartAddedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventPartType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseReasoningSummaryPartDoneEventPartType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseReasoningSummaryPartDoneEventStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseReasoningSummaryPartDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseReasoningSummaryTextDeltaEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseReasoningSummaryTextDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseReasoningTextDeltaEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseReasoningTextDeltaEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseReasoningTextDoneEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseReasoningTextDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseRefusalDeltaEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseRefusalDeltaEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseRefusalDoneEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseRefusalDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseShellCallCommandAddedStreamingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseShellCallCommandDeltaStreamingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseShellCallCommandDoneStreamingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseShellCallOutputContentDeltaStreamingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseShellCallOutputContentDoneStreamingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerAcceptedEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseSteerAcceptedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerErrorCode?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseSteerErrorCode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerErrorCodeEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseSteerErrorCodeEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseSteerEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerFailedEventErrorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseSteerFailedEventErrorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerFailedEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseSteerFailedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerInput?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseSteerInput2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerInputItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseSteerInputItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerInputItemDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseSteerInputItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerPendingEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseSteerPendingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerPendingReason?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseSteerPendingReason2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerPendingReasonEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseSteerPendingReasonEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInput?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseSteerRequiredInput2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseSteerRequiredInputDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredApplyPatchToolCallOutputType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseSteerRequiredInputRequiredApplyPatchToolCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredComputerToolCallOutputType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseSteerRequiredInputRequiredComputerToolCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredCustomToolCallOutputType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseSteerRequiredInputRequiredCustomToolCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredFunctionToolCallOutputType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseSteerRequiredInputRequiredFunctionToolCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredMcpApprovalResponseType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseSteerRequiredInputRequiredMcpApprovalResponseType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredShellToolCallOutputType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseSteerRequiredInputRequiredShellToolCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutputExecution?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseSteerRequiredInputRequiredToolSearchOutputExecution2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutputType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseSteerRequiredInputRequiredToolSearchOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseTextDeltaEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseTextDeltaEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseTextDoneEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseTextDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseVariant3IncompleteDetailsReason?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseVariant3IncompleteDetailsReason2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseVariant3Object?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseVariant3Object2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseVariant3Status?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseVariant3Status2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseVariant3Truncation?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseVariant3Truncation2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseWebSearchCallCompletedEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseWebSearchCallInProgressEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseWebSearchCallSearchingEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseWsErrorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseWsErrorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesClientEvent?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponsesClientEvent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesClientEventDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponsesClientEventDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesClientEventResponseCreate?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponsesClientEventResponseCreate2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1Type?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponsesClientEventResponseCreateVariant1Type2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEvent?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponsesServerEvent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponsesServerEventDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponsesServerEventDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ScreenshotParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableScreenshotParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ScrollParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableScrollParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SearchContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableSearchContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SearchContextSize?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableSearchContextSize2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ServiceTierResponsesEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableServiceTierResponsesEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SkillReferenceParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableSkillReferenceParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SkillsItem2?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableSkillsItem22(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SpecificApplyPatchParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableSpecificApplyPatchParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SpecificFunctionShellParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableSpecificFunctionShellParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SpecificProgrammaticToolCallingParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableSpecificProgrammaticToolCallingParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SummaryTextContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableSummaryTextContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TextResponseFormatConfiguration?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableTextResponseFormatConfiguration2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TextResponseFormatJsonSchemaType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableTextResponseFormatJsonSchemaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Tool?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableTool2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolCallCallerDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableToolCallCallerDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolCallCallerParamDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableToolCallCallerParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceAllowedMode?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableToolChoiceAllowedMode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceAllowedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableToolChoiceAllowedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceCustomType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableToolChoiceCustomType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceTypesType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableToolChoiceTypesType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableToolDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolSearchCallItemParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableToolSearchCallItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolSearchCallType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableToolSearchCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolSearchExecutionType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableToolSearchExecutionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolSearchOutputFunctionToolParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableToolSearchOutputFunctionToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolSearchOutputItemParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableToolSearchOutputItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolSearchOutputNamespaceToolParamToolDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableToolSearchOutputNamespaceToolParamToolDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolSearchOutputNamespaceToolParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableToolSearchOutputNamespaceToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolSearchOutputTool?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableToolSearchOutputTool2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolSearchOutputToolDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableToolSearchOutputToolDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolSearchOutputType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableToolSearchOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolSearchToolParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableToolSearchToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolsItem13?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableToolsItem132(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolsItem14?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableToolsItem142(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TypeParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableTypeParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UrlCitationBodyType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableUrlCitationBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UserMessageItemParamContentVariant1ItemDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableUserMessageItemParamContentVariant1ItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UserMessageItemParamRole?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableUserMessageItemParamRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UserMessageItemParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableUserMessageItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VerbosityEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableVerbosityEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WaitParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWaitParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchActionFindType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebSearchActionFindType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchActionOpenPageType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebSearchActionOpenPageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchActionSearchSourceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebSearchActionSearchSourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchActionSearchType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebSearchActionSearchType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchApproximateLocationWebSearchApproximateLocation1Type?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebSearchApproximateLocationWebSearchApproximateLocation1Type2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchCallStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebSearchCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchPreviewToolType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebSearchPreviewToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchToolCallAction?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebSearchToolCallAction2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchToolCallActionDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebSearchToolCallActionDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchToolCallType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebSearchToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchToolSearchContextSize?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebSearchToolSearchContextSize2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchToolType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebSearchToolType2(options);
                }
                if (type == typeof(int?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.ModerationInputType>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_B50D38EA6F128ECA(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Annotation>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_144E4DFF806E92F6(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CallableToolAllowedCaller>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_A0102E6B0439FF50(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ComputerAction>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_E3E725EED8672F96(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ComputerCallSafetyCheckParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_E71067AAD40601E9(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContainerNetworkPolicyDomainSecretParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_69576CBB03C474C7(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentVariant1Item>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_41BC47FA8394191E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContextManagementParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_BEA6301F87A24B69(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CoordParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_393560E7F4D0A2C5(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.FileSearchToolCallResultsVariant1Item>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_1EE3DDB554A6EABD(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.FiltersItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_383909F143B415B3(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_8A4AF840FCB9CD57(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.FunctionShellCallOutputContent>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_0A2F01D156C18177(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.FunctionShellCallOutputContentParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_F609CF755DE0CE12(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.IncludeEnum>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_EABD224743A226B2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputContent>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_D329C732E3FE4C05(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_8D924B9F02369C50(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.LocalSkillParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_06798C455CA03120(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.LogProb>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_903E0E4F8C7DBAAF(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.MCPListToolsTool>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_213D8E9FE90E98D9(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<string, double?>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_E3941FEAF2607AE9(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_A72BB87EDD8B0424(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputMessageContent>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_5DFD15B6E7DD7864(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputVariant2Item>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_6F56B5293FD908A9(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputsVariant1Item>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_ADEB3C0DD45D6254(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ReasoningTextContent>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_D63B5E4A5DA6D7F7(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ResponseLogProb>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_DB243C92F98CDB59(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ResponseLogProbTopLogprob>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_182C281AD944EF08(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ResponseSteerInputItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_1F90B9110187522A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ResponseSteerRequiredInput>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_E8BE18840DE18EA8(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.SearchContentType>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_0FCB0A1DE07E374A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.SkillsItem2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_A5032DE1023BA797(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.SummaryTextContent>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_B49457B62C01FC26(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Tool>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_89AB6A7CC2C92D2F(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ToolSearchOutputTool>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_75B2E872F2EA9FE5(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ToolsItem13>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_238639EE132A2722(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ToolsItem14>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_A62297FD6BF974E9(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.TopLogProb>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_958662FD1FB10180(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.WebSearchActionSearchSource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_BE277C6744ADF0A7(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<long>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_2BCC53E1C7DA84DD(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_3F34DBFD50DE05D2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentVariant1Item>, string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_6D89BCF443F09289(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.List<string>, global::tryAGI.OpenAI.MCPToolFilter>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_209335A1CF98F53C(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, double?, bool?, global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<string, double?>>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_C8EB3E0743925723(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_311FE012512C5F7A(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputContent>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_D9FC00FB8EF9ED4C(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputItem>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_3ABC6EC2508F010A(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputVariant2Item>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_27F68CCD1C7088DB(options);
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