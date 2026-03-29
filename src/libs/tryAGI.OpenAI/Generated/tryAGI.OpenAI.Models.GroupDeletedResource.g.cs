
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Confirmation payload returned after deleting a group.
    /// </summary>
    public sealed partial class GroupDeletedResource
    {
        /// <summary>
        /// Always `group.deleted`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.GroupDeletedResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.GroupDeletedResourceObject Object { get; set; }

        /// <summary>
        /// Identifier of the deleted group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Whether the group was deleted.
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
        /// Initializes a new instance of the <see cref="GroupDeletedResource" /> class.
        /// </summary>
        /// <param name="id">
        /// Identifier of the deleted group.
        /// </param>
        /// <param name="deleted">
        /// Whether the group was deleted.
        /// </param>
        /// <param name="object">
        /// Always `group.deleted`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroupDeletedResource(
            string id,
            bool deleted,
            global::tryAGI.OpenAI.GroupDeletedResourceObject @object)
        {
            this.Object = @object;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupDeletedResource" /> class.
        /// </summary>
        public GroupDeletedResource()
        {
        }
    }
}