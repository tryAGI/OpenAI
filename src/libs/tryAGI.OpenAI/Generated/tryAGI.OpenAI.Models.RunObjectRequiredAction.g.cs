
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Details on the action required to continue the run. Will be `null` if no action is required.
    /// </summary>
    public sealed partial class RunObjectRequiredAction
    {
        /// <summary>
        /// Details on the tool outputs needed for this run to continue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submit_tool_outputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.RunObjectRequiredActionSubmitToolOutputs SubmitToolOutputs { get; set; }

        /// <summary>
        /// For now, this is always `submit_tool_outputs`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RunObjectRequiredActionTypeJsonConverter))]
        public global::tryAGI.OpenAI.RunObjectRequiredActionType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunObjectRequiredAction" /> class.
        /// </summary>
        /// <param name="submitToolOutputs">
        /// Details on the tool outputs needed for this run to continue.
        /// </param>
        /// <param name="type">
        /// For now, this is always `submit_tool_outputs`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunObjectRequiredAction(
            global::tryAGI.OpenAI.RunObjectRequiredActionSubmitToolOutputs submitToolOutputs,
            global::tryAGI.OpenAI.RunObjectRequiredActionType type)
        {
            this.SubmitToolOutputs = submitToolOutputs ?? throw new global::System.ArgumentNullException(nameof(submitToolOutputs));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunObjectRequiredAction" /> class.
        /// </summary>
        public RunObjectRequiredAction()
        {
        }
    }
}