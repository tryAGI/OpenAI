
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A file supplied inline when the session was created.
    /// </summary>
    public sealed partial class HostedEnvironmentFileResourceInline
    {
        /// <summary>
        /// The type of the object. Always `inline`.<br/>
        /// Default Value: inline
        /// </summary>
        /// <default>global::tryAGI.OpenAI.HostedEnvironmentFileResourceInlineType.Inline</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileResourceInlineTypeJsonConverter))]
        public global::tryAGI.OpenAI.HostedEnvironmentFileResourceInlineType Type { get; set; } = global::tryAGI.OpenAI.HostedEnvironmentFileResourceInlineType.Inline;

        /// <summary>
        /// The session-scoped ID of the file in the execution environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The file's absolute path inside the environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// The decoded file size in bytes.
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
        /// Initializes a new instance of the <see cref="HostedEnvironmentFileResourceInline" /> class.
        /// </summary>
        /// <param name="id">
        /// The session-scoped ID of the file in the execution environment.
        /// </param>
        /// <param name="path">
        /// The file's absolute path inside the environment.
        /// </param>
        /// <param name="sizeBytes">
        /// The decoded file size in bytes.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `inline`.<br/>
        /// Default Value: inline
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HostedEnvironmentFileResourceInline(
            string id,
            string path,
            long sizeBytes,
            global::tryAGI.OpenAI.HostedEnvironmentFileResourceInlineType type = global::tryAGI.OpenAI.HostedEnvironmentFileResourceInlineType.Inline)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.SizeBytes = sizeBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedEnvironmentFileResourceInline" /> class.
        /// </summary>
        public HostedEnvironmentFileResourceInline()
        {
        }

    }
}