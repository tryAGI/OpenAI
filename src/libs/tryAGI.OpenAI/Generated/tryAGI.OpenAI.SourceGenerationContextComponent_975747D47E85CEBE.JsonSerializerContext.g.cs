
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_975747D47E85CEBE
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2E697B088CC65F21.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_37895F451FC874EA.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_43F6A031F2E58FC4.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_7C6351304BA5D529.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_8530F5FEAFFACF52.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_913B11637E2A200D.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_A889AA3E16D943A9.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B7DCC18A84855C3B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_CDE24F53D346A522.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E13679F771D3981E.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E57CB770B257E56F.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_EEC1831CCAF8EB51.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::tryAGI.OpenAI.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.ResultsItemJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.ResultsItemJsonConverter());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.ResultsItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_ResultsItem2_3.Create_ResultsItem2_3(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.ResultsItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_NullableResultsItem2_3.Create_NullableResultsItem2_3(options);
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