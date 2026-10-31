
#nullable enable
namespace tryAGI.OpenAI.Realtime
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class RealtimeSourceGenerationContextComponent_72D99E85884262B5
    {

        internal static readonly global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_5B20F18F5A55C752.MetadataScope,                    static () => global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_711BDA8375500B3F.MetadataScope,                    static () => global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_C44D31999678F42F.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::tryAGI.OpenAI.Realtime.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.Realtime.ToolChoiceOptions?, global::tryAGI.OpenAI.Realtime.ToolChoiceFunction, global::tryAGI.OpenAI.Realtime.ToolChoiceMCP>>(static () => new global::tryAGI.OpenAI.Realtime.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.Realtime.ToolChoiceOptions?, global::tryAGI.OpenAI.Realtime.ToolChoiceFunction, global::tryAGI.OpenAI.Realtime.ToolChoiceMCP>());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.Realtime.OneOf<global::tryAGI.OpenAI.Realtime.ToolChoiceOptions?, global::tryAGI.OpenAI.Realtime.ToolChoiceFunction, global::tryAGI.OpenAI.Realtime.ToolChoiceMCP>))
                {
                    return global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextMetadata0FactoryBatch0033.Create_RealtimeSourceGenerationContextMetadataType_72D99E85884262B5(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Realtime.OneOf<global::tryAGI.OpenAI.Realtime.ToolChoiceOptions?, global::tryAGI.OpenAI.Realtime.ToolChoiceFunction, global::tryAGI.OpenAI.Realtime.ToolChoiceMCP>?))
                {
                    return global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextMetadata0FactoryBatch0034.Create_RealtimeSourceGenerationContextMetadataType_8869A336C0464861(options);
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