
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParam
    {
        /// <summary>
        /// Default Value: browser_authentication
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamType.BrowserAuthentication</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamType Type { get; set; } = global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamType.BrowserAuthentication;

        /// <summary>
        /// Default Value: submit
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamAction.Submit</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamActionJsonConverter))]
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamAction Action { get; set; } = global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamAction.Submit;

        /// <summary>
        /// Values for up to six active fields in the required action. The submitted field-value mapping and selected option must fit within 120 KiB of JSON.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BrowserAuthenticationFieldValueParam> Fields { get; set; }

        /// <summary>
        /// The chosen method. Required when the required action contains options.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selected_option")]
        public string? SelectedOption { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParam" /> class.
        /// </summary>
        /// <param name="fields">
        /// Values for up to six active fields in the required action. The submitted field-value mapping and selected option must fit within 120 KiB of JSON.
        /// </param>
        /// <param name="selectedOption">
        /// The chosen method. Required when the required action contains options.
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
        public ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParam(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BrowserAuthenticationFieldValueParam> fields,
            string? selectedOption,
            global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamType type = global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamType.BrowserAuthentication,
            global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamAction action = global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamAction.Submit)
        {
            this.Type = type;
            this.Action = action;
            this.Fields = fields ?? throw new global::System.ArgumentNullException(nameof(fields));
            this.SelectedOption = selectedOption;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParam" /> class.
        /// </summary>
        public ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParam()
        {
        }

    }
}