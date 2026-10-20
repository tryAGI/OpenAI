
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_F30C0AC826D91119 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_F30C0AC826D91119 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_F30C0AC826D91119(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.FiltersItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.ComparisonFilter, global::tryAGI.OpenAI.CompoundFilter>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?>());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.ComparisonFilterType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComparisonFilterType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CompoundFilterType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CompoundFilterType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreSearchRequestRankingOptionsRanker)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreSearchRequestRankingOptionsRanker?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreSearchResultContentObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreSearchResultContentObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreSearchResultsPageObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreSearchResultsPageObject?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComparisonFilterType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComparisonFilterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComparisonFilterType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComparisonFilterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CompoundFilterType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CompoundFilterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CompoundFilterType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CompoundFilterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreSearchRequestRankingOptionsRanker))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VectorStoreSearchRequestRankingOptionsRankerJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreSearchRequestRankingOptionsRanker?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VectorStoreSearchRequestRankingOptionsRankerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreSearchResultContentObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VectorStoreSearchResultContentObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreSearchResultContentObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VectorStoreSearchResultContentObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreSearchResultsPageObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VectorStoreSearchResultsPageObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VectorStoreSearchResultsPageObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VectorStoreSearchResultsPageObjectNullableJsonConverter();
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
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FiltersItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_33EE83DB0267626E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_A588C663D689201D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VectorStoreSearchResultContentObject>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_49D7F0B486545BDA(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VectorStoreSearchResultItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_0AD07BE350FD9523(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_05BF36C073875770(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComparisonFilter))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ComparisonFilter(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComparisonFilterType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_ComparisonFilterType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CompoundFilter))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CompoundFilter(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CompoundFilterFilterDiscriminator))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CompoundFilterFilterDiscriminator(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CompoundFilterType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_CompoundFilterType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FiltersItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_FiltersItem2_3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ComparisonFilter, global::tryAGI.OpenAI.CompoundFilter>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_B5ED9CF5E041239E(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_33CE3604D32F85AE(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, double?>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_569B880384C23575(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<string>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_4897B98B90D322FC(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VectorStoreSearchRequest))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_VectorStoreSearchRequest(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VectorStoreSearchRequestRankingOptions))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_VectorStoreSearchRequestRankingOptions(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VectorStoreSearchRequestRankingOptionsRanker))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_VectorStoreSearchRequestRankingOptionsRanker2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VectorStoreSearchResultContentObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_VectorStoreSearchResultContentObject(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VectorStoreSearchResultContentObjectType))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_VectorStoreSearchResultContentObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VectorStoreSearchResultItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_VectorStoreSearchResultItem(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VectorStoreSearchResultsPage))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_VectorStoreSearchResultsPage(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VectorStoreSearchResultsPageObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata1.Create_VectorStoreSearchResultsPageObject2(options);
                }
                if (type == typeof(int))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(bool?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableBoolean(options);
                }
                if (type == typeof(double?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableDouble(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ComparisonFilterType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableComparisonFilterType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.CompoundFilterType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableCompoundFilterType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FiltersItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableFiltersItem2_3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ComparisonFilter, global::tryAGI.OpenAI.CompoundFilter>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_2C80323A7F2E0186(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_01848C29385428F2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, double?>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_528BFF85AF3E2294(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<string>>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_6CBA80EF2CB35010(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VectorStoreSearchRequestRankingOptionsRanker?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableVectorStoreSearchRequestRankingOptionsRanker2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VectorStoreSearchResultContentObjectType?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableVectorStoreSearchResultContentObjectType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.VectorStoreSearchResultsPageObject?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata3.Create_NullableVectorStoreSearchResultsPageObject2(options);
                }
                if (type == typeof(int?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata2.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.FiltersItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_383909F143B415B3(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<string, double?>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_E3941FEAF2607AE9(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.VectorStoreSearchResultContentObject>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_98CAA335E3E4D8A9(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.VectorStoreSearchResultItem>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_0ACC615602A2A9B3(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_3F34DBFD50DE05D2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, double?, bool?, global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<string, double?>>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_C8EB3E0743925723(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<string>>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_D4B5434A24378654(options);
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