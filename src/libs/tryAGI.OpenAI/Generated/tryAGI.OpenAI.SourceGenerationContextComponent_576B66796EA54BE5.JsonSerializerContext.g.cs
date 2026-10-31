
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_576B66796EA54BE5
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_7B56852F2DEBD787.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_EEB9BA6B2C23C95D.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F8C4AE0FD9E20522.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::tryAGI.OpenAI.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.FiltersItem2JsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.FiltersItem2JsonConverter());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FiltersItem2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0485.Create_SourceGenerationContextMetadataType_2C996200A138DC7E(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaCompoundFilter))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0027.Create_BetaCompoundFilter(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FiltersItem2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0140.Create_FiltersItem22(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.FiltersItem2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0529.Create_SourceGenerationContextMetadataType_ABF2149A5D315966(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.FiltersItem2?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0276.Create_NullableFiltersItem22(options);
                }
                global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? additional = null;
                ResolveAdditionalTypeInfo(type, options, ref additional);
                return additional;
            }

            static partial void ResolveAdditionalTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options,
                ref global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? result);
        }

    }
}