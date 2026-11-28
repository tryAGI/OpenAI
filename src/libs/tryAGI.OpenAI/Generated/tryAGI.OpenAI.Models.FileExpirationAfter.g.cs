
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
        /// <default>"created_at"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("anchor")]
        public string Anchor { get; set; } = "created_at";

        /// <summary>
        /// The number of seconds after the anchor time that the file will expire. Must be between 3600 (1 hour) and 2592000 (30 days).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Seconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileExpirationAfter" /> class.
        /// </summary>
        /// <param name="seconds">
        /// The number of seconds after the anchor time that the file will expire. Must be between 3600 (1 hour) and 2592000 (30 days).
        /// </param>
        /// <param name="anchor">
        /// Anchor timestamp after which the expiration policy applies. Supported anchors: `created_at`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileExpirationAfter(
            long seconds,
            string anchor = "created_at")
        {
            this.Anchor = anchor;
            this.Seconds = seconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileExpirationAfter" /> class.
        /// </summary>
        public FileExpirationAfter()
        {
        }

        /// <summary>
        /// Creates a new <see cref="FileExpirationAfter"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static FileExpirationAfter FromSeconds(long seconds)
        {
            return new FileExpirationAfter
            {
                Seconds = seconds,
            };
        }

    }
}