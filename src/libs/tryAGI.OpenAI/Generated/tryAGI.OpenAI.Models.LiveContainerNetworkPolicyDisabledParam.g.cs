
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveContainerNetworkPolicyDisabledParam
    {
        /// <summary>
        /// Disable outbound network access. Always `disabled`.<br/>
        /// Default Value: disabled
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveContainerNetworkPolicyDisabledParamType.Disabled</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveContainerNetworkPolicyDisabledParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveContainerNetworkPolicyDisabledParamType Type { get; set; } = global::tryAGI.OpenAI.LiveContainerNetworkPolicyDisabledParamType.Disabled;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveContainerNetworkPolicyDisabledParam" /> class.
        /// </summary>
        /// <param name="type">
        /// Disable outbound network access. Always `disabled`.<br/>
        /// Default Value: disabled
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveContainerNetworkPolicyDisabledParam(
            global::tryAGI.OpenAI.LiveContainerNetworkPolicyDisabledParamType type = global::tryAGI.OpenAI.LiveContainerNetworkPolicyDisabledParamType.Disabled)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveContainerNetworkPolicyDisabledParam" /> class.
        /// </summary>
        public LiveContainerNetworkPolicyDisabledParam()
        {
        }

    }
}