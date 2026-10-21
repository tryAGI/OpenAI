
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextOperation_CE258DAE73451A9C : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F31F0B364502C2FD.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_43A15426EFAE077A.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_32EF56FC4778897A.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_44C8A2CAB8D21376.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_CE6D79D6069A68B9.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B339B2CB4A5CA517.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2CE06A9E7F8C3E6B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_570BDB5E70896CC3.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2CB4032F04932651.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_985CCF1E5253FD77.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_57E6ACBA3F36CE72.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_8A336C440BEBE0E5.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_4360F82900C5EA37.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextOperation_CE258DAE73451A9C Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextOperation_CE258DAE73451A9C Default => DefaultHolder.Instance;
        private SourceGenerationContextOperation_CE258DAE73451A9C(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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