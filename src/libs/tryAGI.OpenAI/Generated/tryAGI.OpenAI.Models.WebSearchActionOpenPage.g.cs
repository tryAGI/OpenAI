
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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchActionOpenPageTypeJsonConverter))]
        public global::tryAGI.OpenAI.WebSearchActionOpenPageType Type { get; set; }

        /// <summary>
        /// The URL opened by the model.
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
        /// Initializes a new instance of the <see cref="WebSearchActionOpenPage" /> class.
        /// </summary>
        /// <param name="type">
        /// The action type.
        /// </param>
        /// <param name="url">
        /// The URL opened by the model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchActionOpenPage(
            string url,
            global::tryAGI.OpenAI.WebSearchActionOpenPageType type)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchActionOpenPage" /> class.
        /// </summary>
        public WebSearchActionOpenPage()
        {
        }
    }
}