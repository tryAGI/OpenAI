
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Represents a ChatKit session and its resolved configuration.<br/>
    /// Example: {"id":"cksess_123","object":"chatkit.session","client_secret":"ek_token_123","expires_at":1712349876,"workflow":{"id":"workflow_alpha","version":"2024-10-01T00:00:00.000Z"},"user":"user_789","rate_limits":{"max_requests_per_1_minute":60},"max_requests_per_1_minute":60,"status":"cancelled","chatkit_configuration":{"automatic_thread_titling":{"enabled":true},"file_upload":{"enabled":true,"max_file_size":16,"max_files":20},"history":{"enabled":true,"recent_threads":10}}}
    /// </summary>
    public sealed partial class ChatSessionResource
    {
        /// <summary>
        /// Identifier for the ChatKit session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Type discriminator that is always `chatkit.session`.<br/>
        /// Default Value: chatkit.session
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ChatSessionResourceObject.ChatkitSession</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ChatSessionResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.ChatSessionResourceObject Object { get; set; } = global::tryAGI.OpenAI.ChatSessionResourceObject.ChatkitSession;

        /// <summary>
        /// Unix timestamp (in seconds) for when the session expires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset ExpiresAt { get; set; }

        /// <summary>
        /// Ephemeral client secret that authenticates session requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientSecret { get; set; }

        /// <summary>
        /// Workflow metadata for the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ChatkitWorkflow Workflow { get; set; }

        /// <summary>
        /// User identifier associated with the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string User { get; set; }

        /// <summary>
        /// Resolved rate limit values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_limits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ChatSessionRateLimits RateLimits { get; set; }

        /// <summary>
        /// Convenience copy of the per-minute request limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_requests_per_1_minute")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxRequestsPer1Minute { get; set; }

        /// <summary>
        /// Current lifecycle state of the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ChatSessionStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ChatSessionStatus Status { get; set; }

        /// <summary>
        /// Resolved ChatKit feature configuration for the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatkit_configuration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ChatSessionChatkitConfiguration ChatkitConfiguration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSessionResource" /> class.
        /// </summary>
        /// <param name="id">
        /// Identifier for the ChatKit session.
        /// </param>
        /// <param name="expiresAt">
        /// Unix timestamp (in seconds) for when the session expires.
        /// </param>
        /// <param name="clientSecret">
        /// Ephemeral client secret that authenticates session requests.
        /// </param>
        /// <param name="workflow">
        /// Workflow metadata for the session.
        /// </param>
        /// <param name="user">
        /// User identifier associated with the session.
        /// </param>
        /// <param name="rateLimits">
        /// Resolved rate limit values.
        /// </param>
        /// <param name="maxRequestsPer1Minute">
        /// Convenience copy of the per-minute request limit.
        /// </param>
        /// <param name="status">
        /// Current lifecycle state of the session.
        /// </param>
        /// <param name="chatkitConfiguration">
        /// Resolved ChatKit feature configuration for the session.
        /// </param>
        /// <param name="object">
        /// Type discriminator that is always `chatkit.session`.<br/>
        /// Default Value: chatkit.session
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatSessionResource(
            string id,
            global::System.DateTimeOffset expiresAt,
            string clientSecret,
            global::tryAGI.OpenAI.ChatkitWorkflow workflow,
            string user,
            global::tryAGI.OpenAI.ChatSessionRateLimits rateLimits,
            int maxRequestsPer1Minute,
            global::tryAGI.OpenAI.ChatSessionStatus status,
            global::tryAGI.OpenAI.ChatSessionChatkitConfiguration chatkitConfiguration,
            global::tryAGI.OpenAI.ChatSessionResourceObject @object = global::tryAGI.OpenAI.ChatSessionResourceObject.ChatkitSession)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.ExpiresAt = expiresAt;
            this.ClientSecret = clientSecret ?? throw new global::System.ArgumentNullException(nameof(clientSecret));
            this.Workflow = workflow ?? throw new global::System.ArgumentNullException(nameof(workflow));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.RateLimits = rateLimits ?? throw new global::System.ArgumentNullException(nameof(rateLimits));
            this.MaxRequestsPer1Minute = maxRequestsPer1Minute;
            this.Status = status;
            this.ChatkitConfiguration = chatkitConfiguration ?? throw new global::System.ArgumentNullException(nameof(chatkitConfiguration));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSessionResource" /> class.
        /// </summary>
        public ChatSessionResource()
        {
        }
    }
}