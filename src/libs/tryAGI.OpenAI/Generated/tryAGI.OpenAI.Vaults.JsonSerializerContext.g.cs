
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    public sealed partial class VaultsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static VaultsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private VaultsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            global::tryAGI.OpenAI.SourceGenerationContextGraph_F5EEAB25C3F10273.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_BA6DEC0C00DEB74F.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_69C87E8852E0BE0C.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_473287F8298DBA71.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_FC0ACBA26C044EC8.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_A1550767A5989B3E.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_12EC5EA63DBB96DF.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_300467DD7EC24833.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_3A3D0F13D6442725.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_DE9DE487BA176A43.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_FC66F021C67D064C.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_3867773C731A2DA3.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_30A4531411F2A31C.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_1100F89B257395C1.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_097F2AC855ECBA25.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_0979BF1DFF05A1D0.AddConverters(options);
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
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[16];

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
                    0 => global::tryAGI.OpenAI.SourceGenerationContextGraph_F5EEAB25C3F10273.TypeInfoResolver,

                    1 => global::tryAGI.OpenAI.SourceGenerationContextGraph_BA6DEC0C00DEB74F.TypeInfoResolver,

                    2 => global::tryAGI.OpenAI.SourceGenerationContextGraph_69C87E8852E0BE0C.TypeInfoResolver,

                    3 => global::tryAGI.OpenAI.SourceGenerationContextGraph_473287F8298DBA71.TypeInfoResolver,

                    4 => global::tryAGI.OpenAI.SourceGenerationContextGraph_FC0ACBA26C044EC8.TypeInfoResolver,

                    5 => global::tryAGI.OpenAI.SourceGenerationContextGraph_A1550767A5989B3E.TypeInfoResolver,

                    6 => global::tryAGI.OpenAI.SourceGenerationContextGraph_12EC5EA63DBB96DF.TypeInfoResolver,

                    7 => global::tryAGI.OpenAI.SourceGenerationContextGraph_300467DD7EC24833.TypeInfoResolver,

                    8 => global::tryAGI.OpenAI.SourceGenerationContextGraph_3A3D0F13D6442725.TypeInfoResolver,

                    9 => global::tryAGI.OpenAI.SourceGenerationContextGraph_DE9DE487BA176A43.TypeInfoResolver,

                    10 => global::tryAGI.OpenAI.SourceGenerationContextGraph_FC66F021C67D064C.TypeInfoResolver,

                    11 => global::tryAGI.OpenAI.SourceGenerationContextGraph_3867773C731A2DA3.TypeInfoResolver,

                    12 => global::tryAGI.OpenAI.SourceGenerationContextGraph_30A4531411F2A31C.TypeInfoResolver,

                    13 => global::tryAGI.OpenAI.SourceGenerationContextGraph_1100F89B257395C1.TypeInfoResolver,

                    14 => global::tryAGI.OpenAI.SourceGenerationContextGraph_097F2AC855ECBA25.TypeInfoResolver,

                    15 => global::tryAGI.OpenAI.SourceGenerationContextGraph_0979BF1DFF05A1D0.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}