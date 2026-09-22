
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Metadata for confidential inline file contents.
    /// </summary>
    public sealed partial class HostedTemplateFileResourceInline
    {
        /// <summary>
        /// The type of the object. Always `inline`.<br/>
        /// Default Value: inline
        /// </summary>
        /// <default>global::tryAGI.OpenAI.HostedTemplateFileResourceInlineType.Inline</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.HostedTemplateFileResourceInlineTypeJsonConverter))]
        public global::tryAGI.OpenAI.HostedTemplateFileResourceInlineType Type { get; set; } = global::tryAGI.OpenAI.HostedTemplateFileResourceInlineType.Inline;

        /// <summary>
        /// The file's absolute path inside the environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// The decoded size of the inline file in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long SizeBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedTemplateFileResourceInline" /> class.
        /// </summary>
        /// <param name="path">
        /// The file's absolute path inside the environment.
        /// </param>
        /// <param name="sizeBytes">
        /// The decoded size of the inline file in bytes.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `inline`.<br/>
        /// Default Value: inline
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HostedTemplateFileResourceInline(
            string path,
            long sizeBytes,
            global::tryAGI.OpenAI.HostedTemplateFileResourceInlineType type = global::tryAGI.OpenAI.HostedTemplateFileResourceInlineType.Inline)
        {
            this.Type = type;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.SizeBytes = sizeBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedTemplateFileResourceInline" /> class.
        /// </summary>
        public HostedTemplateFileResourceInline()
        {
        }

    }
}