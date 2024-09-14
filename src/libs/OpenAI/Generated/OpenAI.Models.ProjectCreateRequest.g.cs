
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectCreateRequest
    {
        /// <summary>
        /// The friendly name of the project, this name appears in reports.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A description of your business, project, or use case. [Why we need this information](https://help.openai.com/en/articles/9824607-api-platform-verifications).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_use_case")]
        public string? AppUseCase { get; set; }

        /// <summary>
        /// Your business URL, or if you don't have one yet, a URL to your LinkedIn or other social media. [Why we need this information](https://help.openai.com/en/articles/9824607-api-platform-verifications).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("business_website")]
        public string? BusinessWebsite { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}