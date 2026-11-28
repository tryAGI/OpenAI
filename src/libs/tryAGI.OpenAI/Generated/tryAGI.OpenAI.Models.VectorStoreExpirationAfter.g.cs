
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The expiration policy for a vector store.
    /// </summary>
    public sealed partial class VectorStoreExpirationAfter
    {
        /// <summary>
        /// Anchor timestamp after which the expiration policy applies. Supported anchors: `last_active_at`.
        /// </summary>
        /// <default>"last_active_at"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("anchor")]
        public string Anchor { get; set; } = "last_active_at";

        /// <summary>
        /// The number of days after the anchor time that the vector store will expire.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("days")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Days { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreExpirationAfter" /> class.
        /// </summary>
        /// <param name="days">
        /// The number of days after the anchor time that the vector store will expire.
        /// </param>
        /// <param name="anchor">
        /// Anchor timestamp after which the expiration policy applies. Supported anchors: `last_active_at`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VectorStoreExpirationAfter(
            int days,
            string anchor = "last_active_at")
        {
            this.Anchor = anchor;
            this.Days = days;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreExpirationAfter" /> class.
        /// </summary>
        public VectorStoreExpirationAfter()
        {
        }

        /// <summary>
        /// Creates a new <see cref="VectorStoreExpirationAfter"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static VectorStoreExpirationAfter FromDays(int days)
        {
            return new VectorStoreExpirationAfter
            {
                Days = days,
            };
        }

    }
}