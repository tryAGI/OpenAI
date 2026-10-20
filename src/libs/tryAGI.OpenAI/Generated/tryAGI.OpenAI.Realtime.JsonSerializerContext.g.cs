
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    public sealed partial class RealtimeSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static RealtimeSourceGenerationContext Default { get; } = new(DefaultOptions);

        private RealtimeSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            global::tryAGI.OpenAI.SourceGenerationContextGraph_04B5ADF57D1CF4E9.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_44C20A7116AFF153.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_473287F8298DBA71.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_B760F44FA5965C24.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_CE96C427940457C0.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_BAAE38D172513629.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_C482561852389560.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_CE97A5272D934ECC.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_967C4A2AD9C0AEBB.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_4D6944FE86405992.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_5A408431A010BF9A.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_2CE06A9E7F8C3E6B.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_46F7568B4EAF978F.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_B8CE1701572C0F0B.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_00A5C457E8E7B58B.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_BA099AE85AD973C0.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_65CABB5F2C782040.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_6DA88C34BA124C41.AddConverters(options);
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
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[18];

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
                    0 => global::tryAGI.OpenAI.SourceGenerationContextGraph_04B5ADF57D1CF4E9.TypeInfoResolver,

                    1 => global::tryAGI.OpenAI.SourceGenerationContextGraph_44C20A7116AFF153.TypeInfoResolver,

                    2 => global::tryAGI.OpenAI.SourceGenerationContextGraph_473287F8298DBA71.TypeInfoResolver,

                    3 => global::tryAGI.OpenAI.SourceGenerationContextGraph_B760F44FA5965C24.TypeInfoResolver,

                    4 => global::tryAGI.OpenAI.SourceGenerationContextGraph_CE96C427940457C0.TypeInfoResolver,

                    5 => global::tryAGI.OpenAI.SourceGenerationContextGraph_BAAE38D172513629.TypeInfoResolver,

                    6 => global::tryAGI.OpenAI.SourceGenerationContextGraph_C482561852389560.TypeInfoResolver,

                    7 => global::tryAGI.OpenAI.SourceGenerationContextGraph_CE97A5272D934ECC.TypeInfoResolver,

                    8 => global::tryAGI.OpenAI.SourceGenerationContextGraph_967C4A2AD9C0AEBB.TypeInfoResolver,

                    9 => global::tryAGI.OpenAI.SourceGenerationContextGraph_4D6944FE86405992.TypeInfoResolver,

                    10 => global::tryAGI.OpenAI.SourceGenerationContextGraph_5A408431A010BF9A.TypeInfoResolver,

                    11 => global::tryAGI.OpenAI.SourceGenerationContextGraph_2CE06A9E7F8C3E6B.TypeInfoResolver,

                    12 => global::tryAGI.OpenAI.SourceGenerationContextGraph_46F7568B4EAF978F.TypeInfoResolver,

                    13 => global::tryAGI.OpenAI.SourceGenerationContextGraph_B8CE1701572C0F0B.TypeInfoResolver,

                    14 => global::tryAGI.OpenAI.SourceGenerationContextGraph_00A5C457E8E7B58B.TypeInfoResolver,

                    15 => global::tryAGI.OpenAI.SourceGenerationContextGraph_BA099AE85AD973C0.TypeInfoResolver,

                    16 => global::tryAGI.OpenAI.SourceGenerationContextGraph_65CABB5F2C782040.TypeInfoResolver,

                    17 => global::tryAGI.OpenAI.SourceGenerationContextGraph_6DA88C34BA124C41.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}