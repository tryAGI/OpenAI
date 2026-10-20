
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    public sealed partial class ResponsesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ResponsesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ResponsesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            global::tryAGI.OpenAI.SourceGenerationContextGraph_2A2FAE321BD36144.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_5CE171745FAB97A5.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_44C20A7116AFF153.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_473287F8298DBA71.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_8F47BD29625DB802.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_9B1D35D9AD8754E9.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_02E8BD14BAFE045C.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_65338A66E188C48F.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_1C7D56569BB221E0.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_5D2A511EB1674D9E.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_41C183D69EE212C4.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_F3678D50BFB56FE8.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_B760F44FA5965C24.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_6DA88C34BA124C41.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_58D0096A67ED45DF.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_5580CD6A7B626749.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_450A3E24EE149813.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_EB8DCA17FBBF20A0.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_A91147BD34EAA3B2.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_20C9AB1175DF0653.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_E4840BA555023C99.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_FA78E621FE098E45.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_3FAF2B6591388AFE.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_E483029437F69FC7.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_2700C3F92AD67D70.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_CDD91538C79FA043.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_21FB8BCCE08D3A5D.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_E82123B0D6DE3A85.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_F063A85B4BF12D2F.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_A54C4734F3CACA87.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_91EC8B2B8625E903.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_FEAD22BDFF630A1C.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_7091D856842047F7.AddConverters(options);
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
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[33];

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
                    0 => global::tryAGI.OpenAI.SourceGenerationContextGraph_2A2FAE321BD36144.TypeInfoResolver,

                    1 => global::tryAGI.OpenAI.SourceGenerationContextGraph_5CE171745FAB97A5.TypeInfoResolver,

                    2 => global::tryAGI.OpenAI.SourceGenerationContextGraph_44C20A7116AFF153.TypeInfoResolver,

                    3 => global::tryAGI.OpenAI.SourceGenerationContextGraph_473287F8298DBA71.TypeInfoResolver,

                    4 => global::tryAGI.OpenAI.SourceGenerationContextGraph_8F47BD29625DB802.TypeInfoResolver,

                    5 => global::tryAGI.OpenAI.SourceGenerationContextGraph_9B1D35D9AD8754E9.TypeInfoResolver,

                    6 => global::tryAGI.OpenAI.SourceGenerationContextGraph_02E8BD14BAFE045C.TypeInfoResolver,

                    7 => global::tryAGI.OpenAI.SourceGenerationContextGraph_65338A66E188C48F.TypeInfoResolver,

                    8 => global::tryAGI.OpenAI.SourceGenerationContextGraph_1C7D56569BB221E0.TypeInfoResolver,

                    9 => global::tryAGI.OpenAI.SourceGenerationContextGraph_5D2A511EB1674D9E.TypeInfoResolver,

                    10 => global::tryAGI.OpenAI.SourceGenerationContextGraph_41C183D69EE212C4.TypeInfoResolver,

                    11 => global::tryAGI.OpenAI.SourceGenerationContextGraph_F3678D50BFB56FE8.TypeInfoResolver,

                    12 => global::tryAGI.OpenAI.SourceGenerationContextGraph_B760F44FA5965C24.TypeInfoResolver,

                    13 => global::tryAGI.OpenAI.SourceGenerationContextGraph_6DA88C34BA124C41.TypeInfoResolver,

                    14 => global::tryAGI.OpenAI.SourceGenerationContextGraph_58D0096A67ED45DF.TypeInfoResolver,

                    15 => global::tryAGI.OpenAI.SourceGenerationContextGraph_5580CD6A7B626749.TypeInfoResolver,

                    16 => global::tryAGI.OpenAI.SourceGenerationContextGraph_450A3E24EE149813.TypeInfoResolver,

                    17 => global::tryAGI.OpenAI.SourceGenerationContextGraph_EB8DCA17FBBF20A0.TypeInfoResolver,

                    18 => global::tryAGI.OpenAI.SourceGenerationContextGraph_A91147BD34EAA3B2.TypeInfoResolver,

                    19 => global::tryAGI.OpenAI.SourceGenerationContextGraph_20C9AB1175DF0653.TypeInfoResolver,

                    20 => global::tryAGI.OpenAI.SourceGenerationContextGraph_E4840BA555023C99.TypeInfoResolver,

                    21 => global::tryAGI.OpenAI.SourceGenerationContextGraph_FA78E621FE098E45.TypeInfoResolver,

                    22 => global::tryAGI.OpenAI.SourceGenerationContextGraph_3FAF2B6591388AFE.TypeInfoResolver,

                    23 => global::tryAGI.OpenAI.SourceGenerationContextGraph_E483029437F69FC7.TypeInfoResolver,

                    24 => global::tryAGI.OpenAI.SourceGenerationContextGraph_2700C3F92AD67D70.TypeInfoResolver,

                    25 => global::tryAGI.OpenAI.SourceGenerationContextGraph_CDD91538C79FA043.TypeInfoResolver,

                    26 => global::tryAGI.OpenAI.SourceGenerationContextGraph_21FB8BCCE08D3A5D.TypeInfoResolver,

                    27 => global::tryAGI.OpenAI.SourceGenerationContextGraph_E82123B0D6DE3A85.TypeInfoResolver,

                    28 => global::tryAGI.OpenAI.SourceGenerationContextGraph_F063A85B4BF12D2F.TypeInfoResolver,

                    29 => global::tryAGI.OpenAI.SourceGenerationContextGraph_A54C4734F3CACA87.TypeInfoResolver,

                    30 => global::tryAGI.OpenAI.SourceGenerationContextGraph_91EC8B2B8625E903.TypeInfoResolver,

                    31 => global::tryAGI.OpenAI.SourceGenerationContextGraph_FEAD22BDFF630A1C.TypeInfoResolver,

                    32 => global::tryAGI.OpenAI.SourceGenerationContextGraph_7091D856842047F7.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}