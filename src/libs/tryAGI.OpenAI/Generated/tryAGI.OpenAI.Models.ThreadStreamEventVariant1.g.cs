
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Occurs when a new [thread](/docs/api-reference/threads/object) is created.
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
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ThreadStreamEventVariant1EventJsonConverter))]
        public global::tryAGI.OpenAI.ThreadStreamEventVariant1Event Event { get; set; }

        /// <summary>
        /// Represents a thread that contains [messages](/docs/api-reference/messages).
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
        /// <param name="enabled">
        /// Whether to enable input audio transcription.
        /// </param>
        /// <param name="event"></param>
        /// <param name="data">
        /// Represents a thread that contains [messages](/docs/api-reference/messages).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThreadStreamEventVariant1(
            global::tryAGI.OpenAI.ThreadObject data,
            bool? enabled,
            global::tryAGI.OpenAI.ThreadStreamEventVariant1Event @event)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Enabled = enabled;
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadStreamEventVariant1" /> class.
        /// </summary>
        public ThreadStreamEventVariant1()
        {
        }
    }
}