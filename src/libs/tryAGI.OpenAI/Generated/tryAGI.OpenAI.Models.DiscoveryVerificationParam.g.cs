
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DiscoveryVerificationParam
    {
        /// <summary>
        /// Default Value: discovery
        /// </summary>
        /// <default>global::tryAGI.OpenAI.DiscoveryVerificationParamType.Discovery</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DiscoveryVerificationParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.DiscoveryVerificationParamType Type { get; set; } = global::tryAGI.OpenAI.DiscoveryVerificationParamType.Discovery;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discovery_url")]
        public string? DiscoveryUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoveryVerificationParam" /> class.
        /// </summary>
        /// <param name="discoveryUrl"></param>
        /// <param name="type">
        /// Default Value: discovery
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DiscoveryVerificationParam(
            string? discoveryUrl,
            global::tryAGI.OpenAI.DiscoveryVerificationParamType type = global::tryAGI.OpenAI.DiscoveryVerificationParamType.Discovery)
        {
            this.Type = type;
            this.DiscoveryUrl = discoveryUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoveryVerificationParam" /> class.
        /// </summary>
        public DiscoveryVerificationParam()
        {
        }

    }
}