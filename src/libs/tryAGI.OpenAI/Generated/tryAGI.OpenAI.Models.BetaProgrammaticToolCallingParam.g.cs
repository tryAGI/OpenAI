
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaProgrammaticToolCallingParam
    {
        /// <summary>
        /// The type of the tool. Always `programmatic_tool_calling`.<br/>
        /// Default Value: programmatic_tool_calling
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaProgrammaticToolCallingParamType.ProgrammaticToolCalling</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaProgrammaticToolCallingParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaProgrammaticToolCallingParamType Type { get; set; } = global::tryAGI.OpenAI.BetaProgrammaticToolCallingParamType.ProgrammaticToolCalling;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaProgrammaticToolCallingParam" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the tool. Always `programmatic_tool_calling`.<br/>
        /// Default Value: programmatic_tool_calling
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaProgrammaticToolCallingParam(
            global::tryAGI.OpenAI.BetaProgrammaticToolCallingParamType type = global::tryAGI.OpenAI.BetaProgrammaticToolCallingParamType.ProgrammaticToolCalling)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaProgrammaticToolCallingParam" /> class.
        /// </summary>
        public BetaProgrammaticToolCallingParam()
        {
        }

    }
}