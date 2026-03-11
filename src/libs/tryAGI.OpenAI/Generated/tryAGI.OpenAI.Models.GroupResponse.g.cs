
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Details about an organization group.
    /// </summary>
    public sealed partial class GroupResponse
    {
        /// <summary>
        /// Identifier for the group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Display name of the group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Unix timestamp (in seconds) when the group was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Whether the group is managed through SCIM and controlled by your identity provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_scim_managed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsScimManaged { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Identifier for the group.
        /// </param>
        /// <param name="name">
        /// Display name of the group.
        /// </param>
        /// <param name="createdAt">
        /// Unix timestamp (in seconds) when the group was created.
        /// </param>
        /// <param name="isScimManaged">
        /// Whether the group is managed through SCIM and controlled by your identity provider.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroupResponse(
            string id,
            string name,
            global::System.DateTimeOffset createdAt,
            bool isScimManaged)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt;
            this.IsScimManaged = isScimManaged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupResponse" /> class.
        /// </summary>
        public GroupResponse()
        {
        }
    }
}