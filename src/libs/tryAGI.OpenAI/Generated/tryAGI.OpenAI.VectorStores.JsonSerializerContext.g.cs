
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    public sealed partial class VectorStoresSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static VectorStoresSourceGenerationContext Default { get; } = new(DefaultOptions);

        private VectorStoresSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            global::tryAGI.OpenAI.SourceGenerationContextGraph_739E11B61712D063.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_44C20A7116AFF153.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_473287F8298DBA71.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_A716290244FED014.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_8B08594418CEDD7C.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_01286B345C7FB528.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_FC0ACBA26C044EC8.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_04B9FD22C3E755C9.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_CCF83E0D3376EF2B.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_2958D416D08AA5A4.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_FBC815AE62874346.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_7A1B7AB04233C0CB.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_93FE7D159B8B5F6C.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_FA029D9E4AEB3F59.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_6DA88C34BA124C41.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_FBD3466004A1EB6C.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_93A74B59E63CC861.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_F395E46F2A6DBC4B.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_29A6266F45380E7E.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_23D18EF715F13F8A.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_F30C0AC826D91119.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_B760F44FA5965C24.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_0368034CD03FD845.AddConverters(options);
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

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[23];

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
                    0 => global::tryAGI.OpenAI.SourceGenerationContextGraph_739E11B61712D063.TypeInfoResolver,

                    1 => global::tryAGI.OpenAI.SourceGenerationContextGraph_44C20A7116AFF153.TypeInfoResolver,

                    2 => global::tryAGI.OpenAI.SourceGenerationContextGraph_473287F8298DBA71.TypeInfoResolver,

                    3 => global::tryAGI.OpenAI.SourceGenerationContextGraph_A716290244FED014.TypeInfoResolver,

                    4 => global::tryAGI.OpenAI.SourceGenerationContextGraph_8B08594418CEDD7C.TypeInfoResolver,

                    5 => global::tryAGI.OpenAI.SourceGenerationContextGraph_01286B345C7FB528.TypeInfoResolver,

                    6 => global::tryAGI.OpenAI.SourceGenerationContextGraph_FC0ACBA26C044EC8.TypeInfoResolver,

                    7 => global::tryAGI.OpenAI.SourceGenerationContextGraph_04B9FD22C3E755C9.TypeInfoResolver,

                    8 => global::tryAGI.OpenAI.SourceGenerationContextGraph_CCF83E0D3376EF2B.TypeInfoResolver,

                    9 => global::tryAGI.OpenAI.SourceGenerationContextGraph_2958D416D08AA5A4.TypeInfoResolver,

                    10 => global::tryAGI.OpenAI.SourceGenerationContextGraph_FBC815AE62874346.TypeInfoResolver,

                    11 => global::tryAGI.OpenAI.SourceGenerationContextGraph_7A1B7AB04233C0CB.TypeInfoResolver,

                    12 => global::tryAGI.OpenAI.SourceGenerationContextGraph_93FE7D159B8B5F6C.TypeInfoResolver,

                    13 => global::tryAGI.OpenAI.SourceGenerationContextGraph_FA029D9E4AEB3F59.TypeInfoResolver,

                    14 => global::tryAGI.OpenAI.SourceGenerationContextGraph_6DA88C34BA124C41.TypeInfoResolver,

                    15 => global::tryAGI.OpenAI.SourceGenerationContextGraph_FBD3466004A1EB6C.TypeInfoResolver,

                    16 => global::tryAGI.OpenAI.SourceGenerationContextGraph_93A74B59E63CC861.TypeInfoResolver,

                    17 => global::tryAGI.OpenAI.SourceGenerationContextGraph_F395E46F2A6DBC4B.TypeInfoResolver,

                    18 => global::tryAGI.OpenAI.SourceGenerationContextGraph_29A6266F45380E7E.TypeInfoResolver,

                    19 => global::tryAGI.OpenAI.SourceGenerationContextGraph_23D18EF715F13F8A.TypeInfoResolver,

                    20 => global::tryAGI.OpenAI.SourceGenerationContextGraph_F30C0AC826D91119.TypeInfoResolver,

                    21 => global::tryAGI.OpenAI.SourceGenerationContextGraph_B760F44FA5965C24.TypeInfoResolver,

                    22 => global::tryAGI.OpenAI.SourceGenerationContextGraph_0368034CD03FD845.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}