
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Custom string key-value pairs attached to the session.
    /// </summary>
    public sealed partial class SessionResourceMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}