
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionMessageToolCallChunk
    {
        /// <summary>
        /// 
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
        /// The type of the tool. Currently, only `function` is supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionMessageToolCallChunkTypeJsonConverter))]
        public global::tryAGI.OpenAI.ChatCompletionMessageToolCallChunkType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        public global::tryAGI.OpenAI.ChatCompletionMessageToolCallChunkFunction? Function { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageToolCallChunk" /> class.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="id">
        /// The ID of the tool call.
        /// </param>
        /// <param name="type">
        /// The type of the tool. Currently, only `function` is supported.
        /// </param>
        /// <param name="function"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChatCompletionMessageToolCallChunk(
            int index,
            string? id,
            global::tryAGI.OpenAI.ChatCompletionMessageToolCallChunkType? type,
            global::tryAGI.OpenAI.ChatCompletionMessageToolCallChunkFunction? function)
        {
            this.Index = index;
            this.Id = id;
            this.Type = type;
            this.Function = function;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageToolCallChunk" /> class.
        /// </summary>
        public ChatCompletionMessageToolCallChunk()
        {
        }
    }
}