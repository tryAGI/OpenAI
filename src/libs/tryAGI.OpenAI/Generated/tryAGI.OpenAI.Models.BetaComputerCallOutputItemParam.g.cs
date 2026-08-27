
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The output of a computer tool call.
    /// </summary>
    public sealed partial class BetaComputerCallOutputItemParam
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::tryAGI.OpenAI.BetaAgentTagParam? Agent { get; set; }

        /// <summary>
        ///
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
        /// The type of the computer tool call output. Always `computer_call_output`.<br/>
        /// Default Value: computer_call_output
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaComputerCallOutputItemParamType.ComputerCallOutput</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaComputerCallOutputItemParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaComputerCallOutputItemParamType Type { get; set; } = global::tryAGI.OpenAI.BetaComputerCallOutputItemParamType.ComputerCallOutput;

        /// <summary>
        /// A computer screenshot image used with the computer use tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BetaComputerScreenshotImage Output { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acknowledged_safety_checks")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaComputerCallSafetyCheckParam>? AcknowledgedSafetyChecks { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public global::tryAGI.OpenAI.BetaFunctionCallItemStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComputerCallOutputItemParam" /> class.
        /// </summary>
        /// <param name="callId">
        /// The ID of the computer tool call that produced the output.
        /// </param>
        /// <param name="output">
        /// A computer screenshot image used with the computer use tool.
        /// </param>
        /// <param name="agent"></param>
        /// <param name="id"></param>
        /// <param name="acknowledgedSafetyChecks"></param>
        /// <param name="status"></param>
        /// <param name="type">
        /// The type of the computer tool call output. Always `computer_call_output`.<br/>
        /// Default Value: computer_call_output
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaComputerCallOutputItemParam(
            string callId,
            global::tryAGI.OpenAI.BetaComputerScreenshotImage output,
            global::tryAGI.OpenAI.BetaAgentTagParam? agent,
            string? id,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaComputerCallSafetyCheckParam>? acknowledgedSafetyChecks,
            global::tryAGI.OpenAI.BetaFunctionCallItemStatus? status,
            global::tryAGI.OpenAI.BetaComputerCallOutputItemParamType type = global::tryAGI.OpenAI.BetaComputerCallOutputItemParamType.ComputerCallOutput)
        {
            this.Agent = agent;
            this.Id = id;
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Type = type;
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.AcknowledgedSafetyChecks = acknowledgedSafetyChecks;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComputerCallOutputItemParam" /> class.
        /// </summary>
        public BetaComputerCallOutputItemParam()
        {
        }

    }
}