
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AgentsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AgentsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            global::tryAGI.OpenAI.SourceGenerationContextGraph_7951E5B31B5EA7C1.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_A550B2C6DB0895EA.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_69C87E8852E0BE0C.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_FC0ACBA26C044EC8.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_473287F8298DBA71.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_B05B182084CB568A.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_F9D9CC5A45AB61AA.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_420B17A7701C2474.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_87DF08A01D0A7924.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_E999DBF3A541E50A.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_01286B345C7FB528.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_CC13ADC3644CF166.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_22E1BEDAD539DDFD.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_3939565AA786E684.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_561200CA4E314C20.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_87502FF44ADF7FC3.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_E44093381EE3078E.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_1D908D434BC42C88.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_B760F44FA5965C24.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_93F9A5A9E9FEC25D.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_B748ED90498664C0.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_49B33DE200072CA5.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_024B6FEBA192222E.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_F07D2F889C0EE0F2.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_E56224775919512E.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_62E3CEB02449C1BC.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_FC66F021C67D064C.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_3867773C731A2DA3.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_EBAD8B52F7440375.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_1E41E09F59D12717.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_FCDF7974331019DB.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_DF5F7352C29BD8F4.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_8D4E6B3B23545E68.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_38F9D00B37D774BC.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_F238F42FEC713384.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_BF4E3285F416FE80.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_4B50D8481AB2138A.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_D5FE5A7EAB23F25E.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_CE97A5272D934ECC.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_905D45827CCD54AE.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_99CE854596ADCDA2.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_934B6286E289D752.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_7F7B98D893F98305.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_2AF79F2206E253DB.AddConverters(options);
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
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[44];

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
                    0 => global::tryAGI.OpenAI.SourceGenerationContextGraph_7951E5B31B5EA7C1.TypeInfoResolver,

                    1 => global::tryAGI.OpenAI.SourceGenerationContextGraph_A550B2C6DB0895EA.TypeInfoResolver,

                    2 => global::tryAGI.OpenAI.SourceGenerationContextGraph_69C87E8852E0BE0C.TypeInfoResolver,

                    3 => global::tryAGI.OpenAI.SourceGenerationContextGraph_FC0ACBA26C044EC8.TypeInfoResolver,

                    4 => global::tryAGI.OpenAI.SourceGenerationContextGraph_473287F8298DBA71.TypeInfoResolver,

                    5 => global::tryAGI.OpenAI.SourceGenerationContextGraph_B05B182084CB568A.TypeInfoResolver,

                    6 => global::tryAGI.OpenAI.SourceGenerationContextGraph_F9D9CC5A45AB61AA.TypeInfoResolver,

                    7 => global::tryAGI.OpenAI.SourceGenerationContextGraph_420B17A7701C2474.TypeInfoResolver,

                    8 => global::tryAGI.OpenAI.SourceGenerationContextGraph_87DF08A01D0A7924.TypeInfoResolver,

                    9 => global::tryAGI.OpenAI.SourceGenerationContextGraph_E999DBF3A541E50A.TypeInfoResolver,

                    10 => global::tryAGI.OpenAI.SourceGenerationContextGraph_01286B345C7FB528.TypeInfoResolver,

                    11 => global::tryAGI.OpenAI.SourceGenerationContextGraph_CC13ADC3644CF166.TypeInfoResolver,

                    12 => global::tryAGI.OpenAI.SourceGenerationContextGraph_22E1BEDAD539DDFD.TypeInfoResolver,

                    13 => global::tryAGI.OpenAI.SourceGenerationContextGraph_3939565AA786E684.TypeInfoResolver,

                    14 => global::tryAGI.OpenAI.SourceGenerationContextGraph_561200CA4E314C20.TypeInfoResolver,

                    15 => global::tryAGI.OpenAI.SourceGenerationContextGraph_87502FF44ADF7FC3.TypeInfoResolver,

                    16 => global::tryAGI.OpenAI.SourceGenerationContextGraph_E44093381EE3078E.TypeInfoResolver,

                    17 => global::tryAGI.OpenAI.SourceGenerationContextGraph_1D908D434BC42C88.TypeInfoResolver,

                    18 => global::tryAGI.OpenAI.SourceGenerationContextGraph_B760F44FA5965C24.TypeInfoResolver,

                    19 => global::tryAGI.OpenAI.SourceGenerationContextGraph_93F9A5A9E9FEC25D.TypeInfoResolver,

                    20 => global::tryAGI.OpenAI.SourceGenerationContextGraph_B748ED90498664C0.TypeInfoResolver,

                    21 => global::tryAGI.OpenAI.SourceGenerationContextGraph_49B33DE200072CA5.TypeInfoResolver,

                    22 => global::tryAGI.OpenAI.SourceGenerationContextGraph_024B6FEBA192222E.TypeInfoResolver,

                    23 => global::tryAGI.OpenAI.SourceGenerationContextGraph_F07D2F889C0EE0F2.TypeInfoResolver,

                    24 => global::tryAGI.OpenAI.SourceGenerationContextGraph_E56224775919512E.TypeInfoResolver,

                    25 => global::tryAGI.OpenAI.SourceGenerationContextGraph_62E3CEB02449C1BC.TypeInfoResolver,

                    26 => global::tryAGI.OpenAI.SourceGenerationContextGraph_FC66F021C67D064C.TypeInfoResolver,

                    27 => global::tryAGI.OpenAI.SourceGenerationContextGraph_3867773C731A2DA3.TypeInfoResolver,

                    28 => global::tryAGI.OpenAI.SourceGenerationContextGraph_EBAD8B52F7440375.TypeInfoResolver,

                    29 => global::tryAGI.OpenAI.SourceGenerationContextGraph_1E41E09F59D12717.TypeInfoResolver,

                    30 => global::tryAGI.OpenAI.SourceGenerationContextGraph_FCDF7974331019DB.TypeInfoResolver,

                    31 => global::tryAGI.OpenAI.SourceGenerationContextGraph_DF5F7352C29BD8F4.TypeInfoResolver,

                    32 => global::tryAGI.OpenAI.SourceGenerationContextGraph_8D4E6B3B23545E68.TypeInfoResolver,

                    33 => global::tryAGI.OpenAI.SourceGenerationContextGraph_38F9D00B37D774BC.TypeInfoResolver,

                    34 => global::tryAGI.OpenAI.SourceGenerationContextGraph_F238F42FEC713384.TypeInfoResolver,

                    35 => global::tryAGI.OpenAI.SourceGenerationContextGraph_BF4E3285F416FE80.TypeInfoResolver,

                    36 => global::tryAGI.OpenAI.SourceGenerationContextGraph_4B50D8481AB2138A.TypeInfoResolver,

                    37 => global::tryAGI.OpenAI.SourceGenerationContextGraph_D5FE5A7EAB23F25E.TypeInfoResolver,

                    38 => global::tryAGI.OpenAI.SourceGenerationContextGraph_CE97A5272D934ECC.TypeInfoResolver,

                    39 => global::tryAGI.OpenAI.SourceGenerationContextGraph_905D45827CCD54AE.TypeInfoResolver,

                    40 => global::tryAGI.OpenAI.SourceGenerationContextGraph_99CE854596ADCDA2.TypeInfoResolver,

                    41 => global::tryAGI.OpenAI.SourceGenerationContextGraph_934B6286E289D752.TypeInfoResolver,

                    42 => global::tryAGI.OpenAI.SourceGenerationContextGraph_7F7B98D893F98305.TypeInfoResolver,

                    43 => global::tryAGI.OpenAI.SourceGenerationContextGraph_2AF79F2206E253DB.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}