
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextOperation_58E7FE0DA0EEE410 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_14848FB0642625C9.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F8221EB66E329005.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C1CA7DF7E6A93740.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C51CEF12023456A0.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2F85213122054D2B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_84CBBA016A86B098.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B7CC71FDF264E8F5.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextOperation_58E7FE0DA0EEE410 Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextOperation_58E7FE0DA0EEE410 Default => DefaultHolder.Instance;
        private SourceGenerationContextOperation_58E7FE0DA0EEE410(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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