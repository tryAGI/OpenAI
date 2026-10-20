
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ProjectsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ProjectsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            global::tryAGI.OpenAI.SourceGenerationContextGraph_E0BA5957E550B16E.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_44C20A7116AFF153.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_8786137D24D818E5.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_473287F8298DBA71.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_A563E44D65D6E026.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_C3E0304EFD6D1A0E.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_B760F44FA5965C24.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_6DA88C34BA124C41.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_2D891CE43414FDE1.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_FE326B426D02C4EC.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_EF15C7F48F0EDB3D.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_73CC848055E0A884.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_253129BA8D4B5354.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_FFF5B3528FED130E.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_B106BB68BF23D063.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_A884C00F24561FBF.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_42A8F3BDE183419B.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_3FB232B901F7A8A1.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_090D5BC89824CEE3.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_BD115FC3B0584E2A.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_49965F0168A96545.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_2C25F7ADD6028355.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_2FC40E08ACC54C0E.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_B08272F412060BAE.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_042D9FCAA761654E.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_01286B345C7FB528.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_3198E96CF56EE4D5.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_4D0C31436DBFDE33.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_0E6AAF10AC64AB6B.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_FC66F021C67D064C.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_77F221EF7C5A730F.AddConverters(options);
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
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[31];

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
                    0 => global::tryAGI.OpenAI.SourceGenerationContextGraph_E0BA5957E550B16E.TypeInfoResolver,

                    1 => global::tryAGI.OpenAI.SourceGenerationContextGraph_44C20A7116AFF153.TypeInfoResolver,

                    2 => global::tryAGI.OpenAI.SourceGenerationContextGraph_8786137D24D818E5.TypeInfoResolver,

                    3 => global::tryAGI.OpenAI.SourceGenerationContextGraph_473287F8298DBA71.TypeInfoResolver,

                    4 => global::tryAGI.OpenAI.SourceGenerationContextGraph_A563E44D65D6E026.TypeInfoResolver,

                    5 => global::tryAGI.OpenAI.SourceGenerationContextGraph_C3E0304EFD6D1A0E.TypeInfoResolver,

                    6 => global::tryAGI.OpenAI.SourceGenerationContextGraph_B760F44FA5965C24.TypeInfoResolver,

                    7 => global::tryAGI.OpenAI.SourceGenerationContextGraph_6DA88C34BA124C41.TypeInfoResolver,

                    8 => global::tryAGI.OpenAI.SourceGenerationContextGraph_2D891CE43414FDE1.TypeInfoResolver,

                    9 => global::tryAGI.OpenAI.SourceGenerationContextGraph_FE326B426D02C4EC.TypeInfoResolver,

                    10 => global::tryAGI.OpenAI.SourceGenerationContextGraph_EF15C7F48F0EDB3D.TypeInfoResolver,

                    11 => global::tryAGI.OpenAI.SourceGenerationContextGraph_73CC848055E0A884.TypeInfoResolver,

                    12 => global::tryAGI.OpenAI.SourceGenerationContextGraph_253129BA8D4B5354.TypeInfoResolver,

                    13 => global::tryAGI.OpenAI.SourceGenerationContextGraph_FFF5B3528FED130E.TypeInfoResolver,

                    14 => global::tryAGI.OpenAI.SourceGenerationContextGraph_B106BB68BF23D063.TypeInfoResolver,

                    15 => global::tryAGI.OpenAI.SourceGenerationContextGraph_A884C00F24561FBF.TypeInfoResolver,

                    16 => global::tryAGI.OpenAI.SourceGenerationContextGraph_42A8F3BDE183419B.TypeInfoResolver,

                    17 => global::tryAGI.OpenAI.SourceGenerationContextGraph_3FB232B901F7A8A1.TypeInfoResolver,

                    18 => global::tryAGI.OpenAI.SourceGenerationContextGraph_090D5BC89824CEE3.TypeInfoResolver,

                    19 => global::tryAGI.OpenAI.SourceGenerationContextGraph_BD115FC3B0584E2A.TypeInfoResolver,

                    20 => global::tryAGI.OpenAI.SourceGenerationContextGraph_49965F0168A96545.TypeInfoResolver,

                    21 => global::tryAGI.OpenAI.SourceGenerationContextGraph_2C25F7ADD6028355.TypeInfoResolver,

                    22 => global::tryAGI.OpenAI.SourceGenerationContextGraph_2FC40E08ACC54C0E.TypeInfoResolver,

                    23 => global::tryAGI.OpenAI.SourceGenerationContextGraph_B08272F412060BAE.TypeInfoResolver,

                    24 => global::tryAGI.OpenAI.SourceGenerationContextGraph_042D9FCAA761654E.TypeInfoResolver,

                    25 => global::tryAGI.OpenAI.SourceGenerationContextGraph_01286B345C7FB528.TypeInfoResolver,

                    26 => global::tryAGI.OpenAI.SourceGenerationContextGraph_3198E96CF56EE4D5.TypeInfoResolver,

                    27 => global::tryAGI.OpenAI.SourceGenerationContextGraph_4D0C31436DBFDE33.TypeInfoResolver,

                    28 => global::tryAGI.OpenAI.SourceGenerationContextGraph_0E6AAF10AC64AB6B.TypeInfoResolver,

                    29 => global::tryAGI.OpenAI.SourceGenerationContextGraph_FC66F021C67D064C.TypeInfoResolver,

                    30 => global::tryAGI.OpenAI.SourceGenerationContextGraph_77F221EF7C5A730F.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}