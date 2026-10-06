
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveProgrammaticToolInputParam
    {
        /// <summary>
        /// Default Value: programmatic_tool_calling
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveProgrammaticToolInputParamType.ProgrammaticToolCalling</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveProgrammaticToolInputParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveProgrammaticToolInputParamType Type { get; set; } = global::tryAGI.OpenAI.LiveProgrammaticToolInputParamType.ProgrammaticToolCalling;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveProgrammaticToolInputParam" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: programmatic_tool_calling
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveProgrammaticToolInputParam(
            global::tryAGI.OpenAI.LiveProgrammaticToolInputParamType type = global::tryAGI.OpenAI.LiveProgrammaticToolInputParamType.ProgrammaticToolCalling)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveProgrammaticToolInputParam" /> class.
        /// </summary>
        public LiveProgrammaticToolInputParam()
        {
        }

    }
}