
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssistantToolsCode
    {
        /// <summary>
        /// The type of tool being defined: `code_interpreter`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AssistantToolsCodeTypeJsonConverter))]
        public global::tryAGI.OpenAI.AssistantToolsCodeType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantToolsCode" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of tool being defined: `code_interpreter`
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AssistantToolsCode(
            global::tryAGI.OpenAI.AssistantToolsCodeType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantToolsCode" /> class.
        /// </summary>
        public AssistantToolsCode()
        {
        }
    }
}