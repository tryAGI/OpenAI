
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_7FDFFCC644A0C884
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_6F6148B52AF91F26.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_ACB375A01F312AFE.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::tryAGI.OpenAI.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDelta2>>(static () => new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDelta2>());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDelta2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_SourceGenerationContextMetadataType_7FDFFCC644A0C884.Create_SourceGenerationContextMetadataType_7FDFFCC644A0C884(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDelta2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_SourceGenerationContextMetadataType_DE5C1E599D53D00D.Create_SourceGenerationContextMetadataType_DE5C1E599D53D00D(options);
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