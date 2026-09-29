
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Network access for an OpenAI-hosted environment.
    /// </summary>
    public sealed partial class NetworkPolicyParam
    {
        /// <summary>
        /// The environment's network access mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.NetworkAccessParamJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.NetworkAccessParam Access { get; set; }

        /// <summary>
        /// Domains the environment may access when network access is restricted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_domains")]
        public global::System.Collections.Generic.IList<string>? AllowedDomains { get; set; }

        /// <summary>
        /// Domains blocked for both executor and browser when access is restricted. A nonempty list requires `access: restricted` and cannot be combined with nonempty `allowed_domains`. Wildcard domains are not supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocked_domains")]
        public global::System.Collections.Generic.IList<string>? BlockedDomains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkPolicyParam" /> class.
        /// </summary>
        /// <param name="access">
        /// The environment's network access mode.
        /// </param>
        /// <param name="allowedDomains">
        /// Domains the environment may access when network access is restricted.
        /// </param>
        /// <param name="blockedDomains">
        /// Domains blocked for both executor and browser when access is restricted. A nonempty list requires `access: restricted` and cannot be combined with nonempty `allowed_domains`. Wildcard domains are not supported.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NetworkPolicyParam(
            global::tryAGI.OpenAI.NetworkAccessParam access,
            global::System.Collections.Generic.IList<string>? allowedDomains,
            global::System.Collections.Generic.IList<string>? blockedDomains)
        {
            this.Access = access;
            this.AllowedDomains = allowedDomains;
            this.BlockedDomains = blockedDomains;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkPolicyParam" /> class.
        /// </summary>
        public NetworkPolicyParam()
        {
        }

    }
}