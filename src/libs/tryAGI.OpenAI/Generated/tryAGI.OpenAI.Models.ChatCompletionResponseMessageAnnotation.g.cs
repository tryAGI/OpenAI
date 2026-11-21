
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A URL citation when using web search.
    /// </summary>
    public sealed partial class ChatCompletionResponseMessageAnnotation
    {
        /// <summary>
        /// The type of the URL citation. Always `url_citation`.
        /// </summary>
        /// <default>"url_citation"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "url_citation";

        /// <summary>
        /// A URL citation when using web search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url_citation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ChatCompletionResponseMessageAnnotationUrlCitation UrlCitation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponseMessageAnnotation" /> class.
        /// </summary>
        /// <param name="urlCitation">
        /// A URL citation when using web search.
        /// </param>
        /// <param name="type">
        /// The type of the URL citation. Always `url_citation`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionResponseMessageAnnotation(
            global::tryAGI.OpenAI.ChatCompletionResponseMessageAnnotationUrlCitation urlCitation,
            string type = "url_citation")
        {
            this.Type = type;
            this.UrlCitation = urlCitation ?? throw new global::System.ArgumentNullException(nameof(urlCitation));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponseMessageAnnotation" /> class.
        /// </summary>
        public ChatCompletionResponseMessageAnnotation()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ChatCompletionResponseMessageAnnotation"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ChatCompletionResponseMessageAnnotation FromUrlCitation(global::tryAGI.OpenAI.ChatCompletionResponseMessageAnnotationUrlCitation urlCitation)
        {
            return new ChatCompletionResponseMessageAnnotation
            {
                UrlCitation = urlCitation,
            };
        }

    }
}