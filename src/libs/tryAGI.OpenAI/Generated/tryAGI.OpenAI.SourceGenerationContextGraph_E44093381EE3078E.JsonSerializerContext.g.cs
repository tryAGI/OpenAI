
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_E44093381EE3078E : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_E44093381EE3078E Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_E44093381EE3078E(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.HostedSkillParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.HostedPluginParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.TextFormatParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.McpTransportConfigParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AgentToolConfigParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.EnvironmentParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.InputContentParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.CreateSessionInputParamJsonConverter());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.NetworkAccessParam)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.NetworkAccessParam?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillParamSkillReferenceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillParamSkillReferenceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64Type)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64Type?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64MediaType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64MediaType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillParamInlineType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillParamInlineType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginParamInlineType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginParamInlineType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamFileIdType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamFileIdType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamInlineType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamInlineType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortParam)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortParam?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningSummaryParam)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningSummaryParam?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatParamTextType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatParamTextType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatParamJsonSchemaType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatParamJsonSchemaType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VerbosityParam)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VerbosityParam?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ServiceTierParam)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ServiceTierParam?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpConnectionOriginParam)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpConnectionOriginParam?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchModeParam)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchModeParam?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchContextSizeParam)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchContextSizeParam?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamFunctionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamFunctionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamToolSearchType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamToolSearchType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCallingType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCallingType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportConfigParamHttpType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportConfigParamHttpType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportConfigParamStdioType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportConfigParamStdioType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportConfigParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportConfigParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamMcpType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamMcpType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamWebSearchType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamWebSearchType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamComputerUseType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamComputerUseType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentParamNoneType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentParamNoneType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerSizeParam)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerSizeParam?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentParamOpenaiHostedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentParamOpenaiHostedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentParamSelfHostedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentParamSelfHostedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputContentParamInputTextType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputContentParamInputTextType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputContentParamInputImageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputContentParamInputImageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputContentParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputContentParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageParamRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageParamRole?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.NetworkAccessParam))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.NetworkAccessParamJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.NetworkAccessParam?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.NetworkAccessParamNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillParamSkillReferenceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedSkillParamSkillReferenceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillParamSkillReferenceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedSkillParamSkillReferenceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64Type))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InlineCapabilitySourceParamBase64TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64Type?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InlineCapabilitySourceParamBase64TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64MediaType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InlineCapabilitySourceParamBase64MediaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64MediaType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InlineCapabilitySourceParamBase64MediaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillParamInlineType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedSkillParamInlineTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillParamInlineType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedSkillParamInlineTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedSkillParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedSkillParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginParamInlineType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedPluginParamInlineTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginParamInlineType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedPluginParamInlineTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedPluginParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedPluginParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamFileIdType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileParamFileIdTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamFileIdType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileParamFileIdTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamInlineType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileParamInlineTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamInlineType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileParamInlineTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortParam))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningEffortParamJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortParam?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningEffortParamNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningSummaryParam))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningSummaryParamJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningSummaryParam?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningSummaryParamNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatParamTextType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TextFormatParamTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatParamTextType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TextFormatParamTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatParamJsonSchemaType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TextFormatParamJsonSchemaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatParamJsonSchemaType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TextFormatParamJsonSchemaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TextFormatParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TextFormatParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VerbosityParam))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VerbosityParamJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VerbosityParam?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VerbosityParamNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ServiceTierParam))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ServiceTierParamJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ServiceTierParam?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ServiceTierParamNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpConnectionOriginParam))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpConnectionOriginParamJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpConnectionOriginParam?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpConnectionOriginParamNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchModeParam))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchModeParamJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchModeParam?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchModeParamNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchContextSizeParam))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchContextSizeParamJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchContextSizeParam?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchContextSizeParamNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamFunctionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolConfigParamFunctionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamFunctionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolConfigParamFunctionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamToolSearchType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolConfigParamToolSearchTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamToolSearchType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolConfigParamToolSearchTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCallingType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolConfigParamProgrammaticToolCallingTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCallingType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolConfigParamProgrammaticToolCallingTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportConfigParamHttpType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpTransportConfigParamHttpTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportConfigParamHttpType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpTransportConfigParamHttpTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportConfigParamStdioType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpTransportConfigParamStdioTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportConfigParamStdioType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpTransportConfigParamStdioTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportConfigParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpTransportConfigParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportConfigParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpTransportConfigParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamMcpType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolConfigParamMcpTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamMcpType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolConfigParamMcpTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamWebSearchType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolConfigParamWebSearchTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamWebSearchType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolConfigParamWebSearchTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamComputerUseType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolConfigParamComputerUseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamComputerUseType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolConfigParamComputerUseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolConfigParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolConfigParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentParamNoneType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentParamNoneTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentParamNoneType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentParamNoneTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerSizeParam))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerSizeParamJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerSizeParam?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerSizeParamNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentParamOpenaiHostedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentParamOpenaiHostedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentParamOpenaiHostedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentParamOpenaiHostedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentParamSelfHostedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentParamSelfHostedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentParamSelfHostedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentParamSelfHostedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputContentParamInputTextType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputContentParamInputTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputContentParamInputTextType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputContentParamInputTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputContentParamInputImageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputContentParamInputImageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputContentParamInputImageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputContentParamInputImageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputContentParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputContentParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputContentParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputContentParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputMessageParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputMessageParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageParamRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputMessageParamRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageParamRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputMessageParamRoleNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AgentToolConfigParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_170AA28C3B5DB6B1(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedEnvironmentFileParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_16FADF073CF5508D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedPluginParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_570D214C9DAAFB74(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedSkillParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_C5B170C97F2CD10B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContentParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_55685EC92864462C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputMessageParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_3240AB93DF1B16D6(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SetupCommandParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_014ADB54F81B220E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_05BF36C073875770(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolConfigParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_AgentToolConfigParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolConfigParamComputerUse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_AgentToolConfigParamComputerUse(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolConfigParamComputerUseType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_AgentToolConfigParamComputerUseType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolConfigParamDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_AgentToolConfigParamDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolConfigParamDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_AgentToolConfigParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolConfigParamFunction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_AgentToolConfigParamFunction(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolConfigParamFunctionType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_AgentToolConfigParamFunctionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolConfigParamMcp))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_AgentToolConfigParamMcp(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolConfigParamMcpType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_AgentToolConfigParamMcpType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCalling))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_AgentToolConfigParamProgrammaticToolCalling(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCallingType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_AgentToolConfigParamProgrammaticToolCallingType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolConfigParamToolSearch))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_AgentToolConfigParamToolSearch(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolConfigParamToolSearchType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_AgentToolConfigParamToolSearchType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolConfigParamWebSearch))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_AgentToolConfigParamWebSearch(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolConfigParamWebSearchType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_AgentToolConfigParamWebSearchType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContainerSizeParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_ContainerSizeParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateAgentSessionParams))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_CreateAgentSessionParams(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateSessionInputParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_CreateSessionInputParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DesktopParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DesktopParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentPackagesParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_EnvironmentPackagesParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_EnvironmentParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentParamDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_EnvironmentParamDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentParamDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_EnvironmentParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentParamNone))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_EnvironmentParamNone(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentParamNoneType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_EnvironmentParamNoneType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentParamOpenaiHosted))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_EnvironmentParamOpenaiHosted(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentParamOpenaiHostedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_EnvironmentParamOpenaiHostedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentParamSelfHosted))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_EnvironmentParamSelfHosted(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentParamSelfHostedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_EnvironmentParamSelfHostedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedEnvironmentFileParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedEnvironmentFileParamDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedEnvironmentFileParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamFileId))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedEnvironmentFileParamFileId(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamFileIdType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedEnvironmentFileParamFileIdType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamInline))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedEnvironmentFileParamInline(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamInlineType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedEnvironmentFileParamInlineType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedPluginParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedPluginParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedPluginParamDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedPluginParamDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedPluginParamDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedPluginParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedPluginParamInline))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedPluginParamInline(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedPluginParamInlineType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedPluginParamInlineType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedSkillParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillParamDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedSkillParamDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillParamDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedSkillParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillParamInline))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedSkillParamInline(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillParamInlineType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedSkillParamInlineType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillParamSkillReference))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedSkillParamSkillReference(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillParamSkillReferenceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedSkillParamSkillReferenceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InlineCapabilitySourceParamBase64(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64MediaType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InlineCapabilitySourceParamBase64MediaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64Type))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InlineCapabilitySourceParamBase64Type2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContentParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_InputContentParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContentParamDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_InputContentParamDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContentParamDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_InputContentParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContentParamInputImage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_InputContentParamInputImage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContentParamInputImageType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_InputContentParamInputImageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContentParamInputText))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_InputContentParamInputText(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContentParamInputTextType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_InputContentParamInputTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputMessageParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_InputMessageParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputMessageParamRole))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_InputMessageParamRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputMessageParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_InputMessageParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpConnectionOriginParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_McpConnectionOriginParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpTransportConfigParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_McpTransportConfigParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpTransportConfigParamDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_McpTransportConfigParamDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpTransportConfigParamDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_McpTransportConfigParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpTransportConfigParamHttp))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_McpTransportConfigParamHttp(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpTransportConfigParamHttpType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_McpTransportConfigParamHttpType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpTransportConfigParamStdio))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_McpTransportConfigParamStdio(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpTransportConfigParamStdioType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_McpTransportConfigParamStdioType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MultiAgentConfigCurrentParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_MultiAgentConfigCurrentParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.NetworkAccessParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_NetworkAccessParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.NetworkPolicyParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_NetworkPolicyParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningEffortParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_ReasoningEffortParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_ReasoningParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningSummaryParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_ReasoningSummaryParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ServiceTierParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_ServiceTierParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionAgentConfigParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SessionAgentConfigParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SetupCommandParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SetupCommandParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TextFormatParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_TextFormatParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TextFormatParamDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_TextFormatParamDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TextFormatParamDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_TextFormatParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TextFormatParamJsonSchema))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_TextFormatParamJsonSchema(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TextFormatParamJsonSchemaType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_TextFormatParamJsonSchemaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TextFormatParamText))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_TextFormatParamText(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TextFormatParamTextType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_TextFormatParamTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TextParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_TextParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VerbosityParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_VerbosityParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchContextSizeParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_WebSearchContextSizeParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchLocationParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_WebSearchLocationParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchModeParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_WebSearchModeParam2(options);
                }
                if (type == typeof(long))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Int64(options);
                }
                if (type == typeof(bool?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableBoolean(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolConfigParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAgentToolConfigParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolConfigParamComputerUseType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAgentToolConfigParamComputerUseType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolConfigParamDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAgentToolConfigParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolConfigParamFunctionType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAgentToolConfigParamFunctionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolConfigParamMcpType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAgentToolConfigParamMcpType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCallingType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAgentToolConfigParamProgrammaticToolCallingType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolConfigParamToolSearchType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAgentToolConfigParamToolSearchType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolConfigParamWebSearchType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAgentToolConfigParamWebSearchType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContainerSizeParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableContainerSizeParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableEnvironmentParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentParamDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableEnvironmentParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentParamNoneType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableEnvironmentParamNoneType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentParamOpenaiHostedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableEnvironmentParamOpenaiHostedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentParamSelfHostedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableEnvironmentParamSelfHostedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedEnvironmentFileParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedEnvironmentFileParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamFileIdType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedEnvironmentFileParamFileIdType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamInlineType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedEnvironmentFileParamInlineType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedPluginParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedPluginParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedPluginParamDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedPluginParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedPluginParamInlineType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedPluginParamInlineType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedSkillParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillParamDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedSkillParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillParamInlineType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedSkillParamInlineType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillParamSkillReferenceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedSkillParamSkillReferenceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64MediaType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInlineCapabilitySourceParamBase64MediaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64Type?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInlineCapabilitySourceParamBase64Type2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContentParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInputContentParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContentParamDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInputContentParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContentParamInputImageType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInputContentParamInputImageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContentParamInputTextType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInputContentParamInputTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputMessageParamRole?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInputMessageParamRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputMessageParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInputMessageParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpConnectionOriginParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMcpConnectionOriginParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpTransportConfigParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMcpTransportConfigParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpTransportConfigParamDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMcpTransportConfigParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpTransportConfigParamHttpType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMcpTransportConfigParamHttpType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpTransportConfigParamStdioType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMcpTransportConfigParamStdioType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.NetworkAccessParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableNetworkAccessParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningEffortParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableReasoningEffortParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningSummaryParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableReasoningSummaryParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ServiceTierParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableServiceTierParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TextFormatParamDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableTextFormatParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TextFormatParamJsonSchemaType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableTextFormatParamJsonSchemaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TextFormatParamTextType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableTextFormatParamTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VerbosityParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableVerbosityParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchContextSizeParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebSearchContextSizeParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchModeParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebSearchModeParam2(options);
                }
                if (type == typeof(long?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt64(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.AgentToolConfigParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_78FF751704943B52(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedEnvironmentFileParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_C0598021B65A2040(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedPluginParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_D8E6CD18752D4032(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedSkillParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_ECB76628EE8F6046(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputContentParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_E6BC49CE6B1EA748(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputMessageParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_720FF0DF3D3792F8(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.SetupCommandParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_2690B46C57642571(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_3F34DBFD50DE05D2(options);
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