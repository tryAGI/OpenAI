
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextOperation_B4263E8C43559293 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_3D81F266CCF7794D.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_AF07BAB963D02BDC.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C9FF56C0A46A3E99.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_EFEB8EAF6F33EABD.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_1A319A531F7258A4.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_635A9AD4B4EE8F6F.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_D6AF8FE2BB293ED3.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_3D39CB6BB08BF068.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C22F6B1388B6207C.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_078751F0609AFA30.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_A02CD1AA57EC6911.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_12CE22BFBE7CC585.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_3D08FB9ACFD80A15.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextOperation_B4263E8C43559293 Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextOperation_B4263E8C43559293 Default => DefaultHolder.Instance;
        private SourceGenerationContextOperation_B4263E8C43559293(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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