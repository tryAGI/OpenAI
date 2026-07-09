
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A tool call to a computer use tool. See the<br/>
    /// [computer use guide](/docs/guides/tools-computer-use) for more information.
    /// </summary>
    public sealed partial class BetaComputerToolCall
    {
        /// <summary>
        /// The agent that produced this item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::tryAGI.OpenAI.BetaAgentTag? Agent { get; set; }

        /// <summary>
        /// The type of the computer call. Always `computer_call`.<br/>
        /// Default Value: computer_call
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaComputerToolCallType.ComputerCall</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaComputerToolCallTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaComputerToolCallType Type { get; set; } = global::tryAGI.OpenAI.BetaComputerToolCallType.ComputerCall;

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaComputerActionJsonConverter))]
        public global::tryAGI.OpenAI.BetaComputerAction? Action { get; set; }

        /// <summary>
        /// Flattened batched actions for `computer_use`. Each action includes an<br/>
        /// `type` discriminator and action-specific fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaComputerAction>? Actions { get; set; }

        /// <summary>
        /// The pending safety checks for the computer call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_safety_checks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaComputerCallSafetyCheckParam> PendingSafetyChecks { get; set; }

        /// <summary>
        /// The status of the item. One of `in_progress`, `completed`, or<br/>
        /// `incomplete`. Populated when items are returned via API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaComputerToolCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BetaComputerToolCallStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComputerToolCall" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the computer call.
        /// </param>
        /// <param name="callId">
        /// An identifier used when responding to the tool call with output.
        /// </param>
        /// <param name="pendingSafetyChecks">
        /// The pending safety checks for the computer call.
        /// </param>
        /// <param name="status">
        /// The status of the item. One of `in_progress`, `completed`, or<br/>
        /// `incomplete`. Populated when items are returned via API.
        /// </param>
        /// <param name="agent">
        /// The agent that produced this item.
        /// </param>
        /// <param name="action"></param>
        /// <param name="actions">
        /// Flattened batched actions for `computer_use`. Each action includes an<br/>
        /// `type` discriminator and action-specific fields.
        /// </param>
        /// <param name="type">
        /// The type of the computer call. Always `computer_call`.<br/>
        /// Default Value: computer_call
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaComputerToolCall(
            string id,
            string callId,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaComputerCallSafetyCheckParam> pendingSafetyChecks,
            global::tryAGI.OpenAI.BetaComputerToolCallStatus status,
            global::tryAGI.OpenAI.BetaAgentTag? agent,
            global::tryAGI.OpenAI.BetaComputerAction? action,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaComputerAction>? actions,
            global::tryAGI.OpenAI.BetaComputerToolCallType type = global::tryAGI.OpenAI.BetaComputerToolCallType.ComputerCall)
        {
            this.Agent = agent;
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Action = action;
            this.Actions = actions;
            this.PendingSafetyChecks = pendingSafetyChecks ?? throw new global::System.ArgumentNullException(nameof(pendingSafetyChecks));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComputerToolCall" /> class.
        /// </summary>
        public BetaComputerToolCall()
        {
        }

    }
}