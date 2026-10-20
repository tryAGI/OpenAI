
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_34081B0D63D68643 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_34081B0D63D68643 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_34081B0D63D68643(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.InputJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OutputJsonConverter());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionListObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionListObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCallDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionModerationInputDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionModerationInputDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionModerationOutputDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionModerationOutputDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionModerationErrorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionModerationErrorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionModerationResultsType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionModerationResultsType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionResponseMessageAnnotationType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionResponseMessageAnnotationType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionResponseMessageRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionResponseMessageRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionResponseChoiceFinishReason)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionResponseChoiceFinishReason?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionResponseObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionResponseObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ServiceTierEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ServiceTierEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModerationInputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModerationInputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModerationResultBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModerationResultBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListChatCompletionsOrder)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListChatCompletionsOrder?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionListObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionListObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionListObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionListObjectNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionModerationInputDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionModerationInputDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionModerationInputDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionModerationInputDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionModerationOutputDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionModerationOutputDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionModerationOutputDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionModerationOutputDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionModerationErrorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionModerationErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionModerationErrorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionModerationErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionModerationResultsType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionModerationResultsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionModerationResultsType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionModerationResultsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionResponseMessageAnnotationType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionResponseMessageAnnotationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionResponseMessageAnnotationType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionResponseMessageAnnotationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionResponseMessageRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionResponseMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ChatCompletionResponseMessageRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ChatCompletionResponseMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionResponseChoiceFinishReason))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionResponseChoiceFinishReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionResponseChoiceFinishReason?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionResponseChoiceFinishReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionResponseObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateChatCompletionResponseObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ServiceTierEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ServiceTierEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ServiceTierEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ServiceTierEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModerationInputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModerationInputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModerationInputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModerationInputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModerationResultBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModerationResultBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModerationResultBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModerationResultBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListChatCompletionsOrder))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListChatCompletionsOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListChatCompletionsOrder?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListChatCompletionsOrderNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.Dictionary<string, bool>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_651A92249C8DF755(options);
                }
                if (type == typeof(global::System.Collections.Generic.Dictionary<string, double>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_3D6C2C32ACF6EA76(options);
                }
                if (type == typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ModerationInputType>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_C52BF211024DDFD3(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionMessageToolCallsItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_ADC375474415018E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionResponseMessageAnnotation>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_662F6D753616F690(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionTokenLogprob>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_8A2127886B3BA189(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionTokenLogprobTopLogprob>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_9E7EF841233F19F6(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateChatCompletionResponse>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_93B13910CF034CF1(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateChatCompletionResponseChoice>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_3C27478CCEA4AFE3(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ModerationResultBody>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_FEB0E26761E396C6(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<long>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_FFC153334BACEC95(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionList))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionList(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionListObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionListObject2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionModeration))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionModeration(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionModerationError))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionModerationError(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionModerationErrorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionModerationErrorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionModerationInputDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionModerationInputDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionModerationInputDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionModerationInputDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionModerationOutputDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionModerationOutputDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionModerationOutputDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionModerationOutputDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionModerationResults))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionModerationResults(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionModerationResultsType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionModerationResultsType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionResponseMessage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionResponseMessage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionResponseMessageAnnotation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionResponseMessageAnnotation(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionResponseMessageAnnotationType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionResponseMessageAnnotationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionResponseMessageAnnotationUrlCitation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionResponseMessageAnnotationUrlCitation(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionResponseMessageAudio))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionResponseMessageAudio(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionResponseMessageFunctionCall))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionResponseMessageFunctionCall(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionResponseMessageRole))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionResponseMessageRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionTokenLogprob))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionTokenLogprob(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionTokenLogprobTopLogprob))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ChatCompletionTokenLogprobTopLogprob(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CompletionUsage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CompletionUsage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CompletionUsageCompletionTokensDetails))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CompletionUsageCompletionTokensDetails(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CompletionUsagePromptTokensDetails))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CompletionUsagePromptTokensDetails(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateChatCompletionResponse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateChatCompletionResponse(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateChatCompletionResponseChoice))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateChatCompletionResponseChoice(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateChatCompletionResponseChoiceFinishReason))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateChatCompletionResponseChoiceFinishReason2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateChatCompletionResponseChoiceLogprobs))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateChatCompletionResponseChoiceLogprobs(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateChatCompletionResponseObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateChatCompletionResponseObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Input))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Input2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ListChatCompletionsOrder))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_ListChatCompletionsOrder2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ModerationInputType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ModerationInputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ModerationResultBody))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ModerationResultBody(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ModerationResultBodyType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ModerationResultBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Output))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Output2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ServiceTierEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ServiceTierEnum2_3(options);
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
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionListObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionListObject2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionModerationErrorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionModerationErrorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionModerationInputDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionModerationInputDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionModerationOutputDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionModerationOutputDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionModerationResultsType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionModerationResultsType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionResponseMessageAnnotationType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionResponseMessageAnnotationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChatCompletionResponseMessageRole?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableChatCompletionResponseMessageRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateChatCompletionResponseChoiceFinishReason?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableCreateChatCompletionResponseChoiceFinishReason2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateChatCompletionResponseObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableCreateChatCompletionResponseObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Input?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInput2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ListChatCompletionsOrder?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableListChatCompletionsOrder2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ModerationInputType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableModerationInputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ModerationResultBodyType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableModerationResultBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Output?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableOutput2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ServiceTierEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableServiceTierEnum2_3(options);
                }
                if (type == typeof(int?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.ModerationInputType>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_B50D38EA6F128ECA(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionMessageToolCallsItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_2C01A7AD62806ECD(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionResponseMessageAnnotation>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_D49B056A8E7B7D84(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionTokenLogprob>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_F6CF478A81B98B38(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionTokenLogprobTopLogprob>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_9988973BE23FB706(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateChatCompletionResponse>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_DC61A82E3390E205(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateChatCompletionResponseChoice>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_4DEC31EC97B0AD11(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ModerationResultBody>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_5872FDDAE5F75D40(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<long>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_2BCC53E1C7DA84DD(options);
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