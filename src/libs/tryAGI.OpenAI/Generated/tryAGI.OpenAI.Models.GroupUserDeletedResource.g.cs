
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Confirmation payload returned after removing a user from a group.
    /// </summary>
    public sealed partial class GroupUserDeletedResource
    {
        /// <summary>
        /// Always `group.user.deleted`.
        /// </summary>
        /// <default>"group.user.deleted"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "group.user.deleted";

        /// <summary>
        /// Whether the group membership was removed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupUserDeletedResource" /> class.
        /// </summary>
        /// <param name="deleted">
        /// Whether the group membership was removed.
        /// </param>
        /// <param name="object">
        /// Always `group.user.deleted`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroupUserDeletedResource(
            bool deleted,
            string @object = "group.user.deleted")
        {
            this.Object = @object;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupUserDeletedResource" /> class.
        /// </summary>
        public GroupUserDeletedResource()
        {
        }

        /// <summary>
        /// Creates a new <see cref="GroupUserDeletedResource"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static GroupUserDeletedResource FromDeleted(bool deleted)
        {
            return new GroupUserDeletedResource
            {
                Deleted = deleted,
            };
        }

    }
}