
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_F28FBF0C1493D9CC
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2767147B2ECDF180.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2CE06A9E7F8C3E6B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_33A1C07699B87C63.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_4352DED78104B2D1.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_5981C628AA0C8D55.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_7CE07F3E060D4F7D.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_7D39ED86B9540AD8.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_8660AC06E08C7E4C.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_95F1707743983785.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_A2E4E7CE1600071F.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_A30B12EBF214D128.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B0133067594434DB.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B057F79C396CACE5.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_BB4A1E6EB679DC2E.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_FBA39DA456FCB431.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_FD5BF6D973930C60.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_FFB18DF413ADE28A.MetadataScope,
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
                if (type == typeof(global::tryAGI.OpenAI.ResponseVariant3))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0437.Create_ResponseVariant3(options);
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