
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Browser use in an OpenAI-hosted session.
    /// </summary>
    public sealed partial class AgentToolResourceComputerUse
    {
        /// <summary>
        /// The type of the object. Always `computer_use`.<br/>
        /// Default Value: computer_use
        /// </summary>
        /// <default>global::tryAGI.OpenAI.AgentToolResourceComputerUseType.ComputerUse</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AgentToolResourceComputerUseTypeJsonConverter))]
        public global::tryAGI.OpenAI.AgentToolResourceComputerUseType Type { get; set; } = global::tryAGI.OpenAI.AgentToolResourceComputerUseType.ComputerUse;

        /// <summary>
        /// Whether computer tool outputs include screenshots.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_screenshots")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IncludeScreenshots { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentToolResourceComputerUse" /> class.
        /// </summary>
        /// <param name="includeScreenshots">
        /// Whether computer tool outputs include screenshots.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `computer_use`.<br/>
        /// Default Value: computer_use
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentToolResourceComputerUse(
            bool includeScreenshots,
            global::tryAGI.OpenAI.AgentToolResourceComputerUseType type = global::tryAGI.OpenAI.AgentToolResourceComputerUseType.ComputerUse)
        {
            this.Type = type;
            this.IncludeScreenshots = includeScreenshots;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentToolResourceComputerUse" /> class.
        /// </summary>
        public AgentToolResourceComputerUse()
        {
        }

        /// <summary>
        /// Creates a new <see cref="AgentToolResourceComputerUse"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static AgentToolResourceComputerUse FromIncludeScreenshots(bool includeScreenshots)
        {
            return new AgentToolResourceComputerUse
            {
                IncludeScreenshots = includeScreenshots,
            };
        }

    }
}