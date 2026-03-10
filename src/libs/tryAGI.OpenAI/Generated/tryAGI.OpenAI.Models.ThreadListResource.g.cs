
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A paginated list of ChatKit threads.
    /// </summary>
    public sealed partial class ThreadListResource
    {
        /// <summary>
        /// The type of object returned, must be `list`.<br/>
        /// Default Value: list
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ThreadListResourceObject.List</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ThreadListResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.ThreadListResourceObject Object { get; set; } = global::tryAGI.OpenAI.ThreadListResourceObject.List;

        /// <summary>
        /// A list of items
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ThreadResource> Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_id")]
        public string? FirstId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_id")]
        public string? LastId { get; set; }

        /// <summary>
        /// Whether there are more items available.
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
        /// Initializes a new instance of the <see cref="ThreadListResource" /> class.
        /// </summary>
        /// <param name="object">
        /// The type of object returned, must be `list`.<br/>
        /// Default Value: list
        /// </param>
        /// <param name="data">
        /// A list of items
        /// </param>
        /// <param name="firstId"></param>
        /// <param name="lastId"></param>
        /// <param name="hasMore">
        /// Whether there are more items available.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThreadListResource(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ThreadResource> data,
            bool hasMore,
            string? firstId,
            string? lastId,
            global::tryAGI.OpenAI.ThreadListResourceObject @object = global::tryAGI.OpenAI.ThreadListResourceObject.List)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.HasMore = hasMore;
            this.Object = @object;
            this.FirstId = firstId;
            this.LastId = lastId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadListResource" /> class.
        /// </summary>
        public ThreadListResource()
        {
        }
    }
}