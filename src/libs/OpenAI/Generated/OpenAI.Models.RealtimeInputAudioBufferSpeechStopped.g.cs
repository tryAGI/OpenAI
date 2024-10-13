
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// Returned in server turn detection mode when speech stops.
    /// </summary>
    public sealed partial class RealtimeInputAudioBufferSpeechStopped
    {
        /// <summary>
        /// The unique ID of the server event.<br/>
        /// Example: event_1718
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be "input_audio_buffer.speech_stopped".<br/>
        /// Example: input_audio_buffer.speech_stopped
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.RealtimeInputAudioBufferSpeechStoppedTypeJsonConverter))]
        public global::OpenAI.RealtimeInputAudioBufferSpeechStoppedType? Type { get; set; }

        /// <summary>
        /// Milliseconds since the session started when speech stopped.<br/>
        /// Example: 2000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_end_ms")]
        public int? AudioEndMs { get; set; }

        /// <summary>
        /// The ID of the user message item that will be created.<br/>
        /// Example: msg_003
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        public string? ItemId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::OpenAI.RealtimeInputAudioBufferSpeechStopped? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::OpenAI.RealtimeInputAudioBufferSpeechStopped),
                jsonSerializerContext) as global::OpenAI.RealtimeInputAudioBufferSpeechStopped;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::OpenAI.RealtimeInputAudioBufferSpeechStopped? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::OpenAI.RealtimeInputAudioBufferSpeechStopped>(
                json,
                jsonSerializerOptions);
        }

    }
}