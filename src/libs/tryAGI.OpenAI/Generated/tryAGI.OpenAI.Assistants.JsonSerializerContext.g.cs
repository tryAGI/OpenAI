
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    public sealed partial class AssistantsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AssistantsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AssistantsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            global::tryAGI.OpenAI.SourceGenerationContextGraph_2B915646809CF0A9.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_44C20A7116AFF153.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_473287F8298DBA71.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_9DE334C5F091F3E4.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_B246EA8853D56A8C.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_FC0ACBA26C044EC8.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_749C0C8E4EDF3327.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_0F989DEA42DA94E8.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_7CD2CFC512829A0D.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_2CE06A9E7F8C3E6B.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_B760F44FA5965C24.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_6DA88C34BA124C41.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_81591025B3DF0105.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_DBC6FEC9829D8344.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_7B3099EA93D5A816.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_B42367BBBF001DBB.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_56EEFB9425CBD37A.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_A2D0FA6CFFB0A53D.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_71F5F399F00C178C.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_8F5A2B9496564310.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_E2529461CB7352A6.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_ABC7DC179475ADB5.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_606D5498ADED238F.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_6F4A071865EE9526.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_7433CC67363F8100.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_30402F1F2CCF1F06.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_2373ECC4D500C84E.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_C4564A7C199FC9A0.AddConverters(options);
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
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[28];

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
                    0 => global::tryAGI.OpenAI.SourceGenerationContextGraph_2B915646809CF0A9.TypeInfoResolver,

                    1 => global::tryAGI.OpenAI.SourceGenerationContextGraph_44C20A7116AFF153.TypeInfoResolver,

                    2 => global::tryAGI.OpenAI.SourceGenerationContextGraph_473287F8298DBA71.TypeInfoResolver,

                    3 => global::tryAGI.OpenAI.SourceGenerationContextGraph_9DE334C5F091F3E4.TypeInfoResolver,

                    4 => global::tryAGI.OpenAI.SourceGenerationContextGraph_B246EA8853D56A8C.TypeInfoResolver,

                    5 => global::tryAGI.OpenAI.SourceGenerationContextGraph_FC0ACBA26C044EC8.TypeInfoResolver,

                    6 => global::tryAGI.OpenAI.SourceGenerationContextGraph_749C0C8E4EDF3327.TypeInfoResolver,

                    7 => global::tryAGI.OpenAI.SourceGenerationContextGraph_0F989DEA42DA94E8.TypeInfoResolver,

                    8 => global::tryAGI.OpenAI.SourceGenerationContextGraph_7CD2CFC512829A0D.TypeInfoResolver,

                    9 => global::tryAGI.OpenAI.SourceGenerationContextGraph_2CE06A9E7F8C3E6B.TypeInfoResolver,

                    10 => global::tryAGI.OpenAI.SourceGenerationContextGraph_B760F44FA5965C24.TypeInfoResolver,

                    11 => global::tryAGI.OpenAI.SourceGenerationContextGraph_6DA88C34BA124C41.TypeInfoResolver,

                    12 => global::tryAGI.OpenAI.SourceGenerationContextGraph_81591025B3DF0105.TypeInfoResolver,

                    13 => global::tryAGI.OpenAI.SourceGenerationContextGraph_DBC6FEC9829D8344.TypeInfoResolver,

                    14 => global::tryAGI.OpenAI.SourceGenerationContextGraph_7B3099EA93D5A816.TypeInfoResolver,

                    15 => global::tryAGI.OpenAI.SourceGenerationContextGraph_B42367BBBF001DBB.TypeInfoResolver,

                    16 => global::tryAGI.OpenAI.SourceGenerationContextGraph_56EEFB9425CBD37A.TypeInfoResolver,

                    17 => global::tryAGI.OpenAI.SourceGenerationContextGraph_A2D0FA6CFFB0A53D.TypeInfoResolver,

                    18 => global::tryAGI.OpenAI.SourceGenerationContextGraph_71F5F399F00C178C.TypeInfoResolver,

                    19 => global::tryAGI.OpenAI.SourceGenerationContextGraph_8F5A2B9496564310.TypeInfoResolver,

                    20 => global::tryAGI.OpenAI.SourceGenerationContextGraph_E2529461CB7352A6.TypeInfoResolver,

                    21 => global::tryAGI.OpenAI.SourceGenerationContextGraph_ABC7DC179475ADB5.TypeInfoResolver,

                    22 => global::tryAGI.OpenAI.SourceGenerationContextGraph_606D5498ADED238F.TypeInfoResolver,

                    23 => global::tryAGI.OpenAI.SourceGenerationContextGraph_6F4A071865EE9526.TypeInfoResolver,

                    24 => global::tryAGI.OpenAI.SourceGenerationContextGraph_7433CC67363F8100.TypeInfoResolver,

                    25 => global::tryAGI.OpenAI.SourceGenerationContextGraph_30402F1F2CCF1F06.TypeInfoResolver,

                    26 => global::tryAGI.OpenAI.SourceGenerationContextGraph_2373ECC4D500C84E.TypeInfoResolver,

                    27 => global::tryAGI.OpenAI.SourceGenerationContextGraph_C4564A7C199FC9A0.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}