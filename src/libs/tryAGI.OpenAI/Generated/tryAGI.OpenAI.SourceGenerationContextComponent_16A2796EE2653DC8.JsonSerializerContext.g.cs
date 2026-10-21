
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextComponent_16A2796EE2653DC8 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope Value = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_0DADC9CEB592F960.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_168A8A7419917732.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_1B9803FC99393DEE.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_4D4A667255AA31E2.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_52260EF5088A9A5F.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_7957932886EC15E4.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_8CD0FB57F33D6D6A.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_946219FE9F184780.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_A7C10C5D66CA1901.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_AD75077D3ED7086E.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B835861D5E4A260E.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_D8FEE105F29F0EC3.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F9B112F628920A0A.MetadataScope,
                }, ContributeConverters);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextComponent_16A2796EE2653DC8 Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextComponent_16A2796EE2653DC8 Default => DefaultHolder.Instance;
        private SourceGenerationContextComponent_16A2796EE2653DC8(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.ToolsItem15JsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.ToolsItem15JsonConverter());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.ToolsItem15))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_ToolsItem152.Create_ToolsItem152(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolsItem15?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_NullableToolsItem152.Create_NullableToolsItem152(options);
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