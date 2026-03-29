
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Details about a group's membership in a project.
    /// </summary>
    public sealed partial class ProjectGroup
    {
        /// <summary>
        /// Always `project.group`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ProjectGroupObjectJsonConverter))]
        public global::tryAGI.OpenAI.ProjectGroupObject Object { get; set; }

        /// <summary>
        /// Identifier of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Identifier of the group that has access to the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GroupId { get; set; }

        /// <summary>
        /// Display name of the group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GroupName { get; set; }

        /// <summary>
        /// Unix timestamp (in seconds) when the group was granted project access.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectGroup" /> class.
        /// </summary>
        /// <param name="projectId">
        /// Identifier of the project.
        /// </param>
        /// <param name="groupId">
        /// Identifier of the group that has access to the project.
        /// </param>
        /// <param name="groupName">
        /// Display name of the group.
        /// </param>
        /// <param name="createdAt">
        /// Unix timestamp (in seconds) when the group was granted project access.
        /// </param>
        /// <param name="object">
        /// Always `project.group`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectGroup(
            string projectId,
            string groupId,
            string groupName,
            global::System.DateTimeOffset createdAt,
            global::tryAGI.OpenAI.ProjectGroupObject @object)
        {
            this.Object = @object;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.GroupId = groupId ?? throw new global::System.ArgumentNullException(nameof(groupId));
            this.GroupName = groupName ?? throw new global::System.ArgumentNullException(nameof(groupName));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectGroup" /> class.
        /// </summary>
        public ProjectGroup()
        {
        }
    }
}