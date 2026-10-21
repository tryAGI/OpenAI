
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class CertificatesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E05F996FD335E0ED.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_ADE1FCADF4B9FA97.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_EFEB8EAF6F33EABD.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C7994DCB63850A27.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_0B37CEFB3951F162.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_0751EAD012CC4926.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_5AE3204B07C292B5.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_71BF06B0792692F9.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_A08533BC6AA854B3.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E12CFA6A85CA3535.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_39E0D94457A14551.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_AF843EF1B7C2E8FC.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_230FD908D0C12675.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_A57F6F7C99E04806.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_8F8F001DF7A524C7.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_BA34E63810333292.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly CertificatesSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static CertificatesSourceGenerationContext Default => DefaultHolder.Instance;
        private CertificatesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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