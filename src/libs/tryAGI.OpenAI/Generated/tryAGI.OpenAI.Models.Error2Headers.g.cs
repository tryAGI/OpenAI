
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Headers returned with the original error. These can include Retry-After, Retry-After-Ms, and, on opted-in deployments, x-openai-inference-capacity-reason.
    /// </summary>
    public sealed partial class Error2Headers
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}