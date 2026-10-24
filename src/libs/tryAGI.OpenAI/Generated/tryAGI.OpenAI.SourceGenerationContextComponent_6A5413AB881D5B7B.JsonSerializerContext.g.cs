
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_6A5413AB881D5B7B
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_01B710A46549445A.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_39B6AEC412233DA5.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_3A3A6AE9E1BE018C.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6C8F368204CE4414.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_790D940FB6C8A4A5.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_9407C45AFAF5327B.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_B2EE49B8713CBC78.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_E1DEF4173CFC5A35.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::tryAGI.OpenAI.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerRequiredInputJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerRequiredInputJsonConverter());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInput))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0064.Create_BetaResponseSteerRequiredInput2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInput?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0239.Create_NullableBetaResponseSteerRequiredInput2(options);
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