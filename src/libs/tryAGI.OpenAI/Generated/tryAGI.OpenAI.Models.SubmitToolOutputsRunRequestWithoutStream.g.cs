
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubmitToolOutputsRunRequestWithoutStream
    {
        /// <summary>
        /// A list of tools for which the outputs are being submitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_outputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SubmitToolOutputsRunRequestWithoutStreamToolOutput> ToolOutputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitToolOutputsRunRequestWithoutStream" /> class.
        /// </summary>
        /// <param name="toolOutputs">
        /// A list of tools for which the outputs are being submitted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitToolOutputsRunRequestWithoutStream(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SubmitToolOutputsRunRequestWithoutStreamToolOutput> toolOutputs)
        {
            this.ToolOutputs = toolOutputs ?? throw new global::System.ArgumentNullException(nameof(toolOutputs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitToolOutputsRunRequestWithoutStream" /> class.
        /// </summary>
        public SubmitToolOutputsRunRequestWithoutStream()
        {
        }
    }
}