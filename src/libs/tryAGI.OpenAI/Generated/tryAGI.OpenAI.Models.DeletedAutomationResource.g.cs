
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeletedAutomationResource
    {
        /// <summary>
        /// The deleted automation ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Always `agent.automation.deleted`.<br/>
        /// Default Value: agent.automation.deleted
        /// </summary>
        /// <default>global::tryAGI.OpenAI.DeletedAutomationResourceObject.AgentAutomationDeleted</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DeletedAutomationResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.DeletedAutomationResourceObject Object { get; set; } = global::tryAGI.OpenAI.DeletedAutomationResourceObject.AgentAutomationDeleted;

        /// <summary>
        /// Always true.
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
        /// Initializes a new instance of the <see cref="DeletedAutomationResource" /> class.
        /// </summary>
        /// <param name="id">
        /// The deleted automation ID.
        /// </param>
        /// <param name="deleted">
        /// Always true.
        /// </param>
        /// <param name="object">
        /// Always `agent.automation.deleted`.<br/>
        /// Default Value: agent.automation.deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeletedAutomationResource(
            string id,
            bool deleted,
            global::tryAGI.OpenAI.DeletedAutomationResourceObject @object = global::tryAGI.OpenAI.DeletedAutomationResourceObject.AgentAutomationDeleted)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeletedAutomationResource" /> class.
        /// </summary>
        public DeletedAutomationResource()
        {
        }

    }
}