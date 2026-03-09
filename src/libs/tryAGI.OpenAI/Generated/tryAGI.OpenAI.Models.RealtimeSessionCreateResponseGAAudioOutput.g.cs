
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeSessionCreateResponseGAAudioOutput
    {
        /// <summary>
        /// The format of the output audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeAudioFormatsJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeAudioFormats? Format { get; set; }

        /// <summary>
        /// The voice the model uses to respond. Voice cannot be changed during the<br/>
        /// session once the model has responded with audio at least once. Current<br/>
        /// voice options are `alloy`, `ash`, `ballad`, `coral`, `echo`, `sage`,<br/>
        /// `shimmer`, `verse`, `marin`, and `cedar`. We recommend `marin` and `cedar` for<br/>
        /// best quality.<br/>
        /// Default Value: alloy<br/>
        /// Example: ash
        /// </summary>
        /// <example>ash</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.VoiceIdsSharedJsonConverter))]
        public global::tryAGI.OpenAI.VoiceIdsShared? Voice { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateResponseGAAudioOutput" /> class.
        /// </summary>
        /// <param name="format">
        /// The format of the output audio.
        /// </param>
        /// <param name="voice">
        /// The voice the model uses to respond. Voice cannot be changed during the<br/>
        /// session once the model has responded with audio at least once. Current<br/>
        /// voice options are `alloy`, `ash`, `ballad`, `coral`, `echo`, `sage`,<br/>
        /// `shimmer`, `verse`, `marin`, and `cedar`. We recommend `marin` and `cedar` for<br/>
        /// best quality.<br/>
        /// Default Value: alloy<br/>
        /// Example: ash
        /// </param>
        /// <param name="speed">
        /// The speed of the model's spoken response as a multiple of the original speed.<br/>
        /// 1.0 is the default speed. 0.25 is the minimum speed. 1.5 is the maximum speed. This value can only be changed in between model turns, not while a response is in progress.<br/>
        /// This parameter is a post-processing adjustment to the audio after it is generated, it's<br/>
        /// also possible to prompt the model to speak faster or slower.<br/>
        /// Default Value: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeSessionCreateResponseGAAudioOutput(
            global::tryAGI.OpenAI.RealtimeAudioFormats? format,
            global::tryAGI.OpenAI.VoiceIdsShared? voice,
            double? speed)
        {
            this.Format = format;
            this.Voice = voice;
            this.Speed = speed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateResponseGAAudioOutput" /> class.
        /// </summary>
        public RealtimeSessionCreateResponseGAAudioOutput()
        {
        }
    }
}