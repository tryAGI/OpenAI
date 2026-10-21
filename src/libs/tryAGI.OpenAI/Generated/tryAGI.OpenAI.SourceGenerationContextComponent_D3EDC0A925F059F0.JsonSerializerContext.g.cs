
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextComponent_D3EDC0A925F059F0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope Value = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_12525BAEFAABFDB0.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2BFF8684B4080648.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_41ABEC97701C332A.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_473207C18E681E6B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_52BD4B5372D35CC9.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_7120AAA43D169CBF.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_76B0DE8D6E07C154.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_77427D9CE2106D42.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_81E923627B27C9E2.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_AFA7755445E86A4B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_AFB62483ED827CF6.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B98A64B1AB73356F.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_BF29D19EF2550665.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_D60CAFF6F6C84DD9.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_DCE384C13DBED287.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E97ED4922A53E4F3.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F41C4F3B60F94D23.MetadataScope,
                }, ContributeConverters);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextComponent_D3EDC0A925F059F0 Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextComponent_D3EDC0A925F059F0 Default => DefaultHolder.Instance;
        private SourceGenerationContextComponent_D3EDC0A925F059F0(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.ToolSearchOutputToolJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.ToolSearchOutputToolJsonConverter());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.ToolSearchOutputTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_ToolSearchOutputTool2.Create_ToolSearchOutputTool2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolSearchOutputTool?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_NullableToolSearchOutputTool2.Create_NullableToolSearchOutputTool2(options);
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