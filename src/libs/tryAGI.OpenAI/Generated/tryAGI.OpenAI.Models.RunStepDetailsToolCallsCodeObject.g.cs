
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Details of the Code Interpreter tool call the run step was involved in.
    /// </summary>
    public sealed partial class RunStepDetailsToolCallsCodeObject
    {
        /// <summary>
        /// The ID of the tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The type of tool call. This is always going to be `code_interpreter` for this type of tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RunStepDetailsToolCallsCodeObjectTypeJsonConverter))]
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObjectType Type { get; set; }

        /// <summary>
        /// The Code Interpreter tool call definition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_interpreter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObjectCodeInterpreter CodeInterpreter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsCodeObject" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the tool call.
        /// </param>
        /// <param name="type">
        /// The type of tool call. This is always going to be `code_interpreter` for this type of tool call.
        /// </param>
        /// <param name="codeInterpreter">
        /// The Code Interpreter tool call definition.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStepDetailsToolCallsCodeObject(
            string id,
            global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObjectCodeInterpreter codeInterpreter,
            global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObjectType type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CodeInterpreter = codeInterpreter ?? throw new global::System.ArgumentNullException(nameof(codeInterpreter));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsCodeObject" /> class.
        /// </summary>
        public RunStepDetailsToolCallsCodeObject()
        {
        }
    }
}