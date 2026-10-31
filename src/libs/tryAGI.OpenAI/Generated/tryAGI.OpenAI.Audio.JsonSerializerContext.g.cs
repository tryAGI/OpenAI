
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class AudioSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_ED8C43F398316B57.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C5D3DBFC94759AD2.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_EFEB8EAF6F33EABD.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_D8D4AE8B7C6EA89B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6432A7400AEF330A.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E8B36821B1784504.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2CE06A9E7F8C3E6B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_4F72CE381AD1469A.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_8CFBF6FF1633111F.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C087F8D5B88B8242.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_596577AE7A5170ED.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_A92602AB6BF67CC3.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_FF8796084CF26794.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_9C53476E94F21618.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_EDDB8D9E266974FC.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_CD299BE5BCFB462A.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C71128B39A62CF42.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_70DBE4DA0E1125E0.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_7E9364AC4B1CA293.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_89946D36FF75B37C.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E4B97FF88ABF0D03.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_BA6D400A94F19A6C.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_9F4A06DDC16140B0.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_BB627F0512232585.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_AFA2A656FA76E0A3.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F38B2F4C132FBB60.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F55956F664E9E027.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly AudioSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static AudioSourceGenerationContext Default => DefaultHolder.Instance;
        private AudioSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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