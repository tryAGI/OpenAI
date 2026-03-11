
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Annotation that references an uploaded file.
    /// </summary>
    public sealed partial class FileAnnotation
    {
        /// <summary>
        /// Type discriminator that is always `file` for this annotation.<br/>
        /// Default Value: file
        /// </summary>
        /// <default>global::tryAGI.OpenAI.FileAnnotationType.File</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.FileAnnotationTypeJsonConverter))]
        public global::tryAGI.OpenAI.FileAnnotationType Type { get; set; } = global::tryAGI.OpenAI.FileAnnotationType.File;

        /// <summary>
        /// File attachment referenced by the annotation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::tryAGI.OpenAI.FileAnnotationSource Source { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileAnnotation" /> class.
        /// </summary>
        /// <param name="type">
        /// Type discriminator that is always `file` for this annotation.<br/>
        /// Default Value: file
        /// </param>
        /// <param name="source">
        /// File attachment referenced by the annotation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileAnnotation(
            global::tryAGI.OpenAI.FileAnnotationSource source,
            global::tryAGI.OpenAI.FileAnnotationType type = global::tryAGI.OpenAI.FileAnnotationType.File)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileAnnotation" /> class.
        /// </summary>
        public FileAnnotation()
        {
        }
    }
}