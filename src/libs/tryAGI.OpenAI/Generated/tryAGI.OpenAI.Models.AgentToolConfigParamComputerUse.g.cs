
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Browser use in an OpenAI-hosted session.
    /// </summary>
    public sealed partial class AgentToolConfigParamComputerUse
    {
        /// <summary>
        /// The type of the object. Always `computer_use`.<br/>
        /// Default Value: computer_use
        /// </summary>
        /// <default>global::tryAGI.OpenAI.AgentToolConfigParamComputerUseType.ComputerUse</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AgentToolConfigParamComputerUseTypeJsonConverter))]
        public global::tryAGI.OpenAI.AgentToolConfigParamComputerUseType Type { get; set; } = global::tryAGI.OpenAI.AgentToolConfigParamComputerUseType.ComputerUse;

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
        /// Initializes a new instance of the <see cref="AgentToolConfigParamComputerUse" /> class.
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
        public AgentToolConfigParamComputerUse(
            bool? includeScreenshots,
            global::tryAGI.OpenAI.AgentToolConfigParamComputerUseType type = global::tryAGI.OpenAI.AgentToolConfigParamComputerUseType.ComputerUse)
        {
            this.Type = type;
            this.IncludeScreenshots = includeScreenshots;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentToolConfigParamComputerUse" /> class.
        /// </summary>
        public AgentToolConfigParamComputerUse()
        {
        }

    }
}