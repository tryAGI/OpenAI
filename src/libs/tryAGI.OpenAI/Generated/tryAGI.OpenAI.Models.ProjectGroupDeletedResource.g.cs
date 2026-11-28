
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Confirmation payload returned after removing a group from a project.
    /// </summary>
    public sealed partial class ProjectGroupDeletedResource
    {
        /// <summary>
        /// Always `project.group.deleted`.
        /// </summary>
        /// <default>"project.group.deleted"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "project.group.deleted";

        /// <summary>
        /// Whether the group membership in the project was removed.
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
        /// Initializes a new instance of the <see cref="ProjectGroupDeletedResource" /> class.
        /// </summary>
        /// <param name="deleted">
        /// Whether the group membership in the project was removed.
        /// </param>
        /// <param name="object">
        /// Always `project.group.deleted`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectGroupDeletedResource(
            bool deleted,
            string @object = "project.group.deleted")
        {
            this.Object = @object;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectGroupDeletedResource" /> class.
        /// </summary>
        public ProjectGroupDeletedResource()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ProjectGroupDeletedResource"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ProjectGroupDeletedResource FromDeleted(bool deleted)
        {
            return new ProjectGroupDeletedResource
            {
                Deleted = deleted,
            };
        }

    }
}