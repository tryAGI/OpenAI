
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The expiration policy for a file. By default, files with `purpose=batch` expire after 30 days and all other files are persisted until they are manually deleted.
    /// </summary>
    public sealed partial class FileExpirationAfter
    {
        /// <summary>
        /// Anchor timestamp after which the expiration policy applies. Supported anchors: `created_at`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anchor")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.FileExpirationAfterAnchorJsonConverter))]
        public global::tryAGI.OpenAI.FileExpirationAfterAnchor Anchor { get; set; }

        /// <summary>
        /// The number of seconds after the anchor time that the file will expire. Must be between 3600 (1 hour) and 2592000 (30 days).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Seconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileExpirationAfter" /> class.
        /// </summary>
        /// <param name="anchor">
        /// Anchor timestamp after which the expiration policy applies. Supported anchors: `created_at`.
        /// </param>
        /// <param name="seconds">
        /// The number of seconds after the anchor time that the file will expire. Must be between 3600 (1 hour) and 2592000 (30 days).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileExpirationAfter(
            int seconds,
            global::tryAGI.OpenAI.FileExpirationAfterAnchor anchor)
        {
            this.Seconds = seconds;
            this.Anchor = anchor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileExpirationAfter" /> class.
        /// </summary>
        public FileExpirationAfter()
        {
        }
    }
}