
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The output of a computer tool call.
    /// </summary>
    public sealed partial class ComputerCallOutputItemParam
    {
        /// <summary>
        /// The safety checks reported by the API that have been acknowledged by the developer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acknowledged_safety_checks")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ComputerCallSafetyCheckParam>? AcknowledgedSafetyChecks { get; set; }

        /// <summary>
        /// The ID of the computer tool call that produced the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// The ID of the computer tool call output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// A computer screenshot image used with the computer use tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ComputerScreenshotImage Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public object? Status { get; set; }

        /// <summary>
        /// The type of the computer tool call output. Always `computer_call_output`.<br/>
        /// Default Value: computer_call_output
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ComputerCallOutputItemParamType.ComputerCallOutput</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ComputerCallOutputItemParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.ComputerCallOutputItemParamType Type { get; set; } = global::tryAGI.OpenAI.ComputerCallOutputItemParamType.ComputerCallOutput;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerCallOutputItemParam" /> class.
        /// </summary>
        /// <param name="acknowledgedSafetyChecks">
        /// The safety checks reported by the API that have been acknowledged by the developer.
        /// </param>
        /// <param name="callId">
        /// The ID of the computer tool call that produced the output.
        /// </param>
        /// <param name="id">
        /// The ID of the computer tool call output.
        /// </param>
        /// <param name="output">
        /// A computer screenshot image used with the computer use tool.
        /// </param>
        /// <param name="status"></param>
        /// <param name="type">
        /// The type of the computer tool call output. Always `computer_call_output`.<br/>
        /// Default Value: computer_call_output
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComputerCallOutputItemParam(
            string callId,
            global::tryAGI.OpenAI.ComputerScreenshotImage output,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ComputerCallSafetyCheckParam>? acknowledgedSafetyChecks,
            string? id,
            object? status,
            global::tryAGI.OpenAI.ComputerCallOutputItemParamType type = global::tryAGI.OpenAI.ComputerCallOutputItemParamType.ComputerCallOutput)
        {
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.AcknowledgedSafetyChecks = acknowledgedSafetyChecks;
            this.Id = id;
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerCallOutputItemParam" /> class.
        /// </summary>
        public ComputerCallOutputItemParam()
        {
        }
    }
}