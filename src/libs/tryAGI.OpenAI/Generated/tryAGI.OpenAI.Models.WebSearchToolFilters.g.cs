
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Filters for the search.
    /// </summary>
    public sealed partial class WebSearchToolFilters
    {
        /// <summary>
        /// Allowed domains for the search. If not provided, all domains are allowed.<br/>
        /// Subdomains of the provided domains are allowed as well.<br/>
        /// Example: `["pubmed.ncbi.nlm.nih.gov"]`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_domains")]
        public global::System.Collections.Generic.IList<string>? AllowedDomains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchToolFilters" /> class.
        /// </summary>
        /// <param name="allowedDomains">
        /// Allowed domains for the search. If not provided, all domains are allowed.<br/>
        /// Subdomains of the provided domains are allowed as well.<br/>
        /// Example: `["pubmed.ncbi.nlm.nih.gov"]`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchToolFilters(
            global::System.Collections.Generic.IList<string>? allowedDomains)
        {
            this.AllowedDomains = allowedDomains;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchToolFilters" /> class.
        /// </summary>
        public WebSearchToolFilters()
        {
        }
    }
}