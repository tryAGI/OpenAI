
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The newly created Live session. Use its ID for session controls and sideband connections.
    /// </summary>
    public sealed partial class Session5
    {
        /// <summary>
        /// Opaque session identifier. Preserve the returned value unchanged, including its prefix.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Session5" /> class.
        /// </summary>
        /// <param name="id">
        /// Opaque session identifier. Preserve the returned value unchanged, including its prefix.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Session5(
            string id)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Session5" /> class.
        /// </summary>
        public Session5()
        {
        }

    }
}