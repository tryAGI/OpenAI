
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
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.GroupUserDeletedResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.GroupUserDeletedResourceObject Object { get; set; }

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
        /// <param name="object">
        /// Always `group.user.deleted`.
        /// </param>
        /// <param name="deleted">
        /// Whether the group membership was removed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroupUserDeletedResource(
            bool deleted,
            global::tryAGI.OpenAI.GroupUserDeletedResourceObject @object)
        {
            this.Deleted = deleted;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupUserDeletedResource" /> class.
        /// </summary>
        public GroupUserDeletedResource()
        {
        }
    }
}