
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DecisionInputCustomToolCallOutput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// Text evidence or an ordered list of text and image parts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DecisionInputToolOutputContentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.DecisionInputToolOutputContent Output { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public global::tryAGI.OpenAI.FunctionCallStatusParam? Status { get; set; }

        /// <summary>
        /// Default Value: custom_tool_call_output
        /// </summary>
        /// <default>global::tryAGI.OpenAI.DecisionInputCustomToolCallOutputType.CustomToolCallOutput</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DecisionInputCustomToolCallOutputTypeJsonConverter))]
        public global::tryAGI.OpenAI.DecisionInputCustomToolCallOutputType Type { get; set; } = global::tryAGI.OpenAI.DecisionInputCustomToolCallOutputType.CustomToolCallOutput;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionInputCustomToolCallOutput" /> class.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="output">
        /// Text evidence or an ordered list of text and image parts.
        /// </param>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <param name="type">
        /// Default Value: custom_tool_call_output
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionInputCustomToolCallOutput(
            string callId,
            global::tryAGI.OpenAI.DecisionInputToolOutputContent output,
            string? id,
            global::tryAGI.OpenAI.FunctionCallStatusParam? status,
            global::tryAGI.OpenAI.DecisionInputCustomToolCallOutputType type = global::tryAGI.OpenAI.DecisionInputCustomToolCallOutputType.CustomToolCallOutput)
        {
            this.Id = id;
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Output = output;
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionInputCustomToolCallOutput" /> class.
        /// </summary>
        public DecisionInputCustomToolCallOutput()
        {
        }

    }
}