
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_194B73A47DB86411 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_194B73A47DB86411 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_194B73A47DB86411(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.DecisionInputContentPartsItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.DecisionInputContentJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.DecisionInputToolOutputContentPartsItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.DecisionInputToolOutputContentJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.DecisionInputJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.DecisionInputVariant2ItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ChoiceValueParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.QuestionParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ChoiceValueResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnswerResourceJsonConverter());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputTextType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputTextType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputTextPromptCacheBreakpointMode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputTextPromptCacheBreakpointMode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageDetailParam)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageDetailParam?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputImagePromptCacheBreakpointMode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputImagePromptCacheBreakpointMode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputImageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputImageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputOutputTextType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputOutputTextType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputRefusalType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputRefusalType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputContentPartDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputContentPartDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessagePhaseParam)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessagePhaseParam?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputMessageRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputMessageRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputMessageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputMessageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallStatusParam)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallStatusParam?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputFunctionCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputFunctionCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputToolOutputContentPartDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputToolOutputContentPartDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputFunctionCallOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputFunctionCallOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputCustomToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputCustomToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputCustomToolCallOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputCustomToolCallOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputVariant2ItemDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputVariant2ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.QuestionParamPredicateType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.QuestionParamPredicateType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.QuestionParamChoiceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.QuestionParamChoiceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.QuestionParamScoreType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.QuestionParamScoreType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.QuestionParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.QuestionParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DecisionRequestPromptCacheOptionsTtl)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DecisionRequestPromptCacheOptionsTtl?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DecisionRequestPromptCacheOptionsMode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DecisionRequestPromptCacheOptionsMode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AnswerResourcePredicateType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AnswerResourcePredicateType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AnswerResourceChoiceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AnswerResourceChoiceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AnswerResourceScoreType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AnswerResourceScoreType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AnswerResourceRefusalType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AnswerResourceRefusalType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AnswerResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AnswerResourceDiscriminatorType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputTextType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionInputTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputTextType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionInputTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputTextPromptCacheBreakpointMode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionInputTextPromptCacheBreakpointModeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputTextPromptCacheBreakpointMode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionInputTextPromptCacheBreakpointModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageDetailParam))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageDetailParamJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageDetailParam?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageDetailParamNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputImagePromptCacheBreakpointMode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionInputImagePromptCacheBreakpointModeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputImagePromptCacheBreakpointMode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionInputImagePromptCacheBreakpointModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputImageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionInputImageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputImageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionInputImageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputOutputTextType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionInputOutputTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputOutputTextType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionInputOutputTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputRefusalType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionInputRefusalTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputRefusalType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionInputRefusalTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputContentPartDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionInputContentPartDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputContentPartDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionInputContentPartDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessagePhaseParam))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessagePhaseParamJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessagePhaseParam?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessagePhaseParamNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputMessageRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionInputMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputMessageRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionInputMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputMessageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionInputMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputMessageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionInputMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallStatusParam))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionCallStatusParamJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallStatusParam?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionCallStatusParamNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputFunctionCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionInputFunctionCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputFunctionCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionInputFunctionCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputToolOutputContentPartDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionInputToolOutputContentPartDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputToolOutputContentPartDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionInputToolOutputContentPartDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputFunctionCallOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionInputFunctionCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputFunctionCallOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionInputFunctionCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputCustomToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionInputCustomToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputCustomToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionInputCustomToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputCustomToolCallOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionInputCustomToolCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputCustomToolCallOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionInputCustomToolCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputVariant2ItemDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionInputVariant2ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionInputVariant2ItemDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionInputVariant2ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.QuestionParamPredicateType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.QuestionParamPredicateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.QuestionParamPredicateType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.QuestionParamPredicateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.QuestionParamChoiceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.QuestionParamChoiceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.QuestionParamChoiceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.QuestionParamChoiceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.QuestionParamScoreType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.QuestionParamScoreTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.QuestionParamScoreType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.QuestionParamScoreTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.QuestionParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.QuestionParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.QuestionParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.QuestionParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionRequestPromptCacheOptionsTtl))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionRequestPromptCacheOptionsTtlJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionRequestPromptCacheOptionsTtl?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionRequestPromptCacheOptionsTtlNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionRequestPromptCacheOptionsMode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionRequestPromptCacheOptionsModeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionRequestPromptCacheOptionsMode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionRequestPromptCacheOptionsModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AnswerResourcePredicateType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AnswerResourcePredicateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AnswerResourcePredicateType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AnswerResourcePredicateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AnswerResourceChoiceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AnswerResourceChoiceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AnswerResourceChoiceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AnswerResourceChoiceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AnswerResourceScoreType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AnswerResourceScoreTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AnswerResourceScoreType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AnswerResourceScoreTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AnswerResourceRefusalType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AnswerResourceRefusalTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AnswerResourceRefusalType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AnswerResourceRefusalTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AnswerResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AnswerResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AnswerResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AnswerResourceDiscriminatorTypeNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AnswerResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_01AB91C55F1078D0(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChoiceOptionParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_13054DDCCB7FD6F4(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChoiceProbabilityResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_5FF0EB5D85772CA7(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputContentPartsItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_E20358036467C67E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputToolOutputContentPartsItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_E5ABE3872433906F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputVariant2Item>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_F9767BFFA26A176D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.QuestionParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_E3B9D13F4AC6C2F8(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ScoreLevelParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_3AA9EA5FD956A145(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ScoreProbabilityResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_4C1223424020D1F5(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnswerResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AnswerResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnswerResourceChoice))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AnswerResourceChoice(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnswerResourceChoiceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AnswerResourceChoiceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnswerResourceDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AnswerResourceDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnswerResourceDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AnswerResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnswerResourcePredicate))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AnswerResourcePredicate(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnswerResourcePredicateType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AnswerResourcePredicateType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnswerResourceRefusal))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AnswerResourceRefusal(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnswerResourceRefusalType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AnswerResourceRefusalType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnswerResourceScore))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AnswerResourceScore(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnswerResourceScoreType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AnswerResourceScoreType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChoiceOptionParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ChoiceOptionParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChoiceProbabilityResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ChoiceProbabilityResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChoiceValueParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ChoiceValueParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChoiceValueResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ChoiceValueResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionInput2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionInputContent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputContentPartDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionInputContentPartDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputContentPartDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionInputContentPartDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputContentPartsItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionInputContentPartsItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputCustomToolCall))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionInputCustomToolCall(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputCustomToolCallOutput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionInputCustomToolCallOutput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputCustomToolCallOutputType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionInputCustomToolCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputCustomToolCallType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionInputCustomToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputFunctionCall))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionInputFunctionCall(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputFunctionCallOutput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionInputFunctionCallOutput(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputFunctionCallOutputType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionInputFunctionCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputFunctionCallType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionInputFunctionCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputImage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionInputImage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputImagePromptCacheBreakpoint))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionInputImagePromptCacheBreakpoint(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputImagePromptCacheBreakpointMode))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionInputImagePromptCacheBreakpointMode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputImageType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionInputImageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputMessage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionInputMessage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputMessageRole))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionInputMessageRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputMessageType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionInputMessageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputOutputText))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionInputOutputText(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputOutputTextType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionInputOutputTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputRefusal))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionInputRefusal(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputRefusalType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionInputRefusalType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputText))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionInputText(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputTextPromptCacheBreakpoint))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionInputTextPromptCacheBreakpoint(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputTextPromptCacheBreakpointMode))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionInputTextPromptCacheBreakpointMode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputTextType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionInputTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputToolOutputContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionInputToolOutputContent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputToolOutputContentPartDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionInputToolOutputContentPartDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputToolOutputContentPartDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionInputToolOutputContentPartDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputToolOutputContentPartsItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionInputToolOutputContentPartsItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputVariant2Item))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionInputVariant2Item2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputVariant2ItemDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionInputVariant2ItemDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputVariant2ItemDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionInputVariant2ItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionRequest))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionRequest(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionRequestPromptCacheOptions))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionRequestPromptCacheOptions(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionRequestPromptCacheOptionsMode))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionRequestPromptCacheOptionsMode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionRequestPromptCacheOptionsTtl))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionRequestPromptCacheOptionsTtl2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionResponse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionResponse(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionCallStatusParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FunctionCallStatusParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageDetailParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ImageDetailParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputTokensDetailsResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InputTokensDetailsResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessagePhaseParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_MessagePhaseParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputTokensDetailsResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_OutputTokensDetailsResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.QuestionParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_QuestionParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.QuestionParamChoice))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_QuestionParamChoice(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.QuestionParamChoiceType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_QuestionParamChoiceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.QuestionParamDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_QuestionParamDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.QuestionParamDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_QuestionParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.QuestionParamPredicate))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_QuestionParamPredicate(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.QuestionParamPredicateType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_QuestionParamPredicateType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.QuestionParamScore))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_QuestionParamScore(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.QuestionParamScoreType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_QuestionParamScoreType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResponseUsageResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResponseUsageResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ScoreLevelParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ScoreLevelParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ScoreProbabilityResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ScoreProbabilityResource(options);
                }
                if (type == typeof(long))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Int64(options);
                }
                if (type == typeof(bool?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableBoolean(options);
                }
                if (type == typeof(double?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableDouble(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnswerResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAnswerResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnswerResourceChoiceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAnswerResourceChoiceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnswerResourceDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAnswerResourceDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnswerResourcePredicateType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAnswerResourcePredicateType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnswerResourceRefusalType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAnswerResourceRefusalType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnswerResourceScoreType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAnswerResourceScoreType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChoiceValueParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableChoiceValueParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ChoiceValueResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableChoiceValueResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInput?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableDecisionInput2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputContent?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableDecisionInputContent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputContentPartDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableDecisionInputContentPartDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputContentPartsItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableDecisionInputContentPartsItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputCustomToolCallOutputType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableDecisionInputCustomToolCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputCustomToolCallType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableDecisionInputCustomToolCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputFunctionCallOutputType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableDecisionInputFunctionCallOutputType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputFunctionCallType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableDecisionInputFunctionCallType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputImagePromptCacheBreakpointMode?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableDecisionInputImagePromptCacheBreakpointMode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputImageType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableDecisionInputImageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputMessageRole?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableDecisionInputMessageRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputMessageType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableDecisionInputMessageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputOutputTextType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableDecisionInputOutputTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputRefusalType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableDecisionInputRefusalType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputTextPromptCacheBreakpointMode?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableDecisionInputTextPromptCacheBreakpointMode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputTextType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableDecisionInputTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputToolOutputContent?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableDecisionInputToolOutputContent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputToolOutputContentPartDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableDecisionInputToolOutputContentPartDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputToolOutputContentPartsItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableDecisionInputToolOutputContentPartsItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputVariant2Item?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableDecisionInputVariant2Item2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputVariant2ItemDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableDecisionInputVariant2ItemDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionRequestPromptCacheOptionsMode?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableDecisionRequestPromptCacheOptionsMode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionRequestPromptCacheOptionsTtl?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableDecisionRequestPromptCacheOptionsTtl2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FunctionCallStatusParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFunctionCallStatusParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageDetailParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableImageDetailParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.MessagePhaseParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableMessagePhaseParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.QuestionParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableQuestionParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.QuestionParamChoiceType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableQuestionParamChoiceType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.QuestionParamDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableQuestionParamDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.QuestionParamPredicateType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableQuestionParamPredicateType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.QuestionParamScoreType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableQuestionParamScoreType2(options);
                }
                if (type == typeof(long?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt64(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.AnswerResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_205D4DEC6504640F(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChoiceOptionParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_1BDE6D89CAF96F82(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChoiceProbabilityResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_30B25EDC66165E7D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.DecisionInputContentPartsItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_9EC23C8CDD2191A2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.DecisionInputToolOutputContentPartsItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_9716E085213E949C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.DecisionInputVariant2Item>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_BF945010AC0ECEAC(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.QuestionParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_82B12B209386B943(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ScoreLevelParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_325154F181A56758(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ScoreProbabilityResource>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_5B4C1825CC3C93FC(options);
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