
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A tool call to a computer use tool. See the <br/>
    /// [computer use guide](/docs/guides/tools-computer-use) for more information.
    /// </summary>
    public sealed partial class ComputerToolCall
    {
        /// <summary>
        /// The type of the computer call. Always `computer_call`.<br/>
        /// Default Value: computer_call
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ComputerToolCallType.ComputerCall</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ComputerToolCallTypeJsonConverter))]
        public global::tryAGI.OpenAI.ComputerToolCallType Type { get; set; } = global::tryAGI.OpenAI.ComputerToolCallType.ComputerCall;

        /// <summary>
        /// The unique ID of the computer call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// An identifier used when responding to the tool call with output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ComputerActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ComputerAction Action { get; set; }

        /// <summary>
        /// The pending safety checks for the computer call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_safety_checks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ComputerToolCallSafetyCheck> PendingSafetyChecks { get; set; }

        /// <summary>
        /// The status of the item. One of `in_progress`, `completed`, or<br/>
        /// `incomplete`. Populated when items are returned via API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ComputerToolCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ComputerToolCallStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerToolCall" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the computer call. Always `computer_call`.<br/>
        /// Default Value: computer_call
        /// </param>
        /// <param name="id">
        /// The unique ID of the computer call.
        /// </param>
        /// <param name="callId">
        /// An identifier used when responding to the tool call with output.
        /// </param>
        /// <param name="action"></param>
        /// <param name="pendingSafetyChecks">
        /// The pending safety checks for the computer call.
        /// </param>
        /// <param name="status">
        /// The status of the item. One of `in_progress`, `completed`, or<br/>
        /// `incomplete`. Populated when items are returned via API.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComputerToolCall(
            string id,
            string callId,
            global::tryAGI.OpenAI.ComputerAction action,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ComputerToolCallSafetyCheck> pendingSafetyChecks,
            global::tryAGI.OpenAI.ComputerToolCallStatus status,
            global::tryAGI.OpenAI.ComputerToolCallType type = global::tryAGI.OpenAI.ComputerToolCallType.ComputerCall)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Action = action;
            this.PendingSafetyChecks = pendingSafetyChecks ?? throw new global::System.ArgumentNullException(nameof(pendingSafetyChecks));
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerToolCall" /> class.
        /// </summary>
        public ComputerToolCall()
        {
        }
    }
}