
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    public sealed partial class CertificatesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static CertificatesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private CertificatesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            global::tryAGI.OpenAI.SourceGenerationContextGraph_9CC8DC3D93E2E822.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_9DD88E164CE91F87.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_44C20A7116AFF153.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_8786137D24D818E5.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_01286B345C7FB528.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_E8BCE3FDD8574E35.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_473287F8298DBA71.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_27164C83EE655B84.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_A5D57CAF9F41CEF3.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_BD7B6313B3F9BF95.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_3DA1D580AAF984C6.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_B3E466FC28FEBBB2.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_45290931436DDA51.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_6DA88C34BA124C41.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_96BEFB62273ACD40.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_4BE7F6EA71BE8973.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_09278AD915FED526.AddConverters(options);
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
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[17];

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
                    0 => global::tryAGI.OpenAI.SourceGenerationContextGraph_9CC8DC3D93E2E822.TypeInfoResolver,

                    1 => global::tryAGI.OpenAI.SourceGenerationContextGraph_9DD88E164CE91F87.TypeInfoResolver,

                    2 => global::tryAGI.OpenAI.SourceGenerationContextGraph_44C20A7116AFF153.TypeInfoResolver,

                    3 => global::tryAGI.OpenAI.SourceGenerationContextGraph_8786137D24D818E5.TypeInfoResolver,

                    4 => global::tryAGI.OpenAI.SourceGenerationContextGraph_01286B345C7FB528.TypeInfoResolver,

                    5 => global::tryAGI.OpenAI.SourceGenerationContextGraph_E8BCE3FDD8574E35.TypeInfoResolver,

                    6 => global::tryAGI.OpenAI.SourceGenerationContextGraph_473287F8298DBA71.TypeInfoResolver,

                    7 => global::tryAGI.OpenAI.SourceGenerationContextGraph_27164C83EE655B84.TypeInfoResolver,

                    8 => global::tryAGI.OpenAI.SourceGenerationContextGraph_A5D57CAF9F41CEF3.TypeInfoResolver,

                    9 => global::tryAGI.OpenAI.SourceGenerationContextGraph_BD7B6313B3F9BF95.TypeInfoResolver,

                    10 => global::tryAGI.OpenAI.SourceGenerationContextGraph_3DA1D580AAF984C6.TypeInfoResolver,

                    11 => global::tryAGI.OpenAI.SourceGenerationContextGraph_B3E466FC28FEBBB2.TypeInfoResolver,

                    12 => global::tryAGI.OpenAI.SourceGenerationContextGraph_45290931436DDA51.TypeInfoResolver,

                    13 => global::tryAGI.OpenAI.SourceGenerationContextGraph_6DA88C34BA124C41.TypeInfoResolver,

                    14 => global::tryAGI.OpenAI.SourceGenerationContextGraph_96BEFB62273ACD40.TypeInfoResolver,

                    15 => global::tryAGI.OpenAI.SourceGenerationContextGraph_4BE7F6EA71BE8973.TypeInfoResolver,

                    16 => global::tryAGI.OpenAI.SourceGenerationContextGraph_09278AD915FED526.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}