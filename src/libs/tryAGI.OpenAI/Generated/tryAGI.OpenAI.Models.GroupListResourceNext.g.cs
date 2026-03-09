
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Cursor to fetch the next page of results, or `null` if there are no more results.
    /// </summary>
    public sealed partial class GroupListResourceNext
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}