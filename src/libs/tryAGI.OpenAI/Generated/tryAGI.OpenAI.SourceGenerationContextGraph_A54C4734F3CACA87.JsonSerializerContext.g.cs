
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_A54C4734F3CACA87 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_A54C4734F3CACA87 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_A54C4734F3CACA87(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.FiltersItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ToolJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.Filters2JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.NetworkPolicy2JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.NetworkPolicy3JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.SkillsItem2JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.EnvironmentVariant1JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.Format2JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ToolsItem13JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::tryAGI.OpenAI.AutoCodeInterpreterToolParam>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.ImageGenToolModel?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.ImageGenToolSize?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, global::tryAGI.OpenAI.MCPToolFilter>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum, global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2?>());
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

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComparisonFilterType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComparisonFilterType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CompoundFilterType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CompoundFilterType?)

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

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolConnectorId)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolConnectorId?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchApproximateLocationWebSearchApproximateLocation1Type)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchApproximateLocationWebSearchApproximateLocation1Type?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchToolSearchContextSize)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchToolSearchContextSize?)

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

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenActionEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenActionEnum?)

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

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolParamType?);
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolDiscriminatorTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenActionEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenActionEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenActionEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenActionEnumNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContainerNetworkPolicyDomainSecretParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_57C01D3546E0935C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FiltersItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_33EE83DB0267626E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LocalSkillParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_BCC356108F578405(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_A588C663D689201D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SearchContentType>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_5D0601242F2C095C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillsItem2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_47F7021679FC8889(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Tool>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_D5D517C0FFB4C526(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem13>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_2FEB8A1A70F07854(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_05BF36C073875770(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenToolModel?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_9E5A4F0B6EBF35BC(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenToolSize?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_571EE018EA62AAA5(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchToolParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchToolParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchToolParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ApplyPatchToolParamType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.CodeInterpreterTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CodeInterpreterTool(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CodeInterpreterToolType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CodeInterpreterToolType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.ComputerEnvironment))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ComputerEnvironment2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ComputerTool(options);
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
                if (type == typeof(global::tryAGI.OpenAI.EmptyModelParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_EmptyModelParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentVariant1))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_EnvironmentVariant1(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FileSearchTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FileSearchTool(options);
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
                if (type == typeof(global::tryAGI.OpenAI.HybridSearchOptions))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HybridSearchOptions(options);
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
                if (type == typeof(global::tryAGI.OpenAI.LocalEnvironmentParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LocalEnvironmentParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LocalEnvironmentParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LocalEnvironmentParamType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.AutoCodeInterpreterToolParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_5A33374B4B36D875(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ProgrammaticToolCallingParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ProgrammaticToolCallingParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ProgrammaticToolCallingParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ProgrammaticToolCallingParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RankerVersionType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RankerVersionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RankingOptions))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RankingOptions(options);
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
                if (type == typeof(global::tryAGI.OpenAI.Tool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Tool2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolSearchExecutionType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolSearchExecutionType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.WebSearchApproximateLocationWebSearchApproximateLocation1))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebSearchApproximateLocationWebSearchApproximateLocation1(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchApproximateLocationWebSearchApproximateLocation1Type))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WebSearchApproximateLocationWebSearchApproximateLocation1Type2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenToolModel?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_ABEA0F8B3FC57D87(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenToolSize?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_1BD7EE6D21EC0B36(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ApplyPatchToolParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableApplyPatchToolParamType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.CodeInterpreterToolType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableCodeInterpreterToolType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComparisonFilterType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableComparisonFilterType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CompoundFilterType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableCompoundFilterType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerEnvironment?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableComputerEnvironment2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.CustomToolParamFormatDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCustomToolParamFormatDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CustomToolParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCustomToolParamType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellToolParamEnvironmentVariant1DiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionShellToolParamEnvironmentVariant1DiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionShellToolParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionShellToolParamType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.ImageGenActionEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableImageGenActionEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageGenToolBackground?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableImageGenToolBackground2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.LocalEnvironmentParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLocalEnvironmentParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LocalShellToolParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableLocalShellToolParamType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.AutoCodeInterpreterToolParam>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_A6CAFCBC284F6CBF(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ProgrammaticToolCallingParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableProgrammaticToolCallingParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RankerVersionType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRankerVersionType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.Tool?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableTool2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableToolDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolSearchExecutionType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableToolSearchExecutionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolSearchToolParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableToolSearchToolParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolsItem13?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableToolsItem132(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchApproximateLocationWebSearchApproximateLocation1Type?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebSearchApproximateLocationWebSearchApproximateLocation1Type2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchPreviewToolType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebSearchPreviewToolType2(options);
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
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CallableToolAllowedCaller>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_A0102E6B0439FF50(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContainerNetworkPolicyDomainSecretParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_69576CBB03C474C7(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.FiltersItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_383909F143B415B3(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.LocalSkillParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_06798C455CA03120(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<string, double?>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_E3941FEAF2607AE9(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.SearchContentType>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_0FCB0A1DE07E374A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.SkillsItem2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_A5032DE1023BA797(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Tool>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_89AB6A7CC2C92D2F(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ToolsItem13>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_238639EE132A2722(options);
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