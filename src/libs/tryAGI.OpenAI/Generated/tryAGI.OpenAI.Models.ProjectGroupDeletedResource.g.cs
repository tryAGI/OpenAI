
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
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ProjectGroupDeletedResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.ProjectGroupDeletedResourceObject Object { get; set; }

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
            global::tryAGI.OpenAI.ProjectGroupDeletedResourceObject @object)
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
    }
}