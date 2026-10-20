
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextOrphans_A523CC2880C1D889 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextOrphans_A523CC2880C1D889 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextOrphans_A523CC2880C1D889(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.Content5JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.InputContentJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OutputContentJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnnotationJsonConverter());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.FilePathType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FilePathType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputContentDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputContentDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputContentDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputContentDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputTextContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputTextContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileCitationBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileCitationBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UrlCitationBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UrlCitationBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerFileCitationBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerFileCitationBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AnnotationDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AnnotationDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputTextContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputTextContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningTextContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningTextContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RefusalContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RefusalContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageDetail)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageDetail?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputImageContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputImageContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileInputDetail)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileInputDetail?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputFileContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputFileContentType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.FilePathType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FilePathTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FilePathType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FilePathTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputContentDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputContentDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputContentDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputContentDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OutputContentDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OutputContentDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OutputContentDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OutputContentDiscriminatorTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileCitationBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileCitationBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileCitationBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileCitationBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UrlCitationBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UrlCitationBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UrlCitationBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UrlCitationBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerFileCitationBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerFileCitationBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerFileCitationBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerFileCitationBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AnnotationDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AnnotationDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AnnotationDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AnnotationDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OutputTextContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OutputTextContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OutputTextContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OutputTextContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningTextContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningTextContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningTextContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningTextContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RefusalContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RefusalContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RefusalContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RefusalContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageDetail))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageDetail?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputImageContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputImageContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputImageContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputImageContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileInputDetail))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileInputDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileInputDetail?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileInputDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputFileContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputFileContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputFileContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputFileContentTypeNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Annotation>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_1A1CAD1829DC041F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LogProb>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_55AE7E4369715D72(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TopLogProb>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_E400EC8643C0A721(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<long>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_FFC153334BACEC95(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Annotation))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_Annotation(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnnotationDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AnnotationDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnnotationDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_AnnotationDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContainerFileCitationBody))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ContainerFileCitationBody(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContainerFileCitationBodyType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ContainerFileCitationBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Content5))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Content52(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FileCitationBody))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FileCitationBody(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FileCitationBodyType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FileCitationBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FileInputDetail))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_FileInputDetail2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FilePath))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FilePath(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FilePathType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FilePathType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageDetail))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ImageDetail2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InputContent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContentDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InputContentDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContentDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InputContentDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputFileContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InputFileContent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputFileContentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InputFileContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputImageContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InputImageContent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputImageContentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InputImageContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputTextContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InputTextContent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputTextContentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_InputTextContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LogProb))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_LogProb(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_OutputContent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputContentDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_OutputContentDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputContentDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_OutputContentDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputTextContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_OutputTextContent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputTextContentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_OutputTextContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfig))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_PromptCacheBreakpointConfig(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_PromptCacheBreakpointConfigMode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningTextContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ReasoningTextContent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningTextContentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ReasoningTextContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RefusalContent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_RefusalContent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RefusalContentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_RefusalContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TopLogProb))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_TopLogProb(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UrlCitationBody))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UrlCitationBody(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UrlCitationBodyType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UrlCitationBodyType2(options);
                }
                if (type == typeof(int))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(double?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableDouble(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnnotationDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableAnnotationDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ContainerFileCitationBodyType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableContainerFileCitationBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Content5?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableContent52(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FileCitationBodyType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFileCitationBodyType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FileInputDetail?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFileInputDetail2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FilePathType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableFilePathType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ImageDetail?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableImageDetail2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContent?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInputContent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputContentDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInputContentDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputFileContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInputFileContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputImageContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInputImageContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputTextContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableInputTextContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputContent?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableOutputContent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputContentDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableOutputContentDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputTextContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableOutputTextContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePromptCacheBreakpointConfigMode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ReasoningTextContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableReasoningTextContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RefusalContentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableRefusalContentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UrlCitationBodyType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableUrlCitationBodyType2(options);
                }
                if (type == typeof(int?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Annotation>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_144E4DFF806E92F6(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.LogProb>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_903E0E4F8C7DBAAF(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.TopLogProb>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_958662FD1FB10180(options);
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