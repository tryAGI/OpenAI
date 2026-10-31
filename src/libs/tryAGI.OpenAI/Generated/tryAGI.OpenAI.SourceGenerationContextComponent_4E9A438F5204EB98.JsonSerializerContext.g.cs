
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_4E9A438F5204EB98
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_168A8A7419917732.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_1B9803FC99393DEE.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_4D4A667255AA31E2.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_52260EF5088A9A5F.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_67502A858E251EC8.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_7957932886EC15E4.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_8CD0FB57F33D6D6A.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_946219FE9F184780.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_A7C10C5D66CA1901.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_AD75077D3ED7086E.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B835861D5E4A260E.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_D8FEE105F29F0EC3.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F9B112F628920A0A.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::tryAGI.OpenAI.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.ToolChoiceVariant22JsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.ToolChoiceVariant22JsonConverter());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceVariant22))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0567.Create_ToolChoiceVariant222(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ToolChoiceVariant22?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0361.Create_NullableToolChoiceVariant222(options);
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