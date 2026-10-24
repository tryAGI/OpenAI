
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_742B52DDA63D0A83
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_00DD3835CB3A8749.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_06BA11DF98B50B79.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_12D44E5072868BD0.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_19B309F569926DF8.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_1FBE99ED44AE0464.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2304ED737B987F90.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2CA6FC681FFDC683.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2FD7E56DC127A36D.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_39DADC131F214781.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_3BD5FAB31012FAED.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_3CA21C5ECFAEE76A.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_5139B73E24B70FB9.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_51B014A785534177.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6A13B9071C814F4D.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6DCC8F480FA91D91.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_78B8B168B8DD8BBD.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_793C2F5D9A4D0811.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_8A00296A1BFC0CF7.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_9BCC06E2966BC797.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_A3A78AB6D25E3FA9.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B060C9C7D40F95D7.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B23DC6193416BD1E.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B31415149D1DB8A1.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_BFB1FF47A90B8AE7.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C226097A0CB83B83.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_CBA199DC8B18798B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_CD42A1FDDBFF4A0E.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_D48090FDCBBADCDE.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_D9886B55F225BE0C.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_DA214E6E16EA9B09.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E756DB731CAB6E5A.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E8CC6D07CB9BCAD5.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_EC2CDC330DB5E469.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_FEE0FD5FA9ECEE31.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::tryAGI.OpenAI.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.SessionEventJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.SessionEventJsonConverter());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.SessionEvent))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0452.Create_SessionEvent2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionEvent?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0348.Create_NullableSessionEvent2(options);
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