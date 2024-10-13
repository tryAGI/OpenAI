
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// Returned when the model-generated function call arguments are updated.
    /// </summary>
    public sealed partial class RealtimeResponseFunctionCallArgumentsDelta
    {
        /// <summary>
        /// The unique ID of the server event.<br/>
        /// Example: event_5354
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be "response.function_call_arguments.delta".<br/>
        /// Example: response.function_call_arguments.delta
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.RealtimeResponseFunctionCallArgumentsDeltaTypeJsonConverter))]
        public global::OpenAI.RealtimeResponseFunctionCallArgumentsDeltaType? Type { get; set; }

        /// <summary>
        /// The ID of the response.<br/>
        /// Example: resp_002
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_id")]
        public string? ResponseId { get; set; }

        /// <summary>
        /// The ID of the function call item.<br/>
        /// Example: fc_001
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        public string? ItemId { get; set; }

        /// <summary>
        /// The index of the output item in the response.<br/>
        /// Example: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        public int? OutputIndex { get; set; }

        /// <summary>
        /// The ID of the function call.<br/>
        /// Example: call_001
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        public string? CallId { get; set; }

        /// <summary>
        /// The arguments delta as a JSON string.<br/>
        /// Example: {"location": "San"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        public string? Delta { get; set; }

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
        public static global::OpenAI.RealtimeResponseFunctionCallArgumentsDelta? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::OpenAI.RealtimeResponseFunctionCallArgumentsDelta),
                jsonSerializerContext) as global::OpenAI.RealtimeResponseFunctionCallArgumentsDelta;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::OpenAI.RealtimeResponseFunctionCallArgumentsDelta? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::OpenAI.RealtimeResponseFunctionCallArgumentsDelta>(
                json,
                jsonSerializerOptions);
        }

    }
}