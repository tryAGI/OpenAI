
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// Tool call objects
    /// </summary>
    public sealed partial class RunToolCallObject
    {
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.RunToolCallObjectTypeJsonConverter))]
        public global::OpenAI.RunToolCallObjectType Type { get; set; }

        /// <summary>
        /// The function definition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenAI.RunToolCallObjectFunction Function { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunToolCallObject" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the tool call. This ID must be referenced when you submit the tool outputs in using the [Submit tool outputs to run](/docs/api-reference/runs/submitToolOutputs) endpoint.
        /// </param>
        /// <param name="type">
        /// The type of tool call the output is required for. For now, this is always `function`.
        /// </param>
        /// <param name="function">
        /// The function definition.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RunToolCallObject(
            string id,
            global::OpenAI.RunToolCallObjectFunction function,
            global::OpenAI.RunToolCallObjectType type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
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