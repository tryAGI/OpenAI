
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_32DE1DF25DF290CE : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_32DE1DF25DF290CE Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_32DE1DF25DF290CE(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageListObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageListObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageListDataItemRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageListDataItemRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageListDataItemContentPartsVariant1ItemType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageListDataItemContentPartsVariant1ItemType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GetChatCompletionMessagesOrder)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GetChatCompletionMessagesOrder?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageListObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageListObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageListObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageListObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageListDataItemRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageListDataItemRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageListDataItemRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageListDataItemRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageListDataItemContentPartsVariant1ItemType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageListDataItemContentPartsVariant1ItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageListDataItemContentPartsVariant1ItemType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageListDataItemContentPartsVariant1ItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GetChatCompletionMessagesOrder))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GetChatCompletionMessagesOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GetChatCompletionMessagesOrder?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GetChatCompletionMessagesOrderNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionMessageListDataItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_4933F7C959BA028B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionMessageListDataItemContentPartsVariant1Item>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_F4BE047A8F614DE4(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionMessageList))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionMessageList(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionMessageListDataItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionMessageListDataItem(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionMessageListDataItemContentPartsVariant1Item))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionMessageListDataItemContentPartsVariant1Item(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionMessageListDataItemContentPartsVariant1ItemFile))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionMessageListDataItemContentPartsVariant1ItemFile(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionMessageListDataItemContentPartsVariant1ItemImageUrl))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionMessageListDataItemContentPartsVariant1ItemImageUrl(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionMessageListDataItemContentPartsVariant1ItemInputAudio))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionMessageListDataItemContentPartsVariant1ItemInputAudio(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionMessageListDataItemContentPartsVariant1ItemType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionMessageListDataItemContentPartsVariant1ItemType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionMessageListDataItemRole))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionMessageListDataItemRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionMessageListObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionMessageListObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GetChatCompletionMessagesOrder))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_GetChatCompletionMessagesOrder2(options);
                }
                if (type == typeof(bool?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableBoolean(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionMessageListDataItemContentPartsVariant1ItemType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionMessageListDataItemContentPartsVariant1ItemType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionMessageListDataItemRole?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionMessageListDataItemRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionMessageListObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionMessageListObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GetChatCompletionMessagesOrder?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableGetChatCompletionMessagesOrder2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionMessageListDataItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_B65446B062E3FD50(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionMessageListDataItemContentPartsVariant1Item>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_F4AD81683092A9FD(options);
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