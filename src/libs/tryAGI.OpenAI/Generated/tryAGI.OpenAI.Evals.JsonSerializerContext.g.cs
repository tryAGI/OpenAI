
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class EvalsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_3DADC74C2C758A91.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_EFEB8EAF6F33EABD.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_A6234B6EA2DC46ED.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_A7B8B0880D049FAE.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_FC0ACBA26C044EC8.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_78BF4907A8C22039.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C77F0B6820AE3E83.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_DAB6AE862FA4AD8E.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E770EAE2235EF55E.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_33799033095D56F5.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_7FFA3EB56F59050C.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_459573105CD1DB14.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F0F7E8292CDB6F14.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_7293A7F50B28982E.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_9A7C33AEE0B86FE8.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_0CF1D27B079A0F61.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_95A269520C64A432.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_FEA83FD35B4B7E50.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_D26ECD28249EA60E.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_AAA469396D3CDDF4.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B955BC619301CC52.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_1B43A6001E99EF9E.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly EvalsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static EvalsSourceGenerationContext Default => DefaultHolder.Instance;
        private EvalsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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