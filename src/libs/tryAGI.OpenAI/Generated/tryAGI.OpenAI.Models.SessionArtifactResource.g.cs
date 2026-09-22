
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An immutable file published by a completed hosted session turn.
    /// </summary>
    public sealed partial class SessionArtifactResource
    {
        /// <summary>
        /// The immutable artifact ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type. Always `agent.session.artifact`.<br/>
        /// Default Value: agent.session.artifact
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SessionArtifactResourceObject.AgentSessionArtifact</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionArtifactResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.SessionArtifactResourceObject Object { get; set; } = global::tryAGI.OpenAI.SessionArtifactResourceObject.AgentSessionArtifact;

        /// <summary>
        /// The ID of the session that owns the artifact.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// The ID of the environment that produced the artifact.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EnvironmentId { get; set; }

        /// <summary>
        /// The ID of the completed turn that published the artifact.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TurnId { get; set; }

        /// <summary>
        /// The original absolute file path in the execution environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// The immutable artifact size in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long SizeBytes { get; set; }

        /// <summary>
        /// The Unix timestamp, in seconds, when the artifact was published.
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
        /// Initializes a new instance of the <see cref="SessionArtifactResource" /> class.
        /// </summary>
        /// <param name="id">
        /// The immutable artifact ID.
        /// </param>
        /// <param name="sessionId">
        /// The ID of the session that owns the artifact.
        /// </param>
        /// <param name="environmentId">
        /// The ID of the environment that produced the artifact.
        /// </param>
        /// <param name="turnId">
        /// The ID of the completed turn that published the artifact.
        /// </param>
        /// <param name="path">
        /// The original absolute file path in the execution environment.
        /// </param>
        /// <param name="sizeBytes">
        /// The immutable artifact size in bytes.
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp, in seconds, when the artifact was published.
        /// </param>
        /// <param name="object">
        /// The object type. Always `agent.session.artifact`.<br/>
        /// Default Value: agent.session.artifact
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionArtifactResource(
            string id,
            string sessionId,
            string environmentId,
            string turnId,
            string path,
            long sizeBytes,
            global::System.DateTimeOffset createdAt,
            global::tryAGI.OpenAI.SessionArtifactResourceObject @object = global::tryAGI.OpenAI.SessionArtifactResourceObject.AgentSessionArtifact)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.EnvironmentId = environmentId ?? throw new global::System.ArgumentNullException(nameof(environmentId));
            this.TurnId = turnId ?? throw new global::System.ArgumentNullException(nameof(turnId));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.SizeBytes = sizeBytes;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionArtifactResource" /> class.
        /// </summary>
        public SessionArtifactResource()
        {
        }

    }
}