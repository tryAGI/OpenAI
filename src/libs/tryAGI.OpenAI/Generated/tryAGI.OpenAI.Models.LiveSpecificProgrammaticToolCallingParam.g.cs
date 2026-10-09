
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveSpecificProgrammaticToolCallingParam
    {
        /// <summary>
        /// The tool to call. Always `programmatic_tool_calling`.<br/>
        /// Default Value: programmatic_tool_calling
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveSpecificProgrammaticToolCallingParamType.ProgrammaticToolCalling</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveSpecificProgrammaticToolCallingParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveSpecificProgrammaticToolCallingParamType Type { get; set; } = global::tryAGI.OpenAI.LiveSpecificProgrammaticToolCallingParamType.ProgrammaticToolCalling;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSpecificProgrammaticToolCallingParam" /> class.
        /// </summary>
        /// <param name="type">
        /// The tool to call. Always `programmatic_tool_calling`.<br/>
        /// Default Value: programmatic_tool_calling
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveSpecificProgrammaticToolCallingParam(
            global::tryAGI.OpenAI.LiveSpecificProgrammaticToolCallingParamType type = global::tryAGI.OpenAI.LiveSpecificProgrammaticToolCallingParamType.ProgrammaticToolCalling)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSpecificProgrammaticToolCallingParam" /> class.
        /// </summary>
        public LiveSpecificProgrammaticToolCallingParam()
        {
        }

    }
}