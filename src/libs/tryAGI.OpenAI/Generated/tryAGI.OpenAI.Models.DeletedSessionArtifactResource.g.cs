
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Confirmation that an immutable session artifact was deleted.
    /// </summary>
    public sealed partial class DeletedSessionArtifactResource
    {
        /// <summary>
        /// The ID of the deleted session artifact.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type. Always `agent.session.artifact.deleted`.<br/>
        /// Default Value: agent.session.artifact.deleted
        /// </summary>
        /// <default>global::tryAGI.OpenAI.DeletedSessionArtifactResourceObject.AgentSessionArtifactDeleted</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DeletedSessionArtifactResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.DeletedSessionArtifactResourceObject Object { get; set; } = global::tryAGI.OpenAI.DeletedSessionArtifactResourceObject.AgentSessionArtifactDeleted;

        /// <summary>
        /// Whether the session artifact was deleted. Always `true`.
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
        /// Initializes a new instance of the <see cref="DeletedSessionArtifactResource" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the deleted session artifact.
        /// </param>
        /// <param name="deleted">
        /// Whether the session artifact was deleted. Always `true`.
        /// </param>
        /// <param name="object">
        /// The object type. Always `agent.session.artifact.deleted`.<br/>
        /// Default Value: agent.session.artifact.deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeletedSessionArtifactResource(
            string id,
            bool deleted,
            global::tryAGI.OpenAI.DeletedSessionArtifactResourceObject @object = global::tryAGI.OpenAI.DeletedSessionArtifactResourceObject.AgentSessionArtifactDeleted)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeletedSessionArtifactResource" /> class.
        /// </summary>
        public DeletedSessionArtifactResource()
        {
        }

    }
}