
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_B8083CF98E879215
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_075F72DF2B04B957.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_080BD58B87EF7CAD.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_08F848B2FF39BAB5.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_16ABB5428CB21795.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_1765BB7DE0F4C7A4.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_3A56E8735B86EA1F.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_3DE9C29BEF891D37.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_45BE497D5B8663B7.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_49A7225623E904AF.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_5B575F7444D31358.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_5D0098962C8F10E6.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6A8C47C082ECC797.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_7024AE3FE0917E3B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_74F81216183B00ED.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_777237AD3B007EA1.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_77EB49864E6D7A09.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_8C71ED8C2E9E9105.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_93551D0EC89AAE76.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_968E82BF822AD2D7.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_9F35CB1D1C9523F2.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_A3FB97C83738482C.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_BDE9746BCA6DF9BC.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C7D33771D6C28DB8.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_D13FCEEA46B195E2.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_D2BF2F4DCF7018E2.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_D8394941173CF05C.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E2788FB62F3D7F16.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E27902287771C684.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E7E77E52DAD95E97.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E8D1B7B94448AA26.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_EAA14DC77FDEDBA5.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F0046A29F169734B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F7C4A5697BE162B1.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_FE04A73D8C100047.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::tryAGI.OpenAI.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.BetaItemResourceJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.BetaItemResourceJsonConverter());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.BetaItemResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0039.Create_BetaItemResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaItemResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0214.Create_NullableBetaItemResource2(options);
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