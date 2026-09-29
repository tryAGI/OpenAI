
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A browser origin awaiting the application's approval decision.
    /// </summary>
    public sealed partial class ComputerUseApprovalRequestKindResourceBrowserOriginAccess
    {
        /// <summary>
        /// The type of the object. Always `browser_origin_access`.<br/>
        /// Default Value: browser_origin_access
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccessType.BrowserOriginAccess</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ComputerUseApprovalRequestKindResourceBrowserOriginAccessTypeJsonConverter))]
        public global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccessType Type { get; set; } = global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccessType.BrowserOriginAccess;

        /// <summary>
        /// The browser's explanation for this request, or null when unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// The origin the browser needs permission to access.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Origin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerUseApprovalRequestKindResourceBrowserOriginAccess" /> class.
        /// </summary>
        /// <param name="origin">
        /// The origin the browser needs permission to access.
        /// </param>
        /// <param name="reason">
        /// The browser's explanation for this request, or null when unavailable.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `browser_origin_access`.<br/>
        /// Default Value: browser_origin_access
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComputerUseApprovalRequestKindResourceBrowserOriginAccess(
            string origin,
            string? reason,
            global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccessType type = global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccessType.BrowserOriginAccess)
        {
            this.Type = type;
            this.Reason = reason;
            this.Origin = origin ?? throw new global::System.ArgumentNullException(nameof(origin));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerUseApprovalRequestKindResourceBrowserOriginAccess" /> class.
        /// </summary>
        public ComputerUseApprovalRequestKindResourceBrowserOriginAccess()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ComputerUseApprovalRequestKindResourceBrowserOriginAccess"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ComputerUseApprovalRequestKindResourceBrowserOriginAccess FromOrigin(string origin)
        {
            return new ComputerUseApprovalRequestKindResourceBrowserOriginAccess
            {
                Origin = origin,
            };
        }

    }
}