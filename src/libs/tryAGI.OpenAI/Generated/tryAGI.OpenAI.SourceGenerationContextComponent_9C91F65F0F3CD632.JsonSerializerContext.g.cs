
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_9C91F65F0F3CD632
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_09F4BD3784F79249.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_1478856246CB467A.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_1F443FB42B0EB6B6.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_36BB1FEFEC8BF9C3.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_439AC7CD8D078580.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_4E4A611B95384FB8.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_4E93191F35F0B0E4.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_AD421E75A9F518DC.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_AD9802E4880C1440.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B071E1E131C59558.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B7E8C64B568D1111.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_BB610C0EEF9D238F.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_DFBBC0A5E88B0FC6.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E24FB3C9A61EDD8C.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::tryAGI.OpenAI.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.ToolsItem17JsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.ToolsItem17JsonConverter());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.ToolsItem17))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0559.Create_ToolsItem172(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolsItem17?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0357.Create_NullableToolsItem172(options);
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