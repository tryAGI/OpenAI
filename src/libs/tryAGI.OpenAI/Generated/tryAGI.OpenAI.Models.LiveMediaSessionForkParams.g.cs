
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Optional overrides for a stored Live session. Omitted settings are inherited. The model, voice, frontend instructions, and prior conversation come from the stored session. WebRTC negotiates its audio format; audio.format is only supported on WebSocket forks.
    /// </summary>
    public sealed partial class LiveMediaSessionForkParams
    {
        /// <summary>
        /// Whether to store the forked session. Omission inherits the stored session's setting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store")]
        public bool? Store { get; set; }

        /// <summary>
        /// Update the Responses backend for an existing Live session without changing delegation ownership.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delegation")]
        public global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParam? Delegation { get; set; }

        /// <summary>
        /// Startup-only capabilities for an untrusted frontend attached to a unified WebRTC session. Trusted sideband connections are unaffected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client")]
        public global::tryAGI.OpenAI.LiveClientConfigParam? Client { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveMediaSessionForkParams" /> class.
        /// </summary>
        /// <param name="store">
        /// Whether to store the forked session. Omission inherits the stored session's setting.
        /// </param>
        /// <param name="delegation">
        /// Update the Responses backend for an existing Live session without changing delegation ownership.
        /// </param>
        /// <param name="client">
        /// Startup-only capabilities for an untrusted frontend attached to a unified WebRTC session. Trusted sideband connections are unaffected.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveMediaSessionForkParams(
            bool? store,
            global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParam? delegation,
            global::tryAGI.OpenAI.LiveClientConfigParam? client)
        {
            this.Store = store;
            this.Delegation = delegation;
            this.Client = client;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveMediaSessionForkParams" /> class.
        /// </summary>
        public LiveMediaSessionForkParams()
        {
        }

    }
}