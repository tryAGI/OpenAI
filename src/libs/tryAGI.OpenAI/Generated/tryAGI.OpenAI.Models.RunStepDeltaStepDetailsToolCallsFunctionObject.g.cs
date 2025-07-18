
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunStepDeltaStepDetailsToolCallsFunctionObject
    {
        /// <summary>
        /// The definition of the function that was called.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObjectFunction? Function { get; set; }

        /// <summary>
        /// The ID of the tool call object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The index of the tool call in the tool calls array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// The type of tool call. This is always going to be `function` for this type of tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RunStepDeltaStepDetailsToolCallsFunctionObjectTypeJsonConverter))]
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObjectType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaStepDetailsToolCallsFunctionObject" /> class.
        /// </summary>
        /// <param name="function">
        /// The definition of the function that was called.
        /// </param>
        /// <param name="id">
        /// The ID of the tool call object.
        /// </param>
        /// <param name="index">
        /// The index of the tool call in the tool calls array.
        /// </param>
        /// <param name="type">
        /// The type of tool call. This is always going to be `function` for this type of tool call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStepDeltaStepDetailsToolCallsFunctionObject(
            int index,
            global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObjectFunction? function,
            string? id,
            global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObjectType type)
        {
            this.Index = index;
            this.Function = function;
            this.Id = id;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaStepDetailsToolCallsFunctionObject" /> class.
        /// </summary>
        public RunStepDeltaStepDetailsToolCallsFunctionObject()
        {
        }
    }
}