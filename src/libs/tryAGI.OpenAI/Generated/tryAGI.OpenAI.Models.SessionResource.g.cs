
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A Managed Agents session.
    /// </summary>
    public sealed partial class SessionResource
    {
        /// <summary>
        /// Custom string key-value pairs attached to the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The ID of the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type. Always `agent.session`.<br/>
        /// Default Value: agent.session
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SessionResourceObject.AgentSession</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.SessionResourceObject Object { get; set; } = global::tryAGI.OpenAI.SessionResourceObject.AgentSession;

        /// <summary>
        /// The Unix timestamp, in seconds, when the session was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The Unix timestamp, in seconds, when the session was last active.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_active_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset LastActiveAt { get; set; }

        /// <summary>
        /// The current status of the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionStatusResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.SessionStatusResource Status { get; set; }

        /// <summary>
        /// Actions that must be completed before the session can continue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_actions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionRequiredActionResource> RequiredActions { get; set; }

        /// <summary>
        /// The error that caused the session to fail, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// The agent running in the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.SessionAgentResource Agent { get; set; }

        /// <summary>
        /// The execution environment for the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.EnvironmentResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.EnvironmentResource Environment { get; set; }

        /// <summary>
        /// The IDs of vaults made available to the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vault_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> VaultIds { get; set; }

        /// <summary>
        /// Best-effort token usage for the session, or null if unknown. Recorded usage may change.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::tryAGI.OpenAI.TokenUsageResource? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionResource" /> class.
        /// </summary>
        /// <param name="metadata">
        /// Custom string key-value pairs attached to the session.
        /// </param>
        /// <param name="id">
        /// The ID of the session.
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp, in seconds, when the session was created.
        /// </param>
        /// <param name="lastActiveAt">
        /// The Unix timestamp, in seconds, when the session was last active.
        /// </param>
        /// <param name="status">
        /// The current status of the session.
        /// </param>
        /// <param name="requiredActions">
        /// Actions that must be completed before the session can continue.
        /// </param>
        /// <param name="agent">
        /// The agent running in the session.
        /// </param>
        /// <param name="environment">
        /// The execution environment for the session.
        /// </param>
        /// <param name="vaultIds">
        /// The IDs of vaults made available to the session.
        /// </param>
        /// <param name="error">
        /// The error that caused the session to fail, if any.
        /// </param>
        /// <param name="usage">
        /// Best-effort token usage for the session, or null if unknown. Recorded usage may change.
        /// </param>
        /// <param name="object">
        /// The object type. Always `agent.session`.<br/>
        /// Default Value: agent.session
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionResource(
            global::System.Collections.Generic.Dictionary<string, string> metadata,
            string id,
            global::System.DateTimeOffset createdAt,
            global::System.DateTimeOffset lastActiveAt,
            global::tryAGI.OpenAI.SessionStatusResource status,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionRequiredActionResource> requiredActions,
            global::tryAGI.OpenAI.SessionAgentResource agent,
            global::tryAGI.OpenAI.EnvironmentResource environment,
            global::System.Collections.Generic.IList<string> vaultIds,
            string? error,
            global::tryAGI.OpenAI.TokenUsageResource? usage,
            global::tryAGI.OpenAI.SessionResourceObject @object = global::tryAGI.OpenAI.SessionResourceObject.AgentSession)
        {
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.CreatedAt = createdAt;
            this.LastActiveAt = lastActiveAt;
            this.Status = status;
            this.RequiredActions = requiredActions ?? throw new global::System.ArgumentNullException(nameof(requiredActions));
            this.Error = error;
            this.Agent = agent ?? throw new global::System.ArgumentNullException(nameof(agent));
            this.Environment = environment;
            this.VaultIds = vaultIds ?? throw new global::System.ArgumentNullException(nameof(vaultIds));
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionResource" /> class.
        /// </summary>
        public SessionResource()
        {
        }

    }
}