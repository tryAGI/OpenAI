
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Action type "find_in_page": Searches for a pattern within a loaded page.
    /// </summary>
    public sealed partial class WebSearchActionFind
    {
        /// <summary>
        /// The action type.
        /// </summary>
        /// <default>"find_in_page"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "find_in_page";

        /// <summary>
        /// The URL of the page searched for the pattern, when available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The pattern or text to search for within the page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Pattern { get; set; }

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
        /// <param name="url">
        /// The URL of the page searched for the pattern, when available.
        /// </param>
        /// <param name="type">
        /// The action type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchActionFind(
            string pattern,
            string? url,
            string type = "find_in_page")
        {
            this.Type = type;
            this.Url = url;
            this.Pattern = pattern ?? throw new global::System.ArgumentNullException(nameof(pattern));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchActionFind" /> class.
        /// </summary>
        public WebSearchActionFind()
        {
        }

        /// <summary>
        /// Creates a new <see cref="WebSearchActionFind"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static WebSearchActionFind FromPattern(string pattern)
        {
            return new WebSearchActionFind
            {
                Pattern = pattern,
            };
        }

    }
}