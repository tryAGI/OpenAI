
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class InvitesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2CC328E5C3FAD936.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_EFEB8EAF6F33EABD.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C7994DCB63850A27.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_20C30C35D19FFB1C.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6CA07EA1F38F3636.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F6D5ECC836B2EF19.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_BEF3B07CE36F1B1E.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6BE847C4080EFDE2.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly InvitesSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static InvitesSourceGenerationContext Default => DefaultHolder.Instance;
        private InvitesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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