
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A subagent created within a session.
    /// </summary>
    public sealed partial class SubagentResource
    {
        /// <summary>
        /// The ID of the subagent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type. Always `agent.session.subagent`.<br/>
        /// Default Value: agent.session.subagent
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SubagentObjectResource.AgentSessionSubagent</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SubagentObjectResourceJsonConverter))]
        public global::tryAGI.OpenAI.SubagentObjectResource Object { get; set; } = global::tryAGI.OpenAI.SubagentObjectResource.AgentSessionSubagent;

        /// <summary>
        /// The ID of the session that owns the subagent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// The runner-assigned nickname, or null when unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Initial task content, or null when unavailable. Text may contain placeholders for images or audio when only a preview is available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AgentContentResource>? Instructions { get; set; }

        /// <summary>
        /// The ID of the agent that created this subagent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ParentAgentId { get; set; }

        /// <summary>
        /// The current status of the subagent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SubagentStatusResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.SubagentStatusResource Status { get; set; }

        /// <summary>
        /// The Unix timestamp, in seconds, when the subagent was first opened. Resuming does not change it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("opened_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset OpenedAt { get; set; }

        /// <summary>
        /// The Unix timestamp, in seconds, when the subagent was closed. Null while active, including after resume.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("closed_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? ClosedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubagentResource" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the subagent.
        /// </param>
        /// <param name="sessionId">
        /// The ID of the session that owns the subagent.
        /// </param>
        /// <param name="parentAgentId">
        /// The ID of the agent that created this subagent.
        /// </param>
        /// <param name="status">
        /// The current status of the subagent.
        /// </param>
        /// <param name="openedAt">
        /// The Unix timestamp, in seconds, when the subagent was first opened. Resuming does not change it.
        /// </param>
        /// <param name="name">
        /// The runner-assigned nickname, or null when unavailable.
        /// </param>
        /// <param name="instructions">
        /// Initial task content, or null when unavailable. Text may contain placeholders for images or audio when only a preview is available.
        /// </param>
        /// <param name="closedAt">
        /// The Unix timestamp, in seconds, when the subagent was closed. Null while active, including after resume.
        /// </param>
        /// <param name="object">
        /// The object type. Always `agent.session.subagent`.<br/>
        /// Default Value: agent.session.subagent
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubagentResource(
            string id,
            string sessionId,
            string parentAgentId,
            global::tryAGI.OpenAI.SubagentStatusResource status,
            global::System.DateTimeOffset openedAt,
            string? name,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AgentContentResource>? instructions,
            global::System.DateTimeOffset? closedAt,
            global::tryAGI.OpenAI.SubagentObjectResource @object = global::tryAGI.OpenAI.SubagentObjectResource.AgentSessionSubagent)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.Name = name;
            this.Instructions = instructions;
            this.ParentAgentId = parentAgentId ?? throw new global::System.ArgumentNullException(nameof(parentAgentId));
            this.Status = status;
            this.OpenedAt = openedAt;
            this.ClosedAt = closedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubagentResource" /> class.
        /// </summary>
        public SubagentResource()
        {
        }

    }
}