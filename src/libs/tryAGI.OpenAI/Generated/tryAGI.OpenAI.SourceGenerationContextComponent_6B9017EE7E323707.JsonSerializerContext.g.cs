
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_6B9017EE7E323707
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_1E368B418B5A6E56.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_3029F89FE6359376.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_599208DA08AB2234.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_A98CCC86AFE2D8C5.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_ACFB443DA58F8994.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B9BBE4634FCC9408.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_DFEE91D7D3BF3627.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F50063E09E186BE7.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::tryAGI.OpenAI.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolConfigParamJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolConfigParamJsonConverter());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParam))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0377.Create_PersistedAgentToolConfigParam2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParam?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0314.Create_NullablePersistedAgentToolConfigParam2(options);
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