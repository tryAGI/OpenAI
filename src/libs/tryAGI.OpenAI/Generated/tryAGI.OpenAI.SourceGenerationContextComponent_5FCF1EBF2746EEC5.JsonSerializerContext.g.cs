
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_5FCF1EBF2746EEC5
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_00028C957D03DC15.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_0FF240FC2ECBB9B1.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_20EA257D17AEF911.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_283C6252DC2B7351.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2C234D877D8C0B37.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_35C42138953B81D8.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_40E37956124782BF.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_5FED649AF14460F9.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6BAB477E66C7AD3C.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6DC10958C828F807.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_91F1DC7EAEB02467.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_9BA6766173B60E6D.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_9BCD311EBFF5C52B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C012049DC974419C.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::tryAGI.OpenAI.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.LiveSidebandClientEventJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.LiveSidebandClientEventJsonConverter());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.LiveSidebandClientEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_LiveSidebandClientEvent2.Create_LiveSidebandClientEvent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveSidebandClientEvent?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_NullableLiveSidebandClientEvent2.Create_NullableLiveSidebandClientEvent2(options);
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