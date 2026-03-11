
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Summary information about a group returned in role assignment responses.
    /// </summary>
    public sealed partial class Group
    {
        /// <summary>
        /// Always `group`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.GroupObjectJsonConverter))]
        public global::tryAGI.OpenAI.GroupObject Object { get; set; }

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
        /// Whether the group is managed through SCIM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scim_managed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ScimManaged { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Group" /> class.
        /// </summary>
        /// <param name="object">
        /// Always `group`.
        /// </param>
        /// <param name="id">
        /// Identifier for the group.
        /// </param>
        /// <param name="name">
        /// Display name of the group.
        /// </param>
        /// <param name="createdAt">
        /// Unix timestamp (in seconds) when the group was created.
        /// </param>
        /// <param name="scimManaged">
        /// Whether the group is managed through SCIM.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Group(
            string id,
            string name,
            global::System.DateTimeOffset createdAt,
            bool scimManaged,
            global::tryAGI.OpenAI.GroupObject @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt;
            this.ScimManaged = scimManaged;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Group" /> class.
        /// </summary>
        public Group()
        {
        }
    }
}