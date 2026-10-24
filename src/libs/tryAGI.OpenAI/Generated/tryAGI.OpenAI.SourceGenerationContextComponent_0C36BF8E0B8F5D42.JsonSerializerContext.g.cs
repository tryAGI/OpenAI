
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_0C36BF8E0B8F5D42
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_02326BE24D50B25F.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_02F101A95F0D3993.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_03760ECD9C8BC0A6.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_0F10168CE55D9149.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_1193C031299D9F6D.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_1DF4A20E7EC28044.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_1E8987F08AE309CC.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_27569B653389618D.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_3016A110B0FED36A.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_37AF749BC94CFC6B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_5A61CB7F845F9E55.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6B3377EBBA9D5BE3.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_7238B81CD26742FF.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_857589D9E890436E.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_8C765F0C08872D7B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_9997ECA2ED3C8A1B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_ABD4893C98ADF93B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B571DBB6CCDEEC85.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_CE069641FA3C9A15.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_D77B360CC92A0FE5.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_DF0620032DEBB943.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E467362A013A6CCC.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E664D23304B02A20.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_FF0CA12EE4269296.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::tryAGI.OpenAI.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.LiveSidebandServerEventJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.LiveSidebandServerEventJsonConverter());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.LiveSidebandServerEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0191.Create_LiveSidebandServerEvent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveSidebandServerEvent?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0302.Create_NullableLiveSidebandServerEvent2(options);
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