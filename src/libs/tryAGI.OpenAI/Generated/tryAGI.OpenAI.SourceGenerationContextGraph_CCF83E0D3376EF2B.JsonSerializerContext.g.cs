
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_CCF83E0D3376EF2B : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_CCF83E0D3376EF2B Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_CCF83E0D3376EF2B(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.StaticChunkingStrategyResponseParam, global::tryAGI.OpenAI.OtherChunkingStrategyResponseParam>());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.OtherChunkingStrategyResponseParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OtherChunkingStrategyResponseParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.StaticChunkingStrategyResponseParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.StaticChunkingStrategyResponseParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreFileObjectObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreFileObjectObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreFileObjectStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreFileObjectStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreFileObjectLastErrorCode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreFileObjectLastErrorCode?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.OtherChunkingStrategyResponseParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OtherChunkingStrategyResponseParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OtherChunkingStrategyResponseParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OtherChunkingStrategyResponseParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.StaticChunkingStrategyResponseParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.StaticChunkingStrategyResponseParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.StaticChunkingStrategyResponseParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.StaticChunkingStrategyResponseParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreFileObjectObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VectorStoreFileObjectObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreFileObjectObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VectorStoreFileObjectObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreFileObjectStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VectorStoreFileObjectStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreFileObjectStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VectorStoreFileObjectStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreFileObjectLastErrorCode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VectorStoreFileObjectLastErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreFileObjectLastErrorCode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VectorStoreFileObjectLastErrorCodeNullableJsonConverter();
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
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.StaticChunkingStrategyResponseParam, global::tryAGI.OpenAI.OtherChunkingStrategyResponseParam>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_CE97D31616542A99(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OtherChunkingStrategyResponseParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_OtherChunkingStrategyResponseParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OtherChunkingStrategyResponseParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_OtherChunkingStrategyResponseParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.StaticChunkingStrategy))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_StaticChunkingStrategy(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.StaticChunkingStrategyResponseParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_StaticChunkingStrategyResponseParam(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.StaticChunkingStrategyResponseParamType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_StaticChunkingStrategyResponseParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VectorStoreFileObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_VectorStoreFileObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VectorStoreFileObjectLastError))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_VectorStoreFileObjectLastError(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VectorStoreFileObjectLastErrorCode))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_VectorStoreFileObjectLastErrorCode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VectorStoreFileObjectObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_VectorStoreFileObjectObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VectorStoreFileObjectStatus))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_VectorStoreFileObjectStatus2(options);
                }
                if (type == typeof(int))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(long))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Int64(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.StaticChunkingStrategyResponseParam, global::tryAGI.OpenAI.OtherChunkingStrategyResponseParam>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_5DF65B6D1D494DA0(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OtherChunkingStrategyResponseParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableOtherChunkingStrategyResponseParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.StaticChunkingStrategyResponseParamType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableStaticChunkingStrategyResponseParamType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VectorStoreFileObjectLastErrorCode?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableVectorStoreFileObjectLastErrorCode2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VectorStoreFileObjectObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableVectorStoreFileObjectObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VectorStoreFileObjectStatus?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableVectorStoreFileObjectStatus2(options);
                }
                if (type == typeof(int?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt32(options);
                }
                if (type == typeof(long?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt64(options);
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