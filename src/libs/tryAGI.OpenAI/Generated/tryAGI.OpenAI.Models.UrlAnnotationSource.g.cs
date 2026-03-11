
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// URL backing an annotation entry.
    /// </summary>
    public sealed partial class UrlAnnotationSource
    {
        /// <summary>
        /// Type discriminator that is always `url`.<br/>
        /// Default Value: url
        /// </summary>
        /// <default>global::tryAGI.OpenAI.UrlAnnotationSourceType.Url</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UrlAnnotationSourceTypeJsonConverter))]
        public global::tryAGI.OpenAI.UrlAnnotationSourceType Type { get; set; } = global::tryAGI.OpenAI.UrlAnnotationSourceType.Url;

        /// <summary>
        /// URL referenced by the annotation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UrlAnnotationSource" /> class.
        /// </summary>
        /// <param name="type">
        /// Type discriminator that is always `url`.<br/>
        /// Default Value: url
        /// </param>
        /// <param name="url">
        /// URL referenced by the annotation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UrlAnnotationSource(
            string url,
            global::tryAGI.OpenAI.UrlAnnotationSourceType type = global::tryAGI.OpenAI.UrlAnnotationSourceType.Url)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UrlAnnotationSource" /> class.
        /// </summary>
        public UrlAnnotationSource()
        {
        }
    }
}