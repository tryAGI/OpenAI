#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IAudioClient
    {
        /// <summary>
        /// Create transcription<br/>
        /// Transcribes audio into the input language.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.CreateTranscriptionResponseJson, global::tryAGI.OpenAI.CreateTranscriptionResponseVerboseJson>> CreateTranscriptionAsync(
            global::tryAGI.OpenAI.CreateTranscriptionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create transcription<br/>
        /// Transcribes audio into the input language.
        /// </summary>
        /// <param name="chunkingStrategy"></param>
        /// <param name="file">
        /// The audio file object (not file name) to transcribe, in one of these formats: flac, mp3, mp4, mpeg, mpga, m4a, ogg, wav, or webm.
        /// </param>
        /// <param name="filename">
        /// The audio file object (not file name) to transcribe, in one of these formats: flac, mp3, mp4, mpeg, mpga, m4a, ogg, wav, or webm.
        /// </param>
        /// <param name="include">
        /// Additional information to include in the transcription response.<br/>
        /// `logprobs` will return the log probabilities of the tokens in the<br/>
        /// response to understand the model's confidence in the transcription.<br/>
        /// `logprobs` only works with response_format set to `json` and only with<br/>
        /// the models `gpt-4o-transcribe` and `gpt-4o-mini-transcribe`.
        /// </param>
        /// <param name="language">
        /// The language of the input audio. Supplying the input language in [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) (e.g. `en`) format will improve accuracy and latency.
        /// </param>
        /// <param name="model">
        /// ID of the model to use. The options are `gpt-4o-transcribe`, `gpt-4o-mini-transcribe`, and `whisper-1` (which is powered by our open source Whisper V2 model).<br/>
        /// Example: gpt-4o-transcribe
        /// </param>
        /// <param name="prompt">
        /// An optional text to guide the model's style or continue a previous audio segment. The [prompt](https://platform.openai.com/docs/guides/speech-to-text#prompting) should match the audio language.
        /// </param>
        /// <param name="responseFormat">
        /// The format of the output, in one of these options: `json`, `text`, `srt`, `verbose_json`, or `vtt`. For `gpt-4o-transcribe` and `gpt-4o-mini-transcribe`, the only supported format is `json`.<br/>
        /// Default Value: json
        /// </param>
        /// <param name="stream">
        /// If set to true, the model response data will be streamed to the client<br/>
        /// as it is generated using [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events#Event_stream_format).<br/>
        /// See the [Streaming section of the Speech-to-Text guide](https://platform.openai.com/docs/guides/speech-to-text?lang=curl#streaming-transcriptions)<br/>
        /// for more information.<br/>
        /// Note: Streaming is not supported for the `whisper-1` model and will be ignored.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="temperature">
        /// The sampling temperature, between 0 and 1. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. If set to 0, the model will use [log probability](https://en.wikipedia.org/wiki/Log_probability) to automatically increase the temperature until certain thresholds are hit.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="timestampGranularities">
        /// The timestamp granularities to populate for this transcription. `response_format` must be set `verbose_json` to use timestamp granularities. Either or both of these options are supported: `word`, or `segment`. Note: There is no additional latency for segment timestamps, but generating word timestamps incurs additional latency.<br/>
        /// Default Value: [segment]
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.CreateTranscriptionResponseJson, global::tryAGI.OpenAI.CreateTranscriptionResponseVerboseJson>> CreateTranscriptionAsync(
            byte[] file,
            string filename,
            global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateTranscriptionRequestModel?> model,
            object? chunkingStrategy = default,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionInclude>? include = default,
            string? language = default,
            string? prompt = default,
            global::tryAGI.OpenAI.AudioResponseFormat? responseFormat = default,
            bool? stream = default,
            double? temperature = default,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateTranscriptionRequestTimestampGranularitie>? timestampGranularities = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}