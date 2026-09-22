
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Add an input item to the Live session’s Responses backend. Requires Responses delegation; use `response.create` to request a response.<br/>
    /// Example: {"type":"response.item.create","event_id":"evt_item_001","item":{"type":"message","role":"user","content":[{"type":"input_text","text":"Please check for a table for two at 7 PM."}]}}
    /// </summary>
    public sealed partial class LiveResponseItemCreateParam
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The Live client event type. Always `response.item.create`.<br/>
        /// Default Value: response.item.create
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveResponseItemCreateParamType.ResponseItemCreate</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveResponseItemCreateParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveResponseItemCreateParamType Type { get; set; } = global::tryAGI.OpenAI.LiveResponseItemCreateParamType.ResponseItemCreate;

        /// <summary>
        /// An input item to append to the Responses backend conversation, such as a user message or a function tool result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.InputItemJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.InputItem Item { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveResponseItemCreateParam" /> class.
        /// </summary>
        /// <param name="item">
        /// An input item to append to the Responses backend conversation, such as a user message or a function tool result.
        /// </param>
        /// <param name="eventId"></param>
        /// <param name="type">
        /// The Live client event type. Always `response.item.create`.<br/>
        /// Default Value: response.item.create
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveResponseItemCreateParam(
            global::tryAGI.OpenAI.InputItem item,
            string? eventId,
            global::tryAGI.OpenAI.LiveResponseItemCreateParamType type = global::tryAGI.OpenAI.LiveResponseItemCreateParamType.ResponseItemCreate)
        {
            this.EventId = eventId;
            this.Type = type;
            this.Item = item;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveResponseItemCreateParam" /> class.
        /// </summary>
        public LiveResponseItemCreateParam()
        {
        }

    }
}