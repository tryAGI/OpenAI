
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Delegate tasks to your application. The Live session emits delegation events that your backend handles.
    /// </summary>
    public sealed partial class LiveClientDelegationParam
    {
        /// <summary>
        /// Milliseconds to wait before requesting an automatic spoken acknowledgement for a delegation. The model may still speak before this delay. Any commentary or thinking appended to the session cancels all pending acknowledgements, including those for other delegations. Defaults to 400 for Decisions sessions and 0 (request immediately) for other sessions. Omission in a session update preserves the current value. Updates apply to subsequent delegations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acknowledgement_delay_ms")]
        public int? AcknowledgementDelayMs { get; set; }

        /// <summary>
        /// The delegation owner. Always `client` for tasks handled by your application.<br/>
        /// Default Value: client
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveClientDelegationParamType.Client</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveClientDelegationParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveClientDelegationParamType Type { get; set; } = global::tryAGI.OpenAI.LiveClientDelegationParamType.Client;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveClientDelegationParam" /> class.
        /// </summary>
        /// <param name="acknowledgementDelayMs">
        /// Milliseconds to wait before requesting an automatic spoken acknowledgement for a delegation. The model may still speak before this delay. Any commentary or thinking appended to the session cancels all pending acknowledgements, including those for other delegations. Defaults to 400 for Decisions sessions and 0 (request immediately) for other sessions. Omission in a session update preserves the current value. Updates apply to subsequent delegations.
        /// </param>
        /// <param name="type">
        /// The delegation owner. Always `client` for tasks handled by your application.<br/>
        /// Default Value: client
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveClientDelegationParam(
            int? acknowledgementDelayMs,
            global::tryAGI.OpenAI.LiveClientDelegationParamType type = global::tryAGI.OpenAI.LiveClientDelegationParamType.Client)
        {
            this.AcknowledgementDelayMs = acknowledgementDelayMs;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveClientDelegationParam" /> class.
        /// </summary>
        public LiveClientDelegationParam()
        {
        }

    }
}