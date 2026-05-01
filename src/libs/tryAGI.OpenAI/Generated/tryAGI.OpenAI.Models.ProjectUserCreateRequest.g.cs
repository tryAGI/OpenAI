
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectUserCreateRequest
    {
        /// <summary>
        /// The ID of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Email of the user to add.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// `owner` or `member`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUserCreateRequest" /> class.
        /// </summary>
        /// <param name="role">
        /// `owner` or `member`
        /// </param>
        /// <param name="userId">
        /// The ID of the user.
        /// </param>
        /// <param name="email">
        /// Email of the user to add.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectUserCreateRequest(
            string role,
            string? userId,
            string? email)
        {
            this.UserId = userId;
            this.Email = email;
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUserCreateRequest" /> class.
        /// </summary>
        public ProjectUserCreateRequest()
        {
        }
    }
}