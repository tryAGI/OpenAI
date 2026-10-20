
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextOrphans_69FF31DF2E1E7264 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextOrphans_69FF31DF2E1E7264 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextOrphans_69FF31DF2E1E7264(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageToolCallsItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestAssistantMessageContentPartJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.FineTuneChatCompletionRequestAssistantMessageJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPart>>());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPartDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPartDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartRefusalType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartRefusalType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartTextType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartTextType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParamMode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParamMode?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageCustomToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageCustomToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageToolCallDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageToolCallDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestAssistantMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestAssistantMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPartDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestAssistantMessageContentPartDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPartDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestAssistantMessageContentPartDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartRefusalType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartRefusalTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartRefusalType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartRefusalTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartTextType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartTextType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParamMode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheBreakpointParamModeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParamMode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheBreakpointParamModeNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionMessageToolCallsItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_ADC375474415018E(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCall))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionMessageCustomToolCall(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCallCustom))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionMessageCustomToolCallCustom(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCallType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionMessageCustomToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCall))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionMessageToolCall(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionMessageToolCallDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionMessageToolCallDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallFunction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionMessageToolCallFunction(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionMessageToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallsItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionMessageToolCallsItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestAssistantMessage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageAudio))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestAssistantMessageAudio(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPart))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestAssistantMessageContentPart2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPartDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestAssistantMessageContentPartDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPartDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestAssistantMessageContentPartDiscriminatorType2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageFunctionCall))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestAssistantMessageFunctionCall(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageRole))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestAssistantMessageRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartRefusal))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestMessageContentPartRefusal(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartRefusalType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestMessageContentPartRefusalType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestMessageContentPartText(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartTextType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionRequestMessageContentPartTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FineTuneChatCompletionRequestAssistantMessage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FineTuneChatCompletionRequestAssistantMessage2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FineTuneChatCompletionRequestAssistantMessageAssistantMessage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FineTuneChatCompletionRequestAssistantMessageAssistantMessage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPart>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_76DED36913040C6C(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_PromptCacheBreakpointParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParamMode))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_PromptCacheBreakpointParamMode2(options);
                }
                if (type == typeof(int))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCallType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionMessageCustomToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionMessageToolCallDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionMessageToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallsItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionMessageToolCallsItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPart?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionRequestAssistantMessageContentPart2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPartDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionRequestAssistantMessageContentPartDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageRole?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionRequestAssistantMessageRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartRefusalType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionRequestMessageContentPartRefusalType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartTextType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionRequestMessageContentPartTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FineTuneChatCompletionRequestAssistantMessage?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFineTuneChatCompletionRequestAssistantMessage2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParamMode?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePromptCacheBreakpointParamMode2(options);
                }
                if (type == typeof(int?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionMessageToolCallsItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_2C01A7AD62806ECD(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPart>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_B3903E113224A413(options);
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