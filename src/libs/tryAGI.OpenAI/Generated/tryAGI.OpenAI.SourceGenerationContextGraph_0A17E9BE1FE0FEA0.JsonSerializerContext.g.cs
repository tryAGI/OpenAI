
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_0A17E9BE1FE0FEA0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_0A17E9BE1FE0FEA0 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_0A17E9BE1FE0FEA0(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ResultsItem2JsonConverter());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.ProvenanceCheckObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProvenanceCheckObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProvenanceDetectionResultApi)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProvenanceDetectionResultApi?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.C2PAValidationStateApi)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.C2PAValidationStateApi?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.C2PAProvenanceResultType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.C2PAProvenanceResultType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SynthIDProvenanceResultType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SynthIDProvenanceResultType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProvenanceResourceResultDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProvenanceResourceResultDiscriminatorType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProvenanceCheckObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProvenanceCheckObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProvenanceCheckObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProvenanceCheckObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProvenanceDetectionResultApi))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProvenanceDetectionResultApiJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProvenanceDetectionResultApi?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProvenanceDetectionResultApiNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.C2PAValidationStateApi))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.C2PAValidationStateApiJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.C2PAValidationStateApi?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.C2PAValidationStateApiNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.C2PAProvenanceResultType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.C2PAProvenanceResultTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.C2PAProvenanceResultType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.C2PAProvenanceResultTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SynthIDProvenanceResultType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SynthIDProvenanceResultTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SynthIDProvenanceResultType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SynthIDProvenanceResultTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProvenanceResourceResultDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProvenanceResourceResultDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProvenanceResourceResultDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProvenanceResourceResultDiscriminatorTypeNullableJsonConverter();
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
                if (type == typeof(byte))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_Byte(options);
                }
                if (type == typeof(byte[]))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ByteArray(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResultsItem2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_EFAE07387EB73359(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.C2PAProvenanceResult))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_C2PAProvenanceResult(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.C2PAProvenanceResultType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_C2PAProvenanceResultType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.C2PAValidationStateApi))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_C2PAValidationStateApi2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateContentProvenanceBody))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_CreateContentProvenanceBody(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ProvenanceCheckObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ProvenanceCheckObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ProvenanceDetectionResultApi))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ProvenanceDetectionResultApi2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ProvenanceResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ProvenanceResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ProvenanceResourceResultDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ProvenanceResourceResultDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ProvenanceResourceResultDiscriminatorType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ProvenanceResourceResultDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResultsItem2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_ResultsItem22(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SynthIDProvenanceResult))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SynthIDProvenanceResult(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SynthIDProvenanceResultType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SynthIDProvenanceResultType2(options);
                }
                if (type == typeof(int))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(byte?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_NullableByte(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.C2PAProvenanceResultType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableC2PAProvenanceResultType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.C2PAValidationStateApi?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableC2PAValidationStateApi2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ProvenanceCheckObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableProvenanceCheckObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ProvenanceDetectionResultApi?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableProvenanceDetectionResultApi2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ProvenanceResourceResultDiscriminatorType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableProvenanceResourceResultDiscriminatorType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResultsItem2?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableResultsItem22(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SynthIDProvenanceResultType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableSynthIDProvenanceResultType2(options);
                }
                if (type == typeof(int?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ResultsItem2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_B69723E60750A789(options);
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