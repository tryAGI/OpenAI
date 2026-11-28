
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Occurs when a [message](https://developers.openai.com/api/docs/assistants/migration) ends before it is completed.
    /// </summary>
    public sealed partial class MessageStreamEventVariant5
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"thread.message.incomplete"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        public string Event { get; set; } = "thread.message.incomplete";

        /// <summary>
        /// Represents a message within a [thread](https://developers.openai.com/api/docs/assistants/migration).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.MessageObject Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageStreamEventVariant5" /> class.
        /// </summary>
        /// <param name="data">
        /// Represents a message within a [thread](https://developers.openai.com/api/docs/assistants/migration).
        /// </param>
        /// <param name="event"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageStreamEventVariant5(
            global::tryAGI.OpenAI.MessageObject data,
            string @event = "thread.message.incomplete")
        {
            this.Event = @event;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageStreamEventVariant5" /> class.
        /// </summary>
        public MessageStreamEventVariant5()
        {
        }

        /// <summary>
        /// Creates a new <see cref="MessageStreamEventVariant5"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static MessageStreamEventVariant5 FromData(global::tryAGI.OpenAI.MessageObject data)
        {
            return new MessageStreamEventVariant5
            {
                Data = data,
            };
        }

    }
}