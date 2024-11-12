
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeConversationItemContentItem
    {
        /// <summary>
        /// The content type.<br/>
        /// Example: input_text
        /// </summary>
        /// <example>input_text</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.RealtimeConversationItemContentItemTypeJsonConverter))]
        public global::OpenAI.RealtimeConversationItemContentItemType? Type { get; set; }

        /// <summary>
        /// The text content (for text or input_text items).<br/>
        /// Example: Hello, how are you?
        /// </summary>
        /// <example>Hello, how are you?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Base64-encoded audio bytes (for audio or input_audio items).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public string? Audio { get; set; }

        /// <summary>
        /// The transcript of the audio (for audio items).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// The ID of the function call (for function_call items).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        public string? CallId { get; set; }

        /// <summary>
        /// The name of the function being called (for function_call items).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The arguments of the function call (for function_call items).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public string? Arguments { get; set; }

        /// <summary>
        /// The output of the function call (for function_call_output items).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public string? Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationItemContentItem" /> class.
        /// </summary>
        /// <param name="type">
        /// The content type.<br/>
        /// Example: input_text
        /// </param>
        /// <param name="text">
        /// The text content (for text or input_text items).<br/>
        /// Example: Hello, how are you?
        /// </param>
        /// <param name="audio">
        /// Base64-encoded audio bytes (for audio or input_audio items).
        /// </param>
        /// <param name="transcript">
        /// The transcript of the audio (for audio items).
        /// </param>
        /// <param name="callId">
        /// The ID of the function call (for function_call items).
        /// </param>
        /// <param name="name">
        /// The name of the function being called (for function_call items).
        /// </param>
        /// <param name="arguments">
        /// The arguments of the function call (for function_call items).
        /// </param>
        /// <param name="output">
        /// The output of the function call (for function_call_output items).
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RealtimeConversationItemContentItem(
            global::OpenAI.RealtimeConversationItemContentItemType? type,
            string? text,
            string? audio,
            string? transcript,
            string? callId,
            string? name,
            string? arguments,
            string? output)
        {
            this.Type = type;
            this.Text = text;
            this.Audio = audio;
            this.Transcript = transcript;
            this.CallId = callId;
            this.Name = name;
            this.Arguments = arguments;
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationItemContentItem" /> class.
        /// </summary>
        public RealtimeConversationItemContentItem()
        {
        }
    }
}