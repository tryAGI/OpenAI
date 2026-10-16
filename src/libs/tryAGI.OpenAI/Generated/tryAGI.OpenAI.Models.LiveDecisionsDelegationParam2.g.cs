
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveDecisionsDelegationParam2
    {
        /// <summary>
        /// Default Value: decisions
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveDecisionsDelegationParam2Type.Decisions</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveDecisionsDelegationParam2TypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveDecisionsDelegationParam2Type Type { get; set; } = global::tryAGI.OpenAI.LiveDecisionsDelegationParam2Type.Decisions;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decisions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.LiveDecisionsSettingsInputParam2 Decisions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionsDelegationParam2" /> class.
        /// </summary>
        /// <param name="decisions"></param>
        /// <param name="type">
        /// Default Value: decisions
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveDecisionsDelegationParam2(
            global::tryAGI.OpenAI.LiveDecisionsSettingsInputParam2 decisions,
            global::tryAGI.OpenAI.LiveDecisionsDelegationParam2Type type = global::tryAGI.OpenAI.LiveDecisionsDelegationParam2Type.Decisions)
        {
            this.Type = type;
            this.Decisions = decisions ?? throw new global::System.ArgumentNullException(nameof(decisions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionsDelegationParam2" /> class.
        /// </summary>
        public LiveDecisionsDelegationParam2()
        {
        }

        /// <summary>
        /// Creates a new <see cref="LiveDecisionsDelegationParam2"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static LiveDecisionsDelegationParam2 FromDecisions(global::tryAGI.OpenAI.LiveDecisionsSettingsInputParam2 decisions)
        {
            return new LiveDecisionsDelegationParam2
            {
                Decisions = decisions,
            };
        }

    }
}