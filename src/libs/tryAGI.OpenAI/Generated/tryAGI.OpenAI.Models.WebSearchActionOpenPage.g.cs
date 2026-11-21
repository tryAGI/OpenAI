
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Action type "open_page" - Opens a specific URL from search results.
    /// </summary>
    public sealed partial class WebSearchActionOpenPage
    {
        /// <summary>
        /// The action type.
        /// </summary>
        /// <default>"open_page"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "open_page";

        /// <summary>
        /// The URL opened by the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchActionOpenPage" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL opened by the model.
        /// </param>
        /// <param name="type">
        /// The action type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchActionOpenPage(
            string? url,
            string type = "open_page")
        {
            this.Type = type;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchActionOpenPage" /> class.
        /// </summary>
        public WebSearchActionOpenPage()
        {
        }

    }
}