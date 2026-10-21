
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class LiveSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_8450F61DE1F8BB8C.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_EFEB8EAF6F33EABD.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_CDCC1A8295CF0ECC.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_DAA50877555A3FD9.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_0B3B2A08C294E303.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_8A442B905072DCAC.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_ADE866CEDDFBE3CA.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C5D3DBFC94759AD2.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_367D9AA25FADB4EE.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_70E97A7FBF2404C3.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_4F9E2855C7742AED.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B54A551BCEEFC24F.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_DA7B113842CA8BBC.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_48B80C2CD2945220.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly LiveSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static LiveSourceGenerationContext Default => DefaultHolder.Instance;
        private LiveSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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