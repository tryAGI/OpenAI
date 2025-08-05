
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Occurs when a [message](https://platform.openai.com/docs/api-reference/messages/object) is completed.
    /// </summary>
    public sealed partial class MessageStreamEventVariant4
    {
        /// <summary>
        /// Represents a message within a [thread](https://platform.openai.com/docs/api-reference/threads).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.MessageObject Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.MessageStreamEventVariant4EventJsonConverter))]
        public global::tryAGI.OpenAI.MessageStreamEventVariant4Event Event { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageStreamEventVariant4" /> class.
        /// </summary>
        /// <param name="data">
        /// Represents a message within a [thread](https://platform.openai.com/docs/api-reference/threads).
        /// </param>
        /// <param name="event"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageStreamEventVariant4(
            global::tryAGI.OpenAI.MessageObject data,
            global::tryAGI.OpenAI.MessageStreamEventVariant4Event @event)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageStreamEventVariant4" /> class.
        /// </summary>
        public MessageStreamEventVariant4()
        {
        }
    }
}