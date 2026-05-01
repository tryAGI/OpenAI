
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserRoleUpdateRequest
    {
        /// <summary>
        /// `owner` or `reader`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// Role ID to assign to the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_id")]
        public string? RoleId { get; set; }

        /// <summary>
        /// Technical level metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("technical_level")]
        public string? TechnicalLevel { get; set; }

        /// <summary>
        /// Developer persona metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("developer_persona")]
        public string? DeveloperPersona { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRoleUpdateRequest" /> class.
        /// </summary>
        /// <param name="role">
        /// `owner` or `reader`
        /// </param>
        /// <param name="roleId">
        /// Role ID to assign to the user.
        /// </param>
        /// <param name="technicalLevel">
        /// Technical level metadata.
        /// </param>
        /// <param name="developerPersona">
        /// Developer persona metadata.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserRoleUpdateRequest(
            string? role,
            string? roleId,
            string? technicalLevel,
            string? developerPersona)
        {
            this.Role = role;
            this.RoleId = roleId;
            this.TechnicalLevel = technicalLevel;
            this.DeveloperPersona = developerPersona;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRoleUpdateRequest" /> class.
        /// </summary>
        public UserRoleUpdateRequest()
        {
        }
    }
}