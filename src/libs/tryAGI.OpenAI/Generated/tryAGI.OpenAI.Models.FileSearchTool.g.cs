
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A tool that searches for relevant content from uploaded files. Learn more about the [file search tool](https://platform.openai.com/docs/guides/tools-file-search).
    /// </summary>
    public sealed partial class FileSearchTool
    {
        /// <summary>
        /// The type of the file search tool. Always `file_search`.<br/>
        /// Default Value: file_search
        /// </summary>
        /// <default>global::tryAGI.OpenAI.FileSearchToolType.FileSearch</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.FileSearchToolTypeJsonConverter))]
        public global::tryAGI.OpenAI.FileSearchToolType Type { get; set; } = global::tryAGI.OpenAI.FileSearchToolType.FileSearch;

        /// <summary>
        /// The IDs of the vector stores to search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_store_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> VectorStoreIds { get; set; }

        /// <summary>
        /// The maximum number of results to return. This number should be between 1 and 50 inclusive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_num_results")]
        public int? MaxNumResults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ranking_options")]
        public global::tryAGI.OpenAI.RankingOptions? RankingOptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<global::tryAGI.OpenAI.Filters2?, object>))]
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.Filters2?, object>? Filters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearchTool" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the file search tool. Always `file_search`.<br/>
        /// Default Value: file_search
        /// </param>
        /// <param name="vectorStoreIds">
        /// The IDs of the vector stores to search.
        /// </param>
        /// <param name="maxNumResults">
        /// The maximum number of results to return. This number should be between 1 and 50 inclusive.
        /// </param>
        /// <param name="rankingOptions"></param>
        /// <param name="filters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileSearchTool(
            global::System.Collections.Generic.IList<string> vectorStoreIds,
            int? maxNumResults,
            global::tryAGI.OpenAI.RankingOptions? rankingOptions,
            global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.Filters2?, object>? filters,
            global::tryAGI.OpenAI.FileSearchToolType type = global::tryAGI.OpenAI.FileSearchToolType.FileSearch)
        {
            this.VectorStoreIds = vectorStoreIds ?? throw new global::System.ArgumentNullException(nameof(vectorStoreIds));
            this.Type = type;
            this.MaxNumResults = maxNumResults;
            this.RankingOptions = rankingOptions;
            this.Filters = filters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearchTool" /> class.
        /// </summary>
        public FileSearchTool()
        {
        }
    }
}