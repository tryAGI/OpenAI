
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextOrphans_50501008A65C33AE : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextOrphans_50501008A65C33AE Default { get; } = new(DefaultOptions);

        private SourceGenerationContextOrphans_50501008A65C33AE(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AssistantsApiResponseFormatOptionJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.AssistantSupportedModels?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.AssistantSupportedModels?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.AssistantSupportedModels?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.AssistantSupportedModels)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantSupportedModels?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsCodeType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsCodeType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsFunctionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsFunctionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantsApiResponseFormatOptionEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantsApiResponseFormatOptionEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchRanker)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchRanker?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchemaType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchemaType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatTextType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatTextType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantSupportedModels))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantSupportedModelsJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantSupportedModels?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantSupportedModelsNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchRanker))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileSearchRankerJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchRanker?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileSearchRankerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningEffortEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningEffortEnumNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStore>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_8DED3937B9A0EF0F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_D8F74B0240BA31FB(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_05BF36C073875770(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.AssistantSupportedModels?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_9AA3C089E7F46546(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantSupportedModels))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AssistantSupportedModels2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.CreateAssistantRequest))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateAssistantRequest(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResources))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateAssistantRequestToolResources(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesCodeInterpreter))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateAssistantRequestToolResourcesCodeInterpreter(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearch))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateAssistantRequestToolResourcesFileSearch(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStore))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateAssistantRequestToolResourcesFileSearchVectorStore(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyStatic))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyStatic(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_391B6DFC224EE298(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_721CB049B22F32B9(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ReasoningEffortEnum2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.AssistantSupportedModels?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_B1BFE51BC2111F6F(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantSupportedModels?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableAssistantSupportedModels2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantToolsCodeType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableAssistantToolsCodeType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableAssistantToolsFileSearchType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantToolsFunctionType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableAssistantToolsFunctionType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantsApiResponseFormatOptionEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableAssistantsApiResponseFormatOptionEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableCreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableCreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FileSearchRanker?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFileSearchRanker2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_6F16A1C0BFAC98A4(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_E8CF5BF95F9DFB83(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableReasoningEffortEnum2(options);
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
                if (type == typeof(int?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStore>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_55BB20BCBF40BB45(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_09B6433818FC3887(options);
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