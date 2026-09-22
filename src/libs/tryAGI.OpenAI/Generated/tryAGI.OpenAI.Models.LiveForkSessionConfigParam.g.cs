
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Overrides for a stored session after connecting to the fork WebSocket. An empty object inherits the stored configuration; do not supply a new model. audio.format applies only to the new WebSocket connection. client overrides are only supported for WebRTC forks.
    /// </summary>
    public sealed partial class LiveForkSessionConfigParam
    {
        /// <summary>
        /// Audio format for a WebSocket fork. WebRTC forks negotiate their audio format and must omit this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::tryAGI.OpenAI.LiveForkAudioParam? Audio { get; set; }

        /// <summary>
        /// Overrides for the stored session’s Responses backend. Only supported when the stored session already uses Responses delegation; the delegation type cannot change.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delegation")]
        public global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParam? Delegation { get; set; }

        /// <summary>
        /// Whether to store the forked session. Omission inherits the stored session's setting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store")]
        public bool? Store { get; set; }

        /// <summary>
        /// Frontend data-channel permissions for a WebRTC fork. Omitted permissions inherit the stored values. Not supported for WebSocket forks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client")]
        public global::tryAGI.OpenAI.LiveClientConfigParam? Client { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveForkSessionConfigParam" /> class.
        /// </summary>
        /// <param name="audio">
        /// Audio format for a WebSocket fork. WebRTC forks negotiate their audio format and must omit this field.
        /// </param>
        /// <param name="delegation">
        /// Overrides for the stored session’s Responses backend. Only supported when the stored session already uses Responses delegation; the delegation type cannot change.
        /// </param>
        /// <param name="store">
        /// Whether to store the forked session. Omission inherits the stored session's setting.
        /// </param>
        /// <param name="client">
        /// Frontend data-channel permissions for a WebRTC fork. Omitted permissions inherit the stored values. Not supported for WebSocket forks.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveForkSessionConfigParam(
            global::tryAGI.OpenAI.LiveForkAudioParam? audio,
            global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParam? delegation,
            bool? store,
            global::tryAGI.OpenAI.LiveClientConfigParam? client)
        {
            this.Audio = audio;
            this.Delegation = delegation;
            this.Store = store;
            this.Client = client;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveForkSessionConfigParam" /> class.
        /// </summary>
        public LiveForkSessionConfigParam()
        {
        }

    }
}