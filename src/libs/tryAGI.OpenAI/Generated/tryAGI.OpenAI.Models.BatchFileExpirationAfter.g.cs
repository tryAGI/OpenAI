
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The expiration policy for the output and/or error file that are generated for a batch.
    /// </summary>
    public sealed partial class BatchFileExpirationAfter
    {
        /// <summary>
        /// Anchor timestamp after which the expiration policy applies. Supported anchors: `created_at`. Note that the anchor is the file creation time, not the time the batch is created.
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
        /// Initializes a new instance of the <see cref="BatchFileExpirationAfter" /> class.
        /// </summary>
        /// <param name="seconds">
        /// The number of seconds after the anchor time that the file will expire. Must be between 3600 (1 hour) and 2592000 (30 days).
        /// </param>
        /// <param name="anchor">
        /// Anchor timestamp after which the expiration policy applies. Supported anchors: `created_at`. Note that the anchor is the file creation time, not the time the batch is created.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchFileExpirationAfter(
            long seconds,
            string anchor = "created_at")
        {
            this.Anchor = anchor;
            this.Seconds = seconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchFileExpirationAfter" /> class.
        /// </summary>
        public BatchFileExpirationAfter()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BatchFileExpirationAfter"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BatchFileExpirationAfter FromSeconds(long seconds)
        {
            return new BatchFileExpirationAfter
            {
                Seconds = seconds,
            };
        }

    }
}