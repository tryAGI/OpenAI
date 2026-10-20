
#nullable enable

namespace tryAGI.OpenAI
{    /// <summary>
    ///
    /// </summary>
    public sealed partial class FineTuningSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static FineTuningSourceGenerationContext Default { get; } = new(DefaultOptions);

        private FineTuningSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            global::tryAGI.OpenAI.SourceGenerationContextGraph_33740AA13C180D2E.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_44C20A7116AFF153.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_473287F8298DBA71.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_7E9CFFEF65BFAD38.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_D90DF0B8A04DE3C6.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_01286B345C7FB528.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_D86D24328ABCBBA8.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_6DA88C34BA124C41.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_FC0ACBA26C044EC8.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_14238EB4D48AF5C5.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_3636013B34CCF193.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_E6FE8F6CCB9F0AAE.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_A99E8F59D90678F2.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_D95DDA56C18CD5E9.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_0A9BA9413460070A.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_2A602CFE9B01099E.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_2958D416D08AA5A4.AddConverters(options);
            global::tryAGI.OpenAI.SourceGenerationContextGraph_E4BE52FFAC10370D.AddConverters(options);
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
                    0 => global::tryAGI.OpenAI.SourceGenerationContextGraph_33740AA13C180D2E.TypeInfoResolver,

                    1 => global::tryAGI.OpenAI.SourceGenerationContextGraph_44C20A7116AFF153.TypeInfoResolver,

                    2 => global::tryAGI.OpenAI.SourceGenerationContextGraph_473287F8298DBA71.TypeInfoResolver,

                    3 => global::tryAGI.OpenAI.SourceGenerationContextGraph_7E9CFFEF65BFAD38.TypeInfoResolver,

                    4 => global::tryAGI.OpenAI.SourceGenerationContextGraph_D90DF0B8A04DE3C6.TypeInfoResolver,

                    5 => global::tryAGI.OpenAI.SourceGenerationContextGraph_01286B345C7FB528.TypeInfoResolver,

                    6 => global::tryAGI.OpenAI.SourceGenerationContextGraph_D86D24328ABCBBA8.TypeInfoResolver,

                    7 => global::tryAGI.OpenAI.SourceGenerationContextGraph_6DA88C34BA124C41.TypeInfoResolver,

                    8 => global::tryAGI.OpenAI.SourceGenerationContextGraph_FC0ACBA26C044EC8.TypeInfoResolver,

                    9 => global::tryAGI.OpenAI.SourceGenerationContextGraph_14238EB4D48AF5C5.TypeInfoResolver,

                    10 => global::tryAGI.OpenAI.SourceGenerationContextGraph_3636013B34CCF193.TypeInfoResolver,

                    11 => global::tryAGI.OpenAI.SourceGenerationContextGraph_E6FE8F6CCB9F0AAE.TypeInfoResolver,

                    12 => global::tryAGI.OpenAI.SourceGenerationContextGraph_A99E8F59D90678F2.TypeInfoResolver,

                    13 => global::tryAGI.OpenAI.SourceGenerationContextGraph_D95DDA56C18CD5E9.TypeInfoResolver,

                    14 => global::tryAGI.OpenAI.SourceGenerationContextGraph_0A9BA9413460070A.TypeInfoResolver,

                    15 => global::tryAGI.OpenAI.SourceGenerationContextGraph_2A602CFE9B01099E.TypeInfoResolver,

                    16 => global::tryAGI.OpenAI.SourceGenerationContextGraph_2958D416D08AA5A4.TypeInfoResolver,

                    17 => global::tryAGI.OpenAI.SourceGenerationContextGraph_E4BE52FFAC10370D.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}