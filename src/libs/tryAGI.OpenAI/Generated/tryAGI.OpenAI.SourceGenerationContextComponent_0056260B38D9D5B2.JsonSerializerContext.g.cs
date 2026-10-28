
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_0056260B38D9D5B2
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_04A6700997EC031E.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2EED0296986950DF.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_479FAA8E45925CC8.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_5DC052EBFEDDC461.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_62CF37D8DE691B70.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_631AB2DD2AA1B0C1.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6FD5996F6068A659.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_7AA52466015815E0.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_7F8C177A829875E4.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_96A2855EE47262AE.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_9727660F548C2BB2.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B4A690E059051E70.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_BDBBEE4DA9455381.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C1E249D005A966C5.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C2C44466B9755DBC.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_D5C501F8C0811D8B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E631BC47E0E628FA.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F55BFF50511F4BE1.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::tryAGI.OpenAI.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.SessionTurnItemResourceJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.SessionTurnItemResourceJsonConverter());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.SessionTurnItemResource))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0460.Create_SessionTurnItemResource2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.SessionTurnItemResource?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0352.Create_NullableSessionTurnItemResource2(options);
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