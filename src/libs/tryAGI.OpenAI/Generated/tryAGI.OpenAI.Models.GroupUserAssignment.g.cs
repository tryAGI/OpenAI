
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Confirmation payload returned after adding a user to a group.
    /// </summary>
    public sealed partial class GroupUserAssignment
    {
        /// <summary>
        /// Always `group.user`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.GroupUserAssignmentObjectJsonConverter))]
        public global::tryAGI.OpenAI.GroupUserAssignmentObject Object { get; set; }

        /// <summary>
        /// Identifier of the user that was added.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Identifier of the group the user was added to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GroupId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupUserAssignment" /> class.
        /// </summary>
        /// <param name="object">
        /// Always `group.user`.
        /// </param>
        /// <param name="userId">
        /// Identifier of the user that was added.
        /// </param>
        /// <param name="groupId">
        /// Identifier of the group the user was added to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroupUserAssignment(
            string userId,
            string groupId,
            global::tryAGI.OpenAI.GroupUserAssignmentObject @object)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.GroupId = groupId ?? throw new global::System.ArgumentNullException(nameof(groupId));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupUserAssignment" /> class.
        /// </summary>
        public GroupUserAssignment()
        {
        }
    }
}