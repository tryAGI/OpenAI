
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_20784A35682F6825 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_20784A35682F6825 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_20784A35682F6825(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ContentItem5JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnnotationsItem3JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ThreadItemJsonConverter());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.UserMessageInputTextType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UserMessageInputTextType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UserMessageQuotedTextType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UserMessageQuotedTextType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AttachmentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AttachmentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UserMessageItemObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UserMessageItemObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UserMessageItemType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UserMessageItemType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UserMessageItemContentItemDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UserMessageItemContentItemDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileAnnotationSourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileAnnotationSourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileAnnotationType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileAnnotationType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UrlAnnotationSourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UrlAnnotationSourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UrlAnnotationType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UrlAnnotationType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseOutputTextType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseOutputTextType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseOutputTextAnnotationDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseOutputTextAnnotationDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantMessageItemObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantMessageItemObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantMessageItemType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantMessageItemType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WidgetMessageItemObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WidgetMessageItemObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WidgetMessageItemType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WidgetMessageItemType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ClientToolCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ClientToolCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ClientToolCallItemObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ClientToolCallItemObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ClientToolCallItemType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ClientToolCallItemType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TaskType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TaskType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TaskItemObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TaskItemObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TaskItemType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TaskItemType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TaskGroupItemObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TaskGroupItemObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TaskGroupItemType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TaskGroupItemType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ThreadItemDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ThreadItemDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ThreadItemListResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ThreadItemListResourceObject?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.UserMessageInputTextType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UserMessageInputTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UserMessageInputTextType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UserMessageInputTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UserMessageQuotedTextType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UserMessageQuotedTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UserMessageQuotedTextType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UserMessageQuotedTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AttachmentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AttachmentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AttachmentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AttachmentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UserMessageItemObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UserMessageItemObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UserMessageItemObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UserMessageItemObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UserMessageItemType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UserMessageItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UserMessageItemType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UserMessageItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UserMessageItemContentItemDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UserMessageItemContentItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UserMessageItemContentItemDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UserMessageItemContentItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileAnnotationSourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileAnnotationSourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileAnnotationSourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileAnnotationSourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileAnnotationType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileAnnotationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileAnnotationType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileAnnotationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UrlAnnotationSourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UrlAnnotationSourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UrlAnnotationSourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UrlAnnotationSourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UrlAnnotationType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UrlAnnotationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UrlAnnotationType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UrlAnnotationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseOutputTextType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseOutputTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseOutputTextType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseOutputTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseOutputTextAnnotationDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseOutputTextAnnotationDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseOutputTextAnnotationDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseOutputTextAnnotationDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantMessageItemObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantMessageItemObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantMessageItemObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantMessageItemObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantMessageItemType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantMessageItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantMessageItemType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantMessageItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WidgetMessageItemObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WidgetMessageItemObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WidgetMessageItemObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WidgetMessageItemObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WidgetMessageItemType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WidgetMessageItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WidgetMessageItemType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WidgetMessageItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ClientToolCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ClientToolCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ClientToolCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ClientToolCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ClientToolCallItemObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ClientToolCallItemObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ClientToolCallItemObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ClientToolCallItemObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ClientToolCallItemType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ClientToolCallItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ClientToolCallItemType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ClientToolCallItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TaskType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TaskTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TaskType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TaskTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TaskItemObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TaskItemObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TaskItemObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TaskItemObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TaskItemType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TaskItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TaskItemType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TaskItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TaskGroupItemObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TaskGroupItemObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TaskGroupItemObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TaskGroupItemObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TaskGroupItemType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TaskGroupItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TaskGroupItemType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TaskGroupItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ThreadItemDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ThreadItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ThreadItemDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ThreadItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ThreadItemListResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ThreadItemListResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ThreadItemListResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ThreadItemListResourceObjectNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AnnotationsItem3>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_14E861529047BC12(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Attachment>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_484EDAE9178386B6(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem5>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_5C8CF7D3150AB03A(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseOutputText>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_B9FC7F519269A6AB(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TaskGroupTask>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_120C599855D25F27(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ThreadItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_49C4570BEABE0C20(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnnotationsItem3))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AnnotationsItem32(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantMessageItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AssistantMessageItem(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantMessageItemObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AssistantMessageItemObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantMessageItemType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AssistantMessageItemType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Attachment))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_Attachment(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AttachmentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AttachmentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ClientToolCallItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ClientToolCallItem(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ClientToolCallItemObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ClientToolCallItemObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ClientToolCallItemType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ClientToolCallItemType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ClientToolCallStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ClientToolCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContentItem5))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ContentItem52(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FileAnnotation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FileAnnotation(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FileAnnotationSource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FileAnnotationSource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FileAnnotationSourceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FileAnnotationSourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FileAnnotationType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FileAnnotationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InferenceOptions))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InferenceOptions(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseOutputText))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseOutputText(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseOutputTextAnnotationDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseOutputTextAnnotationDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseOutputTextAnnotationDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseOutputTextAnnotationDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseOutputTextType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseOutputTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TaskGroupItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_TaskGroupItem(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TaskGroupItemObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_TaskGroupItemObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TaskGroupItemType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_TaskGroupItemType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TaskGroupTask))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_TaskGroupTask(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TaskItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_TaskItem(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TaskItemObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_TaskItemObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TaskItemType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_TaskItemType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TaskType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_TaskType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ThreadItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ThreadItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ThreadItemDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ThreadItemDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ThreadItemDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ThreadItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ThreadItemListResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ThreadItemListResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ThreadItemListResourceObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ThreadItemListResourceObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolChoice9))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ToolChoice9(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UrlAnnotation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UrlAnnotation(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UrlAnnotationSource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UrlAnnotationSource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UrlAnnotationSourceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UrlAnnotationSourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UrlAnnotationType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UrlAnnotationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UserMessageInputText))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UserMessageInputText(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UserMessageInputTextType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UserMessageInputTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UserMessageItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UserMessageItem(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UserMessageItemContentItemDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UserMessageItemContentItemDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UserMessageItemContentItemDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UserMessageItemContentItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UserMessageItemObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UserMessageItemObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UserMessageItemType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UserMessageItemType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UserMessageQuotedText))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UserMessageQuotedText(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UserMessageQuotedTextType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UserMessageQuotedTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WidgetMessageItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WidgetMessageItem(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WidgetMessageItemObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WidgetMessageItemObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WidgetMessageItemType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_WidgetMessageItemType2(options);
                }
                if (type == typeof(int))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(bool?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableBoolean(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnnotationsItem3?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAnnotationsItem32(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantMessageItemObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAssistantMessageItemObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantMessageItemType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAssistantMessageItemType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AttachmentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAttachmentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ClientToolCallItemObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableClientToolCallItemObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ClientToolCallItemType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableClientToolCallItemType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ClientToolCallStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableClientToolCallStatus2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContentItem5?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableContentItem52(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FileAnnotationSourceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFileAnnotationSourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FileAnnotationType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFileAnnotationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseOutputTextAnnotationDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseOutputTextAnnotationDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseOutputTextType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResponseOutputTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TaskGroupItemObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableTaskGroupItemObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TaskGroupItemType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableTaskGroupItemType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TaskItemObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableTaskItemObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TaskItemType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableTaskItemType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TaskType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableTaskType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ThreadItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableThreadItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ThreadItemDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableThreadItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ThreadItemListResourceObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableThreadItemListResourceObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UrlAnnotationSourceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableUrlAnnotationSourceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UrlAnnotationType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableUrlAnnotationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UserMessageInputTextType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableUserMessageInputTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UserMessageItemContentItemDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableUserMessageItemContentItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UserMessageItemObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableUserMessageItemObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UserMessageItemType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableUserMessageItemType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UserMessageQuotedTextType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableUserMessageQuotedTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WidgetMessageItemObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWidgetMessageItemObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.WidgetMessageItemType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableWidgetMessageItemType2(options);
                }
                if (type == typeof(int?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.AnnotationsItem3>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_861559D5EDDBCDA4(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Attachment>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_3B0F44E8CE4D83EB(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentItem5>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_A5D3BC8066053409(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ResponseOutputText>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_29E7C3B0D519CAB6(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.TaskGroupTask>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_9615AEA0DE94A306(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ThreadItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_88B3C852B17FCEE7(options);
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