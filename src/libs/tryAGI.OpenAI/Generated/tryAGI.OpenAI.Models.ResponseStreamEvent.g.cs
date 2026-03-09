#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResponseStreamEvent : global::System.IEquatable<ResponseStreamEvent>
    {
        /// <summary>
        /// Emitted when there is a partial audio response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseAudioDeltaEvent? ResponseAudioDelta { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseAudioDeltaEvent? ResponseAudioDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseAudioDelta))]
#endif
        public bool IsResponseAudioDelta => ResponseAudioDelta != null;

        /// <summary>
        /// Emitted when the audio response is complete.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseAudioDoneEvent? ResponseAudioDone { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseAudioDoneEvent? ResponseAudioDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseAudioDone))]
#endif
        public bool IsResponseAudioDone => ResponseAudioDone != null;

        /// <summary>
        /// Emitted when there is a partial transcript of audio.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent? ResponseAudioTranscriptDelta { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent? ResponseAudioTranscriptDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseAudioTranscriptDelta))]
#endif
        public bool IsResponseAudioTranscriptDelta => ResponseAudioTranscriptDelta != null;

        /// <summary>
        /// Emitted when the full audio transcript is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent? ResponseAudioTranscriptDone { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent? ResponseAudioTranscriptDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseAudioTranscriptDone))]
#endif
        public bool IsResponseAudioTranscriptDone => ResponseAudioTranscriptDone != null;

        /// <summary>
        /// Emitted when a partial code snippet is streamed by the code interpreter.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent? ResponseCodeInterpreterCallCodeDelta { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent? ResponseCodeInterpreterCallCodeDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCodeInterpreterCallCodeDelta))]
#endif
        public bool IsResponseCodeInterpreterCallCodeDelta => ResponseCodeInterpreterCallCodeDelta != null;

        /// <summary>
        /// Emitted when the code snippet is finalized by the code interpreter.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent? ResponseCodeInterpreterCallCodeDone { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent? ResponseCodeInterpreterCallCodeDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCodeInterpreterCallCodeDone))]
#endif
        public bool IsResponseCodeInterpreterCallCodeDone => ResponseCodeInterpreterCallCodeDone != null;

        /// <summary>
        /// Emitted when the code interpreter call is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent? ResponseCodeInterpreterCallCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent? ResponseCodeInterpreterCallCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCodeInterpreterCallCompleted))]
#endif
        public bool IsResponseCodeInterpreterCallCompleted => ResponseCodeInterpreterCallCompleted != null;

        /// <summary>
        /// Emitted when a code interpreter call is in progress.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent? ResponseCodeInterpreterCallInProgress { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent? ResponseCodeInterpreterCallInProgress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCodeInterpreterCallInProgress))]
#endif
        public bool IsResponseCodeInterpreterCallInProgress => ResponseCodeInterpreterCallInProgress != null;

        /// <summary>
        /// Emitted when the code interpreter is actively interpreting the code snippet.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent? ResponseCodeInterpreterCallInterpreting { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent? ResponseCodeInterpreterCallInterpreting { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCodeInterpreterCallInterpreting))]
#endif
        public bool IsResponseCodeInterpreterCallInterpreting => ResponseCodeInterpreterCallInterpreting != null;

        /// <summary>
        /// Emitted when the model response is complete.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseCompletedEvent? ResponseCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseCompletedEvent? ResponseCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCompleted))]
#endif
        public bool IsResponseCompleted => ResponseCompleted != null;

        /// <summary>
        /// Emitted when a new content part is added.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseContentPartAddedEvent? ResponseContentPartAdded { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseContentPartAddedEvent? ResponseContentPartAdded { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseContentPartAdded))]
#endif
        public bool IsResponseContentPartAdded => ResponseContentPartAdded != null;

        /// <summary>
        /// Emitted when a content part is done.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseContentPartDoneEvent? ResponseContentPartDone { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseContentPartDoneEvent? ResponseContentPartDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseContentPartDone))]
#endif
        public bool IsResponseContentPartDone => ResponseContentPartDone != null;

        /// <summary>
        /// An event that is emitted when a response is created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseCreatedEvent? ResponseCreated { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseCreatedEvent? ResponseCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCreated))]
#endif
        public bool IsResponseCreated => ResponseCreated != null;

        /// <summary>
        /// Emitted when an error occurs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseErrorEvent? Error { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseErrorEvent? Error { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;

        /// <summary>
        /// Emitted when a file search call is completed (results found).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent? ResponseFileSearchCallCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent? ResponseFileSearchCallCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFileSearchCallCompleted))]
#endif
        public bool IsResponseFileSearchCallCompleted => ResponseFileSearchCallCompleted != null;

        /// <summary>
        /// Emitted when a file search call is initiated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent? ResponseFileSearchCallInProgress { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent? ResponseFileSearchCallInProgress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFileSearchCallInProgress))]
#endif
        public bool IsResponseFileSearchCallInProgress => ResponseFileSearchCallInProgress != null;

        /// <summary>
        /// Emitted when a file search is currently searching.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent? ResponseFileSearchCallSearching { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent? ResponseFileSearchCallSearching { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFileSearchCallSearching))]
#endif
        public bool IsResponseFileSearchCallSearching => ResponseFileSearchCallSearching != null;

        /// <summary>
        /// Emitted when there is a partial function-call arguments delta.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent? ResponseFunctionCallArgumentsDelta { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent? ResponseFunctionCallArgumentsDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFunctionCallArgumentsDelta))]
#endif
        public bool IsResponseFunctionCallArgumentsDelta => ResponseFunctionCallArgumentsDelta != null;

        /// <summary>
        /// Emitted when function-call arguments are finalized.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent? ResponseFunctionCallArgumentsDone { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent? ResponseFunctionCallArgumentsDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFunctionCallArgumentsDone))]
#endif
        public bool IsResponseFunctionCallArgumentsDone => ResponseFunctionCallArgumentsDone != null;

        /// <summary>
        /// Emitted when the response is in progress.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseInProgressEvent? ResponseInProgress { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseInProgressEvent? ResponseInProgress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseInProgress))]
#endif
        public bool IsResponseInProgress => ResponseInProgress != null;

        /// <summary>
        /// An event that is emitted when a response fails.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseFailedEvent? ResponseFailed { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseFailedEvent? ResponseFailed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFailed))]
#endif
        public bool IsResponseFailed => ResponseFailed != null;

        /// <summary>
        /// An event that is emitted when a response finishes as incomplete.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseIncompleteEvent? ResponseIncomplete { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseIncompleteEvent? ResponseIncomplete { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseIncomplete))]
#endif
        public bool IsResponseIncomplete => ResponseIncomplete != null;

        /// <summary>
        /// Emitted when a new output item is added.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseOutputItemAddedEvent? ResponseOutputItemAdded { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseOutputItemAddedEvent? ResponseOutputItemAdded { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputItemAdded))]
#endif
        public bool IsResponseOutputItemAdded => ResponseOutputItemAdded != null;

        /// <summary>
        /// Emitted when an output item is marked done.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseOutputItemDoneEvent? ResponseOutputItemDone { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseOutputItemDoneEvent? ResponseOutputItemDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputItemDone))]
#endif
        public bool IsResponseOutputItemDone => ResponseOutputItemDone != null;

        /// <summary>
        /// Emitted when a new reasoning summary part is added.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent? ResponseReasoningSummaryPartAdded { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent? ResponseReasoningSummaryPartAdded { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseReasoningSummaryPartAdded))]
#endif
        public bool IsResponseReasoningSummaryPartAdded => ResponseReasoningSummaryPartAdded != null;

        /// <summary>
        /// Emitted when a reasoning summary part is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent? ResponseReasoningSummaryPartDone { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent? ResponseReasoningSummaryPartDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseReasoningSummaryPartDone))]
#endif
        public bool IsResponseReasoningSummaryPartDone => ResponseReasoningSummaryPartDone != null;

        /// <summary>
        /// Emitted when a delta is added to a reasoning summary text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent? ResponseReasoningSummaryTextDelta { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent? ResponseReasoningSummaryTextDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseReasoningSummaryTextDelta))]
#endif
        public bool IsResponseReasoningSummaryTextDelta => ResponseReasoningSummaryTextDelta != null;

        /// <summary>
        /// Emitted when a reasoning summary text is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent? ResponseReasoningSummaryTextDone { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent? ResponseReasoningSummaryTextDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseReasoningSummaryTextDone))]
#endif
        public bool IsResponseReasoningSummaryTextDone => ResponseReasoningSummaryTextDone != null;

        /// <summary>
        /// Emitted when a delta is added to a reasoning text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent? ResponseReasoningTextDelta { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent? ResponseReasoningTextDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseReasoningTextDelta))]
#endif
        public bool IsResponseReasoningTextDelta => ResponseReasoningTextDelta != null;

        /// <summary>
        /// Emitted when a reasoning text is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent? ResponseReasoningTextDone { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent? ResponseReasoningTextDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseReasoningTextDone))]
#endif
        public bool IsResponseReasoningTextDone => ResponseReasoningTextDone != null;

        /// <summary>
        /// Emitted when there is a partial refusal text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseRefusalDeltaEvent? ResponseRefusalDelta { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseRefusalDeltaEvent? ResponseRefusalDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseRefusalDelta))]
#endif
        public bool IsResponseRefusalDelta => ResponseRefusalDelta != null;

        /// <summary>
        /// Emitted when refusal text is finalized.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseRefusalDoneEvent? ResponseRefusalDone { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseRefusalDoneEvent? ResponseRefusalDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseRefusalDone))]
#endif
        public bool IsResponseRefusalDone => ResponseRefusalDone != null;

        /// <summary>
        /// Emitted when there is an additional text delta.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseTextDeltaEvent? ResponseOutputTextDelta { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseTextDeltaEvent? ResponseOutputTextDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputTextDelta))]
#endif
        public bool IsResponseOutputTextDelta => ResponseOutputTextDelta != null;

        /// <summary>
        /// Emitted when text content is finalized.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseTextDoneEvent? ResponseOutputTextDone { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseTextDoneEvent? ResponseOutputTextDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputTextDone))]
#endif
        public bool IsResponseOutputTextDone => ResponseOutputTextDone != null;

        /// <summary>
        /// Emitted when a web search call is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent? ResponseWebSearchCallCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent? ResponseWebSearchCallCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseWebSearchCallCompleted))]
#endif
        public bool IsResponseWebSearchCallCompleted => ResponseWebSearchCallCompleted != null;

        /// <summary>
        /// Emitted when a web search call is initiated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent? ResponseWebSearchCallInProgress { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent? ResponseWebSearchCallInProgress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseWebSearchCallInProgress))]
#endif
        public bool IsResponseWebSearchCallInProgress => ResponseWebSearchCallInProgress != null;

        /// <summary>
        /// Emitted when a web search call is executing.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent? ResponseWebSearchCallSearching { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent? ResponseWebSearchCallSearching { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseWebSearchCallSearching))]
#endif
        public bool IsResponseWebSearchCallSearching => ResponseWebSearchCallSearching != null;

        /// <summary>
        /// Emitted when an image generation tool call has completed and the final image is available.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent? ResponseImageGenerationCallCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent? ResponseImageGenerationCallCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseImageGenerationCallCompleted))]
#endif
        public bool IsResponseImageGenerationCallCompleted => ResponseImageGenerationCallCompleted != null;

        /// <summary>
        /// Emitted when an image generation tool call is actively generating an image (intermediate state).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent? ResponseImageGenerationCallGenerating { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent? ResponseImageGenerationCallGenerating { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseImageGenerationCallGenerating))]
#endif
        public bool IsResponseImageGenerationCallGenerating => ResponseImageGenerationCallGenerating != null;

        /// <summary>
        /// Emitted when an image generation tool call is in progress.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent? ResponseImageGenerationCallInProgress { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent? ResponseImageGenerationCallInProgress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseImageGenerationCallInProgress))]
#endif
        public bool IsResponseImageGenerationCallInProgress => ResponseImageGenerationCallInProgress != null;

        /// <summary>
        /// Emitted when a partial image is available during image generation streaming.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent? ResponseImageGenerationCallPartialImage { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent? ResponseImageGenerationCallPartialImage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseImageGenerationCallPartialImage))]
#endif
        public bool IsResponseImageGenerationCallPartialImage => ResponseImageGenerationCallPartialImage != null;

        /// <summary>
        /// Emitted when there is a delta (partial update) to the arguments of an MCP tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent? ResponseMcpCallArgumentsDelta { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent? ResponseMcpCallArgumentsDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseMcpCallArgumentsDelta))]
#endif
        public bool IsResponseMcpCallArgumentsDelta => ResponseMcpCallArgumentsDelta != null;

        /// <summary>
        /// Emitted when the arguments for an MCP tool call are finalized.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent? ResponseMcpCallArgumentsDone { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent? ResponseMcpCallArgumentsDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseMcpCallArgumentsDone))]
#endif
        public bool IsResponseMcpCallArgumentsDone => ResponseMcpCallArgumentsDone != null;

        /// <summary>
        /// Emitted when an MCP  tool call has completed successfully.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent? ResponseMcpCallCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent? ResponseMcpCallCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseMcpCallCompleted))]
#endif
        public bool IsResponseMcpCallCompleted => ResponseMcpCallCompleted != null;

        /// <summary>
        /// Emitted when an MCP  tool call has failed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseMCPCallFailedEvent? ResponseMcpCallFailed { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseMCPCallFailedEvent? ResponseMcpCallFailed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseMcpCallFailed))]
#endif
        public bool IsResponseMcpCallFailed => ResponseMcpCallFailed != null;

        /// <summary>
        /// Emitted when an MCP  tool call is in progress.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent? ResponseMcpCallInProgress { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent? ResponseMcpCallInProgress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseMcpCallInProgress))]
#endif
        public bool IsResponseMcpCallInProgress => ResponseMcpCallInProgress != null;

        /// <summary>
        /// Emitted when the list of available MCP tools has been successfully retrieved.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent? ResponseMcpListToolsCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent? ResponseMcpListToolsCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseMcpListToolsCompleted))]
#endif
        public bool IsResponseMcpListToolsCompleted => ResponseMcpListToolsCompleted != null;

        /// <summary>
        /// Emitted when the attempt to list available MCP tools has failed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent? ResponseMcpListToolsFailed { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent? ResponseMcpListToolsFailed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseMcpListToolsFailed))]
#endif
        public bool IsResponseMcpListToolsFailed => ResponseMcpListToolsFailed != null;

        /// <summary>
        /// Emitted when the system is in the process of retrieving the list of available MCP tools.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent? ResponseMcpListToolsInProgress { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent? ResponseMcpListToolsInProgress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseMcpListToolsInProgress))]
#endif
        public bool IsResponseMcpListToolsInProgress => ResponseMcpListToolsInProgress != null;

        /// <summary>
        /// Emitted when an annotation is added to output text content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent? ResponseOutputTextAnnotationAdded { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent? ResponseOutputTextAnnotationAdded { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputTextAnnotationAdded))]
#endif
        public bool IsResponseOutputTextAnnotationAdded => ResponseOutputTextAnnotationAdded != null;

        /// <summary>
        /// Emitted when a response is queued and waiting to be processed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseQueuedEvent? ResponseQueued { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseQueuedEvent? ResponseQueued { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseQueued))]
#endif
        public bool IsResponseQueued => ResponseQueued != null;

        /// <summary>
        /// Event representing a delta (partial update) to the input of a custom tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent? ResponseCustomToolCallInputDelta { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent? ResponseCustomToolCallInputDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCustomToolCallInputDelta))]
#endif
        public bool IsResponseCustomToolCallInputDelta => ResponseCustomToolCallInputDelta != null;

        /// <summary>
        /// Event indicating that input for a custom tool call is complete.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent? ResponseCustomToolCallInputDone { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent? ResponseCustomToolCallInputDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCustomToolCallInputDone))]
#endif
        public bool IsResponseCustomToolCallInputDone => ResponseCustomToolCallInputDone != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseAudioDeltaEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseAudioDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseAudioDeltaEvent?(ResponseStreamEvent @this) => @this.ResponseAudioDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseAudioDeltaEvent? value)
        {
            ResponseAudioDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseAudioDoneEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseAudioDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseAudioDoneEvent?(ResponseStreamEvent @this) => @this.ResponseAudioDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseAudioDoneEvent? value)
        {
            ResponseAudioDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent?(ResponseStreamEvent @this) => @this.ResponseAudioTranscriptDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent? value)
        {
            ResponseAudioTranscriptDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent?(ResponseStreamEvent @this) => @this.ResponseAudioTranscriptDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent? value)
        {
            ResponseAudioTranscriptDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent?(ResponseStreamEvent @this) => @this.ResponseCodeInterpreterCallCodeDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent? value)
        {
            ResponseCodeInterpreterCallCodeDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent?(ResponseStreamEvent @this) => @this.ResponseCodeInterpreterCallCodeDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent? value)
        {
            ResponseCodeInterpreterCallCodeDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent?(ResponseStreamEvent @this) => @this.ResponseCodeInterpreterCallCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent? value)
        {
            ResponseCodeInterpreterCallCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent?(ResponseStreamEvent @this) => @this.ResponseCodeInterpreterCallInProgress;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent? value)
        {
            ResponseCodeInterpreterCallInProgress = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent?(ResponseStreamEvent @this) => @this.ResponseCodeInterpreterCallInterpreting;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent? value)
        {
            ResponseCodeInterpreterCallInterpreting = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseCompletedEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseCompletedEvent?(ResponseStreamEvent @this) => @this.ResponseCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseCompletedEvent? value)
        {
            ResponseCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseContentPartAddedEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseContentPartAddedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseContentPartAddedEvent?(ResponseStreamEvent @this) => @this.ResponseContentPartAdded;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseContentPartAddedEvent? value)
        {
            ResponseContentPartAdded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseContentPartDoneEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseContentPartDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseContentPartDoneEvent?(ResponseStreamEvent @this) => @this.ResponseContentPartDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseContentPartDoneEvent? value)
        {
            ResponseContentPartDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseCreatedEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseCreatedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseCreatedEvent?(ResponseStreamEvent @this) => @this.ResponseCreated;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseCreatedEvent? value)
        {
            ResponseCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseErrorEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseErrorEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseErrorEvent?(ResponseStreamEvent @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseErrorEvent? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent?(ResponseStreamEvent @this) => @this.ResponseFileSearchCallCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent? value)
        {
            ResponseFileSearchCallCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent?(ResponseStreamEvent @this) => @this.ResponseFileSearchCallInProgress;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent? value)
        {
            ResponseFileSearchCallInProgress = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent?(ResponseStreamEvent @this) => @this.ResponseFileSearchCallSearching;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent? value)
        {
            ResponseFileSearchCallSearching = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent?(ResponseStreamEvent @this) => @this.ResponseFunctionCallArgumentsDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent? value)
        {
            ResponseFunctionCallArgumentsDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent?(ResponseStreamEvent @this) => @this.ResponseFunctionCallArgumentsDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent? value)
        {
            ResponseFunctionCallArgumentsDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseInProgressEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseInProgressEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseInProgressEvent?(ResponseStreamEvent @this) => @this.ResponseInProgress;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseInProgressEvent? value)
        {
            ResponseInProgress = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseFailedEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseFailedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseFailedEvent?(ResponseStreamEvent @this) => @this.ResponseFailed;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseFailedEvent? value)
        {
            ResponseFailed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseIncompleteEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseIncompleteEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseIncompleteEvent?(ResponseStreamEvent @this) => @this.ResponseIncomplete;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseIncompleteEvent? value)
        {
            ResponseIncomplete = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseOutputItemAddedEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseOutputItemAddedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseOutputItemAddedEvent?(ResponseStreamEvent @this) => @this.ResponseOutputItemAdded;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseOutputItemAddedEvent? value)
        {
            ResponseOutputItemAdded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseOutputItemDoneEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseOutputItemDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseOutputItemDoneEvent?(ResponseStreamEvent @this) => @this.ResponseOutputItemDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseOutputItemDoneEvent? value)
        {
            ResponseOutputItemDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent?(ResponseStreamEvent @this) => @this.ResponseReasoningSummaryPartAdded;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent? value)
        {
            ResponseReasoningSummaryPartAdded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent?(ResponseStreamEvent @this) => @this.ResponseReasoningSummaryPartDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent? value)
        {
            ResponseReasoningSummaryPartDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent?(ResponseStreamEvent @this) => @this.ResponseReasoningSummaryTextDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent? value)
        {
            ResponseReasoningSummaryTextDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent?(ResponseStreamEvent @this) => @this.ResponseReasoningSummaryTextDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent? value)
        {
            ResponseReasoningSummaryTextDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent?(ResponseStreamEvent @this) => @this.ResponseReasoningTextDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent? value)
        {
            ResponseReasoningTextDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent?(ResponseStreamEvent @this) => @this.ResponseReasoningTextDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent? value)
        {
            ResponseReasoningTextDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseRefusalDeltaEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseRefusalDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseRefusalDeltaEvent?(ResponseStreamEvent @this) => @this.ResponseRefusalDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseRefusalDeltaEvent? value)
        {
            ResponseRefusalDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseRefusalDoneEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseRefusalDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseRefusalDoneEvent?(ResponseStreamEvent @this) => @this.ResponseRefusalDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseRefusalDoneEvent? value)
        {
            ResponseRefusalDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseTextDeltaEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseTextDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseTextDeltaEvent?(ResponseStreamEvent @this) => @this.ResponseOutputTextDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseTextDeltaEvent? value)
        {
            ResponseOutputTextDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseTextDoneEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseTextDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseTextDoneEvent?(ResponseStreamEvent @this) => @this.ResponseOutputTextDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseTextDoneEvent? value)
        {
            ResponseOutputTextDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent?(ResponseStreamEvent @this) => @this.ResponseWebSearchCallCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent? value)
        {
            ResponseWebSearchCallCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent?(ResponseStreamEvent @this) => @this.ResponseWebSearchCallInProgress;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent? value)
        {
            ResponseWebSearchCallInProgress = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent?(ResponseStreamEvent @this) => @this.ResponseWebSearchCallSearching;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent? value)
        {
            ResponseWebSearchCallSearching = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent?(ResponseStreamEvent @this) => @this.ResponseImageGenerationCallCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent? value)
        {
            ResponseImageGenerationCallCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent?(ResponseStreamEvent @this) => @this.ResponseImageGenerationCallGenerating;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent? value)
        {
            ResponseImageGenerationCallGenerating = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent?(ResponseStreamEvent @this) => @this.ResponseImageGenerationCallInProgress;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent? value)
        {
            ResponseImageGenerationCallInProgress = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent?(ResponseStreamEvent @this) => @this.ResponseImageGenerationCallPartialImage;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent? value)
        {
            ResponseImageGenerationCallPartialImage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent?(ResponseStreamEvent @this) => @this.ResponseMcpCallArgumentsDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent? value)
        {
            ResponseMcpCallArgumentsDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent?(ResponseStreamEvent @this) => @this.ResponseMcpCallArgumentsDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent? value)
        {
            ResponseMcpCallArgumentsDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent?(ResponseStreamEvent @this) => @this.ResponseMcpCallCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent? value)
        {
            ResponseMcpCallCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseMCPCallFailedEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseMCPCallFailedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseMCPCallFailedEvent?(ResponseStreamEvent @this) => @this.ResponseMcpCallFailed;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseMCPCallFailedEvent? value)
        {
            ResponseMcpCallFailed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent?(ResponseStreamEvent @this) => @this.ResponseMcpCallInProgress;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent? value)
        {
            ResponseMcpCallInProgress = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent?(ResponseStreamEvent @this) => @this.ResponseMcpListToolsCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent? value)
        {
            ResponseMcpListToolsCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent?(ResponseStreamEvent @this) => @this.ResponseMcpListToolsFailed;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent? value)
        {
            ResponseMcpListToolsFailed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent?(ResponseStreamEvent @this) => @this.ResponseMcpListToolsInProgress;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent? value)
        {
            ResponseMcpListToolsInProgress = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent?(ResponseStreamEvent @this) => @this.ResponseOutputTextAnnotationAdded;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent? value)
        {
            ResponseOutputTextAnnotationAdded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseQueuedEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseQueuedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseQueuedEvent?(ResponseStreamEvent @this) => @this.ResponseQueued;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseQueuedEvent? value)
        {
            ResponseQueued = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent?(ResponseStreamEvent @this) => @this.ResponseCustomToolCallInputDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent? value)
        {
            ResponseCustomToolCallInputDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent?(ResponseStreamEvent @this) => @this.ResponseCustomToolCallInputDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent? value)
        {
            ResponseCustomToolCallInputDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(
            global::tryAGI.OpenAI.ResponseAudioDeltaEvent? responseAudioDelta,
            global::tryAGI.OpenAI.ResponseAudioDoneEvent? responseAudioDone,
            global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent? responseAudioTranscriptDelta,
            global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent? responseAudioTranscriptDone,
            global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent? responseCodeInterpreterCallCodeDelta,
            global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent? responseCodeInterpreterCallCodeDone,
            global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent? responseCodeInterpreterCallCompleted,
            global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent? responseCodeInterpreterCallInProgress,
            global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent? responseCodeInterpreterCallInterpreting,
            global::tryAGI.OpenAI.ResponseCompletedEvent? responseCompleted,
            global::tryAGI.OpenAI.ResponseContentPartAddedEvent? responseContentPartAdded,
            global::tryAGI.OpenAI.ResponseContentPartDoneEvent? responseContentPartDone,
            global::tryAGI.OpenAI.ResponseCreatedEvent? responseCreated,
            global::tryAGI.OpenAI.ResponseErrorEvent? error,
            global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent? responseFileSearchCallCompleted,
            global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent? responseFileSearchCallInProgress,
            global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent? responseFileSearchCallSearching,
            global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent? responseFunctionCallArgumentsDelta,
            global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent? responseFunctionCallArgumentsDone,
            global::tryAGI.OpenAI.ResponseInProgressEvent? responseInProgress,
            global::tryAGI.OpenAI.ResponseFailedEvent? responseFailed,
            global::tryAGI.OpenAI.ResponseIncompleteEvent? responseIncomplete,
            global::tryAGI.OpenAI.ResponseOutputItemAddedEvent? responseOutputItemAdded,
            global::tryAGI.OpenAI.ResponseOutputItemDoneEvent? responseOutputItemDone,
            global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent? responseReasoningSummaryPartAdded,
            global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent? responseReasoningSummaryPartDone,
            global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent? responseReasoningSummaryTextDelta,
            global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent? responseReasoningSummaryTextDone,
            global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent? responseReasoningTextDelta,
            global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent? responseReasoningTextDone,
            global::tryAGI.OpenAI.ResponseRefusalDeltaEvent? responseRefusalDelta,
            global::tryAGI.OpenAI.ResponseRefusalDoneEvent? responseRefusalDone,
            global::tryAGI.OpenAI.ResponseTextDeltaEvent? responseOutputTextDelta,
            global::tryAGI.OpenAI.ResponseTextDoneEvent? responseOutputTextDone,
            global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent? responseWebSearchCallCompleted,
            global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent? responseWebSearchCallInProgress,
            global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent? responseWebSearchCallSearching,
            global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent? responseImageGenerationCallCompleted,
            global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent? responseImageGenerationCallGenerating,
            global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent? responseImageGenerationCallInProgress,
            global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent? responseImageGenerationCallPartialImage,
            global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent? responseMcpCallArgumentsDelta,
            global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent? responseMcpCallArgumentsDone,
            global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent? responseMcpCallCompleted,
            global::tryAGI.OpenAI.ResponseMCPCallFailedEvent? responseMcpCallFailed,
            global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent? responseMcpCallInProgress,
            global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent? responseMcpListToolsCompleted,
            global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent? responseMcpListToolsFailed,
            global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent? responseMcpListToolsInProgress,
            global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent? responseOutputTextAnnotationAdded,
            global::tryAGI.OpenAI.ResponseQueuedEvent? responseQueued,
            global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent? responseCustomToolCallInputDelta,
            global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent? responseCustomToolCallInputDone
            )
        {
            ResponseAudioDelta = responseAudioDelta;
            ResponseAudioDone = responseAudioDone;
            ResponseAudioTranscriptDelta = responseAudioTranscriptDelta;
            ResponseAudioTranscriptDone = responseAudioTranscriptDone;
            ResponseCodeInterpreterCallCodeDelta = responseCodeInterpreterCallCodeDelta;
            ResponseCodeInterpreterCallCodeDone = responseCodeInterpreterCallCodeDone;
            ResponseCodeInterpreterCallCompleted = responseCodeInterpreterCallCompleted;
            ResponseCodeInterpreterCallInProgress = responseCodeInterpreterCallInProgress;
            ResponseCodeInterpreterCallInterpreting = responseCodeInterpreterCallInterpreting;
            ResponseCompleted = responseCompleted;
            ResponseContentPartAdded = responseContentPartAdded;
            ResponseContentPartDone = responseContentPartDone;
            ResponseCreated = responseCreated;
            Error = error;
            ResponseFileSearchCallCompleted = responseFileSearchCallCompleted;
            ResponseFileSearchCallInProgress = responseFileSearchCallInProgress;
            ResponseFileSearchCallSearching = responseFileSearchCallSearching;
            ResponseFunctionCallArgumentsDelta = responseFunctionCallArgumentsDelta;
            ResponseFunctionCallArgumentsDone = responseFunctionCallArgumentsDone;
            ResponseInProgress = responseInProgress;
            ResponseFailed = responseFailed;
            ResponseIncomplete = responseIncomplete;
            ResponseOutputItemAdded = responseOutputItemAdded;
            ResponseOutputItemDone = responseOutputItemDone;
            ResponseReasoningSummaryPartAdded = responseReasoningSummaryPartAdded;
            ResponseReasoningSummaryPartDone = responseReasoningSummaryPartDone;
            ResponseReasoningSummaryTextDelta = responseReasoningSummaryTextDelta;
            ResponseReasoningSummaryTextDone = responseReasoningSummaryTextDone;
            ResponseReasoningTextDelta = responseReasoningTextDelta;
            ResponseReasoningTextDone = responseReasoningTextDone;
            ResponseRefusalDelta = responseRefusalDelta;
            ResponseRefusalDone = responseRefusalDone;
            ResponseOutputTextDelta = responseOutputTextDelta;
            ResponseOutputTextDone = responseOutputTextDone;
            ResponseWebSearchCallCompleted = responseWebSearchCallCompleted;
            ResponseWebSearchCallInProgress = responseWebSearchCallInProgress;
            ResponseWebSearchCallSearching = responseWebSearchCallSearching;
            ResponseImageGenerationCallCompleted = responseImageGenerationCallCompleted;
            ResponseImageGenerationCallGenerating = responseImageGenerationCallGenerating;
            ResponseImageGenerationCallInProgress = responseImageGenerationCallInProgress;
            ResponseImageGenerationCallPartialImage = responseImageGenerationCallPartialImage;
            ResponseMcpCallArgumentsDelta = responseMcpCallArgumentsDelta;
            ResponseMcpCallArgumentsDone = responseMcpCallArgumentsDone;
            ResponseMcpCallCompleted = responseMcpCallCompleted;
            ResponseMcpCallFailed = responseMcpCallFailed;
            ResponseMcpCallInProgress = responseMcpCallInProgress;
            ResponseMcpListToolsCompleted = responseMcpListToolsCompleted;
            ResponseMcpListToolsFailed = responseMcpListToolsFailed;
            ResponseMcpListToolsInProgress = responseMcpListToolsInProgress;
            ResponseOutputTextAnnotationAdded = responseOutputTextAnnotationAdded;
            ResponseQueued = responseQueued;
            ResponseCustomToolCallInputDelta = responseCustomToolCallInputDelta;
            ResponseCustomToolCallInputDone = responseCustomToolCallInputDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ResponseCustomToolCallInputDone as object ??
            ResponseCustomToolCallInputDelta as object ??
            ResponseQueued as object ??
            ResponseOutputTextAnnotationAdded as object ??
            ResponseMcpListToolsInProgress as object ??
            ResponseMcpListToolsFailed as object ??
            ResponseMcpListToolsCompleted as object ??
            ResponseMcpCallInProgress as object ??
            ResponseMcpCallFailed as object ??
            ResponseMcpCallCompleted as object ??
            ResponseMcpCallArgumentsDone as object ??
            ResponseMcpCallArgumentsDelta as object ??
            ResponseImageGenerationCallPartialImage as object ??
            ResponseImageGenerationCallInProgress as object ??
            ResponseImageGenerationCallGenerating as object ??
            ResponseImageGenerationCallCompleted as object ??
            ResponseWebSearchCallSearching as object ??
            ResponseWebSearchCallInProgress as object ??
            ResponseWebSearchCallCompleted as object ??
            ResponseOutputTextDone as object ??
            ResponseOutputTextDelta as object ??
            ResponseRefusalDone as object ??
            ResponseRefusalDelta as object ??
            ResponseReasoningTextDone as object ??
            ResponseReasoningTextDelta as object ??
            ResponseReasoningSummaryTextDone as object ??
            ResponseReasoningSummaryTextDelta as object ??
            ResponseReasoningSummaryPartDone as object ??
            ResponseReasoningSummaryPartAdded as object ??
            ResponseOutputItemDone as object ??
            ResponseOutputItemAdded as object ??
            ResponseIncomplete as object ??
            ResponseFailed as object ??
            ResponseInProgress as object ??
            ResponseFunctionCallArgumentsDone as object ??
            ResponseFunctionCallArgumentsDelta as object ??
            ResponseFileSearchCallSearching as object ??
            ResponseFileSearchCallInProgress as object ??
            ResponseFileSearchCallCompleted as object ??
            Error as object ??
            ResponseCreated as object ??
            ResponseContentPartDone as object ??
            ResponseContentPartAdded as object ??
            ResponseCompleted as object ??
            ResponseCodeInterpreterCallInterpreting as object ??
            ResponseCodeInterpreterCallInProgress as object ??
            ResponseCodeInterpreterCallCompleted as object ??
            ResponseCodeInterpreterCallCodeDone as object ??
            ResponseCodeInterpreterCallCodeDelta as object ??
            ResponseAudioTranscriptDone as object ??
            ResponseAudioTranscriptDelta as object ??
            ResponseAudioDone as object ??
            ResponseAudioDelta as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ResponseAudioDelta?.ToString() ??
            ResponseAudioDone?.ToString() ??
            ResponseAudioTranscriptDelta?.ToString() ??
            ResponseAudioTranscriptDone?.ToString() ??
            ResponseCodeInterpreterCallCodeDelta?.ToString() ??
            ResponseCodeInterpreterCallCodeDone?.ToString() ??
            ResponseCodeInterpreterCallCompleted?.ToString() ??
            ResponseCodeInterpreterCallInProgress?.ToString() ??
            ResponseCodeInterpreterCallInterpreting?.ToString() ??
            ResponseCompleted?.ToString() ??
            ResponseContentPartAdded?.ToString() ??
            ResponseContentPartDone?.ToString() ??
            ResponseCreated?.ToString() ??
            Error?.ToString() ??
            ResponseFileSearchCallCompleted?.ToString() ??
            ResponseFileSearchCallInProgress?.ToString() ??
            ResponseFileSearchCallSearching?.ToString() ??
            ResponseFunctionCallArgumentsDelta?.ToString() ??
            ResponseFunctionCallArgumentsDone?.ToString() ??
            ResponseInProgress?.ToString() ??
            ResponseFailed?.ToString() ??
            ResponseIncomplete?.ToString() ??
            ResponseOutputItemAdded?.ToString() ??
            ResponseOutputItemDone?.ToString() ??
            ResponseReasoningSummaryPartAdded?.ToString() ??
            ResponseReasoningSummaryPartDone?.ToString() ??
            ResponseReasoningSummaryTextDelta?.ToString() ??
            ResponseReasoningSummaryTextDone?.ToString() ??
            ResponseReasoningTextDelta?.ToString() ??
            ResponseReasoningTextDone?.ToString() ??
            ResponseRefusalDelta?.ToString() ??
            ResponseRefusalDone?.ToString() ??
            ResponseOutputTextDelta?.ToString() ??
            ResponseOutputTextDone?.ToString() ??
            ResponseWebSearchCallCompleted?.ToString() ??
            ResponseWebSearchCallInProgress?.ToString() ??
            ResponseWebSearchCallSearching?.ToString() ??
            ResponseImageGenerationCallCompleted?.ToString() ??
            ResponseImageGenerationCallGenerating?.ToString() ??
            ResponseImageGenerationCallInProgress?.ToString() ??
            ResponseImageGenerationCallPartialImage?.ToString() ??
            ResponseMcpCallArgumentsDelta?.ToString() ??
            ResponseMcpCallArgumentsDone?.ToString() ??
            ResponseMcpCallCompleted?.ToString() ??
            ResponseMcpCallFailed?.ToString() ??
            ResponseMcpCallInProgress?.ToString() ??
            ResponseMcpListToolsCompleted?.ToString() ??
            ResponseMcpListToolsFailed?.ToString() ??
            ResponseMcpListToolsInProgress?.ToString() ??
            ResponseOutputTextAnnotationAdded?.ToString() ??
            ResponseQueued?.ToString() ??
            ResponseCustomToolCallInputDelta?.ToString() ??
            ResponseCustomToolCallInputDone?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResponseAudioDelta || IsResponseAudioDone || IsResponseAudioTranscriptDelta || IsResponseAudioTranscriptDone || IsResponseCodeInterpreterCallCodeDelta || IsResponseCodeInterpreterCallCodeDone || IsResponseCodeInterpreterCallCompleted || IsResponseCodeInterpreterCallInProgress || IsResponseCodeInterpreterCallInterpreting || IsResponseCompleted || IsResponseContentPartAdded || IsResponseContentPartDone || IsResponseCreated || IsError || IsResponseFileSearchCallCompleted || IsResponseFileSearchCallInProgress || IsResponseFileSearchCallSearching || IsResponseFunctionCallArgumentsDelta || IsResponseFunctionCallArgumentsDone || IsResponseInProgress || IsResponseFailed || IsResponseIncomplete || IsResponseOutputItemAdded || IsResponseOutputItemDone || IsResponseReasoningSummaryPartAdded || IsResponseReasoningSummaryPartDone || IsResponseReasoningSummaryTextDelta || IsResponseReasoningSummaryTextDone || IsResponseReasoningTextDelta || IsResponseReasoningTextDone || IsResponseRefusalDelta || IsResponseRefusalDone || IsResponseOutputTextDelta || IsResponseOutputTextDone || IsResponseWebSearchCallCompleted || IsResponseWebSearchCallInProgress || IsResponseWebSearchCallSearching || IsResponseImageGenerationCallCompleted || IsResponseImageGenerationCallGenerating || IsResponseImageGenerationCallInProgress || IsResponseImageGenerationCallPartialImage || IsResponseMcpCallArgumentsDelta || IsResponseMcpCallArgumentsDone || IsResponseMcpCallCompleted || IsResponseMcpCallFailed || IsResponseMcpCallInProgress || IsResponseMcpListToolsCompleted || IsResponseMcpListToolsFailed || IsResponseMcpListToolsInProgress || IsResponseOutputTextAnnotationAdded || IsResponseQueued || IsResponseCustomToolCallInputDelta || IsResponseCustomToolCallInputDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ResponseAudioDeltaEvent?, TResult>? responseAudioDelta = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseAudioDoneEvent?, TResult>? responseAudioDone = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent?, TResult>? responseAudioTranscriptDelta = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent?, TResult>? responseAudioTranscriptDone = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent?, TResult>? responseCodeInterpreterCallCodeDelta = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent?, TResult>? responseCodeInterpreterCallCodeDone = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent?, TResult>? responseCodeInterpreterCallCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent?, TResult>? responseCodeInterpreterCallInProgress = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent?, TResult>? responseCodeInterpreterCallInterpreting = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseCompletedEvent?, TResult>? responseCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseContentPartAddedEvent?, TResult>? responseContentPartAdded = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseContentPartDoneEvent?, TResult>? responseContentPartDone = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseCreatedEvent?, TResult>? responseCreated = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseErrorEvent?, TResult>? error = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent?, TResult>? responseFileSearchCallCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent?, TResult>? responseFileSearchCallInProgress = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent?, TResult>? responseFileSearchCallSearching = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent?, TResult>? responseFunctionCallArgumentsDelta = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent?, TResult>? responseFunctionCallArgumentsDone = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseInProgressEvent?, TResult>? responseInProgress = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseFailedEvent?, TResult>? responseFailed = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseIncompleteEvent?, TResult>? responseIncomplete = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent?, TResult>? responseOutputItemAdded = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent?, TResult>? responseOutputItemDone = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent?, TResult>? responseReasoningSummaryPartAdded = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent?, TResult>? responseReasoningSummaryPartDone = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent?, TResult>? responseReasoningSummaryTextDelta = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent?, TResult>? responseReasoningSummaryTextDone = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent?, TResult>? responseReasoningTextDelta = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent?, TResult>? responseReasoningTextDone = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent?, TResult>? responseRefusalDelta = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseRefusalDoneEvent?, TResult>? responseRefusalDone = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseTextDeltaEvent?, TResult>? responseOutputTextDelta = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseTextDoneEvent?, TResult>? responseOutputTextDone = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent?, TResult>? responseWebSearchCallCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent?, TResult>? responseWebSearchCallInProgress = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent?, TResult>? responseWebSearchCallSearching = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent?, TResult>? responseImageGenerationCallCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent?, TResult>? responseImageGenerationCallGenerating = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent?, TResult>? responseImageGenerationCallInProgress = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent?, TResult>? responseImageGenerationCallPartialImage = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent?, TResult>? responseMcpCallArgumentsDelta = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent?, TResult>? responseMcpCallArgumentsDone = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent?, TResult>? responseMcpCallCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent?, TResult>? responseMcpCallFailed = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent?, TResult>? responseMcpCallInProgress = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent?, TResult>? responseMcpListToolsCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent?, TResult>? responseMcpListToolsFailed = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent?, TResult>? responseMcpListToolsInProgress = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent?, TResult>? responseOutputTextAnnotationAdded = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseQueuedEvent?, TResult>? responseQueued = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent?, TResult>? responseCustomToolCallInputDelta = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent?, TResult>? responseCustomToolCallInputDone = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponseAudioDelta && responseAudioDelta != null)
            {
                return responseAudioDelta(ResponseAudioDelta!);
            }
            else if (IsResponseAudioDone && responseAudioDone != null)
            {
                return responseAudioDone(ResponseAudioDone!);
            }
            else if (IsResponseAudioTranscriptDelta && responseAudioTranscriptDelta != null)
            {
                return responseAudioTranscriptDelta(ResponseAudioTranscriptDelta!);
            }
            else if (IsResponseAudioTranscriptDone && responseAudioTranscriptDone != null)
            {
                return responseAudioTranscriptDone(ResponseAudioTranscriptDone!);
            }
            else if (IsResponseCodeInterpreterCallCodeDelta && responseCodeInterpreterCallCodeDelta != null)
            {
                return responseCodeInterpreterCallCodeDelta(ResponseCodeInterpreterCallCodeDelta!);
            }
            else if (IsResponseCodeInterpreterCallCodeDone && responseCodeInterpreterCallCodeDone != null)
            {
                return responseCodeInterpreterCallCodeDone(ResponseCodeInterpreterCallCodeDone!);
            }
            else if (IsResponseCodeInterpreterCallCompleted && responseCodeInterpreterCallCompleted != null)
            {
                return responseCodeInterpreterCallCompleted(ResponseCodeInterpreterCallCompleted!);
            }
            else if (IsResponseCodeInterpreterCallInProgress && responseCodeInterpreterCallInProgress != null)
            {
                return responseCodeInterpreterCallInProgress(ResponseCodeInterpreterCallInProgress!);
            }
            else if (IsResponseCodeInterpreterCallInterpreting && responseCodeInterpreterCallInterpreting != null)
            {
                return responseCodeInterpreterCallInterpreting(ResponseCodeInterpreterCallInterpreting!);
            }
            else if (IsResponseCompleted && responseCompleted != null)
            {
                return responseCompleted(ResponseCompleted!);
            }
            else if (IsResponseContentPartAdded && responseContentPartAdded != null)
            {
                return responseContentPartAdded(ResponseContentPartAdded!);
            }
            else if (IsResponseContentPartDone && responseContentPartDone != null)
            {
                return responseContentPartDone(ResponseContentPartDone!);
            }
            else if (IsResponseCreated && responseCreated != null)
            {
                return responseCreated(ResponseCreated!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }
            else if (IsResponseFileSearchCallCompleted && responseFileSearchCallCompleted != null)
            {
                return responseFileSearchCallCompleted(ResponseFileSearchCallCompleted!);
            }
            else if (IsResponseFileSearchCallInProgress && responseFileSearchCallInProgress != null)
            {
                return responseFileSearchCallInProgress(ResponseFileSearchCallInProgress!);
            }
            else if (IsResponseFileSearchCallSearching && responseFileSearchCallSearching != null)
            {
                return responseFileSearchCallSearching(ResponseFileSearchCallSearching!);
            }
            else if (IsResponseFunctionCallArgumentsDelta && responseFunctionCallArgumentsDelta != null)
            {
                return responseFunctionCallArgumentsDelta(ResponseFunctionCallArgumentsDelta!);
            }
            else if (IsResponseFunctionCallArgumentsDone && responseFunctionCallArgumentsDone != null)
            {
                return responseFunctionCallArgumentsDone(ResponseFunctionCallArgumentsDone!);
            }
            else if (IsResponseInProgress && responseInProgress != null)
            {
                return responseInProgress(ResponseInProgress!);
            }
            else if (IsResponseFailed && responseFailed != null)
            {
                return responseFailed(ResponseFailed!);
            }
            else if (IsResponseIncomplete && responseIncomplete != null)
            {
                return responseIncomplete(ResponseIncomplete!);
            }
            else if (IsResponseOutputItemAdded && responseOutputItemAdded != null)
            {
                return responseOutputItemAdded(ResponseOutputItemAdded!);
            }
            else if (IsResponseOutputItemDone && responseOutputItemDone != null)
            {
                return responseOutputItemDone(ResponseOutputItemDone!);
            }
            else if (IsResponseReasoningSummaryPartAdded && responseReasoningSummaryPartAdded != null)
            {
                return responseReasoningSummaryPartAdded(ResponseReasoningSummaryPartAdded!);
            }
            else if (IsResponseReasoningSummaryPartDone && responseReasoningSummaryPartDone != null)
            {
                return responseReasoningSummaryPartDone(ResponseReasoningSummaryPartDone!);
            }
            else if (IsResponseReasoningSummaryTextDelta && responseReasoningSummaryTextDelta != null)
            {
                return responseReasoningSummaryTextDelta(ResponseReasoningSummaryTextDelta!);
            }
            else if (IsResponseReasoningSummaryTextDone && responseReasoningSummaryTextDone != null)
            {
                return responseReasoningSummaryTextDone(ResponseReasoningSummaryTextDone!);
            }
            else if (IsResponseReasoningTextDelta && responseReasoningTextDelta != null)
            {
                return responseReasoningTextDelta(ResponseReasoningTextDelta!);
            }
            else if (IsResponseReasoningTextDone && responseReasoningTextDone != null)
            {
                return responseReasoningTextDone(ResponseReasoningTextDone!);
            }
            else if (IsResponseRefusalDelta && responseRefusalDelta != null)
            {
                return responseRefusalDelta(ResponseRefusalDelta!);
            }
            else if (IsResponseRefusalDone && responseRefusalDone != null)
            {
                return responseRefusalDone(ResponseRefusalDone!);
            }
            else if (IsResponseOutputTextDelta && responseOutputTextDelta != null)
            {
                return responseOutputTextDelta(ResponseOutputTextDelta!);
            }
            else if (IsResponseOutputTextDone && responseOutputTextDone != null)
            {
                return responseOutputTextDone(ResponseOutputTextDone!);
            }
            else if (IsResponseWebSearchCallCompleted && responseWebSearchCallCompleted != null)
            {
                return responseWebSearchCallCompleted(ResponseWebSearchCallCompleted!);
            }
            else if (IsResponseWebSearchCallInProgress && responseWebSearchCallInProgress != null)
            {
                return responseWebSearchCallInProgress(ResponseWebSearchCallInProgress!);
            }
            else if (IsResponseWebSearchCallSearching && responseWebSearchCallSearching != null)
            {
                return responseWebSearchCallSearching(ResponseWebSearchCallSearching!);
            }
            else if (IsResponseImageGenerationCallCompleted && responseImageGenerationCallCompleted != null)
            {
                return responseImageGenerationCallCompleted(ResponseImageGenerationCallCompleted!);
            }
            else if (IsResponseImageGenerationCallGenerating && responseImageGenerationCallGenerating != null)
            {
                return responseImageGenerationCallGenerating(ResponseImageGenerationCallGenerating!);
            }
            else if (IsResponseImageGenerationCallInProgress && responseImageGenerationCallInProgress != null)
            {
                return responseImageGenerationCallInProgress(ResponseImageGenerationCallInProgress!);
            }
            else if (IsResponseImageGenerationCallPartialImage && responseImageGenerationCallPartialImage != null)
            {
                return responseImageGenerationCallPartialImage(ResponseImageGenerationCallPartialImage!);
            }
            else if (IsResponseMcpCallArgumentsDelta && responseMcpCallArgumentsDelta != null)
            {
                return responseMcpCallArgumentsDelta(ResponseMcpCallArgumentsDelta!);
            }
            else if (IsResponseMcpCallArgumentsDone && responseMcpCallArgumentsDone != null)
            {
                return responseMcpCallArgumentsDone(ResponseMcpCallArgumentsDone!);
            }
            else if (IsResponseMcpCallCompleted && responseMcpCallCompleted != null)
            {
                return responseMcpCallCompleted(ResponseMcpCallCompleted!);
            }
            else if (IsResponseMcpCallFailed && responseMcpCallFailed != null)
            {
                return responseMcpCallFailed(ResponseMcpCallFailed!);
            }
            else if (IsResponseMcpCallInProgress && responseMcpCallInProgress != null)
            {
                return responseMcpCallInProgress(ResponseMcpCallInProgress!);
            }
            else if (IsResponseMcpListToolsCompleted && responseMcpListToolsCompleted != null)
            {
                return responseMcpListToolsCompleted(ResponseMcpListToolsCompleted!);
            }
            else if (IsResponseMcpListToolsFailed && responseMcpListToolsFailed != null)
            {
                return responseMcpListToolsFailed(ResponseMcpListToolsFailed!);
            }
            else if (IsResponseMcpListToolsInProgress && responseMcpListToolsInProgress != null)
            {
                return responseMcpListToolsInProgress(ResponseMcpListToolsInProgress!);
            }
            else if (IsResponseOutputTextAnnotationAdded && responseOutputTextAnnotationAdded != null)
            {
                return responseOutputTextAnnotationAdded(ResponseOutputTextAnnotationAdded!);
            }
            else if (IsResponseQueued && responseQueued != null)
            {
                return responseQueued(ResponseQueued!);
            }
            else if (IsResponseCustomToolCallInputDelta && responseCustomToolCallInputDelta != null)
            {
                return responseCustomToolCallInputDelta(ResponseCustomToolCallInputDelta!);
            }
            else if (IsResponseCustomToolCallInputDone && responseCustomToolCallInputDone != null)
            {
                return responseCustomToolCallInputDone(ResponseCustomToolCallInputDone!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.ResponseAudioDeltaEvent?>? responseAudioDelta = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseAudioDoneEvent?>? responseAudioDone = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent?>? responseAudioTranscriptDelta = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent?>? responseAudioTranscriptDone = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent?>? responseCodeInterpreterCallCodeDelta = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent?>? responseCodeInterpreterCallCodeDone = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent?>? responseCodeInterpreterCallCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent?>? responseCodeInterpreterCallInProgress = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent?>? responseCodeInterpreterCallInterpreting = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseCompletedEvent?>? responseCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseContentPartAddedEvent?>? responseContentPartAdded = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseContentPartDoneEvent?>? responseContentPartDone = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseCreatedEvent?>? responseCreated = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseErrorEvent?>? error = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent?>? responseFileSearchCallCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent?>? responseFileSearchCallInProgress = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent?>? responseFileSearchCallSearching = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent?>? responseFunctionCallArgumentsDelta = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent?>? responseFunctionCallArgumentsDone = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseInProgressEvent?>? responseInProgress = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseFailedEvent?>? responseFailed = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseIncompleteEvent?>? responseIncomplete = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent?>? responseOutputItemAdded = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent?>? responseOutputItemDone = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent?>? responseReasoningSummaryPartAdded = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent?>? responseReasoningSummaryPartDone = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent?>? responseReasoningSummaryTextDelta = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent?>? responseReasoningSummaryTextDone = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent?>? responseReasoningTextDelta = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent?>? responseReasoningTextDone = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent?>? responseRefusalDelta = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseRefusalDoneEvent?>? responseRefusalDone = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseTextDeltaEvent?>? responseOutputTextDelta = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseTextDoneEvent?>? responseOutputTextDone = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent?>? responseWebSearchCallCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent?>? responseWebSearchCallInProgress = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent?>? responseWebSearchCallSearching = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent?>? responseImageGenerationCallCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent?>? responseImageGenerationCallGenerating = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent?>? responseImageGenerationCallInProgress = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent?>? responseImageGenerationCallPartialImage = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent?>? responseMcpCallArgumentsDelta = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent?>? responseMcpCallArgumentsDone = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent?>? responseMcpCallCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent?>? responseMcpCallFailed = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent?>? responseMcpCallInProgress = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent?>? responseMcpListToolsCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent?>? responseMcpListToolsFailed = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent?>? responseMcpListToolsInProgress = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent?>? responseOutputTextAnnotationAdded = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseQueuedEvent?>? responseQueued = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent?>? responseCustomToolCallInputDelta = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent?>? responseCustomToolCallInputDone = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponseAudioDelta)
            {
                responseAudioDelta?.Invoke(ResponseAudioDelta!);
            }
            else if (IsResponseAudioDone)
            {
                responseAudioDone?.Invoke(ResponseAudioDone!);
            }
            else if (IsResponseAudioTranscriptDelta)
            {
                responseAudioTranscriptDelta?.Invoke(ResponseAudioTranscriptDelta!);
            }
            else if (IsResponseAudioTranscriptDone)
            {
                responseAudioTranscriptDone?.Invoke(ResponseAudioTranscriptDone!);
            }
            else if (IsResponseCodeInterpreterCallCodeDelta)
            {
                responseCodeInterpreterCallCodeDelta?.Invoke(ResponseCodeInterpreterCallCodeDelta!);
            }
            else if (IsResponseCodeInterpreterCallCodeDone)
            {
                responseCodeInterpreterCallCodeDone?.Invoke(ResponseCodeInterpreterCallCodeDone!);
            }
            else if (IsResponseCodeInterpreterCallCompleted)
            {
                responseCodeInterpreterCallCompleted?.Invoke(ResponseCodeInterpreterCallCompleted!);
            }
            else if (IsResponseCodeInterpreterCallInProgress)
            {
                responseCodeInterpreterCallInProgress?.Invoke(ResponseCodeInterpreterCallInProgress!);
            }
            else if (IsResponseCodeInterpreterCallInterpreting)
            {
                responseCodeInterpreterCallInterpreting?.Invoke(ResponseCodeInterpreterCallInterpreting!);
            }
            else if (IsResponseCompleted)
            {
                responseCompleted?.Invoke(ResponseCompleted!);
            }
            else if (IsResponseContentPartAdded)
            {
                responseContentPartAdded?.Invoke(ResponseContentPartAdded!);
            }
            else if (IsResponseContentPartDone)
            {
                responseContentPartDone?.Invoke(ResponseContentPartDone!);
            }
            else if (IsResponseCreated)
            {
                responseCreated?.Invoke(ResponseCreated!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
            else if (IsResponseFileSearchCallCompleted)
            {
                responseFileSearchCallCompleted?.Invoke(ResponseFileSearchCallCompleted!);
            }
            else if (IsResponseFileSearchCallInProgress)
            {
                responseFileSearchCallInProgress?.Invoke(ResponseFileSearchCallInProgress!);
            }
            else if (IsResponseFileSearchCallSearching)
            {
                responseFileSearchCallSearching?.Invoke(ResponseFileSearchCallSearching!);
            }
            else if (IsResponseFunctionCallArgumentsDelta)
            {
                responseFunctionCallArgumentsDelta?.Invoke(ResponseFunctionCallArgumentsDelta!);
            }
            else if (IsResponseFunctionCallArgumentsDone)
            {
                responseFunctionCallArgumentsDone?.Invoke(ResponseFunctionCallArgumentsDone!);
            }
            else if (IsResponseInProgress)
            {
                responseInProgress?.Invoke(ResponseInProgress!);
            }
            else if (IsResponseFailed)
            {
                responseFailed?.Invoke(ResponseFailed!);
            }
            else if (IsResponseIncomplete)
            {
                responseIncomplete?.Invoke(ResponseIncomplete!);
            }
            else if (IsResponseOutputItemAdded)
            {
                responseOutputItemAdded?.Invoke(ResponseOutputItemAdded!);
            }
            else if (IsResponseOutputItemDone)
            {
                responseOutputItemDone?.Invoke(ResponseOutputItemDone!);
            }
            else if (IsResponseReasoningSummaryPartAdded)
            {
                responseReasoningSummaryPartAdded?.Invoke(ResponseReasoningSummaryPartAdded!);
            }
            else if (IsResponseReasoningSummaryPartDone)
            {
                responseReasoningSummaryPartDone?.Invoke(ResponseReasoningSummaryPartDone!);
            }
            else if (IsResponseReasoningSummaryTextDelta)
            {
                responseReasoningSummaryTextDelta?.Invoke(ResponseReasoningSummaryTextDelta!);
            }
            else if (IsResponseReasoningSummaryTextDone)
            {
                responseReasoningSummaryTextDone?.Invoke(ResponseReasoningSummaryTextDone!);
            }
            else if (IsResponseReasoningTextDelta)
            {
                responseReasoningTextDelta?.Invoke(ResponseReasoningTextDelta!);
            }
            else if (IsResponseReasoningTextDone)
            {
                responseReasoningTextDone?.Invoke(ResponseReasoningTextDone!);
            }
            else if (IsResponseRefusalDelta)
            {
                responseRefusalDelta?.Invoke(ResponseRefusalDelta!);
            }
            else if (IsResponseRefusalDone)
            {
                responseRefusalDone?.Invoke(ResponseRefusalDone!);
            }
            else if (IsResponseOutputTextDelta)
            {
                responseOutputTextDelta?.Invoke(ResponseOutputTextDelta!);
            }
            else if (IsResponseOutputTextDone)
            {
                responseOutputTextDone?.Invoke(ResponseOutputTextDone!);
            }
            else if (IsResponseWebSearchCallCompleted)
            {
                responseWebSearchCallCompleted?.Invoke(ResponseWebSearchCallCompleted!);
            }
            else if (IsResponseWebSearchCallInProgress)
            {
                responseWebSearchCallInProgress?.Invoke(ResponseWebSearchCallInProgress!);
            }
            else if (IsResponseWebSearchCallSearching)
            {
                responseWebSearchCallSearching?.Invoke(ResponseWebSearchCallSearching!);
            }
            else if (IsResponseImageGenerationCallCompleted)
            {
                responseImageGenerationCallCompleted?.Invoke(ResponseImageGenerationCallCompleted!);
            }
            else if (IsResponseImageGenerationCallGenerating)
            {
                responseImageGenerationCallGenerating?.Invoke(ResponseImageGenerationCallGenerating!);
            }
            else if (IsResponseImageGenerationCallInProgress)
            {
                responseImageGenerationCallInProgress?.Invoke(ResponseImageGenerationCallInProgress!);
            }
            else if (IsResponseImageGenerationCallPartialImage)
            {
                responseImageGenerationCallPartialImage?.Invoke(ResponseImageGenerationCallPartialImage!);
            }
            else if (IsResponseMcpCallArgumentsDelta)
            {
                responseMcpCallArgumentsDelta?.Invoke(ResponseMcpCallArgumentsDelta!);
            }
            else if (IsResponseMcpCallArgumentsDone)
            {
                responseMcpCallArgumentsDone?.Invoke(ResponseMcpCallArgumentsDone!);
            }
            else if (IsResponseMcpCallCompleted)
            {
                responseMcpCallCompleted?.Invoke(ResponseMcpCallCompleted!);
            }
            else if (IsResponseMcpCallFailed)
            {
                responseMcpCallFailed?.Invoke(ResponseMcpCallFailed!);
            }
            else if (IsResponseMcpCallInProgress)
            {
                responseMcpCallInProgress?.Invoke(ResponseMcpCallInProgress!);
            }
            else if (IsResponseMcpListToolsCompleted)
            {
                responseMcpListToolsCompleted?.Invoke(ResponseMcpListToolsCompleted!);
            }
            else if (IsResponseMcpListToolsFailed)
            {
                responseMcpListToolsFailed?.Invoke(ResponseMcpListToolsFailed!);
            }
            else if (IsResponseMcpListToolsInProgress)
            {
                responseMcpListToolsInProgress?.Invoke(ResponseMcpListToolsInProgress!);
            }
            else if (IsResponseOutputTextAnnotationAdded)
            {
                responseOutputTextAnnotationAdded?.Invoke(ResponseOutputTextAnnotationAdded!);
            }
            else if (IsResponseQueued)
            {
                responseQueued?.Invoke(ResponseQueued!);
            }
            else if (IsResponseCustomToolCallInputDelta)
            {
                responseCustomToolCallInputDelta?.Invoke(ResponseCustomToolCallInputDelta!);
            }
            else if (IsResponseCustomToolCallInputDone)
            {
                responseCustomToolCallInputDone?.Invoke(ResponseCustomToolCallInputDone!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ResponseAudioDelta,
                typeof(global::tryAGI.OpenAI.ResponseAudioDeltaEvent),
                ResponseAudioDone,
                typeof(global::tryAGI.OpenAI.ResponseAudioDoneEvent),
                ResponseAudioTranscriptDelta,
                typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent),
                ResponseAudioTranscriptDone,
                typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent),
                ResponseCodeInterpreterCallCodeDelta,
                typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent),
                ResponseCodeInterpreterCallCodeDone,
                typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent),
                ResponseCodeInterpreterCallCompleted,
                typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent),
                ResponseCodeInterpreterCallInProgress,
                typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent),
                ResponseCodeInterpreterCallInterpreting,
                typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent),
                ResponseCompleted,
                typeof(global::tryAGI.OpenAI.ResponseCompletedEvent),
                ResponseContentPartAdded,
                typeof(global::tryAGI.OpenAI.ResponseContentPartAddedEvent),
                ResponseContentPartDone,
                typeof(global::tryAGI.OpenAI.ResponseContentPartDoneEvent),
                ResponseCreated,
                typeof(global::tryAGI.OpenAI.ResponseCreatedEvent),
                Error,
                typeof(global::tryAGI.OpenAI.ResponseErrorEvent),
                ResponseFileSearchCallCompleted,
                typeof(global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent),
                ResponseFileSearchCallInProgress,
                typeof(global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent),
                ResponseFileSearchCallSearching,
                typeof(global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent),
                ResponseFunctionCallArgumentsDelta,
                typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent),
                ResponseFunctionCallArgumentsDone,
                typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent),
                ResponseInProgress,
                typeof(global::tryAGI.OpenAI.ResponseInProgressEvent),
                ResponseFailed,
                typeof(global::tryAGI.OpenAI.ResponseFailedEvent),
                ResponseIncomplete,
                typeof(global::tryAGI.OpenAI.ResponseIncompleteEvent),
                ResponseOutputItemAdded,
                typeof(global::tryAGI.OpenAI.ResponseOutputItemAddedEvent),
                ResponseOutputItemDone,
                typeof(global::tryAGI.OpenAI.ResponseOutputItemDoneEvent),
                ResponseReasoningSummaryPartAdded,
                typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent),
                ResponseReasoningSummaryPartDone,
                typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent),
                ResponseReasoningSummaryTextDelta,
                typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent),
                ResponseReasoningSummaryTextDone,
                typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent),
                ResponseReasoningTextDelta,
                typeof(global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent),
                ResponseReasoningTextDone,
                typeof(global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent),
                ResponseRefusalDelta,
                typeof(global::tryAGI.OpenAI.ResponseRefusalDeltaEvent),
                ResponseRefusalDone,
                typeof(global::tryAGI.OpenAI.ResponseRefusalDoneEvent),
                ResponseOutputTextDelta,
                typeof(global::tryAGI.OpenAI.ResponseTextDeltaEvent),
                ResponseOutputTextDone,
                typeof(global::tryAGI.OpenAI.ResponseTextDoneEvent),
                ResponseWebSearchCallCompleted,
                typeof(global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent),
                ResponseWebSearchCallInProgress,
                typeof(global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent),
                ResponseWebSearchCallSearching,
                typeof(global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent),
                ResponseImageGenerationCallCompleted,
                typeof(global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent),
                ResponseImageGenerationCallGenerating,
                typeof(global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent),
                ResponseImageGenerationCallInProgress,
                typeof(global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent),
                ResponseImageGenerationCallPartialImage,
                typeof(global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent),
                ResponseMcpCallArgumentsDelta,
                typeof(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent),
                ResponseMcpCallArgumentsDone,
                typeof(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent),
                ResponseMcpCallCompleted,
                typeof(global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent),
                ResponseMcpCallFailed,
                typeof(global::tryAGI.OpenAI.ResponseMCPCallFailedEvent),
                ResponseMcpCallInProgress,
                typeof(global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent),
                ResponseMcpListToolsCompleted,
                typeof(global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent),
                ResponseMcpListToolsFailed,
                typeof(global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent),
                ResponseMcpListToolsInProgress,
                typeof(global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent),
                ResponseOutputTextAnnotationAdded,
                typeof(global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent),
                ResponseQueued,
                typeof(global::tryAGI.OpenAI.ResponseQueuedEvent),
                ResponseCustomToolCallInputDelta,
                typeof(global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent),
                ResponseCustomToolCallInputDone,
                typeof(global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ResponseStreamEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseAudioDeltaEvent?>.Default.Equals(ResponseAudioDelta, other.ResponseAudioDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseAudioDoneEvent?>.Default.Equals(ResponseAudioDone, other.ResponseAudioDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent?>.Default.Equals(ResponseAudioTranscriptDelta, other.ResponseAudioTranscriptDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent?>.Default.Equals(ResponseAudioTranscriptDone, other.ResponseAudioTranscriptDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent?>.Default.Equals(ResponseCodeInterpreterCallCodeDelta, other.ResponseCodeInterpreterCallCodeDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent?>.Default.Equals(ResponseCodeInterpreterCallCodeDone, other.ResponseCodeInterpreterCallCodeDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent?>.Default.Equals(ResponseCodeInterpreterCallCompleted, other.ResponseCodeInterpreterCallCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent?>.Default.Equals(ResponseCodeInterpreterCallInProgress, other.ResponseCodeInterpreterCallInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent?>.Default.Equals(ResponseCodeInterpreterCallInterpreting, other.ResponseCodeInterpreterCallInterpreting) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseCompletedEvent?>.Default.Equals(ResponseCompleted, other.ResponseCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseContentPartAddedEvent?>.Default.Equals(ResponseContentPartAdded, other.ResponseContentPartAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseContentPartDoneEvent?>.Default.Equals(ResponseContentPartDone, other.ResponseContentPartDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseCreatedEvent?>.Default.Equals(ResponseCreated, other.ResponseCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseErrorEvent?>.Default.Equals(Error, other.Error) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent?>.Default.Equals(ResponseFileSearchCallCompleted, other.ResponseFileSearchCallCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent?>.Default.Equals(ResponseFileSearchCallInProgress, other.ResponseFileSearchCallInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent?>.Default.Equals(ResponseFileSearchCallSearching, other.ResponseFileSearchCallSearching) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent?>.Default.Equals(ResponseFunctionCallArgumentsDelta, other.ResponseFunctionCallArgumentsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent?>.Default.Equals(ResponseFunctionCallArgumentsDone, other.ResponseFunctionCallArgumentsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseInProgressEvent?>.Default.Equals(ResponseInProgress, other.ResponseInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseFailedEvent?>.Default.Equals(ResponseFailed, other.ResponseFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseIncompleteEvent?>.Default.Equals(ResponseIncomplete, other.ResponseIncomplete) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent?>.Default.Equals(ResponseOutputItemAdded, other.ResponseOutputItemAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent?>.Default.Equals(ResponseOutputItemDone, other.ResponseOutputItemDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent?>.Default.Equals(ResponseReasoningSummaryPartAdded, other.ResponseReasoningSummaryPartAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent?>.Default.Equals(ResponseReasoningSummaryPartDone, other.ResponseReasoningSummaryPartDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent?>.Default.Equals(ResponseReasoningSummaryTextDelta, other.ResponseReasoningSummaryTextDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent?>.Default.Equals(ResponseReasoningSummaryTextDone, other.ResponseReasoningSummaryTextDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent?>.Default.Equals(ResponseReasoningTextDelta, other.ResponseReasoningTextDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent?>.Default.Equals(ResponseReasoningTextDone, other.ResponseReasoningTextDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent?>.Default.Equals(ResponseRefusalDelta, other.ResponseRefusalDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseRefusalDoneEvent?>.Default.Equals(ResponseRefusalDone, other.ResponseRefusalDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseTextDeltaEvent?>.Default.Equals(ResponseOutputTextDelta, other.ResponseOutputTextDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseTextDoneEvent?>.Default.Equals(ResponseOutputTextDone, other.ResponseOutputTextDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent?>.Default.Equals(ResponseWebSearchCallCompleted, other.ResponseWebSearchCallCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent?>.Default.Equals(ResponseWebSearchCallInProgress, other.ResponseWebSearchCallInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent?>.Default.Equals(ResponseWebSearchCallSearching, other.ResponseWebSearchCallSearching) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent?>.Default.Equals(ResponseImageGenerationCallCompleted, other.ResponseImageGenerationCallCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent?>.Default.Equals(ResponseImageGenerationCallGenerating, other.ResponseImageGenerationCallGenerating) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent?>.Default.Equals(ResponseImageGenerationCallInProgress, other.ResponseImageGenerationCallInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent?>.Default.Equals(ResponseImageGenerationCallPartialImage, other.ResponseImageGenerationCallPartialImage) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent?>.Default.Equals(ResponseMcpCallArgumentsDelta, other.ResponseMcpCallArgumentsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent?>.Default.Equals(ResponseMcpCallArgumentsDone, other.ResponseMcpCallArgumentsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent?>.Default.Equals(ResponseMcpCallCompleted, other.ResponseMcpCallCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent?>.Default.Equals(ResponseMcpCallFailed, other.ResponseMcpCallFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent?>.Default.Equals(ResponseMcpCallInProgress, other.ResponseMcpCallInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent?>.Default.Equals(ResponseMcpListToolsCompleted, other.ResponseMcpListToolsCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent?>.Default.Equals(ResponseMcpListToolsFailed, other.ResponseMcpListToolsFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent?>.Default.Equals(ResponseMcpListToolsInProgress, other.ResponseMcpListToolsInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent?>.Default.Equals(ResponseOutputTextAnnotationAdded, other.ResponseOutputTextAnnotationAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseQueuedEvent?>.Default.Equals(ResponseQueued, other.ResponseQueued) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent?>.Default.Equals(ResponseCustomToolCallInputDelta, other.ResponseCustomToolCallInputDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent?>.Default.Equals(ResponseCustomToolCallInputDone, other.ResponseCustomToolCallInputDone) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResponseStreamEvent obj1, ResponseStreamEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponseStreamEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResponseStreamEvent obj1, ResponseStreamEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponseStreamEvent o && Equals(o);
        }
    }
}
