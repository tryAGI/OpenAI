
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Confirmation payload returned after unassigning a role.
    /// </summary>
    public sealed partial class DeletedRoleAssignmentResource
    {
        /// <summary>
        /// Identifier for the deleted assignment, such as `group.role.deleted` or `user.role.deleted`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Object { get; set; } = default!;

        /// <summary>
        /// Whether the assignment was removed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public bool Deleted { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeletedRoleAssignmentResource" /> class.
        /// </summary>
        /// <param name="object">
        /// Identifier for the deleted assignment, such as `group.role.deleted` or `user.role.deleted`.
        /// </param>
        /// <param name="deleted">
        /// Whether the assignment was removed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeletedRoleAssignmentResource(
            string @object,
            bool deleted)
        {
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeletedRoleAssignmentResource" /> class.
        /// </summary>
        public DeletedRoleAssignmentResource()
        {
        }
    }
}