
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaContainerNetworkPolicyDisabledParam
    {
        /// <summary>
        /// Disable outbound network access. Always `disabled`.<br/>
        /// Default Value: disabled
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParamType.Disabled</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaContainerNetworkPolicyDisabledParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParamType Type { get; set; } = global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParamType.Disabled;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaContainerNetworkPolicyDisabledParam" /> class.
        /// </summary>
        /// <param name="type">
        /// Disable outbound network access. Always `disabled`.<br/>
        /// Default Value: disabled
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaContainerNetworkPolicyDisabledParam(
            global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParamType type = global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParamType.Disabled)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaContainerNetworkPolicyDisabledParam" /> class.
        /// </summary>
        public BetaContainerNetworkPolicyDisabledParam()
        {
        }

    }
}