
#nullable enable
namespace tryAGI.OpenAI.Realtime
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class RealtimeSourceGenerationContextComponent_74EC1F603287E939
    {

        internal static readonly global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextMetadataScope>[] {
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEnum(typeof(global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGAMaxOutputTokens), static () => new global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeSessionCreateResponseGAMaxOutputTokensJsonConverter());
            collector.AddEnum(typeof(global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGAMaxOutputTokens?), static () => new global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeSessionCreateResponseGAMaxOutputTokensNullableJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGAMaxOutputTokens))
                {
                    return global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextMetadata0Factory_RealtimeSessionCreateResponseGAMaxOutputTokens2.Create_RealtimeSessionCreateResponseGAMaxOutputTokens2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateResponseGAMaxOutputTokens?))
                {
                    return global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextMetadata0Factory_NullableRealtimeSessionCreateResponseGAMaxOutputTokens2.Create_NullableRealtimeSessionCreateResponseGAMaxOutputTokens2(options);
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