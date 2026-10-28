
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_8FDB425236AFD776
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::tryAGI.OpenAI.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEnum(typeof(global::tryAGI.OpenAI.UsageEmbeddingsGroupByItem), static () => new global::tryAGI.OpenAI.JsonConverters.UsageEmbeddingsGroupByItemJsonConverter());
            collector.AddEnum(typeof(global::tryAGI.OpenAI.UsageEmbeddingsGroupByItem?), static () => new global::tryAGI.OpenAI.JsonConverters.UsageEmbeddingsGroupByItemNullableJsonConverter());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.UsageEmbeddingsGroupByItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0567.Create_UsageEmbeddingsGroupByItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.UsageEmbeddingsGroupByItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0361.Create_NullableUsageEmbeddingsGroupByItem2(options);
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