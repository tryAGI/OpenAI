
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Confirmation payload returned after deleting a role.
    /// </summary>
    public sealed partial class RoleDeletedResource
    {
        /// <summary>
        /// Always `role.deleted`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RoleDeletedResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.RoleDeletedResourceObject Object { get; set; }

        /// <summary>
        /// Identifier of the deleted role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Whether the role was deleted.
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
        /// Initializes a new instance of the <see cref="RoleDeletedResource" /> class.
        /// </summary>
        /// <param name="object">
        /// Always `role.deleted`.
        /// </param>
        /// <param name="id">
        /// Identifier of the deleted role.
        /// </param>
        /// <param name="deleted">
        /// Whether the role was deleted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RoleDeletedResource(
            string id,
            bool deleted,
            global::tryAGI.OpenAI.RoleDeletedResourceObject @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Deleted = deleted;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoleDeletedResource" /> class.
        /// </summary>
        public RoleDeletedResource()
        {
        }
    }
}