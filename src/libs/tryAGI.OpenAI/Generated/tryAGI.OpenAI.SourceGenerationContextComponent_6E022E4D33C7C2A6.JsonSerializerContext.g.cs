
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_6E022E4D33C7C2A6
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_05772B772C04959A.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_874D61AED25FACF9.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_9AE866D194DE817B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_CF8DE5043938F55F.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_D8A4AD7A62D807F1.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E4A64D79636081AB.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F2E1CE740C9DF9B0.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F483F37F46089108.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_FC0ACBA26C044EC8.MetadataScope,
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
                if (type == typeof(global::tryAGI.OpenAI.RealtimeResponse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0406.Create_RealtimeResponse(options);
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