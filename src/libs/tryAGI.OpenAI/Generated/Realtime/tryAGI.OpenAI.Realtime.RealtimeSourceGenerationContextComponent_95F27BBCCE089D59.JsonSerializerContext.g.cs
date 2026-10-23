
#nullable enable
namespace tryAGI.OpenAI.Realtime
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class RealtimeSourceGenerationContextComponent_95F27BBCCE089D59
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
            collector.AddEnum(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDoneType), static () => new global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseContentPartDoneTypeJsonConverter());
            collector.AddEnum(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDoneType?), static () => new global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventResponseContentPartDoneTypeNullableJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDoneType))
                {
                    return global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextMetadata0Factory_RealtimeServerEventResponseContentPartDoneType2.Create_RealtimeServerEventResponseContentPartDoneType2(options);
                }
                if (type == typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDoneType?))
                {
                    return global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContextMetadata0Factory_NullableRealtimeServerEventResponseContentPartDoneType2.Create_NullableRealtimeServerEventResponseContentPartDoneType2(options);
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