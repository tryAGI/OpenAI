
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_912A176CC5121550 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_912A176CC5121550 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_912A176CC5121550(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.CreateTranscriptionResponseStreamEventJsonConverter());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEventDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEventDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextSegmentEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextSegmentEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextUsageTokensType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextUsageTokensType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEventDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateTranscriptionResponseStreamEventDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEventDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateTranscriptionResponseStreamEventDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TranscriptTextDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TranscriptTextDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TranscriptTextDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TranscriptTextDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextSegmentEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TranscriptTextSegmentEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextSegmentEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TranscriptTextSegmentEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextUsageTokensType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TranscriptTextUsageTokensTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TranscriptTextUsageTokensType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TranscriptTextUsageTokensTypeNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptTextDeltaEventLogprob>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_A379040801E1C452(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptTextDoneEventLogprob>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_56B2281E9902704B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionLanguage>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_6C42539DFDAB3193(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<long>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_FFC153334BACEC95(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateTranscriptionResponseStreamEvent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEventDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateTranscriptionResponseStreamEventDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEventDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateTranscriptionResponseStreamEventDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TranscriptTextDeltaEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_TranscriptTextDeltaEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TranscriptTextDeltaEventLogprob))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_TranscriptTextDeltaEventLogprob(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TranscriptTextDeltaEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_TranscriptTextDeltaEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TranscriptTextDoneEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_TranscriptTextDoneEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TranscriptTextDoneEventLogprob))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_TranscriptTextDoneEventLogprob(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TranscriptTextDoneEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_TranscriptTextDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TranscriptTextSegmentEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_TranscriptTextSegmentEvent(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TranscriptTextSegmentEventType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_TranscriptTextSegmentEventType2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.TranscriptionLanguage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_TranscriptionLanguage(options);
                }
                if (type == typeof(int))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(double?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableDouble(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEvent?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateTranscriptionResponseStreamEvent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEventDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateTranscriptionResponseStreamEventDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TranscriptTextDeltaEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableTranscriptTextDeltaEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TranscriptTextDoneEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableTranscriptTextDoneEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TranscriptTextSegmentEventType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableTranscriptTextSegmentEventType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.TranscriptTextUsageTokensType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableTranscriptTextUsageTokensType2(options);
                }
                if (type == typeof(int?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.TranscriptTextDeltaEventLogprob>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_6A2AEE80B9BC1A94(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.TranscriptTextDoneEventLogprob>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_421D9A8F9BB7B5AA(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.TranscriptionLanguage>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_2B6860664FDA6466(options);
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