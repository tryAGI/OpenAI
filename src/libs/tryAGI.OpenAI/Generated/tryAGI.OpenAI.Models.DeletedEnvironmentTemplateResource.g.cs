
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A deleted reusable environment template.
    /// </summary>
    public sealed partial class DeletedEnvironmentTemplateResource
    {
        /// <summary>
        /// The ID of the deleted environment template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type. Always `agent.environment.template.deleted`.<br/>
        /// Default Value: agent.environment.template.deleted
        /// </summary>
        /// <default>global::tryAGI.OpenAI.DeletedEnvironmentTemplateResourceObject.AgentEnvironmentTemplateDeleted</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DeletedEnvironmentTemplateResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.DeletedEnvironmentTemplateResourceObject Object { get; set; } = global::tryAGI.OpenAI.DeletedEnvironmentTemplateResourceObject.AgentEnvironmentTemplateDeleted;

        /// <summary>
        /// Whether the environment template was deleted. Always `true`.
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
        /// Initializes a new instance of the <see cref="DeletedEnvironmentTemplateResource" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the deleted environment template.
        /// </param>
        /// <param name="deleted">
        /// Whether the environment template was deleted. Always `true`.
        /// </param>
        /// <param name="object">
        /// The object type. Always `agent.environment.template.deleted`.<br/>
        /// Default Value: agent.environment.template.deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeletedEnvironmentTemplateResource(
            string id,
            bool deleted,
            global::tryAGI.OpenAI.DeletedEnvironmentTemplateResourceObject @object = global::tryAGI.OpenAI.DeletedEnvironmentTemplateResourceObject.AgentEnvironmentTemplateDeleted)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeletedEnvironmentTemplateResource" /> class.
        /// </summary>
        public DeletedEnvironmentTemplateResource()
        {
        }

    }
}