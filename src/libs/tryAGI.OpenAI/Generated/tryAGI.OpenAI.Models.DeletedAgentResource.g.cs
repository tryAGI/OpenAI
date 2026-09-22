
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A deleted reusable agent.
    /// </summary>
    public sealed partial class DeletedAgentResource
    {
        /// <summary>
        /// The ID of the deleted agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type. Always `agent.deleted`.<br/>
        /// Default Value: agent.deleted
        /// </summary>
        /// <default>global::tryAGI.OpenAI.DeletedAgentResourceObject.AgentDeleted</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DeletedAgentResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.DeletedAgentResourceObject Object { get; set; } = global::tryAGI.OpenAI.DeletedAgentResourceObject.AgentDeleted;

        /// <summary>
        /// Whether the agent was deleted. Always `true`.
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
        /// Initializes a new instance of the <see cref="DeletedAgentResource" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the deleted agent.
        /// </param>
        /// <param name="deleted">
        /// Whether the agent was deleted. Always `true`.
        /// </param>
        /// <param name="object">
        /// The object type. Always `agent.deleted`.<br/>
        /// Default Value: agent.deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeletedAgentResource(
            string id,
            bool deleted,
            global::tryAGI.OpenAI.DeletedAgentResourceObject @object = global::tryAGI.OpenAI.DeletedAgentResourceObject.AgentDeleted)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeletedAgentResource" /> class.
        /// </summary>
        public DeletedAgentResource()
        {
        }

    }
}