
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_5548EEF51EA17938 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_5548EEF51EA17938 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_5548EEF51EA17938(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ResultsItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.CostsResultQuantityUnit?>());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.CostsResultApiSource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CostsResultApiSource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CostsResultObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CostsResultObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CostsResultQuantityUnit)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CostsResultQuantityUnit?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageAudioSpeechesResultObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageAudioSpeechesResultObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageAudioTranscriptionsResultObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageAudioTranscriptionsResultObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResultObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResultObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageCompletionsResultApiSource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageCompletionsResultApiSource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageCompletionsResultObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageCompletionsResultObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageEmbeddingsResultObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageEmbeddingsResultObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageFileSearchCallsResultObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageFileSearchCallsResultObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageImagesResultObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageImagesResultObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageModerationsResultObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageModerationsResultObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageResponseObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageResponseObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageTimeBucketObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageTimeBucketObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageTimeBucketResultDiscriminatorObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageTimeBucketResultDiscriminatorObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageVectorStoresResultObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageVectorStoresResultObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageWebSearchCallsResultApiSource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageWebSearchCallsResultApiSource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageWebSearchCallsResultObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UsageWebSearchCallsResultObject?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.CostsResultApiSource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CostsResultApiSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CostsResultApiSource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CostsResultApiSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CostsResultObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CostsResultObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CostsResultObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CostsResultObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CostsResultQuantityUnit))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CostsResultQuantityUnitJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CostsResultQuantityUnit?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CostsResultQuantityUnitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageAudioSpeechesResultObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageAudioSpeechesResultObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageAudioSpeechesResultObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageAudioSpeechesResultObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageAudioTranscriptionsResultObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageAudioTranscriptionsResultObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageAudioTranscriptionsResultObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageAudioTranscriptionsResultObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResultObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageCodeInterpreterSessionsResultObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResultObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageCodeInterpreterSessionsResultObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageCompletionsResultApiSource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageCompletionsResultApiSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageCompletionsResultApiSource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageCompletionsResultApiSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageCompletionsResultObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageCompletionsResultObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageCompletionsResultObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageCompletionsResultObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageEmbeddingsResultObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageEmbeddingsResultObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageEmbeddingsResultObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageEmbeddingsResultObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageFileSearchCallsResultObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageFileSearchCallsResultObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageFileSearchCallsResultObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageFileSearchCallsResultObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageImagesResultObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageImagesResultObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageImagesResultObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageImagesResultObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageModerationsResultObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageModerationsResultObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageModerationsResultObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageModerationsResultObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageResponseObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageResponseObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageTimeBucketObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageTimeBucketObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageTimeBucketObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageTimeBucketObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageTimeBucketResultDiscriminatorObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageTimeBucketResultDiscriminatorObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageTimeBucketResultDiscriminatorObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageTimeBucketResultDiscriminatorObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageVectorStoresResultObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageVectorStoresResultObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageVectorStoresResultObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageVectorStoresResultObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageWebSearchCallsResultApiSource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageWebSearchCallsResultApiSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageWebSearchCallsResultApiSource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageWebSearchCallsResultApiSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageWebSearchCallsResultObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageWebSearchCallsResultObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UsageWebSearchCallsResultObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UsageWebSearchCallsResultObjectNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResultsItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_0D768E4030223393(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageTimeBucket>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_94B332B3119BDA52(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CostsResultQuantityUnit?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_BBB0297508265D97(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CostsResult))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CostsResult(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CostsResultAmount))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CostsResultAmount(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CostsResultApiSource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CostsResultApiSource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CostsResultObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CostsResultObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CostsResultQuantityUnit))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CostsResultQuantityUnit2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResultsItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResultsItem2_3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageAudioSpeechesResult))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UsageAudioSpeechesResult(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageAudioSpeechesResultObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UsageAudioSpeechesResultObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageAudioTranscriptionsResult))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UsageAudioTranscriptionsResult(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageAudioTranscriptionsResultObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UsageAudioTranscriptionsResultObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UsageCodeInterpreterSessionsResult(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResultObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UsageCodeInterpreterSessionsResultObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageCompletionsResult))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UsageCompletionsResult(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageCompletionsResultApiSource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UsageCompletionsResultApiSource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageCompletionsResultObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UsageCompletionsResultObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageEmbeddingsResult))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UsageEmbeddingsResult(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageEmbeddingsResultObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UsageEmbeddingsResultObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageFileSearchCallsResult))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UsageFileSearchCallsResult(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageFileSearchCallsResultObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UsageFileSearchCallsResultObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageImagesResult))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UsageImagesResult(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageImagesResultObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UsageImagesResultObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageModerationsResult))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UsageModerationsResult(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageModerationsResultObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UsageModerationsResultObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageResponse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UsageResponse(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageResponseObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UsageResponseObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageTimeBucket))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UsageTimeBucket(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageTimeBucketObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UsageTimeBucketObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageTimeBucketResultDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UsageTimeBucketResultDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageTimeBucketResultDiscriminatorObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UsageTimeBucketResultDiscriminatorObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageVectorStoresResult))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UsageVectorStoresResult(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageVectorStoresResultObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UsageVectorStoresResultObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageWebSearchCallsResult))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UsageWebSearchCallsResult(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageWebSearchCallsResultApiSource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UsageWebSearchCallsResultApiSource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageWebSearchCallsResultObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_UsageWebSearchCallsResultObject2(options);
                }
                if (type == typeof(int))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Int32(options);
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
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CostsResultQuantityUnit?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_7B726319E59B428F(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CostsResultApiSource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableCostsResultApiSource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CostsResultObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableCostsResultObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CostsResultQuantityUnit?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableCostsResultQuantityUnit2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResultsItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResultsItem2_3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageAudioSpeechesResultObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableUsageAudioSpeechesResultObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageAudioTranscriptionsResultObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableUsageAudioTranscriptionsResultObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResultObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableUsageCodeInterpreterSessionsResultObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageCompletionsResultApiSource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableUsageCompletionsResultApiSource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageCompletionsResultObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableUsageCompletionsResultObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageEmbeddingsResultObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableUsageEmbeddingsResultObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageFileSearchCallsResultObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableUsageFileSearchCallsResultObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageImagesResultObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableUsageImagesResultObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageModerationsResultObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableUsageModerationsResultObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageResponseObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableUsageResponseObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageTimeBucketObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableUsageTimeBucketObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageTimeBucketResultDiscriminatorObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableUsageTimeBucketResultDiscriminatorObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageVectorStoresResultObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableUsageVectorStoresResultObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageWebSearchCallsResultApiSource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableUsageWebSearchCallsResultApiSource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageWebSearchCallsResultObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableUsageWebSearchCallsResultObject2(options);
                }
                if (type == typeof(int?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt32(options);
                }
                if (type == typeof(long?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt64(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ResultsItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_8AA34EBD6F280591(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.UsageTimeBucket>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_9DD51BBEC280F36B(options);
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