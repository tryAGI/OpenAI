
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Request payload for granting a group access to a project.
    /// </summary>
    public sealed partial class InviteProjectGroupBody
    {
        /// <summary>
        /// Identifier of the group to add to the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GroupId { get; set; }

        /// <summary>
        /// Identifier of the project role to grant to the group.
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
        /// Initializes a new instance of the <see cref="InviteProjectGroupBody" /> class.
        /// </summary>
        /// <param name="groupId">
        /// Identifier of the group to add to the project.
        /// </param>
        /// <param name="role">
        /// Identifier of the project role to grant to the group.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InviteProjectGroupBody(
            string groupId,
            string role)
        {
            this.GroupId = groupId ?? throw new global::System.ArgumentNullException(nameof(groupId));
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InviteProjectGroupBody" /> class.
        /// </summary>
        public InviteProjectGroupBody()
        {
        }
    }
}