
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextOrphans_62C29966B33E6A06 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextOrphans_62C29966B33E6A06 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextOrphans_62C29966B33E6A06(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaAnnotationJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaInputContentJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaOutputContentJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaContentJsonConverter());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputFileContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputFileContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileInputDetail)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileInputDetail?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheBreakpointConfigMode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheBreakpointConfigMode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputImageContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputImageContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageDetail)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageDetail?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputTextContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputTextContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningTextContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningTextContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaRefusalContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaRefusalContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputTextContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputTextContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAnnotationDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAnnotationDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFilePathType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFilePathType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerFileCitationBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerFileCitationBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaUrlCitationBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaUrlCitationBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileCitationBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileCitationBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputContentDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputContentDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputContentDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputContentDiscriminatorType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputFileContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputFileContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputFileContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputFileContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileInputDetail))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFileInputDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileInputDetail?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFileInputDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheBreakpointConfigMode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheBreakpointConfigModeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheBreakpointConfigMode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheBreakpointConfigModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputImageContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputImageContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputImageContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputImageContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageDetail))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageDetail?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputTextContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputTextContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputTextContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputTextContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningTextContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningTextContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningTextContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningTextContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaRefusalContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaRefusalContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaRefusalContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaRefusalContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputTextContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaOutputTextContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputTextContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaOutputTextContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAnnotationDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAnnotationDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAnnotationDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAnnotationDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFilePathType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFilePathTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFilePathType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFilePathTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerFileCitationBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerFileCitationBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerFileCitationBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerFileCitationBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaUrlCitationBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaUrlCitationBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaUrlCitationBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaUrlCitationBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileCitationBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFileCitationBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileCitationBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFileCitationBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputContentDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputContentDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputContentDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputContentDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputContentDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaOutputContentDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputContentDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaOutputContentDiscriminatorTypeNullableJsonConverter();
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
                if (type == typeof(double))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Double(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaAnnotation>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_28627596212A6D1F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaLogProb>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_BCFC6F2E7FEDB48B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaTopLogProb>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_D95F66A199316195(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<long>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_FFC153334BACEC95(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAnnotation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaAnnotation(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAnnotationDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaAnnotationDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAnnotationDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaAnnotationDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerFileCitationBody))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaContainerFileCitationBody(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerFileCitationBodyType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaContainerFileCitationBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaContent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFileCitationBody))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFileCitationBody(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFileCitationBodyType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFileCitationBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFileInputDetail))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFileInputDetail2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFilePath))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFilePath(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFilePathType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFilePathType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageDetail))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaImageDetail2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInputContent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputContentDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInputContentDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputContentDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInputContentDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputFileContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInputFileContent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputFileContentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInputFileContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputImageContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInputImageContent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputImageContentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInputImageContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputTextContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInputTextContent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputTextContentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaInputTextContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaLogProb))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaLogProb(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaOutputContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaOutputContent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaOutputContentDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaOutputContentDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaOutputContentDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaOutputContentDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaOutputTextContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaOutputTextContent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaOutputTextContentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaOutputTextContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaPromptCacheBreakpointConfig))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaPromptCacheBreakpointConfig(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaPromptCacheBreakpointConfigMode))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaPromptCacheBreakpointConfigMode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaReasoningTextContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaReasoningTextContent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaReasoningTextContentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaReasoningTextContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaRefusalContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaRefusalContent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaRefusalContentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaRefusalContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaTopLogProb))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaTopLogProb(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaUrlCitationBody))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaUrlCitationBody(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaUrlCitationBodyType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaUrlCitationBodyType2(options);
                }
                if (type == typeof(int))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(double?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableDouble(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaAnnotationDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaAnnotationDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContainerFileCitationBodyType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaContainerFileCitationBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaContent?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaContent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFileCitationBodyType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFileCitationBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFileInputDetail?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFileInputDetail2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFilePathType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFilePathType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageDetail?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaImageDetail2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputContent?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaInputContent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputContentDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaInputContentDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputFileContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaInputFileContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputImageContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaInputImageContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaInputTextContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaInputTextContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaOutputContent?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaOutputContent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaOutputContentDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaOutputContentDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaOutputTextContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaOutputTextContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaPromptCacheBreakpointConfigMode?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaPromptCacheBreakpointConfigMode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaReasoningTextContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaReasoningTextContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaRefusalContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaRefusalContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaUrlCitationBodyType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaUrlCitationBodyType2(options);
                }
                if (type == typeof(int?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaAnnotation>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_FC86392F3B26F72B(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaLogProb>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_35D765866FD83CC4(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaTopLogProb>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_8286E5F200E2BCE7(options);
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