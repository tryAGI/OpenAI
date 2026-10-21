
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class FineTuningSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_3B1C4055F906188E.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_EFEB8EAF6F33EABD.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_3A818678BB7DC6FD.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_5A5CF40B5A9BF52C.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2F6965001AEAA554.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C663A3EC366B0351.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_31BED02FE4F6121A.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_350D1C42BFD9D754.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_ABE76F747A60DA53.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_FC0ACBA26C044EC8.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_8D423037C3CFDAE1.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_3636013B34CCF193.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_58C2775CEBD02B63.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_71F94534C8F25FBF.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_0BE5646D3C56CEFD.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_5E3ABE77A1AD196C.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_AB4D61E7997A1536.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B07EAD259BFB2AEE.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2958D416D08AA5A4.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_05712AE280AEEB75.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_935AE572A09DCC1C.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly FineTuningSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static FineTuningSourceGenerationContext Default => DefaultHolder.Instance;
        private FineTuningSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultHolder.Options;
        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type) =>
            MetadataScope.GetTypeInfo(type, Options);

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

    }
}