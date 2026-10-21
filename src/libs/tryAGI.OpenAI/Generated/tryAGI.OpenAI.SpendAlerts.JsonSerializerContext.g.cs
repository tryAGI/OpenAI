
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class SpendAlertsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_81FB4A8010207087.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_A14D98B2DB22A459.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_EFEB8EAF6F33EABD.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C7994DCB63850A27.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_417A9D7436B247CE.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_511334835EAE42E6.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6A86765ECF0C7D00.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_FB02229BC51C3DE8.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_CF1E5ED23BB00868.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_A4E5C6CBE66DE34D.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_48A6FECF292081C3.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B2FBD3D319998C2E.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E3A5482C507C811E.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B3981DB3E342D41D.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SpendAlertsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SpendAlertsSourceGenerationContext Default => DefaultHolder.Instance;
        private SpendAlertsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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