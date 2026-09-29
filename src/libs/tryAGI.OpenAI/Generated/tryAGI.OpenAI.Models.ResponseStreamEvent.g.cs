#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Event emitted while a response is streamed.
    /// </summary>
    public readonly partial struct ResponseStreamEvent : global::System.IEquatable<ResponseStreamEvent>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseStreamEventDiscriminatorType? Type { get; }

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
        ///
        /// </summary>
        public bool TryPickResponseAudioDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseAudioDeltaEvent? value)
        {
            value = ResponseAudioDelta;
            return IsResponseAudioDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseAudioDeltaEvent PickResponseAudioDelta() => ResponseAudioDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseAudioDelta' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseAudioDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseAudioDoneEvent? value)
        {
            value = ResponseAudioDone;
            return IsResponseAudioDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseAudioDoneEvent PickResponseAudioDone() => ResponseAudioDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseAudioDone' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseAudioTranscriptDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent? value)
        {
            value = ResponseAudioTranscriptDelta;
            return IsResponseAudioTranscriptDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent PickResponseAudioTranscriptDelta() => ResponseAudioTranscriptDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseAudioTranscriptDelta' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseAudioTranscriptDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent? value)
        {
            value = ResponseAudioTranscriptDone;
            return IsResponseAudioTranscriptDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent PickResponseAudioTranscriptDone() => ResponseAudioTranscriptDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseAudioTranscriptDone' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseCodeInterpreterCallCodeDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent? value)
        {
            value = ResponseCodeInterpreterCallCodeDelta;
            return IsResponseCodeInterpreterCallCodeDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent PickResponseCodeInterpreterCallCodeDelta() => ResponseCodeInterpreterCallCodeDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCodeInterpreterCallCodeDelta' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseCodeInterpreterCallCodeDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent? value)
        {
            value = ResponseCodeInterpreterCallCodeDone;
            return IsResponseCodeInterpreterCallCodeDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent PickResponseCodeInterpreterCallCodeDone() => ResponseCodeInterpreterCallCodeDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCodeInterpreterCallCodeDone' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseCodeInterpreterCallCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent? value)
        {
            value = ResponseCodeInterpreterCallCompleted;
            return IsResponseCodeInterpreterCallCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent PickResponseCodeInterpreterCallCompleted() => ResponseCodeInterpreterCallCompleted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCodeInterpreterCallCompleted' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseCodeInterpreterCallInProgress(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent? value)
        {
            value = ResponseCodeInterpreterCallInProgress;
            return IsResponseCodeInterpreterCallInProgress;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent PickResponseCodeInterpreterCallInProgress() => ResponseCodeInterpreterCallInProgress is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCodeInterpreterCallInProgress' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseCodeInterpreterCallInterpreting(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent? value)
        {
            value = ResponseCodeInterpreterCallInterpreting;
            return IsResponseCodeInterpreterCallInterpreting;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent PickResponseCodeInterpreterCallInterpreting() => ResponseCodeInterpreterCallInterpreting is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCodeInterpreterCallInterpreting' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when new summary content is sampled for a compaction trigger. Contains no summary content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent? ResponseCompactionCompacting { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent? ResponseCompactionCompacting { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCompactionCompacting))]
#endif
        public bool IsResponseCompactionCompacting => ResponseCompactionCompacting != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseCompactionCompacting(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent? value)
        {
            value = ResponseCompactionCompacting;
            return IsResponseCompactionCompacting;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent PickResponseCompactionCompacting() => ResponseCompactionCompacting is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCompactionCompacting' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseCompletedEvent? value)
        {
            value = ResponseCompleted;
            return IsResponseCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCompletedEvent PickResponseCompleted() => ResponseCompleted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCompleted' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseContentPartAdded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseContentPartAddedEvent? value)
        {
            value = ResponseContentPartAdded;
            return IsResponseContentPartAdded;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseContentPartAddedEvent PickResponseContentPartAdded() => ResponseContentPartAdded is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseContentPartAdded' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseContentPartDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseContentPartDoneEvent? value)
        {
            value = ResponseContentPartDone;
            return IsResponseContentPartDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseContentPartDoneEvent PickResponseContentPartDone() => ResponseContentPartDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseContentPartDone' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseCreatedEvent? value)
        {
            value = ResponseCreated;
            return IsResponseCreated;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCreatedEvent PickResponseCreated() => ResponseCreated is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCreated' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseErrorEvent? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseErrorEvent PickError() => Error is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Error' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseFileSearchCallCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent? value)
        {
            value = ResponseFileSearchCallCompleted;
            return IsResponseFileSearchCallCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent PickResponseFileSearchCallCompleted() => ResponseFileSearchCallCompleted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseFileSearchCallCompleted' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseFileSearchCallInProgress(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent? value)
        {
            value = ResponseFileSearchCallInProgress;
            return IsResponseFileSearchCallInProgress;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent PickResponseFileSearchCallInProgress() => ResponseFileSearchCallInProgress is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseFileSearchCallInProgress' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseFileSearchCallSearching(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent? value)
        {
            value = ResponseFileSearchCallSearching;
            return IsResponseFileSearchCallSearching;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent PickResponseFileSearchCallSearching() => ResponseFileSearchCallSearching is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseFileSearchCallSearching' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseFunctionCallArgumentsDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent? value)
        {
            value = ResponseFunctionCallArgumentsDelta;
            return IsResponseFunctionCallArgumentsDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent PickResponseFunctionCallArgumentsDelta() => ResponseFunctionCallArgumentsDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseFunctionCallArgumentsDelta' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseFunctionCallArgumentsDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent? value)
        {
            value = ResponseFunctionCallArgumentsDone;
            return IsResponseFunctionCallArgumentsDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent PickResponseFunctionCallArgumentsDone() => ResponseFunctionCallArgumentsDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseFunctionCallArgumentsDone' but the value was {ToString()}.");

        /// <summary>
        /// A streaming event that indicated a shell command was added to a tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent? ResponseShellCallCommandAdded { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent? ResponseShellCallCommandAdded { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseShellCallCommandAdded))]
#endif
        public bool IsResponseShellCallCommandAdded => ResponseShellCallCommandAdded != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseShellCallCommandAdded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent? value)
        {
            value = ResponseShellCallCommandAdded;
            return IsResponseShellCallCommandAdded;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent PickResponseShellCallCommandAdded() => ResponseShellCallCommandAdded is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseShellCallCommandAdded' but the value was {ToString()}.");

        /// <summary>
        /// A streaming event that indicated a shell command was incrementally updated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent? ResponseShellCallCommandDelta { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent? ResponseShellCallCommandDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseShellCallCommandDelta))]
#endif
        public bool IsResponseShellCallCommandDelta => ResponseShellCallCommandDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseShellCallCommandDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent? value)
        {
            value = ResponseShellCallCommandDelta;
            return IsResponseShellCallCommandDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent PickResponseShellCallCommandDelta() => ResponseShellCallCommandDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseShellCallCommandDelta' but the value was {ToString()}.");

        /// <summary>
        /// A streaming event that indicated a shell command was completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent? ResponseShellCallCommandDone { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent? ResponseShellCallCommandDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseShellCallCommandDone))]
#endif
        public bool IsResponseShellCallCommandDone => ResponseShellCallCommandDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseShellCallCommandDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent? value)
        {
            value = ResponseShellCallCommandDone;
            return IsResponseShellCallCommandDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent PickResponseShellCallCommandDone() => ResponseShellCallCommandDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseShellCallCommandDone' but the value was {ToString()}.");

        /// <summary>
        /// A streaming event that indicated shell call output was incrementally added.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent? ResponseShellCallOutputContentDelta { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent? ResponseShellCallOutputContentDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseShellCallOutputContentDelta))]
#endif
        public bool IsResponseShellCallOutputContentDelta => ResponseShellCallOutputContentDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseShellCallOutputContentDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent? value)
        {
            value = ResponseShellCallOutputContentDelta;
            return IsResponseShellCallOutputContentDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent PickResponseShellCallOutputContentDelta() => ResponseShellCallOutputContentDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseShellCallOutputContentDelta' but the value was {ToString()}.");

        /// <summary>
        /// A streaming event that indicated shell call output was completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent? ResponseShellCallOutputContentDone { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent? ResponseShellCallOutputContentDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseShellCallOutputContentDone))]
#endif
        public bool IsResponseShellCallOutputContentDone => ResponseShellCallOutputContentDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseShellCallOutputContentDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent? value)
        {
            value = ResponseShellCallOutputContentDone;
            return IsResponseShellCallOutputContentDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent PickResponseShellCallOutputContentDone() => ResponseShellCallOutputContentDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseShellCallOutputContentDone' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseInProgress(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseInProgressEvent? value)
        {
            value = ResponseInProgress;
            return IsResponseInProgress;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseInProgressEvent PickResponseInProgress() => ResponseInProgress is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseInProgress' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseFailed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseFailedEvent? value)
        {
            value = ResponseFailed;
            return IsResponseFailed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseFailedEvent PickResponseFailed() => ResponseFailed is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseFailed' but the value was {ToString()}.");

        /// <summary>
        /// An event that is emitted when a response finishes as incomplete.<br/>
        /// Over WebSocket, steering can finish a response with<br/>
        /// `response.incomplete_details.reason` set to `steered`, followed automatically<br/>
        /// by a successor `response.created` that commits the queued steering input.
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
        ///
        /// </summary>
        public bool TryPickResponseIncomplete(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseIncompleteEvent? value)
        {
            value = ResponseIncomplete;
            return IsResponseIncomplete;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseIncompleteEvent PickResponseIncomplete() => ResponseIncomplete is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseIncomplete' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseOutputItemAdded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseOutputItemAddedEvent? value)
        {
            value = ResponseOutputItemAdded;
            return IsResponseOutputItemAdded;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputItemAddedEvent PickResponseOutputItemAdded() => ResponseOutputItemAdded is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputItemAdded' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseOutputItemDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseOutputItemDoneEvent? value)
        {
            value = ResponseOutputItemDone;
            return IsResponseOutputItemDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputItemDoneEvent PickResponseOutputItemDone() => ResponseOutputItemDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputItemDone' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseReasoningSummaryPartAdded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent? value)
        {
            value = ResponseReasoningSummaryPartAdded;
            return IsResponseReasoningSummaryPartAdded;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent PickResponseReasoningSummaryPartAdded() => ResponseReasoningSummaryPartAdded is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseReasoningSummaryPartAdded' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseReasoningSummaryPartDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent? value)
        {
            value = ResponseReasoningSummaryPartDone;
            return IsResponseReasoningSummaryPartDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent PickResponseReasoningSummaryPartDone() => ResponseReasoningSummaryPartDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseReasoningSummaryPartDone' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseReasoningSummaryTextDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent? value)
        {
            value = ResponseReasoningSummaryTextDelta;
            return IsResponseReasoningSummaryTextDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent PickResponseReasoningSummaryTextDelta() => ResponseReasoningSummaryTextDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseReasoningSummaryTextDelta' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseReasoningSummaryTextDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent? value)
        {
            value = ResponseReasoningSummaryTextDone;
            return IsResponseReasoningSummaryTextDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent PickResponseReasoningSummaryTextDone() => ResponseReasoningSummaryTextDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseReasoningSummaryTextDone' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseReasoningTextDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent? value)
        {
            value = ResponseReasoningTextDelta;
            return IsResponseReasoningTextDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent PickResponseReasoningTextDelta() => ResponseReasoningTextDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseReasoningTextDelta' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseReasoningTextDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent? value)
        {
            value = ResponseReasoningTextDone;
            return IsResponseReasoningTextDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent PickResponseReasoningTextDone() => ResponseReasoningTextDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseReasoningTextDone' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseRefusalDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseRefusalDeltaEvent? value)
        {
            value = ResponseRefusalDelta;
            return IsResponseRefusalDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseRefusalDeltaEvent PickResponseRefusalDelta() => ResponseRefusalDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseRefusalDelta' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseRefusalDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseRefusalDoneEvent? value)
        {
            value = ResponseRefusalDone;
            return IsResponseRefusalDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseRefusalDoneEvent PickResponseRefusalDone() => ResponseRefusalDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseRefusalDone' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseOutputTextDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseTextDeltaEvent? value)
        {
            value = ResponseOutputTextDelta;
            return IsResponseOutputTextDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseTextDeltaEvent PickResponseOutputTextDelta() => ResponseOutputTextDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputTextDelta' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseOutputTextDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseTextDoneEvent? value)
        {
            value = ResponseOutputTextDone;
            return IsResponseOutputTextDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseTextDoneEvent PickResponseOutputTextDone() => ResponseOutputTextDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputTextDone' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseWebSearchCallCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent? value)
        {
            value = ResponseWebSearchCallCompleted;
            return IsResponseWebSearchCallCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent PickResponseWebSearchCallCompleted() => ResponseWebSearchCallCompleted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseWebSearchCallCompleted' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseWebSearchCallInProgress(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent? value)
        {
            value = ResponseWebSearchCallInProgress;
            return IsResponseWebSearchCallInProgress;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent PickResponseWebSearchCallInProgress() => ResponseWebSearchCallInProgress is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseWebSearchCallInProgress' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseWebSearchCallSearching(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent? value)
        {
            value = ResponseWebSearchCallSearching;
            return IsResponseWebSearchCallSearching;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent PickResponseWebSearchCallSearching() => ResponseWebSearchCallSearching is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseWebSearchCallSearching' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseImageGenerationCallCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent? value)
        {
            value = ResponseImageGenerationCallCompleted;
            return IsResponseImageGenerationCallCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent PickResponseImageGenerationCallCompleted() => ResponseImageGenerationCallCompleted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseImageGenerationCallCompleted' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseImageGenerationCallGenerating(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent? value)
        {
            value = ResponseImageGenerationCallGenerating;
            return IsResponseImageGenerationCallGenerating;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent PickResponseImageGenerationCallGenerating() => ResponseImageGenerationCallGenerating is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseImageGenerationCallGenerating' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseImageGenerationCallInProgress(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent? value)
        {
            value = ResponseImageGenerationCallInProgress;
            return IsResponseImageGenerationCallInProgress;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent PickResponseImageGenerationCallInProgress() => ResponseImageGenerationCallInProgress is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseImageGenerationCallInProgress' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseImageGenerationCallPartialImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent? value)
        {
            value = ResponseImageGenerationCallPartialImage;
            return IsResponseImageGenerationCallPartialImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent PickResponseImageGenerationCallPartialImage() => ResponseImageGenerationCallPartialImage is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseImageGenerationCallPartialImage' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseMcpCallArgumentsDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent? value)
        {
            value = ResponseMcpCallArgumentsDelta;
            return IsResponseMcpCallArgumentsDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent PickResponseMcpCallArgumentsDelta() => ResponseMcpCallArgumentsDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseMcpCallArgumentsDelta' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseMcpCallArgumentsDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent? value)
        {
            value = ResponseMcpCallArgumentsDone;
            return IsResponseMcpCallArgumentsDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent PickResponseMcpCallArgumentsDone() => ResponseMcpCallArgumentsDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseMcpCallArgumentsDone' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseMcpCallCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent? value)
        {
            value = ResponseMcpCallCompleted;
            return IsResponseMcpCallCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent PickResponseMcpCallCompleted() => ResponseMcpCallCompleted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseMcpCallCompleted' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseMcpCallFailed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseMCPCallFailedEvent? value)
        {
            value = ResponseMcpCallFailed;
            return IsResponseMcpCallFailed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallFailedEvent PickResponseMcpCallFailed() => ResponseMcpCallFailed is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseMcpCallFailed' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseMcpCallInProgress(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent? value)
        {
            value = ResponseMcpCallInProgress;
            return IsResponseMcpCallInProgress;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent PickResponseMcpCallInProgress() => ResponseMcpCallInProgress is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseMcpCallInProgress' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseMcpListToolsCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent? value)
        {
            value = ResponseMcpListToolsCompleted;
            return IsResponseMcpListToolsCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent PickResponseMcpListToolsCompleted() => ResponseMcpListToolsCompleted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseMcpListToolsCompleted' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseMcpListToolsFailed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent? value)
        {
            value = ResponseMcpListToolsFailed;
            return IsResponseMcpListToolsFailed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent PickResponseMcpListToolsFailed() => ResponseMcpListToolsFailed is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseMcpListToolsFailed' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseMcpListToolsInProgress(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent? value)
        {
            value = ResponseMcpListToolsInProgress;
            return IsResponseMcpListToolsInProgress;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent PickResponseMcpListToolsInProgress() => ResponseMcpListToolsInProgress is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseMcpListToolsInProgress' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseOutputTextAnnotationAdded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent? value)
        {
            value = ResponseOutputTextAnnotationAdded;
            return IsResponseOutputTextAnnotationAdded;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent PickResponseOutputTextAnnotationAdded() => ResponseOutputTextAnnotationAdded is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputTextAnnotationAdded' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseQueued(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseQueuedEvent? value)
        {
            value = ResponseQueued;
            return IsResponseQueued;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseQueuedEvent PickResponseQueued() => ResponseQueued is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseQueued' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickResponseCustomToolCallInputDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent? value)
        {
            value = ResponseCustomToolCallInputDelta;
            return IsResponseCustomToolCallInputDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent PickResponseCustomToolCallInputDelta() => ResponseCustomToolCallInputDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCustomToolCallInputDelta' but the value was {ToString()}.");

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
        public bool TryPickResponseCustomToolCallInputDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent? value)
        {
            value = ResponseCustomToolCallInputDone;
            return IsResponseCustomToolCallInputDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent PickResponseCustomToolCallInputDone() => ResponseCustomToolCallInputDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCustomToolCallInputDone' but the value was {ToString()}.");
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
        public static ResponseStreamEvent FromResponseAudioDelta(global::tryAGI.OpenAI.ResponseAudioDeltaEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseAudioDone(global::tryAGI.OpenAI.ResponseAudioDoneEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseAudioTranscriptDelta(global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseAudioTranscriptDone(global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseCodeInterpreterCallCodeDelta(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseCodeInterpreterCallCodeDone(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseCodeInterpreterCallCompleted(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseCodeInterpreterCallInProgress(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseCodeInterpreterCallInterpreting(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent? value) => new ResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent?(ResponseStreamEvent @this) => @this.ResponseCompactionCompacting;

        /// <summary>
        ///
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent? value)
        {
            ResponseCompactionCompacting = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseStreamEvent FromResponseCompactionCompacting(global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseCompleted(global::tryAGI.OpenAI.ResponseCompletedEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseContentPartAdded(global::tryAGI.OpenAI.ResponseContentPartAddedEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseContentPartDone(global::tryAGI.OpenAI.ResponseContentPartDoneEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseCreated(global::tryAGI.OpenAI.ResponseCreatedEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromError(global::tryAGI.OpenAI.ResponseErrorEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseFileSearchCallCompleted(global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseFileSearchCallInProgress(global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseFileSearchCallSearching(global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseFunctionCallArgumentsDelta(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseFunctionCallArgumentsDone(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent? value) => new ResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent?(ResponseStreamEvent @this) => @this.ResponseShellCallCommandAdded;

        /// <summary>
        ///
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent? value)
        {
            ResponseShellCallCommandAdded = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseStreamEvent FromResponseShellCallCommandAdded(global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent? value) => new ResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent?(ResponseStreamEvent @this) => @this.ResponseShellCallCommandDelta;

        /// <summary>
        ///
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent? value)
        {
            ResponseShellCallCommandDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseStreamEvent FromResponseShellCallCommandDelta(global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent? value) => new ResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent?(ResponseStreamEvent @this) => @this.ResponseShellCallCommandDone;

        /// <summary>
        ///
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent? value)
        {
            ResponseShellCallCommandDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseStreamEvent FromResponseShellCallCommandDone(global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent? value) => new ResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent?(ResponseStreamEvent @this) => @this.ResponseShellCallOutputContentDelta;

        /// <summary>
        ///
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent? value)
        {
            ResponseShellCallOutputContentDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseStreamEvent FromResponseShellCallOutputContentDelta(global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent? value) => new ResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent?(ResponseStreamEvent @this) => @this.ResponseShellCallOutputContentDone;

        /// <summary>
        ///
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent? value)
        {
            ResponseShellCallOutputContentDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseStreamEvent FromResponseShellCallOutputContentDone(global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseInProgress(global::tryAGI.OpenAI.ResponseInProgressEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseFailed(global::tryAGI.OpenAI.ResponseFailedEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseIncomplete(global::tryAGI.OpenAI.ResponseIncompleteEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseOutputItemAdded(global::tryAGI.OpenAI.ResponseOutputItemAddedEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseOutputItemDone(global::tryAGI.OpenAI.ResponseOutputItemDoneEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseReasoningSummaryPartAdded(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseReasoningSummaryPartDone(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseReasoningSummaryTextDelta(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseReasoningSummaryTextDone(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseReasoningTextDelta(global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseReasoningTextDone(global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseRefusalDelta(global::tryAGI.OpenAI.ResponseRefusalDeltaEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseRefusalDone(global::tryAGI.OpenAI.ResponseRefusalDoneEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseOutputTextDelta(global::tryAGI.OpenAI.ResponseTextDeltaEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseOutputTextDone(global::tryAGI.OpenAI.ResponseTextDoneEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseWebSearchCallCompleted(global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseWebSearchCallInProgress(global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseWebSearchCallSearching(global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseImageGenerationCallCompleted(global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseImageGenerationCallGenerating(global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseImageGenerationCallInProgress(global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseImageGenerationCallPartialImage(global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseMcpCallArgumentsDelta(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseMcpCallArgumentsDone(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseMcpCallCompleted(global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseMcpCallFailed(global::tryAGI.OpenAI.ResponseMCPCallFailedEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseMcpCallInProgress(global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseMcpListToolsCompleted(global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseMcpListToolsFailed(global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseMcpListToolsInProgress(global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseOutputTextAnnotationAdded(global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseQueued(global::tryAGI.OpenAI.ResponseQueuedEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseCustomToolCallInputDelta(global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent? value) => new ResponseStreamEvent(value);

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
        public static ResponseStreamEvent FromResponseCustomToolCallInputDone(global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent? value) => new ResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public ResponseStreamEvent(
            global::tryAGI.OpenAI.ResponseStreamEventDiscriminatorType? type,
            global::tryAGI.OpenAI.ResponseAudioDeltaEvent? responseAudioDelta,
            global::tryAGI.OpenAI.ResponseAudioDoneEvent? responseAudioDone,
            global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent? responseAudioTranscriptDelta,
            global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent? responseAudioTranscriptDone,
            global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent? responseCodeInterpreterCallCodeDelta,
            global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent? responseCodeInterpreterCallCodeDone,
            global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent? responseCodeInterpreterCallCompleted,
            global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent? responseCodeInterpreterCallInProgress,
            global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent? responseCodeInterpreterCallInterpreting,
            global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent? responseCompactionCompacting,
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
            global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent? responseShellCallCommandAdded,
            global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent? responseShellCallCommandDelta,
            global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent? responseShellCallCommandDone,
            global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent? responseShellCallOutputContentDelta,
            global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent? responseShellCallOutputContentDone,
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
            Type = type;

            ResponseAudioDelta = responseAudioDelta;
            ResponseAudioDone = responseAudioDone;
            ResponseAudioTranscriptDelta = responseAudioTranscriptDelta;
            ResponseAudioTranscriptDone = responseAudioTranscriptDone;
            ResponseCodeInterpreterCallCodeDelta = responseCodeInterpreterCallCodeDelta;
            ResponseCodeInterpreterCallCodeDone = responseCodeInterpreterCallCodeDone;
            ResponseCodeInterpreterCallCompleted = responseCodeInterpreterCallCompleted;
            ResponseCodeInterpreterCallInProgress = responseCodeInterpreterCallInProgress;
            ResponseCodeInterpreterCallInterpreting = responseCodeInterpreterCallInterpreting;
            ResponseCompactionCompacting = responseCompactionCompacting;
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
            ResponseShellCallCommandAdded = responseShellCallCommandAdded;
            ResponseShellCallCommandDelta = responseShellCallCommandDelta;
            ResponseShellCallCommandDone = responseShellCallCommandDone;
            ResponseShellCallOutputContentDelta = responseShellCallOutputContentDelta;
            ResponseShellCallOutputContentDone = responseShellCallOutputContentDone;
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
            ResponseShellCallOutputContentDone as object ??
            ResponseShellCallOutputContentDelta as object ??
            ResponseShellCallCommandDone as object ??
            ResponseShellCallCommandDelta as object ??
            ResponseShellCallCommandAdded as object ??
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
            ResponseCompactionCompacting as object ??
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
            ResponseCompactionCompacting?.ToString() ??
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
            ResponseShellCallCommandAdded?.ToString() ??
            ResponseShellCallCommandDelta?.ToString() ??
            ResponseShellCallCommandDone?.ToString() ??
            ResponseShellCallOutputContentDelta?.ToString() ??
            ResponseShellCallOutputContentDone?.ToString() ??
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
            return IsResponseAudioDelta || IsResponseAudioDone || IsResponseAudioTranscriptDelta || IsResponseAudioTranscriptDone || IsResponseCodeInterpreterCallCodeDelta || IsResponseCodeInterpreterCallCodeDone || IsResponseCodeInterpreterCallCompleted || IsResponseCodeInterpreterCallInProgress || IsResponseCodeInterpreterCallInterpreting || IsResponseCompactionCompacting || IsResponseCompleted || IsResponseContentPartAdded || IsResponseContentPartDone || IsResponseCreated || IsError || IsResponseFileSearchCallCompleted || IsResponseFileSearchCallInProgress || IsResponseFileSearchCallSearching || IsResponseFunctionCallArgumentsDelta || IsResponseFunctionCallArgumentsDone || IsResponseShellCallCommandAdded || IsResponseShellCallCommandDelta || IsResponseShellCallCommandDone || IsResponseShellCallOutputContentDelta || IsResponseShellCallOutputContentDone || IsResponseInProgress || IsResponseFailed || IsResponseIncomplete || IsResponseOutputItemAdded || IsResponseOutputItemDone || IsResponseReasoningSummaryPartAdded || IsResponseReasoningSummaryPartDone || IsResponseReasoningSummaryTextDelta || IsResponseReasoningSummaryTextDone || IsResponseReasoningTextDelta || IsResponseReasoningTextDone || IsResponseRefusalDelta || IsResponseRefusalDone || IsResponseOutputTextDelta || IsResponseOutputTextDone || IsResponseWebSearchCallCompleted || IsResponseWebSearchCallInProgress || IsResponseWebSearchCallSearching || IsResponseImageGenerationCallCompleted || IsResponseImageGenerationCallGenerating || IsResponseImageGenerationCallInProgress || IsResponseImageGenerationCallPartialImage || IsResponseMcpCallArgumentsDelta || IsResponseMcpCallArgumentsDone || IsResponseMcpCallCompleted || IsResponseMcpCallFailed || IsResponseMcpCallInProgress || IsResponseMcpListToolsCompleted || IsResponseMcpListToolsFailed || IsResponseMcpListToolsInProgress || IsResponseOutputTextAnnotationAdded || IsResponseQueued || IsResponseCustomToolCallInputDelta || IsResponseCustomToolCallInputDone;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ResponseAudioDeltaEvent, TResult>? responseAudioDelta = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseAudioDoneEvent, TResult>? responseAudioDone = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent, TResult>? responseAudioTranscriptDelta = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent, TResult>? responseAudioTranscriptDone = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent, TResult>? responseCodeInterpreterCallCodeDelta = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent, TResult>? responseCodeInterpreterCallCodeDone = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent, TResult>? responseCodeInterpreterCallCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent, TResult>? responseCodeInterpreterCallInProgress = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent, TResult>? responseCodeInterpreterCallInterpreting = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent, TResult>? responseCompactionCompacting = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseCompletedEvent, TResult>? responseCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseContentPartAddedEvent, TResult>? responseContentPartAdded = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseContentPartDoneEvent, TResult>? responseContentPartDone = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseCreatedEvent, TResult>? responseCreated = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseErrorEvent, TResult>? error = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent, TResult>? responseFileSearchCallCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent, TResult>? responseFileSearchCallInProgress = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent, TResult>? responseFileSearchCallSearching = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent, TResult>? responseFunctionCallArgumentsDelta = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent, TResult>? responseFunctionCallArgumentsDone = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent, TResult>? responseShellCallCommandAdded = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent, TResult>? responseShellCallCommandDelta = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent, TResult>? responseShellCallCommandDone = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent, TResult>? responseShellCallOutputContentDelta = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent, TResult>? responseShellCallOutputContentDone = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseInProgressEvent, TResult>? responseInProgress = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseFailedEvent, TResult>? responseFailed = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseIncompleteEvent, TResult>? responseIncomplete = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent, TResult>? responseOutputItemAdded = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent, TResult>? responseOutputItemDone = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent, TResult>? responseReasoningSummaryPartAdded = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent, TResult>? responseReasoningSummaryPartDone = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent, TResult>? responseReasoningSummaryTextDelta = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent, TResult>? responseReasoningSummaryTextDone = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent, TResult>? responseReasoningTextDelta = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent, TResult>? responseReasoningTextDone = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent, TResult>? responseRefusalDelta = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseRefusalDoneEvent, TResult>? responseRefusalDone = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseTextDeltaEvent, TResult>? responseOutputTextDelta = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseTextDoneEvent, TResult>? responseOutputTextDone = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent, TResult>? responseWebSearchCallCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent, TResult>? responseWebSearchCallInProgress = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent, TResult>? responseWebSearchCallSearching = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent, TResult>? responseImageGenerationCallCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent, TResult>? responseImageGenerationCallGenerating = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent, TResult>? responseImageGenerationCallInProgress = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent, TResult>? responseImageGenerationCallPartialImage = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent, TResult>? responseMcpCallArgumentsDelta = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent, TResult>? responseMcpCallArgumentsDone = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent, TResult>? responseMcpCallCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent, TResult>? responseMcpCallFailed = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent, TResult>? responseMcpCallInProgress = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent, TResult>? responseMcpListToolsCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent, TResult>? responseMcpListToolsFailed = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent, TResult>? responseMcpListToolsInProgress = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent, TResult>? responseOutputTextAnnotationAdded = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseQueuedEvent, TResult>? responseQueued = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent, TResult>? responseCustomToolCallInputDelta = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent, TResult>? responseCustomToolCallInputDone = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ResponseAudioDelta is { } __value0 && responseAudioDelta != null)
            {
                return responseAudioDelta(__value0);
            }
            else if (ResponseAudioDone is { } __value1 && responseAudioDone != null)
            {
                return responseAudioDone(__value1);
            }
            else if (ResponseAudioTranscriptDelta is { } __value2 && responseAudioTranscriptDelta != null)
            {
                return responseAudioTranscriptDelta(__value2);
            }
            else if (ResponseAudioTranscriptDone is { } __value3 && responseAudioTranscriptDone != null)
            {
                return responseAudioTranscriptDone(__value3);
            }
            else if (ResponseCodeInterpreterCallCodeDelta is { } __value4 && responseCodeInterpreterCallCodeDelta != null)
            {
                return responseCodeInterpreterCallCodeDelta(__value4);
            }
            else if (ResponseCodeInterpreterCallCodeDone is { } __value5 && responseCodeInterpreterCallCodeDone != null)
            {
                return responseCodeInterpreterCallCodeDone(__value5);
            }
            else if (ResponseCodeInterpreterCallCompleted is { } __value6 && responseCodeInterpreterCallCompleted != null)
            {
                return responseCodeInterpreterCallCompleted(__value6);
            }
            else if (ResponseCodeInterpreterCallInProgress is { } __value7 && responseCodeInterpreterCallInProgress != null)
            {
                return responseCodeInterpreterCallInProgress(__value7);
            }
            else if (ResponseCodeInterpreterCallInterpreting is { } __value8 && responseCodeInterpreterCallInterpreting != null)
            {
                return responseCodeInterpreterCallInterpreting(__value8);
            }
            else if (ResponseCompactionCompacting is { } __value9 && responseCompactionCompacting != null)
            {
                return responseCompactionCompacting(__value9);
            }
            else if (ResponseCompleted is { } __value10 && responseCompleted != null)
            {
                return responseCompleted(__value10);
            }
            else if (ResponseContentPartAdded is { } __value11 && responseContentPartAdded != null)
            {
                return responseContentPartAdded(__value11);
            }
            else if (ResponseContentPartDone is { } __value12 && responseContentPartDone != null)
            {
                return responseContentPartDone(__value12);
            }
            else if (ResponseCreated is { } __value13 && responseCreated != null)
            {
                return responseCreated(__value13);
            }
            else if (Error is { } __value14 && error != null)
            {
                return error(__value14);
            }
            else if (ResponseFileSearchCallCompleted is { } __value15 && responseFileSearchCallCompleted != null)
            {
                return responseFileSearchCallCompleted(__value15);
            }
            else if (ResponseFileSearchCallInProgress is { } __value16 && responseFileSearchCallInProgress != null)
            {
                return responseFileSearchCallInProgress(__value16);
            }
            else if (ResponseFileSearchCallSearching is { } __value17 && responseFileSearchCallSearching != null)
            {
                return responseFileSearchCallSearching(__value17);
            }
            else if (ResponseFunctionCallArgumentsDelta is { } __value18 && responseFunctionCallArgumentsDelta != null)
            {
                return responseFunctionCallArgumentsDelta(__value18);
            }
            else if (ResponseFunctionCallArgumentsDone is { } __value19 && responseFunctionCallArgumentsDone != null)
            {
                return responseFunctionCallArgumentsDone(__value19);
            }
            else if (ResponseShellCallCommandAdded is { } __value20 && responseShellCallCommandAdded != null)
            {
                return responseShellCallCommandAdded(__value20);
            }
            else if (ResponseShellCallCommandDelta is { } __value21 && responseShellCallCommandDelta != null)
            {
                return responseShellCallCommandDelta(__value21);
            }
            else if (ResponseShellCallCommandDone is { } __value22 && responseShellCallCommandDone != null)
            {
                return responseShellCallCommandDone(__value22);
            }
            else if (ResponseShellCallOutputContentDelta is { } __value23 && responseShellCallOutputContentDelta != null)
            {
                return responseShellCallOutputContentDelta(__value23);
            }
            else if (ResponseShellCallOutputContentDone is { } __value24 && responseShellCallOutputContentDone != null)
            {
                return responseShellCallOutputContentDone(__value24);
            }
            else if (ResponseInProgress is { } __value25 && responseInProgress != null)
            {
                return responseInProgress(__value25);
            }
            else if (ResponseFailed is { } __value26 && responseFailed != null)
            {
                return responseFailed(__value26);
            }
            else if (ResponseIncomplete is { } __value27 && responseIncomplete != null)
            {
                return responseIncomplete(__value27);
            }
            else if (ResponseOutputItemAdded is { } __value28 && responseOutputItemAdded != null)
            {
                return responseOutputItemAdded(__value28);
            }
            else if (ResponseOutputItemDone is { } __value29 && responseOutputItemDone != null)
            {
                return responseOutputItemDone(__value29);
            }
            else if (ResponseReasoningSummaryPartAdded is { } __value30 && responseReasoningSummaryPartAdded != null)
            {
                return responseReasoningSummaryPartAdded(__value30);
            }
            else if (ResponseReasoningSummaryPartDone is { } __value31 && responseReasoningSummaryPartDone != null)
            {
                return responseReasoningSummaryPartDone(__value31);
            }
            else if (ResponseReasoningSummaryTextDelta is { } __value32 && responseReasoningSummaryTextDelta != null)
            {
                return responseReasoningSummaryTextDelta(__value32);
            }
            else if (ResponseReasoningSummaryTextDone is { } __value33 && responseReasoningSummaryTextDone != null)
            {
                return responseReasoningSummaryTextDone(__value33);
            }
            else if (ResponseReasoningTextDelta is { } __value34 && responseReasoningTextDelta != null)
            {
                return responseReasoningTextDelta(__value34);
            }
            else if (ResponseReasoningTextDone is { } __value35 && responseReasoningTextDone != null)
            {
                return responseReasoningTextDone(__value35);
            }
            else if (ResponseRefusalDelta is { } __value36 && responseRefusalDelta != null)
            {
                return responseRefusalDelta(__value36);
            }
            else if (ResponseRefusalDone is { } __value37 && responseRefusalDone != null)
            {
                return responseRefusalDone(__value37);
            }
            else if (ResponseOutputTextDelta is { } __value38 && responseOutputTextDelta != null)
            {
                return responseOutputTextDelta(__value38);
            }
            else if (ResponseOutputTextDone is { } __value39 && responseOutputTextDone != null)
            {
                return responseOutputTextDone(__value39);
            }
            else if (ResponseWebSearchCallCompleted is { } __value40 && responseWebSearchCallCompleted != null)
            {
                return responseWebSearchCallCompleted(__value40);
            }
            else if (ResponseWebSearchCallInProgress is { } __value41 && responseWebSearchCallInProgress != null)
            {
                return responseWebSearchCallInProgress(__value41);
            }
            else if (ResponseWebSearchCallSearching is { } __value42 && responseWebSearchCallSearching != null)
            {
                return responseWebSearchCallSearching(__value42);
            }
            else if (ResponseImageGenerationCallCompleted is { } __value43 && responseImageGenerationCallCompleted != null)
            {
                return responseImageGenerationCallCompleted(__value43);
            }
            else if (ResponseImageGenerationCallGenerating is { } __value44 && responseImageGenerationCallGenerating != null)
            {
                return responseImageGenerationCallGenerating(__value44);
            }
            else if (ResponseImageGenerationCallInProgress is { } __value45 && responseImageGenerationCallInProgress != null)
            {
                return responseImageGenerationCallInProgress(__value45);
            }
            else if (ResponseImageGenerationCallPartialImage is { } __value46 && responseImageGenerationCallPartialImage != null)
            {
                return responseImageGenerationCallPartialImage(__value46);
            }
            else if (ResponseMcpCallArgumentsDelta is { } __value47 && responseMcpCallArgumentsDelta != null)
            {
                return responseMcpCallArgumentsDelta(__value47);
            }
            else if (ResponseMcpCallArgumentsDone is { } __value48 && responseMcpCallArgumentsDone != null)
            {
                return responseMcpCallArgumentsDone(__value48);
            }
            else if (ResponseMcpCallCompleted is { } __value49 && responseMcpCallCompleted != null)
            {
                return responseMcpCallCompleted(__value49);
            }
            else if (ResponseMcpCallFailed is { } __value50 && responseMcpCallFailed != null)
            {
                return responseMcpCallFailed(__value50);
            }
            else if (ResponseMcpCallInProgress is { } __value51 && responseMcpCallInProgress != null)
            {
                return responseMcpCallInProgress(__value51);
            }
            else if (ResponseMcpListToolsCompleted is { } __value52 && responseMcpListToolsCompleted != null)
            {
                return responseMcpListToolsCompleted(__value52);
            }
            else if (ResponseMcpListToolsFailed is { } __value53 && responseMcpListToolsFailed != null)
            {
                return responseMcpListToolsFailed(__value53);
            }
            else if (ResponseMcpListToolsInProgress is { } __value54 && responseMcpListToolsInProgress != null)
            {
                return responseMcpListToolsInProgress(__value54);
            }
            else if (ResponseOutputTextAnnotationAdded is { } __value55 && responseOutputTextAnnotationAdded != null)
            {
                return responseOutputTextAnnotationAdded(__value55);
            }
            else if (ResponseQueued is { } __value56 && responseQueued != null)
            {
                return responseQueued(__value56);
            }
            else if (ResponseCustomToolCallInputDelta is { } __value57 && responseCustomToolCallInputDelta != null)
            {
                return responseCustomToolCallInputDelta(__value57);
            }
            else if (ResponseCustomToolCallInputDone is { } __value58 && responseCustomToolCallInputDone != null)
            {
                return responseCustomToolCallInputDone(__value58);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.ResponseAudioDeltaEvent>? responseAudioDelta = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseAudioDoneEvent>? responseAudioDone = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent>? responseAudioTranscriptDelta = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent>? responseAudioTranscriptDone = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent>? responseCodeInterpreterCallCodeDelta = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent>? responseCodeInterpreterCallCodeDone = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent>? responseCodeInterpreterCallCompleted = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent>? responseCodeInterpreterCallInProgress = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent>? responseCodeInterpreterCallInterpreting = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent>? responseCompactionCompacting = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseCompletedEvent>? responseCompleted = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseContentPartAddedEvent>? responseContentPartAdded = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseContentPartDoneEvent>? responseContentPartDone = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseCreatedEvent>? responseCreated = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseErrorEvent>? error = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent>? responseFileSearchCallCompleted = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent>? responseFileSearchCallInProgress = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent>? responseFileSearchCallSearching = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent>? responseFunctionCallArgumentsDelta = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent>? responseFunctionCallArgumentsDone = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent>? responseShellCallCommandAdded = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent>? responseShellCallCommandDelta = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent>? responseShellCallCommandDone = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent>? responseShellCallOutputContentDelta = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent>? responseShellCallOutputContentDone = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseInProgressEvent>? responseInProgress = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseFailedEvent>? responseFailed = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseIncompleteEvent>? responseIncomplete = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent>? responseOutputItemAdded = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent>? responseOutputItemDone = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent>? responseReasoningSummaryPartAdded = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent>? responseReasoningSummaryPartDone = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent>? responseReasoningSummaryTextDelta = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent>? responseReasoningSummaryTextDone = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent>? responseReasoningTextDelta = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent>? responseReasoningTextDone = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent>? responseRefusalDelta = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseRefusalDoneEvent>? responseRefusalDone = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseTextDeltaEvent>? responseOutputTextDelta = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseTextDoneEvent>? responseOutputTextDone = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent>? responseWebSearchCallCompleted = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent>? responseWebSearchCallInProgress = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent>? responseWebSearchCallSearching = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent>? responseImageGenerationCallCompleted = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent>? responseImageGenerationCallGenerating = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent>? responseImageGenerationCallInProgress = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent>? responseImageGenerationCallPartialImage = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent>? responseMcpCallArgumentsDelta = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent>? responseMcpCallArgumentsDone = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent>? responseMcpCallCompleted = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent>? responseMcpCallFailed = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent>? responseMcpCallInProgress = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent>? responseMcpListToolsCompleted = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent>? responseMcpListToolsFailed = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent>? responseMcpListToolsInProgress = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent>? responseOutputTextAnnotationAdded = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseQueuedEvent>? responseQueued = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent>? responseCustomToolCallInputDelta = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent>? responseCustomToolCallInputDone = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ResponseAudioDelta is { } __value0)
            {
                responseAudioDelta?.Invoke(__value0);
            }
            else if (ResponseAudioDone is { } __value1)
            {
                responseAudioDone?.Invoke(__value1);
            }
            else if (ResponseAudioTranscriptDelta is { } __value2)
            {
                responseAudioTranscriptDelta?.Invoke(__value2);
            }
            else if (ResponseAudioTranscriptDone is { } __value3)
            {
                responseAudioTranscriptDone?.Invoke(__value3);
            }
            else if (ResponseCodeInterpreterCallCodeDelta is { } __value4)
            {
                responseCodeInterpreterCallCodeDelta?.Invoke(__value4);
            }
            else if (ResponseCodeInterpreterCallCodeDone is { } __value5)
            {
                responseCodeInterpreterCallCodeDone?.Invoke(__value5);
            }
            else if (ResponseCodeInterpreterCallCompleted is { } __value6)
            {
                responseCodeInterpreterCallCompleted?.Invoke(__value6);
            }
            else if (ResponseCodeInterpreterCallInProgress is { } __value7)
            {
                responseCodeInterpreterCallInProgress?.Invoke(__value7);
            }
            else if (ResponseCodeInterpreterCallInterpreting is { } __value8)
            {
                responseCodeInterpreterCallInterpreting?.Invoke(__value8);
            }
            else if (ResponseCompactionCompacting is { } __value9)
            {
                responseCompactionCompacting?.Invoke(__value9);
            }
            else if (ResponseCompleted is { } __value10)
            {
                responseCompleted?.Invoke(__value10);
            }
            else if (ResponseContentPartAdded is { } __value11)
            {
                responseContentPartAdded?.Invoke(__value11);
            }
            else if (ResponseContentPartDone is { } __value12)
            {
                responseContentPartDone?.Invoke(__value12);
            }
            else if (ResponseCreated is { } __value13)
            {
                responseCreated?.Invoke(__value13);
            }
            else if (Error is { } __value14)
            {
                error?.Invoke(__value14);
            }
            else if (ResponseFileSearchCallCompleted is { } __value15)
            {
                responseFileSearchCallCompleted?.Invoke(__value15);
            }
            else if (ResponseFileSearchCallInProgress is { } __value16)
            {
                responseFileSearchCallInProgress?.Invoke(__value16);
            }
            else if (ResponseFileSearchCallSearching is { } __value17)
            {
                responseFileSearchCallSearching?.Invoke(__value17);
            }
            else if (ResponseFunctionCallArgumentsDelta is { } __value18)
            {
                responseFunctionCallArgumentsDelta?.Invoke(__value18);
            }
            else if (ResponseFunctionCallArgumentsDone is { } __value19)
            {
                responseFunctionCallArgumentsDone?.Invoke(__value19);
            }
            else if (ResponseShellCallCommandAdded is { } __value20)
            {
                responseShellCallCommandAdded?.Invoke(__value20);
            }
            else if (ResponseShellCallCommandDelta is { } __value21)
            {
                responseShellCallCommandDelta?.Invoke(__value21);
            }
            else if (ResponseShellCallCommandDone is { } __value22)
            {
                responseShellCallCommandDone?.Invoke(__value22);
            }
            else if (ResponseShellCallOutputContentDelta is { } __value23)
            {
                responseShellCallOutputContentDelta?.Invoke(__value23);
            }
            else if (ResponseShellCallOutputContentDone is { } __value24)
            {
                responseShellCallOutputContentDone?.Invoke(__value24);
            }
            else if (ResponseInProgress is { } __value25)
            {
                responseInProgress?.Invoke(__value25);
            }
            else if (ResponseFailed is { } __value26)
            {
                responseFailed?.Invoke(__value26);
            }
            else if (ResponseIncomplete is { } __value27)
            {
                responseIncomplete?.Invoke(__value27);
            }
            else if (ResponseOutputItemAdded is { } __value28)
            {
                responseOutputItemAdded?.Invoke(__value28);
            }
            else if (ResponseOutputItemDone is { } __value29)
            {
                responseOutputItemDone?.Invoke(__value29);
            }
            else if (ResponseReasoningSummaryPartAdded is { } __value30)
            {
                responseReasoningSummaryPartAdded?.Invoke(__value30);
            }
            else if (ResponseReasoningSummaryPartDone is { } __value31)
            {
                responseReasoningSummaryPartDone?.Invoke(__value31);
            }
            else if (ResponseReasoningSummaryTextDelta is { } __value32)
            {
                responseReasoningSummaryTextDelta?.Invoke(__value32);
            }
            else if (ResponseReasoningSummaryTextDone is { } __value33)
            {
                responseReasoningSummaryTextDone?.Invoke(__value33);
            }
            else if (ResponseReasoningTextDelta is { } __value34)
            {
                responseReasoningTextDelta?.Invoke(__value34);
            }
            else if (ResponseReasoningTextDone is { } __value35)
            {
                responseReasoningTextDone?.Invoke(__value35);
            }
            else if (ResponseRefusalDelta is { } __value36)
            {
                responseRefusalDelta?.Invoke(__value36);
            }
            else if (ResponseRefusalDone is { } __value37)
            {
                responseRefusalDone?.Invoke(__value37);
            }
            else if (ResponseOutputTextDelta is { } __value38)
            {
                responseOutputTextDelta?.Invoke(__value38);
            }
            else if (ResponseOutputTextDone is { } __value39)
            {
                responseOutputTextDone?.Invoke(__value39);
            }
            else if (ResponseWebSearchCallCompleted is { } __value40)
            {
                responseWebSearchCallCompleted?.Invoke(__value40);
            }
            else if (ResponseWebSearchCallInProgress is { } __value41)
            {
                responseWebSearchCallInProgress?.Invoke(__value41);
            }
            else if (ResponseWebSearchCallSearching is { } __value42)
            {
                responseWebSearchCallSearching?.Invoke(__value42);
            }
            else if (ResponseImageGenerationCallCompleted is { } __value43)
            {
                responseImageGenerationCallCompleted?.Invoke(__value43);
            }
            else if (ResponseImageGenerationCallGenerating is { } __value44)
            {
                responseImageGenerationCallGenerating?.Invoke(__value44);
            }
            else if (ResponseImageGenerationCallInProgress is { } __value45)
            {
                responseImageGenerationCallInProgress?.Invoke(__value45);
            }
            else if (ResponseImageGenerationCallPartialImage is { } __value46)
            {
                responseImageGenerationCallPartialImage?.Invoke(__value46);
            }
            else if (ResponseMcpCallArgumentsDelta is { } __value47)
            {
                responseMcpCallArgumentsDelta?.Invoke(__value47);
            }
            else if (ResponseMcpCallArgumentsDone is { } __value48)
            {
                responseMcpCallArgumentsDone?.Invoke(__value48);
            }
            else if (ResponseMcpCallCompleted is { } __value49)
            {
                responseMcpCallCompleted?.Invoke(__value49);
            }
            else if (ResponseMcpCallFailed is { } __value50)
            {
                responseMcpCallFailed?.Invoke(__value50);
            }
            else if (ResponseMcpCallInProgress is { } __value51)
            {
                responseMcpCallInProgress?.Invoke(__value51);
            }
            else if (ResponseMcpListToolsCompleted is { } __value52)
            {
                responseMcpListToolsCompleted?.Invoke(__value52);
            }
            else if (ResponseMcpListToolsFailed is { } __value53)
            {
                responseMcpListToolsFailed?.Invoke(__value53);
            }
            else if (ResponseMcpListToolsInProgress is { } __value54)
            {
                responseMcpListToolsInProgress?.Invoke(__value54);
            }
            else if (ResponseOutputTextAnnotationAdded is { } __value55)
            {
                responseOutputTextAnnotationAdded?.Invoke(__value55);
            }
            else if (ResponseQueued is { } __value56)
            {
                responseQueued?.Invoke(__value56);
            }
            else if (ResponseCustomToolCallInputDelta is { } __value57)
            {
                responseCustomToolCallInputDelta?.Invoke(__value57);
            }
            else if (ResponseCustomToolCallInputDone is { } __value58)
            {
                responseCustomToolCallInputDone?.Invoke(__value58);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.ResponseAudioDeltaEvent>? responseAudioDelta = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseAudioDoneEvent>? responseAudioDone = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent>? responseAudioTranscriptDelta = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent>? responseAudioTranscriptDone = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent>? responseCodeInterpreterCallCodeDelta = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent>? responseCodeInterpreterCallCodeDone = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent>? responseCodeInterpreterCallCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent>? responseCodeInterpreterCallInProgress = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent>? responseCodeInterpreterCallInterpreting = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent>? responseCompactionCompacting = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseCompletedEvent>? responseCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseContentPartAddedEvent>? responseContentPartAdded = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseContentPartDoneEvent>? responseContentPartDone = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseCreatedEvent>? responseCreated = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseErrorEvent>? error = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent>? responseFileSearchCallCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent>? responseFileSearchCallInProgress = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent>? responseFileSearchCallSearching = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent>? responseFunctionCallArgumentsDelta = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent>? responseFunctionCallArgumentsDone = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent>? responseShellCallCommandAdded = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent>? responseShellCallCommandDelta = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent>? responseShellCallCommandDone = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent>? responseShellCallOutputContentDelta = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent>? responseShellCallOutputContentDone = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseInProgressEvent>? responseInProgress = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseFailedEvent>? responseFailed = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseIncompleteEvent>? responseIncomplete = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent>? responseOutputItemAdded = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent>? responseOutputItemDone = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent>? responseReasoningSummaryPartAdded = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent>? responseReasoningSummaryPartDone = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent>? responseReasoningSummaryTextDelta = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent>? responseReasoningSummaryTextDone = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent>? responseReasoningTextDelta = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent>? responseReasoningTextDone = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent>? responseRefusalDelta = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseRefusalDoneEvent>? responseRefusalDone = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseTextDeltaEvent>? responseOutputTextDelta = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseTextDoneEvent>? responseOutputTextDone = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent>? responseWebSearchCallCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent>? responseWebSearchCallInProgress = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent>? responseWebSearchCallSearching = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent>? responseImageGenerationCallCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent>? responseImageGenerationCallGenerating = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent>? responseImageGenerationCallInProgress = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent>? responseImageGenerationCallPartialImage = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent>? responseMcpCallArgumentsDelta = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent>? responseMcpCallArgumentsDone = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent>? responseMcpCallCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent>? responseMcpCallFailed = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent>? responseMcpCallInProgress = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent>? responseMcpListToolsCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent>? responseMcpListToolsFailed = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent>? responseMcpListToolsInProgress = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent>? responseOutputTextAnnotationAdded = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseQueuedEvent>? responseQueued = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent>? responseCustomToolCallInputDelta = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent>? responseCustomToolCallInputDone = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ResponseAudioDelta is { } __value0)
            {
                responseAudioDelta?.Invoke(__value0);
            }
            else if (ResponseAudioDone is { } __value1)
            {
                responseAudioDone?.Invoke(__value1);
            }
            else if (ResponseAudioTranscriptDelta is { } __value2)
            {
                responseAudioTranscriptDelta?.Invoke(__value2);
            }
            else if (ResponseAudioTranscriptDone is { } __value3)
            {
                responseAudioTranscriptDone?.Invoke(__value3);
            }
            else if (ResponseCodeInterpreterCallCodeDelta is { } __value4)
            {
                responseCodeInterpreterCallCodeDelta?.Invoke(__value4);
            }
            else if (ResponseCodeInterpreterCallCodeDone is { } __value5)
            {
                responseCodeInterpreterCallCodeDone?.Invoke(__value5);
            }
            else if (ResponseCodeInterpreterCallCompleted is { } __value6)
            {
                responseCodeInterpreterCallCompleted?.Invoke(__value6);
            }
            else if (ResponseCodeInterpreterCallInProgress is { } __value7)
            {
                responseCodeInterpreterCallInProgress?.Invoke(__value7);
            }
            else if (ResponseCodeInterpreterCallInterpreting is { } __value8)
            {
                responseCodeInterpreterCallInterpreting?.Invoke(__value8);
            }
            else if (ResponseCompactionCompacting is { } __value9)
            {
                responseCompactionCompacting?.Invoke(__value9);
            }
            else if (ResponseCompleted is { } __value10)
            {
                responseCompleted?.Invoke(__value10);
            }
            else if (ResponseContentPartAdded is { } __value11)
            {
                responseContentPartAdded?.Invoke(__value11);
            }
            else if (ResponseContentPartDone is { } __value12)
            {
                responseContentPartDone?.Invoke(__value12);
            }
            else if (ResponseCreated is { } __value13)
            {
                responseCreated?.Invoke(__value13);
            }
            else if (Error is { } __value14)
            {
                error?.Invoke(__value14);
            }
            else if (ResponseFileSearchCallCompleted is { } __value15)
            {
                responseFileSearchCallCompleted?.Invoke(__value15);
            }
            else if (ResponseFileSearchCallInProgress is { } __value16)
            {
                responseFileSearchCallInProgress?.Invoke(__value16);
            }
            else if (ResponseFileSearchCallSearching is { } __value17)
            {
                responseFileSearchCallSearching?.Invoke(__value17);
            }
            else if (ResponseFunctionCallArgumentsDelta is { } __value18)
            {
                responseFunctionCallArgumentsDelta?.Invoke(__value18);
            }
            else if (ResponseFunctionCallArgumentsDone is { } __value19)
            {
                responseFunctionCallArgumentsDone?.Invoke(__value19);
            }
            else if (ResponseShellCallCommandAdded is { } __value20)
            {
                responseShellCallCommandAdded?.Invoke(__value20);
            }
            else if (ResponseShellCallCommandDelta is { } __value21)
            {
                responseShellCallCommandDelta?.Invoke(__value21);
            }
            else if (ResponseShellCallCommandDone is { } __value22)
            {
                responseShellCallCommandDone?.Invoke(__value22);
            }
            else if (ResponseShellCallOutputContentDelta is { } __value23)
            {
                responseShellCallOutputContentDelta?.Invoke(__value23);
            }
            else if (ResponseShellCallOutputContentDone is { } __value24)
            {
                responseShellCallOutputContentDone?.Invoke(__value24);
            }
            else if (ResponseInProgress is { } __value25)
            {
                responseInProgress?.Invoke(__value25);
            }
            else if (ResponseFailed is { } __value26)
            {
                responseFailed?.Invoke(__value26);
            }
            else if (ResponseIncomplete is { } __value27)
            {
                responseIncomplete?.Invoke(__value27);
            }
            else if (ResponseOutputItemAdded is { } __value28)
            {
                responseOutputItemAdded?.Invoke(__value28);
            }
            else if (ResponseOutputItemDone is { } __value29)
            {
                responseOutputItemDone?.Invoke(__value29);
            }
            else if (ResponseReasoningSummaryPartAdded is { } __value30)
            {
                responseReasoningSummaryPartAdded?.Invoke(__value30);
            }
            else if (ResponseReasoningSummaryPartDone is { } __value31)
            {
                responseReasoningSummaryPartDone?.Invoke(__value31);
            }
            else if (ResponseReasoningSummaryTextDelta is { } __value32)
            {
                responseReasoningSummaryTextDelta?.Invoke(__value32);
            }
            else if (ResponseReasoningSummaryTextDone is { } __value33)
            {
                responseReasoningSummaryTextDone?.Invoke(__value33);
            }
            else if (ResponseReasoningTextDelta is { } __value34)
            {
                responseReasoningTextDelta?.Invoke(__value34);
            }
            else if (ResponseReasoningTextDone is { } __value35)
            {
                responseReasoningTextDone?.Invoke(__value35);
            }
            else if (ResponseRefusalDelta is { } __value36)
            {
                responseRefusalDelta?.Invoke(__value36);
            }
            else if (ResponseRefusalDone is { } __value37)
            {
                responseRefusalDone?.Invoke(__value37);
            }
            else if (ResponseOutputTextDelta is { } __value38)
            {
                responseOutputTextDelta?.Invoke(__value38);
            }
            else if (ResponseOutputTextDone is { } __value39)
            {
                responseOutputTextDone?.Invoke(__value39);
            }
            else if (ResponseWebSearchCallCompleted is { } __value40)
            {
                responseWebSearchCallCompleted?.Invoke(__value40);
            }
            else if (ResponseWebSearchCallInProgress is { } __value41)
            {
                responseWebSearchCallInProgress?.Invoke(__value41);
            }
            else if (ResponseWebSearchCallSearching is { } __value42)
            {
                responseWebSearchCallSearching?.Invoke(__value42);
            }
            else if (ResponseImageGenerationCallCompleted is { } __value43)
            {
                responseImageGenerationCallCompleted?.Invoke(__value43);
            }
            else if (ResponseImageGenerationCallGenerating is { } __value44)
            {
                responseImageGenerationCallGenerating?.Invoke(__value44);
            }
            else if (ResponseImageGenerationCallInProgress is { } __value45)
            {
                responseImageGenerationCallInProgress?.Invoke(__value45);
            }
            else if (ResponseImageGenerationCallPartialImage is { } __value46)
            {
                responseImageGenerationCallPartialImage?.Invoke(__value46);
            }
            else if (ResponseMcpCallArgumentsDelta is { } __value47)
            {
                responseMcpCallArgumentsDelta?.Invoke(__value47);
            }
            else if (ResponseMcpCallArgumentsDone is { } __value48)
            {
                responseMcpCallArgumentsDone?.Invoke(__value48);
            }
            else if (ResponseMcpCallCompleted is { } __value49)
            {
                responseMcpCallCompleted?.Invoke(__value49);
            }
            else if (ResponseMcpCallFailed is { } __value50)
            {
                responseMcpCallFailed?.Invoke(__value50);
            }
            else if (ResponseMcpCallInProgress is { } __value51)
            {
                responseMcpCallInProgress?.Invoke(__value51);
            }
            else if (ResponseMcpListToolsCompleted is { } __value52)
            {
                responseMcpListToolsCompleted?.Invoke(__value52);
            }
            else if (ResponseMcpListToolsFailed is { } __value53)
            {
                responseMcpListToolsFailed?.Invoke(__value53);
            }
            else if (ResponseMcpListToolsInProgress is { } __value54)
            {
                responseMcpListToolsInProgress?.Invoke(__value54);
            }
            else if (ResponseOutputTextAnnotationAdded is { } __value55)
            {
                responseOutputTextAnnotationAdded?.Invoke(__value55);
            }
            else if (ResponseQueued is { } __value56)
            {
                responseQueued?.Invoke(__value56);
            }
            else if (ResponseCustomToolCallInputDelta is { } __value57)
            {
                responseCustomToolCallInputDelta?.Invoke(__value57);
            }
            else if (ResponseCustomToolCallInputDone is { } __value58)
            {
                responseCustomToolCallInputDone?.Invoke(__value58);
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
                ResponseCompactionCompacting,
                typeof(global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent),
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
                ResponseShellCallCommandAdded,
                typeof(global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent),
                ResponseShellCallCommandDelta,
                typeof(global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent),
                ResponseShellCallCommandDone,
                typeof(global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent),
                ResponseShellCallOutputContentDelta,
                typeof(global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent),
                ResponseShellCallOutputContentDone,
                typeof(global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent),
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
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent?>.Default.Equals(ResponseCompactionCompacting, other.ResponseCompactionCompacting) &&
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
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent?>.Default.Equals(ResponseShellCallCommandAdded, other.ResponseShellCallCommandAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent?>.Default.Equals(ResponseShellCallCommandDelta, other.ResponseShellCallCommandDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent?>.Default.Equals(ResponseShellCallCommandDone, other.ResponseShellCallCommandDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent?>.Default.Equals(ResponseShellCallOutputContentDelta, other.ResponseShellCallOutputContentDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent?>.Default.Equals(ResponseShellCallOutputContentDone, other.ResponseShellCallOutputContentDone) &&
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
