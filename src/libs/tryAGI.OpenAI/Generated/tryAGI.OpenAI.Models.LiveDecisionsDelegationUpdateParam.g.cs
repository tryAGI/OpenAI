
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveDecisionsDelegationUpdateParam
    {
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
        /// <param name="decisions"></param>
        /// <param name="type">
        /// Default Value: decisions
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveDecisionsDelegationUpdateParam(
            global::tryAGI.OpenAI.LiveDecisionsSettingsUpdateParam? decisions,
            global::tryAGI.OpenAI.LiveDecisionsDelegationUpdateParamType type = global::tryAGI.OpenAI.LiveDecisionsDelegationUpdateParamType.Decisions)
        {
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