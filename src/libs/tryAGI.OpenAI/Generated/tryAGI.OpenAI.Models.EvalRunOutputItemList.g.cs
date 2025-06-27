
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An object representing a list of output items for an evaluation run.
    /// </summary>
    public sealed partial class EvalRunOutputItemList
    {
        /// <summary>
        /// An array of eval run output item objects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRunOutputItem> Data { get; set; }

        /// <summary>
        /// The identifier of the first eval run output item in the data array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FirstId { get; set; }

        /// <summary>
        /// Indicates whether there are more eval run output items available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// The identifier of the last eval run output item in the data array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LastId { get; set; }

        /// <summary>
        /// The type of this object. It is always set to "list".<br/>
        /// Default Value: list
        /// </summary>
        /// <default>global::tryAGI.OpenAI.EvalRunOutputItemListObject.List</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.EvalRunOutputItemListObjectJsonConverter))]
        public global::tryAGI.OpenAI.EvalRunOutputItemListObject Object { get; set; } = global::tryAGI.OpenAI.EvalRunOutputItemListObject.List;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalRunOutputItemList" /> class.
        /// </summary>
        /// <param name="data">
        /// An array of eval run output item objects.
        /// </param>
        /// <param name="firstId">
        /// The identifier of the first eval run output item in the data array.
        /// </param>
        /// <param name="hasMore">
        /// Indicates whether there are more eval run output items available.
        /// </param>
        /// <param name="lastId">
        /// The identifier of the last eval run output item in the data array.
        /// </param>
        /// <param name="object">
        /// The type of this object. It is always set to "list".<br/>
        /// Default Value: list
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvalRunOutputItemList(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRunOutputItem> data,
            string firstId,
            bool hasMore,
            string lastId,
            global::tryAGI.OpenAI.EvalRunOutputItemListObject @object = global::tryAGI.OpenAI.EvalRunOutputItemListObject.List)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.FirstId = firstId ?? throw new global::System.ArgumentNullException(nameof(firstId));
            this.HasMore = hasMore;
            this.LastId = lastId ?? throw new global::System.ArgumentNullException(nameof(lastId));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalRunOutputItemList" /> class.
        /// </summary>
        public EvalRunOutputItemList()
        {
        }
    }
}