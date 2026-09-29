
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ComputerUseApprovalResponseParamBrowserAuthenticationCancelParam
    {
        /// <summary>
        /// Default Value: browser_authentication
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamType.BrowserAuthentication</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamType Type { get; set; } = global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamType.BrowserAuthentication;

        /// <summary>
        /// Default Value: cancel
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamAction.Cancel</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamActionJsonConverter))]
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamAction Action { get; set; } = global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamAction.Cancel;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerUseApprovalResponseParamBrowserAuthenticationCancelParam" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: browser_authentication
        /// </param>
        /// <param name="action">
        /// Default Value: cancel
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComputerUseApprovalResponseParamBrowserAuthenticationCancelParam(
            global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamType type = global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamType.BrowserAuthentication,
            global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamAction action = global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamAction.Cancel)
        {
            this.Type = type;
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerUseApprovalResponseParamBrowserAuthenticationCancelParam" /> class.
        /// </summary>
        public ComputerUseApprovalResponseParamBrowserAuthenticationCancelParam()
        {
        }

    }
}