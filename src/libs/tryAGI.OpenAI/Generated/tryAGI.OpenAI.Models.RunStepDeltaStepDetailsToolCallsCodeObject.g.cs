
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Details of the Code Interpreter tool call the run step was involved in.
    /// </summary>
    public sealed partial class RunStepDeltaStepDetailsToolCallsCodeObject
    {
        /// <summary>
        /// The index of the tool call in the tool calls array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// The ID of the tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The type of tool call. This is always going to be `code_interpreter` for this type of tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeObjectTypeJsonConverter))]
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObjectType Type { get; set; }

        /// <summary>
        /// The Code Interpreter tool call definition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_interpreter")]
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter? CodeInterpreter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaStepDetailsToolCallsCodeObject" /> class.
        /// </summary>
        /// <param name="index">
        /// The index of the tool call in the tool calls array.
        /// </param>
        /// <param name="id">
        /// The ID of the tool call.
        /// </param>
        /// <param name="type">
        /// The type of tool call. This is always going to be `code_interpreter` for this type of tool call.
        /// </param>
        /// <param name="codeInterpreter">
        /// The Code Interpreter tool call definition.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RunStepDeltaStepDetailsToolCallsCodeObject(
            int index,
            string? id,
            global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObjectType type,
            global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter? codeInterpreter)
        {
            this.Index = index;
            this.Id = id;
            this.Type = type;
            this.CodeInterpreter = codeInterpreter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaStepDetailsToolCallsCodeObject" /> class.
        /// </summary>
        public RunStepDeltaStepDetailsToolCallsCodeObject()
        {
        }
    }
}