
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveHostedShellNetworkPolicyAllowlistParam
    {
        /// <summary>
        /// Allow outbound network access only to specified domains. Always `allowlist`.<br/>
        /// Default Value: allowlist
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveHostedShellNetworkPolicyAllowlistParamType.Allowlist</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveHostedShellNetworkPolicyAllowlistParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveHostedShellNetworkPolicyAllowlistParamType Type { get; set; } = global::tryAGI.OpenAI.LiveHostedShellNetworkPolicyAllowlistParamType.Allowlist;

        /// <summary>
        /// A list of allowed domains when type is `allowlist`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_domains")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AllowedDomains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveHostedShellNetworkPolicyAllowlistParam" /> class.
        /// </summary>
        /// <param name="allowedDomains">
        /// A list of allowed domains when type is `allowlist`.
        /// </param>
        /// <param name="type">
        /// Allow outbound network access only to specified domains. Always `allowlist`.<br/>
        /// Default Value: allowlist
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveHostedShellNetworkPolicyAllowlistParam(
            global::System.Collections.Generic.IList<string> allowedDomains,
            global::tryAGI.OpenAI.LiveHostedShellNetworkPolicyAllowlistParamType type = global::tryAGI.OpenAI.LiveHostedShellNetworkPolicyAllowlistParamType.Allowlist)
        {
            this.Type = type;
            this.AllowedDomains = allowedDomains ?? throw new global::System.ArgumentNullException(nameof(allowedDomains));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveHostedShellNetworkPolicyAllowlistParam" /> class.
        /// </summary>
        public LiveHostedShellNetworkPolicyAllowlistParam()
        {
        }

    }
}