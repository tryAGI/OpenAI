
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_420B17A7701C2474 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_420B17A7701C2474 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_420B17A7701C2474(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.PersistedMcpTransportConfigParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolConfigParamJsonConverter());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunctionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunctionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearchType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearchType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCallingType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCallingType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttpType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttpType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdioType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdioType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpConnectionOriginParam)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpConnectionOriginParam?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcpType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcpType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchModeParam)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchModeParam?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchContextSizeParam)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchContextSizeParam?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearchType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearchType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamComputerUseType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamComputerUseType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamDiscriminatorType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunctionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolConfigParamFunctionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunctionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolConfigParamFunctionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearchType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolConfigParamToolSearchTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearchType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolConfigParamToolSearchTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCallingType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolConfigParamProgrammaticToolCallingTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCallingType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolConfigParamProgrammaticToolCallingTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttpType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedMcpTransportConfigParamHttpTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttpType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedMcpTransportConfigParamHttpTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdioType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedMcpTransportConfigParamStdioTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdioType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedMcpTransportConfigParamStdioTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedMcpTransportConfigParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedMcpTransportConfigParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpConnectionOriginParam))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpConnectionOriginParamJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpConnectionOriginParam?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpConnectionOriginParamNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcpType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolConfigParamMcpTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcpType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolConfigParamMcpTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearchType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolConfigParamWebSearchTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearchType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolConfigParamWebSearchTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamComputerUseType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolConfigParamComputerUseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamComputerUseType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolConfigParamComputerUseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolConfigParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolConfigParamDiscriminatorTypeNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.PersistedAgentToolConfigParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_70827DC5FBC25A48(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_05BF36C073875770(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpConnectionOriginParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_McpConnectionOriginParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedAgentToolConfigParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamComputerUse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedAgentToolConfigParamComputerUse(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamComputerUseType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedAgentToolConfigParamComputerUseType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedAgentToolConfigParamDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedAgentToolConfigParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedAgentToolConfigParamFunction(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunctionType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedAgentToolConfigParamFunctionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcp))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedAgentToolConfigParamMcp(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcpType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedAgentToolConfigParamMcpType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCalling))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedAgentToolConfigParamProgrammaticToolCalling(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCallingType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedAgentToolConfigParamProgrammaticToolCallingType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearch))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedAgentToolConfigParamToolSearch(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearchType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedAgentToolConfigParamToolSearchType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearch))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedAgentToolConfigParamWebSearch(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearchType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedAgentToolConfigParamWebSearchType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedMcpTransportConfigParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedMcpTransportConfigParamDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedMcpTransportConfigParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttp))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedMcpTransportConfigParamHttp(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttpType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedMcpTransportConfigParamHttpType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdio))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedMcpTransportConfigParamStdio(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdioType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_PersistedMcpTransportConfigParamStdioType2(options);
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
                if (type == typeof(bool?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableBoolean(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.McpConnectionOriginParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMcpConnectionOriginParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePersistedAgentToolConfigParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamComputerUseType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePersistedAgentToolConfigParamComputerUseType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePersistedAgentToolConfigParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunctionType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePersistedAgentToolConfigParamFunctionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcpType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePersistedAgentToolConfigParamMcpType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCallingType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePersistedAgentToolConfigParamProgrammaticToolCallingType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearchType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePersistedAgentToolConfigParamToolSearchType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearchType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePersistedAgentToolConfigParamWebSearchType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePersistedMcpTransportConfigParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePersistedMcpTransportConfigParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttpType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePersistedMcpTransportConfigParamHttpType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdioType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePersistedMcpTransportConfigParamStdioType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchContextSizeParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebSearchContextSizeParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WebSearchModeParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWebSearchModeParam2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.PersistedAgentToolConfigParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_6C49193ABE078D63(options);
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