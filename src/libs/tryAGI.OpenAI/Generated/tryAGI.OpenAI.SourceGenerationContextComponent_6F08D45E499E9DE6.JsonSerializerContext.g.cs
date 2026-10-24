
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_6F08D45E499E9DE6
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_23ACC0855664BCF3.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_4E37F1E4747A567F.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_A323BAF9835FF427.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_A634E82CDDF9BB5B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_AA98A64AC76AB693.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_CD678F91961EA7BB.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_ECD55F2DFAD0619E.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::tryAGI.OpenAI.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.FineTuneReinforcementHyperparameters))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0139.Create_FineTuneReinforcementHyperparameters(options);
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