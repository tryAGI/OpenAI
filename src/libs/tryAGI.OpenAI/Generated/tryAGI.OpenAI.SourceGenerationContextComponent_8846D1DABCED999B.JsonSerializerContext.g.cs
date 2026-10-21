
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_8846D1DABCED999B
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_01C74C4314094596.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_054AF79AFC5F23D3.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_1BBA3BA8DD2BED68.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2CE06A9E7F8C3E6B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_8DD65E4B217ED2D4.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_A624CB925F016BBD.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B033E56FAACE8AC2.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_D7BB696564ABF2D1.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_D8F74B0240BA31FB.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_DB4E3CC61DDC0883.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_DD5F7FA32D395D6E.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_FC0ACBA26C044EC8.MetadataScope,
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
                if (type == typeof(global::tryAGI.OpenAI.RunObject))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_RunObject.Create_RunObject(options);
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