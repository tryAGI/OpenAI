
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The payload used to update the API key.
    /// </summary>
    public sealed partial class AuditLogApiKeyUpdatedChangesRequested
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
    }
}