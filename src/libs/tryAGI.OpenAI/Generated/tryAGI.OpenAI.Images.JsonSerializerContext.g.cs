
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class ImagesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_A3EE2156C80592D0.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_7EDBE160BFA80128.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_EFEB8EAF6F33EABD.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_3E4A874400188133.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_CC3E0EA70C7F1115.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_BFF19760EBFDDAC1.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_0BB495DDE8BD4A5C.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F5796F0CC62868C7.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_316EFB1559880D09.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_1DC8531009AE413C.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_A5F723006C16B7A3.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_AD24D6DD474AE2CC.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_807C8FBD9148A931.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_00B51D76EF49F087.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C5D3DBFC94759AD2.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B5E7D675F703A104.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_1B7D3356FB9784C0.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_9FE8BB059F3CCDBF.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_06940A9BD1991BBF.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_A07B81EC07BD8504.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F669E31416FE0AD4.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_7BEE37B668A45146.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_54882BD5C80DD66A.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly ImagesSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static ImagesSourceGenerationContext Default => DefaultHolder.Instance;
        private ImagesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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