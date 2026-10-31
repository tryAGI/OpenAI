
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_1C6A6F39AD9B0A23
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_1DBE7A63D39A1B10.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_25E2F80755AA69E1.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_3852CABA1EC088C8.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_3DB02BA0B153554C.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_4A5EB82322E38F87.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_585865CD02812E94.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_CEF441CB332CE496.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_DF0D30102AF80107.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_F3BA62CA25D43CB7.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_FCD3BFA9BAA3992E.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::tryAGI.OpenAI.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.BetaComputerActionJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.BetaComputerActionJsonConverter());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerAction))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0027.Create_BetaComputerAction2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaComputerAction?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0222.Create_NullableBetaComputerAction2(options);
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