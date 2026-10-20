
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_ABC7DC179475ADB5 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_ABC7DC179475ADB5 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_ABC7DC179475ADB5(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageContentTextObject, global::tryAGI.OpenAI.MessageContentRefusalObject>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly>());
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

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnlyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnlyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageFileObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageFileObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageFileObjectImageFileDetail)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageFileObjectImageFileDetail?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageUrlObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageUrlObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageUrlObjectImageUrlDetail)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageUrlObjectImageUrlDetail?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentRefusalObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentRefusalObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentTextObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentTextObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectIncompleteDetailsReason)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectIncompleteDetailsReason?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListMessagesOrder)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListMessagesOrder?);
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnlyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantToolsFileSearchTypeOnlyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnlyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantToolsFileSearchTypeOnlyTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentRefusalObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentRefusalObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentRefusalObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentRefusalObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentTextAnnotationsFileCitationObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentTextAnnotationsFileCitationObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentTextAnnotationsFilePathObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentTextAnnotationsFilePathObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentTextObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentTextObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentTextObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentTextObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageObjectObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageObjectObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageObjectStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageObjectStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectIncompleteDetailsReason))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageObjectIncompleteDetailsReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectIncompleteDetailsReason?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageObjectIncompleteDetailsReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageObjectRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageObjectRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageObjectRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListMessagesOrder))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListMessagesOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListMessagesOrder?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListMessagesOrderNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.MessageObject>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_612B018A55F700F8(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.MessageObjectAttachmentsVariant1Item>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_3FE42C2578328F56(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_3A58BB9D42C4A058(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageContentTextObject, global::tryAGI.OpenAI.MessageContentRefusalObject>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_CF7BCE1881F2875E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_D5B9B3D9DDAA8D01(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantToolsCode))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AssistantToolsCode(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantToolsCodeType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AssistantToolsCodeType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AssistantToolsFileSearchTypeOnly(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnlyType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AssistantToolsFileSearchTypeOnlyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ListMessagesOrder))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_ListMessagesOrder2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ListMessagesResponse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ListMessagesResponse(options);
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
                if (type == typeof(global::tryAGI.OpenAI.MessageContentRefusalObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageContentRefusalObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentRefusalObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageContentRefusalObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageContentTextAnnotationsFileCitationObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObjectFileCitation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageContentTextAnnotationsFileCitationObjectFileCitation(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageContentTextAnnotationsFileCitationObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageContentTextAnnotationsFilePathObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObjectFilePath))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageContentTextAnnotationsFilePathObjectFilePath(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageContentTextAnnotationsFilePathObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentTextObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageContentTextObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentTextObjectText))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageContentTextObjectText(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentTextObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageContentTextObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageObjectAttachmentsVariant1Item))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageObjectAttachmentsVariant1Item(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageObjectIncompleteDetails))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageObjectIncompleteDetails(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageObjectIncompleteDetailsReason))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageObjectIncompleteDetailsReason2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageObjectObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageObjectObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageObjectRole))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageObjectRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageObjectStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_MessageObjectStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_147CF865EFF427B7(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageContentTextObject, global::tryAGI.OpenAI.MessageContentRefusalObject>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_2D42DE93E277A9C6(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_0548972A22EAD818(options);
                }
                if (type == typeof(int))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(bool?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableBoolean(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantToolsCodeType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableAssistantToolsCodeType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnlyType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableAssistantToolsFileSearchTypeOnlyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ListMessagesOrder?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableListMessagesOrder2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.MessageContentRefusalObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageContentRefusalObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageContentTextAnnotationsFileCitationObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageContentTextAnnotationsFilePathObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageContentTextObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageContentTextObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageObjectIncompleteDetailsReason?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageObjectIncompleteDetailsReason2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageObjectObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageObjectObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageObjectRole?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageObjectRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessageObjectStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessageObjectStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_AB535EF066C32422(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageContentTextObject, global::tryAGI.OpenAI.MessageContentRefusalObject>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_27485E9BDDC32359(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_9598A82589CE8681(options);
                }
                if (type == typeof(int?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.MessageObject>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_B0D7374D915357C1(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.MessageObjectAttachmentsVariant1Item>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_D5912244E0C57F33(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_69D357B4B780866C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageContentTextObject, global::tryAGI.OpenAI.MessageContentRefusalObject>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_B16D73B6030086EE(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject, global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_EA34D21FA1806FE1(options);
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