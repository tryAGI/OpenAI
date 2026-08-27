#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BetaResponseStreamEvent : global::System.IEquatable<BetaResponseStreamEvent>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseStreamEventDiscriminatorType? Type { get; }

        /// <summary>
        /// Emitted when there is a partial audio response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent? ResponseAudioDelta { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent? ResponseAudioDelta { get; }
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
            out global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent? value)
        {
            value = ResponseAudioDelta;
            return IsResponseAudioDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent PickResponseAudioDelta() => IsResponseAudioDelta
            ? ResponseAudioDelta!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseAudioDelta' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when the audio response is complete.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseAudioDoneEvent? ResponseAudioDone { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseAudioDoneEvent? ResponseAudioDone { get; }
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
            out global::tryAGI.OpenAI.BetaResponseAudioDoneEvent? value)
        {
            value = ResponseAudioDone;
            return IsResponseAudioDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseAudioDoneEvent PickResponseAudioDone() => IsResponseAudioDone
            ? ResponseAudioDone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseAudioDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when there is a partial transcript of audio.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent? ResponseAudioTranscriptDelta { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent? ResponseAudioTranscriptDelta { get; }
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
            out global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent? value)
        {
            value = ResponseAudioTranscriptDelta;
            return IsResponseAudioTranscriptDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent PickResponseAudioTranscriptDelta() => IsResponseAudioTranscriptDelta
            ? ResponseAudioTranscriptDelta!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseAudioTranscriptDelta' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when the full audio transcript is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent? ResponseAudioTranscriptDone { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent? ResponseAudioTranscriptDone { get; }
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
            out global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent? value)
        {
            value = ResponseAudioTranscriptDone;
            return IsResponseAudioTranscriptDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent PickResponseAudioTranscriptDone() => IsResponseAudioTranscriptDone
            ? ResponseAudioTranscriptDone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseAudioTranscriptDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a partial code snippet is streamed by the code interpreter.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent? ResponseCodeInterpreterCallCodeDelta { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent? ResponseCodeInterpreterCallCodeDelta { get; }
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
            out global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent? value)
        {
            value = ResponseCodeInterpreterCallCodeDelta;
            return IsResponseCodeInterpreterCallCodeDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent PickResponseCodeInterpreterCallCodeDelta() => IsResponseCodeInterpreterCallCodeDelta
            ? ResponseCodeInterpreterCallCodeDelta!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCodeInterpreterCallCodeDelta' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when the code snippet is finalized by the code interpreter.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent? ResponseCodeInterpreterCallCodeDone { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent? ResponseCodeInterpreterCallCodeDone { get; }
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
            out global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent? value)
        {
            value = ResponseCodeInterpreterCallCodeDone;
            return IsResponseCodeInterpreterCallCodeDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent PickResponseCodeInterpreterCallCodeDone() => IsResponseCodeInterpreterCallCodeDone
            ? ResponseCodeInterpreterCallCodeDone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCodeInterpreterCallCodeDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when the code interpreter call is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent? ResponseCodeInterpreterCallCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent? ResponseCodeInterpreterCallCompleted { get; }
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
            out global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent? value)
        {
            value = ResponseCodeInterpreterCallCompleted;
            return IsResponseCodeInterpreterCallCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent PickResponseCodeInterpreterCallCompleted() => IsResponseCodeInterpreterCallCompleted
            ? ResponseCodeInterpreterCallCompleted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCodeInterpreterCallCompleted' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a code interpreter call is in progress.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent? ResponseCodeInterpreterCallInProgress { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent? ResponseCodeInterpreterCallInProgress { get; }
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
            out global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent? value)
        {
            value = ResponseCodeInterpreterCallInProgress;
            return IsResponseCodeInterpreterCallInProgress;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent PickResponseCodeInterpreterCallInProgress() => IsResponseCodeInterpreterCallInProgress
            ? ResponseCodeInterpreterCallInProgress!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCodeInterpreterCallInProgress' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when the code interpreter is actively interpreting the code snippet.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent? ResponseCodeInterpreterCallInterpreting { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent? ResponseCodeInterpreterCallInterpreting { get; }
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
            out global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent? value)
        {
            value = ResponseCodeInterpreterCallInterpreting;
            return IsResponseCodeInterpreterCallInterpreting;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent PickResponseCodeInterpreterCallInterpreting() => IsResponseCodeInterpreterCallInterpreting
            ? ResponseCodeInterpreterCallInterpreting!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCodeInterpreterCallInterpreting' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when the model response is complete.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseCompletedEvent? ResponseCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseCompletedEvent? ResponseCompleted { get; }
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
            out global::tryAGI.OpenAI.BetaResponseCompletedEvent? value)
        {
            value = ResponseCompleted;
            return IsResponseCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCompletedEvent PickResponseCompleted() => IsResponseCompleted
            ? ResponseCompleted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCompleted' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a new content part is added.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent? ResponseContentPartAdded { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent? ResponseContentPartAdded { get; }
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
            out global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent? value)
        {
            value = ResponseContentPartAdded;
            return IsResponseContentPartAdded;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent PickResponseContentPartAdded() => IsResponseContentPartAdded
            ? ResponseContentPartAdded!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseContentPartAdded' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a content part is done.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent? ResponseContentPartDone { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent? ResponseContentPartDone { get; }
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
            out global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent? value)
        {
            value = ResponseContentPartDone;
            return IsResponseContentPartDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent PickResponseContentPartDone() => IsResponseContentPartDone
            ? ResponseContentPartDone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseContentPartDone' but the value was {ToString()}.");

        /// <summary>
        /// An event that is emitted when a response is created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseCreatedEvent? ResponseCreated { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseCreatedEvent? ResponseCreated { get; }
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
            out global::tryAGI.OpenAI.BetaResponseCreatedEvent? value)
        {
            value = ResponseCreated;
            return IsResponseCreated;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCreatedEvent PickResponseCreated() => IsResponseCreated
            ? ResponseCreated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCreated' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when an error occurs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseErrorEvent? Error { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseErrorEvent? Error { get; }
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
            out global::tryAGI.OpenAI.BetaResponseErrorEvent? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseErrorEvent PickError() => IsError
            ? Error!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Error' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a file search call is completed (results found).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent? ResponseFileSearchCallCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent? ResponseFileSearchCallCompleted { get; }
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
            out global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent? value)
        {
            value = ResponseFileSearchCallCompleted;
            return IsResponseFileSearchCallCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent PickResponseFileSearchCallCompleted() => IsResponseFileSearchCallCompleted
            ? ResponseFileSearchCallCompleted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseFileSearchCallCompleted' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a file search call is initiated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent? ResponseFileSearchCallInProgress { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent? ResponseFileSearchCallInProgress { get; }
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
            out global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent? value)
        {
            value = ResponseFileSearchCallInProgress;
            return IsResponseFileSearchCallInProgress;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent PickResponseFileSearchCallInProgress() => IsResponseFileSearchCallInProgress
            ? ResponseFileSearchCallInProgress!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseFileSearchCallInProgress' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a file search is currently searching.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent? ResponseFileSearchCallSearching { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent? ResponseFileSearchCallSearching { get; }
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
            out global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent? value)
        {
            value = ResponseFileSearchCallSearching;
            return IsResponseFileSearchCallSearching;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent PickResponseFileSearchCallSearching() => IsResponseFileSearchCallSearching
            ? ResponseFileSearchCallSearching!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseFileSearchCallSearching' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when there is a partial function-call arguments delta.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent? ResponseFunctionCallArgumentsDelta { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent? ResponseFunctionCallArgumentsDelta { get; }
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
            out global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent? value)
        {
            value = ResponseFunctionCallArgumentsDelta;
            return IsResponseFunctionCallArgumentsDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent PickResponseFunctionCallArgumentsDelta() => IsResponseFunctionCallArgumentsDelta
            ? ResponseFunctionCallArgumentsDelta!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseFunctionCallArgumentsDelta' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when function-call arguments are finalized.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent? ResponseFunctionCallArgumentsDone { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent? ResponseFunctionCallArgumentsDone { get; }
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
            out global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent? value)
        {
            value = ResponseFunctionCallArgumentsDone;
            return IsResponseFunctionCallArgumentsDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent PickResponseFunctionCallArgumentsDone() => IsResponseFunctionCallArgumentsDone
            ? ResponseFunctionCallArgumentsDone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseFunctionCallArgumentsDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when the response is in progress.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseInProgressEvent? ResponseInProgress { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseInProgressEvent? ResponseInProgress { get; }
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
            out global::tryAGI.OpenAI.BetaResponseInProgressEvent? value)
        {
            value = ResponseInProgress;
            return IsResponseInProgress;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInProgressEvent PickResponseInProgress() => IsResponseInProgress
            ? ResponseInProgress!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseInProgress' but the value was {ToString()}.");

        /// <summary>
        /// An event that is emitted when a response fails.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseFailedEvent? ResponseFailed { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseFailedEvent? ResponseFailed { get; }
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
            out global::tryAGI.OpenAI.BetaResponseFailedEvent? value)
        {
            value = ResponseFailed;
            return IsResponseFailed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFailedEvent PickResponseFailed() => IsResponseFailed
            ? ResponseFailed!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseFailed' but the value was {ToString()}.");

        /// <summary>
        /// An event that is emitted when a response finishes as incomplete.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseIncompleteEvent? ResponseIncomplete { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseIncompleteEvent? ResponseIncomplete { get; }
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
            out global::tryAGI.OpenAI.BetaResponseIncompleteEvent? value)
        {
            value = ResponseIncomplete;
            return IsResponseIncomplete;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseIncompleteEvent PickResponseIncomplete() => IsResponseIncomplete
            ? ResponseIncomplete!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseIncomplete' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a new output item is added.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent? ResponseOutputItemAdded { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent? ResponseOutputItemAdded { get; }
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
            out global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent? value)
        {
            value = ResponseOutputItemAdded;
            return IsResponseOutputItemAdded;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent PickResponseOutputItemAdded() => IsResponseOutputItemAdded
            ? ResponseOutputItemAdded!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputItemAdded' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when an output item is marked done.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent? ResponseOutputItemDone { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent? ResponseOutputItemDone { get; }
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
            out global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent? value)
        {
            value = ResponseOutputItemDone;
            return IsResponseOutputItemDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent PickResponseOutputItemDone() => IsResponseOutputItemDone
            ? ResponseOutputItemDone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputItemDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a new reasoning summary part is added.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent? ResponseReasoningSummaryPartAdded { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent? ResponseReasoningSummaryPartAdded { get; }
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
            out global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent? value)
        {
            value = ResponseReasoningSummaryPartAdded;
            return IsResponseReasoningSummaryPartAdded;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent PickResponseReasoningSummaryPartAdded() => IsResponseReasoningSummaryPartAdded
            ? ResponseReasoningSummaryPartAdded!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseReasoningSummaryPartAdded' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a reasoning summary part is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent? ResponseReasoningSummaryPartDone { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent? ResponseReasoningSummaryPartDone { get; }
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
            out global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent? value)
        {
            value = ResponseReasoningSummaryPartDone;
            return IsResponseReasoningSummaryPartDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent PickResponseReasoningSummaryPartDone() => IsResponseReasoningSummaryPartDone
            ? ResponseReasoningSummaryPartDone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseReasoningSummaryPartDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a delta is added to a reasoning summary text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent? ResponseReasoningSummaryTextDelta { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent? ResponseReasoningSummaryTextDelta { get; }
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
            out global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent? value)
        {
            value = ResponseReasoningSummaryTextDelta;
            return IsResponseReasoningSummaryTextDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent PickResponseReasoningSummaryTextDelta() => IsResponseReasoningSummaryTextDelta
            ? ResponseReasoningSummaryTextDelta!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseReasoningSummaryTextDelta' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a reasoning summary text is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent? ResponseReasoningSummaryTextDone { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent? ResponseReasoningSummaryTextDone { get; }
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
            out global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent? value)
        {
            value = ResponseReasoningSummaryTextDone;
            return IsResponseReasoningSummaryTextDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent PickResponseReasoningSummaryTextDone() => IsResponseReasoningSummaryTextDone
            ? ResponseReasoningSummaryTextDone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseReasoningSummaryTextDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a delta is added to a reasoning text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent? ResponseReasoningTextDelta { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent? ResponseReasoningTextDelta { get; }
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
            out global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent? value)
        {
            value = ResponseReasoningTextDelta;
            return IsResponseReasoningTextDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent PickResponseReasoningTextDelta() => IsResponseReasoningTextDelta
            ? ResponseReasoningTextDelta!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseReasoningTextDelta' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a reasoning text is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent? ResponseReasoningTextDone { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent? ResponseReasoningTextDone { get; }
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
            out global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent? value)
        {
            value = ResponseReasoningTextDone;
            return IsResponseReasoningTextDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent PickResponseReasoningTextDone() => IsResponseReasoningTextDone
            ? ResponseReasoningTextDone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseReasoningTextDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when there is a partial refusal text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent? ResponseRefusalDelta { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent? ResponseRefusalDelta { get; }
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
            out global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent? value)
        {
            value = ResponseRefusalDelta;
            return IsResponseRefusalDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent PickResponseRefusalDelta() => IsResponseRefusalDelta
            ? ResponseRefusalDelta!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseRefusalDelta' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when refusal text is finalized.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent? ResponseRefusalDone { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent? ResponseRefusalDone { get; }
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
            out global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent? value)
        {
            value = ResponseRefusalDone;
            return IsResponseRefusalDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent PickResponseRefusalDone() => IsResponseRefusalDone
            ? ResponseRefusalDone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseRefusalDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when there is an additional text delta.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseTextDeltaEvent? ResponseOutputTextDelta { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseTextDeltaEvent? ResponseOutputTextDelta { get; }
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
            out global::tryAGI.OpenAI.BetaResponseTextDeltaEvent? value)
        {
            value = ResponseOutputTextDelta;
            return IsResponseOutputTextDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseTextDeltaEvent PickResponseOutputTextDelta() => IsResponseOutputTextDelta
            ? ResponseOutputTextDelta!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputTextDelta' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when text content is finalized.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseTextDoneEvent? ResponseOutputTextDone { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseTextDoneEvent? ResponseOutputTextDone { get; }
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
            out global::tryAGI.OpenAI.BetaResponseTextDoneEvent? value)
        {
            value = ResponseOutputTextDone;
            return IsResponseOutputTextDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseTextDoneEvent PickResponseOutputTextDone() => IsResponseOutputTextDone
            ? ResponseOutputTextDone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputTextDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a web search call is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent? ResponseWebSearchCallCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent? ResponseWebSearchCallCompleted { get; }
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
            out global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent? value)
        {
            value = ResponseWebSearchCallCompleted;
            return IsResponseWebSearchCallCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent PickResponseWebSearchCallCompleted() => IsResponseWebSearchCallCompleted
            ? ResponseWebSearchCallCompleted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseWebSearchCallCompleted' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a web search call is initiated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent? ResponseWebSearchCallInProgress { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent? ResponseWebSearchCallInProgress { get; }
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
            out global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent? value)
        {
            value = ResponseWebSearchCallInProgress;
            return IsResponseWebSearchCallInProgress;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent PickResponseWebSearchCallInProgress() => IsResponseWebSearchCallInProgress
            ? ResponseWebSearchCallInProgress!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseWebSearchCallInProgress' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a web search call is executing.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent? ResponseWebSearchCallSearching { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent? ResponseWebSearchCallSearching { get; }
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
            out global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent? value)
        {
            value = ResponseWebSearchCallSearching;
            return IsResponseWebSearchCallSearching;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent PickResponseWebSearchCallSearching() => IsResponseWebSearchCallSearching
            ? ResponseWebSearchCallSearching!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseWebSearchCallSearching' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when an image generation tool call has completed and the final image is available.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent? ResponseImageGenerationCallCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent? ResponseImageGenerationCallCompleted { get; }
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
            out global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent? value)
        {
            value = ResponseImageGenerationCallCompleted;
            return IsResponseImageGenerationCallCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent PickResponseImageGenerationCallCompleted() => IsResponseImageGenerationCallCompleted
            ? ResponseImageGenerationCallCompleted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseImageGenerationCallCompleted' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when an image generation tool call is actively generating an image (intermediate state).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent? ResponseImageGenerationCallGenerating { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent? ResponseImageGenerationCallGenerating { get; }
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
            out global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent? value)
        {
            value = ResponseImageGenerationCallGenerating;
            return IsResponseImageGenerationCallGenerating;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent PickResponseImageGenerationCallGenerating() => IsResponseImageGenerationCallGenerating
            ? ResponseImageGenerationCallGenerating!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseImageGenerationCallGenerating' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when an image generation tool call is in progress.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent? ResponseImageGenerationCallInProgress { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent? ResponseImageGenerationCallInProgress { get; }
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
            out global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent? value)
        {
            value = ResponseImageGenerationCallInProgress;
            return IsResponseImageGenerationCallInProgress;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent PickResponseImageGenerationCallInProgress() => IsResponseImageGenerationCallInProgress
            ? ResponseImageGenerationCallInProgress!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseImageGenerationCallInProgress' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a partial image is available during image generation streaming.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent? ResponseImageGenerationCallPartialImage { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent? ResponseImageGenerationCallPartialImage { get; }
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
            out global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent? value)
        {
            value = ResponseImageGenerationCallPartialImage;
            return IsResponseImageGenerationCallPartialImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent PickResponseImageGenerationCallPartialImage() => IsResponseImageGenerationCallPartialImage
            ? ResponseImageGenerationCallPartialImage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseImageGenerationCallPartialImage' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when there is a delta (partial update) to the arguments of an MCP tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent? ResponseMcpCallArgumentsDelta { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent? ResponseMcpCallArgumentsDelta { get; }
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
            out global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent? value)
        {
            value = ResponseMcpCallArgumentsDelta;
            return IsResponseMcpCallArgumentsDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent PickResponseMcpCallArgumentsDelta() => IsResponseMcpCallArgumentsDelta
            ? ResponseMcpCallArgumentsDelta!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseMcpCallArgumentsDelta' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when the arguments for an MCP tool call are finalized.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent? ResponseMcpCallArgumentsDone { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent? ResponseMcpCallArgumentsDone { get; }
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
            out global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent? value)
        {
            value = ResponseMcpCallArgumentsDone;
            return IsResponseMcpCallArgumentsDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent PickResponseMcpCallArgumentsDone() => IsResponseMcpCallArgumentsDone
            ? ResponseMcpCallArgumentsDone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseMcpCallArgumentsDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when an MCP  tool call has completed successfully.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent? ResponseMcpCallCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent? ResponseMcpCallCompleted { get; }
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
            out global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent? value)
        {
            value = ResponseMcpCallCompleted;
            return IsResponseMcpCallCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent PickResponseMcpCallCompleted() => IsResponseMcpCallCompleted
            ? ResponseMcpCallCompleted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseMcpCallCompleted' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when an MCP  tool call has failed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent? ResponseMcpCallFailed { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent? ResponseMcpCallFailed { get; }
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
            out global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent? value)
        {
            value = ResponseMcpCallFailed;
            return IsResponseMcpCallFailed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent PickResponseMcpCallFailed() => IsResponseMcpCallFailed
            ? ResponseMcpCallFailed!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseMcpCallFailed' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when an MCP  tool call is in progress.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent? ResponseMcpCallInProgress { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent? ResponseMcpCallInProgress { get; }
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
            out global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent? value)
        {
            value = ResponseMcpCallInProgress;
            return IsResponseMcpCallInProgress;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent PickResponseMcpCallInProgress() => IsResponseMcpCallInProgress
            ? ResponseMcpCallInProgress!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseMcpCallInProgress' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when the list of available MCP tools has been successfully retrieved.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent? ResponseMcpListToolsCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent? ResponseMcpListToolsCompleted { get; }
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
            out global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent? value)
        {
            value = ResponseMcpListToolsCompleted;
            return IsResponseMcpListToolsCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent PickResponseMcpListToolsCompleted() => IsResponseMcpListToolsCompleted
            ? ResponseMcpListToolsCompleted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseMcpListToolsCompleted' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when the attempt to list available MCP tools has failed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent? ResponseMcpListToolsFailed { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent? ResponseMcpListToolsFailed { get; }
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
            out global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent? value)
        {
            value = ResponseMcpListToolsFailed;
            return IsResponseMcpListToolsFailed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent PickResponseMcpListToolsFailed() => IsResponseMcpListToolsFailed
            ? ResponseMcpListToolsFailed!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseMcpListToolsFailed' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when the system is in the process of retrieving the list of available MCP tools.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent? ResponseMcpListToolsInProgress { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent? ResponseMcpListToolsInProgress { get; }
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
            out global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent? value)
        {
            value = ResponseMcpListToolsInProgress;
            return IsResponseMcpListToolsInProgress;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent PickResponseMcpListToolsInProgress() => IsResponseMcpListToolsInProgress
            ? ResponseMcpListToolsInProgress!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseMcpListToolsInProgress' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when an annotation is added to output text content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent? ResponseOutputTextAnnotationAdded { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent? ResponseOutputTextAnnotationAdded { get; }
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
            out global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent? value)
        {
            value = ResponseOutputTextAnnotationAdded;
            return IsResponseOutputTextAnnotationAdded;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent PickResponseOutputTextAnnotationAdded() => IsResponseOutputTextAnnotationAdded
            ? ResponseOutputTextAnnotationAdded!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputTextAnnotationAdded' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a response is queued and waiting to be processed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseQueuedEvent? ResponseQueued { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseQueuedEvent? ResponseQueued { get; }
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
            out global::tryAGI.OpenAI.BetaResponseQueuedEvent? value)
        {
            value = ResponseQueued;
            return IsResponseQueued;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseQueuedEvent PickResponseQueued() => IsResponseQueued
            ? ResponseQueued!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseQueued' but the value was {ToString()}.");

        /// <summary>
        /// Event representing a delta (partial update) to the input of a custom tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent? ResponseCustomToolCallInputDelta { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent? ResponseCustomToolCallInputDelta { get; }
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
            out global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent? value)
        {
            value = ResponseCustomToolCallInputDelta;
            return IsResponseCustomToolCallInputDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent PickResponseCustomToolCallInputDelta() => IsResponseCustomToolCallInputDelta
            ? ResponseCustomToolCallInputDelta!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCustomToolCallInputDelta' but the value was {ToString()}.");

        /// <summary>
        /// Event indicating that input for a custom tool call is complete.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent? ResponseCustomToolCallInputDone { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent? ResponseCustomToolCallInputDone { get; }
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
            out global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent? value)
        {
            value = ResponseCustomToolCallInputDone;
            return IsResponseCustomToolCallInputDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent PickResponseCustomToolCallInputDone() => IsResponseCustomToolCallInputDone
            ? ResponseCustomToolCallInputDone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCustomToolCallInputDone' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent?(BetaResponseStreamEvent @this) => @this.ResponseAudioDelta;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent? value)
        {
            ResponseAudioDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseAudioDelta(global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseAudioDoneEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseAudioDoneEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseAudioDoneEvent?(BetaResponseStreamEvent @this) => @this.ResponseAudioDone;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseAudioDoneEvent? value)
        {
            ResponseAudioDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseAudioDone(global::tryAGI.OpenAI.BetaResponseAudioDoneEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent?(BetaResponseStreamEvent @this) => @this.ResponseAudioTranscriptDelta;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent? value)
        {
            ResponseAudioTranscriptDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseAudioTranscriptDelta(global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent?(BetaResponseStreamEvent @this) => @this.ResponseAudioTranscriptDone;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent? value)
        {
            ResponseAudioTranscriptDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseAudioTranscriptDone(global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent?(BetaResponseStreamEvent @this) => @this.ResponseCodeInterpreterCallCodeDelta;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent? value)
        {
            ResponseCodeInterpreterCallCodeDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseCodeInterpreterCallCodeDelta(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent?(BetaResponseStreamEvent @this) => @this.ResponseCodeInterpreterCallCodeDone;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent? value)
        {
            ResponseCodeInterpreterCallCodeDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseCodeInterpreterCallCodeDone(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent?(BetaResponseStreamEvent @this) => @this.ResponseCodeInterpreterCallCompleted;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent? value)
        {
            ResponseCodeInterpreterCallCompleted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseCodeInterpreterCallCompleted(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent?(BetaResponseStreamEvent @this) => @this.ResponseCodeInterpreterCallInProgress;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent? value)
        {
            ResponseCodeInterpreterCallInProgress = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseCodeInterpreterCallInProgress(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent?(BetaResponseStreamEvent @this) => @this.ResponseCodeInterpreterCallInterpreting;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent? value)
        {
            ResponseCodeInterpreterCallInterpreting = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseCodeInterpreterCallInterpreting(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseCompletedEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseCompletedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseCompletedEvent?(BetaResponseStreamEvent @this) => @this.ResponseCompleted;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseCompletedEvent? value)
        {
            ResponseCompleted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseCompleted(global::tryAGI.OpenAI.BetaResponseCompletedEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent?(BetaResponseStreamEvent @this) => @this.ResponseContentPartAdded;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent? value)
        {
            ResponseContentPartAdded = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseContentPartAdded(global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent?(BetaResponseStreamEvent @this) => @this.ResponseContentPartDone;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent? value)
        {
            ResponseContentPartDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseContentPartDone(global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseCreatedEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseCreatedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseCreatedEvent?(BetaResponseStreamEvent @this) => @this.ResponseCreated;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseCreatedEvent? value)
        {
            ResponseCreated = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseCreated(global::tryAGI.OpenAI.BetaResponseCreatedEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseErrorEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseErrorEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseErrorEvent?(BetaResponseStreamEvent @this) => @this.Error;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseErrorEvent? value)
        {
            Error = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromError(global::tryAGI.OpenAI.BetaResponseErrorEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent?(BetaResponseStreamEvent @this) => @this.ResponseFileSearchCallCompleted;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent? value)
        {
            ResponseFileSearchCallCompleted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseFileSearchCallCompleted(global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent?(BetaResponseStreamEvent @this) => @this.ResponseFileSearchCallInProgress;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent? value)
        {
            ResponseFileSearchCallInProgress = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseFileSearchCallInProgress(global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent?(BetaResponseStreamEvent @this) => @this.ResponseFileSearchCallSearching;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent? value)
        {
            ResponseFileSearchCallSearching = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseFileSearchCallSearching(global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent?(BetaResponseStreamEvent @this) => @this.ResponseFunctionCallArgumentsDelta;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent? value)
        {
            ResponseFunctionCallArgumentsDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseFunctionCallArgumentsDelta(global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent?(BetaResponseStreamEvent @this) => @this.ResponseFunctionCallArgumentsDone;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent? value)
        {
            ResponseFunctionCallArgumentsDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseFunctionCallArgumentsDone(global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseInProgressEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseInProgressEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseInProgressEvent?(BetaResponseStreamEvent @this) => @this.ResponseInProgress;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseInProgressEvent? value)
        {
            ResponseInProgress = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseInProgress(global::tryAGI.OpenAI.BetaResponseInProgressEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseFailedEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseFailedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseFailedEvent?(BetaResponseStreamEvent @this) => @this.ResponseFailed;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseFailedEvent? value)
        {
            ResponseFailed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseFailed(global::tryAGI.OpenAI.BetaResponseFailedEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseIncompleteEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseIncompleteEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseIncompleteEvent?(BetaResponseStreamEvent @this) => @this.ResponseIncomplete;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseIncompleteEvent? value)
        {
            ResponseIncomplete = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseIncomplete(global::tryAGI.OpenAI.BetaResponseIncompleteEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent?(BetaResponseStreamEvent @this) => @this.ResponseOutputItemAdded;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent? value)
        {
            ResponseOutputItemAdded = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseOutputItemAdded(global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent?(BetaResponseStreamEvent @this) => @this.ResponseOutputItemDone;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent? value)
        {
            ResponseOutputItemDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseOutputItemDone(global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent?(BetaResponseStreamEvent @this) => @this.ResponseReasoningSummaryPartAdded;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent? value)
        {
            ResponseReasoningSummaryPartAdded = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseReasoningSummaryPartAdded(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent?(BetaResponseStreamEvent @this) => @this.ResponseReasoningSummaryPartDone;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent? value)
        {
            ResponseReasoningSummaryPartDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseReasoningSummaryPartDone(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent?(BetaResponseStreamEvent @this) => @this.ResponseReasoningSummaryTextDelta;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent? value)
        {
            ResponseReasoningSummaryTextDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseReasoningSummaryTextDelta(global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent?(BetaResponseStreamEvent @this) => @this.ResponseReasoningSummaryTextDone;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent? value)
        {
            ResponseReasoningSummaryTextDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseReasoningSummaryTextDone(global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent?(BetaResponseStreamEvent @this) => @this.ResponseReasoningTextDelta;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent? value)
        {
            ResponseReasoningTextDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseReasoningTextDelta(global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent?(BetaResponseStreamEvent @this) => @this.ResponseReasoningTextDone;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent? value)
        {
            ResponseReasoningTextDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseReasoningTextDone(global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent?(BetaResponseStreamEvent @this) => @this.ResponseRefusalDelta;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent? value)
        {
            ResponseRefusalDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseRefusalDelta(global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent?(BetaResponseStreamEvent @this) => @this.ResponseRefusalDone;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent? value)
        {
            ResponseRefusalDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseRefusalDone(global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseTextDeltaEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseTextDeltaEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseTextDeltaEvent?(BetaResponseStreamEvent @this) => @this.ResponseOutputTextDelta;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseTextDeltaEvent? value)
        {
            ResponseOutputTextDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseOutputTextDelta(global::tryAGI.OpenAI.BetaResponseTextDeltaEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseTextDoneEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseTextDoneEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseTextDoneEvent?(BetaResponseStreamEvent @this) => @this.ResponseOutputTextDone;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseTextDoneEvent? value)
        {
            ResponseOutputTextDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseOutputTextDone(global::tryAGI.OpenAI.BetaResponseTextDoneEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent?(BetaResponseStreamEvent @this) => @this.ResponseWebSearchCallCompleted;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent? value)
        {
            ResponseWebSearchCallCompleted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseWebSearchCallCompleted(global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent?(BetaResponseStreamEvent @this) => @this.ResponseWebSearchCallInProgress;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent? value)
        {
            ResponseWebSearchCallInProgress = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseWebSearchCallInProgress(global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent?(BetaResponseStreamEvent @this) => @this.ResponseWebSearchCallSearching;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent? value)
        {
            ResponseWebSearchCallSearching = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseWebSearchCallSearching(global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent?(BetaResponseStreamEvent @this) => @this.ResponseImageGenerationCallCompleted;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent? value)
        {
            ResponseImageGenerationCallCompleted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseImageGenerationCallCompleted(global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent?(BetaResponseStreamEvent @this) => @this.ResponseImageGenerationCallGenerating;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent? value)
        {
            ResponseImageGenerationCallGenerating = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseImageGenerationCallGenerating(global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent?(BetaResponseStreamEvent @this) => @this.ResponseImageGenerationCallInProgress;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent? value)
        {
            ResponseImageGenerationCallInProgress = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseImageGenerationCallInProgress(global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent?(BetaResponseStreamEvent @this) => @this.ResponseImageGenerationCallPartialImage;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent? value)
        {
            ResponseImageGenerationCallPartialImage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseImageGenerationCallPartialImage(global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent?(BetaResponseStreamEvent @this) => @this.ResponseMcpCallArgumentsDelta;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent? value)
        {
            ResponseMcpCallArgumentsDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseMcpCallArgumentsDelta(global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent?(BetaResponseStreamEvent @this) => @this.ResponseMcpCallArgumentsDone;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent? value)
        {
            ResponseMcpCallArgumentsDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseMcpCallArgumentsDone(global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent?(BetaResponseStreamEvent @this) => @this.ResponseMcpCallCompleted;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent? value)
        {
            ResponseMcpCallCompleted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseMcpCallCompleted(global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent?(BetaResponseStreamEvent @this) => @this.ResponseMcpCallFailed;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent? value)
        {
            ResponseMcpCallFailed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseMcpCallFailed(global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent?(BetaResponseStreamEvent @this) => @this.ResponseMcpCallInProgress;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent? value)
        {
            ResponseMcpCallInProgress = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseMcpCallInProgress(global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent?(BetaResponseStreamEvent @this) => @this.ResponseMcpListToolsCompleted;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent? value)
        {
            ResponseMcpListToolsCompleted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseMcpListToolsCompleted(global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent?(BetaResponseStreamEvent @this) => @this.ResponseMcpListToolsFailed;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent? value)
        {
            ResponseMcpListToolsFailed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseMcpListToolsFailed(global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent?(BetaResponseStreamEvent @this) => @this.ResponseMcpListToolsInProgress;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent? value)
        {
            ResponseMcpListToolsInProgress = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseMcpListToolsInProgress(global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent?(BetaResponseStreamEvent @this) => @this.ResponseOutputTextAnnotationAdded;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent? value)
        {
            ResponseOutputTextAnnotationAdded = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseOutputTextAnnotationAdded(global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseQueuedEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseQueuedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseQueuedEvent?(BetaResponseStreamEvent @this) => @this.ResponseQueued;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseQueuedEvent? value)
        {
            ResponseQueued = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseQueued(global::tryAGI.OpenAI.BetaResponseQueuedEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent?(BetaResponseStreamEvent @this) => @this.ResponseCustomToolCallInputDelta;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent? value)
        {
            ResponseCustomToolCallInputDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseCustomToolCallInputDelta(global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent value) => new BetaResponseStreamEvent((global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent?(BetaResponseStreamEvent @this) => @this.ResponseCustomToolCallInputDone;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent? value)
        {
            ResponseCustomToolCallInputDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseStreamEvent FromResponseCustomToolCallInputDone(global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent? value) => new BetaResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public BetaResponseStreamEvent(
            global::tryAGI.OpenAI.BetaResponseStreamEventDiscriminatorType? type,
            global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent? responseAudioDelta,
            global::tryAGI.OpenAI.BetaResponseAudioDoneEvent? responseAudioDone,
            global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent? responseAudioTranscriptDelta,
            global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent? responseAudioTranscriptDone,
            global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent? responseCodeInterpreterCallCodeDelta,
            global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent? responseCodeInterpreterCallCodeDone,
            global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent? responseCodeInterpreterCallCompleted,
            global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent? responseCodeInterpreterCallInProgress,
            global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent? responseCodeInterpreterCallInterpreting,
            global::tryAGI.OpenAI.BetaResponseCompletedEvent? responseCompleted,
            global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent? responseContentPartAdded,
            global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent? responseContentPartDone,
            global::tryAGI.OpenAI.BetaResponseCreatedEvent? responseCreated,
            global::tryAGI.OpenAI.BetaResponseErrorEvent? error,
            global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent? responseFileSearchCallCompleted,
            global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent? responseFileSearchCallInProgress,
            global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent? responseFileSearchCallSearching,
            global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent? responseFunctionCallArgumentsDelta,
            global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent? responseFunctionCallArgumentsDone,
            global::tryAGI.OpenAI.BetaResponseInProgressEvent? responseInProgress,
            global::tryAGI.OpenAI.BetaResponseFailedEvent? responseFailed,
            global::tryAGI.OpenAI.BetaResponseIncompleteEvent? responseIncomplete,
            global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent? responseOutputItemAdded,
            global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent? responseOutputItemDone,
            global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent? responseReasoningSummaryPartAdded,
            global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent? responseReasoningSummaryPartDone,
            global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent? responseReasoningSummaryTextDelta,
            global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent? responseReasoningSummaryTextDone,
            global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent? responseReasoningTextDelta,
            global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent? responseReasoningTextDone,
            global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent? responseRefusalDelta,
            global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent? responseRefusalDone,
            global::tryAGI.OpenAI.BetaResponseTextDeltaEvent? responseOutputTextDelta,
            global::tryAGI.OpenAI.BetaResponseTextDoneEvent? responseOutputTextDone,
            global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent? responseWebSearchCallCompleted,
            global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent? responseWebSearchCallInProgress,
            global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent? responseWebSearchCallSearching,
            global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent? responseImageGenerationCallCompleted,
            global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent? responseImageGenerationCallGenerating,
            global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent? responseImageGenerationCallInProgress,
            global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent? responseImageGenerationCallPartialImage,
            global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent? responseMcpCallArgumentsDelta,
            global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent? responseMcpCallArgumentsDone,
            global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent? responseMcpCallCompleted,
            global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent? responseMcpCallFailed,
            global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent? responseMcpCallInProgress,
            global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent? responseMcpListToolsCompleted,
            global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent? responseMcpListToolsFailed,
            global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent? responseMcpListToolsInProgress,
            global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent? responseOutputTextAnnotationAdded,
            global::tryAGI.OpenAI.BetaResponseQueuedEvent? responseQueued,
            global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent? responseCustomToolCallInputDelta,
            global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent? responseCustomToolCallInputDone
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
            global::System.Func<global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent, TResult>? responseAudioDelta = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseAudioDoneEvent, TResult>? responseAudioDone = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent, TResult>? responseAudioTranscriptDelta = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent, TResult>? responseAudioTranscriptDone = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent, TResult>? responseCodeInterpreterCallCodeDelta = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent, TResult>? responseCodeInterpreterCallCodeDone = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent, TResult>? responseCodeInterpreterCallCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent, TResult>? responseCodeInterpreterCallInProgress = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent, TResult>? responseCodeInterpreterCallInterpreting = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseCompletedEvent, TResult>? responseCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent, TResult>? responseContentPartAdded = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent, TResult>? responseContentPartDone = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseCreatedEvent, TResult>? responseCreated = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseErrorEvent, TResult>? error = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent, TResult>? responseFileSearchCallCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent, TResult>? responseFileSearchCallInProgress = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent, TResult>? responseFileSearchCallSearching = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent, TResult>? responseFunctionCallArgumentsDelta = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent, TResult>? responseFunctionCallArgumentsDone = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseInProgressEvent, TResult>? responseInProgress = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseFailedEvent, TResult>? responseFailed = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseIncompleteEvent, TResult>? responseIncomplete = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent, TResult>? responseOutputItemAdded = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent, TResult>? responseOutputItemDone = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent, TResult>? responseReasoningSummaryPartAdded = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent, TResult>? responseReasoningSummaryPartDone = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent, TResult>? responseReasoningSummaryTextDelta = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent, TResult>? responseReasoningSummaryTextDone = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent, TResult>? responseReasoningTextDelta = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent, TResult>? responseReasoningTextDone = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent, TResult>? responseRefusalDelta = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent, TResult>? responseRefusalDone = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseTextDeltaEvent, TResult>? responseOutputTextDelta = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseTextDoneEvent, TResult>? responseOutputTextDone = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent, TResult>? responseWebSearchCallCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent, TResult>? responseWebSearchCallInProgress = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent, TResult>? responseWebSearchCallSearching = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent, TResult>? responseImageGenerationCallCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent, TResult>? responseImageGenerationCallGenerating = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent, TResult>? responseImageGenerationCallInProgress = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent, TResult>? responseImageGenerationCallPartialImage = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent, TResult>? responseMcpCallArgumentsDelta = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent, TResult>? responseMcpCallArgumentsDone = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent, TResult>? responseMcpCallCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent, TResult>? responseMcpCallFailed = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent, TResult>? responseMcpCallInProgress = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent, TResult>? responseMcpListToolsCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent, TResult>? responseMcpListToolsFailed = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent, TResult>? responseMcpListToolsInProgress = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent, TResult>? responseOutputTextAnnotationAdded = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseQueuedEvent, TResult>? responseQueued = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent, TResult>? responseCustomToolCallInputDelta = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent, TResult>? responseCustomToolCallInputDone = null,
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
            global::System.Action<global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent>? responseAudioDelta = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseAudioDoneEvent>? responseAudioDone = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent>? responseAudioTranscriptDelta = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent>? responseAudioTranscriptDone = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent>? responseCodeInterpreterCallCodeDelta = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent>? responseCodeInterpreterCallCodeDone = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent>? responseCodeInterpreterCallCompleted = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent>? responseCodeInterpreterCallInProgress = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent>? responseCodeInterpreterCallInterpreting = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseCompletedEvent>? responseCompleted = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent>? responseContentPartAdded = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent>? responseContentPartDone = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseCreatedEvent>? responseCreated = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseErrorEvent>? error = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent>? responseFileSearchCallCompleted = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent>? responseFileSearchCallInProgress = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent>? responseFileSearchCallSearching = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent>? responseFunctionCallArgumentsDelta = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent>? responseFunctionCallArgumentsDone = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseInProgressEvent>? responseInProgress = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseFailedEvent>? responseFailed = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseIncompleteEvent>? responseIncomplete = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent>? responseOutputItemAdded = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent>? responseOutputItemDone = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent>? responseReasoningSummaryPartAdded = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent>? responseReasoningSummaryPartDone = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent>? responseReasoningSummaryTextDelta = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent>? responseReasoningSummaryTextDone = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent>? responseReasoningTextDelta = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent>? responseReasoningTextDone = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent>? responseRefusalDelta = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent>? responseRefusalDone = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseTextDeltaEvent>? responseOutputTextDelta = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseTextDoneEvent>? responseOutputTextDone = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent>? responseWebSearchCallCompleted = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent>? responseWebSearchCallInProgress = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent>? responseWebSearchCallSearching = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent>? responseImageGenerationCallCompleted = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent>? responseImageGenerationCallGenerating = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent>? responseImageGenerationCallInProgress = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent>? responseImageGenerationCallPartialImage = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent>? responseMcpCallArgumentsDelta = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent>? responseMcpCallArgumentsDone = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent>? responseMcpCallCompleted = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent>? responseMcpCallFailed = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent>? responseMcpCallInProgress = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent>? responseMcpListToolsCompleted = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent>? responseMcpListToolsFailed = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent>? responseMcpListToolsInProgress = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent>? responseOutputTextAnnotationAdded = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseQueuedEvent>? responseQueued = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent>? responseCustomToolCallInputDelta = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent>? responseCustomToolCallInputDone = null,
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
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent>? responseAudioDelta = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseAudioDoneEvent>? responseAudioDone = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent>? responseAudioTranscriptDelta = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent>? responseAudioTranscriptDone = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent>? responseCodeInterpreterCallCodeDelta = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent>? responseCodeInterpreterCallCodeDone = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent>? responseCodeInterpreterCallCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent>? responseCodeInterpreterCallInProgress = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent>? responseCodeInterpreterCallInterpreting = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseCompletedEvent>? responseCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent>? responseContentPartAdded = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent>? responseContentPartDone = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseCreatedEvent>? responseCreated = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseErrorEvent>? error = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent>? responseFileSearchCallCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent>? responseFileSearchCallInProgress = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent>? responseFileSearchCallSearching = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent>? responseFunctionCallArgumentsDelta = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent>? responseFunctionCallArgumentsDone = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseInProgressEvent>? responseInProgress = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseFailedEvent>? responseFailed = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseIncompleteEvent>? responseIncomplete = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent>? responseOutputItemAdded = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent>? responseOutputItemDone = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent>? responseReasoningSummaryPartAdded = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent>? responseReasoningSummaryPartDone = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent>? responseReasoningSummaryTextDelta = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent>? responseReasoningSummaryTextDone = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent>? responseReasoningTextDelta = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent>? responseReasoningTextDone = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent>? responseRefusalDelta = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent>? responseRefusalDone = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseTextDeltaEvent>? responseOutputTextDelta = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseTextDoneEvent>? responseOutputTextDone = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent>? responseWebSearchCallCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent>? responseWebSearchCallInProgress = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent>? responseWebSearchCallSearching = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent>? responseImageGenerationCallCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent>? responseImageGenerationCallGenerating = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent>? responseImageGenerationCallInProgress = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent>? responseImageGenerationCallPartialImage = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent>? responseMcpCallArgumentsDelta = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent>? responseMcpCallArgumentsDone = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent>? responseMcpCallCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent>? responseMcpCallFailed = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent>? responseMcpCallInProgress = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent>? responseMcpListToolsCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent>? responseMcpListToolsFailed = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent>? responseMcpListToolsInProgress = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent>? responseOutputTextAnnotationAdded = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseQueuedEvent>? responseQueued = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent>? responseCustomToolCallInputDelta = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent>? responseCustomToolCallInputDone = null,
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
                typeof(global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent),
                ResponseAudioDone,
                typeof(global::tryAGI.OpenAI.BetaResponseAudioDoneEvent),
                ResponseAudioTranscriptDelta,
                typeof(global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent),
                ResponseAudioTranscriptDone,
                typeof(global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent),
                ResponseCodeInterpreterCallCodeDelta,
                typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent),
                ResponseCodeInterpreterCallCodeDone,
                typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent),
                ResponseCodeInterpreterCallCompleted,
                typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent),
                ResponseCodeInterpreterCallInProgress,
                typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent),
                ResponseCodeInterpreterCallInterpreting,
                typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent),
                ResponseCompleted,
                typeof(global::tryAGI.OpenAI.BetaResponseCompletedEvent),
                ResponseContentPartAdded,
                typeof(global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent),
                ResponseContentPartDone,
                typeof(global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent),
                ResponseCreated,
                typeof(global::tryAGI.OpenAI.BetaResponseCreatedEvent),
                Error,
                typeof(global::tryAGI.OpenAI.BetaResponseErrorEvent),
                ResponseFileSearchCallCompleted,
                typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent),
                ResponseFileSearchCallInProgress,
                typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent),
                ResponseFileSearchCallSearching,
                typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent),
                ResponseFunctionCallArgumentsDelta,
                typeof(global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent),
                ResponseFunctionCallArgumentsDone,
                typeof(global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent),
                ResponseInProgress,
                typeof(global::tryAGI.OpenAI.BetaResponseInProgressEvent),
                ResponseFailed,
                typeof(global::tryAGI.OpenAI.BetaResponseFailedEvent),
                ResponseIncomplete,
                typeof(global::tryAGI.OpenAI.BetaResponseIncompleteEvent),
                ResponseOutputItemAdded,
                typeof(global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent),
                ResponseOutputItemDone,
                typeof(global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent),
                ResponseReasoningSummaryPartAdded,
                typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent),
                ResponseReasoningSummaryPartDone,
                typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent),
                ResponseReasoningSummaryTextDelta,
                typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent),
                ResponseReasoningSummaryTextDone,
                typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent),
                ResponseReasoningTextDelta,
                typeof(global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent),
                ResponseReasoningTextDone,
                typeof(global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent),
                ResponseRefusalDelta,
                typeof(global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent),
                ResponseRefusalDone,
                typeof(global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent),
                ResponseOutputTextDelta,
                typeof(global::tryAGI.OpenAI.BetaResponseTextDeltaEvent),
                ResponseOutputTextDone,
                typeof(global::tryAGI.OpenAI.BetaResponseTextDoneEvent),
                ResponseWebSearchCallCompleted,
                typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent),
                ResponseWebSearchCallInProgress,
                typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent),
                ResponseWebSearchCallSearching,
                typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent),
                ResponseImageGenerationCallCompleted,
                typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent),
                ResponseImageGenerationCallGenerating,
                typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent),
                ResponseImageGenerationCallInProgress,
                typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent),
                ResponseImageGenerationCallPartialImage,
                typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent),
                ResponseMcpCallArgumentsDelta,
                typeof(global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent),
                ResponseMcpCallArgumentsDone,
                typeof(global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent),
                ResponseMcpCallCompleted,
                typeof(global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent),
                ResponseMcpCallFailed,
                typeof(global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent),
                ResponseMcpCallInProgress,
                typeof(global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent),
                ResponseMcpListToolsCompleted,
                typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent),
                ResponseMcpListToolsFailed,
                typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent),
                ResponseMcpListToolsInProgress,
                typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent),
                ResponseOutputTextAnnotationAdded,
                typeof(global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent),
                ResponseQueued,
                typeof(global::tryAGI.OpenAI.BetaResponseQueuedEvent),
                ResponseCustomToolCallInputDelta,
                typeof(global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent),
                ResponseCustomToolCallInputDone,
                typeof(global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent),
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
        public bool Equals(BetaResponseStreamEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent?>.Default.Equals(ResponseAudioDelta, other.ResponseAudioDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseAudioDoneEvent?>.Default.Equals(ResponseAudioDone, other.ResponseAudioDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent?>.Default.Equals(ResponseAudioTranscriptDelta, other.ResponseAudioTranscriptDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent?>.Default.Equals(ResponseAudioTranscriptDone, other.ResponseAudioTranscriptDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent?>.Default.Equals(ResponseCodeInterpreterCallCodeDelta, other.ResponseCodeInterpreterCallCodeDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent?>.Default.Equals(ResponseCodeInterpreterCallCodeDone, other.ResponseCodeInterpreterCallCodeDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent?>.Default.Equals(ResponseCodeInterpreterCallCompleted, other.ResponseCodeInterpreterCallCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent?>.Default.Equals(ResponseCodeInterpreterCallInProgress, other.ResponseCodeInterpreterCallInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent?>.Default.Equals(ResponseCodeInterpreterCallInterpreting, other.ResponseCodeInterpreterCallInterpreting) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseCompletedEvent?>.Default.Equals(ResponseCompleted, other.ResponseCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent?>.Default.Equals(ResponseContentPartAdded, other.ResponseContentPartAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent?>.Default.Equals(ResponseContentPartDone, other.ResponseContentPartDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseCreatedEvent?>.Default.Equals(ResponseCreated, other.ResponseCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseErrorEvent?>.Default.Equals(Error, other.Error) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent?>.Default.Equals(ResponseFileSearchCallCompleted, other.ResponseFileSearchCallCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent?>.Default.Equals(ResponseFileSearchCallInProgress, other.ResponseFileSearchCallInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent?>.Default.Equals(ResponseFileSearchCallSearching, other.ResponseFileSearchCallSearching) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent?>.Default.Equals(ResponseFunctionCallArgumentsDelta, other.ResponseFunctionCallArgumentsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent?>.Default.Equals(ResponseFunctionCallArgumentsDone, other.ResponseFunctionCallArgumentsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseInProgressEvent?>.Default.Equals(ResponseInProgress, other.ResponseInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseFailedEvent?>.Default.Equals(ResponseFailed, other.ResponseFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseIncompleteEvent?>.Default.Equals(ResponseIncomplete, other.ResponseIncomplete) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent?>.Default.Equals(ResponseOutputItemAdded, other.ResponseOutputItemAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent?>.Default.Equals(ResponseOutputItemDone, other.ResponseOutputItemDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent?>.Default.Equals(ResponseReasoningSummaryPartAdded, other.ResponseReasoningSummaryPartAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent?>.Default.Equals(ResponseReasoningSummaryPartDone, other.ResponseReasoningSummaryPartDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent?>.Default.Equals(ResponseReasoningSummaryTextDelta, other.ResponseReasoningSummaryTextDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent?>.Default.Equals(ResponseReasoningSummaryTextDone, other.ResponseReasoningSummaryTextDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent?>.Default.Equals(ResponseReasoningTextDelta, other.ResponseReasoningTextDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent?>.Default.Equals(ResponseReasoningTextDone, other.ResponseReasoningTextDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent?>.Default.Equals(ResponseRefusalDelta, other.ResponseRefusalDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent?>.Default.Equals(ResponseRefusalDone, other.ResponseRefusalDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseTextDeltaEvent?>.Default.Equals(ResponseOutputTextDelta, other.ResponseOutputTextDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseTextDoneEvent?>.Default.Equals(ResponseOutputTextDone, other.ResponseOutputTextDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent?>.Default.Equals(ResponseWebSearchCallCompleted, other.ResponseWebSearchCallCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent?>.Default.Equals(ResponseWebSearchCallInProgress, other.ResponseWebSearchCallInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent?>.Default.Equals(ResponseWebSearchCallSearching, other.ResponseWebSearchCallSearching) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent?>.Default.Equals(ResponseImageGenerationCallCompleted, other.ResponseImageGenerationCallCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent?>.Default.Equals(ResponseImageGenerationCallGenerating, other.ResponseImageGenerationCallGenerating) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent?>.Default.Equals(ResponseImageGenerationCallInProgress, other.ResponseImageGenerationCallInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent?>.Default.Equals(ResponseImageGenerationCallPartialImage, other.ResponseImageGenerationCallPartialImage) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent?>.Default.Equals(ResponseMcpCallArgumentsDelta, other.ResponseMcpCallArgumentsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent?>.Default.Equals(ResponseMcpCallArgumentsDone, other.ResponseMcpCallArgumentsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent?>.Default.Equals(ResponseMcpCallCompleted, other.ResponseMcpCallCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent?>.Default.Equals(ResponseMcpCallFailed, other.ResponseMcpCallFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent?>.Default.Equals(ResponseMcpCallInProgress, other.ResponseMcpCallInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent?>.Default.Equals(ResponseMcpListToolsCompleted, other.ResponseMcpListToolsCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent?>.Default.Equals(ResponseMcpListToolsFailed, other.ResponseMcpListToolsFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent?>.Default.Equals(ResponseMcpListToolsInProgress, other.ResponseMcpListToolsInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent?>.Default.Equals(ResponseOutputTextAnnotationAdded, other.ResponseOutputTextAnnotationAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseQueuedEvent?>.Default.Equals(ResponseQueued, other.ResponseQueued) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent?>.Default.Equals(ResponseCustomToolCallInputDelta, other.ResponseCustomToolCallInputDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent?>.Default.Equals(ResponseCustomToolCallInputDone, other.ResponseCustomToolCallInputDone)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaResponseStreamEvent obj1, BetaResponseStreamEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaResponseStreamEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaResponseStreamEvent obj1, BetaResponseStreamEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaResponseStreamEvent o && Equals(o);
        }
    }
}
