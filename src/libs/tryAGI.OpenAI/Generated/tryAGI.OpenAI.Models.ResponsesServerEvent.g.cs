#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Server events emitted by the Responses WebSocket server.
    /// </summary>
    public readonly partial struct ResponsesServerEvent : global::System.IEquatable<ResponsesServerEvent>
    {
        /// <summary>
        /// Emitted when there is a partial audio response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDelta2>? ResponseAudioWsDelta { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDelta2>? ResponseAudioWsDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseAudioWsDelta))]
#endif
        public bool IsResponseAudioWsDelta => ResponseAudioWsDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseAudioWsDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDelta2>? value)
        {
            value = ResponseAudioWsDelta;
            return IsResponseAudioWsDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDelta2> PickResponseAudioWsDelta() => ResponseAudioWsDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseAudioWsDelta' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when the audio response is complete.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDone2>? ResponseAudioWsDone { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDone2>? ResponseAudioWsDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseAudioWsDone))]
#endif
        public bool IsResponseAudioWsDone => ResponseAudioWsDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseAudioWsDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDone2>? value)
        {
            value = ResponseAudioWsDone;
            return IsResponseAudioWsDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDone2> PickResponseAudioWsDone() => ResponseAudioWsDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseAudioWsDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when there is a partial transcript of audio.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDelta2>? ResponseAudioTranscriptWsDelta { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDelta2>? ResponseAudioTranscriptWsDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseAudioTranscriptWsDelta))]
#endif
        public bool IsResponseAudioTranscriptWsDelta => ResponseAudioTranscriptWsDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseAudioTranscriptWsDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDelta2>? value)
        {
            value = ResponseAudioTranscriptWsDelta;
            return IsResponseAudioTranscriptWsDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDelta2> PickResponseAudioTranscriptWsDelta() => ResponseAudioTranscriptWsDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseAudioTranscriptWsDelta' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when the full audio transcript is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDone2>? ResponseAudioTranscriptWsDone { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDone2>? ResponseAudioTranscriptWsDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseAudioTranscriptWsDone))]
#endif
        public bool IsResponseAudioTranscriptWsDone => ResponseAudioTranscriptWsDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseAudioTranscriptWsDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDone2>? value)
        {
            value = ResponseAudioTranscriptWsDone;
            return IsResponseAudioTranscriptWsDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDone2> PickResponseAudioTranscriptWsDone() => ResponseAudioTranscriptWsDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseAudioTranscriptWsDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a partial code snippet is streamed by the code interpreter.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDelta2>? ResponseCodeInterpreterCallCodeWsDelta { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDelta2>? ResponseCodeInterpreterCallCodeWsDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCodeInterpreterCallCodeWsDelta))]
#endif
        public bool IsResponseCodeInterpreterCallCodeWsDelta => ResponseCodeInterpreterCallCodeWsDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseCodeInterpreterCallCodeWsDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDelta2>? value)
        {
            value = ResponseCodeInterpreterCallCodeWsDelta;
            return IsResponseCodeInterpreterCallCodeWsDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDelta2> PickResponseCodeInterpreterCallCodeWsDelta() => ResponseCodeInterpreterCallCodeWsDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCodeInterpreterCallCodeWsDelta' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when the code snippet is finalized by the code interpreter.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDone2>? ResponseCodeInterpreterCallCodeWsDone { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDone2>? ResponseCodeInterpreterCallCodeWsDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCodeInterpreterCallCodeWsDone))]
#endif
        public bool IsResponseCodeInterpreterCallCodeWsDone => ResponseCodeInterpreterCallCodeWsDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseCodeInterpreterCallCodeWsDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDone2>? value)
        {
            value = ResponseCodeInterpreterCallCodeWsDone;
            return IsResponseCodeInterpreterCallCodeWsDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDone2> PickResponseCodeInterpreterCallCodeWsDone() => ResponseCodeInterpreterCallCodeWsDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCodeInterpreterCallCodeWsDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when the code interpreter call is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsCompleted2>? ResponseCodeInterpreterCallWsCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsCompleted2>? ResponseCodeInterpreterCallWsCompleted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCodeInterpreterCallWsCompleted))]
#endif
        public bool IsResponseCodeInterpreterCallWsCompleted => ResponseCodeInterpreterCallWsCompleted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseCodeInterpreterCallWsCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsCompleted2>? value)
        {
            value = ResponseCodeInterpreterCallWsCompleted;
            return IsResponseCodeInterpreterCallWsCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsCompleted2> PickResponseCodeInterpreterCallWsCompleted() => ResponseCodeInterpreterCallWsCompleted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCodeInterpreterCallWsCompleted' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a code interpreter call is in progress.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallInWsProgress2>? ResponseCodeInterpreterCallInWsProgress { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallInWsProgress2>? ResponseCodeInterpreterCallInWsProgress { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCodeInterpreterCallInWsProgress))]
#endif
        public bool IsResponseCodeInterpreterCallInWsProgress => ResponseCodeInterpreterCallInWsProgress != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseCodeInterpreterCallInWsProgress(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallInWsProgress2>? value)
        {
            value = ResponseCodeInterpreterCallInWsProgress;
            return IsResponseCodeInterpreterCallInWsProgress;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallInWsProgress2> PickResponseCodeInterpreterCallInWsProgress() => ResponseCodeInterpreterCallInWsProgress is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCodeInterpreterCallInWsProgress' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when the code interpreter is actively interpreting the code snippet.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsInterpreting2>? ResponseCodeInterpreterCallWsInterpreting { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsInterpreting2>? ResponseCodeInterpreterCallWsInterpreting { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCodeInterpreterCallWsInterpreting))]
#endif
        public bool IsResponseCodeInterpreterCallWsInterpreting => ResponseCodeInterpreterCallWsInterpreting != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseCodeInterpreterCallWsInterpreting(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsInterpreting2>? value)
        {
            value = ResponseCodeInterpreterCallWsInterpreting;
            return IsResponseCodeInterpreterCallWsInterpreting;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsInterpreting2> PickResponseCodeInterpreterCallWsInterpreting() => ResponseCodeInterpreterCallWsInterpreting is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCodeInterpreterCallWsInterpreting' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when new summary content is sampled for a compaction trigger. Contains no summary content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCompactionWsCompacting2>? ResponseCompactionWsCompacting { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCompactionWsCompacting2>? ResponseCompactionWsCompacting { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCompactionWsCompacting))]
#endif
        public bool IsResponseCompactionWsCompacting => ResponseCompactionWsCompacting != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseCompactionWsCompacting(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCompactionWsCompacting2>? value)
        {
            value = ResponseCompactionWsCompacting;
            return IsResponseCompactionWsCompacting;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCompactionWsCompacting2> PickResponseCompactionWsCompacting() => ResponseCompactionWsCompacting is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCompactionWsCompacting' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when the model response is complete.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCompleted2>? ResponseWsCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCompleted2>? ResponseWsCompleted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseWsCompleted))]
#endif
        public bool IsResponseWsCompleted => ResponseWsCompleted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseWsCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCompleted2>? value)
        {
            value = ResponseWsCompleted;
            return IsResponseWsCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCompleted2> PickResponseWsCompleted() => ResponseWsCompleted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseWsCompleted' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a new content part is added.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsAdded2>? ResponseContentPartWsAdded { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsAdded2>? ResponseContentPartWsAdded { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseContentPartWsAdded))]
#endif
        public bool IsResponseContentPartWsAdded => ResponseContentPartWsAdded != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseContentPartWsAdded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsAdded2>? value)
        {
            value = ResponseContentPartWsAdded;
            return IsResponseContentPartWsAdded;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsAdded2> PickResponseContentPartWsAdded() => ResponseContentPartWsAdded is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseContentPartWsAdded' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a content part is done.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsDone2>? ResponseContentPartWsDone { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsDone2>? ResponseContentPartWsDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseContentPartWsDone))]
#endif
        public bool IsResponseContentPartWsDone => ResponseContentPartWsDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseContentPartWsDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsDone2>? value)
        {
            value = ResponseContentPartWsDone;
            return IsResponseContentPartWsDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsDone2> PickResponseContentPartWsDone() => ResponseContentPartWsDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseContentPartWsDone' but the value was {ToString()}.");

        /// <summary>
        /// An event that is emitted when a response is created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCreatedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCreated2>? ResponseWsCreated { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCreatedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCreated2>? ResponseWsCreated { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseWsCreated))]
#endif
        public bool IsResponseWsCreated => ResponseWsCreated != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseWsCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCreatedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCreated2>? value)
        {
            value = ResponseWsCreated;
            return IsResponseWsCreated;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCreatedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCreated2> PickResponseWsCreated() => ResponseWsCreated is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseWsCreated' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a file search call is completed (results found).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsCompleted2>? ResponseFileSearchCallWsCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsCompleted2>? ResponseFileSearchCallWsCompleted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFileSearchCallWsCompleted))]
#endif
        public bool IsResponseFileSearchCallWsCompleted => ResponseFileSearchCallWsCompleted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseFileSearchCallWsCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsCompleted2>? value)
        {
            value = ResponseFileSearchCallWsCompleted;
            return IsResponseFileSearchCallWsCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsCompleted2> PickResponseFileSearchCallWsCompleted() => ResponseFileSearchCallWsCompleted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseFileSearchCallWsCompleted' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a file search call is initiated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallInWsProgress2>? ResponseFileSearchCallInWsProgress { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallInWsProgress2>? ResponseFileSearchCallInWsProgress { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFileSearchCallInWsProgress))]
#endif
        public bool IsResponseFileSearchCallInWsProgress => ResponseFileSearchCallInWsProgress != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseFileSearchCallInWsProgress(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallInWsProgress2>? value)
        {
            value = ResponseFileSearchCallInWsProgress;
            return IsResponseFileSearchCallInWsProgress;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallInWsProgress2> PickResponseFileSearchCallInWsProgress() => ResponseFileSearchCallInWsProgress is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseFileSearchCallInWsProgress' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a file search is currently searching.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsSearching2>? ResponseFileSearchCallWsSearching { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsSearching2>? ResponseFileSearchCallWsSearching { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFileSearchCallWsSearching))]
#endif
        public bool IsResponseFileSearchCallWsSearching => ResponseFileSearchCallWsSearching != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseFileSearchCallWsSearching(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsSearching2>? value)
        {
            value = ResponseFileSearchCallWsSearching;
            return IsResponseFileSearchCallWsSearching;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsSearching2> PickResponseFileSearchCallWsSearching() => ResponseFileSearchCallWsSearching is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseFileSearchCallWsSearching' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when there is a partial function-call arguments delta.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDelta2>? ResponseFunctionCallArgumentsWsDelta { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDelta2>? ResponseFunctionCallArgumentsWsDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFunctionCallArgumentsWsDelta))]
#endif
        public bool IsResponseFunctionCallArgumentsWsDelta => ResponseFunctionCallArgumentsWsDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseFunctionCallArgumentsWsDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDelta2>? value)
        {
            value = ResponseFunctionCallArgumentsWsDelta;
            return IsResponseFunctionCallArgumentsWsDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDelta2> PickResponseFunctionCallArgumentsWsDelta() => ResponseFunctionCallArgumentsWsDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseFunctionCallArgumentsWsDelta' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when function-call arguments are finalized.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2>? ResponseFunctionCallArgumentsWsDone { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2>? ResponseFunctionCallArgumentsWsDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFunctionCallArgumentsWsDone))]
#endif
        public bool IsResponseFunctionCallArgumentsWsDone => ResponseFunctionCallArgumentsWsDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseFunctionCallArgumentsWsDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2>? value)
        {
            value = ResponseFunctionCallArgumentsWsDone;
            return IsResponseFunctionCallArgumentsWsDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2> PickResponseFunctionCallArgumentsWsDone() => ResponseFunctionCallArgumentsWsDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseFunctionCallArgumentsWsDone' but the value was {ToString()}.");

        /// <summary>
        /// A streaming event that indicated a shell command was added to a tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsAdded2>? ResponseShellCallCommandWsAdded { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsAdded2>? ResponseShellCallCommandWsAdded { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseShellCallCommandWsAdded))]
#endif
        public bool IsResponseShellCallCommandWsAdded => ResponseShellCallCommandWsAdded != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseShellCallCommandWsAdded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsAdded2>? value)
        {
            value = ResponseShellCallCommandWsAdded;
            return IsResponseShellCallCommandWsAdded;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsAdded2> PickResponseShellCallCommandWsAdded() => ResponseShellCallCommandWsAdded is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseShellCallCommandWsAdded' but the value was {ToString()}.");

        /// <summary>
        /// A streaming event that indicated a shell command was incrementally updated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDelta2>? ResponseShellCallCommandWsDelta { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDelta2>? ResponseShellCallCommandWsDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseShellCallCommandWsDelta))]
#endif
        public bool IsResponseShellCallCommandWsDelta => ResponseShellCallCommandWsDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseShellCallCommandWsDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDelta2>? value)
        {
            value = ResponseShellCallCommandWsDelta;
            return IsResponseShellCallCommandWsDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDelta2> PickResponseShellCallCommandWsDelta() => ResponseShellCallCommandWsDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseShellCallCommandWsDelta' but the value was {ToString()}.");

        /// <summary>
        /// A streaming event that indicated a shell command was completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDone2>? ResponseShellCallCommandWsDone { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDone2>? ResponseShellCallCommandWsDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseShellCallCommandWsDone))]
#endif
        public bool IsResponseShellCallCommandWsDone => ResponseShellCallCommandWsDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseShellCallCommandWsDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDone2>? value)
        {
            value = ResponseShellCallCommandWsDone;
            return IsResponseShellCallCommandWsDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDone2> PickResponseShellCallCommandWsDone() => ResponseShellCallCommandWsDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseShellCallCommandWsDone' but the value was {ToString()}.");

        /// <summary>
        /// A streaming event that indicated shell call output was incrementally added.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDelta2>? ResponseShellCallOutputContentWsDelta { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDelta2>? ResponseShellCallOutputContentWsDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseShellCallOutputContentWsDelta))]
#endif
        public bool IsResponseShellCallOutputContentWsDelta => ResponseShellCallOutputContentWsDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseShellCallOutputContentWsDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDelta2>? value)
        {
            value = ResponseShellCallOutputContentWsDelta;
            return IsResponseShellCallOutputContentWsDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDelta2> PickResponseShellCallOutputContentWsDelta() => ResponseShellCallOutputContentWsDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseShellCallOutputContentWsDelta' but the value was {ToString()}.");

        /// <summary>
        /// A streaming event that indicated shell call output was completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDone2>? ResponseShellCallOutputContentWsDone { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDone2>? ResponseShellCallOutputContentWsDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseShellCallOutputContentWsDone))]
#endif
        public bool IsResponseShellCallOutputContentWsDone => ResponseShellCallOutputContentWsDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseShellCallOutputContentWsDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDone2>? value)
        {
            value = ResponseShellCallOutputContentWsDone;
            return IsResponseShellCallOutputContentWsDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDone2> PickResponseShellCallOutputContentWsDone() => ResponseShellCallOutputContentWsDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseShellCallOutputContentWsDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when the response is in progress.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseInWsProgress2>? ResponseInWsProgress { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseInWsProgress2>? ResponseInWsProgress { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseInWsProgress))]
#endif
        public bool IsResponseInWsProgress => ResponseInWsProgress != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseInWsProgress(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseInWsProgress2>? value)
        {
            value = ResponseInWsProgress;
            return IsResponseInWsProgress;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseInWsProgress2> PickResponseInWsProgress() => ResponseInWsProgress is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseInWsProgress' but the value was {ToString()}.");

        /// <summary>
        /// An event that is emitted when a response fails.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsFailed2>? ResponseWsFailed { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsFailed2>? ResponseWsFailed { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseWsFailed))]
#endif
        public bool IsResponseWsFailed => ResponseWsFailed != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseWsFailed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsFailed2>? value)
        {
            value = ResponseWsFailed;
            return IsResponseWsFailed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsFailed2> PickResponseWsFailed() => ResponseWsFailed is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseWsFailed' but the value was {ToString()}.");

        /// <summary>
        /// An event that is emitted when a response finishes as incomplete.<br/>
        /// Over WebSocket, steering can finish a response with<br/>
        /// `response.incomplete_details.reason` set to `steered`, followed automatically<br/>
        /// by a successor `response.created` that commits the queued steering input.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseIncompleteEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsIncomplete2>? ResponseWsIncomplete { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseIncompleteEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsIncomplete2>? ResponseWsIncomplete { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseWsIncomplete))]
#endif
        public bool IsResponseWsIncomplete => ResponseWsIncomplete != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseWsIncomplete(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseIncompleteEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsIncomplete2>? value)
        {
            value = ResponseWsIncomplete;
            return IsResponseWsIncomplete;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseIncompleteEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsIncomplete2> PickResponseWsIncomplete() => ResponseWsIncomplete is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseWsIncomplete' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a new output item is added.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsAdded2>? ResponseOutputItemWsAdded { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsAdded2>? ResponseOutputItemWsAdded { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputItemWsAdded))]
#endif
        public bool IsResponseOutputItemWsAdded => ResponseOutputItemWsAdded != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseOutputItemWsAdded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsAdded2>? value)
        {
            value = ResponseOutputItemWsAdded;
            return IsResponseOutputItemWsAdded;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsAdded2> PickResponseOutputItemWsAdded() => ResponseOutputItemWsAdded is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputItemWsAdded' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when an output item is marked done.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsDone2>? ResponseOutputItemWsDone { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsDone2>? ResponseOutputItemWsDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputItemWsDone))]
#endif
        public bool IsResponseOutputItemWsDone => ResponseOutputItemWsDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseOutputItemWsDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsDone2>? value)
        {
            value = ResponseOutputItemWsDone;
            return IsResponseOutputItemWsDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsDone2> PickResponseOutputItemWsDone() => ResponseOutputItemWsDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputItemWsDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a new reasoning summary part is added.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsAdded2>? ResponseReasoningSummaryPartWsAdded { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsAdded2>? ResponseReasoningSummaryPartWsAdded { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseReasoningSummaryPartWsAdded))]
#endif
        public bool IsResponseReasoningSummaryPartWsAdded => ResponseReasoningSummaryPartWsAdded != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseReasoningSummaryPartWsAdded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsAdded2>? value)
        {
            value = ResponseReasoningSummaryPartWsAdded;
            return IsResponseReasoningSummaryPartWsAdded;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsAdded2> PickResponseReasoningSummaryPartWsAdded() => ResponseReasoningSummaryPartWsAdded is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseReasoningSummaryPartWsAdded' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a reasoning summary part is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsDone2>? ResponseReasoningSummaryPartWsDone { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsDone2>? ResponseReasoningSummaryPartWsDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseReasoningSummaryPartWsDone))]
#endif
        public bool IsResponseReasoningSummaryPartWsDone => ResponseReasoningSummaryPartWsDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseReasoningSummaryPartWsDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsDone2>? value)
        {
            value = ResponseReasoningSummaryPartWsDone;
            return IsResponseReasoningSummaryPartWsDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsDone2> PickResponseReasoningSummaryPartWsDone() => ResponseReasoningSummaryPartWsDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseReasoningSummaryPartWsDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a delta is added to a reasoning summary text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDelta2>? ResponseReasoningSummaryTextWsDelta { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDelta2>? ResponseReasoningSummaryTextWsDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseReasoningSummaryTextWsDelta))]
#endif
        public bool IsResponseReasoningSummaryTextWsDelta => ResponseReasoningSummaryTextWsDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseReasoningSummaryTextWsDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDelta2>? value)
        {
            value = ResponseReasoningSummaryTextWsDelta;
            return IsResponseReasoningSummaryTextWsDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDelta2> PickResponseReasoningSummaryTextWsDelta() => ResponseReasoningSummaryTextWsDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseReasoningSummaryTextWsDelta' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a reasoning summary text is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDone2>? ResponseReasoningSummaryTextWsDone { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDone2>? ResponseReasoningSummaryTextWsDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseReasoningSummaryTextWsDone))]
#endif
        public bool IsResponseReasoningSummaryTextWsDone => ResponseReasoningSummaryTextWsDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseReasoningSummaryTextWsDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDone2>? value)
        {
            value = ResponseReasoningSummaryTextWsDone;
            return IsResponseReasoningSummaryTextWsDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDone2> PickResponseReasoningSummaryTextWsDone() => ResponseReasoningSummaryTextWsDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseReasoningSummaryTextWsDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a delta is added to a reasoning text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDelta2>? ResponseReasoningTextWsDelta { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDelta2>? ResponseReasoningTextWsDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseReasoningTextWsDelta))]
#endif
        public bool IsResponseReasoningTextWsDelta => ResponseReasoningTextWsDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseReasoningTextWsDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDelta2>? value)
        {
            value = ResponseReasoningTextWsDelta;
            return IsResponseReasoningTextWsDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDelta2> PickResponseReasoningTextWsDelta() => ResponseReasoningTextWsDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseReasoningTextWsDelta' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a reasoning text is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDone2>? ResponseReasoningTextWsDone { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDone2>? ResponseReasoningTextWsDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseReasoningTextWsDone))]
#endif
        public bool IsResponseReasoningTextWsDone => ResponseReasoningTextWsDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseReasoningTextWsDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDone2>? value)
        {
            value = ResponseReasoningTextWsDone;
            return IsResponseReasoningTextWsDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDone2> PickResponseReasoningTextWsDone() => ResponseReasoningTextWsDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseReasoningTextWsDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when there is a partial refusal text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDelta2>? ResponseRefusalWsDelta { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDelta2>? ResponseRefusalWsDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseRefusalWsDelta))]
