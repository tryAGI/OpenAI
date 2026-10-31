
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_C35A60F22FD2B060
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_09ADA45BF44D2DB6.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_0F989DEA42DA94E8.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_1780DE272E50FA7E.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2CE06A9E7F8C3E6B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_353FA6D05FD47ECD.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_43D1A6CC06FA1487.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_587429A4142703D9.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_64FBBFE92E78D7DB.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6846745DF35595FC.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6B56E4CD1695C807.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_73BD5F88508D8062.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_95DEAAAFB40E6491.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B1246E900C0280CE.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C059841E343F7FAA.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C8CDFCF1AF9E6EA9.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_D45889BA8D6000E0.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_DF86D56617EF93DF.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F9B81E2A923EC473.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_FAF20D73B84FFAE9.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_FC66F021C67D064C.MetadataScope,
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
                if (type == typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0101.Create_CreateChatCompletionRequestVariant2(options);
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