
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Supply `output` using the computer tool call output input schema,<br/>
    /// including any required `acknowledged_safety_checks`.
    /// </summary>
    public sealed partial class ResponseSteerRequiredInputRequiredComputerToolCallOutput
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"computer_call_output"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "computer_call_output";

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
        /// Initializes a new instance of the <see cref="ResponseSteerRequiredInputRequiredComputerToolCallOutput" /> class.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseSteerRequiredInputRequiredComputerToolCallOutput(
            string callId,
            string type = "computer_call_output")
        {
            this.Type = type;
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSteerRequiredInputRequiredComputerToolCallOutput" /> class.
        /// </summary>
        public ResponseSteerRequiredInputRequiredComputerToolCallOutput()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ResponseSteerRequiredInputRequiredComputerToolCallOutput"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ResponseSteerRequiredInputRequiredComputerToolCallOutput FromCallId(string callId)
        {
            return new ResponseSteerRequiredInputRequiredComputerToolCallOutput
            {
                CallId = callId,
            };
        }

    }
}