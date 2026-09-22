
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Supply `status` and optional `output` using the apply patch tool call<br/>
    /// output input schema.
    /// </summary>
    public sealed partial class ResponseSteerRequiredInputRequiredApplyPatchToolCallOutput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseSteerRequiredInputRequiredApplyPatchToolCallOutputTypeJsonConverter))]
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredApplyPatchToolCallOutputType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSteerRequiredInputRequiredApplyPatchToolCallOutput" /> class.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseSteerRequiredInputRequiredApplyPatchToolCallOutput(
            string callId,
            global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredApplyPatchToolCallOutputType type)
        {
            this.Type = type;
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSteerRequiredInputRequiredApplyPatchToolCallOutput" /> class.
        /// </summary>
        public ResponseSteerRequiredInputRequiredApplyPatchToolCallOutput()
        {
        }

    }
}