
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The service account API key create request payload.
    /// </summary>
    public sealed partial class CreateProjectServiceAccountApiKeyBody
    {
        /// <summary>
        /// API key name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// API key scopes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectServiceAccountApiKeyBody" /> class.
        /// </summary>
        /// <param name="name">
        /// API key name.
        /// </param>
        /// <param name="scopes">
        /// API key scopes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProjectServiceAccountApiKeyBody(
            string? name,
            global::System.Collections.Generic.IList<string>? scopes)
        {
            this.Name = name;
            this.Scopes = scopes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectServiceAccountApiKeyBody" /> class.
        /// </summary>
        public CreateProjectServiceAccountApiKeyBody()
        {
        }

    }
}