
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_0A9BA9413460070A : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_0A9BA9413460070A Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_0A9BA9413460070A(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.EvalItemContentJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.EvalItemContentItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.GraderStringCheck, global::tryAGI.OpenAI.GraderTextSimilarity, global::tryAGI.OpenAI.GraderPython, global::tryAGI.OpenAI.GraderScoreModel, global::tryAGI.OpenAI.GraderMulti>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.GraderStringCheck, global::tryAGI.OpenAI.GraderTextSimilarity, global::tryAGI.OpenAI.GraderPython, global::tryAGI.OpenAI.GraderScoreModel, global::tryAGI.OpenAI.GraderMulti>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.GraderStringCheck, global::tryAGI.OpenAI.GraderTextSimilarity, global::tryAGI.OpenAI.GraderPython, global::tryAGI.OpenAI.GraderScoreModel, global::tryAGI.OpenAI.GraderMulti>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.GraderStringCheck, global::tryAGI.OpenAI.GraderTextSimilarity, global::tryAGI.OpenAI.GraderPython, global::tryAGI.OpenAI.GraderScoreModel, global::tryAGI.OpenAI.GraderMulti>());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.EvalItemRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EvalItemRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EvalItemType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EvalItemType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EvalItemContentOutputTextType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EvalItemContentOutputTextType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EvalItemInputImageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EvalItemInputImageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GraderMultiType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GraderMultiType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GraderPythonType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GraderPythonType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GraderScoreModelType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GraderScoreModelType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GraderStringCheckType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GraderStringCheckType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GraderStringCheckOperation)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GraderStringCheckOperation?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GraderTextSimilarityType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GraderTextSimilarityType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GraderTextSimilarityEvaluationMetric)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GraderTextSimilarityEvaluationMetric?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputAudioType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputAudioType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputAudioInputAudio1Format)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputAudioInputAudio1Format?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputTextContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputTextContentType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.EvalItemRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EvalItemRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EvalItemRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EvalItemRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EvalItemType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EvalItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EvalItemType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EvalItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EvalItemContentOutputTextType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EvalItemContentOutputTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EvalItemContentOutputTextType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EvalItemContentOutputTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EvalItemInputImageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EvalItemInputImageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EvalItemInputImageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EvalItemInputImageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GraderMultiType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GraderMultiTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GraderMultiType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GraderMultiTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GraderPythonType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GraderPythonTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GraderPythonType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GraderPythonTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GraderScoreModelType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GraderScoreModelTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GraderScoreModelType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GraderScoreModelTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GraderStringCheckType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GraderStringCheckTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GraderStringCheckType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GraderStringCheckTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GraderStringCheckOperation))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GraderStringCheckOperationJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GraderStringCheckOperation?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GraderStringCheckOperationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GraderTextSimilarityType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GraderTextSimilarityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GraderTextSimilarityType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GraderTextSimilarityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GraderTextSimilarityEvaluationMetric))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GraderTextSimilarityEvaluationMetricJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GraderTextSimilarityEvaluationMetric?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GraderTextSimilarityEvaluationMetricNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputAudioType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputAudioTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputAudioType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputAudioTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputAudioInputAudio1Format))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputAudioInputAudio1FormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputAudioInputAudio1Format?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputAudioInputAudio1FormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningEffortEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningEffortEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheBreakpointConfigModeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheBreakpointConfigModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputTextContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputTextContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputTextContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputTextContentTypeNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.IList<double>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_887498FFA805A692(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_952828133D79EAE4(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalItemContentItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_9B82F5617E524F86(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EvalItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_EvalItem(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EvalItemContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_EvalItemContent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EvalItemContentItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_EvalItemContentItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EvalItemContentOutputText))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_EvalItemContentOutputText(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EvalItemContentOutputTextType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_EvalItemContentOutputTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EvalItemInputImage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_EvalItemInputImage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EvalItemInputImageType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_EvalItemInputImageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EvalItemRole))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_EvalItemRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EvalItemType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_EvalItemType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GraderMulti))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_GraderMulti(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GraderMultiType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_GraderMultiType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GraderPython))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_GraderPython(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GraderPythonType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_GraderPythonType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GraderScoreModel))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_GraderScoreModel(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GraderScoreModelSamplingParams))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_GraderScoreModelSamplingParams(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GraderScoreModelType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_GraderScoreModelType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GraderStringCheck))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_GraderStringCheck(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GraderStringCheckOperation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_GraderStringCheckOperation2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GraderStringCheckType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_GraderStringCheckType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GraderTextSimilarity))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_GraderTextSimilarity(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GraderTextSimilarityEvaluationMetric))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_GraderTextSimilarityEvaluationMetric2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GraderTextSimilarityType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_GraderTextSimilarityType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputAudio))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InputAudio(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputAudioInputAudio1))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InputAudioInputAudio1(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputAudioInputAudio1Format))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InputAudioInputAudio1Format2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputAudioType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InputAudioType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputTextContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InputTextContent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputTextContentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InputTextContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.GraderStringCheck, global::tryAGI.OpenAI.GraderTextSimilarity, global::tryAGI.OpenAI.GraderPython, global::tryAGI.OpenAI.GraderScoreModel, global::tryAGI.OpenAI.GraderMulti>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_B07EAD259BFB2AEE(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfig))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_PromptCacheBreakpointConfig(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_PromptCacheBreakpointConfigMode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ReasoningEffortEnum2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunGraderRequest))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunGraderRequest(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunGraderResponse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunGraderResponse(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunGraderResponseMetadata))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunGraderResponseMetadata(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunGraderResponseMetadataErrors))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunGraderResponseMetadataErrors(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunGraderResponseMetadataTokenUsage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RunGraderResponseMetadataTokenUsage(options);
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
                if (type == typeof(global::tryAGI.OpenAI.EvalItemContent?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableEvalItemContent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EvalItemContentItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableEvalItemContentItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EvalItemContentOutputTextType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableEvalItemContentOutputTextType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EvalItemInputImageType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableEvalItemInputImageType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EvalItemRole?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableEvalItemRole2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.EvalItemType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableEvalItemType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GraderMultiType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableGraderMultiType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GraderPythonType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableGraderPythonType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GraderScoreModelType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableGraderScoreModelType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GraderStringCheckOperation?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableGraderStringCheckOperation2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GraderStringCheckType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableGraderStringCheckType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GraderTextSimilarityEvaluationMetric?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableGraderTextSimilarityEvaluationMetric2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.GraderTextSimilarityType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableGraderTextSimilarityType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputAudioInputAudio1Format?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInputAudioInputAudio1Format2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputAudioType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInputAudioType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputTextContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInputTextContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.GraderStringCheck, global::tryAGI.OpenAI.GraderTextSimilarity, global::tryAGI.OpenAI.GraderPython, global::tryAGI.OpenAI.GraderScoreModel, global::tryAGI.OpenAI.GraderMulti>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_61F3E8DE917D3EAC(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePromptCacheBreakpointConfigMode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableReasoningEffortEnum2(options);
                }
                if (type == typeof(int?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<double>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_D64E05E278D4AE77(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.EvalItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_E868131C1412E9D7(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.EvalItemContentItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_561CF6464C64928C(options);
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