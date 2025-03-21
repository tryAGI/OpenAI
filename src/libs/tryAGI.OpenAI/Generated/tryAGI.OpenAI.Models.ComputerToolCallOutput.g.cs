
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The output of a computer tool call.
    /// </summary>
    public sealed partial class ComputerToolCallOutput
    {
        /// <summary>
        /// The type of the computer tool call output. Always `computer_call_output`.<br/>
        /// Default Value: computer_call_output
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ComputerToolCallOutputType.ComputerCallOutput</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ComputerToolCallOutputTypeJsonConverter))]
        public global::tryAGI.OpenAI.ComputerToolCallOutputType Type { get; set; } = global::tryAGI.OpenAI.ComputerToolCallOutputType.ComputerCallOutput;

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
        /// The safety checks reported by the API that have been acknowledged by the <br/>
        /// developer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acknowledged_safety_checks")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ComputerToolCallSafetyCheck>? AcknowledgedSafetyChecks { get; set; }

        /// <summary>
        /// A computer screenshot image used with the computer use tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ComputerScreenshotImage Output { get; set; }

        /// <summary>
        /// The status of the message input. One of `in_progress`, `completed`, or<br/>
        /// `incomplete`. Populated when input items are returned via API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ComputerToolCallOutputStatusJsonConverter))]
        public global::tryAGI.OpenAI.ComputerToolCallOutputStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerToolCallOutput" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the computer tool call output. Always `computer_call_output`.<br/>
        /// Default Value: computer_call_output
        /// </param>
        /// <param name="id">
        /// The ID of the computer tool call output.
        /// </param>
        /// <param name="callId">
        /// The ID of the computer tool call that produced the output.
        /// </param>
        /// <param name="acknowledgedSafetyChecks">
        /// The safety checks reported by the API that have been acknowledged by the <br/>
        /// developer.
        /// </param>
        /// <param name="output">
        /// A computer screenshot image used with the computer use tool.
        /// </param>
        /// <param name="status">
        /// The status of the message input. One of `in_progress`, `completed`, or<br/>
        /// `incomplete`. Populated when input items are returned via API.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComputerToolCallOutput(
            string callId,
            global::tryAGI.OpenAI.ComputerScreenshotImage output,
            string? id,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ComputerToolCallSafetyCheck>? acknowledgedSafetyChecks,
            global::tryAGI.OpenAI.ComputerToolCallOutputStatus? status,
            global::tryAGI.OpenAI.ComputerToolCallOutputType type = global::tryAGI.OpenAI.ComputerToolCallOutputType.ComputerCallOutput)
        {
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.Type = type;
            this.Id = id;
            this.AcknowledgedSafetyChecks = acknowledgedSafetyChecks;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerToolCallOutput" /> class.
        /// </summary>
        public ComputerToolCallOutput()
        {
        }
    }
}