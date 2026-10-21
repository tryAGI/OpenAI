
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextOperation_2F657F176563069E : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_8E126B988000BA85.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C7C42DB703B60F74.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_EFEB8EAF6F33EABD.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_8660AC06E08C7E4C.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_D5D517C0FFB4C526.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2BD5E854F409F29A.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_FBA39DA456FCB431.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B3D37F8E987A7278.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_FE38FF22DB352434.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6E32C885F7848962.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_911405CA8586BA9F.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextOperation_2F657F176563069E Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextOperation_2F657F176563069E Default => DefaultHolder.Instance;
        private SourceGenerationContextOperation_2F657F176563069E(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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