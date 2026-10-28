
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_461BB15891E9F439
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_0423C84969FB5EF1.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_1336C8A54D025F0C.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_1EE7671040E4F48C.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_39CACFCBC1CBB46B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_4360F82900C5EA37.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_679C8DF89AE5E67A.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_685FE089EEEF418E.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_8A336C440BEBE0E5.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B5BEFB4A926F0A7E.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_D3EE725DD9947A25.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E57DBB50EBD7946A.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F1C5BEFADCB57B0E.MetadataScope,
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
                if (type == typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0414.Create_RealtimeSessionCreateRequestGA(options);
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