
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The nested Responses streaming event. Dispatch on its type field. Response lifecycle snapshots omit input and clear instructions, tools, and output to keep messages small; consume granular output events for the generated content.
    /// </summary>
    public sealed partial class LiveResponseEventEvent
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}