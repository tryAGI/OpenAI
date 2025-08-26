
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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchActionSearchSourceTypeJsonConverter))]
        public global::tryAGI.OpenAI.WebSearchActionSearchSourceType Type { get; set; }

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
        /// <param name="type">
        /// The type of source. Always `url`.
        /// </param>
        /// <param name="url">
        /// The URL of the source.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchActionSearchSource(
            string url,
            global::tryAGI.OpenAI.WebSearchActionSearchSourceType type)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchActionSearchSource" /> class.
        /// </summary>
        public WebSearchActionSearchSource()
        {
        }
    }
}