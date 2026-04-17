
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeResponseAudioOutput
    {
        /// <summary>
        /// The format of the output audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeAudioFormatsJsonConverter))]
        public global::tryAGI.OpenAI.Realtime.RealtimeAudioFormats? Format { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.VoiceIdsSharedJsonConverter))]
        public global::tryAGI.OpenAI.Realtime.VoiceIdsShared? Voice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseAudioOutput" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeResponseAudioOutput(
            global::tryAGI.OpenAI.Realtime.RealtimeAudioFormats? format,
            global::tryAGI.OpenAI.Realtime.VoiceIdsShared? voice)
        {
            this.Format = format;
            this.Voice = voice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseAudioOutput" /> class.
        /// </summary>
        public RealtimeResponseAudioOutput()
        {
        }
    }
}