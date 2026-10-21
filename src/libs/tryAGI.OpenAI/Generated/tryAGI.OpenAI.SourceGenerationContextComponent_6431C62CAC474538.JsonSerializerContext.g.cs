
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_6431C62CAC474538
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_035CF0575598A999.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_1C1B38C7F62D1E3A.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_73CC9C84DA919C5E.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_949318F241748773.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_A22270E0C183993E.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C21118F16F47F4B0.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::tryAGI.OpenAI.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.DecisionInputVariant2ItemJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.DecisionInputVariant2ItemJsonConverter());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputVariant2Item))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_DecisionInputVariant2Item2.Create_DecisionInputVariant2Item2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.DecisionInputVariant2Item?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_NullableDecisionInputVariant2Item2.Create_NullableDecisionInputVariant2Item2(options);
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