
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_E524C27E635F893F
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_0E04F93060E6CB86.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2309CA58B6807CA9.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2CE06A9E7F8C3E6B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2F70375A6C5B368B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_4385A673AD6A2763.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_4D0527D6DFC74298.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_651325880EC4D52B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_9FC149F3E345721F.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C5EFFCCE56766A2C.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_CF8DE5043938F55F.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_FC0ACBA26C044EC8.MetadataScope,
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
                if (type == typeof(global::tryAGI.OpenAI.RealtimeBetaResponse))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0392.Create_RealtimeBetaResponse(options);
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