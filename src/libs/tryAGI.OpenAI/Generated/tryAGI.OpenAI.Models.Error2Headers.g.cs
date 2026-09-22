
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The Retry-After and Retry-After-Ms headers returned with the original error, if any.
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