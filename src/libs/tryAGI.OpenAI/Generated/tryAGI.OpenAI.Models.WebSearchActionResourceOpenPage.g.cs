
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Opens a web page.
    /// </summary>
    public sealed partial class WebSearchActionResourceOpenPage
    {
        /// <summary>
        /// The type of the object. Always `open_page`.<br/>
        /// Default Value: open_page
        /// </summary>
        /// <default>global::tryAGI.OpenAI.WebSearchActionResourceOpenPageType.OpenPage</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchActionResourceOpenPageTypeJsonConverter))]
        public global::tryAGI.OpenAI.WebSearchActionResourceOpenPageType Type { get; set; } = global::tryAGI.OpenAI.WebSearchActionResourceOpenPageType.OpenPage;

        /// <summary>
        /// The URL of the page that was opened.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchActionResourceOpenPage" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL of the page that was opened.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `open_page`.<br/>
        /// Default Value: open_page
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchActionResourceOpenPage(
            string? url,
            global::tryAGI.OpenAI.WebSearchActionResourceOpenPageType type = global::tryAGI.OpenAI.WebSearchActionResourceOpenPageType.OpenPage)
        {
            this.Type = type;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchActionResourceOpenPage" /> class.
        /// </summary>
        public WebSearchActionResourceOpenPage()
        {
        }

    }
}