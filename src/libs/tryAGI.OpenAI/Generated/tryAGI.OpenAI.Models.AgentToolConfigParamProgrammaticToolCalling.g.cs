
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Enables calling tools from model-generated code.
    /// </summary>
    public sealed partial class AgentToolConfigParamProgrammaticToolCalling
    {
        /// <summary>
        /// The type of the object. Always `programmatic_tool_calling`.<br/>
        /// Default Value: programmatic_tool_calling
        /// </summary>
        /// <default>global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCallingType.ProgrammaticToolCalling</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AgentToolConfigParamProgrammaticToolCallingTypeJsonConverter))]
        public global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCallingType Type { get; set; } = global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCallingType.ProgrammaticToolCalling;

        /// <summary>
        /// Whether tools can be called from model-generated code. Defaults to `true`.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentToolConfigParamProgrammaticToolCalling" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether tools can be called from model-generated code. Defaults to `true`.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `programmatic_tool_calling`.<br/>
        /// Default Value: programmatic_tool_calling
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentToolConfigParamProgrammaticToolCalling(
            bool? enabled,
            global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCallingType type = global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCallingType.ProgrammaticToolCalling)
        {
            this.Type = type;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentToolConfigParamProgrammaticToolCalling" /> class.
        /// </summary>
        public AgentToolConfigParamProgrammaticToolCalling()
        {
        }

    }
}