
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A new Realtime transcription session configuration.<br/>
    /// When a session is created on the server via REST API, the session object<br/>
    /// also contains an ephemeral key. Default TTL for keys is 10 minutes. This <br/>
    /// property is not present when a session is updated via the WebSocket API.
    /// </summary>
    public sealed partial class RealtimeTranscriptionSessionCreateResponse
    {
        /// <summary>
        /// Ephemeral key returned by the API. Only present when the session is<br/>
        /// created on the server via REST API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseClientSecret ClientSecret { get; set; }

        /// <summary>
        /// The format of input audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio_format")]
        public string? InputAudioFormat { get; set; }

        /// <summary>
        /// Configuration of the transcription model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio_transcription")]
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseInputAudioTranscription? InputAudioTranscription { get; set; }

        /// <summary>
        /// The set of modalities the model can respond with. To disable audio,<br/>
        /// set this to ["text"].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modalities")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseModalitie>? Modalities { get; set; }

        /// <summary>
        /// Configuration for turn detection. Can be set to `null` to turn off. Server <br/>
        /// VAD means that the model will detect the start and end of speech based on <br/>
        /// audio volume and respond at the end of user speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_detection")]
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseTurnDetection? TurnDetection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreateResponse" /> class.
        /// </summary>
        /// <param name="clientSecret">
        /// Ephemeral key returned by the API. Only present when the session is<br/>
        /// created on the server via REST API.
        /// </param>
        /// <param name="inputAudioFormat">
        /// The format of input audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.
        /// </param>
        /// <param name="inputAudioTranscription">
        /// Configuration of the transcription model.
        /// </param>
        /// <param name="modalities">
        /// The set of modalities the model can respond with. To disable audio,<br/>
        /// set this to ["text"].
        /// </param>
        /// <param name="turnDetection">
        /// Configuration for turn detection. Can be set to `null` to turn off. Server <br/>
        /// VAD means that the model will detect the start and end of speech based on <br/>
        /// audio volume and respond at the end of user speech.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranscriptionSessionCreateResponse(
            global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseClientSecret clientSecret,
            string? inputAudioFormat,
            global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseInputAudioTranscription? inputAudioTranscription,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseModalitie>? modalities,
            global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseTurnDetection? turnDetection)
        {
            this.ClientSecret = clientSecret ?? throw new global::System.ArgumentNullException(nameof(clientSecret));
            this.InputAudioFormat = inputAudioFormat;
            this.InputAudioTranscription = inputAudioTranscription;
            this.Modalities = modalities;
            this.TurnDetection = turnDetection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreateResponse" /> class.
        /// </summary>
        public RealtimeTranscriptionSessionCreateResponse()
        {
        }
    }
}