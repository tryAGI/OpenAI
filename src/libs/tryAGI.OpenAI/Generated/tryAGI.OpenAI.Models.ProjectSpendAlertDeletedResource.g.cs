
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Confirmation payload returned after deleting a project spend alert.
    /// </summary>
    public sealed partial class ProjectSpendAlertDeletedResource
    {
        /// <summary>
        /// The deleted spend alert ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Always `project.spend_alert.deleted`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ProjectSpendAlertDeletedResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.ProjectSpendAlertDeletedResourceObject Object { get; set; }

        /// <summary>
        /// Whether the spend alert was deleted.
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
        /// Initializes a new instance of the <see cref="ProjectSpendAlertDeletedResource" /> class.
        /// </summary>
        /// <param name="id">
        /// The deleted spend alert ID.
        /// </param>
        /// <param name="deleted">
        /// Whether the spend alert was deleted.
        /// </param>
        /// <param name="object">
        /// Always `project.spend_alert.deleted`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectSpendAlertDeletedResource(
            string id,
            bool deleted,
            global::tryAGI.OpenAI.ProjectSpendAlertDeletedResourceObject @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSpendAlertDeletedResource" /> class.
        /// </summary>
        public ProjectSpendAlertDeletedResource()
        {
        }

    }
}