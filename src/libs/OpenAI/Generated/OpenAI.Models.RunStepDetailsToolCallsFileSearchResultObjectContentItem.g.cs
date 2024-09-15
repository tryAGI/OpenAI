
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunStepDetailsToolCallsFileSearchResultObjectContentItem
    {
        /// <summary>
        /// The type of the content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.RunStepDetailsToolCallsFileSearchResultObjectContentItemTypeJsonConverter))]
        public global::OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItemType? Type { get; set; }

        /// <summary>
        /// The text content of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}