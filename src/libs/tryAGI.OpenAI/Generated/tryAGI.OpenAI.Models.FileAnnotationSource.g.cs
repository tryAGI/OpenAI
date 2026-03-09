
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Attachment source referenced by an annotation.
    /// </summary>
    public sealed partial class FileAnnotationSource
    {
        /// <summary>
        /// Type discriminator that is always `file`.<br/>
        /// Default Value: file
        /// </summary>
        /// <default>global::tryAGI.OpenAI.FileAnnotationSourceType.File</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.FileAnnotationSourceTypeJsonConverter))]
        public global::tryAGI.OpenAI.FileAnnotationSourceType Type { get; set; } = global::tryAGI.OpenAI.FileAnnotationSourceType.File;

        /// <summary>
        /// Filename referenced by the annotation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileAnnotationSource" /> class.
        /// </summary>
        /// <param name="type">
        /// Type discriminator that is always `file`.<br/>
        /// Default Value: file
        /// </param>
        /// <param name="filename">
        /// Filename referenced by the annotation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileAnnotationSource(
            string filename,
            global::tryAGI.OpenAI.FileAnnotationSourceType type = global::tryAGI.OpenAI.FileAnnotationSourceType.File)
        {
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileAnnotationSource" /> class.
        /// </summary>
        public FileAnnotationSource()
        {
        }
    }
}