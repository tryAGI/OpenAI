
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_E195AA54F4265B30
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_0246451F5ED5D6E2.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2CE42DC6CC8FA3B4.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2DECBE399360342B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_68E6E608449B3CE3.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_88DE3147ADF0AD0E.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_9103EACFD8BEB5A0.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F68AE084A4601A23.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::tryAGI.OpenAI.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.RunStepStreamEventJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.RunStepStreamEventJsonConverter());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.RunStepStreamEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0449.Create_RunStepStreamEvent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.RunStepStreamEvent?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0347.Create_NullableRunStepStreamEvent2(options);
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