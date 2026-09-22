
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Enables calling tools from model-generated code.
    /// </summary>
    public sealed partial class AgentToolResourceProgrammaticToolCalling
    {
        /// <summary>
        /// The type of the object. Always `programmatic_tool_calling`.<br/>
        /// Default Value: programmatic_tool_calling
        /// </summary>
        /// <default>global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCallingType.ProgrammaticToolCalling</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AgentToolResourceProgrammaticToolCallingTypeJsonConverter))]
        public global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCallingType Type { get; set; } = global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCallingType.ProgrammaticToolCalling;

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
        /// Initializes a new instance of the <see cref="AgentToolResourceProgrammaticToolCalling" /> class.
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
        public AgentToolResourceProgrammaticToolCalling(
            bool enabled,
            global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCallingType type = global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCallingType.ProgrammaticToolCalling)
        {
            this.Type = type;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentToolResourceProgrammaticToolCalling" /> class.
        /// </summary>
        public AgentToolResourceProgrammaticToolCalling()
        {
        }

        /// <summary>
        /// Creates a new <see cref="AgentToolResourceProgrammaticToolCalling"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static AgentToolResourceProgrammaticToolCalling FromEnabled(bool enabled)
        {
            return new AgentToolResourceProgrammaticToolCalling
            {
                Enabled = enabled,
            };
        }

    }
}