#endif
        public bool IsResponseRefusalWsDelta => ResponseRefusalWsDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseRefusalWsDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDelta2>? value)
        {
            value = ResponseRefusalWsDelta;
            return IsResponseRefusalWsDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDelta2> PickResponseRefusalWsDelta() => ResponseRefusalWsDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseRefusalWsDelta' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when refusal text is finalized.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDone2>? ResponseRefusalWsDone { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDone2>? ResponseRefusalWsDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseRefusalWsDone))]
#endif
        public bool IsResponseRefusalWsDone => ResponseRefusalWsDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseRefusalWsDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDone2>? value)
        {
            value = ResponseRefusalWsDone;
            return IsResponseRefusalWsDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDone2> PickResponseRefusalWsDone() => ResponseRefusalWsDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseRefusalWsDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when there is an additional text delta.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDelta2>? ResponseTextWsDelta { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDelta2>? ResponseTextWsDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseTextWsDelta))]
#endif
        public bool IsResponseTextWsDelta => ResponseTextWsDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseTextWsDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDelta2>? value)
        {
            value = ResponseTextWsDelta;
            return IsResponseTextWsDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDelta2> PickResponseTextWsDelta() => ResponseTextWsDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseTextWsDelta' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when text content is finalized.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDone2>? ResponseTextWsDone { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDone2>? ResponseTextWsDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseTextWsDone))]
#endif
        public bool IsResponseTextWsDone => ResponseTextWsDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseTextWsDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDone2>? value)
        {
            value = ResponseTextWsDone;
            return IsResponseTextWsDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDone2> PickResponseTextWsDone() => ResponseTextWsDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseTextWsDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a web search call is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsCompleted2>? ResponseWebSearchCallWsCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsCompleted2>? ResponseWebSearchCallWsCompleted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseWebSearchCallWsCompleted))]
