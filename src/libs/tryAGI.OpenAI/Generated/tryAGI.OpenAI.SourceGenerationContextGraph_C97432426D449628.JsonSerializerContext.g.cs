
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_C97432426D449628 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_C97432426D449628 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_C97432426D449628(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<byte[], global::System.Collections.Generic.IList<byte[]>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.CreateImageEditRequestModel?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.CreateImageEditRequestSize?>());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestBackground)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestBackground?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestModel)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestModel?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestSize)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestSize?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestResponseFormat)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestResponseFormat?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestOutputFormat)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestOutputFormat?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestQuality)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestQuality?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputFidelity)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputFidelity?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestBackground))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageEditRequestBackgroundJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestBackground?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageEditRequestBackgroundNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestModel))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageEditRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestModel?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageEditRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestSize))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageEditRequestSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestSize?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageEditRequestSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestResponseFormat))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageEditRequestResponseFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestResponseFormat?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageEditRequestResponseFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestOutputFormat))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageEditRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestOutputFormat?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageEditRequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestQuality))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageEditRequestQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateImageEditRequestQuality?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateImageEditRequestQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputFidelity))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputFidelityJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputFidelity?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputFidelityNullableJsonConverter();
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
                if (type == typeof(byte))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_Byte(options);
                }
                if (type == typeof(byte[]))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ByteArray(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<byte[]>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_E287161281C36F74(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<byte[], global::System.Collections.Generic.IList<byte[]>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_00B51D76EF49F087(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageEditRequestModel?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_1B7D3356FB9784C0(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageEditRequestSize?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_9FE8BB059F3CCDBF(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateImageEditRequest))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateImageEditRequest(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateImageEditRequestBackground))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateImageEditRequestBackground2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateImageEditRequestModel))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateImageEditRequestModel2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateImageEditRequestOutputFormat))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateImageEditRequestOutputFormat2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateImageEditRequestQuality))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateImageEditRequestQuality2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.CreateImageEditRequestResponseFormat))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateImageEditRequestResponseFormat2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::tryAGI.OpenAI.CreateImageEditRequestSize))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CreateImageEditRequestSize2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputFidelity))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_InputFidelity2(options);
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
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<byte[], global::System.Collections.Generic.IList<byte[]>>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_E1FE283B9221A90E(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageEditRequestModel?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_C3DD0D9260EFFDD7(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageEditRequestSize?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_17578AF8D16C7AB0(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateImageEditRequestBackground?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableCreateImageEditRequestBackground2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateImageEditRequestModel?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableCreateImageEditRequestModel2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateImageEditRequestOutputFormat?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableCreateImageEditRequestOutputFormat2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CreateImageEditRequestQuality?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableCreateImageEditRequestQuality2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::tryAGI.OpenAI.CreateImageEditRequestResponseFormat?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableCreateImageEditRequestResponseFormat2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::tryAGI.OpenAI.CreateImageEditRequestSize?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableCreateImageEditRequestSize2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.InputFidelity?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInputFidelity2(options);
                }
                if (type == typeof(int?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<byte[]>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_C8A2E9F077B7FE9A(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AnyOf<byte[], global::System.Collections.Generic.List<byte[]>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_002DDF4E7284377E(options);
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