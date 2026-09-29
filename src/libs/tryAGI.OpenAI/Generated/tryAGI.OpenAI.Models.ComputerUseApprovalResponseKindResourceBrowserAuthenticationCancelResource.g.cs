
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResource
    {
        /// <summary>
        /// Default Value: browser_authentication
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceType.BrowserAuthentication</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceTypeJsonConverter))]
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceType Type { get; set; } = global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceType.BrowserAuthentication;

        /// <summary>
        /// Default Value: cancel
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceAction.Cancel</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceActionJsonConverter))]
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceAction Action { get; set; } = global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceAction.Cancel;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResource" /> class.
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
        public ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResource(
            global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceType type = global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceType.BrowserAuthentication,
            global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceAction action = global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceAction.Cancel)
        {
            this.Type = type;
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResource" /> class.
        /// </summary>
        public ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResource()
        {
        }

    }
}