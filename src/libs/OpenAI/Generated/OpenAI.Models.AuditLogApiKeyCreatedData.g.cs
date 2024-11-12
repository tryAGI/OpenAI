
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The payload used to create the API key.
    /// </summary>
    public sealed partial class AuditLogApiKeyCreatedData
    {
        /// <summary>
        /// A list of scopes allowed for the API key, e.g. `["api.model.request"]`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogApiKeyCreatedData" /> class.
        /// </summary>
        /// <param name="scopes">
        /// A list of scopes allowed for the API key, e.g. `["api.model.request"]`
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AuditLogApiKeyCreatedData(
            global::System.Collections.Generic.IList<string>? scopes)
        {
            this.Scopes = scopes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogApiKeyCreatedData" /> class.
        /// </summary>
        public AuditLogApiKeyCreatedData()
        {
        }
    }
}