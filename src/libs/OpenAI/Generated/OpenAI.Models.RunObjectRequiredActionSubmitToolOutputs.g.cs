
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// Details on the tool outputs needed for this run to continue.
    /// </summary>
    public sealed partial class RunObjectRequiredActionSubmitToolOutputs
    {
        /// <summary>
        /// A list of the relevant tool calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenAI.RunToolCallObject> ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunObjectRequiredActionSubmitToolOutputs" /> class.
        /// </summary>
        /// <param name="toolCalls">
        /// A list of the relevant tool calls.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RunObjectRequiredActionSubmitToolOutputs(
            global::System.Collections.Generic.IList<global::OpenAI.RunToolCallObject> toolCalls)
        {
            this.ToolCalls = toolCalls ?? throw new global::System.ArgumentNullException(nameof(toolCalls));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunObjectRequiredActionSubmitToolOutputs" /> class.
        /// </summary>
        public RunObjectRequiredActionSubmitToolOutputs()
        {
        }
    }
}