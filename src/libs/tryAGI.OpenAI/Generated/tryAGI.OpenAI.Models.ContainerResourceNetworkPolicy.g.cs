
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Network access policy for the container.
    /// </summary>
    public sealed partial class ContainerResourceNetworkPolicy
    {
        /// <summary>
        /// The network policy mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ContainerResourceNetworkPolicyTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ContainerResourceNetworkPolicyType Type { get; set; }

        /// <summary>
        /// Allowed outbound domains when `type` is `allowlist`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_domains")]
        public global::System.Collections.Generic.IList<string>? AllowedDomains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerResourceNetworkPolicy" /> class.
        /// </summary>
        /// <param name="type">
        /// The network policy mode.
        /// </param>
        /// <param name="allowedDomains">
        /// Allowed outbound domains when `type` is `allowlist`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContainerResourceNetworkPolicy(
            global::tryAGI.OpenAI.ContainerResourceNetworkPolicyType type,
            global::System.Collections.Generic.IList<string>? allowedDomains)
        {
            this.Type = type;
            this.AllowedDomains = allowedDomains;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerResourceNetworkPolicy" /> class.
        /// </summary>
        public ContainerResourceNetworkPolicy()
        {
        }
    }
}