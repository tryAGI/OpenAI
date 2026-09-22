
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Finds text within a web page.
    /// </summary>
    public sealed partial class WebSearchActionResourceFindInPage
    {
        /// <summary>
        /// The type of the object. Always `find_in_page`.<br/>
        /// Default Value: find_in_page
        /// </summary>
        /// <default>global::tryAGI.OpenAI.WebSearchActionResourceFindInPageType.FindInPage</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchActionResourceFindInPageTypeJsonConverter))]
        public global::tryAGI.OpenAI.WebSearchActionResourceFindInPageType Type { get; set; } = global::tryAGI.OpenAI.WebSearchActionResourceFindInPageType.FindInPage;

        /// <summary>
        /// The URL of the page that was searched.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The text pattern that was searched for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern")]
        public string? Pattern { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchActionResourceFindInPage" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL of the page that was searched.
        /// </param>
        /// <param name="pattern">
        /// The text pattern that was searched for.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `find_in_page`.<br/>
        /// Default Value: find_in_page
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchActionResourceFindInPage(
            string? url,
            string? pattern,
            global::tryAGI.OpenAI.WebSearchActionResourceFindInPageType type = global::tryAGI.OpenAI.WebSearchActionResourceFindInPageType.FindInPage)
        {
            this.Type = type;
            this.Url = url;
            this.Pattern = pattern;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchActionResourceFindInPage" /> class.
        /// </summary>
        public WebSearchActionResourceFindInPage()
        {
        }

    }
}