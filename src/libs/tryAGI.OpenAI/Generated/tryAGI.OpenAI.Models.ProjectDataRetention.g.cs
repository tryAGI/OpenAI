
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Represents a project's data retention control setting.
    /// </summary>
    public sealed partial class ProjectDataRetention
    {
        /// <summary>
        /// The object type, which is always `project.data_retention`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ProjectDataRetentionObjectJsonConverter))]
        public global::tryAGI.OpenAI.ProjectDataRetentionObject Object { get; set; }

        /// <summary>
        /// The configured project data retention type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ProjectDataRetentionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ProjectDataRetentionType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectDataRetention" /> class.
        /// </summary>
        /// <param name="type">
        /// The configured project data retention type.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `project.data_retention`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectDataRetention(
            global::tryAGI.OpenAI.ProjectDataRetentionType type,
            global::tryAGI.OpenAI.ProjectDataRetentionObject @object)
        {
            this.Object = @object;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectDataRetention" /> class.
        /// </summary>
        public ProjectDataRetention()
        {
        }

    }
}