
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextComponent_E6C1C04BF34D5E8A : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope Value = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_0A5FA18D32DCAEE3.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_1BDC47EB8E333039.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_1D98E2DF841F10EA.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_1D9C83B81201836D.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2B1CEE75505BA53C.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_4003B117F8550103.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_46459AE7231E7A08.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6C9ED2BC4D8C40AE.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_8D1C708C966BF961.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_9F39ACB34CA6028C.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_A415B1892722C132.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_A538543399270A58.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_AEC89DC237620B13.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B8D8FA5E23A3AA32.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_CEFD3E7F72EEE2CC.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F4FB3D2BD96333D8.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_FD12AC8A88D5C1E7.MetadataScope,
                }, ContributeConverters);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextComponent_E6C1C04BF34D5E8A Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextComponent_E6C1C04BF34D5E8A Default => DefaultHolder.Instance;
        private SourceGenerationContextComponent_E6C1C04BF34D5E8A(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.BetaToolSearchOutputToolJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.BetaToolSearchOutputToolJsonConverter());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputTool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_BetaToolSearchOutputTool2.Create_BetaToolSearchOutputTool2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputTool?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_NullableBetaToolSearchOutputTool2.Create_NullableBetaToolSearchOutputTool2(options);
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