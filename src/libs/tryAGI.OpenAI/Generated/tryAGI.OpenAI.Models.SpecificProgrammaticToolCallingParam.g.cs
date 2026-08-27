
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SpecificProgrammaticToolCallingParam
    {
        /// <summary>
        /// The tool to call. Always `programmatic_tool_calling`.<br/>
        /// Default Value: programmatic_tool_calling
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SpecificProgrammaticToolCallingParamType.ProgrammaticToolCalling</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SpecificProgrammaticToolCallingParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.SpecificProgrammaticToolCallingParamType Type { get; set; } = global::tryAGI.OpenAI.SpecificProgrammaticToolCallingParamType.ProgrammaticToolCalling;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpecificProgrammaticToolCallingParam" /> class.
        /// </summary>
        /// <param name="type">
        /// The tool to call. Always `programmatic_tool_calling`.<br/>
        /// Default Value: programmatic_tool_calling
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpecificProgrammaticToolCallingParam(
            global::tryAGI.OpenAI.SpecificProgrammaticToolCallingParamType type = global::tryAGI.OpenAI.SpecificProgrammaticToolCallingParamType.ProgrammaticToolCalling)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpecificProgrammaticToolCallingParam" /> class.
        /// </summary>
        public SpecificProgrammaticToolCallingParam()
        {
        }

    }
}