
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Tool call objects
    /// </summary>
    public sealed partial class RunToolCallObject
    {
        /// <summary>
        /// The function definition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.RunToolCallObjectFunction Function { get; set; }

        /// <summary>
        /// The ID of the tool call. This ID must be referenced when you submit the tool outputs in using the [Submit tool outputs to run](/docs/api-reference/runs/submitToolOutputs) endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The type of tool call the output is required for. For now, this is always `function`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RunToolCallObjectTypeJsonConverter))]
        public global::tryAGI.OpenAI.RunToolCallObjectType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunToolCallObject" /> class.
        /// </summary>
        /// <param name="function">
        /// The function definition.
        /// </param>
        /// <param name="id">
        /// The ID of the tool call. This ID must be referenced when you submit the tool outputs in using the [Submit tool outputs to run](/docs/api-reference/runs/submitToolOutputs) endpoint.
        /// </param>
        /// <param name="type">
        /// The type of tool call the output is required for. For now, this is always `function`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunToolCallObject(
            global::tryAGI.OpenAI.RunToolCallObjectFunction function,
            string id,
            global::tryAGI.OpenAI.RunToolCallObjectType type)
        {
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunToolCallObject" /> class.
        /// </summary>
        public RunToolCallObject()
        {
        }
    }
}