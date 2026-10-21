
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextComponent_3D08FB9ACFD80A15 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope Value = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_04CA9733FF9C671B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_1CA27886BC032A35.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_3E0EE9A713F6668A.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_58979DB387D671B6.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_838084EDE892D05C.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_855DF957ACCB1644.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F318BE36998F949B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F80F030838657A97.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_FD9A07298C6B61B0.MetadataScope,
                }, ContributeConverters);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextComponent_3D08FB9ACFD80A15 Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextComponent_3D08FB9ACFD80A15 Default => DefaultHolder.Instance;
        private SourceGenerationContextComponent_3D08FB9ACFD80A15(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultHolder.Options;
        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type) =>
            MetadataScope.GetTypeInfo(type, Options);
        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::tryAGI.OpenAI.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceParamJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceParamJsonConverter());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.BetaToolChoiceParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_BetaToolChoiceParam.Create_BetaToolChoiceParam(options);
                }
                global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? additional = null;
                ResolveAdditionalTypeInfo(type, options, ref additional);
                return additional;
            }

            static partial void ResolveAdditionalTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options,
                ref global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? result);
        }

    }
}