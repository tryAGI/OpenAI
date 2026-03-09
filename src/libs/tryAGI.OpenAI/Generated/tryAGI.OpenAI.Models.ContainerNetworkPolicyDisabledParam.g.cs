
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContainerNetworkPolicyDisabledParam
    {
        /// <summary>
        /// Disable outbound network access. Always `disabled`.<br/>
        /// Default Value: disabled
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParamType.Disabled</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ContainerNetworkPolicyDisabledParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParamType Type { get; set; } = global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParamType.Disabled;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerNetworkPolicyDisabledParam" /> class.
        /// </summary>
        /// <param name="type">
        /// Disable outbound network access. Always `disabled`.<br/>
        /// Default Value: disabled
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContainerNetworkPolicyDisabledParam(
            global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParamType type = global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParamType.Disabled)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerNetworkPolicyDisabledParam" /> class.
        /// </summary>
        public ContainerNetworkPolicyDisabledParam()
        {
        }
    }
}