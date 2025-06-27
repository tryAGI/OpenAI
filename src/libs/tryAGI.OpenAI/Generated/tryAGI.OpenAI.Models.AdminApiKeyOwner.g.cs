
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AdminApiKeyOwner
    {
        /// <summary>
        /// The Unix timestamp (in seconds) of when the user was created<br/>
        /// Example: 1711471533L
        /// </summary>
        /// <example>1711471533L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// The identifier, which can be referenced in API endpoints<br/>
        /// Example: sa_456
        /// </summary>
        /// <example>sa_456</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the user<br/>
        /// Example: My Service Account
        /// </summary>
        /// <example>My Service Account</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The object type, which is always organization.user<br/>
        /// Example: organization.user
        /// </summary>
        /// <example>organization.user</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Always `owner`<br/>
        /// Example: owner
        /// </summary>
        /// <example>owner</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// Always `user`<br/>
        /// Example: user
        /// </summary>
        /// <example>user</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminApiKeyOwner" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) of when the user was created<br/>
        /// Example: 1711471533L
        /// </param>
        /// <param name="id">
        /// The identifier, which can be referenced in API endpoints<br/>
        /// Example: sa_456
        /// </param>
        /// <param name="name">
        /// The name of the user<br/>
        /// Example: My Service Account
        /// </param>
        /// <param name="object">
        /// The object type, which is always organization.user<br/>
        /// Example: organization.user
        /// </param>
        /// <param name="role">
        /// Always `owner`<br/>
        /// Example: owner
        /// </param>
        /// <param name="type">
        /// Always `user`<br/>
        /// Example: user
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminApiKeyOwner(
            global::System.DateTimeOffset? createdAt,
            string? id,
            string? name,
            string? @object,
            string? role,
            string? type)
        {
            this.CreatedAt = createdAt;
            this.Id = id;
            this.Name = name;
            this.Object = @object;
            this.Role = role;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminApiKeyOwner" /> class.
        /// </summary>
        public AdminApiKeyOwner()
        {
        }
    }
}