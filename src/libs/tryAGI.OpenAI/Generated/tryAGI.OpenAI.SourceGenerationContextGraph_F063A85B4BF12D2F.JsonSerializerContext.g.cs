
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_F063A85B4BF12D2F : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_F063A85B4BF12D2F Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_F063A85B4BF12D2F(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ConversationParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.FunctionAndCustomToolCallOutputJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.InputContentJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.InputItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.MCPToolCallErrorJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OutputMessageContentJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.TextResponseFormatConfigurationJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ToolJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ToolChoiceParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ToolSearchOutputToolJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.WebSearchToolCallActionJsonConverter());
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OutputVariant2ItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ToolsItem14JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.EnvironmentVariant13JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputOutcomeParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ApplyPatchOperationParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ReasoningModeEnumJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.PersonalityEnumJsonConverter());
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.ImageGenToolCallSizeVariant1?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>>());
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

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatTextType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatTextType?)

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

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParamMode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParamMode?)

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

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DirectToolCallCallerParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DirectToolCallCallerParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProgramToolCallCallerParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProgramToolCallCallerParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolCallCallerParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolCallCallerParamDiscriminatorType?)

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

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchExecutionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchExecutionType?)

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

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterOutputLogsType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterOutputLogsType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterOutputImageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterOutputImageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellExecActionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellExecActionType?)

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

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningModeEnumEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningModeEnumEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TruncationEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TruncationEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersonalityEnumEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersonalityEnumEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TokenCountsResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TokenCountsResourceObject?);
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseConfigurationUpdateItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseConfigurationUpdateItemParamTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParamMode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheBreakpointParamModeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParamMode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheBreakpointParamModeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchExecutionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolSearchExecutionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchExecutionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolSearchExecutionTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningModeEnumEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningModeEnumEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningModeEnumEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningModeEnumEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TruncationEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TruncationEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TruncationEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TruncationEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersonalityEnumEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersonalityEnumEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersonalityEnumEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersonalityEnumEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TokenCountsResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TokenCountsResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TokenCountsResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TokenCountsResourceObjectNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionShellCallOutputContentParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_ECFF433A88839BCC(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContent>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_3761A4CD1A5F3989(options);
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
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchCallOutputStatusParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchCallOutputStatusParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchCallStatusParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchCallStatusParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchCreateFileOperationParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchCreateFileOperationParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchDeleteFileOperationParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchDeleteFileOperationParamType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallItemParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ApplyPatchToolCallItemParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallItemParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchToolCallItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ApplyPatchToolCallOutputItemParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchToolCallOutputItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchToolParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchToolParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchToolParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchUpdateFileOperationParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchUpdateFileOperationParamType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentVariant13))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_EnvironmentVariant13(options);
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
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellActionParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionShellActionParam(options);
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
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputContentParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionShellCallOutputContentParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionShellCallOutputExitOutcomeParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionShellCallOutputExitOutcomeParamType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionShellCallOutputTimeoutOutcomeParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionShellCallOutputTimeoutOutcomeParamType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.PersonalityEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_PersonalityEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersonalityEnumEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_PersonalityEnumEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ProgramItemParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ProgramItemParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ProgramItemParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ProgramItemParamType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.ResponseTextParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseTextParam(options);
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
                if (type == typeof(global::tryAGI.OpenAI.TokenCountsBody))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_TokenCountsBody(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TokenCountsResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_TokenCountsResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TokenCountsResourceObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_TokenCountsResourceObject2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.ToolSearchCallItemParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ToolSearchCallItemParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolSearchCallItemParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolSearchCallItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolSearchExecutionType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolSearchExecutionType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.TruncationEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_TruncationEnum2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchCallOutputStatusParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableApplyPatchCallOutputStatusParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchCallStatusParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableApplyPatchCallStatusParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableApplyPatchCreateFileOperationParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableApplyPatchDeleteFileOperationParamType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableApplyPatchToolCallOutputItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchToolParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableApplyPatchToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableApplyPatchUpdateFileOperationParamType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.ComputerEnvironment?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableComputerEnvironment2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerScreenshotImageType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableComputerScreenshotImageType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.CustomGrammarFormatParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCustomGrammarFormatParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CustomTextFormatParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCustomTextFormatParamType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionShellCallOutputExitOutcomeParamType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionShellCallOutputTimeoutOutcomeParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellToolParamEnvironmentVariant1DiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionShellToolParamEnvironmentVariant1DiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellToolParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionShellToolParamType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.PersonalityEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePersonalityEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersonalityEnumEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePersonalityEnumEnum2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.ProgramToolCallCallerParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableProgramToolCallCallerParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ProgramToolCallCallerType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableProgramToolCallCallerType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseConfigurationUpdateItemParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseFormatJsonObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseFormatTextType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseFormatTextType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.TokenCountsResourceObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableTokenCountsResourceObject2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.TruncationEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableTruncationEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TypeParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableTypeParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UrlCitationBodyType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableUrlCitationBodyType2(options);
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
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.FunctionShellCallOutputContentParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_F609CF755DE0CE12(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputContent>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_D329C732E3FE4C05(options);
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