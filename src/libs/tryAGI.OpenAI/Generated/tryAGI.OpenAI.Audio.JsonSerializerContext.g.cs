
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    public sealed partial class AudioSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AudioSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AudioSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            global::tryAGI.OpenAI.SourceGenerationContextGraph_87D2B7826832B1F9.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_CE97A5272D934ECC.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_44C20A7116AFF153.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_473287F8298DBA71.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_2CE06A9E7F8C3E6B.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_965BA0F92C1A1D4D.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_DE5251A066F8AE15.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_5E42353B2D4A6FEE.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_01286B345C7FB528.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_B760F44FA5965C24.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_912A176CC5121550.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_BF7701C5595B2BAD.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_AA99DD3DC8CE1E71.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_B22F51C574F6F79E.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_7E8B7499E3637F4C.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_B9A3925741D50C02.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_D0ABE7E9CA7A0FAE.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_E3E6380D72F88870.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_6DA88C34BA124C41.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_773EC5B556C67631.AddConverters(options);
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
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[20];

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
                    0 => global::tryAGI.OpenAI.SourceGenerationContextGraph_87D2B7826832B1F9.TypeInfoResolver,

                    1 => global::tryAGI.OpenAI.SourceGenerationContextGraph_CE97A5272D934ECC.TypeInfoResolver,

                    2 => global::tryAGI.OpenAI.SourceGenerationContextGraph_44C20A7116AFF153.TypeInfoResolver,

                    3 => global::tryAGI.OpenAI.SourceGenerationContextGraph_473287F8298DBA71.TypeInfoResolver,

                    4 => global::tryAGI.OpenAI.SourceGenerationContextGraph_2CE06A9E7F8C3E6B.TypeInfoResolver,

                    5 => global::tryAGI.OpenAI.SourceGenerationContextGraph_965BA0F92C1A1D4D.TypeInfoResolver,

                    6 => global::tryAGI.OpenAI.SourceGenerationContextGraph_DE5251A066F8AE15.TypeInfoResolver,

                    7 => global::tryAGI.OpenAI.SourceGenerationContextGraph_5E42353B2D4A6FEE.TypeInfoResolver,

                    8 => global::tryAGI.OpenAI.SourceGenerationContextGraph_01286B345C7FB528.TypeInfoResolver,

                    9 => global::tryAGI.OpenAI.SourceGenerationContextGraph_B760F44FA5965C24.TypeInfoResolver,

                    10 => global::tryAGI.OpenAI.SourceGenerationContextGraph_912A176CC5121550.TypeInfoResolver,

                    11 => global::tryAGI.OpenAI.SourceGenerationContextGraph_BF7701C5595B2BAD.TypeInfoResolver,

                    12 => global::tryAGI.OpenAI.SourceGenerationContextGraph_AA99DD3DC8CE1E71.TypeInfoResolver,

                    13 => global::tryAGI.OpenAI.SourceGenerationContextGraph_B22F51C574F6F79E.TypeInfoResolver,

                    14 => global::tryAGI.OpenAI.SourceGenerationContextGraph_7E8B7499E3637F4C.TypeInfoResolver,

                    15 => global::tryAGI.OpenAI.SourceGenerationContextGraph_B9A3925741D50C02.TypeInfoResolver,

                    16 => global::tryAGI.OpenAI.SourceGenerationContextGraph_D0ABE7E9CA7A0FAE.TypeInfoResolver,

                    17 => global::tryAGI.OpenAI.SourceGenerationContextGraph_E3E6380D72F88870.TypeInfoResolver,

                    18 => global::tryAGI.OpenAI.SourceGenerationContextGraph_6DA88C34BA124C41.TypeInfoResolver,

                    19 => global::tryAGI.OpenAI.SourceGenerationContextGraph_773EC5B556C67631.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}