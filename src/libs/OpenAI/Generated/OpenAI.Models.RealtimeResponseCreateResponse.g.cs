
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeResponseCreateResponse
    {
        /// <summary>
        /// The modalities for the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modalities")]
        public global::System.Collections.Generic.IList<global::OpenAI.RealtimeResponseCreateResponseModalitie>? Modalities { get; set; }

        /// <summary>
        /// Instructions for the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// The voice the model uses to respond.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.RealtimeResponseCreateResponseVoiceJsonConverter))]
        public global::OpenAI.RealtimeResponseCreateResponseVoice? Voice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_audio_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.RealtimeAudioFormatJsonConverter))]
        public global::OpenAI.RealtimeAudioFormat? OutputAudioFormat { get; set; }

        /// <summary>
        /// Sampling temperature.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Maximum number of output tokens, or "inf" for unlimited. Defaults to "inf".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_tokens")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.OneOfJsonConverterFactory2))]
        public global::OpenAI.OneOf<int?, global::OpenAI.RealtimeResponseCreateResponseMaxOutputTokens?>? MaxOutputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}