
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Starts inference when microphone speech is detected.
    /// </summary>
    public sealed partial class LiveSpeechWakePolicyParam
    {
        /// <summary>
        /// The wake policy type, always `speech`.<br/>
        /// Default Value: speech
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveSpeechWakePolicyParamType.Speech</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveSpeechWakePolicyParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveSpeechWakePolicyParamType Type { get; set; } = global::tryAGI.OpenAI.LiveSpeechWakePolicyParamType.Speech;

        /// <summary>
        /// The speech detection threshold for the first wake and each later wake, from 0 to 1 inclusive. Defaults to 0.5. Higher values require stronger evidence of speech. This setting is independent of active turn detection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vad_threshold")]
        public double? VadThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSpeechWakePolicyParam" /> class.
        /// </summary>
        /// <param name="vadThreshold">
        /// The speech detection threshold for the first wake and each later wake, from 0 to 1 inclusive. Defaults to 0.5. Higher values require stronger evidence of speech. This setting is independent of active turn detection.
        /// </param>
        /// <param name="type">
        /// The wake policy type, always `speech`.<br/>
        /// Default Value: speech
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveSpeechWakePolicyParam(
            double? vadThreshold,
            global::tryAGI.OpenAI.LiveSpeechWakePolicyParamType type = global::tryAGI.OpenAI.LiveSpeechWakePolicyParamType.Speech)
        {
            this.Type = type;
            this.VadThreshold = vadThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSpeechWakePolicyParam" /> class.
        /// </summary>
        public LiveSpeechWakePolicyParam()
        {
        }

    }
}