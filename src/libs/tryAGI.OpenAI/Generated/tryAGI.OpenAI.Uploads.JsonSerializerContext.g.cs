
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class UploadsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2431BEF840C4909A.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_AEBE809E92F183DF.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_EFEB8EAF6F33EABD.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C5D3DBFC94759AD2.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_31FD084CC4A66711.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_3D987397F1B97133.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F574D719C0C2553C.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2B0BDA9ACD9FC3CF.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_FC66F021C67D064C.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B980242B7831DA7B.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly UploadsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static UploadsSourceGenerationContext Default => DefaultHolder.Instance;
        private UploadsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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