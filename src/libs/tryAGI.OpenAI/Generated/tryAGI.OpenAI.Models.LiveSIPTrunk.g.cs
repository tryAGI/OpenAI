
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// SIP trunk configuration supplied for this call. Keep trunk credentials on your server. The creation response does not return this configuration.
    /// </summary>
    public sealed partial class LiveSIPTrunk
    {
        /// <summary>
        /// Provider endpoint in the form `sips:host[:port][;transport=tcp]`. The default port is 5061. IPv6 addresses must be bracketed. TLS signaling is required; plaintext SIP is not supported. Do not include userinfo, a path, URI headers, or other URI parameters. Local hostnames and literal private, loopback, link-local, unspecified, multicast, and broadcast IP addresses are rejected.<br/>
        /// Example: sips:sip.example.com:5061
        /// </summary>
        /// <example>sips:sip.example.com:5061</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderUrl { get; set; }

        /// <summary>
        /// Credentials for SIP Digest authentication with your trunk provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.LiveSIPTrunkAuth Auth { get; set; }

        /// <summary>
        /// Caller phone number in E.164 format to use in the SIP From header.<br/>
        /// Example: +14155550100
        /// </summary>
        /// <example>+14155550100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("caller_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallerNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSIPTrunk" /> class.
        /// </summary>
        /// <param name="providerUrl">
        /// Provider endpoint in the form `sips:host[:port][;transport=tcp]`. The default port is 5061. IPv6 addresses must be bracketed. TLS signaling is required; plaintext SIP is not supported. Do not include userinfo, a path, URI headers, or other URI parameters. Local hostnames and literal private, loopback, link-local, unspecified, multicast, and broadcast IP addresses are rejected.<br/>
        /// Example: sips:sip.example.com:5061
        /// </param>
        /// <param name="auth">
        /// Credentials for SIP Digest authentication with your trunk provider.
        /// </param>
        /// <param name="callerNumber">
        /// Caller phone number in E.164 format to use in the SIP From header.<br/>
        /// Example: +14155550100
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveSIPTrunk(
            string providerUrl,
            global::tryAGI.OpenAI.LiveSIPTrunkAuth auth,
            string callerNumber)
        {
            this.ProviderUrl = providerUrl ?? throw new global::System.ArgumentNullException(nameof(providerUrl));
            this.Auth = auth ?? throw new global::System.ArgumentNullException(nameof(auth));
            this.CallerNumber = callerNumber ?? throw new global::System.ArgumentNullException(nameof(callerNumber));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSIPTrunk" /> class.
        /// </summary>
        public LiveSIPTrunk()
        {
        }

    }
}