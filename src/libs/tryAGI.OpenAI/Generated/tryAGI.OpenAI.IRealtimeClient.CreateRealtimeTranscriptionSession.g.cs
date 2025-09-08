#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IRealtimeClient
    {
        /// <summary>
        /// Create transcription session<br/>
        /// Create an ephemeral API token for use in client-side applications with the<br/>
        /// Realtime API specifically for realtime transcriptions. <br/>
        /// Can be configured with the same session parameters as the `transcription_session.update` client event.<br/>
        /// It responds with a session object, plus a `client_secret` key which contains<br/>
        /// a usable ephemeral API token that can be used to authenticate browser clients<br/>
        /// for the Realtime API.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponse> CreateRealtimeTranscriptionSessionAsync(
            global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create transcription session<br/>
        /// Create an ephemeral API token for use in client-side applications with the<br/>
        /// Realtime API specifically for realtime transcriptions. <br/>
        /// Can be configured with the same session parameters as the `transcription_session.update` client event.<br/>
        /// It responds with a session object, plus a `client_secret` key which contains<br/>
        /// a usable ephemeral API token that can be used to authenticate browser clients<br/>
        /// for the Realtime API.
        /// </summary>
        /// <param name="include">
        /// The set of items to include in the transcription. Current available items are:<br/>
        /// `item.input_audio_transcription.logprobs`
        /// </param>
        /// <param name="inputAudioFormat">
        /// The format of input audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.<br/>
        /// For `pcm16`, input audio must be 16-bit PCM at a 24kHz sample rate,<br/>
        /// single channel (mono), and little-endian byte order.<br/>
        /// Default Value: pcm16
        /// </param>
        /// <param name="inputAudioNoiseReduction">
        /// Configuration for input audio noise reduction. This can be set to `null` to turn off.<br/>
        /// Noise reduction filters audio added to the input audio buffer before it is sent to VAD and the model.<br/>
        /// Filtering the audio can improve VAD and turn detection accuracy (reducing false positives) and model performance by improving perception of the input audio.
        /// </param>
        /// <param name="inputAudioTranscription"></param>
        /// <param name="turnDetection">
        /// Configuration for turn detection. Can be set to `null` to turn off. Server VAD means that the model will detect the start and end of speech based on audio volume and respond at the end of user speech.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponse> CreateRealtimeTranscriptionSessionAsync(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestIncludeItem>? include = default,
            global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestInputAudioFormat? inputAudioFormat = default,
            global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReduction? inputAudioNoiseReduction = default,
            global::tryAGI.OpenAI.AudioTranscription? inputAudioTranscription = default,
            global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestTurnDetection? turnDetection = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}