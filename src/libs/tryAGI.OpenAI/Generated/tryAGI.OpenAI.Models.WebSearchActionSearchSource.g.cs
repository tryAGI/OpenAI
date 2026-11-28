
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A source used in the search.
    /// </summary>
    public sealed partial class WebSearchActionSearchSource
    {
        /// <summary>
        /// The type of source. Always `url`.
        /// </summary>
        /// <default>"url"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "url";

        /// <summary>
        /// The URL of the source.
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
        /// Initializes a new instance of the <see cref="WebSearchActionSearchSource" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL of the source.
        /// </param>
        /// <param name="type">
        /// The type of source. Always `url`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchActionSearchSource(
            string url,
            string type = "url")
        {
            this.Type = type;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchActionSearchSource" /> class.
        /// </summary>
        public WebSearchActionSearchSource()
        {
        }

        /// <summary>
        /// Creates a new <see cref="WebSearchActionSearchSource"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static WebSearchActionSearchSource FromUrl(string url)
        {
            return new WebSearchActionSearchSource
            {
                Url = url,
            };
        }

    }
}