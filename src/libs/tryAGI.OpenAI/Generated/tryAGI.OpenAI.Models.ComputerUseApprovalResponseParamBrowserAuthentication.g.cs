
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonPolymorphic(
        TypeDiscriminatorPropertyName = "action",
        IgnoreUnrecognizedTypeDiscriminators = true,
        UnknownDerivedTypeHandling = global::System.Text.Json.Serialization.JsonUnknownDerivedTypeHandling.FallBackToBaseType)]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParam), typeDiscriminator: "cancel")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParam), typeDiscriminator: "submit")]
    public partial class ComputerUseApprovalResponseParamBrowserAuthentication
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalResponseParamBrowserAuthenticationTypeJsonConverter))]
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerUseApprovalResponseParamBrowserAuthentication" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComputerUseApprovalResponseParamBrowserAuthentication(
            global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerUseApprovalResponseParamBrowserAuthentication" /> class.
        /// </summary>
        public ComputerUseApprovalResponseParamBrowserAuthentication()
        {
        }

    }
}