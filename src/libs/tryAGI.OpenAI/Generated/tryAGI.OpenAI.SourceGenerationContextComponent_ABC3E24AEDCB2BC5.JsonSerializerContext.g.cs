
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextComponent_ABC3E24AEDCB2BC5 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope Value = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_02326BE24D50B25F.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_02F101A95F0D3993.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_03760ECD9C8BC0A6.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_0F10168CE55D9149.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_1193C031299D9F6D.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_1DF4A20E7EC28044.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_1E8987F08AE309CC.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_27569B653389618D.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_3016A110B0FED36A.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_34DC8E4B2B342F02.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_37AF749BC94CFC6B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_55B1222CBDB483E3.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_5A61CB7F845F9E55.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6B3377EBBA9D5BE3.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_81F12EABB17B3E67.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_857589D9E890436E.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_8C765F0C08872D7B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_9997ECA2ED3C8A1B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_ABD4893C98ADF93B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B571DBB6CCDEEC85.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_CE069641FA3C9A15.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_D77B360CC92A0FE5.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_DF0620032DEBB943.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E467362A013A6CCC.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E664D23304B02A20.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_EBD521E2F84D8F31.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F8E0C08E30B0DF56.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_FF0CA12EE4269296.MetadataScope,
                }, ContributeConverters);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextComponent_ABC3E24AEDCB2BC5 Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextComponent_ABC3E24AEDCB2BC5 Default => DefaultHolder.Instance;
        private SourceGenerationContextComponent_ABC3E24AEDCB2BC5(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.LiveServerEvent2JsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.LiveServerEvent2JsonConverter());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.LiveServerEvent2))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_LiveServerEvent22.Create_LiveServerEvent22(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.LiveServerEvent2?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_NullableLiveServerEvent22.Create_NullableLiveServerEvent22(options);
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