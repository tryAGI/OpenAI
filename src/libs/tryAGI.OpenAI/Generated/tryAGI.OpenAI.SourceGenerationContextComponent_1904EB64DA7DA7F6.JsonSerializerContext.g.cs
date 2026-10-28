
#nullable enable
namespace tryAGI.OpenAI
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_1904EB64DA7DA7F6
    {

        internal static readonly global::tryAGI.OpenAI.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.SourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_C0A56F1C3B7E675C.MetadataScope,                    static () => global::tryAGI.OpenAI.SourceGenerationContextComponent_DA1FF04E3215175E.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::tryAGI.OpenAI.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2>>(static () => new global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2>());
            collector.AddEager<global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter>(static () => new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0470.Create_SourceGenerationContextMetadataType_1904EB64DA7DA7F6(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2>?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0FactoryBatch0539.Create_SourceGenerationContextMetadataType_DE1D0C4BED809B0C(options);
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