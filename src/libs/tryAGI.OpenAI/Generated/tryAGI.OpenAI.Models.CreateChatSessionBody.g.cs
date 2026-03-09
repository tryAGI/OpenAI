
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Parameters for provisioning a new ChatKit session.
    /// </summary>
    public sealed partial class CreateChatSessionBody
    {
        /// <summary>
        /// Workflow that powers the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.WorkflowParam Workflow { get; set; }

        /// <summary>
        /// A free-form string that identifies your end user; ensures this Session can access other objects that have the same `user` scope.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string User { get; set; }

        /// <summary>
        /// Optional override for session expiration timing in seconds from creation. Defaults to 10 minutes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_after")]
        public global::tryAGI.OpenAI.ExpiresAfterParam? ExpiresAfter { get; set; }

        /// <summary>
        /// Optional override for per-minute request limits. When omitted, defaults to 10.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_limits")]
        public global::tryAGI.OpenAI.RateLimitsParam? RateLimits { get; set; }

        /// <summary>
        /// Optional overrides for ChatKit runtime configuration features
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatkit_configuration")]
        public global::tryAGI.OpenAI.ChatkitConfigurationParam? ChatkitConfiguration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatSessionBody" /> class.
        /// </summary>
        /// <param name="workflow">
        /// Workflow that powers the session.
        /// </param>
        /// <param name="user">
        /// A free-form string that identifies your end user; ensures this Session can access other objects that have the same `user` scope.
        /// </param>
        /// <param name="expiresAfter">
        /// Optional override for session expiration timing in seconds from creation. Defaults to 10 minutes.
        /// </param>
        /// <param name="rateLimits">
        /// Optional override for per-minute request limits. When omitted, defaults to 10.
        /// </param>
        /// <param name="chatkitConfiguration">
        /// Optional overrides for ChatKit runtime configuration features
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateChatSessionBody(
            global::tryAGI.OpenAI.WorkflowParam workflow,
            string user,
            global::tryAGI.OpenAI.ExpiresAfterParam? expiresAfter,
            global::tryAGI.OpenAI.RateLimitsParam? rateLimits,
            global::tryAGI.OpenAI.ChatkitConfigurationParam? chatkitConfiguration)
        {
            this.Workflow = workflow ?? throw new global::System.ArgumentNullException(nameof(workflow));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.ExpiresAfter = expiresAfter;
            this.RateLimits = rateLimits;
            this.ChatkitConfiguration = chatkitConfiguration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatSessionBody" /> class.
        /// </summary>
        public CreateChatSessionBody()
        {
        }
    }
}