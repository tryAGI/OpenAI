
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentSessionEnvironmentPayloadResource
    {
        /// <summary>
        /// The ID of the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The ID of the environment, when one exists.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_id")]
        public string? EnvironmentId { get; set; }

        /// <summary>
        /// The environment type: `none`, `openai_hosted`, or `self_hosted`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EnvironmentType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionEnvironmentPayloadResource" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the session.
        /// </param>
        /// <param name="environmentType">
        /// The environment type: `none`, `openai_hosted`, or `self_hosted`.
        /// </param>
        /// <param name="environmentId">
        /// The ID of the environment, when one exists.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSessionEnvironmentPayloadResource(
            string id,
            string environmentType,
            string? environmentId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.EnvironmentId = environmentId;
            this.EnvironmentType = environmentType ?? throw new global::System.ArgumentNullException(nameof(environmentType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionEnvironmentPayloadResource" /> class.
        /// </summary>
        public AgentSessionEnvironmentPayloadResource()
        {
        }

    }
}