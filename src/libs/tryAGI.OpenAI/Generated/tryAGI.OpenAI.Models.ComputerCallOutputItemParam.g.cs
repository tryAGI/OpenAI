
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The output of a computer tool call.
    /// </summary>
    public sealed partial class ComputerCallOutputItemParam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, object>))]
        public global::tryAGI.OpenAI.AnyOf<string, object>? Id { get; set; }

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
        /// <default>global::tryAGI.OpenAI.ComputerCallOutputItemParamType.ComputerCallOutput</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ComputerCallOutputItemParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.ComputerCallOutputItemParamType Type { get; set; } = global::tryAGI.OpenAI.ComputerCallOutputItemParamType.ComputerCallOutput;

        /// <summary>
        /// A computer screenshot image used with the computer use tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ComputerScreenshotImage Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acknowledged_safety_checks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ComputerCallSafetyCheckParam>, object>))]
        public global::tryAGI.OpenAI.AnyOf<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ComputerCallSafetyCheckParam>, object>? AcknowledgedSafetyChecks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<global::tryAGI.OpenAI.ComputerCallOutputItemParamStatus?, object>))]
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.ComputerCallOutputItemParamStatus?, object>? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerCallOutputItemParam" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="callId">
        /// The ID of the computer tool call that produced the output.
        /// </param>
        /// <param name="type">
        /// The type of the computer tool call output. Always `computer_call_output`.<br/>
        /// Default Value: computer_call_output
        /// </param>
        /// <param name="output">
        /// A computer screenshot image used with the computer use tool.
        /// </param>
        /// <param name="acknowledgedSafetyChecks"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComputerCallOutputItemParam(
            string callId,
            global::tryAGI.OpenAI.ComputerScreenshotImage output,
            global::tryAGI.OpenAI.AnyOf<string, object>? id,
            global::tryAGI.OpenAI.AnyOf<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ComputerCallSafetyCheckParam>, object>? acknowledgedSafetyChecks,
            global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.ComputerCallOutputItemParamStatus?, object>? status,
            global::tryAGI.OpenAI.ComputerCallOutputItemParamType type = global::tryAGI.OpenAI.ComputerCallOutputItemParamType.ComputerCallOutput)
        {
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.Id = id;
            this.Type = type;
            this.AcknowledgedSafetyChecks = acknowledgedSafetyChecks;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerCallOutputItemParam" /> class.
        /// </summary>
        public ComputerCallOutputItemParam()
        {
        }
    }
}