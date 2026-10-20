
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_DBC6FEC9829D8344 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_DBC6FEC9829D8344 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_DBC6FEC9829D8344(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AssistantStreamEventJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AssistantsApiResponseFormatOptionJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AssistantsApiToolChoiceOptionJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.MessageStreamEventJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.RunStepStreamEventJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.RunStreamEventJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ThreadStreamEventJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.MisalignmentErrorTypeJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.MessageDeltaContentImageFileObject, global::tryAGI.OpenAI.MessageDeltaContentTextObject, global::tryAGI.OpenAI.MessageDeltaContentRefusalObject, global::tryAGI.OpenAI.MessageDeltaContentImageUrlObject>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageContentTextObject, global::tryAGI.OpenAI.MessageContentRefusalObject>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RunStepDeltaStepDetailsMessageCreationObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsObject>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RunStepDetailsMessageCreationObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsObject>());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsCodeType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsCodeType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnlyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnlyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsFunctionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsFunctionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantsApiResponseFormatOptionEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantsApiResponseFormatOptionEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantsApiToolChoiceOptionEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantsApiToolChoiceOptionEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantsNamedToolChoiceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantsNamedToolChoiceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DoneEventEvent)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DoneEventEvent?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DoneEventData)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DoneEventData?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ErrorEventEvent)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ErrorEventEvent?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchRanker)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchRanker?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageFileObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageFileObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageFileObjectImageFileDetail)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageFileObjectImageFileDetail?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageUrlObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageUrlObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageUrlObjectImageUrlDetail)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageUrlObjectImageUrlDetail?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentRefusalObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentRefusalObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentTextObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentTextObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageDeltaContentImageFileObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageDeltaContentImageFileObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageDeltaContentImageFileObjectImageFileDetail)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageDeltaContentImageFileObjectImageFileDetail?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageDeltaContentImageUrlObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageDeltaContentImageUrlObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageDeltaContentImageUrlObjectImageUrlDetail)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageDeltaContentImageUrlObjectImageUrlDetail?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageDeltaContentRefusalObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageDeltaContentRefusalObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageDeltaContentTextObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageDeltaContentTextObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageDeltaObjectObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageDeltaObjectObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageDeltaObjectDeltaRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageDeltaObjectDeltaRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectIncompleteDetailsReason)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectIncompleteDetailsReason?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageStreamEventVariant1Event)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageStreamEventVariant1Event?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageStreamEventVariant2Event)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageStreamEventVariant2Event?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageStreamEventVariant3Event)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageStreamEventVariant3Event?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageStreamEventVariant4Event)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageStreamEventVariant4Event?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageStreamEventVariant5Event)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageStreamEventVariant5Event?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchemaType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchemaType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatTextType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatTextType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunObjectObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunObjectObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunObjectStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunObjectStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunObjectRequiredActionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunObjectRequiredActionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunObjectLastErrorCode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunObjectLastErrorCode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunObjectIncompleteDetailsReason)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunObjectIncompleteDetailsReason?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDeltaObjectObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDeltaObjectObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsMessageCreationObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsMessageCreationObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsMessageCreationObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsMessageCreationObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItemType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItemType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectLastErrorCode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectLastErrorCode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant1Event)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant1Event?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant2Event)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant2Event?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant3Event)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant3Event?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant4Event)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant4Event?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant5Event)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant5Event?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant6Event)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant6Event?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant7Event)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant7Event?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStreamEventVariant1Event)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStreamEventVariant1Event?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStreamEventVariant2Event)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStreamEventVariant2Event?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStreamEventVariant3Event)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStreamEventVariant3Event?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStreamEventVariant4Event)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStreamEventVariant4Event?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStreamEventVariant5Event)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStreamEventVariant5Event?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStreamEventVariant6Event)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStreamEventVariant6Event?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStreamEventVariant7Event)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStreamEventVariant7Event?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStreamEventVariant8Event)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStreamEventVariant8Event?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStreamEventVariant9Event)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStreamEventVariant9Event?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStreamEventVariant10Event)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunStreamEventVariant10Event?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunToolCallObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunToolCallObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ThreadObjectObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ThreadObjectObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ThreadStreamEventVariant1Event)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ThreadStreamEventVariant1Event?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TruncationObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TruncationObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsCodeType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantToolsCodeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsCodeType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantToolsCodeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantToolsFileSearchTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantToolsFileSearchTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnlyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantToolsFileSearchTypeOnlyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnlyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantToolsFileSearchTypeOnlyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsFunctionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantToolsFunctionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsFunctionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantToolsFunctionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantsApiResponseFormatOptionEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantsApiResponseFormatOptionEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantsApiResponseFormatOptionEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantsApiResponseFormatOptionEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantsApiToolChoiceOptionEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantsApiToolChoiceOptionEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantsApiToolChoiceOptionEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantsApiToolChoiceOptionEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantsNamedToolChoiceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantsNamedToolChoiceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantsNamedToolChoiceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantsNamedToolChoiceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DoneEventEvent))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DoneEventEventJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DoneEventEvent?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DoneEventEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DoneEventData))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DoneEventDataJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DoneEventData?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DoneEventDataNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ErrorEventEvent))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ErrorEventEventJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ErrorEventEvent?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ErrorEventEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchRanker))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileSearchRankerJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchRanker?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileSearchRankerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageFileObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentImageFileObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageFileObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentImageFileObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageFileObjectImageFileDetail))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentImageFileObjectImageFileDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageFileObjectImageFileDetail?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentImageFileObjectImageFileDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageUrlObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentImageUrlObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageUrlObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentImageUrlObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageUrlObjectImageUrlDetail))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentImageUrlObjectImageUrlDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageUrlObjectImageUrlDetail?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentImageUrlObjectImageUrlDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentRefusalObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentRefusalObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentRefusalObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentRefusalObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentTextAnnotationsFileCitationObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentTextAnnotationsFileCitationObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentTextAnnotationsFilePathObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentTextAnnotationsFilePathObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentTextObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentTextObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentTextObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentTextObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageDeltaContentImageFileObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageDeltaContentImageFileObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageDeltaContentImageFileObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageDeltaContentImageFileObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageDeltaContentImageFileObjectImageFileDetail))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageDeltaContentImageFileObjectImageFileDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageDeltaContentImageFileObjectImageFileDetail?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageDeltaContentImageFileObjectImageFileDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageDeltaContentImageUrlObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageDeltaContentImageUrlObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageDeltaContentImageUrlObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageDeltaContentImageUrlObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageDeltaContentImageUrlObjectImageUrlDetail))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageDeltaContentImageUrlObjectImageUrlDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageDeltaContentImageUrlObjectImageUrlDetail?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageDeltaContentImageUrlObjectImageUrlDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageDeltaContentRefusalObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageDeltaContentRefusalObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageDeltaContentRefusalObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageDeltaContentRefusalObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageDeltaContentTextAnnotationsFileCitationObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageDeltaContentTextAnnotationsFileCitationObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageDeltaContentTextAnnotationsFilePathObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageDeltaContentTextAnnotationsFilePathObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageDeltaContentTextObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageDeltaContentTextObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageDeltaContentTextObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageDeltaContentTextObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageDeltaObjectObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageDeltaObjectObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageDeltaObjectObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageDeltaObjectObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageDeltaObjectDeltaRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageDeltaObjectDeltaRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageDeltaObjectDeltaRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageDeltaObjectDeltaRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageObjectObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageObjectObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageObjectStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageObjectStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectIncompleteDetailsReason))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageObjectIncompleteDetailsReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectIncompleteDetailsReason?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageObjectIncompleteDetailsReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageObjectRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageObjectRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageStreamEventVariant1Event))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageStreamEventVariant1EventJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageStreamEventVariant1Event?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageStreamEventVariant1EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageStreamEventVariant2Event))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageStreamEventVariant2EventJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageStreamEventVariant2Event?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageStreamEventVariant2EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageStreamEventVariant3Event))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageStreamEventVariant3EventJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageStreamEventVariant3Event?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageStreamEventVariant3EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageStreamEventVariant4Event))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageStreamEventVariant4EventJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageStreamEventVariant4Event?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageStreamEventVariant4EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageStreamEventVariant5Event))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageStreamEventVariant5EventJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageStreamEventVariant5Event?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageStreamEventVariant5EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFormatJsonObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFormatJsonObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchemaType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFormatJsonSchemaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchemaType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFormatJsonSchemaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatTextType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFormatTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatTextType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFormatTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunObjectObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunObjectObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunObjectObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunObjectObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunObjectStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunObjectStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunObjectStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunObjectStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunObjectRequiredActionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunObjectRequiredActionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunObjectRequiredActionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunObjectRequiredActionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunObjectLastErrorCode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunObjectLastErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunObjectLastErrorCode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunObjectLastErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunObjectIncompleteDetailsReason))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunObjectIncompleteDetailsReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunObjectIncompleteDetailsReason?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunObjectIncompleteDetailsReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDeltaObjectObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDeltaObjectObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDeltaObjectObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDeltaObjectObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsMessageCreationObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDeltaStepDetailsMessageCreationObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsMessageCreationObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDeltaStepDetailsMessageCreationObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDeltaStepDetailsToolCallsFileSearchObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDeltaStepDetailsToolCallsFileSearchObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDeltaStepDetailsToolCallsFunctionObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDeltaStepDetailsToolCallsFunctionObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDeltaStepDetailsToolCallsObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDeltaStepDetailsToolCallsObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsMessageCreationObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsMessageCreationObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsMessageCreationObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsMessageCreationObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsCodeObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsCodeObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsCodeOutputImageObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsCodeOutputImageObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsCodeOutputLogsObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsCodeOutputLogsObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsFileSearchObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsFileSearchObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItemType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsFileSearchResultObjectContentItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItemType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsFileSearchResultObjectContentItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsFunctionObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsFunctionObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepObjectObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepObjectObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepObjectStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepObjectStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectLastErrorCode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepObjectLastErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepObjectLastErrorCode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepObjectLastErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant1Event))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepStreamEventVariant1EventJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant1Event?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepStreamEventVariant1EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant2Event))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepStreamEventVariant2EventJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant2Event?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepStreamEventVariant2EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant3Event))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepStreamEventVariant3EventJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant3Event?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepStreamEventVariant3EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant4Event))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepStreamEventVariant4EventJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant4Event?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepStreamEventVariant4EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant5Event))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepStreamEventVariant5EventJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant5Event?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepStreamEventVariant5EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant6Event))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepStreamEventVariant6EventJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant6Event?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepStreamEventVariant6EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant7Event))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepStreamEventVariant7EventJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant7Event?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStepStreamEventVariant7EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStreamEventVariant1Event))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStreamEventVariant1EventJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStreamEventVariant1Event?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStreamEventVariant1EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStreamEventVariant2Event))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStreamEventVariant2EventJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStreamEventVariant2Event?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStreamEventVariant2EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStreamEventVariant3Event))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStreamEventVariant3EventJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStreamEventVariant3Event?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStreamEventVariant3EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStreamEventVariant4Event))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStreamEventVariant4EventJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStreamEventVariant4Event?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStreamEventVariant4EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStreamEventVariant5Event))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStreamEventVariant5EventJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStreamEventVariant5Event?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStreamEventVariant5EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStreamEventVariant6Event))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStreamEventVariant6EventJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStreamEventVariant6Event?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStreamEventVariant6EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStreamEventVariant7Event))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStreamEventVariant7EventJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStreamEventVariant7Event?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStreamEventVariant7EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStreamEventVariant8Event))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStreamEventVariant8EventJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStreamEventVariant8Event?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStreamEventVariant8EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStreamEventVariant9Event))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStreamEventVariant9EventJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStreamEventVariant9Event?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStreamEventVariant9EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStreamEventVariant10Event))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStreamEventVariant10EventJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunStreamEventVariant10Event?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunStreamEventVariant10EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunToolCallObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunToolCallObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunToolCallObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunToolCallObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ThreadObjectObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ThreadObjectObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ThreadObjectObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ThreadObjectObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ThreadStreamEventVariant1Event))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ThreadStreamEventVariant1EventJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ThreadStreamEventVariant1Event?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ThreadStreamEventVariant1EventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TruncationObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TruncationObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TruncationObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TruncationObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MisalignmentErrorTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MisalignmentErrorTypeEnumNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.MessageObjectAttachmentsVariant1Item>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_3FE42C2578328F56(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_D8F74B0240BA31FB(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_3A58BB9D42C4A058(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageContentTextObject, global::tryAGI.OpenAI.MessageContentRefusalObject>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_CF7BCE1881F2875E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_D5B9B3D9DDAA8D01(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageDeltaContentImageFileObject, global::tryAGI.OpenAI.MessageDeltaContentTextObject, global::tryAGI.OpenAI.MessageDeltaContentRefusalObject, global::tryAGI.OpenAI.MessageDeltaContentImageUrlObject>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_2F275C432EDCB25F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_CE0D252E4BD23E4E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_C668B4EDEAC0FACF(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_5822DE0E0DD8174B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_9B381E90A4EF2D2B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_44E0CF8C6D74658C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObject>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_6F35DF7152C746AB(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_59122DCE4DA189AD(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RunToolCallObject>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_C250EA806C62157A(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_05BF36C073875770(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantStreamEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AssistantStreamEvent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantToolsCode))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AssistantToolsCode(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantToolsCodeType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AssistantToolsCodeType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantToolsFileSearch))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AssistantToolsFileSearch(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchFileSearch))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AssistantToolsFileSearchFileSearch(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AssistantToolsFileSearchType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AssistantToolsFileSearchTypeOnly(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnlyType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AssistantToolsFileSearchTypeOnlyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantToolsFunction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AssistantToolsFunction(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantToolsFunctionType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AssistantToolsFunctionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantsApiResponseFormatOption))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AssistantsApiResponseFormatOption(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantsApiResponseFormatOptionEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AssistantsApiResponseFormatOptionEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantsApiToolChoiceOption))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AssistantsApiToolChoiceOption(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantsApiToolChoiceOptionEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AssistantsApiToolChoiceOptionEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantsNamedToolChoice))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AssistantsNamedToolChoice(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantsNamedToolChoiceFunction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AssistantsNamedToolChoiceFunction(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantsNamedToolChoiceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AssistantsNamedToolChoiceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DoneEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_DoneEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DoneEventData))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_DoneEventData2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DoneEventEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_DoneEventEvent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Error))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Error(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ErrorEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ErrorEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ErrorEventEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ErrorEventEvent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FileSearchRanker))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FileSearchRanker2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FileSearchRankingOptions))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FileSearchRankingOptions(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FunctionObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionParameters))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FunctionParameters(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentImageFileObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageContentImageFileObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentImageFileObjectImageFile))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageContentImageFileObjectImageFile(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentImageFileObjectImageFileDetail))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageContentImageFileObjectImageFileDetail2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentImageFileObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageContentImageFileObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentImageUrlObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageContentImageUrlObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentImageUrlObjectImageUrl))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageContentImageUrlObjectImageUrl(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentImageUrlObjectImageUrlDetail))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageContentImageUrlObjectImageUrlDetail2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentImageUrlObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageContentImageUrlObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentRefusalObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageContentRefusalObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentRefusalObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageContentRefusalObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageContentTextAnnotationsFileCitationObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObjectFileCitation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageContentTextAnnotationsFileCitationObjectFileCitation(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageContentTextAnnotationsFileCitationObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageContentTextAnnotationsFilePathObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObjectFilePath))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageContentTextAnnotationsFilePathObjectFilePath(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageContentTextAnnotationsFilePathObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentTextObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageContentTextObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentTextObjectText))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageContentTextObjectText(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentTextObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageContentTextObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageDeltaContentImageFileObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageDeltaContentImageFileObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageDeltaContentImageFileObjectImageFile))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageDeltaContentImageFileObjectImageFile(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageDeltaContentImageFileObjectImageFileDetail))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageDeltaContentImageFileObjectImageFileDetail2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageDeltaContentImageFileObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageDeltaContentImageFileObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageDeltaContentImageUrlObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageDeltaContentImageUrlObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageDeltaContentImageUrlObjectImageUrl))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageDeltaContentImageUrlObjectImageUrl(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageDeltaContentImageUrlObjectImageUrlDetail))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageDeltaContentImageUrlObjectImageUrlDetail2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageDeltaContentImageUrlObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageDeltaContentImageUrlObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageDeltaContentRefusalObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageDeltaContentRefusalObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageDeltaContentRefusalObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageDeltaContentRefusalObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageDeltaContentTextAnnotationsFileCitationObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObjectFileCitation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageDeltaContentTextAnnotationsFileCitationObjectFileCitation(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageDeltaContentTextAnnotationsFileCitationObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageDeltaContentTextAnnotationsFilePathObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObjectFilePath))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageDeltaContentTextAnnotationsFilePathObjectFilePath(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageDeltaContentTextAnnotationsFilePathObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageDeltaContentTextObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageDeltaContentTextObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageDeltaContentTextObjectText))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageDeltaContentTextObjectText(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageDeltaContentTextObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageDeltaContentTextObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageDeltaObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageDeltaObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageDeltaObjectDelta))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageDeltaObjectDelta(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageDeltaObjectDeltaRole))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageDeltaObjectDeltaRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageDeltaObjectObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageDeltaObjectObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageObjectAttachmentsVariant1Item))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageObjectAttachmentsVariant1Item(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageObjectIncompleteDetails))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageObjectIncompleteDetails(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageObjectIncompleteDetailsReason))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageObjectIncompleteDetailsReason2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageObjectObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageObjectObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageObjectRole))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageObjectRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageObjectStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageObjectStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageStreamEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageStreamEvent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageStreamEventVariant1))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageStreamEventVariant1(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageStreamEventVariant1Event))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageStreamEventVariant1Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageStreamEventVariant2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageStreamEventVariant2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageStreamEventVariant2Event))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageStreamEventVariant2Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageStreamEventVariant3))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageStreamEventVariant3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageStreamEventVariant3Event))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageStreamEventVariant3Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageStreamEventVariant4))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageStreamEventVariant4(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageStreamEventVariant4Event))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageStreamEventVariant4Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageStreamEventVariant5))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageStreamEventVariant5(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageStreamEventVariant5Event))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageStreamEventVariant5Event2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_391B6DFC224EE298(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_147CF865EFF427B7(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageContentTextObject, global::tryAGI.OpenAI.MessageContentRefusalObject>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_2D42DE93E277A9C6(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_0548972A22EAD818(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageDeltaContentImageFileObject, global::tryAGI.OpenAI.MessageDeltaContentTextObject, global::tryAGI.OpenAI.MessageDeltaContentRefusalObject, global::tryAGI.OpenAI.MessageDeltaContentImageUrlObject>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_2B471C850E7DD060(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_FD0FA529A5386716(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDeltaStepDetailsMessageCreationObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsObject>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_AC0289420E8FEDE6(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_EA8E6D42B1B57F40(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_750AFA53706561EB(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsMessageCreationObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsObject>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_8E1A8F5656643B53(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_49B1EDE9A00410F7(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_455A7D8A948D2AD6(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ResponseFormatJsonObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseFormatJsonObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchema))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ResponseFormatJsonSchema(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchemaJsonSchema))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseFormatJsonSchemaJsonSchema(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchemaSchema))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseFormatJsonSchemaSchema(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchemaType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseFormatJsonSchemaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFormatText))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ResponseFormatText(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFormatTextType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseFormatTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunCompletionUsageVariant1))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunCompletionUsageVariant1(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RunObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunObjectIncompleteDetails))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunObjectIncompleteDetails(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunObjectIncompleteDetailsReason))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunObjectIncompleteDetailsReason2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunObjectLastError))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunObjectLastError(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunObjectLastErrorCode))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunObjectLastErrorCode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunObjectObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunObjectObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunObjectRequiredAction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunObjectRequiredAction(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunObjectRequiredActionSubmitToolOutputs))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunObjectRequiredActionSubmitToolOutputs(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunObjectRequiredActionType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunObjectRequiredActionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunObjectStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunObjectStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepCompletionUsageVariant1))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepCompletionUsageVariant1(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDeltaObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDeltaObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDeltaObjectDelta))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDeltaObjectDelta(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDeltaObjectObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDeltaObjectObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsMessageCreationObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDeltaStepDetailsMessageCreationObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsMessageCreationObjectMessageCreation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDeltaStepDetailsMessageCreationObjectMessageCreation(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsMessageCreationObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDeltaStepDetailsMessageCreationObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDeltaStepDetailsToolCallsCodeObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDeltaStepDetailsToolCallsCodeObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDeltaStepDetailsToolCallsCodeOutputImageObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDeltaStepDetailsToolCallsFileSearchObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDeltaStepDetailsToolCallsFileSearchObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDeltaStepDetailsToolCallsFunctionObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObjectFunction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDeltaStepDetailsToolCallsFunctionObjectFunction(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDeltaStepDetailsToolCallsFunctionObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDeltaStepDetailsToolCallsObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDeltaStepDetailsToolCallsObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsMessageCreationObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsMessageCreationObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsMessageCreationObjectMessageCreation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsMessageCreationObjectMessageCreation(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsMessageCreationObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsMessageCreationObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsToolCallsCodeObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObjectCodeInterpreter))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsToolCallsCodeObjectCodeInterpreter(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsToolCallsCodeObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsToolCallsCodeOutputImageObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObjectImage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsToolCallsCodeOutputImageObjectImage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsToolCallsCodeOutputImageObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsToolCallsCodeOutputLogsObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsToolCallsCodeOutputLogsObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsToolCallsFileSearchObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObjectFileSearch))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsToolCallsFileSearchObjectFileSearch(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsToolCallsFileSearchObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchRankingOptionsObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsToolCallsFileSearchRankingOptionsObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsToolCallsFileSearchResultObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsToolCallsFileSearchResultObjectContentItem(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItemType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsToolCallsFileSearchResultObjectContentItemType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsToolCallsFunctionObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObjectFunction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsToolCallsFunctionObjectFunction(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsToolCallsFunctionObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsToolCallsObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepDetailsToolCallsObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RunStepObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepObjectLastError))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepObjectLastError(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepObjectLastErrorCode))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepObjectLastErrorCode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepObjectObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepObjectObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepObjectStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepObjectStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepStreamEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RunStepStreamEvent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant1))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepStreamEventVariant1(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant1Event))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepStreamEventVariant1Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepStreamEventVariant2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant2Event))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepStreamEventVariant2Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant3))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepStreamEventVariant3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant3Event))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepStreamEventVariant3Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant4))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepStreamEventVariant4(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant4Event))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepStreamEventVariant4Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant5))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepStreamEventVariant5(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant5Event))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepStreamEventVariant5Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant6))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepStreamEventVariant6(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant6Event))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepStreamEventVariant6Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant7))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepStreamEventVariant7(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant7Event))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStepStreamEventVariant7Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStreamEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RunStreamEvent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStreamEventVariant1))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStreamEventVariant1(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStreamEventVariant10))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStreamEventVariant10(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStreamEventVariant10Event))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStreamEventVariant10Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStreamEventVariant1Event))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStreamEventVariant1Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStreamEventVariant2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStreamEventVariant2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStreamEventVariant2Event))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStreamEventVariant2Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStreamEventVariant3))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStreamEventVariant3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStreamEventVariant3Event))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStreamEventVariant3Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStreamEventVariant4))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStreamEventVariant4(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStreamEventVariant4Event))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStreamEventVariant4Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStreamEventVariant5))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStreamEventVariant5(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStreamEventVariant5Event))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStreamEventVariant5Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStreamEventVariant6))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStreamEventVariant6(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStreamEventVariant6Event))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStreamEventVariant6Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStreamEventVariant7))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStreamEventVariant7(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStreamEventVariant7Event))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStreamEventVariant7Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStreamEventVariant8))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStreamEventVariant8(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStreamEventVariant8Event))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStreamEventVariant8Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStreamEventVariant9))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStreamEventVariant9(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStreamEventVariant9Event))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunStreamEventVariant9Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunToolCallObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunToolCallObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunToolCallObjectFunction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunToolCallObjectFunction(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunToolCallObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunToolCallObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ThreadObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ThreadObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ThreadObjectObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ThreadObjectObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ThreadObjectToolResources))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ThreadObjectToolResources(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ThreadObjectToolResourcesCodeInterpreter))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ThreadObjectToolResourcesCodeInterpreter(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ThreadObjectToolResourcesFileSearch))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ThreadObjectToolResourcesFileSearch(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ThreadStreamEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ThreadStreamEvent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ThreadStreamEventVariant1))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ThreadStreamEventVariant1(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ThreadStreamEventVariant1Event))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ThreadStreamEventVariant1Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TruncationObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_TruncationObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TruncationObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_TruncationObjectType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.AssistantStreamEvent?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableAssistantStreamEvent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantToolsCodeType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableAssistantToolsCodeType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableAssistantToolsFileSearchType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnlyType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableAssistantToolsFileSearchTypeOnlyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantToolsFunctionType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableAssistantToolsFunctionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantsApiResponseFormatOptionEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableAssistantsApiResponseFormatOptionEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantsApiToolChoiceOptionEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableAssistantsApiToolChoiceOptionEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantsNamedToolChoiceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableAssistantsNamedToolChoiceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DoneEventData?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableDoneEventData2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DoneEventEvent?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableDoneEventEvent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ErrorEventEvent?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableErrorEventEvent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FileSearchRanker?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFileSearchRanker2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentImageFileObjectImageFileDetail?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageContentImageFileObjectImageFileDetail2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentImageFileObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageContentImageFileObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentImageUrlObjectImageUrlDetail?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageContentImageUrlObjectImageUrlDetail2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentImageUrlObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageContentImageUrlObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentRefusalObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageContentRefusalObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageContentTextAnnotationsFileCitationObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageContentTextAnnotationsFilePathObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentTextObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageContentTextObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageDeltaContentImageFileObjectImageFileDetail?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageDeltaContentImageFileObjectImageFileDetail2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageDeltaContentImageFileObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageDeltaContentImageFileObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageDeltaContentImageUrlObjectImageUrlDetail?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageDeltaContentImageUrlObjectImageUrlDetail2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageDeltaContentImageUrlObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageDeltaContentImageUrlObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageDeltaContentRefusalObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageDeltaContentRefusalObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageDeltaContentTextAnnotationsFileCitationObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageDeltaContentTextAnnotationsFilePathObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageDeltaContentTextObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageDeltaContentTextObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageDeltaObjectDeltaRole?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageDeltaObjectDeltaRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageDeltaObjectObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageDeltaObjectObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageObjectIncompleteDetailsReason?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageObjectIncompleteDetailsReason2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageObjectObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageObjectObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageObjectRole?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageObjectRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageObjectStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageObjectStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageStreamEvent?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableMessageStreamEvent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageStreamEventVariant1Event?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageStreamEventVariant1Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageStreamEventVariant2Event?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageStreamEventVariant2Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageStreamEventVariant3Event?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageStreamEventVariant3Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageStreamEventVariant4Event?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageStreamEventVariant4Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageStreamEventVariant5Event?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageStreamEventVariant5Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MisalignmentErrorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMisalignmentErrorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMisalignmentErrorTypeEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_6F16A1C0BFAC98A4(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_AB535EF066C32422(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageContentTextObject, global::tryAGI.OpenAI.MessageContentRefusalObject>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_27485E9BDDC32359(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_9598A82589CE8681(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageDeltaContentImageFileObject, global::tryAGI.OpenAI.MessageDeltaContentTextObject, global::tryAGI.OpenAI.MessageDeltaContentRefusalObject, global::tryAGI.OpenAI.MessageDeltaContentImageUrlObject>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_EECE817C31A7267F(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_7D99C0C54B4DA74B(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDeltaStepDetailsMessageCreationObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsObject>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_8D673BDA87416BC4(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_7CAEDE0A252B99A3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_CC64FB5AF93217C1(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsMessageCreationObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsObject>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_AEC54B1C23D248DA(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_A6F5CFDAABCB0602(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_052C8F0411FCBD3A(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseFormatJsonObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchemaType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseFormatJsonSchemaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFormatTextType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseFormatTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunObjectIncompleteDetailsReason?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunObjectIncompleteDetailsReason2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunObjectLastErrorCode?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunObjectLastErrorCode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunObjectObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunObjectObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunObjectRequiredActionType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunObjectRequiredActionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunObjectStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunObjectStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDeltaObjectObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStepDeltaObjectObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsMessageCreationObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStepDeltaStepDetailsMessageCreationObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStepDeltaStepDetailsToolCallsCodeObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStepDeltaStepDetailsToolCallsFileSearchObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStepDeltaStepDetailsToolCallsFunctionObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStepDeltaStepDetailsToolCallsObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsMessageCreationObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStepDetailsMessageCreationObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStepDetailsToolCallsCodeObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStepDetailsToolCallsCodeOutputImageObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStepDetailsToolCallsCodeOutputLogsObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStepDetailsToolCallsFileSearchObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItemType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStepDetailsToolCallsFileSearchResultObjectContentItemType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStepDetailsToolCallsFunctionObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStepDetailsToolCallsObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepObjectLastErrorCode?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStepObjectLastErrorCode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepObjectObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStepObjectObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepObjectStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStepObjectStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStepObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepStreamEvent?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableRunStepStreamEvent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant1Event?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStepStreamEventVariant1Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant2Event?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStepStreamEventVariant2Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant3Event?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStepStreamEventVariant3Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant4Event?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStepStreamEventVariant4Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant5Event?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStepStreamEventVariant5Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant6Event?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStepStreamEventVariant6Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepStreamEventVariant7Event?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStepStreamEventVariant7Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStreamEvent?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableRunStreamEvent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStreamEventVariant10Event?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStreamEventVariant10Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStreamEventVariant1Event?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStreamEventVariant1Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStreamEventVariant2Event?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStreamEventVariant2Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStreamEventVariant3Event?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStreamEventVariant3Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStreamEventVariant4Event?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStreamEventVariant4Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStreamEventVariant5Event?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStreamEventVariant5Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStreamEventVariant6Event?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStreamEventVariant6Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStreamEventVariant7Event?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStreamEventVariant7Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStreamEventVariant8Event?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStreamEventVariant8Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStreamEventVariant9Event?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunStreamEventVariant9Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunToolCallObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunToolCallObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ThreadObjectObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableThreadObjectObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ThreadStreamEvent?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableThreadStreamEvent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ThreadStreamEventVariant1Event?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableThreadStreamEventVariant1Event2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TruncationObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableTruncationObjectType2(options);
                }
                if (type == typeof(int?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.MessageObjectAttachmentsVariant1Item>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_D5912244E0C57F33(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_09B6433818FC3887(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_69D357B4B780866C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageContentTextObject, global::tryAGI.OpenAI.MessageContentRefusalObject>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_B16D73B6030086EE(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_EA34D21FA1806FE1(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageDeltaContentImageFileObject, global::tryAGI.OpenAI.MessageDeltaContentTextObject, global::tryAGI.OpenAI.MessageDeltaContentRefusalObject, global::tryAGI.OpenAI.MessageDeltaContentImageUrlObject>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_977C93B2BD28B37B(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_EADD652FDD482D3E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_7AF2DCCB43023FB3(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_BB09FE96F1D5C7F3(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_9863C93CDA017189(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject, global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_B2E9EE125890D0B8(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObject>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_A45605418757433E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_00FEBFDCAC0FD86D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RunToolCallObject>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_6BC2955694967327(options);
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