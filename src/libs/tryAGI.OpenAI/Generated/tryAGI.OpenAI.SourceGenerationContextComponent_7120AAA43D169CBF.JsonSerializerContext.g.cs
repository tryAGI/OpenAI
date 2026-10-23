
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_7120AAA43D169CBF
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_571EE018EA62AAA5.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_5FA1FA36D36F960E.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6D6CC9ABF6DD2D8A.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_7B0ADA7C57258FCF.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_7FD8DF496E6346C7.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_822855A02191D430.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_8CB412EE6210E3C8.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_9E5A4F0B6EBF35BC.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C640D5D3594C8263.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F669E31416FE0AD4.MetadataScope,
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
                if (type == typeof(global::tryAGI.OpenAI.ImageGenTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0149.Create_ImageGenTool(options);
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