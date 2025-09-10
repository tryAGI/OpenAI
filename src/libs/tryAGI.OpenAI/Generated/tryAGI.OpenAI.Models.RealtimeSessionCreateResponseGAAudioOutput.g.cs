
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeSessionCreateResponseGAAudioOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeAudioFormatsJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeAudioFormats? Format { get; set; }

        /// <summary>
        /// The speed of the model's spoken response as a multiple of the original speed.<br/>
        /// 1.0 is the default speed. 0.25 is the minimum speed. 1.5 is the maximum speed. This value can only be changed in between model turns, not while a response is in progress.<br/>
        /// This parameter is a post-processing adjustment to the audio after it is generated, it's<br/>
        /// also possible to prompt the model to speak faster or slower.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Example: ash
        /// </summary>
        /// <example>ash</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.VoiceIdsSharedJsonConverter))]
        public global::tryAGI.OpenAI.VoiceIdsShared? Voice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateResponseGAAudioOutput" /> class.
        /// </summary>
        /// <param name="format"></param>
        /// <param name="speed">
        /// The speed of the model's spoken response as a multiple of the original speed.<br/>
        /// 1.0 is the default speed. 0.25 is the minimum speed. 1.5 is the maximum speed. This value can only be changed in between model turns, not while a response is in progress.<br/>
        /// This parameter is a post-processing adjustment to the audio after it is generated, it's<br/>
        /// also possible to prompt the model to speak faster or slower.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="voice">
        /// Example: ash
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeSessionCreateResponseGAAudioOutput(
            global::tryAGI.OpenAI.RealtimeAudioFormats? format,
            double? speed,
            global::tryAGI.OpenAI.VoiceIdsShared? voice)
        {
            this.Format = format;
            this.Speed = speed;
            this.Voice = voice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateResponseGAAudioOutput" /> class.
        /// </summary>
        public RealtimeSessionCreateResponseGAAudioOutput()
        {
        }
    }
}