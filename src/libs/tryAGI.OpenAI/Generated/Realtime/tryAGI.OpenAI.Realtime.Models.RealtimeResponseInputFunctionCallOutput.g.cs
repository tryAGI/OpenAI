
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// The result of a function call supplied as input to a Realtime response.
    /// </summary>
    public sealed partial class RealtimeResponseInputFunctionCallOutput
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeResponseInputFunctionCallOutputTypeJsonConverter))]
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallOutputType Type { get; set; }

        /// <summary>
        /// Default Value: completed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeResponseInputFunctionCallOutputStatusJsonConverter))]
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallOutputStatus? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseInputFunctionCallOutput" /> class.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="output"></param>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="status">
        /// Default Value: completed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeResponseInputFunctionCallOutput(
            string callId,
            string output,
            string? id,
            global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallOutputType type,
            global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallOutputStatus? status)
        {
            this.Id = id;
            this.Type = type;
            this.Status = status;
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseInputFunctionCallOutput" /> class.
        /// </summary>
        public RealtimeResponseInputFunctionCallOutput()
        {
        }

    }
}