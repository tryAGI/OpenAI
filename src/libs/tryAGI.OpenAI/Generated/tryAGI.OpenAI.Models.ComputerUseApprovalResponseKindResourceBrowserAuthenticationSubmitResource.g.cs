
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResource
    {
        /// <summary>
        /// Default Value: browser_authentication
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceType.BrowserAuthentication</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceTypeJsonConverter))]
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceType Type { get; set; } = global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceType.BrowserAuthentication;

        /// <summary>
        /// Default Value: submit
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceAction.Submit</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceActionJsonConverter))]
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceAction Action { get; set; } = global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceAction.Submit;

        /// <summary>
        /// The chosen sign-in method, or null when no options were offered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selected_option")]
        public string? SelectedOption { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResource" /> class.
        /// </summary>
        /// <param name="selectedOption">
        /// The chosen sign-in method, or null when no options were offered.
        /// </param>
        /// <param name="type">
        /// Default Value: browser_authentication
        /// </param>
        /// <param name="action">
        /// Default Value: submit
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResource(
            string? selectedOption,
            global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceType type = global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceType.BrowserAuthentication,
            global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceAction action = global::tryAGI.OpenAI.ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceAction.Submit)
        {
            this.Type = type;
            this.Action = action;
            this.SelectedOption = selectedOption;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResource" /> class.
        /// </summary>
        public ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResource()
        {
        }

    }
}