
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An object representing a list of Chat Completions.
    /// </summary>
    public sealed partial class ChatCompletionList
    {
        /// <summary>
        /// The type of this object. It is always set to "list".<br/>
        /// Default Value: list
        /// </summary>
        /// <default>"list"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "list";

        /// <summary>
        /// An array of chat completion objects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateChatCompletionResponse> Data { get; set; }

        /// <summary>
        /// The identifier of the first chat completion in the data array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_id")]
        public string? FirstId { get; set; }

        /// <summary>
        /// The identifier of the last chat completion in the data array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_id")]
        public string? LastId { get; set; }

        /// <summary>
        /// Indicates whether there are more Chat Completions available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionList" /> class.
        /// </summary>
        /// <param name="data">
        /// An array of chat completion objects.
        /// </param>
        /// <param name="hasMore">
        /// Indicates whether there are more Chat Completions available.
        /// </param>
        /// <param name="firstId">
        /// The identifier of the first chat completion in the data array.
        /// </param>
        /// <param name="lastId">
        /// The identifier of the last chat completion in the data array.
        /// </param>
        /// <param name="object">
        /// The type of this object. It is always set to "list".<br/>
        /// Default Value: list
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionList(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateChatCompletionResponse> data,
            bool hasMore,
            string? firstId,
            string? lastId,
            string @object = "list")
        {
            this.Object = @object;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.FirstId = firstId;
            this.LastId = lastId;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionList" /> class.
        /// </summary>
        public ChatCompletionList()
        {
        }

    }
}