
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListFineTuningJobCheckpointsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FineTuningJobCheckpoint> Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_id")]
        public string? FirstId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_id")]
        public string? LastId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ListFineTuningJobCheckpointsResponseObjectJsonConverter))]
        public global::tryAGI.OpenAI.ListFineTuningJobCheckpointsResponseObject Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListFineTuningJobCheckpointsResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="firstId"></param>
        /// <param name="hasMore"></param>
        /// <param name="lastId"></param>
        /// <param name="object"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListFineTuningJobCheckpointsResponse(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FineTuningJobCheckpoint> data,
            bool hasMore,
            string? firstId,
            string? lastId,
            global::tryAGI.OpenAI.ListFineTuningJobCheckpointsResponseObject @object)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.HasMore = hasMore;
            this.FirstId = firstId;
            this.LastId = lastId;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListFineTuningJobCheckpointsResponse" /> class.
        /// </summary>
        public ListFineTuningJobCheckpointsResponse()
        {
        }
    }
}