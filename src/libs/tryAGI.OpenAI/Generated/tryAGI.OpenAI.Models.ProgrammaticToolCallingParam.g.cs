
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProgrammaticToolCallingParam
    {
        /// <summary>
        /// The type of the tool. Always `programmatic_tool_calling`.<br/>
        /// Default Value: programmatic_tool_calling
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ProgrammaticToolCallingParamType.ProgrammaticToolCalling</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ProgrammaticToolCallingParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.ProgrammaticToolCallingParamType Type { get; set; } = global::tryAGI.OpenAI.ProgrammaticToolCallingParamType.ProgrammaticToolCalling;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProgrammaticToolCallingParam" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the tool. Always `programmatic_tool_calling`.<br/>
        /// Default Value: programmatic_tool_calling
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProgrammaticToolCallingParam(
            global::tryAGI.OpenAI.ProgrammaticToolCallingParamType type = global::tryAGI.OpenAI.ProgrammaticToolCallingParamType.ProgrammaticToolCalling)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProgrammaticToolCallingParam" /> class.
        /// </summary>
        public ProgrammaticToolCallingParam()
        {
        }

    }
}