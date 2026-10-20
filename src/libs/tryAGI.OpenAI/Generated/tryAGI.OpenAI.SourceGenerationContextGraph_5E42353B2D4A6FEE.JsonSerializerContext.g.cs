
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_5E42353B2D4A6FEE : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_5E42353B2D4A6FEE Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_5E42353B2D4A6FEE(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.CreateTranscriptionResponseDiarizedJsonUsageJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.TranscriptTextUsageTokens, global::tryAGI.OpenAI.TranscriptTextUsageDuration>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.TranscriptTextUsageTokens, global::tryAGI.OpenAI.TranscriptTextUsageDuration>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.TranscriptTextUsageTokens, global::tryAGI.OpenAI.TranscriptTextUsageDuration>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<global::tryAGI.OpenAI.CreateTranscriptionResponseJson, global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJson, global::tryAGI.OpenAI.CreateTranscriptionResponseVerboseJson>());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonTask)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonTask?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsageDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsageDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextUsageDurationType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextUsageDurationType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextUsageTokensType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextUsageTokensType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptionDiarizedSegmentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptionDiarizedSegmentType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonTask))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateTranscriptionResponseDiarizedJsonTaskJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonTask?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateTranscriptionResponseDiarizedJsonTaskNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsageDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateTranscriptionResponseDiarizedJsonUsageDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsageDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateTranscriptionResponseDiarizedJsonUsageDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextUsageDurationType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TranscriptTextUsageDurationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextUsageDurationType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TranscriptTextUsageDurationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextUsageTokensType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TranscriptTextUsageTokensTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextUsageTokensType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TranscriptTextUsageTokensTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptionDiarizedSegmentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TranscriptionDiarizedSegmentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptionDiarizedSegmentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TranscriptionDiarizedSegmentTypeNullableJsonConverter();
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
                if (type == typeof(float))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Single(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<double>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_887498FFA805A692(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateTranscriptionResponseJsonLogprob>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_F301FD4002FD4401(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionDiarizedSegment>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_7E84B4C4152BF688(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionLanguage>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_6C42539DFDAB3193(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionSegment>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_34FCACEFF6DD622B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionWord>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_76D52150FAB7128C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<int>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_827998FE1115C670(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.CreateTranscriptionResponseJson, global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJson, global::tryAGI.OpenAI.CreateTranscriptionResponseVerboseJson>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_596577AE7A5170ED(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJson))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateTranscriptionResponseDiarizedJson(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonTask))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateTranscriptionResponseDiarizedJsonTask2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateTranscriptionResponseDiarizedJsonUsage2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsageDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateTranscriptionResponseDiarizedJsonUsageDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsageDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateTranscriptionResponseDiarizedJsonUsageDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseJson))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateTranscriptionResponseJson(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseJsonLogprob))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateTranscriptionResponseJsonLogprob(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseVerboseJson))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateTranscriptionResponseVerboseJson(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.TranscriptTextUsageTokens, global::tryAGI.OpenAI.TranscriptTextUsageDuration>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_DE27E23B1BD046E0(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TranscriptTextUsageDuration))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_TranscriptTextUsageDuration(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TranscriptTextUsageDurationType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_TranscriptTextUsageDurationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TranscriptTextUsageTokens))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_TranscriptTextUsageTokens(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TranscriptTextUsageTokensInputTokenDetails))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_TranscriptTextUsageTokensInputTokenDetails(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TranscriptTextUsageTokensType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_TranscriptTextUsageTokensType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TranscriptionDiarizedSegment))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_TranscriptionDiarizedSegment(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TranscriptionDiarizedSegmentType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_TranscriptionDiarizedSegmentType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TranscriptionLanguage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_TranscriptionLanguage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TranscriptionSegment))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_TranscriptionSegment(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TranscriptionWord))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_TranscriptionWord(options);
                }
                if (type == typeof(int))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(double?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableDouble(options);
                }
                if (type == typeof(float?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableSingle(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.CreateTranscriptionResponseJson, global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJson, global::tryAGI.OpenAI.CreateTranscriptionResponseVerboseJson>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_AB824D562BD8D6BE(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonTask?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateTranscriptionResponseDiarizedJsonTask2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsage?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateTranscriptionResponseDiarizedJsonUsage2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsageDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateTranscriptionResponseDiarizedJsonUsageDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.TranscriptTextUsageTokens, global::tryAGI.OpenAI.TranscriptTextUsageDuration>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_D0ABE68F8D52139B(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TranscriptTextUsageDurationType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableTranscriptTextUsageDurationType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TranscriptTextUsageTokensType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableTranscriptTextUsageTokensType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TranscriptionDiarizedSegmentType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableTranscriptionDiarizedSegmentType2(options);
                }
                if (type == typeof(int?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<double>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_D64E05E278D4AE77(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CreateTranscriptionResponseJsonLogprob>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_B33FC704EB658B53(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.TranscriptionDiarizedSegment>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_06B1B3A17B631070(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.TranscriptionLanguage>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_2B6860664FDA6466(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.TranscriptionSegment>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_336886B8B76759C8(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.TranscriptionWord>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_0EA8F4E2E39D742D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<int>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_2058AC0D316B5916(options);
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