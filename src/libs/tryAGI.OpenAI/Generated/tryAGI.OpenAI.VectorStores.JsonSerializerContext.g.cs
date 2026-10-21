
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class VectorStoresSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_474DED7B6B93F820.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_EFEB8EAF6F33EABD.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_0363DA4721EBE43E.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B82109F87FE521E8.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_58D3F209469250F9.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_A605F0891B144CE0.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_FC0ACBA26C044EC8.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_0B3068D9AB81EE50.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_1E031396DAEE8886.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_ECEDDDA676B0CC77.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2958D416D08AA5A4.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_61A5B4914DFA0A4D.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_35E78521F238757D.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_FFC7A36E18167641.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C378EAE9F91BB786.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_890D6A5EF9229A25.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B2FD6C63EDAAD302.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_ECCDAB7E053D48A7.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_7926D6EE95C67D1D.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_06AE88A81A06B6F2.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_3385C79478CCD170.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_45751072A2690D13.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_DF4DA0CF50AEE971.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_D5BE7BEAD4702381.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_65E059DC01B81608.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F200725232CD104C.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B27E44D209077B87.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_4897B98B90D322FC.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B5ED9CF5E041239E.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_ED8BE32110B39F39.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_4B6AB476B96CF00C.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly VectorStoresSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static VectorStoresSourceGenerationContext Default => DefaultHolder.Instance;
        private VectorStoresSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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