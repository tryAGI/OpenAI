
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_3955DA790BE5CE10 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_3955DA790BE5CE10 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_3955DA790BE5CE10(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.DecisionsUsageErrorDetails, string>());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.DecisionsUsageBucketWidth)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DecisionsUsageBucketWidth?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DecisionsUsageGroupBy)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DecisionsUsageGroupBy?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DecisionsUsageApiSource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DecisionsUsageApiSource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DecisionsUsageResultObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DecisionsUsageResultObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DecisionsUsageBucketObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DecisionsUsageBucketObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PublicDecisionsUsageResponseResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PublicDecisionsUsageResponseResourceObject?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionsUsageBucketWidth))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionsUsageBucketWidthJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionsUsageBucketWidth?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionsUsageBucketWidthNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionsUsageGroupBy))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionsUsageGroupByJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionsUsageGroupBy?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionsUsageGroupByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionsUsageApiSource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionsUsageApiSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionsUsageApiSource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionsUsageApiSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionsUsageResultObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionsUsageResultObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionsUsageResultObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionsUsageResultObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionsUsageBucketObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionsUsageBucketObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DecisionsUsageBucketObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DecisionsUsageBucketObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PublicDecisionsUsageResponseResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PublicDecisionsUsageResponseResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PublicDecisionsUsageResponseResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PublicDecisionsUsageResponseResourceObjectNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionsUsageBucket>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_AA17A4DC4A7A326C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionsUsageGroupBy>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_5F3E81B2E4147B69(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionsUsageResult>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_986C1A1730F4C9AB(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionsUsageApiSource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionsUsageApiSource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionsUsageBucket))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionsUsageBucket(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionsUsageBucketObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionsUsageBucketObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionsUsageBucketWidth))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionsUsageBucketWidth2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionsUsageErrorDetails))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionsUsageErrorDetails(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionsUsageErrorResponse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionsUsageErrorResponse(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionsUsageGroupBy))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionsUsageGroupBy2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionsUsagePermissionErrorResponse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionsUsagePermissionErrorResponse(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionsUsageResult))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionsUsageResult(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionsUsageResultObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_DecisionsUsageResultObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.DecisionsUsageErrorDetails, string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_6CE95F0C91499AC4(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PublicDecisionsUsageResponseResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_PublicDecisionsUsageResponseResource(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PublicDecisionsUsageResponseResourceObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_PublicDecisionsUsageResponseResourceObject2(options);
                }
                if (type == typeof(int))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(bool?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableBoolean(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionsUsageApiSource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableDecisionsUsageApiSource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionsUsageBucketObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableDecisionsUsageBucketObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionsUsageBucketWidth?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableDecisionsUsageBucketWidth2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionsUsageGroupBy?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableDecisionsUsageGroupBy2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionsUsageResultObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableDecisionsUsageResultObject2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.DecisionsUsageErrorDetails, string>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_3CB1161F053ED939(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PublicDecisionsUsageResponseResourceObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullablePublicDecisionsUsageResponseResourceObject2(options);
                }
                if (type == typeof(int?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.DecisionsUsageBucket>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_A9413208C96F6912(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.DecisionsUsageGroupBy>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_E474C223376D5882(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.DecisionsUsageResult>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_B85DE868544E55EF(options);
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