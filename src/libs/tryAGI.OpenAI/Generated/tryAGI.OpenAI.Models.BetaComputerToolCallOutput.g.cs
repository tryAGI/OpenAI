
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The output of a computer tool call.
    /// </summary>
    public sealed partial class BetaComputerToolCallOutput
    {
        /// <summary>
        /// The agent that produced this item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::tryAGI.OpenAI.BetaAgentTag? Agent { get; set; }

        /// <summary>
        /// The type of the computer tool call output. Always `computer_call_output`.<br/>
        /// Default Value: computer_call_output
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaComputerToolCallOutputType.ComputerCallOutput</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaComputerToolCallOutputTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaComputerToolCallOutputType Type { get; set; } = global::tryAGI.OpenAI.BetaComputerToolCallOutputType.ComputerCallOutput;

        /// <summary>
        /// The ID of the computer tool call output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The ID of the computer tool call that produced the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// The safety checks reported by the API that have been acknowledged by the<br/>
        /// developer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acknowledged_safety_checks")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaComputerCallSafetyCheckParam>? AcknowledgedSafetyChecks { get; set; }

        /// <summary>
        /// A computer screenshot image used with the computer use tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BetaComputerScreenshotImage Output { get; set; }

        /// <summary>
        /// The status of the message input. One of `in_progress`, `completed`, or<br/>
        /// `incomplete`. Populated when input items are returned via API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaComputerToolCallOutputStatusJsonConverter))]
        public global::tryAGI.OpenAI.BetaComputerToolCallOutputStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComputerToolCallOutput" /> class.
        /// </summary>
        /// <param name="callId">
        /// The ID of the computer tool call that produced the output.
        /// </param>
        /// <param name="output">
        /// A computer screenshot image used with the computer use tool.
        /// </param>
        /// <param name="agent">
        /// The agent that produced this item.
        /// </param>
        /// <param name="id">
        /// The ID of the computer tool call output.
        /// </param>
        /// <param name="acknowledgedSafetyChecks">
        /// The safety checks reported by the API that have been acknowledged by the<br/>
        /// developer.
        /// </param>
        /// <param name="status">
        /// The status of the message input. One of `in_progress`, `completed`, or<br/>
        /// `incomplete`. Populated when input items are returned via API.
        /// </param>
        /// <param name="type">
        /// The type of the computer tool call output. Always `computer_call_output`.<br/>
        /// Default Value: computer_call_output
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaComputerToolCallOutput(
            string callId,
            global::tryAGI.OpenAI.BetaComputerScreenshotImage output,
            global::tryAGI.OpenAI.BetaAgentTag? agent,
            string? id,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaComputerCallSafetyCheckParam>? acknowledgedSafetyChecks,
            global::tryAGI.OpenAI.BetaComputerToolCallOutputStatus? status,
            global::tryAGI.OpenAI.BetaComputerToolCallOutputType type = global::tryAGI.OpenAI.BetaComputerToolCallOutputType.ComputerCallOutput)
        {
            this.Agent = agent;
            this.Type = type;
            this.Id = id;
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.AcknowledgedSafetyChecks = acknowledgedSafetyChecks;
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComputerToolCallOutput" /> class.
        /// </summary>
        public BetaComputerToolCallOutput()
        {
        }

    }
}