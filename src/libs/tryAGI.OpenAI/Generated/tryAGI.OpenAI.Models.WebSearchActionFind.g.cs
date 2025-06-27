
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Action type "find": Searches for a pattern within a loaded page.
    /// </summary>
    public sealed partial class WebSearchActionFind
    {
        /// <summary>
        /// The pattern or text to search for within the page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Pattern { get; set; }

        /// <summary>
        /// The action type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchActionFindTypeJsonConverter))]
        public global::tryAGI.OpenAI.WebSearchActionFindType Type { get; set; }

        /// <summary>
        /// The URL of the page searched for the pattern.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchActionFind" /> class.
        /// </summary>
        /// <param name="pattern">
        /// The pattern or text to search for within the page.
        /// </param>
        /// <param name="type">
        /// The action type.
        /// </param>
        /// <param name="url">
        /// The URL of the page searched for the pattern.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchActionFind(
            string pattern,
            string url,
            global::tryAGI.OpenAI.WebSearchActionFindType type)
        {
            this.Pattern = pattern ?? throw new global::System.ArgumentNullException(nameof(pattern));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchActionFind" /> class.
        /// </summary>
        public WebSearchActionFind()
        {
        }
    }
}