#endif
        public bool IsResponseWebSearchCallWsCompleted => ResponseWebSearchCallWsCompleted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseWebSearchCallWsCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsCompleted2>? value)
        {
            value = ResponseWebSearchCallWsCompleted;
            return IsResponseWebSearchCallWsCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsCompleted2> PickResponseWebSearchCallWsCompleted() => ResponseWebSearchCallWsCompleted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseWebSearchCallWsCompleted' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a web search call is initiated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallInWsProgress2>? ResponseWebSearchCallInWsProgress { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallInWsProgress2>? ResponseWebSearchCallInWsProgress { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseWebSearchCallInWsProgress))]
#endif
        public bool IsResponseWebSearchCallInWsProgress => ResponseWebSearchCallInWsProgress != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseWebSearchCallInWsProgress(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallInWsProgress2>? value)
        {
            value = ResponseWebSearchCallInWsProgress;
            return IsResponseWebSearchCallInWsProgress;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallInWsProgress2> PickResponseWebSearchCallInWsProgress() => ResponseWebSearchCallInWsProgress is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseWebSearchCallInWsProgress' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a web search call is executing.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsSearching2>? ResponseWebSearchCallWsSearching { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsSearching2>? ResponseWebSearchCallWsSearching { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseWebSearchCallWsSearching))]
#endif
        public bool IsResponseWebSearchCallWsSearching => ResponseWebSearchCallWsSearching != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseWebSearchCallWsSearching(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsSearching2>? value)
        {
            value = ResponseWebSearchCallWsSearching;
            return IsResponseWebSearchCallWsSearching;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsSearching2> PickResponseWebSearchCallWsSearching() => ResponseWebSearchCallWsSearching is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseWebSearchCallWsSearching' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when an image generation tool call has completed and the final image is available.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsCompleted2>? ResponseImageGenCallWsCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsCompleted2>? ResponseImageGenCallWsCompleted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseImageGenCallWsCompleted))]
#endif
        public bool IsResponseImageGenCallWsCompleted => ResponseImageGenCallWsCompleted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseImageGenCallWsCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsCompleted2>? value)
        {
            value = ResponseImageGenCallWsCompleted;
            return IsResponseImageGenCallWsCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsCompleted2> PickResponseImageGenCallWsCompleted() => ResponseImageGenCallWsCompleted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseImageGenCallWsCompleted' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when an image generation tool call is actively generating an image (intermediate state).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsGenerating2>? ResponseImageGenCallWsGenerating { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsGenerating2>? ResponseImageGenCallWsGenerating { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseImageGenCallWsGenerating))]
#endif
        public bool IsResponseImageGenCallWsGenerating => ResponseImageGenCallWsGenerating != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseImageGenCallWsGenerating(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsGenerating2>? value)
        {
            value = ResponseImageGenCallWsGenerating;
            return IsResponseImageGenCallWsGenerating;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsGenerating2> PickResponseImageGenCallWsGenerating() => ResponseImageGenCallWsGenerating is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseImageGenCallWsGenerating' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when an image generation tool call is in progress.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallInWsProgress2>? ResponseImageGenCallInWsProgress { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallInWsProgress2>? ResponseImageGenCallInWsProgress { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseImageGenCallInWsProgress))]
#endif
        public bool IsResponseImageGenCallInWsProgress => ResponseImageGenCallInWsProgress != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseImageGenCallInWsProgress(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallInWsProgress2>? value)
        {
            value = ResponseImageGenCallInWsProgress;
            return IsResponseImageGenCallInWsProgress;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallInWsProgress2> PickResponseImageGenCallInWsProgress() => ResponseImageGenCallInWsProgress is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseImageGenCallInWsProgress' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a partial image is available during image generation streaming.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2>? ResponseImageGenCallPartialWsImage { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2>? ResponseImageGenCallPartialWsImage { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseImageGenCallPartialWsImage))]
#endif
        public bool IsResponseImageGenCallPartialWsImage => ResponseImageGenCallPartialWsImage != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseImageGenCallPartialWsImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2>? value)
        {
            value = ResponseImageGenCallPartialWsImage;
            return IsResponseImageGenCallPartialWsImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2> PickResponseImageGenCallPartialWsImage() => ResponseImageGenCallPartialWsImage is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseImageGenCallPartialWsImage' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when there is a delta (partial update) to the arguments of an MCP tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDelta2>? ResponseMcpCallArgumentsWsDelta { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDelta2>? ResponseMcpCallArgumentsWsDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseMcpCallArgumentsWsDelta))]
#endif
        public bool IsResponseMcpCallArgumentsWsDelta => ResponseMcpCallArgumentsWsDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseMcpCallArgumentsWsDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDelta2>? value)
        {
            value = ResponseMcpCallArgumentsWsDelta;
            return IsResponseMcpCallArgumentsWsDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDelta2> PickResponseMcpCallArgumentsWsDelta() => ResponseMcpCallArgumentsWsDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseMcpCallArgumentsWsDelta' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when the arguments for an MCP tool call are finalized.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDone2>? ResponseMcpCallArgumentsWsDone { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDone2>? ResponseMcpCallArgumentsWsDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseMcpCallArgumentsWsDone))]
#endif
        public bool IsResponseMcpCallArgumentsWsDone => ResponseMcpCallArgumentsWsDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseMcpCallArgumentsWsDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDone2>? value)
        {
            value = ResponseMcpCallArgumentsWsDone;
            return IsResponseMcpCallArgumentsWsDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDone2> PickResponseMcpCallArgumentsWsDone() => ResponseMcpCallArgumentsWsDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseMcpCallArgumentsWsDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when an MCP  tool call has completed successfully.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsCompleted2>? ResponseMcpCallWsCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsCompleted2>? ResponseMcpCallWsCompleted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseMcpCallWsCompleted))]
#endif
        public bool IsResponseMcpCallWsCompleted => ResponseMcpCallWsCompleted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseMcpCallWsCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsCompleted2>? value)
        {
            value = ResponseMcpCallWsCompleted;
            return IsResponseMcpCallWsCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsCompleted2> PickResponseMcpCallWsCompleted() => ResponseMcpCallWsCompleted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseMcpCallWsCompleted' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when an MCP  tool call has failed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsFailed2>? ResponseMcpCallWsFailed { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsFailed2>? ResponseMcpCallWsFailed { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseMcpCallWsFailed))]
#endif
        public bool IsResponseMcpCallWsFailed => ResponseMcpCallWsFailed != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseMcpCallWsFailed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsFailed2>? value)
        {
            value = ResponseMcpCallWsFailed;
            return IsResponseMcpCallWsFailed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsFailed2> PickResponseMcpCallWsFailed() => ResponseMcpCallWsFailed is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseMcpCallWsFailed' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when an MCP  tool call is in progress.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallInWsProgress2>? ResponseMcpCallInWsProgress { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallInWsProgress2>? ResponseMcpCallInWsProgress { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseMcpCallInWsProgress))]
#endif
        public bool IsResponseMcpCallInWsProgress => ResponseMcpCallInWsProgress != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseMcpCallInWsProgress(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallInWsProgress2>? value)
        {
            value = ResponseMcpCallInWsProgress;
            return IsResponseMcpCallInWsProgress;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallInWsProgress2> PickResponseMcpCallInWsProgress() => ResponseMcpCallInWsProgress is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseMcpCallInWsProgress' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when the list of available MCP tools has been successfully retrieved.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsCompleted2>? ResponseMcpListToolsWsCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsCompleted2>? ResponseMcpListToolsWsCompleted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseMcpListToolsWsCompleted))]
#endif
        public bool IsResponseMcpListToolsWsCompleted => ResponseMcpListToolsWsCompleted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseMcpListToolsWsCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsCompleted2>? value)
        {
            value = ResponseMcpListToolsWsCompleted;
            return IsResponseMcpListToolsWsCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsCompleted2> PickResponseMcpListToolsWsCompleted() => ResponseMcpListToolsWsCompleted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseMcpListToolsWsCompleted' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when the attempt to list available MCP tools has failed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsFailed2>? ResponseMcpListToolsWsFailed { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsFailed2>? ResponseMcpListToolsWsFailed { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseMcpListToolsWsFailed))]
#endif
        public bool IsResponseMcpListToolsWsFailed => ResponseMcpListToolsWsFailed != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseMcpListToolsWsFailed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsFailed2>? value)
        {
            value = ResponseMcpListToolsWsFailed;
            return IsResponseMcpListToolsWsFailed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsFailed2> PickResponseMcpListToolsWsFailed() => ResponseMcpListToolsWsFailed is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseMcpListToolsWsFailed' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when the system is in the process of retrieving the list of available MCP tools.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsInWsProgress2>? ResponseMcpListToolsInWsProgress { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsInWsProgress2>? ResponseMcpListToolsInWsProgress { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseMcpListToolsInWsProgress))]
#endif
        public bool IsResponseMcpListToolsInWsProgress => ResponseMcpListToolsInWsProgress != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseMcpListToolsInWsProgress(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsInWsProgress2>? value)
        {
            value = ResponseMcpListToolsInWsProgress;
            return IsResponseMcpListToolsInWsProgress;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsInWsProgress2> PickResponseMcpListToolsInWsProgress() => ResponseMcpListToolsInWsProgress is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseMcpListToolsInWsProgress' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when an annotation is added to output text content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputTextAnnotationWsAdded2>? ResponseOutputTextAnnotationWsAdded { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputTextAnnotationWsAdded2>? ResponseOutputTextAnnotationWsAdded { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputTextAnnotationWsAdded))]
#endif
        public bool IsResponseOutputTextAnnotationWsAdded => ResponseOutputTextAnnotationWsAdded != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseOutputTextAnnotationWsAdded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputTextAnnotationWsAdded2>? value)
        {
            value = ResponseOutputTextAnnotationWsAdded;
            return IsResponseOutputTextAnnotationWsAdded;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputTextAnnotationWsAdded2> PickResponseOutputTextAnnotationWsAdded() => ResponseOutputTextAnnotationWsAdded is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputTextAnnotationWsAdded' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a response is queued and waiting to be processed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseQueuedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsQueued2>? ResponseWsQueued { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseQueuedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsQueued2>? ResponseWsQueued { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseWsQueued))]
#endif
        public bool IsResponseWsQueued => ResponseWsQueued != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseWsQueued(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseQueuedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsQueued2>? value)
        {
            value = ResponseWsQueued;
            return IsResponseWsQueued;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseQueuedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsQueued2> PickResponseWsQueued() => ResponseWsQueued is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseWsQueued' but the value was {ToString()}.");

        /// <summary>
        /// Event representing a delta (partial update) to the input of a custom tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDelta2>? ResponseCustomToolCallInputWsDelta { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDelta2>? ResponseCustomToolCallInputWsDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCustomToolCallInputWsDelta))]
#endif
        public bool IsResponseCustomToolCallInputWsDelta => ResponseCustomToolCallInputWsDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseCustomToolCallInputWsDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDelta2>? value)
        {
            value = ResponseCustomToolCallInputWsDelta;
            return IsResponseCustomToolCallInputWsDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDelta2> PickResponseCustomToolCallInputWsDelta() => ResponseCustomToolCallInputWsDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCustomToolCallInputWsDelta' but the value was {ToString()}.");

        /// <summary>
        /// Event indicating that input for a custom tool call is complete.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDone2>? ResponseCustomToolCallInputWsDone { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDone2>? ResponseCustomToolCallInputWsDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCustomToolCallInputWsDone))]
#endif
        public bool IsResponseCustomToolCallInputWsDone => ResponseCustomToolCallInputWsDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseCustomToolCallInputWsDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDone2>? value)
        {
            value = ResponseCustomToolCallInputWsDone;
            return IsResponseCustomToolCallInputWsDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDone2> PickResponseCustomToolCallInputWsDone() => ResponseCustomToolCallInputWsDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCustomToolCallInputWsDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when an error occurs while processing a Responses WebSocket request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseWsError? Error { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseWsError? Error { get; }
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
            out global::tryAGI.OpenAI.ResponseWsError? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseWsError PickError() => Error is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Error' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when steering input has been validated and queued. Acceptance means<br/>
        /// the server owns the input, not that it has been applied. The successor's<br/>
        /// `response.created` event is the commit point. If accepted input cannot be<br/>
        /// committed, `response.steer.failed` returns it with the same steering ID.<br/>
        /// When the response stops for client-owned tool output or approval, the input<br/>
        /// remains queued and `response.steer.pending` is emitted after<br/>
        /// `response.completed`. Fill the pending event's `required_input` stubs with<br/>
        /// saved results and send one matching explicit `response.create` per parent.<br/>
        /// Do not resend accepted input while it is still queued.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseSteerAcceptedEvent? ResponseSteerAccepted { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseSteerAcceptedEvent? ResponseSteerAccepted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseSteerAccepted))]
#endif
        public bool IsResponseSteerAccepted => ResponseSteerAccepted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseSteerAccepted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseSteerAcceptedEvent? value)
        {
            value = ResponseSteerAccepted;
            return IsResponseSteerAccepted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerAcceptedEvent PickResponseSteerAccepted() => ResponseSteerAccepted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseSteerAccepted' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when accepted steering input remains queued after the target<br/>
        /// response completes. The server still owns the input. Do not resend it.<br/>
        /// The successor's `response.created` event is the commit point.<br/>
        /// When `reason` is `waiting_for_required_input`, this event follows<br/>
        /// `response.completed` while the response waits for the tool results or<br/>
        /// approval decisions identified by `required_input`. Copy those stubs, fill<br/>
        /// their result fields using the ordinary `response.create` input schemas,<br/>
        /// and submit one continuation per parent with the same `previous_response_id`<br/>
        /// and WebSocket lane. Use saved results without rerunning tools. The queued<br/>
        /// steering input is prepended in submission order to the continuation's<br/>
        /// input. That explicit request retains its own settings.<br/>
        /// This notification is emitted at most once per steering submission. Multiple<br/>
        /// submissions for the same parent can report the same required inputs; they<br/>
        /// do not each require a separate continuation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseSteerPendingEvent? ResponseSteerPending { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseSteerPendingEvent? ResponseSteerPending { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseSteerPending))]
#endif
        public bool IsResponseSteerPending => ResponseSteerPending != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseSteerPending(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseSteerPendingEvent? value)
        {
            value = ResponseSteerPending;
            return IsResponseSteerPending;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerPendingEvent PickResponseSteerPending() => ResponseSteerPending is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseSteerPending' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when steering input is rejected or cannot be committed to a<br/>
        /// successor response. Returns the original, uncommitted input so the client<br/>
        /// can carry it into `response.create` when appropriate. Invalid input must<br/>
        /// be corrected before retrying.<br/>
        /// Failures after acceptance include the same steering ID. Failures before an<br/>
        /// ID is allocated omit `steer.id`. A lost connection or missing acknowledgement<br/>
        /// leaves the outcome unknown; it is not proof that the input was rejected.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseSteerFailedEvent? ResponseSteerFailed { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseSteerFailedEvent? ResponseSteerFailed { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseSteerFailed))]
#endif
        public bool IsResponseSteerFailed => ResponseSteerFailed != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseSteerFailed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseSteerFailedEvent? value)
        {
            value = ResponseSteerFailed;
            return IsResponseSteerFailed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerFailedEvent PickResponseSteerFailed() => ResponseSteerFailed is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseSteerFailed' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDelta2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDelta2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDelta2>?(ResponsesServerEvent @this) => @this.ResponseAudioWsDelta;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDelta2>? value)
        {
            ResponseAudioWsDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseAudioWsDelta(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDelta2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDone2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDone2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDone2>?(ResponsesServerEvent @this) => @this.ResponseAudioWsDone;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDone2>? value)
        {
            ResponseAudioWsDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseAudioWsDone(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDone2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDelta2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDelta2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDelta2>?(ResponsesServerEvent @this) => @this.ResponseAudioTranscriptWsDelta;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDelta2>? value)
        {
            ResponseAudioTranscriptWsDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseAudioTranscriptWsDelta(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDelta2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDone2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDone2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDone2>?(ResponsesServerEvent @this) => @this.ResponseAudioTranscriptWsDone;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDone2>? value)
        {
            ResponseAudioTranscriptWsDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseAudioTranscriptWsDone(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDone2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDelta2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDelta2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDelta2>?(ResponsesServerEvent @this) => @this.ResponseCodeInterpreterCallCodeWsDelta;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDelta2>? value)
        {
            ResponseCodeInterpreterCallCodeWsDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseCodeInterpreterCallCodeWsDelta(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDelta2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDone2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDone2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDone2>?(ResponsesServerEvent @this) => @this.ResponseCodeInterpreterCallCodeWsDone;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDone2>? value)
        {
            ResponseCodeInterpreterCallCodeWsDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseCodeInterpreterCallCodeWsDone(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDone2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsCompleted2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsCompleted2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsCompleted2>?(ResponsesServerEvent @this) => @this.ResponseCodeInterpreterCallWsCompleted;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsCompleted2>? value)
        {
            ResponseCodeInterpreterCallWsCompleted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseCodeInterpreterCallWsCompleted(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsCompleted2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallInWsProgress2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallInWsProgress2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallInWsProgress2>?(ResponsesServerEvent @this) => @this.ResponseCodeInterpreterCallInWsProgress;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallInWsProgress2>? value)
        {
            ResponseCodeInterpreterCallInWsProgress = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseCodeInterpreterCallInWsProgress(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallInWsProgress2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsInterpreting2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsInterpreting2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsInterpreting2>?(ResponsesServerEvent @this) => @this.ResponseCodeInterpreterCallWsInterpreting;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsInterpreting2>? value)
        {
            ResponseCodeInterpreterCallWsInterpreting = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseCodeInterpreterCallWsInterpreting(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsInterpreting2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCompactionWsCompacting2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCompactionWsCompacting2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCompactionWsCompacting2>?(ResponsesServerEvent @this) => @this.ResponseCompactionWsCompacting;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCompactionWsCompacting2>? value)
        {
            ResponseCompactionWsCompacting = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseCompactionWsCompacting(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCompactionWsCompacting2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCompleted2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCompleted2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCompleted2>?(ResponsesServerEvent @this) => @this.ResponseWsCompleted;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCompleted2>? value)
        {
            ResponseWsCompleted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseWsCompleted(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCompleted2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsAdded2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsAdded2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsAdded2>?(ResponsesServerEvent @this) => @this.ResponseContentPartWsAdded;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsAdded2>? value)
        {
            ResponseContentPartWsAdded = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseContentPartWsAdded(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsAdded2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsDone2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsDone2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsDone2>?(ResponsesServerEvent @this) => @this.ResponseContentPartWsDone;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsDone2>? value)
        {
            ResponseContentPartWsDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseContentPartWsDone(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsDone2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCreatedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCreated2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCreatedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCreated2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCreatedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCreated2>?(ResponsesServerEvent @this) => @this.ResponseWsCreated;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCreatedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCreated2>? value)
        {
            ResponseWsCreated = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseWsCreated(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCreatedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCreated2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsCompleted2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsCompleted2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsCompleted2>?(ResponsesServerEvent @this) => @this.ResponseFileSearchCallWsCompleted;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsCompleted2>? value)
        {
            ResponseFileSearchCallWsCompleted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseFileSearchCallWsCompleted(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsCompleted2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallInWsProgress2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallInWsProgress2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallInWsProgress2>?(ResponsesServerEvent @this) => @this.ResponseFileSearchCallInWsProgress;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallInWsProgress2>? value)
        {
            ResponseFileSearchCallInWsProgress = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseFileSearchCallInWsProgress(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallInWsProgress2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsSearching2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsSearching2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsSearching2>?(ResponsesServerEvent @this) => @this.ResponseFileSearchCallWsSearching;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsSearching2>? value)
        {
            ResponseFileSearchCallWsSearching = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseFileSearchCallWsSearching(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsSearching2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDelta2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDelta2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDelta2>?(ResponsesServerEvent @this) => @this.ResponseFunctionCallArgumentsWsDelta;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDelta2>? value)
        {
            ResponseFunctionCallArgumentsWsDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseFunctionCallArgumentsWsDelta(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDelta2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2>?(ResponsesServerEvent @this) => @this.ResponseFunctionCallArgumentsWsDone;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2>? value)
        {
            ResponseFunctionCallArgumentsWsDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseFunctionCallArgumentsWsDone(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsAdded2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsAdded2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsAdded2>?(ResponsesServerEvent @this) => @this.ResponseShellCallCommandWsAdded;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsAdded2>? value)
        {
            ResponseShellCallCommandWsAdded = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseShellCallCommandWsAdded(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsAdded2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDelta2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDelta2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDelta2>?(ResponsesServerEvent @this) => @this.ResponseShellCallCommandWsDelta;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDelta2>? value)
        {
            ResponseShellCallCommandWsDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseShellCallCommandWsDelta(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDelta2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDone2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDone2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDone2>?(ResponsesServerEvent @this) => @this.ResponseShellCallCommandWsDone;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDone2>? value)
        {
            ResponseShellCallCommandWsDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseShellCallCommandWsDone(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDone2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDelta2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDelta2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDelta2>?(ResponsesServerEvent @this) => @this.ResponseShellCallOutputContentWsDelta;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDelta2>? value)
        {
            ResponseShellCallOutputContentWsDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseShellCallOutputContentWsDelta(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDelta2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDone2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDone2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDone2>?(ResponsesServerEvent @this) => @this.ResponseShellCallOutputContentWsDone;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDone2>? value)
        {
            ResponseShellCallOutputContentWsDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseShellCallOutputContentWsDone(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDone2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseInWsProgress2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseInWsProgress2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseInWsProgress2>?(ResponsesServerEvent @this) => @this.ResponseInWsProgress;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseInWsProgress2>? value)
        {
            ResponseInWsProgress = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseInWsProgress(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseInWsProgress2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsFailed2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsFailed2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsFailed2>?(ResponsesServerEvent @this) => @this.ResponseWsFailed;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsFailed2>? value)
        {
            ResponseWsFailed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseWsFailed(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsFailed2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseIncompleteEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsIncomplete2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseIncompleteEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsIncomplete2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseIncompleteEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsIncomplete2>?(ResponsesServerEvent @this) => @this.ResponseWsIncomplete;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseIncompleteEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsIncomplete2>? value)
        {
            ResponseWsIncomplete = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseWsIncomplete(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseIncompleteEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsIncomplete2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsAdded2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsAdded2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsAdded2>?(ResponsesServerEvent @this) => @this.ResponseOutputItemWsAdded;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsAdded2>? value)
        {
            ResponseOutputItemWsAdded = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseOutputItemWsAdded(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsAdded2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsDone2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsDone2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsDone2>?(ResponsesServerEvent @this) => @this.ResponseOutputItemWsDone;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsDone2>? value)
        {
            ResponseOutputItemWsDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseOutputItemWsDone(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsDone2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsAdded2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsAdded2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsAdded2>?(ResponsesServerEvent @this) => @this.ResponseReasoningSummaryPartWsAdded;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsAdded2>? value)
        {
            ResponseReasoningSummaryPartWsAdded = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseReasoningSummaryPartWsAdded(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsAdded2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsDone2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsDone2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsDone2>?(ResponsesServerEvent @this) => @this.ResponseReasoningSummaryPartWsDone;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsDone2>? value)
        {
            ResponseReasoningSummaryPartWsDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseReasoningSummaryPartWsDone(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsDone2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDelta2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDelta2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDelta2>?(ResponsesServerEvent @this) => @this.ResponseReasoningSummaryTextWsDelta;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDelta2>? value)
        {
            ResponseReasoningSummaryTextWsDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseReasoningSummaryTextWsDelta(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDelta2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDone2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDone2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDone2>?(ResponsesServerEvent @this) => @this.ResponseReasoningSummaryTextWsDone;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDone2>? value)
        {
            ResponseReasoningSummaryTextWsDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseReasoningSummaryTextWsDone(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDone2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDelta2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDelta2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDelta2>?(ResponsesServerEvent @this) => @this.ResponseReasoningTextWsDelta;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDelta2>? value)
        {
            ResponseReasoningTextWsDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseReasoningTextWsDelta(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDelta2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDone2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDone2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDone2>?(ResponsesServerEvent @this) => @this.ResponseReasoningTextWsDone;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDone2>? value)
        {
            ResponseReasoningTextWsDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseReasoningTextWsDone(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDone2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDelta2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDelta2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDelta2>?(ResponsesServerEvent @this) => @this.ResponseRefusalWsDelta;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDelta2>? value)
        {
            ResponseRefusalWsDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseRefusalWsDelta(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDelta2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDone2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDone2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDone2>?(ResponsesServerEvent @this) => @this.ResponseRefusalWsDone;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDone2>? value)
        {
            ResponseRefusalWsDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseRefusalWsDone(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDone2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDelta2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDelta2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDelta2>?(ResponsesServerEvent @this) => @this.ResponseTextWsDelta;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDelta2>? value)
        {
            ResponseTextWsDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseTextWsDelta(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDelta2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDone2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDone2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDone2>?(ResponsesServerEvent @this) => @this.ResponseTextWsDone;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDone2>? value)
        {
            ResponseTextWsDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseTextWsDone(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDone2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsCompleted2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsCompleted2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsCompleted2>?(ResponsesServerEvent @this) => @this.ResponseWebSearchCallWsCompleted;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsCompleted2>? value)
        {
            ResponseWebSearchCallWsCompleted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseWebSearchCallWsCompleted(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsCompleted2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallInWsProgress2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallInWsProgress2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallInWsProgress2>?(ResponsesServerEvent @this) => @this.ResponseWebSearchCallInWsProgress;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallInWsProgress2>? value)
        {
            ResponseWebSearchCallInWsProgress = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseWebSearchCallInWsProgress(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallInWsProgress2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsSearching2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsSearching2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsSearching2>?(ResponsesServerEvent @this) => @this.ResponseWebSearchCallWsSearching;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsSearching2>? value)
        {
            ResponseWebSearchCallWsSearching = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseWebSearchCallWsSearching(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsSearching2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsCompleted2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsCompleted2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsCompleted2>?(ResponsesServerEvent @this) => @this.ResponseImageGenCallWsCompleted;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsCompleted2>? value)
        {
            ResponseImageGenCallWsCompleted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseImageGenCallWsCompleted(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsCompleted2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsGenerating2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsGenerating2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsGenerating2>?(ResponsesServerEvent @this) => @this.ResponseImageGenCallWsGenerating;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsGenerating2>? value)
        {
            ResponseImageGenCallWsGenerating = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseImageGenCallWsGenerating(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsGenerating2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallInWsProgress2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallInWsProgress2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallInWsProgress2>?(ResponsesServerEvent @this) => @this.ResponseImageGenCallInWsProgress;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallInWsProgress2>? value)
        {
            ResponseImageGenCallInWsProgress = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseImageGenCallInWsProgress(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallInWsProgress2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2>?(ResponsesServerEvent @this) => @this.ResponseImageGenCallPartialWsImage;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2>? value)
        {
            ResponseImageGenCallPartialWsImage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseImageGenCallPartialWsImage(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDelta2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDelta2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDelta2>?(ResponsesServerEvent @this) => @this.ResponseMcpCallArgumentsWsDelta;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDelta2>? value)
        {
            ResponseMcpCallArgumentsWsDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseMcpCallArgumentsWsDelta(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDelta2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDone2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDone2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDone2>?(ResponsesServerEvent @this) => @this.ResponseMcpCallArgumentsWsDone;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDone2>? value)
        {
            ResponseMcpCallArgumentsWsDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseMcpCallArgumentsWsDone(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDone2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsCompleted2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsCompleted2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsCompleted2>?(ResponsesServerEvent @this) => @this.ResponseMcpCallWsCompleted;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsCompleted2>? value)
        {
            ResponseMcpCallWsCompleted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseMcpCallWsCompleted(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsCompleted2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsFailed2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsFailed2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsFailed2>?(ResponsesServerEvent @this) => @this.ResponseMcpCallWsFailed;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsFailed2>? value)
        {
            ResponseMcpCallWsFailed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseMcpCallWsFailed(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsFailed2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallInWsProgress2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallInWsProgress2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallInWsProgress2>?(ResponsesServerEvent @this) => @this.ResponseMcpCallInWsProgress;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallInWsProgress2>? value)
        {
            ResponseMcpCallInWsProgress = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseMcpCallInWsProgress(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallInWsProgress2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsCompleted2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsCompleted2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsCompleted2>?(ResponsesServerEvent @this) => @this.ResponseMcpListToolsWsCompleted;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsCompleted2>? value)
        {
            ResponseMcpListToolsWsCompleted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseMcpListToolsWsCompleted(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsCompleted2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsFailed2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsFailed2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsFailed2>?(ResponsesServerEvent @this) => @this.ResponseMcpListToolsWsFailed;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsFailed2>? value)
        {
            ResponseMcpListToolsWsFailed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseMcpListToolsWsFailed(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsFailed2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsInWsProgress2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsInWsProgress2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsInWsProgress2>?(ResponsesServerEvent @this) => @this.ResponseMcpListToolsInWsProgress;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsInWsProgress2>? value)
        {
            ResponseMcpListToolsInWsProgress = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseMcpListToolsInWsProgress(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsInWsProgress2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputTextAnnotationWsAdded2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputTextAnnotationWsAdded2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputTextAnnotationWsAdded2>?(ResponsesServerEvent @this) => @this.ResponseOutputTextAnnotationWsAdded;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputTextAnnotationWsAdded2>? value)
        {
            ResponseOutputTextAnnotationWsAdded = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseOutputTextAnnotationWsAdded(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputTextAnnotationWsAdded2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseQueuedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsQueued2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseQueuedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsQueued2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseQueuedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsQueued2>?(ResponsesServerEvent @this) => @this.ResponseWsQueued;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseQueuedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsQueued2>? value)
        {
            ResponseWsQueued = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseWsQueued(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseQueuedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsQueued2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDelta2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDelta2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDelta2>?(ResponsesServerEvent @this) => @this.ResponseCustomToolCallInputWsDelta;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDelta2>? value)
        {
            ResponseCustomToolCallInputWsDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseCustomToolCallInputWsDelta(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDelta2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDone2> value) => new ResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDone2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDone2>?(ResponsesServerEvent @this) => @this.ResponseCustomToolCallInputWsDone;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDone2>? value)
        {
            ResponseCustomToolCallInputWsDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseCustomToolCallInputWsDone(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDone2>? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.ResponseWsError value) => new ResponsesServerEvent((global::tryAGI.OpenAI.ResponseWsError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseWsError?(ResponsesServerEvent @this) => @this.Error;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.ResponseWsError? value)
        {
            Error = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromError(global::tryAGI.OpenAI.ResponseWsError? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.ResponseSteerAcceptedEvent value) => new ResponsesServerEvent((global::tryAGI.OpenAI.ResponseSteerAcceptedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseSteerAcceptedEvent?(ResponsesServerEvent @this) => @this.ResponseSteerAccepted;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.ResponseSteerAcceptedEvent? value)
        {
            ResponseSteerAccepted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseSteerAccepted(global::tryAGI.OpenAI.ResponseSteerAcceptedEvent? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.ResponseSteerPendingEvent value) => new ResponsesServerEvent((global::tryAGI.OpenAI.ResponseSteerPendingEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseSteerPendingEvent?(ResponsesServerEvent @this) => @this.ResponseSteerPending;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.ResponseSteerPendingEvent? value)
        {
            ResponseSteerPending = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseSteerPending(global::tryAGI.OpenAI.ResponseSteerPendingEvent? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.ResponseSteerFailedEvent value) => new ResponsesServerEvent((global::tryAGI.OpenAI.ResponseSteerFailedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseSteerFailedEvent?(ResponsesServerEvent @this) => @this.ResponseSteerFailed;

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.ResponseSteerFailedEvent? value)
        {
            ResponseSteerFailed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesServerEvent FromResponseSteerFailed(global::tryAGI.OpenAI.ResponseSteerFailedEvent? value) => new ResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public ResponsesServerEvent(
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDelta2>? responseAudioWsDelta,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDone2>? responseAudioWsDone,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDelta2>? responseAudioTranscriptWsDelta,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDone2>? responseAudioTranscriptWsDone,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDelta2>? responseCodeInterpreterCallCodeWsDelta,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDone2>? responseCodeInterpreterCallCodeWsDone,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsCompleted2>? responseCodeInterpreterCallWsCompleted,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallInWsProgress2>? responseCodeInterpreterCallInWsProgress,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsInterpreting2>? responseCodeInterpreterCallWsInterpreting,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCompactionWsCompacting2>? responseCompactionWsCompacting,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCompleted2>? responseWsCompleted,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsAdded2>? responseContentPartWsAdded,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsDone2>? responseContentPartWsDone,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCreatedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCreated2>? responseWsCreated,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsCompleted2>? responseFileSearchCallWsCompleted,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallInWsProgress2>? responseFileSearchCallInWsProgress,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsSearching2>? responseFileSearchCallWsSearching,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDelta2>? responseFunctionCallArgumentsWsDelta,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2>? responseFunctionCallArgumentsWsDone,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsAdded2>? responseShellCallCommandWsAdded,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDelta2>? responseShellCallCommandWsDelta,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDone2>? responseShellCallCommandWsDone,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDelta2>? responseShellCallOutputContentWsDelta,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDone2>? responseShellCallOutputContentWsDone,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseInWsProgress2>? responseInWsProgress,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsFailed2>? responseWsFailed,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseIncompleteEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsIncomplete2>? responseWsIncomplete,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsAdded2>? responseOutputItemWsAdded,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsDone2>? responseOutputItemWsDone,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsAdded2>? responseReasoningSummaryPartWsAdded,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsDone2>? responseReasoningSummaryPartWsDone,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDelta2>? responseReasoningSummaryTextWsDelta,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDone2>? responseReasoningSummaryTextWsDone,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDelta2>? responseReasoningTextWsDelta,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDone2>? responseReasoningTextWsDone,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDelta2>? responseRefusalWsDelta,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDone2>? responseRefusalWsDone,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDelta2>? responseTextWsDelta,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDone2>? responseTextWsDone,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsCompleted2>? responseWebSearchCallWsCompleted,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallInWsProgress2>? responseWebSearchCallInWsProgress,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsSearching2>? responseWebSearchCallWsSearching,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsCompleted2>? responseImageGenCallWsCompleted,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsGenerating2>? responseImageGenCallWsGenerating,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallInWsProgress2>? responseImageGenCallInWsProgress,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2>? responseImageGenCallPartialWsImage,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDelta2>? responseMcpCallArgumentsWsDelta,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDone2>? responseMcpCallArgumentsWsDone,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsCompleted2>? responseMcpCallWsCompleted,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsFailed2>? responseMcpCallWsFailed,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallInWsProgress2>? responseMcpCallInWsProgress,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsCompleted2>? responseMcpListToolsWsCompleted,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsFailed2>? responseMcpListToolsWsFailed,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsInWsProgress2>? responseMcpListToolsInWsProgress,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputTextAnnotationWsAdded2>? responseOutputTextAnnotationWsAdded,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseQueuedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsQueued2>? responseWsQueued,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDelta2>? responseCustomToolCallInputWsDelta,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDone2>? responseCustomToolCallInputWsDone,
            global::tryAGI.OpenAI.ResponseWsError? error,
            global::tryAGI.OpenAI.ResponseSteerAcceptedEvent? responseSteerAccepted,
            global::tryAGI.OpenAI.ResponseSteerPendingEvent? responseSteerPending,
            global::tryAGI.OpenAI.ResponseSteerFailedEvent? responseSteerFailed
            )
        {
            ResponseAudioWsDelta = responseAudioWsDelta;
            ResponseAudioWsDone = responseAudioWsDone;
            ResponseAudioTranscriptWsDelta = responseAudioTranscriptWsDelta;
            ResponseAudioTranscriptWsDone = responseAudioTranscriptWsDone;
            ResponseCodeInterpreterCallCodeWsDelta = responseCodeInterpreterCallCodeWsDelta;
            ResponseCodeInterpreterCallCodeWsDone = responseCodeInterpreterCallCodeWsDone;
            ResponseCodeInterpreterCallWsCompleted = responseCodeInterpreterCallWsCompleted;
            ResponseCodeInterpreterCallInWsProgress = responseCodeInterpreterCallInWsProgress;
            ResponseCodeInterpreterCallWsInterpreting = responseCodeInterpreterCallWsInterpreting;
            ResponseCompactionWsCompacting = responseCompactionWsCompacting;
            ResponseWsCompleted = responseWsCompleted;
            ResponseContentPartWsAdded = responseContentPartWsAdded;
            ResponseContentPartWsDone = responseContentPartWsDone;
            ResponseWsCreated = responseWsCreated;
            ResponseFileSearchCallWsCompleted = responseFileSearchCallWsCompleted;
            ResponseFileSearchCallInWsProgress = responseFileSearchCallInWsProgress;
            ResponseFileSearchCallWsSearching = responseFileSearchCallWsSearching;
            ResponseFunctionCallArgumentsWsDelta = responseFunctionCallArgumentsWsDelta;
            ResponseFunctionCallArgumentsWsDone = responseFunctionCallArgumentsWsDone;
            ResponseShellCallCommandWsAdded = responseShellCallCommandWsAdded;
            ResponseShellCallCommandWsDelta = responseShellCallCommandWsDelta;
            ResponseShellCallCommandWsDone = responseShellCallCommandWsDone;
            ResponseShellCallOutputContentWsDelta = responseShellCallOutputContentWsDelta;
            ResponseShellCallOutputContentWsDone = responseShellCallOutputContentWsDone;
            ResponseInWsProgress = responseInWsProgress;
            ResponseWsFailed = responseWsFailed;
            ResponseWsIncomplete = responseWsIncomplete;
            ResponseOutputItemWsAdded = responseOutputItemWsAdded;
            ResponseOutputItemWsDone = responseOutputItemWsDone;
            ResponseReasoningSummaryPartWsAdded = responseReasoningSummaryPartWsAdded;
            ResponseReasoningSummaryPartWsDone = responseReasoningSummaryPartWsDone;
            ResponseReasoningSummaryTextWsDelta = responseReasoningSummaryTextWsDelta;
            ResponseReasoningSummaryTextWsDone = responseReasoningSummaryTextWsDone;
            ResponseReasoningTextWsDelta = responseReasoningTextWsDelta;
            ResponseReasoningTextWsDone = responseReasoningTextWsDone;
            ResponseRefusalWsDelta = responseRefusalWsDelta;
            ResponseRefusalWsDone = responseRefusalWsDone;
            ResponseTextWsDelta = responseTextWsDelta;
            ResponseTextWsDone = responseTextWsDone;
            ResponseWebSearchCallWsCompleted = responseWebSearchCallWsCompleted;
            ResponseWebSearchCallInWsProgress = responseWebSearchCallInWsProgress;
            ResponseWebSearchCallWsSearching = responseWebSearchCallWsSearching;
            ResponseImageGenCallWsCompleted = responseImageGenCallWsCompleted;
            ResponseImageGenCallWsGenerating = responseImageGenCallWsGenerating;
            ResponseImageGenCallInWsProgress = responseImageGenCallInWsProgress;
            ResponseImageGenCallPartialWsImage = responseImageGenCallPartialWsImage;
            ResponseMcpCallArgumentsWsDelta = responseMcpCallArgumentsWsDelta;
            ResponseMcpCallArgumentsWsDone = responseMcpCallArgumentsWsDone;
            ResponseMcpCallWsCompleted = responseMcpCallWsCompleted;
            ResponseMcpCallWsFailed = responseMcpCallWsFailed;
            ResponseMcpCallInWsProgress = responseMcpCallInWsProgress;
            ResponseMcpListToolsWsCompleted = responseMcpListToolsWsCompleted;
            ResponseMcpListToolsWsFailed = responseMcpListToolsWsFailed;
            ResponseMcpListToolsInWsProgress = responseMcpListToolsInWsProgress;
            ResponseOutputTextAnnotationWsAdded = responseOutputTextAnnotationWsAdded;
            ResponseWsQueued = responseWsQueued;
            ResponseCustomToolCallInputWsDelta = responseCustomToolCallInputWsDelta;
            ResponseCustomToolCallInputWsDone = responseCustomToolCallInputWsDone;
            Error = error;
            ResponseSteerAccepted = responseSteerAccepted;
            ResponseSteerPending = responseSteerPending;
            ResponseSteerFailed = responseSteerFailed;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ResponseSteerFailed as object ??
            ResponseSteerPending as object ??
            ResponseSteerAccepted as object ??
            Error as object ??
            ResponseCustomToolCallInputWsDone as object ??
            ResponseCustomToolCallInputWsDelta as object ??
            ResponseWsQueued as object ??
            ResponseOutputTextAnnotationWsAdded as object ??
            ResponseMcpListToolsInWsProgress as object ??
            ResponseMcpListToolsWsFailed as object ??
            ResponseMcpListToolsWsCompleted as object ??
            ResponseMcpCallInWsProgress as object ??
            ResponseMcpCallWsFailed as object ??
            ResponseMcpCallWsCompleted as object ??
            ResponseMcpCallArgumentsWsDone as object ??
            ResponseMcpCallArgumentsWsDelta as object ??
            ResponseImageGenCallPartialWsImage as object ??
            ResponseImageGenCallInWsProgress as object ??
            ResponseImageGenCallWsGenerating as object ??
            ResponseImageGenCallWsCompleted as object ??
            ResponseWebSearchCallWsSearching as object ??
            ResponseWebSearchCallInWsProgress as object ??
            ResponseWebSearchCallWsCompleted as object ??
            ResponseTextWsDone as object ??
            ResponseTextWsDelta as object ??
            ResponseRefusalWsDone as object ??
            ResponseRefusalWsDelta as object ??
            ResponseReasoningTextWsDone as object ??
            ResponseReasoningTextWsDelta as object ??
            ResponseReasoningSummaryTextWsDone as object ??
            ResponseReasoningSummaryTextWsDelta as object ??
            ResponseReasoningSummaryPartWsDone as object ??
            ResponseReasoningSummaryPartWsAdded as object ??
            ResponseOutputItemWsDone as object ??
            ResponseOutputItemWsAdded as object ??
            ResponseWsIncomplete as object ??
            ResponseWsFailed as object ??
            ResponseInWsProgress as object ??
            ResponseShellCallOutputContentWsDone as object ??
            ResponseShellCallOutputContentWsDelta as object ??
            ResponseShellCallCommandWsDone as object ??
            ResponseShellCallCommandWsDelta as object ??
            ResponseShellCallCommandWsAdded as object ??
            ResponseFunctionCallArgumentsWsDone as object ??
            ResponseFunctionCallArgumentsWsDelta as object ??
            ResponseFileSearchCallWsSearching as object ??
            ResponseFileSearchCallInWsProgress as object ??
            ResponseFileSearchCallWsCompleted as object ??
            ResponseWsCreated as object ??
            ResponseContentPartWsDone as object ??
            ResponseContentPartWsAdded as object ??
            ResponseWsCompleted as object ??
            ResponseCompactionWsCompacting as object ??
            ResponseCodeInterpreterCallWsInterpreting as object ??
            ResponseCodeInterpreterCallInWsProgress as object ??
            ResponseCodeInterpreterCallWsCompleted as object ??
            ResponseCodeInterpreterCallCodeWsDone as object ??
            ResponseCodeInterpreterCallCodeWsDelta as object ??
            ResponseAudioTranscriptWsDone as object ??
            ResponseAudioTranscriptWsDelta as object ??
            ResponseAudioWsDone as object ??
            ResponseAudioWsDelta as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ResponseAudioWsDelta?.ToString() ??
            ResponseAudioWsDone?.ToString() ??
            ResponseAudioTranscriptWsDelta?.ToString() ??
            ResponseAudioTranscriptWsDone?.ToString() ??
            ResponseCodeInterpreterCallCodeWsDelta?.ToString() ??
            ResponseCodeInterpreterCallCodeWsDone?.ToString() ??
            ResponseCodeInterpreterCallWsCompleted?.ToString() ??
            ResponseCodeInterpreterCallInWsProgress?.ToString() ??
            ResponseCodeInterpreterCallWsInterpreting?.ToString() ??
            ResponseCompactionWsCompacting?.ToString() ??
            ResponseWsCompleted?.ToString() ??
            ResponseContentPartWsAdded?.ToString() ??
            ResponseContentPartWsDone?.ToString() ??
            ResponseWsCreated?.ToString() ??
            ResponseFileSearchCallWsCompleted?.ToString() ??
            ResponseFileSearchCallInWsProgress?.ToString() ??
            ResponseFileSearchCallWsSearching?.ToString() ??
            ResponseFunctionCallArgumentsWsDelta?.ToString() ??
            ResponseFunctionCallArgumentsWsDone?.ToString() ??
            ResponseShellCallCommandWsAdded?.ToString() ??
            ResponseShellCallCommandWsDelta?.ToString() ??
            ResponseShellCallCommandWsDone?.ToString() ??
            ResponseShellCallOutputContentWsDelta?.ToString() ??
            ResponseShellCallOutputContentWsDone?.ToString() ??
            ResponseInWsProgress?.ToString() ??
            ResponseWsFailed?.ToString() ??
            ResponseWsIncomplete?.ToString() ??
            ResponseOutputItemWsAdded?.ToString() ??
            ResponseOutputItemWsDone?.ToString() ??
            ResponseReasoningSummaryPartWsAdded?.ToString() ??
            ResponseReasoningSummaryPartWsDone?.ToString() ??
            ResponseReasoningSummaryTextWsDelta?.ToString() ??
            ResponseReasoningSummaryTextWsDone?.ToString() ??
            ResponseReasoningTextWsDelta?.ToString() ??
            ResponseReasoningTextWsDone?.ToString() ??
            ResponseRefusalWsDelta?.ToString() ??
            ResponseRefusalWsDone?.ToString() ??
            ResponseTextWsDelta?.ToString() ??
            ResponseTextWsDone?.ToString() ??
            ResponseWebSearchCallWsCompleted?.ToString() ??
            ResponseWebSearchCallInWsProgress?.ToString() ??
            ResponseWebSearchCallWsSearching?.ToString() ??
            ResponseImageGenCallWsCompleted?.ToString() ??
            ResponseImageGenCallWsGenerating?.ToString() ??
            ResponseImageGenCallInWsProgress?.ToString() ??
            ResponseImageGenCallPartialWsImage?.ToString() ??
            ResponseMcpCallArgumentsWsDelta?.ToString() ??
            ResponseMcpCallArgumentsWsDone?.ToString() ??
            ResponseMcpCallWsCompleted?.ToString() ??
            ResponseMcpCallWsFailed?.ToString() ??
            ResponseMcpCallInWsProgress?.ToString() ??
            ResponseMcpListToolsWsCompleted?.ToString() ??
            ResponseMcpListToolsWsFailed?.ToString() ??
            ResponseMcpListToolsInWsProgress?.ToString() ??
            ResponseOutputTextAnnotationWsAdded?.ToString() ??
            ResponseWsQueued?.ToString() ??
            ResponseCustomToolCallInputWsDelta?.ToString() ??
            ResponseCustomToolCallInputWsDone?.ToString() ??
            Error?.ToString() ??
            ResponseSteerAccepted?.ToString() ??
            ResponseSteerPending?.ToString() ??
            ResponseSteerFailed?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsResponseAudioWsDelta || IsResponseAudioWsDone || IsResponseAudioTranscriptWsDelta || IsResponseAudioTranscriptWsDone || IsResponseCodeInterpreterCallCodeWsDelta || IsResponseCodeInterpreterCallCodeWsDone || IsResponseCodeInterpreterCallWsCompleted || IsResponseCodeInterpreterCallInWsProgress || IsResponseCodeInterpreterCallWsInterpreting || IsResponseCompactionWsCompacting || IsResponseWsCompleted || IsResponseContentPartWsAdded || IsResponseContentPartWsDone || IsResponseWsCreated || IsResponseFileSearchCallWsCompleted || IsResponseFileSearchCallInWsProgress || IsResponseFileSearchCallWsSearching || IsResponseFunctionCallArgumentsWsDelta || IsResponseFunctionCallArgumentsWsDone || IsResponseShellCallCommandWsAdded || IsResponseShellCallCommandWsDelta || IsResponseShellCallCommandWsDone || IsResponseShellCallOutputContentWsDelta || IsResponseShellCallOutputContentWsDone || IsResponseInWsProgress || IsResponseWsFailed || IsResponseWsIncomplete || IsResponseOutputItemWsAdded || IsResponseOutputItemWsDone || IsResponseReasoningSummaryPartWsAdded || IsResponseReasoningSummaryPartWsDone || IsResponseReasoningSummaryTextWsDelta || IsResponseReasoningSummaryTextWsDone || IsResponseReasoningTextWsDelta || IsResponseReasoningTextWsDone || IsResponseRefusalWsDelta || IsResponseRefusalWsDone || IsResponseTextWsDelta || IsResponseTextWsDone || IsResponseWebSearchCallWsCompleted || IsResponseWebSearchCallInWsProgress || IsResponseWebSearchCallWsSearching || IsResponseImageGenCallWsCompleted || IsResponseImageGenCallWsGenerating || IsResponseImageGenCallInWsProgress || IsResponseImageGenCallPartialWsImage || IsResponseMcpCallArgumentsWsDelta || IsResponseMcpCallArgumentsWsDone || IsResponseMcpCallWsCompleted || IsResponseMcpCallWsFailed || IsResponseMcpCallInWsProgress || IsResponseMcpListToolsWsCompleted || IsResponseMcpListToolsWsFailed || IsResponseMcpListToolsInWsProgress || IsResponseOutputTextAnnotationWsAdded || IsResponseWsQueued || IsResponseCustomToolCallInputWsDelta || IsResponseCustomToolCallInputWsDone || IsError || IsResponseSteerAccepted || IsResponseSteerPending || IsResponseSteerFailed;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDelta2>?, TResult>? responseAudioWsDelta = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDone2>?, TResult>? responseAudioWsDone = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDelta2>?, TResult>? responseAudioTranscriptWsDelta = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDone2>?, TResult>? responseAudioTranscriptWsDone = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDelta2>?, TResult>? responseCodeInterpreterCallCodeWsDelta = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDone2>?, TResult>? responseCodeInterpreterCallCodeWsDone = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsCompleted2>?, TResult>? responseCodeInterpreterCallWsCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallInWsProgress2>?, TResult>? responseCodeInterpreterCallInWsProgress = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsInterpreting2>?, TResult>? responseCodeInterpreterCallWsInterpreting = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCompactionWsCompacting2>?, TResult>? responseCompactionWsCompacting = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCompleted2>?, TResult>? responseWsCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsAdded2>?, TResult>? responseContentPartWsAdded = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsDone2>?, TResult>? responseContentPartWsDone = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCreatedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCreated2>?, TResult>? responseWsCreated = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsCompleted2>?, TResult>? responseFileSearchCallWsCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallInWsProgress2>?, TResult>? responseFileSearchCallInWsProgress = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsSearching2>?, TResult>? responseFileSearchCallWsSearching = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDelta2>?, TResult>? responseFunctionCallArgumentsWsDelta = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2>?, TResult>? responseFunctionCallArgumentsWsDone = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsAdded2>?, TResult>? responseShellCallCommandWsAdded = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDelta2>?, TResult>? responseShellCallCommandWsDelta = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDone2>?, TResult>? responseShellCallCommandWsDone = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDelta2>?, TResult>? responseShellCallOutputContentWsDelta = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDone2>?, TResult>? responseShellCallOutputContentWsDone = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseInWsProgress2>?, TResult>? responseInWsProgress = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsFailed2>?, TResult>? responseWsFailed = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseIncompleteEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsIncomplete2>?, TResult>? responseWsIncomplete = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsAdded2>?, TResult>? responseOutputItemWsAdded = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsDone2>?, TResult>? responseOutputItemWsDone = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsAdded2>?, TResult>? responseReasoningSummaryPartWsAdded = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsDone2>?, TResult>? responseReasoningSummaryPartWsDone = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDelta2>?, TResult>? responseReasoningSummaryTextWsDelta = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDone2>?, TResult>? responseReasoningSummaryTextWsDone = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDelta2>?, TResult>? responseReasoningTextWsDelta = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDone2>?, TResult>? responseReasoningTextWsDone = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDelta2>?, TResult>? responseRefusalWsDelta = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDone2>?, TResult>? responseRefusalWsDone = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDelta2>?, TResult>? responseTextWsDelta = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDone2>?, TResult>? responseTextWsDone = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsCompleted2>?, TResult>? responseWebSearchCallWsCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallInWsProgress2>?, TResult>? responseWebSearchCallInWsProgress = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsSearching2>?, TResult>? responseWebSearchCallWsSearching = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsCompleted2>?, TResult>? responseImageGenCallWsCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsGenerating2>?, TResult>? responseImageGenCallWsGenerating = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallInWsProgress2>?, TResult>? responseImageGenCallInWsProgress = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2>?, TResult>? responseImageGenCallPartialWsImage = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDelta2>?, TResult>? responseMcpCallArgumentsWsDelta = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDone2>?, TResult>? responseMcpCallArgumentsWsDone = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsCompleted2>?, TResult>? responseMcpCallWsCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsFailed2>?, TResult>? responseMcpCallWsFailed = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallInWsProgress2>?, TResult>? responseMcpCallInWsProgress = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsCompleted2>?, TResult>? responseMcpListToolsWsCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsFailed2>?, TResult>? responseMcpListToolsWsFailed = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsInWsProgress2>?, TResult>? responseMcpListToolsInWsProgress = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputTextAnnotationWsAdded2>?, TResult>? responseOutputTextAnnotationWsAdded = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseQueuedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsQueued2>?, TResult>? responseWsQueued = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDelta2>?, TResult>? responseCustomToolCallInputWsDelta = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDone2>?, TResult>? responseCustomToolCallInputWsDone = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseWsError, TResult>? error = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseSteerAcceptedEvent, TResult>? responseSteerAccepted = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseSteerPendingEvent, TResult>? responseSteerPending = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseSteerFailedEvent, TResult>? responseSteerFailed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ResponseAudioWsDelta is { } __value0 && responseAudioWsDelta != null)
            {
                return responseAudioWsDelta(__value0);
            }
            else if (ResponseAudioWsDone is { } __value1 && responseAudioWsDone != null)
            {
                return responseAudioWsDone(__value1);
            }
            else if (ResponseAudioTranscriptWsDelta is { } __value2 && responseAudioTranscriptWsDelta != null)
            {
                return responseAudioTranscriptWsDelta(__value2);
            }
            else if (ResponseAudioTranscriptWsDone is { } __value3 && responseAudioTranscriptWsDone != null)
            {
                return responseAudioTranscriptWsDone(__value3);
            }
            else if (ResponseCodeInterpreterCallCodeWsDelta is { } __value4 && responseCodeInterpreterCallCodeWsDelta != null)
            {
                return responseCodeInterpreterCallCodeWsDelta(__value4);
            }
            else if (ResponseCodeInterpreterCallCodeWsDone is { } __value5 && responseCodeInterpreterCallCodeWsDone != null)
            {
                return responseCodeInterpreterCallCodeWsDone(__value5);
            }
            else if (ResponseCodeInterpreterCallWsCompleted is { } __value6 && responseCodeInterpreterCallWsCompleted != null)
            {
                return responseCodeInterpreterCallWsCompleted(__value6);
            }
            else if (ResponseCodeInterpreterCallInWsProgress is { } __value7 && responseCodeInterpreterCallInWsProgress != null)
            {
                return responseCodeInterpreterCallInWsProgress(__value7);
            }
            else if (ResponseCodeInterpreterCallWsInterpreting is { } __value8 && responseCodeInterpreterCallWsInterpreting != null)
            {
                return responseCodeInterpreterCallWsInterpreting(__value8);
            }
            else if (ResponseCompactionWsCompacting is { } __value9 && responseCompactionWsCompacting != null)
            {
                return responseCompactionWsCompacting(__value9);
            }
            else if (ResponseWsCompleted is { } __value10 && responseWsCompleted != null)
            {
                return responseWsCompleted(__value10);
            }
            else if (ResponseContentPartWsAdded is { } __value11 && responseContentPartWsAdded != null)
            {
                return responseContentPartWsAdded(__value11);
            }
            else if (ResponseContentPartWsDone is { } __value12 && responseContentPartWsDone != null)
            {
                return responseContentPartWsDone(__value12);
            }
            else if (ResponseWsCreated is { } __value13 && responseWsCreated != null)
            {
                return responseWsCreated(__value13);
            }
            else if (ResponseFileSearchCallWsCompleted is { } __value14 && responseFileSearchCallWsCompleted != null)
            {
                return responseFileSearchCallWsCompleted(__value14);
            }
            else if (ResponseFileSearchCallInWsProgress is { } __value15 && responseFileSearchCallInWsProgress != null)
            {
                return responseFileSearchCallInWsProgress(__value15);
            }
            else if (ResponseFileSearchCallWsSearching is { } __value16 && responseFileSearchCallWsSearching != null)
            {
                return responseFileSearchCallWsSearching(__value16);
            }
            else if (ResponseFunctionCallArgumentsWsDelta is { } __value17 && responseFunctionCallArgumentsWsDelta != null)
            {
                return responseFunctionCallArgumentsWsDelta(__value17);
            }
            else if (ResponseFunctionCallArgumentsWsDone is { } __value18 && responseFunctionCallArgumentsWsDone != null)
            {
                return responseFunctionCallArgumentsWsDone(__value18);
            }
            else if (ResponseShellCallCommandWsAdded is { } __value19 && responseShellCallCommandWsAdded != null)
            {
                return responseShellCallCommandWsAdded(__value19);
            }
            else if (ResponseShellCallCommandWsDelta is { } __value20 && responseShellCallCommandWsDelta != null)
            {
                return responseShellCallCommandWsDelta(__value20);
            }
            else if (ResponseShellCallCommandWsDone is { } __value21 && responseShellCallCommandWsDone != null)
            {
                return responseShellCallCommandWsDone(__value21);
            }
            else if (ResponseShellCallOutputContentWsDelta is { } __value22 && responseShellCallOutputContentWsDelta != null)
            {
                return responseShellCallOutputContentWsDelta(__value22);
            }
            else if (ResponseShellCallOutputContentWsDone is { } __value23 && responseShellCallOutputContentWsDone != null)
            {
                return responseShellCallOutputContentWsDone(__value23);
            }
            else if (ResponseInWsProgress is { } __value24 && responseInWsProgress != null)
            {
                return responseInWsProgress(__value24);
            }
            else if (ResponseWsFailed is { } __value25 && responseWsFailed != null)
            {
                return responseWsFailed(__value25);
            }
            else if (ResponseWsIncomplete is { } __value26 && responseWsIncomplete != null)
            {
                return responseWsIncomplete(__value26);
            }
            else if (ResponseOutputItemWsAdded is { } __value27 && responseOutputItemWsAdded != null)
            {
                return responseOutputItemWsAdded(__value27);
            }
            else if (ResponseOutputItemWsDone is { } __value28 && responseOutputItemWsDone != null)
            {
                return responseOutputItemWsDone(__value28);
            }
            else if (ResponseReasoningSummaryPartWsAdded is { } __value29 && responseReasoningSummaryPartWsAdded != null)
            {
                return responseReasoningSummaryPartWsAdded(__value29);
            }
            else if (ResponseReasoningSummaryPartWsDone is { } __value30 && responseReasoningSummaryPartWsDone != null)
            {
                return responseReasoningSummaryPartWsDone(__value30);
            }
            else if (ResponseReasoningSummaryTextWsDelta is { } __value31 && responseReasoningSummaryTextWsDelta != null)
            {
                return responseReasoningSummaryTextWsDelta(__value31);
            }
            else if (ResponseReasoningSummaryTextWsDone is { } __value32 && responseReasoningSummaryTextWsDone != null)
            {
                return responseReasoningSummaryTextWsDone(__value32);
            }
            else if (ResponseReasoningTextWsDelta is { } __value33 && responseReasoningTextWsDelta != null)
            {
                return responseReasoningTextWsDelta(__value33);
            }
            else if (ResponseReasoningTextWsDone is { } __value34 && responseReasoningTextWsDone != null)
            {
                return responseReasoningTextWsDone(__value34);
            }
            else if (ResponseRefusalWsDelta is { } __value35 && responseRefusalWsDelta != null)
            {
                return responseRefusalWsDelta(__value35);
            }
            else if (ResponseRefusalWsDone is { } __value36 && responseRefusalWsDone != null)
            {
                return responseRefusalWsDone(__value36);
            }
            else if (ResponseTextWsDelta is { } __value37 && responseTextWsDelta != null)
            {
                return responseTextWsDelta(__value37);
            }
            else if (ResponseTextWsDone is { } __value38 && responseTextWsDone != null)
            {
                return responseTextWsDone(__value38);
            }
            else if (ResponseWebSearchCallWsCompleted is { } __value39 && responseWebSearchCallWsCompleted != null)
            {
                return responseWebSearchCallWsCompleted(__value39);
            }
            else if (ResponseWebSearchCallInWsProgress is { } __value40 && responseWebSearchCallInWsProgress != null)
            {
                return responseWebSearchCallInWsProgress(__value40);
            }
            else if (ResponseWebSearchCallWsSearching is { } __value41 && responseWebSearchCallWsSearching != null)
            {
                return responseWebSearchCallWsSearching(__value41);
            }
            else if (ResponseImageGenCallWsCompleted is { } __value42 && responseImageGenCallWsCompleted != null)
            {
                return responseImageGenCallWsCompleted(__value42);
            }
            else if (ResponseImageGenCallWsGenerating is { } __value43 && responseImageGenCallWsGenerating != null)
            {
                return responseImageGenCallWsGenerating(__value43);
            }
            else if (ResponseImageGenCallInWsProgress is { } __value44 && responseImageGenCallInWsProgress != null)
            {
                return responseImageGenCallInWsProgress(__value44);
            }
            else if (ResponseImageGenCallPartialWsImage is { } __value45 && responseImageGenCallPartialWsImage != null)
            {
                return responseImageGenCallPartialWsImage(__value45);
            }
            else if (ResponseMcpCallArgumentsWsDelta is { } __value46 && responseMcpCallArgumentsWsDelta != null)
            {
                return responseMcpCallArgumentsWsDelta(__value46);
            }
            else if (ResponseMcpCallArgumentsWsDone is { } __value47 && responseMcpCallArgumentsWsDone != null)
            {
                return responseMcpCallArgumentsWsDone(__value47);
            }
            else if (ResponseMcpCallWsCompleted is { } __value48 && responseMcpCallWsCompleted != null)
            {
                return responseMcpCallWsCompleted(__value48);
            }
            else if (ResponseMcpCallWsFailed is { } __value49 && responseMcpCallWsFailed != null)
            {
                return responseMcpCallWsFailed(__value49);
            }
            else if (ResponseMcpCallInWsProgress is { } __value50 && responseMcpCallInWsProgress != null)
            {
                return responseMcpCallInWsProgress(__value50);
            }
            else if (ResponseMcpListToolsWsCompleted is { } __value51 && responseMcpListToolsWsCompleted != null)
            {
                return responseMcpListToolsWsCompleted(__value51);
            }
            else if (ResponseMcpListToolsWsFailed is { } __value52 && responseMcpListToolsWsFailed != null)
            {
                return responseMcpListToolsWsFailed(__value52);
            }
            else if (ResponseMcpListToolsInWsProgress is { } __value53 && responseMcpListToolsInWsProgress != null)
            {
                return responseMcpListToolsInWsProgress(__value53);
            }
            else if (ResponseOutputTextAnnotationWsAdded is { } __value54 && responseOutputTextAnnotationWsAdded != null)
            {
                return responseOutputTextAnnotationWsAdded(__value54);
            }
            else if (ResponseWsQueued is { } __value55 && responseWsQueued != null)
            {
                return responseWsQueued(__value55);
            }
            else if (ResponseCustomToolCallInputWsDelta is { } __value56 && responseCustomToolCallInputWsDelta != null)
            {
                return responseCustomToolCallInputWsDelta(__value56);
            }
            else if (ResponseCustomToolCallInputWsDone is { } __value57 && responseCustomToolCallInputWsDone != null)
            {
                return responseCustomToolCallInputWsDone(__value57);
            }
            else if (Error is { } __value58 && error != null)
            {
                return error(__value58);
            }
            else if (ResponseSteerAccepted is { } __value59 && responseSteerAccepted != null)
            {
                return responseSteerAccepted(__value59);
            }
            else if (ResponseSteerPending is { } __value60 && responseSteerPending != null)
            {
                return responseSteerPending(__value60);
            }
            else if (ResponseSteerFailed is { } __value61 && responseSteerFailed != null)
            {
                return responseSteerFailed(__value61);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDelta2>?>? responseAudioWsDelta = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDone2>?>? responseAudioWsDone = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDelta2>?>? responseAudioTranscriptWsDelta = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDone2>?>? responseAudioTranscriptWsDone = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDelta2>?>? responseCodeInterpreterCallCodeWsDelta = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDone2>?>? responseCodeInterpreterCallCodeWsDone = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsCompleted2>?>? responseCodeInterpreterCallWsCompleted = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallInWsProgress2>?>? responseCodeInterpreterCallInWsProgress = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsInterpreting2>?>? responseCodeInterpreterCallWsInterpreting = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCompactionWsCompacting2>?>? responseCompactionWsCompacting = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCompleted2>?>? responseWsCompleted = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsAdded2>?>? responseContentPartWsAdded = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsDone2>?>? responseContentPartWsDone = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCreatedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCreated2>?>? responseWsCreated = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsCompleted2>?>? responseFileSearchCallWsCompleted = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallInWsProgress2>?>? responseFileSearchCallInWsProgress = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsSearching2>?>? responseFileSearchCallWsSearching = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDelta2>?>? responseFunctionCallArgumentsWsDelta = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2>?>? responseFunctionCallArgumentsWsDone = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsAdded2>?>? responseShellCallCommandWsAdded = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDelta2>?>? responseShellCallCommandWsDelta = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDone2>?>? responseShellCallCommandWsDone = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDelta2>?>? responseShellCallOutputContentWsDelta = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDone2>?>? responseShellCallOutputContentWsDone = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseInWsProgress2>?>? responseInWsProgress = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsFailed2>?>? responseWsFailed = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseIncompleteEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsIncomplete2>?>? responseWsIncomplete = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsAdded2>?>? responseOutputItemWsAdded = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsDone2>?>? responseOutputItemWsDone = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsAdded2>?>? responseReasoningSummaryPartWsAdded = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsDone2>?>? responseReasoningSummaryPartWsDone = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDelta2>?>? responseReasoningSummaryTextWsDelta = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDone2>?>? responseReasoningSummaryTextWsDone = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDelta2>?>? responseReasoningTextWsDelta = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDone2>?>? responseReasoningTextWsDone = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDelta2>?>? responseRefusalWsDelta = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDone2>?>? responseRefusalWsDone = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDelta2>?>? responseTextWsDelta = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDone2>?>? responseTextWsDone = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsCompleted2>?>? responseWebSearchCallWsCompleted = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallInWsProgress2>?>? responseWebSearchCallInWsProgress = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsSearching2>?>? responseWebSearchCallWsSearching = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsCompleted2>?>? responseImageGenCallWsCompleted = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsGenerating2>?>? responseImageGenCallWsGenerating = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallInWsProgress2>?>? responseImageGenCallInWsProgress = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2>?>? responseImageGenCallPartialWsImage = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDelta2>?>? responseMcpCallArgumentsWsDelta = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDone2>?>? responseMcpCallArgumentsWsDone = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsCompleted2>?>? responseMcpCallWsCompleted = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsFailed2>?>? responseMcpCallWsFailed = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallInWsProgress2>?>? responseMcpCallInWsProgress = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsCompleted2>?>? responseMcpListToolsWsCompleted = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsFailed2>?>? responseMcpListToolsWsFailed = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsInWsProgress2>?>? responseMcpListToolsInWsProgress = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputTextAnnotationWsAdded2>?>? responseOutputTextAnnotationWsAdded = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseQueuedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsQueued2>?>? responseWsQueued = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDelta2>?>? responseCustomToolCallInputWsDelta = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDone2>?>? responseCustomToolCallInputWsDone = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseWsError>? error = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseSteerAcceptedEvent>? responseSteerAccepted = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseSteerPendingEvent>? responseSteerPending = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseSteerFailedEvent>? responseSteerFailed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ResponseAudioWsDelta is { } __value0)
            {
                responseAudioWsDelta?.Invoke(__value0);
            }
            else if (ResponseAudioWsDone is { } __value1)
            {
                responseAudioWsDone?.Invoke(__value1);
            }
            else if (ResponseAudioTranscriptWsDelta is { } __value2)
            {
                responseAudioTranscriptWsDelta?.Invoke(__value2);
            }
            else if (ResponseAudioTranscriptWsDone is { } __value3)
            {
                responseAudioTranscriptWsDone?.Invoke(__value3);
            }
            else if (ResponseCodeInterpreterCallCodeWsDelta is { } __value4)
            {
                responseCodeInterpreterCallCodeWsDelta?.Invoke(__value4);
            }
            else if (ResponseCodeInterpreterCallCodeWsDone is { } __value5)
            {
                responseCodeInterpreterCallCodeWsDone?.Invoke(__value5);
            }
            else if (ResponseCodeInterpreterCallWsCompleted is { } __value6)
            {
                responseCodeInterpreterCallWsCompleted?.Invoke(__value6);
            }
            else if (ResponseCodeInterpreterCallInWsProgress is { } __value7)
            {
                responseCodeInterpreterCallInWsProgress?.Invoke(__value7);
            }
            else if (ResponseCodeInterpreterCallWsInterpreting is { } __value8)
            {
                responseCodeInterpreterCallWsInterpreting?.Invoke(__value8);
            }
            else if (ResponseCompactionWsCompacting is { } __value9)
            {
                responseCompactionWsCompacting?.Invoke(__value9);
            }
            else if (ResponseWsCompleted is { } __value10)
            {
                responseWsCompleted?.Invoke(__value10);
            }
            else if (ResponseContentPartWsAdded is { } __value11)
            {
                responseContentPartWsAdded?.Invoke(__value11);
            }
            else if (ResponseContentPartWsDone is { } __value12)
            {
                responseContentPartWsDone?.Invoke(__value12);
            }
            else if (ResponseWsCreated is { } __value13)
            {
                responseWsCreated?.Invoke(__value13);
            }
            else if (ResponseFileSearchCallWsCompleted is { } __value14)
            {
                responseFileSearchCallWsCompleted?.Invoke(__value14);
            }
            else if (ResponseFileSearchCallInWsProgress is { } __value15)
            {
                responseFileSearchCallInWsProgress?.Invoke(__value15);
            }
            else if (ResponseFileSearchCallWsSearching is { } __value16)
            {
                responseFileSearchCallWsSearching?.Invoke(__value16);
            }
            else if (ResponseFunctionCallArgumentsWsDelta is { } __value17)
            {
                responseFunctionCallArgumentsWsDelta?.Invoke(__value17);
            }
            else if (ResponseFunctionCallArgumentsWsDone is { } __value18)
            {
                responseFunctionCallArgumentsWsDone?.Invoke(__value18);
            }
            else if (ResponseShellCallCommandWsAdded is { } __value19)
            {
                responseShellCallCommandWsAdded?.Invoke(__value19);
            }
            else if (ResponseShellCallCommandWsDelta is { } __value20)
            {
                responseShellCallCommandWsDelta?.Invoke(__value20);
            }
            else if (ResponseShellCallCommandWsDone is { } __value21)
            {
                responseShellCallCommandWsDone?.Invoke(__value21);
            }
            else if (ResponseShellCallOutputContentWsDelta is { } __value22)
            {
                responseShellCallOutputContentWsDelta?.Invoke(__value22);
            }
            else if (ResponseShellCallOutputContentWsDone is { } __value23)
            {
                responseShellCallOutputContentWsDone?.Invoke(__value23);
            }
            else if (ResponseInWsProgress is { } __value24)
            {
                responseInWsProgress?.Invoke(__value24);
            }
            else if (ResponseWsFailed is { } __value25)
            {
                responseWsFailed?.Invoke(__value25);
            }
            else if (ResponseWsIncomplete is { } __value26)
            {
                responseWsIncomplete?.Invoke(__value26);
            }
            else if (ResponseOutputItemWsAdded is { } __value27)
            {
                responseOutputItemWsAdded?.Invoke(__value27);
            }
            else if (ResponseOutputItemWsDone is { } __value28)
            {
                responseOutputItemWsDone?.Invoke(__value28);
            }
            else if (ResponseReasoningSummaryPartWsAdded is { } __value29)
            {
                responseReasoningSummaryPartWsAdded?.Invoke(__value29);
            }
            else if (ResponseReasoningSummaryPartWsDone is { } __value30)
            {
                responseReasoningSummaryPartWsDone?.Invoke(__value30);
            }
            else if (ResponseReasoningSummaryTextWsDelta is { } __value31)
            {
                responseReasoningSummaryTextWsDelta?.Invoke(__value31);
            }
            else if (ResponseReasoningSummaryTextWsDone is { } __value32)
            {
                responseReasoningSummaryTextWsDone?.Invoke(__value32);
            }
            else if (ResponseReasoningTextWsDelta is { } __value33)
            {
                responseReasoningTextWsDelta?.Invoke(__value33);
            }
            else if (ResponseReasoningTextWsDone is { } __value34)
            {
                responseReasoningTextWsDone?.Invoke(__value34);
            }
            else if (ResponseRefusalWsDelta is { } __value35)
            {
                responseRefusalWsDelta?.Invoke(__value35);
            }
            else if (ResponseRefusalWsDone is { } __value36)
            {
                responseRefusalWsDone?.Invoke(__value36);
            }
            else if (ResponseTextWsDelta is { } __value37)
            {
                responseTextWsDelta?.Invoke(__value37);
            }
            else if (ResponseTextWsDone is { } __value38)
            {
                responseTextWsDone?.Invoke(__value38);
            }
            else if (ResponseWebSearchCallWsCompleted is { } __value39)
            {
                responseWebSearchCallWsCompleted?.Invoke(__value39);
            }
            else if (ResponseWebSearchCallInWsProgress is { } __value40)
            {
                responseWebSearchCallInWsProgress?.Invoke(__value40);
            }
            else if (ResponseWebSearchCallWsSearching is { } __value41)
            {
                responseWebSearchCallWsSearching?.Invoke(__value41);
            }
            else if (ResponseImageGenCallWsCompleted is { } __value42)
            {
                responseImageGenCallWsCompleted?.Invoke(__value42);
            }
            else if (ResponseImageGenCallWsGenerating is { } __value43)
            {
                responseImageGenCallWsGenerating?.Invoke(__value43);
            }
            else if (ResponseImageGenCallInWsProgress is { } __value44)
            {
                responseImageGenCallInWsProgress?.Invoke(__value44);
            }
            else if (ResponseImageGenCallPartialWsImage is { } __value45)
            {
                responseImageGenCallPartialWsImage?.Invoke(__value45);
            }
            else if (ResponseMcpCallArgumentsWsDelta is { } __value46)
            {
                responseMcpCallArgumentsWsDelta?.Invoke(__value46);
            }
            else if (ResponseMcpCallArgumentsWsDone is { } __value47)
            {
                responseMcpCallArgumentsWsDone?.Invoke(__value47);
            }
            else if (ResponseMcpCallWsCompleted is { } __value48)
            {
                responseMcpCallWsCompleted?.Invoke(__value48);
            }
            else if (ResponseMcpCallWsFailed is { } __value49)
            {
                responseMcpCallWsFailed?.Invoke(__value49);
            }
            else if (ResponseMcpCallInWsProgress is { } __value50)
            {
                responseMcpCallInWsProgress?.Invoke(__value50);
            }
            else if (ResponseMcpListToolsWsCompleted is { } __value51)
            {
                responseMcpListToolsWsCompleted?.Invoke(__value51);
            }
            else if (ResponseMcpListToolsWsFailed is { } __value52)
            {
                responseMcpListToolsWsFailed?.Invoke(__value52);
            }
            else if (ResponseMcpListToolsInWsProgress is { } __value53)
            {
                responseMcpListToolsInWsProgress?.Invoke(__value53);
            }
            else if (ResponseOutputTextAnnotationWsAdded is { } __value54)
            {
                responseOutputTextAnnotationWsAdded?.Invoke(__value54);
            }
            else if (ResponseWsQueued is { } __value55)
            {
                responseWsQueued?.Invoke(__value55);
            }
            else if (ResponseCustomToolCallInputWsDelta is { } __value56)
            {
                responseCustomToolCallInputWsDelta?.Invoke(__value56);
            }
            else if (ResponseCustomToolCallInputWsDone is { } __value57)
            {
                responseCustomToolCallInputWsDone?.Invoke(__value57);
            }
            else if (Error is { } __value58)
            {
                error?.Invoke(__value58);
            }
            else if (ResponseSteerAccepted is { } __value59)
            {
                responseSteerAccepted?.Invoke(__value59);
            }
            else if (ResponseSteerPending is { } __value60)
            {
                responseSteerPending?.Invoke(__value60);
            }
            else if (ResponseSteerFailed is { } __value61)
            {
                responseSteerFailed?.Invoke(__value61);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDelta2>?>? responseAudioWsDelta = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDone2>?>? responseAudioWsDone = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDelta2>?>? responseAudioTranscriptWsDelta = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDone2>?>? responseAudioTranscriptWsDone = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDelta2>?>? responseCodeInterpreterCallCodeWsDelta = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDone2>?>? responseCodeInterpreterCallCodeWsDone = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsCompleted2>?>? responseCodeInterpreterCallWsCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallInWsProgress2>?>? responseCodeInterpreterCallInWsProgress = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsInterpreting2>?>? responseCodeInterpreterCallWsInterpreting = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCompactionWsCompacting2>?>? responseCompactionWsCompacting = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCompleted2>?>? responseWsCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsAdded2>?>? responseContentPartWsAdded = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsDone2>?>? responseContentPartWsDone = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCreatedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCreated2>?>? responseWsCreated = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsCompleted2>?>? responseFileSearchCallWsCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallInWsProgress2>?>? responseFileSearchCallInWsProgress = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsSearching2>?>? responseFileSearchCallWsSearching = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDelta2>?>? responseFunctionCallArgumentsWsDelta = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2>?>? responseFunctionCallArgumentsWsDone = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsAdded2>?>? responseShellCallCommandWsAdded = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDelta2>?>? responseShellCallCommandWsDelta = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDone2>?>? responseShellCallCommandWsDone = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDelta2>?>? responseShellCallOutputContentWsDelta = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDone2>?>? responseShellCallOutputContentWsDone = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseInWsProgress2>?>? responseInWsProgress = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsFailed2>?>? responseWsFailed = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseIncompleteEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsIncomplete2>?>? responseWsIncomplete = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsAdded2>?>? responseOutputItemWsAdded = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsDone2>?>? responseOutputItemWsDone = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsAdded2>?>? responseReasoningSummaryPartWsAdded = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsDone2>?>? responseReasoningSummaryPartWsDone = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDelta2>?>? responseReasoningSummaryTextWsDelta = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDone2>?>? responseReasoningSummaryTextWsDone = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDelta2>?>? responseReasoningTextWsDelta = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDone2>?>? responseReasoningTextWsDone = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDelta2>?>? responseRefusalWsDelta = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDone2>?>? responseRefusalWsDone = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDelta2>?>? responseTextWsDelta = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDone2>?>? responseTextWsDone = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsCompleted2>?>? responseWebSearchCallWsCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallInWsProgress2>?>? responseWebSearchCallInWsProgress = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsSearching2>?>? responseWebSearchCallWsSearching = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsCompleted2>?>? responseImageGenCallWsCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsGenerating2>?>? responseImageGenCallWsGenerating = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallInWsProgress2>?>? responseImageGenCallInWsProgress = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2>?>? responseImageGenCallPartialWsImage = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDelta2>?>? responseMcpCallArgumentsWsDelta = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDone2>?>? responseMcpCallArgumentsWsDone = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsCompleted2>?>? responseMcpCallWsCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsFailed2>?>? responseMcpCallWsFailed = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallInWsProgress2>?>? responseMcpCallInWsProgress = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsCompleted2>?>? responseMcpListToolsWsCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsFailed2>?>? responseMcpListToolsWsFailed = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsInWsProgress2>?>? responseMcpListToolsInWsProgress = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputTextAnnotationWsAdded2>?>? responseOutputTextAnnotationWsAdded = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseQueuedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsQueued2>?>? responseWsQueued = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDelta2>?>? responseCustomToolCallInputWsDelta = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDone2>?>? responseCustomToolCallInputWsDone = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseWsError>? error = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseSteerAcceptedEvent>? responseSteerAccepted = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseSteerPendingEvent>? responseSteerPending = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseSteerFailedEvent>? responseSteerFailed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ResponseAudioWsDelta is { } __value0)
            {
                responseAudioWsDelta?.Invoke(__value0);
            }
            else if (ResponseAudioWsDone is { } __value1)
            {
                responseAudioWsDone?.Invoke(__value1);
            }
            else if (ResponseAudioTranscriptWsDelta is { } __value2)
            {
                responseAudioTranscriptWsDelta?.Invoke(__value2);
            }
            else if (ResponseAudioTranscriptWsDone is { } __value3)
            {
                responseAudioTranscriptWsDone?.Invoke(__value3);
            }
            else if (ResponseCodeInterpreterCallCodeWsDelta is { } __value4)
            {
                responseCodeInterpreterCallCodeWsDelta?.Invoke(__value4);
            }
            else if (ResponseCodeInterpreterCallCodeWsDone is { } __value5)
            {
                responseCodeInterpreterCallCodeWsDone?.Invoke(__value5);
            }
            else if (ResponseCodeInterpreterCallWsCompleted is { } __value6)
            {
                responseCodeInterpreterCallWsCompleted?.Invoke(__value6);
            }
            else if (ResponseCodeInterpreterCallInWsProgress is { } __value7)
            {
                responseCodeInterpreterCallInWsProgress?.Invoke(__value7);
            }
            else if (ResponseCodeInterpreterCallWsInterpreting is { } __value8)
            {
                responseCodeInterpreterCallWsInterpreting?.Invoke(__value8);
            }
            else if (ResponseCompactionWsCompacting is { } __value9)
            {
                responseCompactionWsCompacting?.Invoke(__value9);
            }
            else if (ResponseWsCompleted is { } __value10)
            {
                responseWsCompleted?.Invoke(__value10);
            }
            else if (ResponseContentPartWsAdded is { } __value11)
            {
                responseContentPartWsAdded?.Invoke(__value11);
            }
            else if (ResponseContentPartWsDone is { } __value12)
            {
                responseContentPartWsDone?.Invoke(__value12);
            }
            else if (ResponseWsCreated is { } __value13)
            {
                responseWsCreated?.Invoke(__value13);
            }
            else if (ResponseFileSearchCallWsCompleted is { } __value14)
            {
                responseFileSearchCallWsCompleted?.Invoke(__value14);
            }
            else if (ResponseFileSearchCallInWsProgress is { } __value15)
            {
                responseFileSearchCallInWsProgress?.Invoke(__value15);
            }
            else if (ResponseFileSearchCallWsSearching is { } __value16)
            {
                responseFileSearchCallWsSearching?.Invoke(__value16);
            }
            else if (ResponseFunctionCallArgumentsWsDelta is { } __value17)
            {
                responseFunctionCallArgumentsWsDelta?.Invoke(__value17);
            }
            else if (ResponseFunctionCallArgumentsWsDone is { } __value18)
            {
                responseFunctionCallArgumentsWsDone?.Invoke(__value18);
            }
            else if (ResponseShellCallCommandWsAdded is { } __value19)
            {
                responseShellCallCommandWsAdded?.Invoke(__value19);
            }
            else if (ResponseShellCallCommandWsDelta is { } __value20)
            {
                responseShellCallCommandWsDelta?.Invoke(__value20);
            }
            else if (ResponseShellCallCommandWsDone is { } __value21)
            {
                responseShellCallCommandWsDone?.Invoke(__value21);
            }
            else if (ResponseShellCallOutputContentWsDelta is { } __value22)
            {
                responseShellCallOutputContentWsDelta?.Invoke(__value22);
            }
            else if (ResponseShellCallOutputContentWsDone is { } __value23)
            {
                responseShellCallOutputContentWsDone?.Invoke(__value23);
            }
            else if (ResponseInWsProgress is { } __value24)
            {
                responseInWsProgress?.Invoke(__value24);
            }
            else if (ResponseWsFailed is { } __value25)
            {
                responseWsFailed?.Invoke(__value25);
            }
            else if (ResponseWsIncomplete is { } __value26)
            {
                responseWsIncomplete?.Invoke(__value26);
            }
            else if (ResponseOutputItemWsAdded is { } __value27)
            {
                responseOutputItemWsAdded?.Invoke(__value27);
            }
            else if (ResponseOutputItemWsDone is { } __value28)
            {
                responseOutputItemWsDone?.Invoke(__value28);
            }
            else if (ResponseReasoningSummaryPartWsAdded is { } __value29)
            {
                responseReasoningSummaryPartWsAdded?.Invoke(__value29);
            }
            else if (ResponseReasoningSummaryPartWsDone is { } __value30)
            {
                responseReasoningSummaryPartWsDone?.Invoke(__value30);
            }
            else if (ResponseReasoningSummaryTextWsDelta is { } __value31)
            {
                responseReasoningSummaryTextWsDelta?.Invoke(__value31);
            }
            else if (ResponseReasoningSummaryTextWsDone is { } __value32)
            {
                responseReasoningSummaryTextWsDone?.Invoke(__value32);
            }
            else if (ResponseReasoningTextWsDelta is { } __value33)
            {
                responseReasoningTextWsDelta?.Invoke(__value33);
            }
            else if (ResponseReasoningTextWsDone is { } __value34)
            {
                responseReasoningTextWsDone?.Invoke(__value34);
            }
            else if (ResponseRefusalWsDelta is { } __value35)
            {
                responseRefusalWsDelta?.Invoke(__value35);
            }
            else if (ResponseRefusalWsDone is { } __value36)
            {
                responseRefusalWsDone?.Invoke(__value36);
            }
            else if (ResponseTextWsDelta is { } __value37)
            {
                responseTextWsDelta?.Invoke(__value37);
            }
            else if (ResponseTextWsDone is { } __value38)
            {
                responseTextWsDone?.Invoke(__value38);
            }
            else if (ResponseWebSearchCallWsCompleted is { } __value39)
            {
                responseWebSearchCallWsCompleted?.Invoke(__value39);
            }
            else if (ResponseWebSearchCallInWsProgress is { } __value40)
            {
                responseWebSearchCallInWsProgress?.Invoke(__value40);
            }
            else if (ResponseWebSearchCallWsSearching is { } __value41)
            {
                responseWebSearchCallWsSearching?.Invoke(__value41);
            }
            else if (ResponseImageGenCallWsCompleted is { } __value42)
            {
                responseImageGenCallWsCompleted?.Invoke(__value42);
            }
            else if (ResponseImageGenCallWsGenerating is { } __value43)
            {
                responseImageGenCallWsGenerating?.Invoke(__value43);
            }
            else if (ResponseImageGenCallInWsProgress is { } __value44)
            {
                responseImageGenCallInWsProgress?.Invoke(__value44);
            }
            else if (ResponseImageGenCallPartialWsImage is { } __value45)
            {
                responseImageGenCallPartialWsImage?.Invoke(__value45);
            }
            else if (ResponseMcpCallArgumentsWsDelta is { } __value46)
            {
                responseMcpCallArgumentsWsDelta?.Invoke(__value46);
            }
            else if (ResponseMcpCallArgumentsWsDone is { } __value47)
            {
                responseMcpCallArgumentsWsDone?.Invoke(__value47);
            }
            else if (ResponseMcpCallWsCompleted is { } __value48)
            {
                responseMcpCallWsCompleted?.Invoke(__value48);
            }
            else if (ResponseMcpCallWsFailed is { } __value49)
            {
                responseMcpCallWsFailed?.Invoke(__value49);
            }
            else if (ResponseMcpCallInWsProgress is { } __value50)
            {
                responseMcpCallInWsProgress?.Invoke(__value50);
            }
            else if (ResponseMcpListToolsWsCompleted is { } __value51)
            {
                responseMcpListToolsWsCompleted?.Invoke(__value51);
            }
            else if (ResponseMcpListToolsWsFailed is { } __value52)
            {
                responseMcpListToolsWsFailed?.Invoke(__value52);
            }
            else if (ResponseMcpListToolsInWsProgress is { } __value53)
            {
                responseMcpListToolsInWsProgress?.Invoke(__value53);
            }
            else if (ResponseOutputTextAnnotationWsAdded is { } __value54)
            {
                responseOutputTextAnnotationWsAdded?.Invoke(__value54);
            }
            else if (ResponseWsQueued is { } __value55)
            {
                responseWsQueued?.Invoke(__value55);
            }
            else if (ResponseCustomToolCallInputWsDelta is { } __value56)
            {
                responseCustomToolCallInputWsDelta?.Invoke(__value56);
            }
            else if (ResponseCustomToolCallInputWsDone is { } __value57)
            {
                responseCustomToolCallInputWsDone?.Invoke(__value57);
            }
            else if (Error is { } __value58)
            {
                error?.Invoke(__value58);
            }
            else if (ResponseSteerAccepted is { } __value59)
            {
                responseSteerAccepted?.Invoke(__value59);
            }
            else if (ResponseSteerPending is { } __value60)
            {
                responseSteerPending?.Invoke(__value60);
            }
            else if (ResponseSteerFailed is { } __value61)
            {
                responseSteerFailed?.Invoke(__value61);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ResponseAudioWsDelta,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDelta2>),
                ResponseAudioWsDone,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDone2>),
                ResponseAudioTranscriptWsDelta,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDelta2>),
                ResponseAudioTranscriptWsDone,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDone2>),
                ResponseCodeInterpreterCallCodeWsDelta,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDelta2>),
                ResponseCodeInterpreterCallCodeWsDone,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDone2>),
                ResponseCodeInterpreterCallWsCompleted,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsCompleted2>),
                ResponseCodeInterpreterCallInWsProgress,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallInWsProgress2>),
                ResponseCodeInterpreterCallWsInterpreting,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsInterpreting2>),
                ResponseCompactionWsCompacting,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCompactionWsCompacting2>),
                ResponseWsCompleted,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCompleted2>),
                ResponseContentPartWsAdded,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsAdded2>),
                ResponseContentPartWsDone,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsDone2>),
                ResponseWsCreated,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCreatedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCreated2>),
                ResponseFileSearchCallWsCompleted,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsCompleted2>),
                ResponseFileSearchCallInWsProgress,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallInWsProgress2>),
                ResponseFileSearchCallWsSearching,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsSearching2>),
                ResponseFunctionCallArgumentsWsDelta,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDelta2>),
                ResponseFunctionCallArgumentsWsDone,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2>),
                ResponseShellCallCommandWsAdded,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsAdded2>),
                ResponseShellCallCommandWsDelta,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDelta2>),
                ResponseShellCallCommandWsDone,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDone2>),
                ResponseShellCallOutputContentWsDelta,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDelta2>),
                ResponseShellCallOutputContentWsDone,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDone2>),
                ResponseInWsProgress,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseInWsProgress2>),
                ResponseWsFailed,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsFailed2>),
                ResponseWsIncomplete,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseIncompleteEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsIncomplete2>),
                ResponseOutputItemWsAdded,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsAdded2>),
                ResponseOutputItemWsDone,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsDone2>),
                ResponseReasoningSummaryPartWsAdded,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsAdded2>),
                ResponseReasoningSummaryPartWsDone,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsDone2>),
                ResponseReasoningSummaryTextWsDelta,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDelta2>),
                ResponseReasoningSummaryTextWsDone,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDone2>),
                ResponseReasoningTextWsDelta,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDelta2>),
                ResponseReasoningTextWsDone,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDone2>),
                ResponseRefusalWsDelta,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDelta2>),
                ResponseRefusalWsDone,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDone2>),
                ResponseTextWsDelta,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDelta2>),
                ResponseTextWsDone,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDone2>),
                ResponseWebSearchCallWsCompleted,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsCompleted2>),
                ResponseWebSearchCallInWsProgress,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallInWsProgress2>),
                ResponseWebSearchCallWsSearching,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsSearching2>),
                ResponseImageGenCallWsCompleted,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsCompleted2>),
                ResponseImageGenCallWsGenerating,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsGenerating2>),
                ResponseImageGenCallInWsProgress,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallInWsProgress2>),
                ResponseImageGenCallPartialWsImage,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2>),
                ResponseMcpCallArgumentsWsDelta,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDelta2>),
                ResponseMcpCallArgumentsWsDone,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDone2>),
                ResponseMcpCallWsCompleted,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsCompleted2>),
                ResponseMcpCallWsFailed,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsFailed2>),
                ResponseMcpCallInWsProgress,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallInWsProgress2>),
                ResponseMcpListToolsWsCompleted,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsCompleted2>),
                ResponseMcpListToolsWsFailed,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsFailed2>),
                ResponseMcpListToolsInWsProgress,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsInWsProgress2>),
                ResponseOutputTextAnnotationWsAdded,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputTextAnnotationWsAdded2>),
                ResponseWsQueued,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseQueuedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsQueued2>),
                ResponseCustomToolCallInputWsDelta,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDelta2>),
                ResponseCustomToolCallInputWsDone,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDone2>),
                Error,
                typeof(global::tryAGI.OpenAI.ResponseWsError),
                ResponseSteerAccepted,
                typeof(global::tryAGI.OpenAI.ResponseSteerAcceptedEvent),
                ResponseSteerPending,
                typeof(global::tryAGI.OpenAI.ResponseSteerPendingEvent),
                ResponseSteerFailed,
                typeof(global::tryAGI.OpenAI.ResponseSteerFailedEvent),
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
        public bool Equals(ResponsesServerEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDelta2>?>.Default.Equals(ResponseAudioWsDelta, other.ResponseAudioWsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDone2>?>.Default.Equals(ResponseAudioWsDone, other.ResponseAudioWsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDelta2>?>.Default.Equals(ResponseAudioTranscriptWsDelta, other.ResponseAudioTranscriptWsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDone2>?>.Default.Equals(ResponseAudioTranscriptWsDone, other.ResponseAudioTranscriptWsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDelta2>?>.Default.Equals(ResponseCodeInterpreterCallCodeWsDelta, other.ResponseCodeInterpreterCallCodeWsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDone2>?>.Default.Equals(ResponseCodeInterpreterCallCodeWsDone, other.ResponseCodeInterpreterCallCodeWsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsCompleted2>?>.Default.Equals(ResponseCodeInterpreterCallWsCompleted, other.ResponseCodeInterpreterCallWsCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallInWsProgress2>?>.Default.Equals(ResponseCodeInterpreterCallInWsProgress, other.ResponseCodeInterpreterCallInWsProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsInterpreting2>?>.Default.Equals(ResponseCodeInterpreterCallWsInterpreting, other.ResponseCodeInterpreterCallWsInterpreting) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCompactionWsCompacting2>?>.Default.Equals(ResponseCompactionWsCompacting, other.ResponseCompactionWsCompacting) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCompleted2>?>.Default.Equals(ResponseWsCompleted, other.ResponseWsCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsAdded2>?>.Default.Equals(ResponseContentPartWsAdded, other.ResponseContentPartWsAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsDone2>?>.Default.Equals(ResponseContentPartWsDone, other.ResponseContentPartWsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCreatedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCreated2>?>.Default.Equals(ResponseWsCreated, other.ResponseWsCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsCompleted2>?>.Default.Equals(ResponseFileSearchCallWsCompleted, other.ResponseFileSearchCallWsCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallInWsProgress2>?>.Default.Equals(ResponseFileSearchCallInWsProgress, other.ResponseFileSearchCallInWsProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsSearching2>?>.Default.Equals(ResponseFileSearchCallWsSearching, other.ResponseFileSearchCallWsSearching) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDelta2>?>.Default.Equals(ResponseFunctionCallArgumentsWsDelta, other.ResponseFunctionCallArgumentsWsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2>?>.Default.Equals(ResponseFunctionCallArgumentsWsDone, other.ResponseFunctionCallArgumentsWsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsAdded2>?>.Default.Equals(ResponseShellCallCommandWsAdded, other.ResponseShellCallCommandWsAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDelta2>?>.Default.Equals(ResponseShellCallCommandWsDelta, other.ResponseShellCallCommandWsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDone2>?>.Default.Equals(ResponseShellCallCommandWsDone, other.ResponseShellCallCommandWsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDelta2>?>.Default.Equals(ResponseShellCallOutputContentWsDelta, other.ResponseShellCallOutputContentWsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDone2>?>.Default.Equals(ResponseShellCallOutputContentWsDone, other.ResponseShellCallOutputContentWsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseInWsProgress2>?>.Default.Equals(ResponseInWsProgress, other.ResponseInWsProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsFailed2>?>.Default.Equals(ResponseWsFailed, other.ResponseWsFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseIncompleteEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsIncomplete2>?>.Default.Equals(ResponseWsIncomplete, other.ResponseWsIncomplete) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsAdded2>?>.Default.Equals(ResponseOutputItemWsAdded, other.ResponseOutputItemWsAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsDone2>?>.Default.Equals(ResponseOutputItemWsDone, other.ResponseOutputItemWsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsAdded2>?>.Default.Equals(ResponseReasoningSummaryPartWsAdded, other.ResponseReasoningSummaryPartWsAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsDone2>?>.Default.Equals(ResponseReasoningSummaryPartWsDone, other.ResponseReasoningSummaryPartWsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDelta2>?>.Default.Equals(ResponseReasoningSummaryTextWsDelta, other.ResponseReasoningSummaryTextWsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDone2>?>.Default.Equals(ResponseReasoningSummaryTextWsDone, other.ResponseReasoningSummaryTextWsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDelta2>?>.Default.Equals(ResponseReasoningTextWsDelta, other.ResponseReasoningTextWsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDone2>?>.Default.Equals(ResponseReasoningTextWsDone, other.ResponseReasoningTextWsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDelta2>?>.Default.Equals(ResponseRefusalWsDelta, other.ResponseRefusalWsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDone2>?>.Default.Equals(ResponseRefusalWsDone, other.ResponseRefusalWsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDelta2>?>.Default.Equals(ResponseTextWsDelta, other.ResponseTextWsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDone2>?>.Default.Equals(ResponseTextWsDone, other.ResponseTextWsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsCompleted2>?>.Default.Equals(ResponseWebSearchCallWsCompleted, other.ResponseWebSearchCallWsCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallInWsProgress2>?>.Default.Equals(ResponseWebSearchCallInWsProgress, other.ResponseWebSearchCallInWsProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsSearching2>?>.Default.Equals(ResponseWebSearchCallWsSearching, other.ResponseWebSearchCallWsSearching) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsCompleted2>?>.Default.Equals(ResponseImageGenCallWsCompleted, other.ResponseImageGenCallWsCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsGenerating2>?>.Default.Equals(ResponseImageGenCallWsGenerating, other.ResponseImageGenCallWsGenerating) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallInWsProgress2>?>.Default.Equals(ResponseImageGenCallInWsProgress, other.ResponseImageGenCallInWsProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2>?>.Default.Equals(ResponseImageGenCallPartialWsImage, other.ResponseImageGenCallPartialWsImage) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDelta2>?>.Default.Equals(ResponseMcpCallArgumentsWsDelta, other.ResponseMcpCallArgumentsWsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDone2>?>.Default.Equals(ResponseMcpCallArgumentsWsDone, other.ResponseMcpCallArgumentsWsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsCompleted2>?>.Default.Equals(ResponseMcpCallWsCompleted, other.ResponseMcpCallWsCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsFailed2>?>.Default.Equals(ResponseMcpCallWsFailed, other.ResponseMcpCallWsFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallInWsProgress2>?>.Default.Equals(ResponseMcpCallInWsProgress, other.ResponseMcpCallInWsProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsCompleted2>?>.Default.Equals(ResponseMcpListToolsWsCompleted, other.ResponseMcpListToolsWsCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsFailed2>?>.Default.Equals(ResponseMcpListToolsWsFailed, other.ResponseMcpListToolsWsFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsInWsProgress2>?>.Default.Equals(ResponseMcpListToolsInWsProgress, other.ResponseMcpListToolsInWsProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputTextAnnotationWsAdded2>?>.Default.Equals(ResponseOutputTextAnnotationWsAdded, other.ResponseOutputTextAnnotationWsAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseQueuedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsQueued2>?>.Default.Equals(ResponseWsQueued, other.ResponseWsQueued) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDelta2>?>.Default.Equals(ResponseCustomToolCallInputWsDelta, other.ResponseCustomToolCallInputWsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDone2>?>.Default.Equals(ResponseCustomToolCallInputWsDone, other.ResponseCustomToolCallInputWsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseWsError?>.Default.Equals(Error, other.Error) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseSteerAcceptedEvent?>.Default.Equals(ResponseSteerAccepted, other.ResponseSteerAccepted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseSteerPendingEvent?>.Default.Equals(ResponseSteerPending, other.ResponseSteerPending) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseSteerFailedEvent?>.Default.Equals(ResponseSteerFailed, other.ResponseSteerFailed)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ResponsesServerEvent obj1, ResponsesServerEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponsesServerEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ResponsesServerEvent obj1, ResponsesServerEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponsesServerEvent o && Equals(o);
        }
    }
}
