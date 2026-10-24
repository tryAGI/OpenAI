
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Initial configuration for a Live session, including its model, conversation instructions, audio, and delegated task handling.
    /// </summary>
    public sealed partial class LiveSessionCreateParams
    {
        /// <summary>
        /// The Live model. Required in the session configuration for every transport; do not pass it as a URL query parameter.<br/>
        /// Example: gpt-live-1
        /// </summary>
        /// <example>gpt-live-1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ModelIdsLiveJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ModelIdsLive Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Ordered text-only history supplied before startup. Supports developer, user, and assistant messages with one text part each; at most 128 messages and a configured rendered-token limit (8,192 by default).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveInitialItem>? Input { get; set; }

        /// <summary>
        /// Startup audio configuration. Only primary WebSockets accept audio.format; WebRTC and SIP negotiate their media format. Voice and format are immutable after startup.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::tryAGI.OpenAI.LiveInitialSessionAudioParam? Audio { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delegation")]
        public global::tryAGI.OpenAI.DelegationVariant12? Delegation { get; set; }

        /// <summary>
        /// At most one Decisions trigger per transcript event type. Triggers run independently of delegation. On update, omit triggers to keep the current configuration, send a list to replace it, or send an empty list to disable triggers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggers")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveDecisionTriggerInputParam>? Triggers { get; set; }

        /// <summary>
        /// Whether to store the session for later forking and recording download. Defaults to false for new sessions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store")]
        public bool? Store { get; set; }

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
        /// Initializes a new instance of the <see cref="LiveSessionCreateParams" /> class.
        /// </summary>
        /// <param name="model">
        /// The Live model. Required in the session configuration for every transport; do not pass it as a URL query parameter.<br/>
        /// Example: gpt-live-1
        /// </param>
        /// <param name="instructions"></param>
        /// <param name="input">
        /// Ordered text-only history supplied before startup. Supports developer, user, and assistant messages with one text part each; at most 128 messages and a configured rendered-token limit (8,192 by default).
        /// </param>
        /// <param name="audio">
        /// Startup audio configuration. Only primary WebSockets accept audio.format; WebRTC and SIP negotiate their media format. Voice and format are immutable after startup.
        /// </param>
        /// <param name="delegation"></param>
        /// <param name="triggers">
        /// At most one Decisions trigger per transcript event type. Triggers run independently of delegation. On update, omit triggers to keep the current configuration, send a list to replace it, or send an empty list to disable triggers.
        /// </param>
        /// <param name="store">
        /// Whether to store the session for later forking and recording download. Defaults to false for new sessions.
        /// </param>
        /// <param name="client">
        /// Startup-only capabilities for an untrusted frontend attached to a unified WebRTC session. Trusted sideband connections are unaffected.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveSessionCreateParams(
            global::tryAGI.OpenAI.ModelIdsLive model,
            string? instructions,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveInitialItem>? input,
            global::tryAGI.OpenAI.LiveInitialSessionAudioParam? audio,
            global::tryAGI.OpenAI.DelegationVariant12? delegation,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveDecisionTriggerInputParam>? triggers,
            bool? store,
            global::tryAGI.OpenAI.LiveClientConfigParam? client)
        {
            this.Model = model;
            this.Instructions = instructions;
            this.Input = input;
            this.Audio = audio;
            this.Delegation = delegation;
            this.Triggers = triggers;
            this.Store = store;
            this.Client = client;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSessionCreateParams" /> class.
        /// </summary>
        public LiveSessionCreateParams()
        {
        }

    }
}