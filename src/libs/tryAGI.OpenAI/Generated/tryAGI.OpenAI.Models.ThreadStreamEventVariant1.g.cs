
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Occurs when a new [thread](https://developers.openai.com/api/docs/assistants/migration) is created.
    /// </summary>
    public sealed partial class ThreadStreamEventVariant1
    {
        /// <summary>
        /// Whether to enable input audio transcription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"thread.created"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        public string Event { get; set; } = "thread.created";

        /// <summary>
        /// Represents a thread that contains [messages](https://developers.openai.com/api/docs/assistants/migration).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ThreadObject Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadStreamEventVariant1" /> class.
        /// </summary>
        /// <param name="data">
        /// Represents a thread that contains [messages](https://developers.openai.com/api/docs/assistants/migration).
        /// </param>
        /// <param name="enabled">
        /// Whether to enable input audio transcription.
        /// </param>
        /// <param name="event"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThreadStreamEventVariant1(
            global::tryAGI.OpenAI.ThreadObject data,
            bool? enabled,
            string @event = "thread.created")
        {
            this.Enabled = enabled;
            this.Event = @event;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadStreamEventVariant1" /> class.
        /// </summary>
        public ThreadStreamEventVariant1()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ThreadStreamEventVariant1"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ThreadStreamEventVariant1 FromData(global::tryAGI.OpenAI.ThreadObject data)
        {
            return new ThreadStreamEventVariant1
            {
                Data = data,
            };
        }

    }
}