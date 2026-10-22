
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveDecisionsDelegationUpdateParam
    {
        /// <summary>
        /// Milliseconds to wait before requesting an automatic spoken acknowledgement for a delegation. The model may still speak before this delay. Any commentary or thinking appended to the session cancels all pending acknowledgements, including those for other delegations. Defaults to 400 for Decisions sessions and 0 (request immediately) for other sessions. Omission in a session update preserves the current value. Updates apply to subsequent delegations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acknowledgement_delay_ms")]
        public int? AcknowledgementDelayMs { get; set; }

        /// <summary>
        /// Default Value: decisions
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveDecisionsDelegationUpdateParamType.Decisions</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveDecisionsDelegationUpdateParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveDecisionsDelegationUpdateParamType Type { get; set; } = global::tryAGI.OpenAI.LiveDecisionsDelegationUpdateParamType.Decisions;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decisions")]
        public global::tryAGI.OpenAI.LiveDecisionsSettingsUpdateParam? Decisions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionsDelegationUpdateParam" /> class.
        /// </summary>
        /// <param name="acknowledgementDelayMs">
        /// Milliseconds to wait before requesting an automatic spoken acknowledgement for a delegation. The model may still speak before this delay. Any commentary or thinking appended to the session cancels all pending acknowledgements, including those for other delegations. Defaults to 400 for Decisions sessions and 0 (request immediately) for other sessions. Omission in a session update preserves the current value. Updates apply to subsequent delegations.
        /// </param>
        /// <param name="decisions"></param>
        /// <param name="type">
        /// Default Value: decisions
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveDecisionsDelegationUpdateParam(
            int? acknowledgementDelayMs,
            global::tryAGI.OpenAI.LiveDecisionsSettingsUpdateParam? decisions,
            global::tryAGI.OpenAI.LiveDecisionsDelegationUpdateParamType type = global::tryAGI.OpenAI.LiveDecisionsDelegationUpdateParamType.Decisions)
        {
            this.AcknowledgementDelayMs = acknowledgementDelayMs;
            this.Type = type;
            this.Decisions = decisions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionsDelegationUpdateParam" /> class.
        /// </summary>
        public LiveDecisionsDelegationUpdateParam()
        {
        }

    }
}