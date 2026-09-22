
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A Managed Agents session removed from the public API. Physical cleanup may continue asynchronously.
    /// </summary>
    public sealed partial class DeletedSessionResource
    {
        /// <summary>
        /// The ID of the deleted session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type. Always `agent.session.deleted`.<br/>
        /// Default Value: agent.session.deleted
        /// </summary>
        /// <default>global::tryAGI.OpenAI.DeletedSessionResourceObject.AgentSessionDeleted</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DeletedSessionResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.DeletedSessionResourceObject Object { get; set; } = global::tryAGI.OpenAI.DeletedSessionResourceObject.AgentSessionDeleted;

        /// <summary>
        /// Whether the session has been removed from the public API. Always `true`. Physical cleanup may still be in progress.
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
        /// Initializes a new instance of the <see cref="DeletedSessionResource" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the deleted session.
        /// </param>
        /// <param name="deleted">
        /// Whether the session has been removed from the public API. Always `true`. Physical cleanup may still be in progress.
        /// </param>
        /// <param name="object">
        /// The object type. Always `agent.session.deleted`.<br/>
        /// Default Value: agent.session.deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeletedSessionResource(
            string id,
            bool deleted,
            global::tryAGI.OpenAI.DeletedSessionResourceObject @object = global::tryAGI.OpenAI.DeletedSessionResourceObject.AgentSessionDeleted)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeletedSessionResource" /> class.
        /// </summary>
        public DeletedSessionResource()
        {
        }

    }
}