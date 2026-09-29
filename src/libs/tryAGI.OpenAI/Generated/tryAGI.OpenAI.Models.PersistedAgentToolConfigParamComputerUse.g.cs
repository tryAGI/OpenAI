
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Browser use in an OpenAI-hosted session.
    /// </summary>
    public sealed partial class PersistedAgentToolConfigParamComputerUse
    {
        /// <summary>
        /// The type of the object. Always `computer_use`.<br/>
        /// Default Value: computer_use
        /// </summary>
        /// <default>global::tryAGI.OpenAI.PersistedAgentToolConfigParamComputerUseType.ComputerUse</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolConfigParamComputerUseTypeJsonConverter))]
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamComputerUseType Type { get; set; } = global::tryAGI.OpenAI.PersistedAgentToolConfigParamComputerUseType.ComputerUse;

        /// <summary>
        /// Whether computer tool outputs include screenshots. Defaults to `false`.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_screenshots")]
        public bool? IncludeScreenshots { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PersistedAgentToolConfigParamComputerUse" /> class.
        /// </summary>
        /// <param name="includeScreenshots">
        /// Whether computer tool outputs include screenshots. Defaults to `false`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `computer_use`.<br/>
        /// Default Value: computer_use
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PersistedAgentToolConfigParamComputerUse(
            bool? includeScreenshots,
            global::tryAGI.OpenAI.PersistedAgentToolConfigParamComputerUseType type = global::tryAGI.OpenAI.PersistedAgentToolConfigParamComputerUseType.ComputerUse)
        {
            this.Type = type;
            this.IncludeScreenshots = includeScreenshots;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersistedAgentToolConfigParamComputerUse" /> class.
        /// </summary>
        public PersistedAgentToolConfigParamComputerUse()
        {
        }

    }
}