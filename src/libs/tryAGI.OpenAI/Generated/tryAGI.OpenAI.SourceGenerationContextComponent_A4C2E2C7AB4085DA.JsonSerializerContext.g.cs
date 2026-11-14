
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_A4C2E2C7AB4085DA
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_39CACFCBC1CBB46B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_4360F82900C5EA37.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_67BD903415C0B2C4.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_8A336C440BEBE0E5.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_96E825F6294365DE.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_9E042FD213F8467A.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C9B35199FE48552F.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_D3EE725DD9947A25.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E57A7EE978FCD76B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E57DBB50EBD7946A.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_ED3497A2CC700008.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::tryAGI.OpenAI.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0377.Create_RealtimeSessionCreateResponseGA(options);
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