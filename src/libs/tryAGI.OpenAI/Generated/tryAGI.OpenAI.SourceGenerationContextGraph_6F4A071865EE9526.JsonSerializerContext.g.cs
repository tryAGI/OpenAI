
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_6F4A071865EE9526 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_6F4A071865EE9526 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_6F4A071865EE9526(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AssistantsApiToolChoiceOptionJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsCodeType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsCodeType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsFunctionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsFunctionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantsApiResponseFormatOptionEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantsApiResponseFormatOptionEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantsApiToolChoiceOptionEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantsApiToolChoiceOptionEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantsNamedToolChoiceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantsNamedToolChoiceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchRanker)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchRanker?)

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

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunToolCallObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RunToolCallObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TruncationObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TruncationObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListRunsOrder)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListRunsOrder?);
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchRanker))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileSearchRankerJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchRanker?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileSearchRankerNullableJsonConverter();
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunToolCallObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunToolCallObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RunToolCallObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RunToolCallObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TruncationObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TruncationObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TruncationObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TruncationObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListRunsOrder))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListRunsOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListRunsOrder?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListRunsOrderNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_D8F74B0240BA31FB(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RunObject>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_EC2B8030394A7D99(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RunToolCallObject>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_C250EA806C62157A(options);
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
                if (type == typeof(global::tryAGI.OpenAI.ListRunsOrder))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_ListRunsOrder2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ListRunsResponse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ListRunsResponse(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_391B6DFC224EE298(options);
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
                if (type == typeof(global::tryAGI.OpenAI.AssistantsApiToolChoiceOptionEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableAssistantsApiToolChoiceOptionEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantsNamedToolChoiceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableAssistantsNamedToolChoiceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FileSearchRanker?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFileSearchRanker2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ListRunsOrder?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableListRunsOrder2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_6F16A1C0BFAC98A4(options);
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
                if (type == typeof(global::tryAGI.OpenAI.RunToolCallObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRunToolCallObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TruncationObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableTruncationObjectType2(options);
                }
                if (type == typeof(int?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_09B6433818FC3887(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RunObject>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_958F47CFF60ED491(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.RunToolCallObject>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_6BC2955694967327(options);
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