
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_35D02BB85A47B024
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_080BD58B87EF7CAD.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_088CECCFF6C4172E.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_08F848B2FF39BAB5.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_14AB27C5DEA6CEBD.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_1E4AA697B0BC5897.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_25EBC5D688F4D60F.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_344D2703E8637142.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_38923EE174AC2F43.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_3A56E8735B86EA1F.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_431C3C8631367735.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_49A7225623E904AF.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_4B09C51D3801FA64.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_5B575F7444D31358.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_61C8594BEF6747A7.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_61E739A22E4031A0.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_7024AE3FE0917E3B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_717D6A16384E729B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_7FC7643E1CA37433.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_8C71ED8C2E9E9105.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_9699399C1A6241C8.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_A10A9A065F72E109.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_A3FB97C83738482C.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B53FE94682395D9A.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B642E40A4FFE1CE7.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C1097680855E2D53.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C435D8438ABFE4DA.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C8BA4947E22B7FE2.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_D13FCEEA46B195E2.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E2788FB62F3D7F16.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F0046A29F169734B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F158492CCE08B600.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F7C4A5697BE162B1.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::tryAGI.OpenAI.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.BetaItemJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.BetaItemJsonConverter());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.BetaItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0038.Create_BetaItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0214.Create_NullableBetaItem2(options);
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