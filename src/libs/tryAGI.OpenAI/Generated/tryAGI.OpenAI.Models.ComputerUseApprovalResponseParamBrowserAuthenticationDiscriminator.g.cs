
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ComputerUseApprovalResponseParamBrowserAuthenticationDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalResponseParamBrowserAuthenticationDiscriminatorActionJsonConverter))]
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationDiscriminatorAction? Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerUseApprovalResponseParamBrowserAuthenticationDiscriminator" /> class.
        /// </summary>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComputerUseApprovalResponseParamBrowserAuthenticationDiscriminator(
            global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthenticationDiscriminatorAction? action)
        {
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerUseApprovalResponseParamBrowserAuthenticationDiscriminator" /> class.
        /// </summary>
        public ComputerUseApprovalResponseParamBrowserAuthenticationDiscriminator()
        {
        }

    }
}