
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_78D9FFE65D57F903
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_270117B62332F83E.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_2E7562A5EF420CF8.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_52E9027093B126C8.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_5CE6BCF3378AEE6A.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6BF222AA49FFFC88.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_77C943988588063A.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_87618D4523BA3B00.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_9616234A69B6E191.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_9A01D7C5361B9D0D.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B2F98E19C80B465F.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_D0306E3F6E6CDB78.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_DB1329AC7DA3DF28.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F83288E2815CC239.MetadataScope,
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
                if (type == typeof(global::tryAGI.OpenAI.CreateModerationResponseResultCategoryAppliedInputTypes))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0109.Create_CreateModerationResponseResultCategoryAppliedInputTypes(options);
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