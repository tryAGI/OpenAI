
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Nested user details.
    /// </summary>
    public sealed partial class UserUser1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UserUser1ObjectJsonConverter))]
        public global::tryAGI.OpenAI.UserUser1Object Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("picture")]
        public string? Picture { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("banned")]
        public bool? Banned { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("banned_at")]
        public int? BannedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserUser1" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="object"></param>
        /// <param name="email"></param>
        /// <param name="name"></param>
        /// <param name="picture"></param>
        /// <param name="enabled"></param>
        /// <param name="banned"></param>
        /// <param name="bannedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserUser1(
            string id,
            global::tryAGI.OpenAI.UserUser1Object @object,
            string? email,
            string? name,
            string? picture,
            bool? enabled,
            bool? banned,
            int? bannedAt)
        {
            this.Object = @object;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Email = email;
            this.Name = name;
            this.Picture = picture;
            this.Enabled = enabled;
            this.Banned = banned;
            this.BannedAt = bannedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserUser1" /> class.
        /// </summary>
        public UserUser1()
        {
        }
    }
}