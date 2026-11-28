
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Occurs when a stream ends.
    /// </summary>
    public sealed partial class DoneEvent
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"done"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        public string Event { get; set; } = "done";

        /// <summary>
        ///
        /// </summary>
        /// <default>"[DONE]"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public string Data { get; set; } = "[DONE]";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DoneEvent" /> class.
        /// </summary>
        /// <param name="event"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DoneEvent(
            string @event = "done",
            string data = "[DONE]")
        {
            this.Event = @event;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DoneEvent" /> class.
        /// </summary>
        public DoneEvent()
        {
        }

    }
}