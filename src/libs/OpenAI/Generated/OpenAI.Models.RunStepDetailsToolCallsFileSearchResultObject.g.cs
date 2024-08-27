
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// A result instance of the file search.
    /// </summary>
    public sealed partial class RunStepDetailsToolCallsFileSearchResultObject
    {
        /// <summary>
        /// The ID of the file that result was found in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// The name of the file that result was found in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileName { get; set; }

        /// <summary>
        /// The score of the result. All values must be a floating point number between 0 and 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// The content of the result that was found. The content is only included if requested via the include query parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::OpenAI.RunStepDetailsToolCallsFileSearchResultObjectContentItem>? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}