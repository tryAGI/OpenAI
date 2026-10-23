
#nullable enable
namespace tryAGI.OpenAI.Realtime
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class RealtimeSourceGenerationContextComponent_2445533BF51094A5
    {

        internal static readonly global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextMetadataScope>[] {
                    static () => global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_007BA07BFFD74B64.MetadataScope,                    static () => global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_01FA0BE50F88F403.MetadataScope,                    static () => global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_254E2F54B7F4B784.MetadataScope,                    static () => global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_470FAE45E5249759.MetadataScope,                    static () => global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_4D22A1C18492F3CA.MetadataScope,                    static () => global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_577EBACCF56ADDF6.MetadataScope,                    static () => global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_677611221911EA9F.MetadataScope,                    static () => global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_7D933DB192241426.MetadataScope,                    static () => global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_B78065A339EF8568.MetadataScope,                    static () => global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextComponent_C3B446675A6C3861.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemJsonConverter>(static () => new global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItem))
                {
                    return global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextMetadata0Factory_RealtimeConversationItem2.Create_RealtimeConversationItem2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItem?))
                {
                    return global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextMetadata0Factory_NullableRealtimeConversationItem2.Create_NullableRealtimeConversationItem2(options);
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