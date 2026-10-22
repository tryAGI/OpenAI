
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveDecisionsDelegationParam
    {
        /// <summary>
        /// Milliseconds to wait before requesting an automatic spoken acknowledgement for a delegation. The model may still speak before this delay. Any commentary or thinking appended to the session cancels all pending acknowledgements, including those for other delegations. Defaults to 400. Updates apply to subsequent delegations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acknowledgement_delay_ms")]
        public int? AcknowledgementDelayMs { get; set; }

        /// <summary>
        /// Default Value: decisions
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveDecisionsDelegationParamType.Decisions</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveDecisionsDelegationParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveDecisionsDelegationParamType Type { get; set; } = global::tryAGI.OpenAI.LiveDecisionsDelegationParamType.Decisions;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decisions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.LiveDecisionsSettingsInputParam Decisions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionsDelegationParam" /> class.
        /// </summary>
        /// <param name="decisions"></param>
        /// <param name="acknowledgementDelayMs">
        /// Milliseconds to wait before requesting an automatic spoken acknowledgement for a delegation. The model may still speak before this delay. Any commentary or thinking appended to the session cancels all pending acknowledgements, including those for other delegations. Defaults to 400. Updates apply to subsequent delegations.
        /// </param>
        /// <param name="type">
        /// Default Value: decisions
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveDecisionsDelegationParam(
            global::tryAGI.OpenAI.LiveDecisionsSettingsInputParam decisions,
            int? acknowledgementDelayMs,
            global::tryAGI.OpenAI.LiveDecisionsDelegationParamType type = global::tryAGI.OpenAI.LiveDecisionsDelegationParamType.Decisions)
        {
            this.AcknowledgementDelayMs = acknowledgementDelayMs;
            this.Type = type;
            this.Decisions = decisions ?? throw new global::System.ArgumentNullException(nameof(decisions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionsDelegationParam" /> class.
        /// </summary>
        public LiveDecisionsDelegationParam()
        {
        }

        /// <summary>
        /// Creates a new <see cref="LiveDecisionsDelegationParam"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static LiveDecisionsDelegationParam FromDecisions(global::tryAGI.OpenAI.LiveDecisionsSettingsInputParam decisions)
        {
            return new LiveDecisionsDelegationParam
            {
                Decisions = decisions,
            };
        }

    }
}