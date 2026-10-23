
#nullable enable
namespace tryAGI.OpenAI.Realtime
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class RealtimeSourceGenerationContextComponent_8208C044BAC43E41
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
            collector.AddEnum(typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageUserContentItemDetail), static () => new global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemMessageUserContentItemDetailJsonConverter());
            collector.AddEnum(typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageUserContentItemDetail?), static () => new global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemMessageUserContentItemDetailNullableJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageUserContentItemDetail))
                {
                    return global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextMetadata0Factory_RealtimeConversationItemMessageUserContentItemDetail2.Create_RealtimeConversationItemMessageUserContentItemDetail2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageUserContentItemDetail?))
                {
                    return global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextMetadata0Factory_NullableRealtimeConversationItemMessageUserContentItemDetail2.Create_NullableRealtimeConversationItemMessageUserContentItemDetail2(options);
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