
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_9DE334C5F091F3E4 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_9DE334C5F091F3E4 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_9DE334C5F091F3E4(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly>());
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

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateMessageRequestRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateMessageRequestRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageFileObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageFileObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageFileObjectImageFileDetail)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageFileObjectImageFileDetail?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageUrlObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageUrlObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageUrlObjectImageUrlDetail)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentImageUrlObjectImageUrlDetail?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageRequestContentTextObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageRequestContentTextObjectType?);
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateMessageRequestRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateMessageRequestRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateMessageRequestRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateMessageRequestRoleNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateMessageRequestAttachmentsVariant1Item>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_7C56B7466AB2C123(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnly>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_3A58BB9D42C4A058(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_C62780C8AE4C3A13(options);
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
                if (type == typeof(global::tryAGI.OpenAI.AssistantToolsCodeType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableAssistantToolsCodeType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AssistantToolsFileSearchTypeOnlyType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableAssistantToolsFileSearchTypeOnlyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateMessageRequestRole?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateMessageRequestRole2(options);
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
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateMessageRequestAttachmentsVariant1Item>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_105679476A9C3376(options);
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