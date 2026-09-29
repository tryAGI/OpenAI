
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ComputerUseApprovalResponseParamBrowserOriginAccessParam
    {
        /// <summary>
        /// Default Value: browser_origin_access
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParamType.BrowserOriginAccess</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalResponseParamBrowserOriginAccessParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParamType Type { get; set; } = global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParamType.BrowserOriginAccess;

        /// <summary>
        /// Whether to allow, deny, or cancel the requested origin access.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decision")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BrowserOriginAccessDecisionParamJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BrowserOriginAccessDecisionParam Decision { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerUseApprovalResponseParamBrowserOriginAccessParam" /> class.
        /// </summary>
        /// <param name="decision">
        /// Whether to allow, deny, or cancel the requested origin access.
        /// </param>
        /// <param name="type">
        /// Default Value: browser_origin_access
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComputerUseApprovalResponseParamBrowserOriginAccessParam(
            global::tryAGI.OpenAI.BrowserOriginAccessDecisionParam decision,
            global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParamType type = global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParamType.BrowserOriginAccess)
        {
            this.Type = type;
            this.Decision = decision;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerUseApprovalResponseParamBrowserOriginAccessParam" /> class.
        /// </summary>
        public ComputerUseApprovalResponseParamBrowserOriginAccessParam()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ComputerUseApprovalResponseParamBrowserOriginAccessParam"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ComputerUseApprovalResponseParamBrowserOriginAccessParam FromDecision(global::tryAGI.OpenAI.BrowserOriginAccessDecisionParam decision)
        {
            return new ComputerUseApprovalResponseParamBrowserOriginAccessParam
            {
                Decision = decision,
            };
        }

    }
}