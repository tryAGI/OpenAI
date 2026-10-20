
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_DE5251A066F8AE15 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_DE5251A066F8AE15 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_DE5251A066F8AE15(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.CreateTranscriptionRequestModel?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<global::tryAGI.OpenAI.CreateTranscriptionRequestChunkingStrategyVariant1?, global::tryAGI.OpenAI.VadConfig>());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.AudioResponseFormat)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AudioResponseFormat?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionRequestModel)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionRequestModel?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionRequestTimestampGranularitie)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionRequestTimestampGranularitie?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionRequestChunkingStrategyVariant1)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionRequestChunkingStrategyVariant1?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptionInclude)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptionInclude?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VadConfigType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VadConfigType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.AudioResponseFormat))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AudioResponseFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AudioResponseFormat?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AudioResponseFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionRequestModel))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateTranscriptionRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionRequestModel?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateTranscriptionRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionRequestTimestampGranularitie))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateTranscriptionRequestTimestampGranularitieJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionRequestTimestampGranularitie?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateTranscriptionRequestTimestampGranularitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionRequestChunkingStrategyVariant1))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateTranscriptionRequestChunkingStrategyVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionRequestChunkingStrategyVariant1?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateTranscriptionRequestChunkingStrategyVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptionInclude))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TranscriptionIncludeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptionInclude?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TranscriptionIncludeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VadConfigType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VadConfigTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VadConfigType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VadConfigTypeNullableJsonConverter();
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
                if (type == typeof(byte))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_Byte(options);
                }
                if (type == typeof(byte[]))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ByteArray(options);
                }
                if (type == typeof(double))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Double(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateTranscriptionRequestTimestampGranularitie>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_EDDB8D9E266974FC(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionInclude>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_9C53476E94F21618(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_05BF36C073875770(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.CreateTranscriptionRequestChunkingStrategyVariant1?, global::tryAGI.OpenAI.VadConfig>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_CD299BE5BCFB462A(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateTranscriptionRequestModel?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_A92602AB6BF67CC3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AudioResponseFormat))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_AudioResponseFormat2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateTranscriptionRequest))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateTranscriptionRequest(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateTranscriptionRequestChunkingStrategyVariant1))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateTranscriptionRequestChunkingStrategyVariant12(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateTranscriptionRequestModel))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateTranscriptionRequestModel2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateTranscriptionRequestTimestampGranularitie))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateTranscriptionRequestTimestampGranularitie2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TranscriptionInclude))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_TranscriptionInclude2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VadConfig))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_VadConfig(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VadConfigType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_VadConfigType2(options);
                }
                if (type == typeof(int))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(bool?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableBoolean(options);
                }
                if (type == typeof(byte?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableByte(options);
                }
                if (type == typeof(double?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableDouble(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateTranscriptionRequestModel?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_23B8C769FBB9E17A(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AudioResponseFormat?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableAudioResponseFormat2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateTranscriptionRequestChunkingStrategyVariant1?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateTranscriptionRequestChunkingStrategyVariant12(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateTranscriptionRequestModel?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateTranscriptionRequestModel2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateTranscriptionRequestTimestampGranularitie?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateTranscriptionRequestTimestampGranularitie2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TranscriptionInclude?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableTranscriptionInclude2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VadConfigType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableVadConfigType2(options);
                }
                if (type == typeof(int?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateTranscriptionRequestTimestampGranularitie>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_17BDD472A3A8A0B9(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.TranscriptionInclude>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_8CDF988B18D250BF(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_3F34DBFD50DE05D2(options);
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