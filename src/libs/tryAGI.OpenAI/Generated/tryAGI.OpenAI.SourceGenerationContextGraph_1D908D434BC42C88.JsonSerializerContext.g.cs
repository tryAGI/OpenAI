
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_1D908D434BC42C88 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_1D908D434BC42C88 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_1D908D434BC42C88(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.HostedSkillResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.HostedPluginResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.TextFormatResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalRequestKindResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.SessionRequiredActionResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.McpTransportResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AgentToolResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.EnvironmentResourceJsonConverter());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileIdType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileIdType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceInlineType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceInlineType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillResourceSkillReferenceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillResourceSkillReferenceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillResourceInlineType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillResourceInlineType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginResourceInlineType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginResourceInlineType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningSummaryResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningSummaryResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatResourceTextType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatResourceTextType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatResourceJsonSchemaType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatResourceJsonSchemaType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VerbosityResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VerbosityResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ServiceTierResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ServiceTierResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpConnectionOriginResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpConnectionOriginResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchModeResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchModeResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchContextSizeResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchContextSizeResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.NetworkAccessResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.NetworkAccessResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionStatusResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionStatusResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserAuthenticationType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserAuthenticationType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccessType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccessType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceComputerUseApprovalRequestType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceComputerUseApprovalRequestType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnectionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnectionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceFunctionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceFunctionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCallingType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCallingType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportResourceHttpType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportResourceHttpType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportResourceStdioType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportResourceStdioType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceMcpType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceMcpType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceWebSearchType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceWebSearchType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceComputerUseType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceComputerUseType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentResourceNoneType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentResourceNoneType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerSizeResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerSizeResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentResourceOpenaiHostedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentResourceOpenaiHostedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentResourceSelfHostedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentResourceSelfHostedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionResourceObject?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileIdType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileResourceFileIdTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileIdType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileResourceFileIdTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceInlineType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileResourceInlineTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceInlineType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileResourceInlineTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillResourceSkillReferenceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedSkillResourceSkillReferenceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillResourceSkillReferenceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedSkillResourceSkillReferenceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillResourceInlineType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedSkillResourceInlineTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillResourceInlineType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedSkillResourceInlineTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedSkillResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedSkillResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginResourceInlineType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedPluginResourceInlineTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginResourceInlineType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedPluginResourceInlineTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedPluginResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedPluginResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningEffortResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningEffortResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningSummaryResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningSummaryResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningSummaryResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningSummaryResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatResourceTextType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TextFormatResourceTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatResourceTextType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TextFormatResourceTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatResourceJsonSchemaType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TextFormatResourceJsonSchemaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatResourceJsonSchemaType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TextFormatResourceJsonSchemaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TextFormatResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TextFormatResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VerbosityResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VerbosityResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VerbosityResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VerbosityResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ServiceTierResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ServiceTierResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ServiceTierResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ServiceTierResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpConnectionOriginResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpConnectionOriginResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpConnectionOriginResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpConnectionOriginResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchModeResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchModeResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchModeResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchModeResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchContextSizeResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchContextSizeResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchContextSizeResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchContextSizeResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.NetworkAccessResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.NetworkAccessResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.NetworkAccessResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.NetworkAccessResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionStatusResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionStatusResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionStatusResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionStatusResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserAuthenticationType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalRequestKindResourceBrowserAuthenticationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserAuthenticationType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalRequestKindResourceBrowserAuthenticationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccessType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalRequestKindResourceBrowserOriginAccessTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccessType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalRequestKindResourceBrowserOriginAccessTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalRequestKindResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalRequestKindResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceComputerUseApprovalRequestType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionRequiredActionResourceComputerUseApprovalRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceComputerUseApprovalRequestType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionRequiredActionResourceComputerUseApprovalRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionRequiredActionResourceFunctionCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionRequiredActionResourceFunctionCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnectionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionRequiredActionResourceEnvironmentConnectionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnectionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionRequiredActionResourceEnvironmentConnectionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionRequiredActionResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionRequiredActionResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceFunctionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolResourceFunctionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceFunctionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolResourceFunctionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCallingType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolResourceProgrammaticToolCallingTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCallingType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolResourceProgrammaticToolCallingTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportResourceHttpType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpTransportResourceHttpTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportResourceHttpType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpTransportResourceHttpTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportResourceStdioType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpTransportResourceStdioTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportResourceStdioType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpTransportResourceStdioTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpTransportResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpTransportResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceMcpType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolResourceMcpTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceMcpType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolResourceMcpTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceWebSearchType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolResourceWebSearchTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceWebSearchType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolResourceWebSearchTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceComputerUseType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolResourceComputerUseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceComputerUseType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolResourceComputerUseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentResourceNoneType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentResourceNoneTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentResourceNoneType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentResourceNoneTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerSizeResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerSizeResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerSizeResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerSizeResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentResourceOpenaiHostedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentResourceOpenaiHostedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentResourceOpenaiHostedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentResourceOpenaiHostedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentResourceSelfHostedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentResourceSelfHostedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentResourceSelfHostedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentResourceSelfHostedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionResourceObjectNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AgentToolResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_AC4EDEC23D039BC1(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BrowserAuthenticationFieldResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_6BE05555663EF51C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BrowserAuthenticationOptionResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_76EFD47CC825F5DD(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedEnvironmentFileResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_3A4845214B4505E4(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedPluginResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_35153BC742C70D83(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedSkillResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_FD87951FB4C7FF61(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionRequiredActionResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_0E9F59B7E9BB2B82(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_05BF36C073875770(options);
                }
                if (type == typeof(global::System.DateTimeOffset))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_DateTimeOffset(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_AgentToolResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolResourceComputerUse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_AgentToolResourceComputerUse(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolResourceComputerUseType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_AgentToolResourceComputerUseType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolResourceDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_AgentToolResourceDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolResourceDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_AgentToolResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolResourceFunction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_AgentToolResourceFunction(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolResourceFunctionType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_AgentToolResourceFunctionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolResourceMcp))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_AgentToolResourceMcp(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolResourceMcpType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_AgentToolResourceMcpType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCalling))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_AgentToolResourceProgrammaticToolCalling(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCallingType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_AgentToolResourceProgrammaticToolCallingType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolResourceWebSearch))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_AgentToolResourceWebSearch(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolResourceWebSearchType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_AgentToolResourceWebSearchType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BrowserAuthenticationFieldResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_BrowserAuthenticationFieldResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BrowserAuthenticationOptionResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_BrowserAuthenticationOptionResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_ComputerUseApprovalRequestKindResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserAuthentication))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_ComputerUseApprovalRequestKindResourceBrowserAuthentication(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserAuthenticationType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_ComputerUseApprovalRequestKindResourceBrowserAuthenticationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccess))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_ComputerUseApprovalRequestKindResourceBrowserOriginAccess(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccessType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_ComputerUseApprovalRequestKindResourceBrowserOriginAccessType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_ComputerUseApprovalRequestKindResourceDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_ComputerUseApprovalRequestKindResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContainerSizeResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_ContainerSizeResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DesktopResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_DesktopResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentPackagesResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_EnvironmentPackagesResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_EnvironmentResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentResourceDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_EnvironmentResourceDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentResourceDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_EnvironmentResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentResourceNone))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_EnvironmentResourceNone(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentResourceNoneType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_EnvironmentResourceNoneType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentResourceOpenaiHosted))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_EnvironmentResourceOpenaiHosted(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentResourceOpenaiHostedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_EnvironmentResourceOpenaiHostedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentResourceSelfHosted))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_EnvironmentResourceSelfHosted(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentResourceSelfHostedType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_EnvironmentResourceSelfHostedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedEnvironmentFileResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedEnvironmentFileResourceDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedEnvironmentFileResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileId))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedEnvironmentFileResourceFileId(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileIdType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedEnvironmentFileResourceFileIdType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceInline))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedEnvironmentFileResourceInline(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceInlineType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedEnvironmentFileResourceInlineType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedPluginResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedPluginResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedPluginResourceDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedPluginResourceDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedPluginResourceDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedPluginResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedPluginResourceInline))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedPluginResourceInline(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedPluginResourceInlineType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedPluginResourceInlineType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedSkillResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillResourceDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedSkillResourceDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillResourceDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedSkillResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillResourceInline))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedSkillResourceInline(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillResourceInlineType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedSkillResourceInlineType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillResourceSkillReference))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedSkillResourceSkillReference(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillResourceSkillReferenceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_HostedSkillResourceSkillReferenceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputTokensDetailsResource2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InputTokensDetailsResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpConnectionOriginResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_McpConnectionOriginResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpTransportResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_McpTransportResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpTransportResourceDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_McpTransportResourceDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpTransportResourceDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_McpTransportResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpTransportResourceHttp))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_McpTransportResourceHttp(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpTransportResourceHttpType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_McpTransportResourceHttpType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpTransportResourceStdio))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_McpTransportResourceStdio(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpTransportResourceStdioType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_McpTransportResourceStdioType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MultiAgentConfigResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_MultiAgentConfigResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.NetworkAccessResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NetworkAccessResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.NetworkPolicyResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NetworkPolicyResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputTokensDetailsResource2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_OutputTokensDetailsResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningEffortResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_ReasoningEffortResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_ReasoningResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningSummaryResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_ReasoningSummaryResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ServiceTierResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_ServiceTierResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionAgentResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SessionAgentResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionRequiredActionResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SessionRequiredActionResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceComputerUseApprovalRequest))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SessionRequiredActionResourceComputerUseApprovalRequest(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceComputerUseApprovalRequestType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SessionRequiredActionResourceComputerUseApprovalRequestType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SessionRequiredActionResourceDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SessionRequiredActionResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnection))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SessionRequiredActionResourceEnvironmentConnection(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnectionType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SessionRequiredActionResourceEnvironmentConnectionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCall))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SessionRequiredActionResourceFunctionCall(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCallType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SessionRequiredActionResourceFunctionCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SessionResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionResourceObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SessionResourceObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionStatusResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SessionStatusResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TextFormatResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_TextFormatResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TextFormatResourceDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_TextFormatResourceDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TextFormatResourceDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_TextFormatResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TextFormatResourceJsonSchema))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_TextFormatResourceJsonSchema(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TextFormatResourceJsonSchemaType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_TextFormatResourceJsonSchemaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TextFormatResourceText))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_TextFormatResourceText(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TextFormatResourceTextType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_TextFormatResourceTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TextResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_TextResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TokenUsageResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_TokenUsageResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VerbosityResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_VerbosityResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchContextSizeResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_WebSearchContextSizeResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchLocationResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_WebSearchLocationResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchModeResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_WebSearchModeResource2(options);
                }
                if (type == typeof(long))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Int64(options);
                }
                if (type == typeof(bool?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableBoolean(options);
                }
                if (type == typeof(global::System.DateTimeOffset?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableDateTimeOffset(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAgentToolResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolResourceComputerUseType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAgentToolResourceComputerUseType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolResourceDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAgentToolResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolResourceFunctionType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAgentToolResourceFunctionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolResourceMcpType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAgentToolResourceMcpType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCallingType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAgentToolResourceProgrammaticToolCallingType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentToolResourceWebSearchType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAgentToolResourceWebSearchType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableComputerUseApprovalRequestKindResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserAuthenticationType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableComputerUseApprovalRequestKindResourceBrowserAuthenticationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccessType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableComputerUseApprovalRequestKindResourceBrowserOriginAccessType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableComputerUseApprovalRequestKindResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContainerSizeResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableContainerSizeResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableEnvironmentResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentResourceDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableEnvironmentResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentResourceNoneType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableEnvironmentResourceNoneType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentResourceOpenaiHostedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableEnvironmentResourceOpenaiHostedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EnvironmentResourceSelfHostedType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableEnvironmentResourceSelfHostedType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedEnvironmentFileResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedEnvironmentFileResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileIdType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedEnvironmentFileResourceFileIdType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceInlineType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedEnvironmentFileResourceInlineType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedPluginResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedPluginResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedPluginResourceDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedPluginResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedPluginResourceInlineType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedPluginResourceInlineType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedSkillResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillResourceDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedSkillResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillResourceInlineType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedSkillResourceInlineType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.HostedSkillResourceSkillReferenceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableHostedSkillResourceSkillReferenceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpConnectionOriginResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMcpConnectionOriginResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpTransportResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMcpTransportResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpTransportResourceDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMcpTransportResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpTransportResourceHttpType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMcpTransportResourceHttpType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpTransportResourceStdioType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMcpTransportResourceStdioType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.NetworkAccessResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableNetworkAccessResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningEffortResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableReasoningEffortResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningSummaryResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableReasoningSummaryResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ServiceTierResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableServiceTierResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionRequiredActionResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableSessionRequiredActionResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceComputerUseApprovalRequestType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableSessionRequiredActionResourceComputerUseApprovalRequestType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableSessionRequiredActionResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnectionType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableSessionRequiredActionResourceEnvironmentConnectionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCallType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableSessionRequiredActionResourceFunctionCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionResourceObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableSessionResourceObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionStatusResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableSessionStatusResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TextFormatResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableTextFormatResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TextFormatResourceDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableTextFormatResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TextFormatResourceJsonSchemaType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableTextFormatResourceJsonSchemaType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TextFormatResourceTextType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableTextFormatResourceTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VerbosityResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableVerbosityResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchContextSizeResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebSearchContextSizeResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchModeResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebSearchModeResource2(options);
                }
                if (type == typeof(long?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt64(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.AgentToolResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_44C07B0681639FFC(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BrowserAuthenticationFieldResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_00DA528B192B5D7D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BrowserAuthenticationOptionResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_EEE6C55815B4EB51(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedEnvironmentFileResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_5D47DF5648867ADF(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedPluginResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_5EA93C387ED5A055(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedSkillResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_E27D3211C01D8351(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.SessionRequiredActionResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_C098ADB965633FD4(options);
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