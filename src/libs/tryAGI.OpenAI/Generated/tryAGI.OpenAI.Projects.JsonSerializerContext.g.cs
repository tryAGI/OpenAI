
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class ProjectsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F2B5827F30853E5B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_EFEB8EAF6F33EABD.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C7994DCB63850A27.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F98EED57C0498A42.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2CD24BDDC2734724.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_65655DC6850B3286.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_A14A5274403017E4.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_D17ACCE791E35807.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_12A80423C8986E84.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_FA8542305B9182AD.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F37FC606D7242847.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_757E6DCC3A1D6651.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_A1B9E5E105F93AC3.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_29BC55F7D8CDC862.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_1D4F131A849F292B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_01FD5EB9FA1756DD.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_92B4084B43A88849.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_EEF812F577E44C39.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_ABA6B0E9F60DD4F6.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_69F14F109210CB2B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_8C499EF26F409686.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_8400B1F37321B9D6.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_7F44A9013237A012.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_1526C89E5B7056BC.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_CD35AB2C01CA7F97.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_50847026D37BEE0D.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E84C364101046857.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_FAA58B5E2FF70C10.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_EEBB18E24A2EA1F9.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_FC66F021C67D064C.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_BEBACF37C7C21338.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F58C0F993DE7E6C4.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly ProjectsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static ProjectsSourceGenerationContext Default => DefaultHolder.Instance;
        private ProjectsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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