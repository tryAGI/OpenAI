
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_E08B4D81537BEB84
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_0855129842D8A1BE.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_37EA7C8E0196BCE5.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_82F1D6363162A784.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_9B2D485A55108995.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B36C40CE04E59FAD.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_D8A4128EB46644DA.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_FD160451A05490AF.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_FF418794F028B13F.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::tryAGI.OpenAI.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.RealtimeTranslationServerEventJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.RealtimeTranslationServerEventJsonConverter());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0420.Create_RealtimeTranslationServerEvent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RealtimeTranslationServerEvent?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0335.Create_NullableRealtimeTranslationServerEvent2(options);
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