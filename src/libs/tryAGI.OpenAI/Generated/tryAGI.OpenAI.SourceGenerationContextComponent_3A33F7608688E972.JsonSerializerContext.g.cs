
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_3A33F7608688E972
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_02C9B4E931291FA8.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_02FD9B3669099389.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_1C083C85BF0DEC97.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_247D209EFF727AAE.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2BB49AC94BBECE10.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2F1343A1BEEA6930.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2FC0AD881F78FA9C.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_35E01D045246FBAA.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_4747639BA57D9386.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_47A08272360DE9EE.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_4878EFF16E56F26F.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_51168E8ED23B6B81.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_59054E1D2F0349F6.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_5E4D266C4159B300.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_605DC0EC4C0174F1.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_61ABDD57CF5A1B32.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_75DFC455792C4960.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_78EBBA7CBF35AEC8.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_7BC5EE3390CD68B4.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_AA4301DE3489EA08.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B2921A7E653A25D3.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_BD303339A20C0C37.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C2B6457B92231B67.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_D017B4420FCFD790.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_D62DE0118CBC8F75.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E35C7C88EE224249.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F63CB980CE2853D3.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_FA5109E2B96118C5.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_FBCBDA1DAA3E0750.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::tryAGI.OpenAI.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.OutputItemJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.OutputItemJsonConverter());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.OutputItem))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0376.Create_OutputItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.OutputItem?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0313.Create_NullableOutputItem2(options);
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