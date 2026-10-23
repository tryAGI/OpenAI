
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_BAF7636C833FBA59
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_029184B90EAE7EA5.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_07402FB9EC7C4876.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_5D11499DD652A610.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6D4BA6DACE421131.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_A2FBF7D1A24F056B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_BBA0C2B9BD48E775.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_BD5DDB212A32840C.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_DAC8ED552C83BBD9.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F3F11AA2A5817CE8.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F8F073842E7DE5CB.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::tryAGI.OpenAI.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.RunStreamEventJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.RunStreamEventJsonConverter());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.RunStreamEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0430.Create_RunStreamEvent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStreamEvent?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0328.Create_NullableRunStreamEvent2(options);
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