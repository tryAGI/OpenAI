
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextOrphans_985AFDCDB23A7EF1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextOrphans_985AFDCDB23A7EF1 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextOrphans_985AFDCDB23A7EF1(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::tryAGI.OpenAI.BetaInputTextContent, global::tryAGI.OpenAI.BetaInputImageContent, global::tryAGI.OpenAI.BetaInputFileContent>());
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

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputTextContentType?);
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
                if (type == typeof(global::tryAGI.OpenAI.BetaFileInputDetail))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaFileInputDetail2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageDetail))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaImageDetail2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.BetaPromptCacheBreakpointConfig))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaPromptCacheBreakpointConfig(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaPromptCacheBreakpointConfigMode))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_BetaPromptCacheBreakpointConfigMode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.BetaInputTextContent, global::tryAGI.OpenAI.BetaInputImageContent, global::tryAGI.OpenAI.BetaInputFileContent>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_E7FDF7927E7BB3A1(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaFileInputDetail?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaFileInputDetail2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaImageDetail?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaImageDetail2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.BetaPromptCacheBreakpointConfigMode?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableBetaPromptCacheBreakpointConfigMode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.BetaInputTextContent, global::tryAGI.OpenAI.BetaInputImageContent, global::tryAGI.OpenAI.BetaInputFileContent>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_3DE19103DF421F0A(options);
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