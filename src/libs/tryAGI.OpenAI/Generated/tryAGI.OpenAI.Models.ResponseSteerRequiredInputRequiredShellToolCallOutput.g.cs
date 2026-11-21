
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Supply `output` using the shell tool call output input schema. Each<br/>
    /// output entry includes `stdout`, `stderr`, and `outcome`.
    /// </summary>
    public sealed partial class ResponseSteerRequiredInputRequiredShellToolCallOutput
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"shell_call_output"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "shell_call_output";

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
        /// Initializes a new instance of the <see cref="ResponseSteerRequiredInputRequiredShellToolCallOutput" /> class.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseSteerRequiredInputRequiredShellToolCallOutput(
            string callId,
            string type = "shell_call_output")
        {
            this.Type = type;
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSteerRequiredInputRequiredShellToolCallOutput" /> class.
        /// </summary>
        public ResponseSteerRequiredInputRequiredShellToolCallOutput()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ResponseSteerRequiredInputRequiredShellToolCallOutput"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ResponseSteerRequiredInputRequiredShellToolCallOutput FromCallId(string callId)
        {
            return new ResponseSteerRequiredInputRequiredShellToolCallOutput
            {
                CallId = callId,
            };
        }

    }
}