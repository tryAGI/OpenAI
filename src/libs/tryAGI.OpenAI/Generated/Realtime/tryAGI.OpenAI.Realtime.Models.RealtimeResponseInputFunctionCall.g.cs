
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// A function call supplied as input to a Realtime response.
    /// </summary>
    public sealed partial class RealtimeResponseInputFunctionCall
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeResponseInputFunctionCallTypeJsonConverter))]
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallType Type { get; set; }

        /// <summary>
        /// Default Value: completed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeResponseInputFunctionCallStatusJsonConverter))]
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallStatus? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseInputFunctionCall" /> class.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="name"></param>
        /// <param name="arguments"></param>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="status">
        /// Default Value: completed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeResponseInputFunctionCall(
            string callId,
            string name,
            string arguments,
            string? id,
            global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallType type,
            global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallStatus? status)
        {
            this.Id = id;
            this.Type = type;
            this.Status = status;
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseInputFunctionCall" /> class.
        /// </summary>
        public RealtimeResponseInputFunctionCall()
        {
        }

    }
}