
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Lets the agent manage its own scheduled wakeups.
    /// </summary>
    public sealed partial class PersistedAgentToolConfigParamAutomations
    {
        /// <summary>
        /// The type of the object. Always `automations`.<br/>
        /// Default Value: automations
        /// </summary>
        /// <default>global::tryAGI.OpenAI.PersistedAgentToolConfigParamAutomationsType.Automations</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolConfigParamAutomationsTypeJsonConverter))]
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamAutomationsType Type { get; set; } = global::tryAGI.OpenAI.PersistedAgentToolConfigParamAutomationsType.Automations;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PersistedAgentToolConfigParamAutomations" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the object. Always `automations`.<br/>
        /// Default Value: automations
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PersistedAgentToolConfigParamAutomations(
            global::tryAGI.OpenAI.PersistedAgentToolConfigParamAutomationsType type = global::tryAGI.OpenAI.PersistedAgentToolConfigParamAutomationsType.Automations)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersistedAgentToolConfigParamAutomations" /> class.
        /// </summary>
        public PersistedAgentToolConfigParamAutomations()
        {
        }

    }
}