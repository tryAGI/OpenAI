
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Supply `output` using the custom tool call output input schema. The<br/>
    /// original custom tool call supplies the tool's name.
    /// </summary>
    public sealed partial class ResponseSteerRequiredInputRequiredCustomToolCallOutput
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"custom_tool_call_output"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "custom_tool_call_output";

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
        /// Initializes a new instance of the <see cref="ResponseSteerRequiredInputRequiredCustomToolCallOutput" /> class.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseSteerRequiredInputRequiredCustomToolCallOutput(
            string callId,
            string type = "custom_tool_call_output")
        {
            this.Type = type;
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSteerRequiredInputRequiredCustomToolCallOutput" /> class.
        /// </summary>
        public ResponseSteerRequiredInputRequiredCustomToolCallOutput()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ResponseSteerRequiredInputRequiredCustomToolCallOutput"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ResponseSteerRequiredInputRequiredCustomToolCallOutput FromCallId(string callId)
        {
            return new ResponseSteerRequiredInputRequiredCustomToolCallOutput
            {
                CallId = callId,
            };
        }

    }
}