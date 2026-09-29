
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A registered form awaiting the application's response.
    /// </summary>
    public sealed partial class BrowserAuthenticationHistoryRequestKindResourceBrowserAuthentication
    {
        /// <summary>
        /// The type of the object. Always `browser_authentication`.<br/>
        /// Default Value: browser_authentication
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceBrowserAuthenticationType.BrowserAuthentication</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BrowserAuthenticationHistoryRequestKindResourceBrowserAuthenticationTypeJsonConverter))]
        public global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceBrowserAuthenticationType Type { get; set; } = global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceBrowserAuthenticationType.BrowserAuthentication;

        /// <summary>
        /// Why the agent needs the user to sign in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// The registered form or frame origin where values will be entered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credential_origin")]
        public string? CredentialOrigin { get; set; }

        /// <summary>
        /// Controls to render. All submitted values are sensitive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BrowserAuthenticationFieldResource> Fields { get; set; }

        /// <summary>
        /// Sign-in methods. Empty for a plain form.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BrowserAuthenticationOptionResource> Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserAuthenticationHistoryRequestKindResourceBrowserAuthentication" /> class.
        /// </summary>
        /// <param name="fields">
        /// Controls to render. All submitted values are sensitive.
        /// </param>
        /// <param name="options">
        /// Sign-in methods. Empty for a plain form.
        /// </param>
        /// <param name="reason">
        /// Why the agent needs the user to sign in.
        /// </param>
        /// <param name="credentialOrigin">
        /// The registered form or frame origin where values will be entered.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `browser_authentication`.<br/>
        /// Default Value: browser_authentication
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BrowserAuthenticationHistoryRequestKindResourceBrowserAuthentication(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BrowserAuthenticationFieldResource> fields,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BrowserAuthenticationOptionResource> options,
            string? reason,
            string? credentialOrigin,
            global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceBrowserAuthenticationType type = global::tryAGI.OpenAI.BrowserAuthenticationHistoryRequestKindResourceBrowserAuthenticationType.BrowserAuthentication)
        {
            this.Type = type;
            this.Reason = reason;
            this.CredentialOrigin = credentialOrigin;
            this.Fields = fields ?? throw new global::System.ArgumentNullException(nameof(fields));
            this.Options = options ?? throw new global::System.ArgumentNullException(nameof(options));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserAuthenticationHistoryRequestKindResourceBrowserAuthentication" /> class.
        /// </summary>
        public BrowserAuthenticationHistoryRequestKindResourceBrowserAuthentication()
        {
        }

    }
}