
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Supply `tools` using the tool search output input schema, retaining<br/>
    /// `execution: "client"`.
    /// </summary>
    public sealed partial class ResponseSteerRequiredInputRequiredToolSearchOutput
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"tool_search_output"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "tool_search_output";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"client"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution")]
        public string Execution { get; set; } = "client";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSteerRequiredInputRequiredToolSearchOutput" /> class.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="type"></param>
        /// <param name="execution"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseSteerRequiredInputRequiredToolSearchOutput(
            string callId,
            string type = "tool_search_output",
            string execution = "client")
        {
            this.Type = type;
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Execution = execution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSteerRequiredInputRequiredToolSearchOutput" /> class.
        /// </summary>
        public ResponseSteerRequiredInputRequiredToolSearchOutput()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ResponseSteerRequiredInputRequiredToolSearchOutput"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ResponseSteerRequiredInputRequiredToolSearchOutput FromCallId(string callId)
        {
            return new ResponseSteerRequiredInputRequiredToolSearchOutput
            {
                CallId = callId,
            };
        }

    }
}