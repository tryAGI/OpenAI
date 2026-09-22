
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Enables calling tools from model-generated code.
    /// </summary>
    public sealed partial class PersistedAgentToolResourceProgrammaticToolCalling
    {
        /// <summary>
        /// The type of the object. Always `programmatic_tool_calling`.<br/>
        /// Default Value: programmatic_tool_calling
        /// </summary>
        /// <default>global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCallingType.ProgrammaticToolCalling</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolResourceProgrammaticToolCallingTypeJsonConverter))]
        public global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCallingType Type { get; set; } = global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCallingType.ProgrammaticToolCalling;

        /// <summary>
        /// Whether tools can be called from model-generated code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PersistedAgentToolResourceProgrammaticToolCalling" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether tools can be called from model-generated code.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `programmatic_tool_calling`.<br/>
        /// Default Value: programmatic_tool_calling
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PersistedAgentToolResourceProgrammaticToolCalling(
            bool enabled,
            global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCallingType type = global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCallingType.ProgrammaticToolCalling)
        {
            this.Type = type;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersistedAgentToolResourceProgrammaticToolCalling" /> class.
        /// </summary>
        public PersistedAgentToolResourceProgrammaticToolCalling()
        {
        }

        /// <summary>
        /// Creates a new <see cref="PersistedAgentToolResourceProgrammaticToolCalling"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static PersistedAgentToolResourceProgrammaticToolCalling FromEnabled(bool enabled)
        {
            return new PersistedAgentToolResourceProgrammaticToolCalling
            {
                Enabled = enabled,
            };
        }

    }
}