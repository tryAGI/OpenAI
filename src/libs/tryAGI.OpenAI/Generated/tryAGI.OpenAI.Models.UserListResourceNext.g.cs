
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Cursor to fetch the next page of results, or `null` when no further users are available.
    /// </summary>
    public sealed partial class UserListResourceNext
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}