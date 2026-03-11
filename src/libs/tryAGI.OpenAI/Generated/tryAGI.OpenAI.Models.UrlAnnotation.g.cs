
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Annotation that references a URL.
    /// </summary>
    public sealed partial class UrlAnnotation
    {
        /// <summary>
        /// Type discriminator that is always `url` for this annotation.<br/>
        /// Default Value: url
        /// </summary>
        /// <default>global::tryAGI.OpenAI.UrlAnnotationType.Url</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UrlAnnotationTypeJsonConverter))]
        public global::tryAGI.OpenAI.UrlAnnotationType Type { get; set; } = global::tryAGI.OpenAI.UrlAnnotationType.Url;

        /// <summary>
        /// URL referenced by the annotation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.UrlAnnotationSource Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UrlAnnotation" /> class.
        /// </summary>
        /// <param name="type">
        /// Type discriminator that is always `url` for this annotation.<br/>
        /// Default Value: url
        /// </param>
        /// <param name="source">
        /// URL referenced by the annotation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UrlAnnotation(
            global::tryAGI.OpenAI.UrlAnnotationSource source,
            global::tryAGI.OpenAI.UrlAnnotationType type = global::tryAGI.OpenAI.UrlAnnotationType.Url)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UrlAnnotation" /> class.
        /// </summary>
        public UrlAnnotation()
        {
        }
    }
}