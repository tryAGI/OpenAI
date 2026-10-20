
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_749C0C8E4EDF3327 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_749C0C8E4EDF3327 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_749C0C8E4EDF3327(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.AssistantSupportedModels?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.AssistantSupportedModels?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.TruncationObject, object>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.AssistantsApiToolChoiceOption?, object>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.TruncationObject, object>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.AssistantsApiToolChoiceOption?, object>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly>());
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

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateMessageRequestRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateMessageRequestRole?)

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

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageRequestContentTextObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageRequestContentTextObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchemaType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchemaType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatTextType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatTextType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TruncationObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TruncationObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateRunIncludeItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateRunIncludeItem?);
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateMessageRequestRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateMessageRequestRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateMessageRequestRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateMessageRequestRoleNullableJsonConverter();
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageRequestContentTextObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageRequestContentTextObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageRequestContentTextObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageRequestContentTextObjectTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TruncationObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TruncationObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TruncationObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TruncationObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateRunIncludeItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateRunIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateRunIncludeItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateRunIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateMessageRequest>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_4C8B47F5D17BDABA(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateMessageRequestAttachmentsVariant1Item>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_7C56B7466AB2C123(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateRunIncludeItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_13E8FD8D2C8972E1(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_D8F74B0240BA31FB(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_3A58BB9D42C4A058(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_C62780C8AE4C3A13(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.AssistantsApiToolChoiceOption?, object>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_EC047EC71CEFF49D(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.TruncationObject, object>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_B6BDADD9BC6697BB(options);
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
                if (type == typeof(global::tryAGI.OpenAI.CreateMessageRequest))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateMessageRequest(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateMessageRequestAttachmentsVariant1Item))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateMessageRequestAttachmentsVariant1Item(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateMessageRequestRole))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateMessageRequestRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateRunIncludeItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_CreateRunIncludeItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateRunRequest))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateRunRequest(options);
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
                if (type == typeof(global::tryAGI.OpenAI.MessageRequestContentTextObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageRequestContentTextObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageRequestContentTextObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageRequestContentTextObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_391B6DFC224EE298(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_147CF865EFF427B7(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_0BDD2D89FDA444EB(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_BCA5FD92DF116A36(options);
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
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.AssistantsApiToolChoiceOption?, object>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_2BD2D6DDFBAAA1C8(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.TruncationObject, object>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_9851CDA3826AB7C4(options);
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
                if (type == typeof(global::tryAGI.OpenAI.CreateMessageRequestRole?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateMessageRequestRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateRunIncludeItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableCreateRunIncludeItem2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.MessageRequestContentTextObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageRequestContentTextObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_6F16A1C0BFAC98A4(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_AB535EF066C32422(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_6DF0656544AC25AC(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>>>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_85306175D1861C76(options);
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
                if (type == typeof(global::tryAGI.OpenAI.TruncationObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableTruncationObjectType2(options);
                }
                if (type == typeof(int?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateMessageRequest>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_7F6B94BF09A8E5E8(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateMessageRequestAttachmentsVariant1Item>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_105679476A9C3376(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateRunIncludeItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_90F72AFB54227282(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_09B6433818FC3887(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_69D357B4B780866C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_7A9D5B4D81468B29(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_0B10C781B66C5AC5(options);
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