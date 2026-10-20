
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_60214213BDD7B0F0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_60214213BDD7B0F0 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_60214213BDD7B0F0(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ConversationItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.FunctionAndCustomToolCallOutputJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.FunctionToolCallOutputResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.FunctionToolCallResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.MCPToolCallErrorJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ToolJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.WebSearchToolCallActionJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnnotationJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ContentItem3JsonConverter());
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::tryAGI.OpenAI.AutoCodeInterpreterToolParam>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.ImageGenToolModel?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.ImageGenToolSize?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, global::tryAGI.OpenAI.MCPToolFilter>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum, global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.ImageGenToolCallSizeVariant1?>());
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

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ConversationItemDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ConversationItemDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolCallOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolCallOutputType?)

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

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningItemType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningItemType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningItemStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningItemStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolDiscriminatorType?)

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

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageStatus?)

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

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TextContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TextContentType?)

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

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerScreenshotContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerScreenshotContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileInputDetail)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileInputDetail?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputFileContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputFileContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessagePhase2)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessagePhase2?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentItemDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentItemDiscriminatorType?)

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

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolCallStatus?);
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ConversationItemDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ConversationItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ConversationItemDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ConversationItemDiscriminatorTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseConfigurationUpdateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseConfigurationUpdateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolDiscriminatorTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageStatusNullableJsonConverter();
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TextContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TextContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TextContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TextContentTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerScreenshotContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerScreenshotContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerScreenshotContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerScreenshotContentTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessagePhase2))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessagePhase2JsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessagePhase2?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessagePhase2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentItemDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentItemDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentItemDiscriminatorTypeNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem3>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_5A311FE2BCB8A5BD(options);
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
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem13>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_2FEB8A1A70F07854(options);
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
                if (type == typeof(global::System.Collections.Generic.IList<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_05BF36C073875770(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AdditionalTools))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AdditionalTools(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AdditionalToolsType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AdditionalToolsType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchCallStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchCreateFileOperation(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperationType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchCreateFileOperationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchDeleteFileOperation(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchDeleteFileOperationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchToolCall))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ApplyPatchToolCall(options);
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
                if (type == typeof(global::tryAGI.OpenAI.ComputerScreenshotContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ComputerScreenshotContent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerScreenshotContentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ComputerScreenshotContentType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.ContentItem3))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ContentItem32(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ConversationItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ConversationItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ConversationItemDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ConversationItemDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ConversationItemDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ConversationItemDiscriminatorType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.FileCitationBody))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FileCitationBody(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FileCitationBodyType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FileCitationBodyType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcome))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionShellCallOutputExitOutcome(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionShellCallOutputExitOutcomeType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputStatusEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionShellCallOutputStatusEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcome))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionShellCallOutputTimeoutOutcome(options);
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
                if (type == typeof(global::tryAGI.OpenAI.FunctionToolCallResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FunctionToolCallResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionToolCallResourceVariant2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FunctionToolCallResourceVariant2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.InputFidelity))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InputFidelity2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputFileContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InputFileContent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputFileContentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InputFileContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputImageContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InputImageContent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputImageContentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InputImageContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputTextContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InputTextContent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputTextContentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InputTextContentType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.MCPApprovalResponseResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MCPApprovalResponseResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MCPApprovalResponseResourceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MCPApprovalResponseResourceType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.Message))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Message(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentItemDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_MessageContentItemDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentItemDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_MessageContentItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessagePhase2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_MessagePhase22(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageRole))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_MessageRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_MessageStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_MessageType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.OutputTextContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_OutputTextContent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputTextContentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_OutputTextContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputsVariant1Item))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_OutputsVariant1Item2_3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Program))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Program(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ProgramOutput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ProgramOutput(options);
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
                if (type == typeof(global::tryAGI.OpenAI.RankerVersionType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RankerVersionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RankingOptions))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RankingOptions(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ReasoningEffortEnum2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdate))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ResponseConfigurationUpdate(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateReasoning))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseConfigurationUpdateReasoning(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseConfigurationUpdateType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.SummaryTextContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SummaryTextContent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SummaryTextContentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SummaryTextContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TextContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_TextContent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TextContentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_TextContentType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.AdditionalToolsType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAdditionalToolsType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchCallStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableApplyPatchCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperationType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableApplyPatchCreateFileOperationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableApplyPatchDeleteFileOperationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOperationDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableApplyPatchToolCallOperationDiscriminatorType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.ComputerCallOutputStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableComputerCallOutputStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerEnvironment?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableComputerEnvironment2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerScreenshotContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableComputerScreenshotContentType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.ContentItem3?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableContentItem32(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ConversationItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableConversationItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ConversationItemDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableConversationItemDiscriminatorType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.FileCitationBodyType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFileCitationBodyType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputContentOutcomeDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionShellCallOutputContentOutcomeDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionShellCallOutputExitOutcomeType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputStatusEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionShellCallOutputStatusEnum2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.FunctionToolCallResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableFunctionToolCallResource2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.InputFidelity?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInputFidelity2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputFileContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInputFileContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputImageContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInputImageContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputTextContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInputTextContentType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.MessageContentItemDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageContentItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessagePhase2?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessagePhase22(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageRole?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.OutputTextContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableOutputTextContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputsVariant1Item?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableOutputsVariant1Item2_3(options);
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
                if (type == typeof(global::tryAGI.OpenAI.RankerVersionType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRankerVersionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableReasoningEffortEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningItemStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableReasoningItemStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningItemType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableReasoningItemType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningTextContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableReasoningTextContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RefusalContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRefusalContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseConfigurationUpdateType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.SummaryTextContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableSummaryTextContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TextContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableTextContentType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.ToolDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableToolDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolSearchCallType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableToolSearchCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolSearchExecutionType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableToolSearchExecutionType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.TypeParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableTypeParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UrlCitationBodyType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableUrlCitationBodyType2(options);
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
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentItem3>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_0DE2018244138BB8(options);
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
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ToolsItem13>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_238639EE132A2722(options);
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