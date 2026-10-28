
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_721CB049B22F32B9
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_99C47AA9854C3FD4.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_D241C4CE71413240.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::tryAGI.OpenAI.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>>(static () => new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0500.Create_SourceGenerationContextMetadataType_721CB049B22F32B9(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::tryAGI.OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0544.Create_SourceGenerationContextMetadataType_E8CF5BF95F9DFB83(options);
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