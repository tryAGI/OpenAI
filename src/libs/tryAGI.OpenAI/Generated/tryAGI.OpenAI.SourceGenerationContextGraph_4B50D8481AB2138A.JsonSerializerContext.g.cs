
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_4B50D8481AB2138A : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_4B50D8481AB2138A Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_4B50D8481AB2138A(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.TextFormatResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.PersistedMcpTransportResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolResourceJsonConverter());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortResource)

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

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceFunctionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceFunctionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceToolSearchType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceToolSearchType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCallingType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCallingType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceHttpType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceHttpType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceStdioType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceStdioType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpConnectionOriginResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpConnectionOriginResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceMcpType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceMcpType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchModeResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchModeResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchContextSizeResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchContextSizeResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearchType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearchType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceComputerUseType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceComputerUseType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentListResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentListResourceObject?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceFunctionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolResourceFunctionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceFunctionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolResourceFunctionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceToolSearchType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolResourceToolSearchTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceToolSearchType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolResourceToolSearchTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCallingType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolResourceProgrammaticToolCallingTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCallingType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolResourceProgrammaticToolCallingTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceHttpType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedMcpTransportResourceHttpTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceHttpType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedMcpTransportResourceHttpTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceStdioType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedMcpTransportResourceStdioTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceStdioType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedMcpTransportResourceStdioTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedMcpTransportResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedMcpTransportResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpConnectionOriginResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpConnectionOriginResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpConnectionOriginResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpConnectionOriginResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceMcpType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolResourceMcpTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceMcpType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolResourceMcpTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearchType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolResourceWebSearchTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearchType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolResourceWebSearchTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceComputerUseType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolResourceComputerUseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceComputerUseType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolResourceComputerUseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentListResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentListResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentListResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentListResourceObjectNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AgentResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_A719D1B581574A2F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.PersistedAgentToolResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_69DEF4DC897AB8D2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_05BF36C073875770(options);
                }
                if (type == typeof(global::System.DateTimeOffset))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_DateTimeOffset(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentListResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_AgentListResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentListResourceObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_AgentListResourceObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_AgentResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentResourceObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_AgentResourceObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpConnectionOriginResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_McpConnectionOriginResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MultiAgentConfigResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_MultiAgentConfigResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedAgentToolResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceComputerUse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedAgentToolResourceComputerUse(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceComputerUseType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedAgentToolResourceComputerUseType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedAgentToolResourceDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedAgentToolResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceFunction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedAgentToolResourceFunction(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceFunctionType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedAgentToolResourceFunctionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceMcp))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedAgentToolResourceMcp(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceMcpType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedAgentToolResourceMcpType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCalling))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedAgentToolResourceProgrammaticToolCalling(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCallingType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedAgentToolResourceProgrammaticToolCallingType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceToolSearch))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedAgentToolResourceToolSearch(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceToolSearchType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedAgentToolResourceToolSearchType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearch))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedAgentToolResourceWebSearch(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearchType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedAgentToolResourceWebSearchType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedMcpTransportResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedMcpTransportResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedMcpTransportResourceDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedMcpTransportResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceHttp))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedMcpTransportResourceHttp(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceHttpType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedMcpTransportResourceHttpType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceStdio))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedMcpTransportResourceStdio(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceStdioType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedMcpTransportResourceStdioType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.AgentListResourceObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAgentListResourceObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AgentResourceObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAgentResourceObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpConnectionOriginResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMcpConnectionOriginResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePersistedAgentToolResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceComputerUseType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePersistedAgentToolResourceComputerUseType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePersistedAgentToolResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceFunctionType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePersistedAgentToolResourceFunctionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceMcpType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePersistedAgentToolResourceMcpType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCallingType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePersistedAgentToolResourceProgrammaticToolCallingType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceToolSearchType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePersistedAgentToolResourceToolSearchType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearchType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePersistedAgentToolResourceWebSearchType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedMcpTransportResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePersistedMcpTransportResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePersistedMcpTransportResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceHttpType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePersistedMcpTransportResourceHttpType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceStdioType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePersistedMcpTransportResourceStdioType2(options);
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
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.AgentResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_1D02D6C205243193(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.PersistedAgentToolResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_E938DBA5A4F8AB69(options);
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