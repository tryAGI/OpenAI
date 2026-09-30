
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Place an outbound SIP call using your provider's trunk. Outbound SIP calling must be enabled for your organization. The trunk must support TLS signaling, Opus audio, and SDES-SRTP media. See [Telephony and SIP](https://developers.openai.com/api/docs/guides/voice-sip?api=live#place-an-outbound-call).
    /// </summary>
    public sealed partial class LiveSIPTransport
    {
        /// <summary>
        /// The transport used for the Live session. Always `sip`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveSIPTransportTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveSIPTransportType Type { get; set; }

        /// <summary>
        /// Phone number to call in E.164 format. SIP URI destinations are not supported.<br/>
        /// Example: +14155550123
        /// </summary>
        /// <example>+14155550123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Destination { get; set; }

        /// <summary>
        /// SIP trunk configuration supplied for this call. Keep trunk credentials on your server. The creation response does not return this configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trunk")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.LiveSIPTrunk Trunk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSIPTransport" /> class.
        /// </summary>
        /// <param name="destination">
        /// Phone number to call in E.164 format. SIP URI destinations are not supported.<br/>
        /// Example: +14155550123
        /// </param>
        /// <param name="trunk">
        /// SIP trunk configuration supplied for this call. Keep trunk credentials on your server. The creation response does not return this configuration.
        /// </param>
        /// <param name="type">
        /// The transport used for the Live session. Always `sip`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveSIPTransport(
            string destination,
            global::tryAGI.OpenAI.LiveSIPTrunk trunk,
            global::tryAGI.OpenAI.LiveSIPTransportType type)
        {
            this.Type = type;
            this.Destination = destination ?? throw new global::System.ArgumentNullException(nameof(destination));
            this.Trunk = trunk ?? throw new global::System.ArgumentNullException(nameof(trunk));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSIPTransport" /> class.
        /// </summary>
        public LiveSIPTransport()
        {
        }

    }
}