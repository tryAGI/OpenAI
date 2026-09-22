
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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseSteerRequiredInputRequiredToolSearchOutputTypeJsonConverter))]
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutputType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseSteerRequiredInputRequiredToolSearchOutputExecutionJsonConverter))]
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutputExecution Execution { get; set; }

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
            global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutputType type,
            global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutputExecution execution)
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

    }
}