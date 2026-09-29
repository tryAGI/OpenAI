
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Browser use in an OpenAI-hosted session.
    /// </summary>
    public sealed partial class PersistedAgentToolResourceComputerUse
    {
        /// <summary>
        /// The type of the object. Always `computer_use`.<br/>
        /// Default Value: computer_use
        /// </summary>
        /// <default>global::tryAGI.OpenAI.PersistedAgentToolResourceComputerUseType.ComputerUse</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolResourceComputerUseTypeJsonConverter))]
        public global::tryAGI.OpenAI.PersistedAgentToolResourceComputerUseType Type { get; set; } = global::tryAGI.OpenAI.PersistedAgentToolResourceComputerUseType.ComputerUse;

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
        /// Initializes a new instance of the <see cref="PersistedAgentToolResourceComputerUse" /> class.
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
        public PersistedAgentToolResourceComputerUse(
            bool includeScreenshots,
            global::tryAGI.OpenAI.PersistedAgentToolResourceComputerUseType type = global::tryAGI.OpenAI.PersistedAgentToolResourceComputerUseType.ComputerUse)
        {
            this.Type = type;
            this.IncludeScreenshots = includeScreenshots;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersistedAgentToolResourceComputerUse" /> class.
        /// </summary>
        public PersistedAgentToolResourceComputerUse()
        {
        }

        /// <summary>
        /// Creates a new <see cref="PersistedAgentToolResourceComputerUse"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static PersistedAgentToolResourceComputerUse FromIncludeScreenshots(bool includeScreenshots)
        {
            return new PersistedAgentToolResourceComputerUse
            {
                IncludeScreenshots = includeScreenshots,
            };
        }

    }
}