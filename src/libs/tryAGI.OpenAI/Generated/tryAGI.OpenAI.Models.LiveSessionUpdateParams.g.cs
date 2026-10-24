
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Changes to an active Live session's delegation settings and transcript triggers.
    /// </summary>
    public sealed partial class LiveSessionUpdateParams
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delegation")]
        public global::tryAGI.OpenAI.DelegationVariant13? Delegation { get; set; }

        /// <summary>
        /// At most one Decisions trigger per transcript event type. Triggers run independently of delegation. On update, omit triggers to keep the current configuration, send a list to replace it, or send an empty list to disable triggers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggers")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveDecisionTriggerInputParam>? Triggers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSessionUpdateParams" /> class.
        /// </summary>
        /// <param name="delegation"></param>
        /// <param name="triggers">
        /// At most one Decisions trigger per transcript event type. Triggers run independently of delegation. On update, omit triggers to keep the current configuration, send a list to replace it, or send an empty list to disable triggers.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveSessionUpdateParams(
            global::tryAGI.OpenAI.DelegationVariant13? delegation,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveDecisionTriggerInputParam>? triggers)
        {
            this.Delegation = delegation;
            this.Triggers = triggers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSessionUpdateParams" /> class.
        /// </summary>
        public LiveSessionUpdateParams()
        {
        }

    }
}