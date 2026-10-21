
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class UsageSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C672FB937D220280.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_EFEB8EAF6F33EABD.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C7994DCB63850A27.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_BAAE54E953603BC4.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_59FE9F06536EFCE0.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_8FC197DD483BDEC7.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_A3D0A62FAEF06C70.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_489BF90D60D36C25.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E23459567401B1E1.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_748E7F7040D0FC8B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E38448E5E9B3D707.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_59D14CF4F2F83A16.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_79991840FD81035B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_001B847670D628F1.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_D8668A7065F875D6.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_53C11D84D0207A43.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_1D6EF64144CFB9B6.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6AAB8BB84F3D3B21.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_5EEDAB2928849489.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_576406C5D42D40DA.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_185D20FF420C133B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_8CD936519F3CEC3B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_1F99CD88D79072E1.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_EE55D9EC636A3CC3.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6D2FAB0921AC7966.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_3C6A1EE6AA967238.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E0199F5CF408E485.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_90DFCD276BE04634.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly UsageSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static UsageSourceGenerationContext Default => DefaultHolder.Instance;
        private UsageSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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