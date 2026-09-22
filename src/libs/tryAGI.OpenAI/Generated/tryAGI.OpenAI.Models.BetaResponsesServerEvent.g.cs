#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Server events emitted by the Responses WebSocket server.
    /// </summary>
    public readonly partial struct BetaResponsesServerEvent : global::System.IEquatable<BetaResponsesServerEvent>
    {
        /// <summary>
        /// Emitted when there is a partial audio response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDelta2>? BetaResponseAudioWsDelta { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDelta2>? BetaResponseAudioWsDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseAudioWsDelta))]
#endif
        public bool IsBetaResponseAudioWsDelta => BetaResponseAudioWsDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseAudioWsDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDelta2>? value)
        {
            value = BetaResponseAudioWsDelta;
            return IsBetaResponseAudioWsDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDelta2> PickBetaResponseAudioWsDelta() => IsBetaResponseAudioWsDelta
            ? BetaResponseAudioWsDelta!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseAudioWsDelta' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when the audio response is complete.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDone2>? BetaResponseAudioWsDone { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDone2>? BetaResponseAudioWsDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseAudioWsDone))]
#endif
        public bool IsBetaResponseAudioWsDone => BetaResponseAudioWsDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseAudioWsDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDone2>? value)
        {
            value = BetaResponseAudioWsDone;
            return IsBetaResponseAudioWsDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDone2> PickBetaResponseAudioWsDone() => IsBetaResponseAudioWsDone
            ? BetaResponseAudioWsDone!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseAudioWsDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when there is a partial transcript of audio.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDelta2>? BetaResponseAudioTranscriptWsDelta { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDelta2>? BetaResponseAudioTranscriptWsDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseAudioTranscriptWsDelta))]
#endif
        public bool IsBetaResponseAudioTranscriptWsDelta => BetaResponseAudioTranscriptWsDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseAudioTranscriptWsDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDelta2>? value)
        {
            value = BetaResponseAudioTranscriptWsDelta;
            return IsBetaResponseAudioTranscriptWsDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDelta2> PickBetaResponseAudioTranscriptWsDelta() => IsBetaResponseAudioTranscriptWsDelta
            ? BetaResponseAudioTranscriptWsDelta!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseAudioTranscriptWsDelta' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when the full audio transcript is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDone2>? BetaResponseAudioTranscriptWsDone { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDone2>? BetaResponseAudioTranscriptWsDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseAudioTranscriptWsDone))]
#endif
        public bool IsBetaResponseAudioTranscriptWsDone => BetaResponseAudioTranscriptWsDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseAudioTranscriptWsDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDone2>? value)
        {
            value = BetaResponseAudioTranscriptWsDone;
            return IsBetaResponseAudioTranscriptWsDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDone2> PickBetaResponseAudioTranscriptWsDone() => IsBetaResponseAudioTranscriptWsDone
            ? BetaResponseAudioTranscriptWsDone!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseAudioTranscriptWsDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a partial code snippet is streamed by the code interpreter.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDelta2>? BetaResponseCodeInterpreterCallCodeWsDelta { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDelta2>? BetaResponseCodeInterpreterCallCodeWsDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseCodeInterpreterCallCodeWsDelta))]
#endif
        public bool IsBetaResponseCodeInterpreterCallCodeWsDelta => BetaResponseCodeInterpreterCallCodeWsDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseCodeInterpreterCallCodeWsDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDelta2>? value)
        {
            value = BetaResponseCodeInterpreterCallCodeWsDelta;
            return IsBetaResponseCodeInterpreterCallCodeWsDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDelta2> PickBetaResponseCodeInterpreterCallCodeWsDelta() => IsBetaResponseCodeInterpreterCallCodeWsDelta
            ? BetaResponseCodeInterpreterCallCodeWsDelta!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseCodeInterpreterCallCodeWsDelta' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when the code snippet is finalized by the code interpreter.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDone2>? BetaResponseCodeInterpreterCallCodeWsDone { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDone2>? BetaResponseCodeInterpreterCallCodeWsDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseCodeInterpreterCallCodeWsDone))]
#endif
        public bool IsBetaResponseCodeInterpreterCallCodeWsDone => BetaResponseCodeInterpreterCallCodeWsDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseCodeInterpreterCallCodeWsDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDone2>? value)
        {
            value = BetaResponseCodeInterpreterCallCodeWsDone;
            return IsBetaResponseCodeInterpreterCallCodeWsDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDone2> PickBetaResponseCodeInterpreterCallCodeWsDone() => IsBetaResponseCodeInterpreterCallCodeWsDone
            ? BetaResponseCodeInterpreterCallCodeWsDone!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseCodeInterpreterCallCodeWsDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when the code interpreter call is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsCompleted2>? BetaResponseCodeInterpreterCallWsCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsCompleted2>? BetaResponseCodeInterpreterCallWsCompleted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseCodeInterpreterCallWsCompleted))]
#endif
        public bool IsBetaResponseCodeInterpreterCallWsCompleted => BetaResponseCodeInterpreterCallWsCompleted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseCodeInterpreterCallWsCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsCompleted2>? value)
        {
            value = BetaResponseCodeInterpreterCallWsCompleted;
            return IsBetaResponseCodeInterpreterCallWsCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsCompleted2> PickBetaResponseCodeInterpreterCallWsCompleted() => IsBetaResponseCodeInterpreterCallWsCompleted
            ? BetaResponseCodeInterpreterCallWsCompleted!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseCodeInterpreterCallWsCompleted' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a code interpreter call is in progress.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallInWsProgress2>? BetaResponseCodeInterpreterCallInWsProgress { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallInWsProgress2>? BetaResponseCodeInterpreterCallInWsProgress { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseCodeInterpreterCallInWsProgress))]
#endif
        public bool IsBetaResponseCodeInterpreterCallInWsProgress => BetaResponseCodeInterpreterCallInWsProgress != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseCodeInterpreterCallInWsProgress(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallInWsProgress2>? value)
        {
            value = BetaResponseCodeInterpreterCallInWsProgress;
            return IsBetaResponseCodeInterpreterCallInWsProgress;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallInWsProgress2> PickBetaResponseCodeInterpreterCallInWsProgress() => IsBetaResponseCodeInterpreterCallInWsProgress
            ? BetaResponseCodeInterpreterCallInWsProgress!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseCodeInterpreterCallInWsProgress' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when the code interpreter is actively interpreting the code snippet.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsInterpreting2>? BetaResponseCodeInterpreterCallWsInterpreting { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsInterpreting2>? BetaResponseCodeInterpreterCallWsInterpreting { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseCodeInterpreterCallWsInterpreting))]
#endif
        public bool IsBetaResponseCodeInterpreterCallWsInterpreting => BetaResponseCodeInterpreterCallWsInterpreting != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseCodeInterpreterCallWsInterpreting(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsInterpreting2>? value)
        {
            value = BetaResponseCodeInterpreterCallWsInterpreting;
            return IsBetaResponseCodeInterpreterCallWsInterpreting;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsInterpreting2> PickBetaResponseCodeInterpreterCallWsInterpreting() => IsBetaResponseCodeInterpreterCallWsInterpreting
            ? BetaResponseCodeInterpreterCallWsInterpreting!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseCodeInterpreterCallWsInterpreting' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when new summary content is sampled for a compaction trigger. Contains no summary content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCompactionWsCompacting2>? BetaResponseCompactionWsCompacting { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCompactionWsCompacting2>? BetaResponseCompactionWsCompacting { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseCompactionWsCompacting))]
#endif
        public bool IsBetaResponseCompactionWsCompacting => BetaResponseCompactionWsCompacting != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseCompactionWsCompacting(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCompactionWsCompacting2>? value)
        {
            value = BetaResponseCompactionWsCompacting;
            return IsBetaResponseCompactionWsCompacting;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCompactionWsCompacting2> PickBetaResponseCompactionWsCompacting() => IsBetaResponseCompactionWsCompacting
            ? BetaResponseCompactionWsCompacting!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseCompactionWsCompacting' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when the model response is complete.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCompleted2>? BetaResponseWsCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCompleted2>? BetaResponseWsCompleted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseWsCompleted))]
#endif
        public bool IsBetaResponseWsCompleted => BetaResponseWsCompleted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseWsCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCompleted2>? value)
        {
            value = BetaResponseWsCompleted;
            return IsBetaResponseWsCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCompleted2> PickBetaResponseWsCompleted() => IsBetaResponseWsCompleted
            ? BetaResponseWsCompleted!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseWsCompleted' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a new content part is added.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsAdded2>? BetaResponseContentPartWsAdded { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsAdded2>? BetaResponseContentPartWsAdded { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseContentPartWsAdded))]
#endif
        public bool IsBetaResponseContentPartWsAdded => BetaResponseContentPartWsAdded != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseContentPartWsAdded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsAdded2>? value)
        {
            value = BetaResponseContentPartWsAdded;
            return IsBetaResponseContentPartWsAdded;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsAdded2> PickBetaResponseContentPartWsAdded() => IsBetaResponseContentPartWsAdded
            ? BetaResponseContentPartWsAdded!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseContentPartWsAdded' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a content part is done.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsDone2>? BetaResponseContentPartWsDone { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsDone2>? BetaResponseContentPartWsDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseContentPartWsDone))]
#endif
        public bool IsBetaResponseContentPartWsDone => BetaResponseContentPartWsDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseContentPartWsDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsDone2>? value)
        {
            value = BetaResponseContentPartWsDone;
            return IsBetaResponseContentPartWsDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsDone2> PickBetaResponseContentPartWsDone() => IsBetaResponseContentPartWsDone
            ? BetaResponseContentPartWsDone!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseContentPartWsDone' but the value was {ToString()}.");

        /// <summary>
        /// An event that is emitted when a response is created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCreatedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCreated2>? BetaResponseWsCreated { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCreatedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCreated2>? BetaResponseWsCreated { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseWsCreated))]
#endif
        public bool IsBetaResponseWsCreated => BetaResponseWsCreated != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseWsCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCreatedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCreated2>? value)
        {
            value = BetaResponseWsCreated;
            return IsBetaResponseWsCreated;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCreatedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCreated2> PickBetaResponseWsCreated() => IsBetaResponseWsCreated
            ? BetaResponseWsCreated!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseWsCreated' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a file search call is completed (results found).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsCompleted2>? BetaResponseFileSearchCallWsCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsCompleted2>? BetaResponseFileSearchCallWsCompleted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseFileSearchCallWsCompleted))]
#endif
        public bool IsBetaResponseFileSearchCallWsCompleted => BetaResponseFileSearchCallWsCompleted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseFileSearchCallWsCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsCompleted2>? value)
        {
            value = BetaResponseFileSearchCallWsCompleted;
            return IsBetaResponseFileSearchCallWsCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsCompleted2> PickBetaResponseFileSearchCallWsCompleted() => IsBetaResponseFileSearchCallWsCompleted
            ? BetaResponseFileSearchCallWsCompleted!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseFileSearchCallWsCompleted' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a file search call is initiated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallInWsProgress2>? BetaResponseFileSearchCallInWsProgress { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallInWsProgress2>? BetaResponseFileSearchCallInWsProgress { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseFileSearchCallInWsProgress))]
#endif
        public bool IsBetaResponseFileSearchCallInWsProgress => BetaResponseFileSearchCallInWsProgress != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseFileSearchCallInWsProgress(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallInWsProgress2>? value)
        {
            value = BetaResponseFileSearchCallInWsProgress;
            return IsBetaResponseFileSearchCallInWsProgress;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallInWsProgress2> PickBetaResponseFileSearchCallInWsProgress() => IsBetaResponseFileSearchCallInWsProgress
            ? BetaResponseFileSearchCallInWsProgress!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseFileSearchCallInWsProgress' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a file search is currently searching.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsSearching2>? BetaResponseFileSearchCallWsSearching { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsSearching2>? BetaResponseFileSearchCallWsSearching { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseFileSearchCallWsSearching))]
#endif
        public bool IsBetaResponseFileSearchCallWsSearching => BetaResponseFileSearchCallWsSearching != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseFileSearchCallWsSearching(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsSearching2>? value)
        {
            value = BetaResponseFileSearchCallWsSearching;
            return IsBetaResponseFileSearchCallWsSearching;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsSearching2> PickBetaResponseFileSearchCallWsSearching() => IsBetaResponseFileSearchCallWsSearching
            ? BetaResponseFileSearchCallWsSearching!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseFileSearchCallWsSearching' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when there is a partial function-call arguments delta.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDelta2>? BetaResponseFunctionCallArgumentsWsDelta { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDelta2>? BetaResponseFunctionCallArgumentsWsDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseFunctionCallArgumentsWsDelta))]
#endif
        public bool IsBetaResponseFunctionCallArgumentsWsDelta => BetaResponseFunctionCallArgumentsWsDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseFunctionCallArgumentsWsDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDelta2>? value)
        {
            value = BetaResponseFunctionCallArgumentsWsDelta;
            return IsBetaResponseFunctionCallArgumentsWsDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDelta2> PickBetaResponseFunctionCallArgumentsWsDelta() => IsBetaResponseFunctionCallArgumentsWsDelta
            ? BetaResponseFunctionCallArgumentsWsDelta!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseFunctionCallArgumentsWsDelta' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when function-call arguments are finalized.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2>? BetaResponseFunctionCallArgumentsWsDone { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2>? BetaResponseFunctionCallArgumentsWsDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseFunctionCallArgumentsWsDone))]
#endif
        public bool IsBetaResponseFunctionCallArgumentsWsDone => BetaResponseFunctionCallArgumentsWsDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseFunctionCallArgumentsWsDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2>? value)
        {
            value = BetaResponseFunctionCallArgumentsWsDone;
            return IsBetaResponseFunctionCallArgumentsWsDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2> PickBetaResponseFunctionCallArgumentsWsDone() => IsBetaResponseFunctionCallArgumentsWsDone
            ? BetaResponseFunctionCallArgumentsWsDone!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseFunctionCallArgumentsWsDone' but the value was {ToString()}.");

        /// <summary>
        /// A streaming event that indicated a shell command was added to a tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsAdded2>? BetaResponseShellCallCommandWsAdded { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsAdded2>? BetaResponseShellCallCommandWsAdded { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseShellCallCommandWsAdded))]
#endif
        public bool IsBetaResponseShellCallCommandWsAdded => BetaResponseShellCallCommandWsAdded != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseShellCallCommandWsAdded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsAdded2>? value)
        {
            value = BetaResponseShellCallCommandWsAdded;
            return IsBetaResponseShellCallCommandWsAdded;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsAdded2> PickBetaResponseShellCallCommandWsAdded() => IsBetaResponseShellCallCommandWsAdded
            ? BetaResponseShellCallCommandWsAdded!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseShellCallCommandWsAdded' but the value was {ToString()}.");

        /// <summary>
        /// A streaming event that indicated a shell command was incrementally updated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDelta2>? BetaResponseShellCallCommandWsDelta { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDelta2>? BetaResponseShellCallCommandWsDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseShellCallCommandWsDelta))]
#endif
        public bool IsBetaResponseShellCallCommandWsDelta => BetaResponseShellCallCommandWsDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseShellCallCommandWsDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDelta2>? value)
        {
            value = BetaResponseShellCallCommandWsDelta;
            return IsBetaResponseShellCallCommandWsDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDelta2> PickBetaResponseShellCallCommandWsDelta() => IsBetaResponseShellCallCommandWsDelta
            ? BetaResponseShellCallCommandWsDelta!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseShellCallCommandWsDelta' but the value was {ToString()}.");

        /// <summary>
        /// A streaming event that indicated a shell command was completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDone2>? BetaResponseShellCallCommandWsDone { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDone2>? BetaResponseShellCallCommandWsDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseShellCallCommandWsDone))]
#endif
        public bool IsBetaResponseShellCallCommandWsDone => BetaResponseShellCallCommandWsDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseShellCallCommandWsDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDone2>? value)
        {
            value = BetaResponseShellCallCommandWsDone;
            return IsBetaResponseShellCallCommandWsDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDone2> PickBetaResponseShellCallCommandWsDone() => IsBetaResponseShellCallCommandWsDone
            ? BetaResponseShellCallCommandWsDone!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseShellCallCommandWsDone' but the value was {ToString()}.");

        /// <summary>
        /// A streaming event that indicated shell call output was incrementally added.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDelta2>? BetaResponseShellCallOutputContentWsDelta { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDelta2>? BetaResponseShellCallOutputContentWsDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseShellCallOutputContentWsDelta))]
#endif
        public bool IsBetaResponseShellCallOutputContentWsDelta => BetaResponseShellCallOutputContentWsDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseShellCallOutputContentWsDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDelta2>? value)
        {
            value = BetaResponseShellCallOutputContentWsDelta;
            return IsBetaResponseShellCallOutputContentWsDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDelta2> PickBetaResponseShellCallOutputContentWsDelta() => IsBetaResponseShellCallOutputContentWsDelta
            ? BetaResponseShellCallOutputContentWsDelta!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseShellCallOutputContentWsDelta' but the value was {ToString()}.");

        /// <summary>
        /// A streaming event that indicated shell call output was completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDone2>? BetaResponseShellCallOutputContentWsDone { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDone2>? BetaResponseShellCallOutputContentWsDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseShellCallOutputContentWsDone))]
#endif
        public bool IsBetaResponseShellCallOutputContentWsDone => BetaResponseShellCallOutputContentWsDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseShellCallOutputContentWsDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDone2>? value)
        {
            value = BetaResponseShellCallOutputContentWsDone;
            return IsBetaResponseShellCallOutputContentWsDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDone2> PickBetaResponseShellCallOutputContentWsDone() => IsBetaResponseShellCallOutputContentWsDone
            ? BetaResponseShellCallOutputContentWsDone!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseShellCallOutputContentWsDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when the response is in progress.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseInWsProgress2>? BetaResponseInWsProgress { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseInWsProgress2>? BetaResponseInWsProgress { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseInWsProgress))]
#endif
        public bool IsBetaResponseInWsProgress => BetaResponseInWsProgress != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseInWsProgress(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseInWsProgress2>? value)
        {
            value = BetaResponseInWsProgress;
            return IsBetaResponseInWsProgress;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseInWsProgress2> PickBetaResponseInWsProgress() => IsBetaResponseInWsProgress
            ? BetaResponseInWsProgress!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseInWsProgress' but the value was {ToString()}.");

        /// <summary>
        /// An event that is emitted when a response fails.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsFailed2>? BetaResponseWsFailed { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsFailed2>? BetaResponseWsFailed { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseWsFailed))]
#endif
        public bool IsBetaResponseWsFailed => BetaResponseWsFailed != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseWsFailed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsFailed2>? value)
        {
            value = BetaResponseWsFailed;
            return IsBetaResponseWsFailed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsFailed2> PickBetaResponseWsFailed() => IsBetaResponseWsFailed
            ? BetaResponseWsFailed!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseWsFailed' but the value was {ToString()}.");

        /// <summary>
        /// An event that is emitted when a response finishes as incomplete.<br/>
        /// Over WebSocket, steering can finish a response with<br/>
        /// `response.incomplete_details.reason` set to `steered`, followed automatically<br/>
        /// by a successor `response.created` that commits the queued steering input.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseIncompleteEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsIncomplete2>? BetaResponseWsIncomplete { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseIncompleteEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsIncomplete2>? BetaResponseWsIncomplete { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseWsIncomplete))]
#endif
        public bool IsBetaResponseWsIncomplete => BetaResponseWsIncomplete != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseWsIncomplete(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseIncompleteEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsIncomplete2>? value)
        {
            value = BetaResponseWsIncomplete;
            return IsBetaResponseWsIncomplete;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseIncompleteEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsIncomplete2> PickBetaResponseWsIncomplete() => IsBetaResponseWsIncomplete
            ? BetaResponseWsIncomplete!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseWsIncomplete' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a new output item is added.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsAdded2>? BetaResponseOutputItemWsAdded { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsAdded2>? BetaResponseOutputItemWsAdded { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseOutputItemWsAdded))]
#endif
        public bool IsBetaResponseOutputItemWsAdded => BetaResponseOutputItemWsAdded != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseOutputItemWsAdded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsAdded2>? value)
        {
            value = BetaResponseOutputItemWsAdded;
            return IsBetaResponseOutputItemWsAdded;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsAdded2> PickBetaResponseOutputItemWsAdded() => IsBetaResponseOutputItemWsAdded
            ? BetaResponseOutputItemWsAdded!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseOutputItemWsAdded' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when an output item is marked done.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsDone2>? BetaResponseOutputItemWsDone { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsDone2>? BetaResponseOutputItemWsDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseOutputItemWsDone))]
#endif
        public bool IsBetaResponseOutputItemWsDone => BetaResponseOutputItemWsDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseOutputItemWsDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsDone2>? value)
        {
            value = BetaResponseOutputItemWsDone;
            return IsBetaResponseOutputItemWsDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsDone2> PickBetaResponseOutputItemWsDone() => IsBetaResponseOutputItemWsDone
            ? BetaResponseOutputItemWsDone!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseOutputItemWsDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a new reasoning summary part is added.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsAdded2>? BetaResponseReasoningSummaryPartWsAdded { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsAdded2>? BetaResponseReasoningSummaryPartWsAdded { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseReasoningSummaryPartWsAdded))]
#endif
        public bool IsBetaResponseReasoningSummaryPartWsAdded => BetaResponseReasoningSummaryPartWsAdded != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseReasoningSummaryPartWsAdded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsAdded2>? value)
        {
            value = BetaResponseReasoningSummaryPartWsAdded;
            return IsBetaResponseReasoningSummaryPartWsAdded;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsAdded2> PickBetaResponseReasoningSummaryPartWsAdded() => IsBetaResponseReasoningSummaryPartWsAdded
            ? BetaResponseReasoningSummaryPartWsAdded!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseReasoningSummaryPartWsAdded' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a reasoning summary part is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsDone2>? BetaResponseReasoningSummaryPartWsDone { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsDone2>? BetaResponseReasoningSummaryPartWsDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseReasoningSummaryPartWsDone))]
#endif
        public bool IsBetaResponseReasoningSummaryPartWsDone => BetaResponseReasoningSummaryPartWsDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseReasoningSummaryPartWsDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsDone2>? value)
        {
            value = BetaResponseReasoningSummaryPartWsDone;
            return IsBetaResponseReasoningSummaryPartWsDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsDone2> PickBetaResponseReasoningSummaryPartWsDone() => IsBetaResponseReasoningSummaryPartWsDone
            ? BetaResponseReasoningSummaryPartWsDone!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseReasoningSummaryPartWsDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a delta is added to a reasoning summary text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDelta2>? BetaResponseReasoningSummaryTextWsDelta { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDelta2>? BetaResponseReasoningSummaryTextWsDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseReasoningSummaryTextWsDelta))]
#endif
        public bool IsBetaResponseReasoningSummaryTextWsDelta => BetaResponseReasoningSummaryTextWsDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseReasoningSummaryTextWsDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDelta2>? value)
        {
            value = BetaResponseReasoningSummaryTextWsDelta;
            return IsBetaResponseReasoningSummaryTextWsDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDelta2> PickBetaResponseReasoningSummaryTextWsDelta() => IsBetaResponseReasoningSummaryTextWsDelta
            ? BetaResponseReasoningSummaryTextWsDelta!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseReasoningSummaryTextWsDelta' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a reasoning summary text is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDone2>? BetaResponseReasoningSummaryTextWsDone { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDone2>? BetaResponseReasoningSummaryTextWsDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseReasoningSummaryTextWsDone))]
#endif
        public bool IsBetaResponseReasoningSummaryTextWsDone => BetaResponseReasoningSummaryTextWsDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseReasoningSummaryTextWsDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDone2>? value)
        {
            value = BetaResponseReasoningSummaryTextWsDone;
            return IsBetaResponseReasoningSummaryTextWsDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDone2> PickBetaResponseReasoningSummaryTextWsDone() => IsBetaResponseReasoningSummaryTextWsDone
            ? BetaResponseReasoningSummaryTextWsDone!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseReasoningSummaryTextWsDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a delta is added to a reasoning text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDelta2>? BetaResponseReasoningTextWsDelta { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDelta2>? BetaResponseReasoningTextWsDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseReasoningTextWsDelta))]
#endif
        public bool IsBetaResponseReasoningTextWsDelta => BetaResponseReasoningTextWsDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseReasoningTextWsDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDelta2>? value)
        {
            value = BetaResponseReasoningTextWsDelta;
            return IsBetaResponseReasoningTextWsDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDelta2> PickBetaResponseReasoningTextWsDelta() => IsBetaResponseReasoningTextWsDelta
            ? BetaResponseReasoningTextWsDelta!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseReasoningTextWsDelta' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a reasoning text is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDone2>? BetaResponseReasoningTextWsDone { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDone2>? BetaResponseReasoningTextWsDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseReasoningTextWsDone))]
#endif
        public bool IsBetaResponseReasoningTextWsDone => BetaResponseReasoningTextWsDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseReasoningTextWsDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDone2>? value)
        {
            value = BetaResponseReasoningTextWsDone;
            return IsBetaResponseReasoningTextWsDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDone2> PickBetaResponseReasoningTextWsDone() => IsBetaResponseReasoningTextWsDone
            ? BetaResponseReasoningTextWsDone!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseReasoningTextWsDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when there is a partial refusal text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDelta2>? BetaResponseRefusalWsDelta { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDelta2>? BetaResponseRefusalWsDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseRefusalWsDelta))]
#endif
        public bool IsBetaResponseRefusalWsDelta => BetaResponseRefusalWsDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseRefusalWsDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDelta2>? value)
        {
            value = BetaResponseRefusalWsDelta;
            return IsBetaResponseRefusalWsDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDelta2> PickBetaResponseRefusalWsDelta() => IsBetaResponseRefusalWsDelta
            ? BetaResponseRefusalWsDelta!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseRefusalWsDelta' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when refusal text is finalized.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDone2>? BetaResponseRefusalWsDone { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDone2>? BetaResponseRefusalWsDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseRefusalWsDone))]
#endif
        public bool IsBetaResponseRefusalWsDone => BetaResponseRefusalWsDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseRefusalWsDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDone2>? value)
        {
            value = BetaResponseRefusalWsDone;
            return IsBetaResponseRefusalWsDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDone2> PickBetaResponseRefusalWsDone() => IsBetaResponseRefusalWsDone
            ? BetaResponseRefusalWsDone!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseRefusalWsDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when there is an additional text delta.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDelta2>? BetaResponseTextWsDelta { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDelta2>? BetaResponseTextWsDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseTextWsDelta))]
#endif
        public bool IsBetaResponseTextWsDelta => BetaResponseTextWsDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseTextWsDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDelta2>? value)
        {
            value = BetaResponseTextWsDelta;
            return IsBetaResponseTextWsDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDelta2> PickBetaResponseTextWsDelta() => IsBetaResponseTextWsDelta
            ? BetaResponseTextWsDelta!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseTextWsDelta' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when text content is finalized.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDone2>? BetaResponseTextWsDone { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDone2>? BetaResponseTextWsDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseTextWsDone))]
#endif
        public bool IsBetaResponseTextWsDone => BetaResponseTextWsDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseTextWsDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDone2>? value)
        {
            value = BetaResponseTextWsDone;
            return IsBetaResponseTextWsDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDone2> PickBetaResponseTextWsDone() => IsBetaResponseTextWsDone
            ? BetaResponseTextWsDone!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseTextWsDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a web search call is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsCompleted2>? BetaResponseWebSearchCallWsCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsCompleted2>? BetaResponseWebSearchCallWsCompleted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseWebSearchCallWsCompleted))]
#endif
        public bool IsBetaResponseWebSearchCallWsCompleted => BetaResponseWebSearchCallWsCompleted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseWebSearchCallWsCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsCompleted2>? value)
        {
            value = BetaResponseWebSearchCallWsCompleted;
            return IsBetaResponseWebSearchCallWsCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsCompleted2> PickBetaResponseWebSearchCallWsCompleted() => IsBetaResponseWebSearchCallWsCompleted
            ? BetaResponseWebSearchCallWsCompleted!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseWebSearchCallWsCompleted' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a web search call is initiated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallInWsProgress2>? BetaResponseWebSearchCallInWsProgress { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallInWsProgress2>? BetaResponseWebSearchCallInWsProgress { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseWebSearchCallInWsProgress))]
#endif
        public bool IsBetaResponseWebSearchCallInWsProgress => BetaResponseWebSearchCallInWsProgress != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseWebSearchCallInWsProgress(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallInWsProgress2>? value)
        {
            value = BetaResponseWebSearchCallInWsProgress;
            return IsBetaResponseWebSearchCallInWsProgress;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallInWsProgress2> PickBetaResponseWebSearchCallInWsProgress() => IsBetaResponseWebSearchCallInWsProgress
            ? BetaResponseWebSearchCallInWsProgress!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseWebSearchCallInWsProgress' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a web search call is executing.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsSearching2>? BetaResponseWebSearchCallWsSearching { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsSearching2>? BetaResponseWebSearchCallWsSearching { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseWebSearchCallWsSearching))]
#endif
        public bool IsBetaResponseWebSearchCallWsSearching => BetaResponseWebSearchCallWsSearching != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseWebSearchCallWsSearching(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsSearching2>? value)
        {
            value = BetaResponseWebSearchCallWsSearching;
            return IsBetaResponseWebSearchCallWsSearching;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsSearching2> PickBetaResponseWebSearchCallWsSearching() => IsBetaResponseWebSearchCallWsSearching
            ? BetaResponseWebSearchCallWsSearching!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseWebSearchCallWsSearching' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when an image generation tool call has completed and the final image is available.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsCompleted2>? BetaResponseImageGenCallWsCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsCompleted2>? BetaResponseImageGenCallWsCompleted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseImageGenCallWsCompleted))]
#endif
        public bool IsBetaResponseImageGenCallWsCompleted => BetaResponseImageGenCallWsCompleted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseImageGenCallWsCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsCompleted2>? value)
        {
            value = BetaResponseImageGenCallWsCompleted;
            return IsBetaResponseImageGenCallWsCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsCompleted2> PickBetaResponseImageGenCallWsCompleted() => IsBetaResponseImageGenCallWsCompleted
            ? BetaResponseImageGenCallWsCompleted!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseImageGenCallWsCompleted' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when an image generation tool call is actively generating an image (intermediate state).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsGenerating2>? BetaResponseImageGenCallWsGenerating { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsGenerating2>? BetaResponseImageGenCallWsGenerating { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseImageGenCallWsGenerating))]
#endif
        public bool IsBetaResponseImageGenCallWsGenerating => BetaResponseImageGenCallWsGenerating != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseImageGenCallWsGenerating(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsGenerating2>? value)
        {
            value = BetaResponseImageGenCallWsGenerating;
            return IsBetaResponseImageGenCallWsGenerating;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsGenerating2> PickBetaResponseImageGenCallWsGenerating() => IsBetaResponseImageGenCallWsGenerating
            ? BetaResponseImageGenCallWsGenerating!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseImageGenCallWsGenerating' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when an image generation tool call is in progress.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallInWsProgress2>? BetaResponseImageGenCallInWsProgress { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallInWsProgress2>? BetaResponseImageGenCallInWsProgress { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseImageGenCallInWsProgress))]
#endif
        public bool IsBetaResponseImageGenCallInWsProgress => BetaResponseImageGenCallInWsProgress != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseImageGenCallInWsProgress(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallInWsProgress2>? value)
        {
            value = BetaResponseImageGenCallInWsProgress;
            return IsBetaResponseImageGenCallInWsProgress;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallInWsProgress2> PickBetaResponseImageGenCallInWsProgress() => IsBetaResponseImageGenCallInWsProgress
            ? BetaResponseImageGenCallInWsProgress!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseImageGenCallInWsProgress' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a partial image is available during image generation streaming.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallPartialWsImage2>? BetaResponseImageGenCallPartialWsImage { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallPartialWsImage2>? BetaResponseImageGenCallPartialWsImage { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseImageGenCallPartialWsImage))]
#endif
        public bool IsBetaResponseImageGenCallPartialWsImage => BetaResponseImageGenCallPartialWsImage != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseImageGenCallPartialWsImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallPartialWsImage2>? value)
        {
            value = BetaResponseImageGenCallPartialWsImage;
            return IsBetaResponseImageGenCallPartialWsImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallPartialWsImage2> PickBetaResponseImageGenCallPartialWsImage() => IsBetaResponseImageGenCallPartialWsImage
            ? BetaResponseImageGenCallPartialWsImage!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseImageGenCallPartialWsImage' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when there is a delta (partial update) to the arguments of an MCP tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDelta2>? BetaResponseMcpCallArgumentsWsDelta { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDelta2>? BetaResponseMcpCallArgumentsWsDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseMcpCallArgumentsWsDelta))]
#endif
        public bool IsBetaResponseMcpCallArgumentsWsDelta => BetaResponseMcpCallArgumentsWsDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseMcpCallArgumentsWsDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDelta2>? value)
        {
            value = BetaResponseMcpCallArgumentsWsDelta;
            return IsBetaResponseMcpCallArgumentsWsDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDelta2> PickBetaResponseMcpCallArgumentsWsDelta() => IsBetaResponseMcpCallArgumentsWsDelta
            ? BetaResponseMcpCallArgumentsWsDelta!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseMcpCallArgumentsWsDelta' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when the arguments for an MCP tool call are finalized.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDone2>? BetaResponseMcpCallArgumentsWsDone { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDone2>? BetaResponseMcpCallArgumentsWsDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseMcpCallArgumentsWsDone))]
#endif
        public bool IsBetaResponseMcpCallArgumentsWsDone => BetaResponseMcpCallArgumentsWsDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseMcpCallArgumentsWsDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDone2>? value)
        {
            value = BetaResponseMcpCallArgumentsWsDone;
            return IsBetaResponseMcpCallArgumentsWsDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDone2> PickBetaResponseMcpCallArgumentsWsDone() => IsBetaResponseMcpCallArgumentsWsDone
            ? BetaResponseMcpCallArgumentsWsDone!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseMcpCallArgumentsWsDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when an MCP  tool call has completed successfully.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsCompleted2>? BetaResponseMcpCallWsCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsCompleted2>? BetaResponseMcpCallWsCompleted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseMcpCallWsCompleted))]
#endif
        public bool IsBetaResponseMcpCallWsCompleted => BetaResponseMcpCallWsCompleted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseMcpCallWsCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsCompleted2>? value)
        {
            value = BetaResponseMcpCallWsCompleted;
            return IsBetaResponseMcpCallWsCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsCompleted2> PickBetaResponseMcpCallWsCompleted() => IsBetaResponseMcpCallWsCompleted
            ? BetaResponseMcpCallWsCompleted!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseMcpCallWsCompleted' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when an MCP  tool call has failed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsFailed2>? BetaResponseMcpCallWsFailed { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsFailed2>? BetaResponseMcpCallWsFailed { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseMcpCallWsFailed))]
#endif
        public bool IsBetaResponseMcpCallWsFailed => BetaResponseMcpCallWsFailed != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseMcpCallWsFailed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsFailed2>? value)
        {
            value = BetaResponseMcpCallWsFailed;
            return IsBetaResponseMcpCallWsFailed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsFailed2> PickBetaResponseMcpCallWsFailed() => IsBetaResponseMcpCallWsFailed
            ? BetaResponseMcpCallWsFailed!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseMcpCallWsFailed' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when an MCP  tool call is in progress.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallInWsProgress2>? BetaResponseMcpCallInWsProgress { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallInWsProgress2>? BetaResponseMcpCallInWsProgress { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseMcpCallInWsProgress))]
#endif
        public bool IsBetaResponseMcpCallInWsProgress => BetaResponseMcpCallInWsProgress != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseMcpCallInWsProgress(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallInWsProgress2>? value)
        {
            value = BetaResponseMcpCallInWsProgress;
            return IsBetaResponseMcpCallInWsProgress;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallInWsProgress2> PickBetaResponseMcpCallInWsProgress() => IsBetaResponseMcpCallInWsProgress
            ? BetaResponseMcpCallInWsProgress!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseMcpCallInWsProgress' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when the list of available MCP tools has been successfully retrieved.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsCompleted2>? BetaResponseMcpListToolsWsCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsCompleted2>? BetaResponseMcpListToolsWsCompleted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseMcpListToolsWsCompleted))]
#endif
        public bool IsBetaResponseMcpListToolsWsCompleted => BetaResponseMcpListToolsWsCompleted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseMcpListToolsWsCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsCompleted2>? value)
        {
            value = BetaResponseMcpListToolsWsCompleted;
            return IsBetaResponseMcpListToolsWsCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsCompleted2> PickBetaResponseMcpListToolsWsCompleted() => IsBetaResponseMcpListToolsWsCompleted
            ? BetaResponseMcpListToolsWsCompleted!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseMcpListToolsWsCompleted' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when the attempt to list available MCP tools has failed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsFailed2>? BetaResponseMcpListToolsWsFailed { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsFailed2>? BetaResponseMcpListToolsWsFailed { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseMcpListToolsWsFailed))]
#endif
        public bool IsBetaResponseMcpListToolsWsFailed => BetaResponseMcpListToolsWsFailed != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseMcpListToolsWsFailed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsFailed2>? value)
        {
            value = BetaResponseMcpListToolsWsFailed;
            return IsBetaResponseMcpListToolsWsFailed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsFailed2> PickBetaResponseMcpListToolsWsFailed() => IsBetaResponseMcpListToolsWsFailed
            ? BetaResponseMcpListToolsWsFailed!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseMcpListToolsWsFailed' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when the system is in the process of retrieving the list of available MCP tools.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsInWsProgress2>? BetaResponseMcpListToolsInWsProgress { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsInWsProgress2>? BetaResponseMcpListToolsInWsProgress { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseMcpListToolsInWsProgress))]
#endif
        public bool IsBetaResponseMcpListToolsInWsProgress => BetaResponseMcpListToolsInWsProgress != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseMcpListToolsInWsProgress(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsInWsProgress2>? value)
        {
            value = BetaResponseMcpListToolsInWsProgress;
            return IsBetaResponseMcpListToolsInWsProgress;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsInWsProgress2> PickBetaResponseMcpListToolsInWsProgress() => IsBetaResponseMcpListToolsInWsProgress
            ? BetaResponseMcpListToolsInWsProgress!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseMcpListToolsInWsProgress' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when an annotation is added to output text content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputTextAnnotationWsAdded2>? BetaResponseOutputTextAnnotationWsAdded { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputTextAnnotationWsAdded2>? BetaResponseOutputTextAnnotationWsAdded { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseOutputTextAnnotationWsAdded))]
#endif
        public bool IsBetaResponseOutputTextAnnotationWsAdded => BetaResponseOutputTextAnnotationWsAdded != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseOutputTextAnnotationWsAdded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputTextAnnotationWsAdded2>? value)
        {
            value = BetaResponseOutputTextAnnotationWsAdded;
            return IsBetaResponseOutputTextAnnotationWsAdded;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputTextAnnotationWsAdded2> PickBetaResponseOutputTextAnnotationWsAdded() => IsBetaResponseOutputTextAnnotationWsAdded
            ? BetaResponseOutputTextAnnotationWsAdded!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseOutputTextAnnotationWsAdded' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a response is queued and waiting to be processed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseQueuedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsQueued2>? BetaResponseWsQueued { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseQueuedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsQueued2>? BetaResponseWsQueued { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseWsQueued))]
#endif
        public bool IsBetaResponseWsQueued => BetaResponseWsQueued != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseWsQueued(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseQueuedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsQueued2>? value)
        {
            value = BetaResponseWsQueued;
            return IsBetaResponseWsQueued;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseQueuedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsQueued2> PickBetaResponseWsQueued() => IsBetaResponseWsQueued
            ? BetaResponseWsQueued!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseWsQueued' but the value was {ToString()}.");

        /// <summary>
        /// Event representing a delta (partial update) to the input of a custom tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDelta2>? BetaResponseCustomToolCallInputWsDelta { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDelta2>? BetaResponseCustomToolCallInputWsDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseCustomToolCallInputWsDelta))]
#endif
        public bool IsBetaResponseCustomToolCallInputWsDelta => BetaResponseCustomToolCallInputWsDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseCustomToolCallInputWsDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDelta2>? value)
        {
            value = BetaResponseCustomToolCallInputWsDelta;
            return IsBetaResponseCustomToolCallInputWsDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDelta2> PickBetaResponseCustomToolCallInputWsDelta() => IsBetaResponseCustomToolCallInputWsDelta
            ? BetaResponseCustomToolCallInputWsDelta!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseCustomToolCallInputWsDelta' but the value was {ToString()}.");

        /// <summary>
        /// Event indicating that input for a custom tool call is complete.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDone2>? BetaResponseCustomToolCallInputWsDone { get; init; }
#else
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDone2>? BetaResponseCustomToolCallInputWsDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseCustomToolCallInputWsDone))]
#endif
        public bool IsBetaResponseCustomToolCallInputWsDone => BetaResponseCustomToolCallInputWsDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseCustomToolCallInputWsDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDone2>? value)
        {
            value = BetaResponseCustomToolCallInputWsDone;
            return IsBetaResponseCustomToolCallInputWsDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDone2> PickBetaResponseCustomToolCallInputWsDone() => IsBetaResponseCustomToolCallInputWsDone
            ? BetaResponseCustomToolCallInputWsDone!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseCustomToolCallInputWsDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when an error occurs while processing a Responses WebSocket request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseWsError? Error { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseWsError? Error { get; }
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
            out global::tryAGI.OpenAI.BetaResponseWsError? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseWsError PickError() => IsError
            ? Error!
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
        public global::tryAGI.OpenAI.BetaResponseSteerAcceptedEvent? ResponseSteerAccepted { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseSteerAcceptedEvent? ResponseSteerAccepted { get; }
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
            out global::tryAGI.OpenAI.BetaResponseSteerAcceptedEvent? value)
        {
            value = ResponseSteerAccepted;
            return IsResponseSteerAccepted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerAcceptedEvent PickResponseSteerAccepted() => IsResponseSteerAccepted
            ? ResponseSteerAccepted!
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
        public global::tryAGI.OpenAI.BetaResponseSteerPendingEvent? ResponseSteerPending { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseSteerPendingEvent? ResponseSteerPending { get; }
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
            out global::tryAGI.OpenAI.BetaResponseSteerPendingEvent? value)
        {
            value = ResponseSteerPending;
            return IsResponseSteerPending;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerPendingEvent PickResponseSteerPending() => IsResponseSteerPending
            ? ResponseSteerPending!
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
        public global::tryAGI.OpenAI.BetaResponseSteerFailedEvent? ResponseSteerFailed { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseSteerFailedEvent? ResponseSteerFailed { get; }
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
            out global::tryAGI.OpenAI.BetaResponseSteerFailedEvent? value)
        {
            value = ResponseSteerFailed;
            return IsResponseSteerFailed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerFailedEvent PickResponseSteerFailed() => IsResponseSteerFailed
            ? ResponseSteerFailed!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseSteerFailed' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when all injected input items were validated and committed to the<br/>
        /// active response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent? ResponseInjectCreated { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent? ResponseInjectCreated { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseInjectCreated))]
#endif
        public bool IsResponseInjectCreated => ResponseInjectCreated != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseInjectCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent? value)
        {
            value = ResponseInjectCreated;
            return IsResponseInjectCreated;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent PickResponseInjectCreated() => IsResponseInjectCreated
            ? ResponseInjectCreated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseInjectCreated' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when injected input could not be committed to a response. The event<br/>
        /// returns the uncommitted raw input so the client can retry it in another<br/>
        /// response when appropriate.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseInjectFailedEvent? ResponseInjectFailed { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseInjectFailedEvent? ResponseInjectFailed { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseInjectFailed))]
#endif
        public bool IsResponseInjectFailed => ResponseInjectFailed != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseInjectFailed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaResponseInjectFailedEvent? value)
        {
            value = ResponseInjectFailed;
            return IsResponseInjectFailed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInjectFailedEvent PickResponseInjectFailed() => IsResponseInjectFailed
            ? ResponseInjectFailed!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseInjectFailed' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDelta2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDelta2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDelta2>?(BetaResponsesServerEvent @this) => @this.BetaResponseAudioWsDelta;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDelta2>? value)
        {
            BetaResponseAudioWsDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseAudioWsDelta(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDelta2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDone2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDone2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDone2>?(BetaResponsesServerEvent @this) => @this.BetaResponseAudioWsDone;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDone2>? value)
        {
            BetaResponseAudioWsDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseAudioWsDone(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDone2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDelta2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDelta2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDelta2>?(BetaResponsesServerEvent @this) => @this.BetaResponseAudioTranscriptWsDelta;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDelta2>? value)
        {
            BetaResponseAudioTranscriptWsDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseAudioTranscriptWsDelta(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDelta2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDone2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDone2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDone2>?(BetaResponsesServerEvent @this) => @this.BetaResponseAudioTranscriptWsDone;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDone2>? value)
        {
            BetaResponseAudioTranscriptWsDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseAudioTranscriptWsDone(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDone2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDelta2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDelta2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDelta2>?(BetaResponsesServerEvent @this) => @this.BetaResponseCodeInterpreterCallCodeWsDelta;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDelta2>? value)
        {
            BetaResponseCodeInterpreterCallCodeWsDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseCodeInterpreterCallCodeWsDelta(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDelta2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDone2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDone2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDone2>?(BetaResponsesServerEvent @this) => @this.BetaResponseCodeInterpreterCallCodeWsDone;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDone2>? value)
        {
            BetaResponseCodeInterpreterCallCodeWsDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseCodeInterpreterCallCodeWsDone(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDone2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsCompleted2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsCompleted2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsCompleted2>?(BetaResponsesServerEvent @this) => @this.BetaResponseCodeInterpreterCallWsCompleted;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsCompleted2>? value)
        {
            BetaResponseCodeInterpreterCallWsCompleted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseCodeInterpreterCallWsCompleted(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsCompleted2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallInWsProgress2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallInWsProgress2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallInWsProgress2>?(BetaResponsesServerEvent @this) => @this.BetaResponseCodeInterpreterCallInWsProgress;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallInWsProgress2>? value)
        {
            BetaResponseCodeInterpreterCallInWsProgress = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseCodeInterpreterCallInWsProgress(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallInWsProgress2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsInterpreting2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsInterpreting2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsInterpreting2>?(BetaResponsesServerEvent @this) => @this.BetaResponseCodeInterpreterCallWsInterpreting;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsInterpreting2>? value)
        {
            BetaResponseCodeInterpreterCallWsInterpreting = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseCodeInterpreterCallWsInterpreting(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsInterpreting2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCompactionWsCompacting2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCompactionWsCompacting2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCompactionWsCompacting2>?(BetaResponsesServerEvent @this) => @this.BetaResponseCompactionWsCompacting;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCompactionWsCompacting2>? value)
        {
            BetaResponseCompactionWsCompacting = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseCompactionWsCompacting(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCompactionWsCompacting2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCompleted2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCompleted2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCompleted2>?(BetaResponsesServerEvent @this) => @this.BetaResponseWsCompleted;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCompleted2>? value)
        {
            BetaResponseWsCompleted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseWsCompleted(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCompleted2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsAdded2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsAdded2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsAdded2>?(BetaResponsesServerEvent @this) => @this.BetaResponseContentPartWsAdded;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsAdded2>? value)
        {
            BetaResponseContentPartWsAdded = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseContentPartWsAdded(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsAdded2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsDone2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsDone2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsDone2>?(BetaResponsesServerEvent @this) => @this.BetaResponseContentPartWsDone;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsDone2>? value)
        {
            BetaResponseContentPartWsDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseContentPartWsDone(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsDone2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCreatedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCreated2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCreatedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCreated2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCreatedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCreated2>?(BetaResponsesServerEvent @this) => @this.BetaResponseWsCreated;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCreatedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCreated2>? value)
        {
            BetaResponseWsCreated = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseWsCreated(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCreatedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCreated2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsCompleted2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsCompleted2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsCompleted2>?(BetaResponsesServerEvent @this) => @this.BetaResponseFileSearchCallWsCompleted;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsCompleted2>? value)
        {
            BetaResponseFileSearchCallWsCompleted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseFileSearchCallWsCompleted(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsCompleted2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallInWsProgress2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallInWsProgress2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallInWsProgress2>?(BetaResponsesServerEvent @this) => @this.BetaResponseFileSearchCallInWsProgress;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallInWsProgress2>? value)
        {
            BetaResponseFileSearchCallInWsProgress = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseFileSearchCallInWsProgress(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallInWsProgress2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsSearching2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsSearching2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsSearching2>?(BetaResponsesServerEvent @this) => @this.BetaResponseFileSearchCallWsSearching;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsSearching2>? value)
        {
            BetaResponseFileSearchCallWsSearching = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseFileSearchCallWsSearching(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsSearching2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDelta2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDelta2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDelta2>?(BetaResponsesServerEvent @this) => @this.BetaResponseFunctionCallArgumentsWsDelta;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDelta2>? value)
        {
            BetaResponseFunctionCallArgumentsWsDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseFunctionCallArgumentsWsDelta(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDelta2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2>?(BetaResponsesServerEvent @this) => @this.BetaResponseFunctionCallArgumentsWsDone;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2>? value)
        {
            BetaResponseFunctionCallArgumentsWsDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseFunctionCallArgumentsWsDone(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsAdded2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsAdded2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsAdded2>?(BetaResponsesServerEvent @this) => @this.BetaResponseShellCallCommandWsAdded;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsAdded2>? value)
        {
            BetaResponseShellCallCommandWsAdded = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseShellCallCommandWsAdded(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsAdded2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDelta2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDelta2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDelta2>?(BetaResponsesServerEvent @this) => @this.BetaResponseShellCallCommandWsDelta;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDelta2>? value)
        {
            BetaResponseShellCallCommandWsDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseShellCallCommandWsDelta(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDelta2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDone2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDone2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDone2>?(BetaResponsesServerEvent @this) => @this.BetaResponseShellCallCommandWsDone;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDone2>? value)
        {
            BetaResponseShellCallCommandWsDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseShellCallCommandWsDone(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDone2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDelta2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDelta2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDelta2>?(BetaResponsesServerEvent @this) => @this.BetaResponseShellCallOutputContentWsDelta;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDelta2>? value)
        {
            BetaResponseShellCallOutputContentWsDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseShellCallOutputContentWsDelta(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDelta2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDone2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDone2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDone2>?(BetaResponsesServerEvent @this) => @this.BetaResponseShellCallOutputContentWsDone;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDone2>? value)
        {
            BetaResponseShellCallOutputContentWsDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseShellCallOutputContentWsDone(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDone2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseInWsProgress2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseInWsProgress2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseInWsProgress2>?(BetaResponsesServerEvent @this) => @this.BetaResponseInWsProgress;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseInWsProgress2>? value)
        {
            BetaResponseInWsProgress = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseInWsProgress(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseInWsProgress2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsFailed2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsFailed2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsFailed2>?(BetaResponsesServerEvent @this) => @this.BetaResponseWsFailed;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsFailed2>? value)
        {
            BetaResponseWsFailed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseWsFailed(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsFailed2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseIncompleteEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsIncomplete2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseIncompleteEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsIncomplete2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseIncompleteEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsIncomplete2>?(BetaResponsesServerEvent @this) => @this.BetaResponseWsIncomplete;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseIncompleteEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsIncomplete2>? value)
        {
            BetaResponseWsIncomplete = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseWsIncomplete(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseIncompleteEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsIncomplete2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsAdded2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsAdded2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsAdded2>?(BetaResponsesServerEvent @this) => @this.BetaResponseOutputItemWsAdded;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsAdded2>? value)
        {
            BetaResponseOutputItemWsAdded = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseOutputItemWsAdded(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsAdded2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsDone2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsDone2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsDone2>?(BetaResponsesServerEvent @this) => @this.BetaResponseOutputItemWsDone;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsDone2>? value)
        {
            BetaResponseOutputItemWsDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseOutputItemWsDone(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsDone2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsAdded2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsAdded2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsAdded2>?(BetaResponsesServerEvent @this) => @this.BetaResponseReasoningSummaryPartWsAdded;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsAdded2>? value)
        {
            BetaResponseReasoningSummaryPartWsAdded = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseReasoningSummaryPartWsAdded(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsAdded2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsDone2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsDone2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsDone2>?(BetaResponsesServerEvent @this) => @this.BetaResponseReasoningSummaryPartWsDone;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsDone2>? value)
        {
            BetaResponseReasoningSummaryPartWsDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseReasoningSummaryPartWsDone(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsDone2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDelta2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDelta2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDelta2>?(BetaResponsesServerEvent @this) => @this.BetaResponseReasoningSummaryTextWsDelta;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDelta2>? value)
        {
            BetaResponseReasoningSummaryTextWsDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseReasoningSummaryTextWsDelta(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDelta2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDone2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDone2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDone2>?(BetaResponsesServerEvent @this) => @this.BetaResponseReasoningSummaryTextWsDone;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDone2>? value)
        {
            BetaResponseReasoningSummaryTextWsDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseReasoningSummaryTextWsDone(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDone2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDelta2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDelta2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDelta2>?(BetaResponsesServerEvent @this) => @this.BetaResponseReasoningTextWsDelta;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDelta2>? value)
        {
            BetaResponseReasoningTextWsDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseReasoningTextWsDelta(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDelta2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDone2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDone2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDone2>?(BetaResponsesServerEvent @this) => @this.BetaResponseReasoningTextWsDone;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDone2>? value)
        {
            BetaResponseReasoningTextWsDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseReasoningTextWsDone(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDone2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDelta2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDelta2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDelta2>?(BetaResponsesServerEvent @this) => @this.BetaResponseRefusalWsDelta;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDelta2>? value)
        {
            BetaResponseRefusalWsDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseRefusalWsDelta(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDelta2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDone2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDone2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDone2>?(BetaResponsesServerEvent @this) => @this.BetaResponseRefusalWsDone;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDone2>? value)
        {
            BetaResponseRefusalWsDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseRefusalWsDone(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDone2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDelta2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDelta2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDelta2>?(BetaResponsesServerEvent @this) => @this.BetaResponseTextWsDelta;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDelta2>? value)
        {
            BetaResponseTextWsDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseTextWsDelta(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDelta2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDone2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDone2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDone2>?(BetaResponsesServerEvent @this) => @this.BetaResponseTextWsDone;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDone2>? value)
        {
            BetaResponseTextWsDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseTextWsDone(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDone2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsCompleted2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsCompleted2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsCompleted2>?(BetaResponsesServerEvent @this) => @this.BetaResponseWebSearchCallWsCompleted;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsCompleted2>? value)
        {
            BetaResponseWebSearchCallWsCompleted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseWebSearchCallWsCompleted(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsCompleted2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallInWsProgress2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallInWsProgress2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallInWsProgress2>?(BetaResponsesServerEvent @this) => @this.BetaResponseWebSearchCallInWsProgress;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallInWsProgress2>? value)
        {
            BetaResponseWebSearchCallInWsProgress = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseWebSearchCallInWsProgress(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallInWsProgress2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsSearching2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsSearching2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsSearching2>?(BetaResponsesServerEvent @this) => @this.BetaResponseWebSearchCallWsSearching;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsSearching2>? value)
        {
            BetaResponseWebSearchCallWsSearching = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseWebSearchCallWsSearching(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsSearching2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsCompleted2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsCompleted2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsCompleted2>?(BetaResponsesServerEvent @this) => @this.BetaResponseImageGenCallWsCompleted;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsCompleted2>? value)
        {
            BetaResponseImageGenCallWsCompleted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseImageGenCallWsCompleted(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsCompleted2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsGenerating2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsGenerating2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsGenerating2>?(BetaResponsesServerEvent @this) => @this.BetaResponseImageGenCallWsGenerating;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsGenerating2>? value)
        {
            BetaResponseImageGenCallWsGenerating = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseImageGenCallWsGenerating(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsGenerating2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallInWsProgress2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallInWsProgress2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallInWsProgress2>?(BetaResponsesServerEvent @this) => @this.BetaResponseImageGenCallInWsProgress;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallInWsProgress2>? value)
        {
            BetaResponseImageGenCallInWsProgress = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseImageGenCallInWsProgress(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallInWsProgress2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallPartialWsImage2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallPartialWsImage2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallPartialWsImage2>?(BetaResponsesServerEvent @this) => @this.BetaResponseImageGenCallPartialWsImage;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallPartialWsImage2>? value)
        {
            BetaResponseImageGenCallPartialWsImage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseImageGenCallPartialWsImage(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallPartialWsImage2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDelta2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDelta2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDelta2>?(BetaResponsesServerEvent @this) => @this.BetaResponseMcpCallArgumentsWsDelta;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDelta2>? value)
        {
            BetaResponseMcpCallArgumentsWsDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseMcpCallArgumentsWsDelta(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDelta2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDone2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDone2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDone2>?(BetaResponsesServerEvent @this) => @this.BetaResponseMcpCallArgumentsWsDone;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDone2>? value)
        {
            BetaResponseMcpCallArgumentsWsDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseMcpCallArgumentsWsDone(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDone2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsCompleted2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsCompleted2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsCompleted2>?(BetaResponsesServerEvent @this) => @this.BetaResponseMcpCallWsCompleted;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsCompleted2>? value)
        {
            BetaResponseMcpCallWsCompleted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseMcpCallWsCompleted(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsCompleted2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsFailed2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsFailed2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsFailed2>?(BetaResponsesServerEvent @this) => @this.BetaResponseMcpCallWsFailed;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsFailed2>? value)
        {
            BetaResponseMcpCallWsFailed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseMcpCallWsFailed(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsFailed2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallInWsProgress2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallInWsProgress2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallInWsProgress2>?(BetaResponsesServerEvent @this) => @this.BetaResponseMcpCallInWsProgress;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallInWsProgress2>? value)
        {
            BetaResponseMcpCallInWsProgress = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseMcpCallInWsProgress(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallInWsProgress2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsCompleted2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsCompleted2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsCompleted2>?(BetaResponsesServerEvent @this) => @this.BetaResponseMcpListToolsWsCompleted;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsCompleted2>? value)
        {
            BetaResponseMcpListToolsWsCompleted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseMcpListToolsWsCompleted(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsCompleted2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsFailed2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsFailed2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsFailed2>?(BetaResponsesServerEvent @this) => @this.BetaResponseMcpListToolsWsFailed;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsFailed2>? value)
        {
            BetaResponseMcpListToolsWsFailed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseMcpListToolsWsFailed(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsFailed2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsInWsProgress2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsInWsProgress2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsInWsProgress2>?(BetaResponsesServerEvent @this) => @this.BetaResponseMcpListToolsInWsProgress;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsInWsProgress2>? value)
        {
            BetaResponseMcpListToolsInWsProgress = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseMcpListToolsInWsProgress(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsInWsProgress2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputTextAnnotationWsAdded2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputTextAnnotationWsAdded2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputTextAnnotationWsAdded2>?(BetaResponsesServerEvent @this) => @this.BetaResponseOutputTextAnnotationWsAdded;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputTextAnnotationWsAdded2>? value)
        {
            BetaResponseOutputTextAnnotationWsAdded = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseOutputTextAnnotationWsAdded(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputTextAnnotationWsAdded2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseQueuedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsQueued2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseQueuedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsQueued2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseQueuedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsQueued2>?(BetaResponsesServerEvent @this) => @this.BetaResponseWsQueued;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseQueuedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsQueued2>? value)
        {
            BetaResponseWsQueued = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseWsQueued(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseQueuedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsQueued2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDelta2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDelta2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDelta2>?(BetaResponsesServerEvent @this) => @this.BetaResponseCustomToolCallInputWsDelta;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDelta2>? value)
        {
            BetaResponseCustomToolCallInputWsDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseCustomToolCallInputWsDelta(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDelta2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDone2> value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDone2>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDone2>?(BetaResponsesServerEvent @this) => @this.BetaResponseCustomToolCallInputWsDone;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDone2>? value)
        {
            BetaResponseCustomToolCallInputWsDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromBetaResponseCustomToolCallInputWsDone(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDone2>? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.BetaResponseWsError value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.BetaResponseWsError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseWsError?(BetaResponsesServerEvent @this) => @this.Error;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.BetaResponseWsError? value)
        {
            Error = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromError(global::tryAGI.OpenAI.BetaResponseWsError? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.BetaResponseSteerAcceptedEvent value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.BetaResponseSteerAcceptedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseSteerAcceptedEvent?(BetaResponsesServerEvent @this) => @this.ResponseSteerAccepted;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.BetaResponseSteerAcceptedEvent? value)
        {
            ResponseSteerAccepted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromResponseSteerAccepted(global::tryAGI.OpenAI.BetaResponseSteerAcceptedEvent? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.BetaResponseSteerPendingEvent value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.BetaResponseSteerPendingEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseSteerPendingEvent?(BetaResponsesServerEvent @this) => @this.ResponseSteerPending;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.BetaResponseSteerPendingEvent? value)
        {
            ResponseSteerPending = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromResponseSteerPending(global::tryAGI.OpenAI.BetaResponseSteerPendingEvent? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.BetaResponseSteerFailedEvent value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.BetaResponseSteerFailedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseSteerFailedEvent?(BetaResponsesServerEvent @this) => @this.ResponseSteerFailed;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.BetaResponseSteerFailedEvent? value)
        {
            ResponseSteerFailed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromResponseSteerFailed(global::tryAGI.OpenAI.BetaResponseSteerFailedEvent? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent?(BetaResponsesServerEvent @this) => @this.ResponseInjectCreated;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent? value)
        {
            ResponseInjectCreated = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromResponseInjectCreated(global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.BetaResponseInjectFailedEvent value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.BetaResponseInjectFailedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseInjectFailedEvent?(BetaResponsesServerEvent @this) => @this.ResponseInjectFailed;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.BetaResponseInjectFailedEvent? value)
        {
            ResponseInjectFailed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesServerEvent FromResponseInjectFailed(global::tryAGI.OpenAI.BetaResponseInjectFailedEvent? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesServerEvent(
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDelta2>? betaResponseAudioWsDelta,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDone2>? betaResponseAudioWsDone,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDelta2>? betaResponseAudioTranscriptWsDelta,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDone2>? betaResponseAudioTranscriptWsDone,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDelta2>? betaResponseCodeInterpreterCallCodeWsDelta,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDone2>? betaResponseCodeInterpreterCallCodeWsDone,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsCompleted2>? betaResponseCodeInterpreterCallWsCompleted,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallInWsProgress2>? betaResponseCodeInterpreterCallInWsProgress,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsInterpreting2>? betaResponseCodeInterpreterCallWsInterpreting,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCompactionWsCompacting2>? betaResponseCompactionWsCompacting,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCompleted2>? betaResponseWsCompleted,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsAdded2>? betaResponseContentPartWsAdded,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsDone2>? betaResponseContentPartWsDone,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCreatedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCreated2>? betaResponseWsCreated,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsCompleted2>? betaResponseFileSearchCallWsCompleted,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallInWsProgress2>? betaResponseFileSearchCallInWsProgress,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsSearching2>? betaResponseFileSearchCallWsSearching,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDelta2>? betaResponseFunctionCallArgumentsWsDelta,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2>? betaResponseFunctionCallArgumentsWsDone,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsAdded2>? betaResponseShellCallCommandWsAdded,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDelta2>? betaResponseShellCallCommandWsDelta,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDone2>? betaResponseShellCallCommandWsDone,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDelta2>? betaResponseShellCallOutputContentWsDelta,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDone2>? betaResponseShellCallOutputContentWsDone,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseInWsProgress2>? betaResponseInWsProgress,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsFailed2>? betaResponseWsFailed,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseIncompleteEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsIncomplete2>? betaResponseWsIncomplete,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsAdded2>? betaResponseOutputItemWsAdded,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsDone2>? betaResponseOutputItemWsDone,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsAdded2>? betaResponseReasoningSummaryPartWsAdded,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsDone2>? betaResponseReasoningSummaryPartWsDone,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDelta2>? betaResponseReasoningSummaryTextWsDelta,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDone2>? betaResponseReasoningSummaryTextWsDone,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDelta2>? betaResponseReasoningTextWsDelta,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDone2>? betaResponseReasoningTextWsDone,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDelta2>? betaResponseRefusalWsDelta,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDone2>? betaResponseRefusalWsDone,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDelta2>? betaResponseTextWsDelta,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDone2>? betaResponseTextWsDone,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsCompleted2>? betaResponseWebSearchCallWsCompleted,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallInWsProgress2>? betaResponseWebSearchCallInWsProgress,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsSearching2>? betaResponseWebSearchCallWsSearching,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsCompleted2>? betaResponseImageGenCallWsCompleted,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsGenerating2>? betaResponseImageGenCallWsGenerating,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallInWsProgress2>? betaResponseImageGenCallInWsProgress,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallPartialWsImage2>? betaResponseImageGenCallPartialWsImage,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDelta2>? betaResponseMcpCallArgumentsWsDelta,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDone2>? betaResponseMcpCallArgumentsWsDone,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsCompleted2>? betaResponseMcpCallWsCompleted,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsFailed2>? betaResponseMcpCallWsFailed,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallInWsProgress2>? betaResponseMcpCallInWsProgress,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsCompleted2>? betaResponseMcpListToolsWsCompleted,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsFailed2>? betaResponseMcpListToolsWsFailed,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsInWsProgress2>? betaResponseMcpListToolsInWsProgress,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputTextAnnotationWsAdded2>? betaResponseOutputTextAnnotationWsAdded,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseQueuedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsQueued2>? betaResponseWsQueued,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDelta2>? betaResponseCustomToolCallInputWsDelta,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDone2>? betaResponseCustomToolCallInputWsDone,
            global::tryAGI.OpenAI.BetaResponseWsError? error,
            global::tryAGI.OpenAI.BetaResponseSteerAcceptedEvent? responseSteerAccepted,
            global::tryAGI.OpenAI.BetaResponseSteerPendingEvent? responseSteerPending,
            global::tryAGI.OpenAI.BetaResponseSteerFailedEvent? responseSteerFailed,
            global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent? responseInjectCreated,
            global::tryAGI.OpenAI.BetaResponseInjectFailedEvent? responseInjectFailed
            )
        {
            BetaResponseAudioWsDelta = betaResponseAudioWsDelta;
            BetaResponseAudioWsDone = betaResponseAudioWsDone;
            BetaResponseAudioTranscriptWsDelta = betaResponseAudioTranscriptWsDelta;
            BetaResponseAudioTranscriptWsDone = betaResponseAudioTranscriptWsDone;
            BetaResponseCodeInterpreterCallCodeWsDelta = betaResponseCodeInterpreterCallCodeWsDelta;
            BetaResponseCodeInterpreterCallCodeWsDone = betaResponseCodeInterpreterCallCodeWsDone;
            BetaResponseCodeInterpreterCallWsCompleted = betaResponseCodeInterpreterCallWsCompleted;
            BetaResponseCodeInterpreterCallInWsProgress = betaResponseCodeInterpreterCallInWsProgress;
            BetaResponseCodeInterpreterCallWsInterpreting = betaResponseCodeInterpreterCallWsInterpreting;
            BetaResponseCompactionWsCompacting = betaResponseCompactionWsCompacting;
            BetaResponseWsCompleted = betaResponseWsCompleted;
            BetaResponseContentPartWsAdded = betaResponseContentPartWsAdded;
            BetaResponseContentPartWsDone = betaResponseContentPartWsDone;
            BetaResponseWsCreated = betaResponseWsCreated;
            BetaResponseFileSearchCallWsCompleted = betaResponseFileSearchCallWsCompleted;
            BetaResponseFileSearchCallInWsProgress = betaResponseFileSearchCallInWsProgress;
            BetaResponseFileSearchCallWsSearching = betaResponseFileSearchCallWsSearching;
            BetaResponseFunctionCallArgumentsWsDelta = betaResponseFunctionCallArgumentsWsDelta;
            BetaResponseFunctionCallArgumentsWsDone = betaResponseFunctionCallArgumentsWsDone;
            BetaResponseShellCallCommandWsAdded = betaResponseShellCallCommandWsAdded;
            BetaResponseShellCallCommandWsDelta = betaResponseShellCallCommandWsDelta;
            BetaResponseShellCallCommandWsDone = betaResponseShellCallCommandWsDone;
            BetaResponseShellCallOutputContentWsDelta = betaResponseShellCallOutputContentWsDelta;
            BetaResponseShellCallOutputContentWsDone = betaResponseShellCallOutputContentWsDone;
            BetaResponseInWsProgress = betaResponseInWsProgress;
            BetaResponseWsFailed = betaResponseWsFailed;
            BetaResponseWsIncomplete = betaResponseWsIncomplete;
            BetaResponseOutputItemWsAdded = betaResponseOutputItemWsAdded;
            BetaResponseOutputItemWsDone = betaResponseOutputItemWsDone;
            BetaResponseReasoningSummaryPartWsAdded = betaResponseReasoningSummaryPartWsAdded;
            BetaResponseReasoningSummaryPartWsDone = betaResponseReasoningSummaryPartWsDone;
            BetaResponseReasoningSummaryTextWsDelta = betaResponseReasoningSummaryTextWsDelta;
            BetaResponseReasoningSummaryTextWsDone = betaResponseReasoningSummaryTextWsDone;
            BetaResponseReasoningTextWsDelta = betaResponseReasoningTextWsDelta;
            BetaResponseReasoningTextWsDone = betaResponseReasoningTextWsDone;
            BetaResponseRefusalWsDelta = betaResponseRefusalWsDelta;
            BetaResponseRefusalWsDone = betaResponseRefusalWsDone;
            BetaResponseTextWsDelta = betaResponseTextWsDelta;
            BetaResponseTextWsDone = betaResponseTextWsDone;
            BetaResponseWebSearchCallWsCompleted = betaResponseWebSearchCallWsCompleted;
            BetaResponseWebSearchCallInWsProgress = betaResponseWebSearchCallInWsProgress;
            BetaResponseWebSearchCallWsSearching = betaResponseWebSearchCallWsSearching;
            BetaResponseImageGenCallWsCompleted = betaResponseImageGenCallWsCompleted;
            BetaResponseImageGenCallWsGenerating = betaResponseImageGenCallWsGenerating;
            BetaResponseImageGenCallInWsProgress = betaResponseImageGenCallInWsProgress;
            BetaResponseImageGenCallPartialWsImage = betaResponseImageGenCallPartialWsImage;
            BetaResponseMcpCallArgumentsWsDelta = betaResponseMcpCallArgumentsWsDelta;
            BetaResponseMcpCallArgumentsWsDone = betaResponseMcpCallArgumentsWsDone;
            BetaResponseMcpCallWsCompleted = betaResponseMcpCallWsCompleted;
            BetaResponseMcpCallWsFailed = betaResponseMcpCallWsFailed;
            BetaResponseMcpCallInWsProgress = betaResponseMcpCallInWsProgress;
            BetaResponseMcpListToolsWsCompleted = betaResponseMcpListToolsWsCompleted;
            BetaResponseMcpListToolsWsFailed = betaResponseMcpListToolsWsFailed;
            BetaResponseMcpListToolsInWsProgress = betaResponseMcpListToolsInWsProgress;
            BetaResponseOutputTextAnnotationWsAdded = betaResponseOutputTextAnnotationWsAdded;
            BetaResponseWsQueued = betaResponseWsQueued;
            BetaResponseCustomToolCallInputWsDelta = betaResponseCustomToolCallInputWsDelta;
            BetaResponseCustomToolCallInputWsDone = betaResponseCustomToolCallInputWsDone;
            Error = error;
            ResponseSteerAccepted = responseSteerAccepted;
            ResponseSteerPending = responseSteerPending;
            ResponseSteerFailed = responseSteerFailed;
            ResponseInjectCreated = responseInjectCreated;
            ResponseInjectFailed = responseInjectFailed;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ResponseInjectFailed as object ??
            ResponseInjectCreated as object ??
            ResponseSteerFailed as object ??
            ResponseSteerPending as object ??
            ResponseSteerAccepted as object ??
            Error as object ??
            BetaResponseCustomToolCallInputWsDone as object ??
            BetaResponseCustomToolCallInputWsDelta as object ??
            BetaResponseWsQueued as object ??
            BetaResponseOutputTextAnnotationWsAdded as object ??
            BetaResponseMcpListToolsInWsProgress as object ??
            BetaResponseMcpListToolsWsFailed as object ??
            BetaResponseMcpListToolsWsCompleted as object ??
            BetaResponseMcpCallInWsProgress as object ??
            BetaResponseMcpCallWsFailed as object ??
            BetaResponseMcpCallWsCompleted as object ??
            BetaResponseMcpCallArgumentsWsDone as object ??
            BetaResponseMcpCallArgumentsWsDelta as object ??
            BetaResponseImageGenCallPartialWsImage as object ??
            BetaResponseImageGenCallInWsProgress as object ??
            BetaResponseImageGenCallWsGenerating as object ??
            BetaResponseImageGenCallWsCompleted as object ??
            BetaResponseWebSearchCallWsSearching as object ??
            BetaResponseWebSearchCallInWsProgress as object ??
            BetaResponseWebSearchCallWsCompleted as object ??
            BetaResponseTextWsDone as object ??
            BetaResponseTextWsDelta as object ??
            BetaResponseRefusalWsDone as object ??
            BetaResponseRefusalWsDelta as object ??
            BetaResponseReasoningTextWsDone as object ??
            BetaResponseReasoningTextWsDelta as object ??
            BetaResponseReasoningSummaryTextWsDone as object ??
            BetaResponseReasoningSummaryTextWsDelta as object ??
            BetaResponseReasoningSummaryPartWsDone as object ??
            BetaResponseReasoningSummaryPartWsAdded as object ??
            BetaResponseOutputItemWsDone as object ??
            BetaResponseOutputItemWsAdded as object ??
            BetaResponseWsIncomplete as object ??
            BetaResponseWsFailed as object ??
            BetaResponseInWsProgress as object ??
            BetaResponseShellCallOutputContentWsDone as object ??
            BetaResponseShellCallOutputContentWsDelta as object ??
            BetaResponseShellCallCommandWsDone as object ??
            BetaResponseShellCallCommandWsDelta as object ??
            BetaResponseShellCallCommandWsAdded as object ??
            BetaResponseFunctionCallArgumentsWsDone as object ??
            BetaResponseFunctionCallArgumentsWsDelta as object ??
            BetaResponseFileSearchCallWsSearching as object ??
            BetaResponseFileSearchCallInWsProgress as object ??
            BetaResponseFileSearchCallWsCompleted as object ??
            BetaResponseWsCreated as object ??
            BetaResponseContentPartWsDone as object ??
            BetaResponseContentPartWsAdded as object ??
            BetaResponseWsCompleted as object ??
            BetaResponseCompactionWsCompacting as object ??
            BetaResponseCodeInterpreterCallWsInterpreting as object ??
            BetaResponseCodeInterpreterCallInWsProgress as object ??
            BetaResponseCodeInterpreterCallWsCompleted as object ??
            BetaResponseCodeInterpreterCallCodeWsDone as object ??
            BetaResponseCodeInterpreterCallCodeWsDelta as object ??
            BetaResponseAudioTranscriptWsDone as object ??
            BetaResponseAudioTranscriptWsDelta as object ??
            BetaResponseAudioWsDone as object ??
            BetaResponseAudioWsDelta as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            BetaResponseAudioWsDelta?.ToString() ??
            BetaResponseAudioWsDone?.ToString() ??
            BetaResponseAudioTranscriptWsDelta?.ToString() ??
            BetaResponseAudioTranscriptWsDone?.ToString() ??
            BetaResponseCodeInterpreterCallCodeWsDelta?.ToString() ??
            BetaResponseCodeInterpreterCallCodeWsDone?.ToString() ??
            BetaResponseCodeInterpreterCallWsCompleted?.ToString() ??
            BetaResponseCodeInterpreterCallInWsProgress?.ToString() ??
            BetaResponseCodeInterpreterCallWsInterpreting?.ToString() ??
            BetaResponseCompactionWsCompacting?.ToString() ??
            BetaResponseWsCompleted?.ToString() ??
            BetaResponseContentPartWsAdded?.ToString() ??
            BetaResponseContentPartWsDone?.ToString() ??
            BetaResponseWsCreated?.ToString() ??
            BetaResponseFileSearchCallWsCompleted?.ToString() ??
            BetaResponseFileSearchCallInWsProgress?.ToString() ??
            BetaResponseFileSearchCallWsSearching?.ToString() ??
            BetaResponseFunctionCallArgumentsWsDelta?.ToString() ??
            BetaResponseFunctionCallArgumentsWsDone?.ToString() ??
            BetaResponseShellCallCommandWsAdded?.ToString() ??
            BetaResponseShellCallCommandWsDelta?.ToString() ??
            BetaResponseShellCallCommandWsDone?.ToString() ??
            BetaResponseShellCallOutputContentWsDelta?.ToString() ??
            BetaResponseShellCallOutputContentWsDone?.ToString() ??
            BetaResponseInWsProgress?.ToString() ??
            BetaResponseWsFailed?.ToString() ??
            BetaResponseWsIncomplete?.ToString() ??
            BetaResponseOutputItemWsAdded?.ToString() ??
            BetaResponseOutputItemWsDone?.ToString() ??
            BetaResponseReasoningSummaryPartWsAdded?.ToString() ??
            BetaResponseReasoningSummaryPartWsDone?.ToString() ??
            BetaResponseReasoningSummaryTextWsDelta?.ToString() ??
            BetaResponseReasoningSummaryTextWsDone?.ToString() ??
            BetaResponseReasoningTextWsDelta?.ToString() ??
            BetaResponseReasoningTextWsDone?.ToString() ??
            BetaResponseRefusalWsDelta?.ToString() ??
            BetaResponseRefusalWsDone?.ToString() ??
            BetaResponseTextWsDelta?.ToString() ??
            BetaResponseTextWsDone?.ToString() ??
            BetaResponseWebSearchCallWsCompleted?.ToString() ??
            BetaResponseWebSearchCallInWsProgress?.ToString() ??
            BetaResponseWebSearchCallWsSearching?.ToString() ??
            BetaResponseImageGenCallWsCompleted?.ToString() ??
            BetaResponseImageGenCallWsGenerating?.ToString() ??
            BetaResponseImageGenCallInWsProgress?.ToString() ??
            BetaResponseImageGenCallPartialWsImage?.ToString() ??
            BetaResponseMcpCallArgumentsWsDelta?.ToString() ??
            BetaResponseMcpCallArgumentsWsDone?.ToString() ??
            BetaResponseMcpCallWsCompleted?.ToString() ??
            BetaResponseMcpCallWsFailed?.ToString() ??
            BetaResponseMcpCallInWsProgress?.ToString() ??
            BetaResponseMcpListToolsWsCompleted?.ToString() ??
            BetaResponseMcpListToolsWsFailed?.ToString() ??
            BetaResponseMcpListToolsInWsProgress?.ToString() ??
            BetaResponseOutputTextAnnotationWsAdded?.ToString() ??
            BetaResponseWsQueued?.ToString() ??
            BetaResponseCustomToolCallInputWsDelta?.ToString() ??
            BetaResponseCustomToolCallInputWsDone?.ToString() ??
            Error?.ToString() ??
            ResponseSteerAccepted?.ToString() ??
            ResponseSteerPending?.ToString() ??
            ResponseSteerFailed?.ToString() ??
            ResponseInjectCreated?.ToString() ??
            ResponseInjectFailed?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBetaResponseAudioWsDelta || IsBetaResponseAudioWsDone || IsBetaResponseAudioTranscriptWsDelta || IsBetaResponseAudioTranscriptWsDone || IsBetaResponseCodeInterpreterCallCodeWsDelta || IsBetaResponseCodeInterpreterCallCodeWsDone || IsBetaResponseCodeInterpreterCallWsCompleted || IsBetaResponseCodeInterpreterCallInWsProgress || IsBetaResponseCodeInterpreterCallWsInterpreting || IsBetaResponseCompactionWsCompacting || IsBetaResponseWsCompleted || IsBetaResponseContentPartWsAdded || IsBetaResponseContentPartWsDone || IsBetaResponseWsCreated || IsBetaResponseFileSearchCallWsCompleted || IsBetaResponseFileSearchCallInWsProgress || IsBetaResponseFileSearchCallWsSearching || IsBetaResponseFunctionCallArgumentsWsDelta || IsBetaResponseFunctionCallArgumentsWsDone || IsBetaResponseShellCallCommandWsAdded || IsBetaResponseShellCallCommandWsDelta || IsBetaResponseShellCallCommandWsDone || IsBetaResponseShellCallOutputContentWsDelta || IsBetaResponseShellCallOutputContentWsDone || IsBetaResponseInWsProgress || IsBetaResponseWsFailed || IsBetaResponseWsIncomplete || IsBetaResponseOutputItemWsAdded || IsBetaResponseOutputItemWsDone || IsBetaResponseReasoningSummaryPartWsAdded || IsBetaResponseReasoningSummaryPartWsDone || IsBetaResponseReasoningSummaryTextWsDelta || IsBetaResponseReasoningSummaryTextWsDone || IsBetaResponseReasoningTextWsDelta || IsBetaResponseReasoningTextWsDone || IsBetaResponseRefusalWsDelta || IsBetaResponseRefusalWsDone || IsBetaResponseTextWsDelta || IsBetaResponseTextWsDone || IsBetaResponseWebSearchCallWsCompleted || IsBetaResponseWebSearchCallInWsProgress || IsBetaResponseWebSearchCallWsSearching || IsBetaResponseImageGenCallWsCompleted || IsBetaResponseImageGenCallWsGenerating || IsBetaResponseImageGenCallInWsProgress || IsBetaResponseImageGenCallPartialWsImage || IsBetaResponseMcpCallArgumentsWsDelta || IsBetaResponseMcpCallArgumentsWsDone || IsBetaResponseMcpCallWsCompleted || IsBetaResponseMcpCallWsFailed || IsBetaResponseMcpCallInWsProgress || IsBetaResponseMcpListToolsWsCompleted || IsBetaResponseMcpListToolsWsFailed || IsBetaResponseMcpListToolsInWsProgress || IsBetaResponseOutputTextAnnotationWsAdded || IsBetaResponseWsQueued || IsBetaResponseCustomToolCallInputWsDelta || IsBetaResponseCustomToolCallInputWsDone || IsError || IsResponseSteerAccepted || IsResponseSteerPending || IsResponseSteerFailed || IsResponseInjectCreated || IsResponseInjectFailed;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDelta2>?, TResult>? betaResponseAudioWsDelta = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDone2>?, TResult>? betaResponseAudioWsDone = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDelta2>?, TResult>? betaResponseAudioTranscriptWsDelta = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDone2>?, TResult>? betaResponseAudioTranscriptWsDone = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDelta2>?, TResult>? betaResponseCodeInterpreterCallCodeWsDelta = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDone2>?, TResult>? betaResponseCodeInterpreterCallCodeWsDone = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsCompleted2>?, TResult>? betaResponseCodeInterpreterCallWsCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallInWsProgress2>?, TResult>? betaResponseCodeInterpreterCallInWsProgress = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsInterpreting2>?, TResult>? betaResponseCodeInterpreterCallWsInterpreting = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCompactionWsCompacting2>?, TResult>? betaResponseCompactionWsCompacting = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCompleted2>?, TResult>? betaResponseWsCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsAdded2>?, TResult>? betaResponseContentPartWsAdded = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsDone2>?, TResult>? betaResponseContentPartWsDone = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCreatedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCreated2>?, TResult>? betaResponseWsCreated = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsCompleted2>?, TResult>? betaResponseFileSearchCallWsCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallInWsProgress2>?, TResult>? betaResponseFileSearchCallInWsProgress = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsSearching2>?, TResult>? betaResponseFileSearchCallWsSearching = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDelta2>?, TResult>? betaResponseFunctionCallArgumentsWsDelta = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2>?, TResult>? betaResponseFunctionCallArgumentsWsDone = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsAdded2>?, TResult>? betaResponseShellCallCommandWsAdded = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDelta2>?, TResult>? betaResponseShellCallCommandWsDelta = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDone2>?, TResult>? betaResponseShellCallCommandWsDone = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDelta2>?, TResult>? betaResponseShellCallOutputContentWsDelta = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDone2>?, TResult>? betaResponseShellCallOutputContentWsDone = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseInWsProgress2>?, TResult>? betaResponseInWsProgress = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsFailed2>?, TResult>? betaResponseWsFailed = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseIncompleteEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsIncomplete2>?, TResult>? betaResponseWsIncomplete = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsAdded2>?, TResult>? betaResponseOutputItemWsAdded = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsDone2>?, TResult>? betaResponseOutputItemWsDone = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsAdded2>?, TResult>? betaResponseReasoningSummaryPartWsAdded = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsDone2>?, TResult>? betaResponseReasoningSummaryPartWsDone = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDelta2>?, TResult>? betaResponseReasoningSummaryTextWsDelta = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDone2>?, TResult>? betaResponseReasoningSummaryTextWsDone = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDelta2>?, TResult>? betaResponseReasoningTextWsDelta = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDone2>?, TResult>? betaResponseReasoningTextWsDone = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDelta2>?, TResult>? betaResponseRefusalWsDelta = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDone2>?, TResult>? betaResponseRefusalWsDone = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDelta2>?, TResult>? betaResponseTextWsDelta = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDone2>?, TResult>? betaResponseTextWsDone = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsCompleted2>?, TResult>? betaResponseWebSearchCallWsCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallInWsProgress2>?, TResult>? betaResponseWebSearchCallInWsProgress = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsSearching2>?, TResult>? betaResponseWebSearchCallWsSearching = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsCompleted2>?, TResult>? betaResponseImageGenCallWsCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsGenerating2>?, TResult>? betaResponseImageGenCallWsGenerating = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallInWsProgress2>?, TResult>? betaResponseImageGenCallInWsProgress = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallPartialWsImage2>?, TResult>? betaResponseImageGenCallPartialWsImage = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDelta2>?, TResult>? betaResponseMcpCallArgumentsWsDelta = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDone2>?, TResult>? betaResponseMcpCallArgumentsWsDone = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsCompleted2>?, TResult>? betaResponseMcpCallWsCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsFailed2>?, TResult>? betaResponseMcpCallWsFailed = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallInWsProgress2>?, TResult>? betaResponseMcpCallInWsProgress = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsCompleted2>?, TResult>? betaResponseMcpListToolsWsCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsFailed2>?, TResult>? betaResponseMcpListToolsWsFailed = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsInWsProgress2>?, TResult>? betaResponseMcpListToolsInWsProgress = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputTextAnnotationWsAdded2>?, TResult>? betaResponseOutputTextAnnotationWsAdded = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseQueuedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsQueued2>?, TResult>? betaResponseWsQueued = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDelta2>?, TResult>? betaResponseCustomToolCallInputWsDelta = null,
            global::System.Func<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDone2>?, TResult>? betaResponseCustomToolCallInputWsDone = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseWsError, TResult>? error = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseSteerAcceptedEvent, TResult>? responseSteerAccepted = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseSteerPendingEvent, TResult>? responseSteerPending = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseSteerFailedEvent, TResult>? responseSteerFailed = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent, TResult>? responseInjectCreated = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseInjectFailedEvent, TResult>? responseInjectFailed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBetaResponseAudioWsDelta && betaResponseAudioWsDelta != null)
            {
                return betaResponseAudioWsDelta(BetaResponseAudioWsDelta!);
            }
            else if (IsBetaResponseAudioWsDone && betaResponseAudioWsDone != null)
            {
                return betaResponseAudioWsDone(BetaResponseAudioWsDone!);
            }
            else if (IsBetaResponseAudioTranscriptWsDelta && betaResponseAudioTranscriptWsDelta != null)
            {
                return betaResponseAudioTranscriptWsDelta(BetaResponseAudioTranscriptWsDelta!);
            }
            else if (IsBetaResponseAudioTranscriptWsDone && betaResponseAudioTranscriptWsDone != null)
            {
                return betaResponseAudioTranscriptWsDone(BetaResponseAudioTranscriptWsDone!);
            }
            else if (IsBetaResponseCodeInterpreterCallCodeWsDelta && betaResponseCodeInterpreterCallCodeWsDelta != null)
            {
                return betaResponseCodeInterpreterCallCodeWsDelta(BetaResponseCodeInterpreterCallCodeWsDelta!);
            }
            else if (IsBetaResponseCodeInterpreterCallCodeWsDone && betaResponseCodeInterpreterCallCodeWsDone != null)
            {
                return betaResponseCodeInterpreterCallCodeWsDone(BetaResponseCodeInterpreterCallCodeWsDone!);
            }
            else if (IsBetaResponseCodeInterpreterCallWsCompleted && betaResponseCodeInterpreterCallWsCompleted != null)
            {
                return betaResponseCodeInterpreterCallWsCompleted(BetaResponseCodeInterpreterCallWsCompleted!);
            }
            else if (IsBetaResponseCodeInterpreterCallInWsProgress && betaResponseCodeInterpreterCallInWsProgress != null)
            {
                return betaResponseCodeInterpreterCallInWsProgress(BetaResponseCodeInterpreterCallInWsProgress!);
            }
            else if (IsBetaResponseCodeInterpreterCallWsInterpreting && betaResponseCodeInterpreterCallWsInterpreting != null)
            {
                return betaResponseCodeInterpreterCallWsInterpreting(BetaResponseCodeInterpreterCallWsInterpreting!);
            }
            else if (IsBetaResponseCompactionWsCompacting && betaResponseCompactionWsCompacting != null)
            {
                return betaResponseCompactionWsCompacting(BetaResponseCompactionWsCompacting!);
            }
            else if (IsBetaResponseWsCompleted && betaResponseWsCompleted != null)
            {
                return betaResponseWsCompleted(BetaResponseWsCompleted!);
            }
            else if (IsBetaResponseContentPartWsAdded && betaResponseContentPartWsAdded != null)
            {
                return betaResponseContentPartWsAdded(BetaResponseContentPartWsAdded!);
            }
            else if (IsBetaResponseContentPartWsDone && betaResponseContentPartWsDone != null)
            {
                return betaResponseContentPartWsDone(BetaResponseContentPartWsDone!);
            }
            else if (IsBetaResponseWsCreated && betaResponseWsCreated != null)
            {
                return betaResponseWsCreated(BetaResponseWsCreated!);
            }
            else if (IsBetaResponseFileSearchCallWsCompleted && betaResponseFileSearchCallWsCompleted != null)
            {
                return betaResponseFileSearchCallWsCompleted(BetaResponseFileSearchCallWsCompleted!);
            }
            else if (IsBetaResponseFileSearchCallInWsProgress && betaResponseFileSearchCallInWsProgress != null)
            {
                return betaResponseFileSearchCallInWsProgress(BetaResponseFileSearchCallInWsProgress!);
            }
            else if (IsBetaResponseFileSearchCallWsSearching && betaResponseFileSearchCallWsSearching != null)
            {
                return betaResponseFileSearchCallWsSearching(BetaResponseFileSearchCallWsSearching!);
            }
            else if (IsBetaResponseFunctionCallArgumentsWsDelta && betaResponseFunctionCallArgumentsWsDelta != null)
            {
                return betaResponseFunctionCallArgumentsWsDelta(BetaResponseFunctionCallArgumentsWsDelta!);
            }
            else if (IsBetaResponseFunctionCallArgumentsWsDone && betaResponseFunctionCallArgumentsWsDone != null)
            {
                return betaResponseFunctionCallArgumentsWsDone(BetaResponseFunctionCallArgumentsWsDone!);
            }
            else if (IsBetaResponseShellCallCommandWsAdded && betaResponseShellCallCommandWsAdded != null)
            {
                return betaResponseShellCallCommandWsAdded(BetaResponseShellCallCommandWsAdded!);
            }
            else if (IsBetaResponseShellCallCommandWsDelta && betaResponseShellCallCommandWsDelta != null)
            {
                return betaResponseShellCallCommandWsDelta(BetaResponseShellCallCommandWsDelta!);
            }
            else if (IsBetaResponseShellCallCommandWsDone && betaResponseShellCallCommandWsDone != null)
            {
                return betaResponseShellCallCommandWsDone(BetaResponseShellCallCommandWsDone!);
            }
            else if (IsBetaResponseShellCallOutputContentWsDelta && betaResponseShellCallOutputContentWsDelta != null)
            {
                return betaResponseShellCallOutputContentWsDelta(BetaResponseShellCallOutputContentWsDelta!);
            }
            else if (IsBetaResponseShellCallOutputContentWsDone && betaResponseShellCallOutputContentWsDone != null)
            {
                return betaResponseShellCallOutputContentWsDone(BetaResponseShellCallOutputContentWsDone!);
            }
            else if (IsBetaResponseInWsProgress && betaResponseInWsProgress != null)
            {
                return betaResponseInWsProgress(BetaResponseInWsProgress!);
            }
            else if (IsBetaResponseWsFailed && betaResponseWsFailed != null)
            {
                return betaResponseWsFailed(BetaResponseWsFailed!);
            }
            else if (IsBetaResponseWsIncomplete && betaResponseWsIncomplete != null)
            {
                return betaResponseWsIncomplete(BetaResponseWsIncomplete!);
            }
            else if (IsBetaResponseOutputItemWsAdded && betaResponseOutputItemWsAdded != null)
            {
                return betaResponseOutputItemWsAdded(BetaResponseOutputItemWsAdded!);
            }
            else if (IsBetaResponseOutputItemWsDone && betaResponseOutputItemWsDone != null)
            {
                return betaResponseOutputItemWsDone(BetaResponseOutputItemWsDone!);
            }
            else if (IsBetaResponseReasoningSummaryPartWsAdded && betaResponseReasoningSummaryPartWsAdded != null)
            {
                return betaResponseReasoningSummaryPartWsAdded(BetaResponseReasoningSummaryPartWsAdded!);
            }
            else if (IsBetaResponseReasoningSummaryPartWsDone && betaResponseReasoningSummaryPartWsDone != null)
            {
                return betaResponseReasoningSummaryPartWsDone(BetaResponseReasoningSummaryPartWsDone!);
            }
            else if (IsBetaResponseReasoningSummaryTextWsDelta && betaResponseReasoningSummaryTextWsDelta != null)
            {
                return betaResponseReasoningSummaryTextWsDelta(BetaResponseReasoningSummaryTextWsDelta!);
            }
            else if (IsBetaResponseReasoningSummaryTextWsDone && betaResponseReasoningSummaryTextWsDone != null)
            {
                return betaResponseReasoningSummaryTextWsDone(BetaResponseReasoningSummaryTextWsDone!);
            }
            else if (IsBetaResponseReasoningTextWsDelta && betaResponseReasoningTextWsDelta != null)
            {
                return betaResponseReasoningTextWsDelta(BetaResponseReasoningTextWsDelta!);
            }
            else if (IsBetaResponseReasoningTextWsDone && betaResponseReasoningTextWsDone != null)
            {
                return betaResponseReasoningTextWsDone(BetaResponseReasoningTextWsDone!);
            }
            else if (IsBetaResponseRefusalWsDelta && betaResponseRefusalWsDelta != null)
            {
                return betaResponseRefusalWsDelta(BetaResponseRefusalWsDelta!);
            }
            else if (IsBetaResponseRefusalWsDone && betaResponseRefusalWsDone != null)
            {
                return betaResponseRefusalWsDone(BetaResponseRefusalWsDone!);
            }
            else if (IsBetaResponseTextWsDelta && betaResponseTextWsDelta != null)
            {
                return betaResponseTextWsDelta(BetaResponseTextWsDelta!);
            }
            else if (IsBetaResponseTextWsDone && betaResponseTextWsDone != null)
            {
                return betaResponseTextWsDone(BetaResponseTextWsDone!);
            }
            else if (IsBetaResponseWebSearchCallWsCompleted && betaResponseWebSearchCallWsCompleted != null)
            {
                return betaResponseWebSearchCallWsCompleted(BetaResponseWebSearchCallWsCompleted!);
            }
            else if (IsBetaResponseWebSearchCallInWsProgress && betaResponseWebSearchCallInWsProgress != null)
            {
                return betaResponseWebSearchCallInWsProgress(BetaResponseWebSearchCallInWsProgress!);
            }
            else if (IsBetaResponseWebSearchCallWsSearching && betaResponseWebSearchCallWsSearching != null)
            {
                return betaResponseWebSearchCallWsSearching(BetaResponseWebSearchCallWsSearching!);
            }
            else if (IsBetaResponseImageGenCallWsCompleted && betaResponseImageGenCallWsCompleted != null)
            {
                return betaResponseImageGenCallWsCompleted(BetaResponseImageGenCallWsCompleted!);
            }
            else if (IsBetaResponseImageGenCallWsGenerating && betaResponseImageGenCallWsGenerating != null)
            {
                return betaResponseImageGenCallWsGenerating(BetaResponseImageGenCallWsGenerating!);
            }
            else if (IsBetaResponseImageGenCallInWsProgress && betaResponseImageGenCallInWsProgress != null)
            {
                return betaResponseImageGenCallInWsProgress(BetaResponseImageGenCallInWsProgress!);
            }
            else if (IsBetaResponseImageGenCallPartialWsImage && betaResponseImageGenCallPartialWsImage != null)
            {
                return betaResponseImageGenCallPartialWsImage(BetaResponseImageGenCallPartialWsImage!);
            }
            else if (IsBetaResponseMcpCallArgumentsWsDelta && betaResponseMcpCallArgumentsWsDelta != null)
            {
                return betaResponseMcpCallArgumentsWsDelta(BetaResponseMcpCallArgumentsWsDelta!);
            }
            else if (IsBetaResponseMcpCallArgumentsWsDone && betaResponseMcpCallArgumentsWsDone != null)
            {
                return betaResponseMcpCallArgumentsWsDone(BetaResponseMcpCallArgumentsWsDone!);
            }
            else if (IsBetaResponseMcpCallWsCompleted && betaResponseMcpCallWsCompleted != null)
            {
                return betaResponseMcpCallWsCompleted(BetaResponseMcpCallWsCompleted!);
            }
            else if (IsBetaResponseMcpCallWsFailed && betaResponseMcpCallWsFailed != null)
            {
                return betaResponseMcpCallWsFailed(BetaResponseMcpCallWsFailed!);
            }
            else if (IsBetaResponseMcpCallInWsProgress && betaResponseMcpCallInWsProgress != null)
            {
                return betaResponseMcpCallInWsProgress(BetaResponseMcpCallInWsProgress!);
            }
            else if (IsBetaResponseMcpListToolsWsCompleted && betaResponseMcpListToolsWsCompleted != null)
            {
                return betaResponseMcpListToolsWsCompleted(BetaResponseMcpListToolsWsCompleted!);
            }
            else if (IsBetaResponseMcpListToolsWsFailed && betaResponseMcpListToolsWsFailed != null)
            {
                return betaResponseMcpListToolsWsFailed(BetaResponseMcpListToolsWsFailed!);
            }
            else if (IsBetaResponseMcpListToolsInWsProgress && betaResponseMcpListToolsInWsProgress != null)
            {
                return betaResponseMcpListToolsInWsProgress(BetaResponseMcpListToolsInWsProgress!);
            }
            else if (IsBetaResponseOutputTextAnnotationWsAdded && betaResponseOutputTextAnnotationWsAdded != null)
            {
                return betaResponseOutputTextAnnotationWsAdded(BetaResponseOutputTextAnnotationWsAdded!);
            }
            else if (IsBetaResponseWsQueued && betaResponseWsQueued != null)
            {
                return betaResponseWsQueued(BetaResponseWsQueued!);
            }
            else if (IsBetaResponseCustomToolCallInputWsDelta && betaResponseCustomToolCallInputWsDelta != null)
            {
                return betaResponseCustomToolCallInputWsDelta(BetaResponseCustomToolCallInputWsDelta!);
            }
            else if (IsBetaResponseCustomToolCallInputWsDone && betaResponseCustomToolCallInputWsDone != null)
            {
                return betaResponseCustomToolCallInputWsDone(BetaResponseCustomToolCallInputWsDone!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }
            else if (IsResponseSteerAccepted && responseSteerAccepted != null)
            {
                return responseSteerAccepted(ResponseSteerAccepted!);
            }
            else if (IsResponseSteerPending && responseSteerPending != null)
            {
                return responseSteerPending(ResponseSteerPending!);
            }
            else if (IsResponseSteerFailed && responseSteerFailed != null)
            {
                return responseSteerFailed(ResponseSteerFailed!);
            }
            else if (IsResponseInjectCreated && responseInjectCreated != null)
            {
                return responseInjectCreated(ResponseInjectCreated!);
            }
            else if (IsResponseInjectFailed && responseInjectFailed != null)
            {
                return responseInjectFailed(ResponseInjectFailed!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDelta2>?>? betaResponseAudioWsDelta = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDone2>?>? betaResponseAudioWsDone = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDelta2>?>? betaResponseAudioTranscriptWsDelta = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDone2>?>? betaResponseAudioTranscriptWsDone = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDelta2>?>? betaResponseCodeInterpreterCallCodeWsDelta = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDone2>?>? betaResponseCodeInterpreterCallCodeWsDone = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsCompleted2>?>? betaResponseCodeInterpreterCallWsCompleted = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallInWsProgress2>?>? betaResponseCodeInterpreterCallInWsProgress = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsInterpreting2>?>? betaResponseCodeInterpreterCallWsInterpreting = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCompactionWsCompacting2>?>? betaResponseCompactionWsCompacting = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCompleted2>?>? betaResponseWsCompleted = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsAdded2>?>? betaResponseContentPartWsAdded = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsDone2>?>? betaResponseContentPartWsDone = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCreatedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCreated2>?>? betaResponseWsCreated = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsCompleted2>?>? betaResponseFileSearchCallWsCompleted = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallInWsProgress2>?>? betaResponseFileSearchCallInWsProgress = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsSearching2>?>? betaResponseFileSearchCallWsSearching = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDelta2>?>? betaResponseFunctionCallArgumentsWsDelta = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2>?>? betaResponseFunctionCallArgumentsWsDone = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsAdded2>?>? betaResponseShellCallCommandWsAdded = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDelta2>?>? betaResponseShellCallCommandWsDelta = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDone2>?>? betaResponseShellCallCommandWsDone = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDelta2>?>? betaResponseShellCallOutputContentWsDelta = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDone2>?>? betaResponseShellCallOutputContentWsDone = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseInWsProgress2>?>? betaResponseInWsProgress = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsFailed2>?>? betaResponseWsFailed = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseIncompleteEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsIncomplete2>?>? betaResponseWsIncomplete = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsAdded2>?>? betaResponseOutputItemWsAdded = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsDone2>?>? betaResponseOutputItemWsDone = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsAdded2>?>? betaResponseReasoningSummaryPartWsAdded = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsDone2>?>? betaResponseReasoningSummaryPartWsDone = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDelta2>?>? betaResponseReasoningSummaryTextWsDelta = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDone2>?>? betaResponseReasoningSummaryTextWsDone = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDelta2>?>? betaResponseReasoningTextWsDelta = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDone2>?>? betaResponseReasoningTextWsDone = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDelta2>?>? betaResponseRefusalWsDelta = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDone2>?>? betaResponseRefusalWsDone = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDelta2>?>? betaResponseTextWsDelta = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDone2>?>? betaResponseTextWsDone = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsCompleted2>?>? betaResponseWebSearchCallWsCompleted = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallInWsProgress2>?>? betaResponseWebSearchCallInWsProgress = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsSearching2>?>? betaResponseWebSearchCallWsSearching = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsCompleted2>?>? betaResponseImageGenCallWsCompleted = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsGenerating2>?>? betaResponseImageGenCallWsGenerating = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallInWsProgress2>?>? betaResponseImageGenCallInWsProgress = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallPartialWsImage2>?>? betaResponseImageGenCallPartialWsImage = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDelta2>?>? betaResponseMcpCallArgumentsWsDelta = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDone2>?>? betaResponseMcpCallArgumentsWsDone = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsCompleted2>?>? betaResponseMcpCallWsCompleted = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsFailed2>?>? betaResponseMcpCallWsFailed = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallInWsProgress2>?>? betaResponseMcpCallInWsProgress = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsCompleted2>?>? betaResponseMcpListToolsWsCompleted = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsFailed2>?>? betaResponseMcpListToolsWsFailed = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsInWsProgress2>?>? betaResponseMcpListToolsInWsProgress = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputTextAnnotationWsAdded2>?>? betaResponseOutputTextAnnotationWsAdded = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseQueuedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsQueued2>?>? betaResponseWsQueued = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDelta2>?>? betaResponseCustomToolCallInputWsDelta = null,

            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDone2>?>? betaResponseCustomToolCallInputWsDone = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseWsError>? error = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseSteerAcceptedEvent>? responseSteerAccepted = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseSteerPendingEvent>? responseSteerPending = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseSteerFailedEvent>? responseSteerFailed = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent>? responseInjectCreated = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseInjectFailedEvent>? responseInjectFailed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBetaResponseAudioWsDelta)
            {
                betaResponseAudioWsDelta?.Invoke(BetaResponseAudioWsDelta!);
            }
            else if (IsBetaResponseAudioWsDone)
            {
                betaResponseAudioWsDone?.Invoke(BetaResponseAudioWsDone!);
            }
            else if (IsBetaResponseAudioTranscriptWsDelta)
            {
                betaResponseAudioTranscriptWsDelta?.Invoke(BetaResponseAudioTranscriptWsDelta!);
            }
            else if (IsBetaResponseAudioTranscriptWsDone)
            {
                betaResponseAudioTranscriptWsDone?.Invoke(BetaResponseAudioTranscriptWsDone!);
            }
            else if (IsBetaResponseCodeInterpreterCallCodeWsDelta)
            {
                betaResponseCodeInterpreterCallCodeWsDelta?.Invoke(BetaResponseCodeInterpreterCallCodeWsDelta!);
            }
            else if (IsBetaResponseCodeInterpreterCallCodeWsDone)
            {
                betaResponseCodeInterpreterCallCodeWsDone?.Invoke(BetaResponseCodeInterpreterCallCodeWsDone!);
            }
            else if (IsBetaResponseCodeInterpreterCallWsCompleted)
            {
                betaResponseCodeInterpreterCallWsCompleted?.Invoke(BetaResponseCodeInterpreterCallWsCompleted!);
            }
            else if (IsBetaResponseCodeInterpreterCallInWsProgress)
            {
                betaResponseCodeInterpreterCallInWsProgress?.Invoke(BetaResponseCodeInterpreterCallInWsProgress!);
            }
            else if (IsBetaResponseCodeInterpreterCallWsInterpreting)
            {
                betaResponseCodeInterpreterCallWsInterpreting?.Invoke(BetaResponseCodeInterpreterCallWsInterpreting!);
            }
            else if (IsBetaResponseCompactionWsCompacting)
            {
                betaResponseCompactionWsCompacting?.Invoke(BetaResponseCompactionWsCompacting!);
            }
            else if (IsBetaResponseWsCompleted)
            {
                betaResponseWsCompleted?.Invoke(BetaResponseWsCompleted!);
            }
            else if (IsBetaResponseContentPartWsAdded)
            {
                betaResponseContentPartWsAdded?.Invoke(BetaResponseContentPartWsAdded!);
            }
            else if (IsBetaResponseContentPartWsDone)
            {
                betaResponseContentPartWsDone?.Invoke(BetaResponseContentPartWsDone!);
            }
            else if (IsBetaResponseWsCreated)
            {
                betaResponseWsCreated?.Invoke(BetaResponseWsCreated!);
            }
            else if (IsBetaResponseFileSearchCallWsCompleted)
            {
                betaResponseFileSearchCallWsCompleted?.Invoke(BetaResponseFileSearchCallWsCompleted!);
            }
            else if (IsBetaResponseFileSearchCallInWsProgress)
            {
                betaResponseFileSearchCallInWsProgress?.Invoke(BetaResponseFileSearchCallInWsProgress!);
            }
            else if (IsBetaResponseFileSearchCallWsSearching)
            {
                betaResponseFileSearchCallWsSearching?.Invoke(BetaResponseFileSearchCallWsSearching!);
            }
            else if (IsBetaResponseFunctionCallArgumentsWsDelta)
            {
                betaResponseFunctionCallArgumentsWsDelta?.Invoke(BetaResponseFunctionCallArgumentsWsDelta!);
            }
            else if (IsBetaResponseFunctionCallArgumentsWsDone)
            {
                betaResponseFunctionCallArgumentsWsDone?.Invoke(BetaResponseFunctionCallArgumentsWsDone!);
            }
            else if (IsBetaResponseShellCallCommandWsAdded)
            {
                betaResponseShellCallCommandWsAdded?.Invoke(BetaResponseShellCallCommandWsAdded!);
            }
            else if (IsBetaResponseShellCallCommandWsDelta)
            {
                betaResponseShellCallCommandWsDelta?.Invoke(BetaResponseShellCallCommandWsDelta!);
            }
            else if (IsBetaResponseShellCallCommandWsDone)
            {
                betaResponseShellCallCommandWsDone?.Invoke(BetaResponseShellCallCommandWsDone!);
            }
            else if (IsBetaResponseShellCallOutputContentWsDelta)
            {
                betaResponseShellCallOutputContentWsDelta?.Invoke(BetaResponseShellCallOutputContentWsDelta!);
            }
            else if (IsBetaResponseShellCallOutputContentWsDone)
            {
                betaResponseShellCallOutputContentWsDone?.Invoke(BetaResponseShellCallOutputContentWsDone!);
            }
            else if (IsBetaResponseInWsProgress)
            {
                betaResponseInWsProgress?.Invoke(BetaResponseInWsProgress!);
            }
            else if (IsBetaResponseWsFailed)
            {
                betaResponseWsFailed?.Invoke(BetaResponseWsFailed!);
            }
            else if (IsBetaResponseWsIncomplete)
            {
                betaResponseWsIncomplete?.Invoke(BetaResponseWsIncomplete!);
            }
            else if (IsBetaResponseOutputItemWsAdded)
            {
                betaResponseOutputItemWsAdded?.Invoke(BetaResponseOutputItemWsAdded!);
            }
            else if (IsBetaResponseOutputItemWsDone)
            {
                betaResponseOutputItemWsDone?.Invoke(BetaResponseOutputItemWsDone!);
            }
            else if (IsBetaResponseReasoningSummaryPartWsAdded)
            {
                betaResponseReasoningSummaryPartWsAdded?.Invoke(BetaResponseReasoningSummaryPartWsAdded!);
            }
            else if (IsBetaResponseReasoningSummaryPartWsDone)
            {
                betaResponseReasoningSummaryPartWsDone?.Invoke(BetaResponseReasoningSummaryPartWsDone!);
            }
            else if (IsBetaResponseReasoningSummaryTextWsDelta)
            {
                betaResponseReasoningSummaryTextWsDelta?.Invoke(BetaResponseReasoningSummaryTextWsDelta!);
            }
            else if (IsBetaResponseReasoningSummaryTextWsDone)
            {
                betaResponseReasoningSummaryTextWsDone?.Invoke(BetaResponseReasoningSummaryTextWsDone!);
            }
            else if (IsBetaResponseReasoningTextWsDelta)
            {
                betaResponseReasoningTextWsDelta?.Invoke(BetaResponseReasoningTextWsDelta!);
            }
            else if (IsBetaResponseReasoningTextWsDone)
            {
                betaResponseReasoningTextWsDone?.Invoke(BetaResponseReasoningTextWsDone!);
            }
            else if (IsBetaResponseRefusalWsDelta)
            {
                betaResponseRefusalWsDelta?.Invoke(BetaResponseRefusalWsDelta!);
            }
            else if (IsBetaResponseRefusalWsDone)
            {
                betaResponseRefusalWsDone?.Invoke(BetaResponseRefusalWsDone!);
            }
            else if (IsBetaResponseTextWsDelta)
            {
                betaResponseTextWsDelta?.Invoke(BetaResponseTextWsDelta!);
            }
            else if (IsBetaResponseTextWsDone)
            {
                betaResponseTextWsDone?.Invoke(BetaResponseTextWsDone!);
            }
            else if (IsBetaResponseWebSearchCallWsCompleted)
            {
                betaResponseWebSearchCallWsCompleted?.Invoke(BetaResponseWebSearchCallWsCompleted!);
            }
            else if (IsBetaResponseWebSearchCallInWsProgress)
            {
                betaResponseWebSearchCallInWsProgress?.Invoke(BetaResponseWebSearchCallInWsProgress!);
            }
            else if (IsBetaResponseWebSearchCallWsSearching)
            {
                betaResponseWebSearchCallWsSearching?.Invoke(BetaResponseWebSearchCallWsSearching!);
            }
            else if (IsBetaResponseImageGenCallWsCompleted)
            {
                betaResponseImageGenCallWsCompleted?.Invoke(BetaResponseImageGenCallWsCompleted!);
            }
            else if (IsBetaResponseImageGenCallWsGenerating)
            {
                betaResponseImageGenCallWsGenerating?.Invoke(BetaResponseImageGenCallWsGenerating!);
            }
            else if (IsBetaResponseImageGenCallInWsProgress)
            {
                betaResponseImageGenCallInWsProgress?.Invoke(BetaResponseImageGenCallInWsProgress!);
            }
            else if (IsBetaResponseImageGenCallPartialWsImage)
            {
                betaResponseImageGenCallPartialWsImage?.Invoke(BetaResponseImageGenCallPartialWsImage!);
            }
            else if (IsBetaResponseMcpCallArgumentsWsDelta)
            {
                betaResponseMcpCallArgumentsWsDelta?.Invoke(BetaResponseMcpCallArgumentsWsDelta!);
            }
            else if (IsBetaResponseMcpCallArgumentsWsDone)
            {
                betaResponseMcpCallArgumentsWsDone?.Invoke(BetaResponseMcpCallArgumentsWsDone!);
            }
            else if (IsBetaResponseMcpCallWsCompleted)
            {
                betaResponseMcpCallWsCompleted?.Invoke(BetaResponseMcpCallWsCompleted!);
            }
            else if (IsBetaResponseMcpCallWsFailed)
            {
                betaResponseMcpCallWsFailed?.Invoke(BetaResponseMcpCallWsFailed!);
            }
            else if (IsBetaResponseMcpCallInWsProgress)
            {
                betaResponseMcpCallInWsProgress?.Invoke(BetaResponseMcpCallInWsProgress!);
            }
            else if (IsBetaResponseMcpListToolsWsCompleted)
            {
                betaResponseMcpListToolsWsCompleted?.Invoke(BetaResponseMcpListToolsWsCompleted!);
            }
            else if (IsBetaResponseMcpListToolsWsFailed)
            {
                betaResponseMcpListToolsWsFailed?.Invoke(BetaResponseMcpListToolsWsFailed!);
            }
            else if (IsBetaResponseMcpListToolsInWsProgress)
            {
                betaResponseMcpListToolsInWsProgress?.Invoke(BetaResponseMcpListToolsInWsProgress!);
            }
            else if (IsBetaResponseOutputTextAnnotationWsAdded)
            {
                betaResponseOutputTextAnnotationWsAdded?.Invoke(BetaResponseOutputTextAnnotationWsAdded!);
            }
            else if (IsBetaResponseWsQueued)
            {
                betaResponseWsQueued?.Invoke(BetaResponseWsQueued!);
            }
            else if (IsBetaResponseCustomToolCallInputWsDelta)
            {
                betaResponseCustomToolCallInputWsDelta?.Invoke(BetaResponseCustomToolCallInputWsDelta!);
            }
            else if (IsBetaResponseCustomToolCallInputWsDone)
            {
                betaResponseCustomToolCallInputWsDone?.Invoke(BetaResponseCustomToolCallInputWsDone!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
            else if (IsResponseSteerAccepted)
            {
                responseSteerAccepted?.Invoke(ResponseSteerAccepted!);
            }
            else if (IsResponseSteerPending)
            {
                responseSteerPending?.Invoke(ResponseSteerPending!);
            }
            else if (IsResponseSteerFailed)
            {
                responseSteerFailed?.Invoke(ResponseSteerFailed!);
            }
            else if (IsResponseInjectCreated)
            {
                responseInjectCreated?.Invoke(ResponseInjectCreated!);
            }
            else if (IsResponseInjectFailed)
            {
                responseInjectFailed?.Invoke(ResponseInjectFailed!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDelta2>?>? betaResponseAudioWsDelta = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDone2>?>? betaResponseAudioWsDone = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDelta2>?>? betaResponseAudioTranscriptWsDelta = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDone2>?>? betaResponseAudioTranscriptWsDone = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDelta2>?>? betaResponseCodeInterpreterCallCodeWsDelta = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDone2>?>? betaResponseCodeInterpreterCallCodeWsDone = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsCompleted2>?>? betaResponseCodeInterpreterCallWsCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallInWsProgress2>?>? betaResponseCodeInterpreterCallInWsProgress = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsInterpreting2>?>? betaResponseCodeInterpreterCallWsInterpreting = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCompactionWsCompacting2>?>? betaResponseCompactionWsCompacting = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCompleted2>?>? betaResponseWsCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsAdded2>?>? betaResponseContentPartWsAdded = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsDone2>?>? betaResponseContentPartWsDone = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCreatedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCreated2>?>? betaResponseWsCreated = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsCompleted2>?>? betaResponseFileSearchCallWsCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallInWsProgress2>?>? betaResponseFileSearchCallInWsProgress = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsSearching2>?>? betaResponseFileSearchCallWsSearching = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDelta2>?>? betaResponseFunctionCallArgumentsWsDelta = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2>?>? betaResponseFunctionCallArgumentsWsDone = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsAdded2>?>? betaResponseShellCallCommandWsAdded = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDelta2>?>? betaResponseShellCallCommandWsDelta = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDone2>?>? betaResponseShellCallCommandWsDone = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDelta2>?>? betaResponseShellCallOutputContentWsDelta = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDone2>?>? betaResponseShellCallOutputContentWsDone = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseInWsProgress2>?>? betaResponseInWsProgress = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsFailed2>?>? betaResponseWsFailed = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseIncompleteEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsIncomplete2>?>? betaResponseWsIncomplete = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsAdded2>?>? betaResponseOutputItemWsAdded = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsDone2>?>? betaResponseOutputItemWsDone = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsAdded2>?>? betaResponseReasoningSummaryPartWsAdded = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsDone2>?>? betaResponseReasoningSummaryPartWsDone = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDelta2>?>? betaResponseReasoningSummaryTextWsDelta = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDone2>?>? betaResponseReasoningSummaryTextWsDone = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDelta2>?>? betaResponseReasoningTextWsDelta = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDone2>?>? betaResponseReasoningTextWsDone = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDelta2>?>? betaResponseRefusalWsDelta = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDone2>?>? betaResponseRefusalWsDone = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDelta2>?>? betaResponseTextWsDelta = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDone2>?>? betaResponseTextWsDone = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsCompleted2>?>? betaResponseWebSearchCallWsCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallInWsProgress2>?>? betaResponseWebSearchCallInWsProgress = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsSearching2>?>? betaResponseWebSearchCallWsSearching = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsCompleted2>?>? betaResponseImageGenCallWsCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsGenerating2>?>? betaResponseImageGenCallWsGenerating = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallInWsProgress2>?>? betaResponseImageGenCallInWsProgress = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallPartialWsImage2>?>? betaResponseImageGenCallPartialWsImage = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDelta2>?>? betaResponseMcpCallArgumentsWsDelta = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDone2>?>? betaResponseMcpCallArgumentsWsDone = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsCompleted2>?>? betaResponseMcpCallWsCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsFailed2>?>? betaResponseMcpCallWsFailed = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallInWsProgress2>?>? betaResponseMcpCallInWsProgress = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsCompleted2>?>? betaResponseMcpListToolsWsCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsFailed2>?>? betaResponseMcpListToolsWsFailed = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsInWsProgress2>?>? betaResponseMcpListToolsInWsProgress = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputTextAnnotationWsAdded2>?>? betaResponseOutputTextAnnotationWsAdded = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseQueuedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsQueued2>?>? betaResponseWsQueued = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDelta2>?>? betaResponseCustomToolCallInputWsDelta = null,
            global::System.Action<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDone2>?>? betaResponseCustomToolCallInputWsDone = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseWsError>? error = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseSteerAcceptedEvent>? responseSteerAccepted = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseSteerPendingEvent>? responseSteerPending = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseSteerFailedEvent>? responseSteerFailed = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent>? responseInjectCreated = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseInjectFailedEvent>? responseInjectFailed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBetaResponseAudioWsDelta)
            {
                betaResponseAudioWsDelta?.Invoke(BetaResponseAudioWsDelta!);
            }
            else if (IsBetaResponseAudioWsDone)
            {
                betaResponseAudioWsDone?.Invoke(BetaResponseAudioWsDone!);
            }
            else if (IsBetaResponseAudioTranscriptWsDelta)
            {
                betaResponseAudioTranscriptWsDelta?.Invoke(BetaResponseAudioTranscriptWsDelta!);
            }
            else if (IsBetaResponseAudioTranscriptWsDone)
            {
                betaResponseAudioTranscriptWsDone?.Invoke(BetaResponseAudioTranscriptWsDone!);
            }
            else if (IsBetaResponseCodeInterpreterCallCodeWsDelta)
            {
                betaResponseCodeInterpreterCallCodeWsDelta?.Invoke(BetaResponseCodeInterpreterCallCodeWsDelta!);
            }
            else if (IsBetaResponseCodeInterpreterCallCodeWsDone)
            {
                betaResponseCodeInterpreterCallCodeWsDone?.Invoke(BetaResponseCodeInterpreterCallCodeWsDone!);
            }
            else if (IsBetaResponseCodeInterpreterCallWsCompleted)
            {
                betaResponseCodeInterpreterCallWsCompleted?.Invoke(BetaResponseCodeInterpreterCallWsCompleted!);
            }
            else if (IsBetaResponseCodeInterpreterCallInWsProgress)
            {
                betaResponseCodeInterpreterCallInWsProgress?.Invoke(BetaResponseCodeInterpreterCallInWsProgress!);
            }
            else if (IsBetaResponseCodeInterpreterCallWsInterpreting)
            {
                betaResponseCodeInterpreterCallWsInterpreting?.Invoke(BetaResponseCodeInterpreterCallWsInterpreting!);
            }
            else if (IsBetaResponseCompactionWsCompacting)
            {
                betaResponseCompactionWsCompacting?.Invoke(BetaResponseCompactionWsCompacting!);
            }
            else if (IsBetaResponseWsCompleted)
            {
                betaResponseWsCompleted?.Invoke(BetaResponseWsCompleted!);
            }
            else if (IsBetaResponseContentPartWsAdded)
            {
                betaResponseContentPartWsAdded?.Invoke(BetaResponseContentPartWsAdded!);
            }
            else if (IsBetaResponseContentPartWsDone)
            {
                betaResponseContentPartWsDone?.Invoke(BetaResponseContentPartWsDone!);
            }
            else if (IsBetaResponseWsCreated)
            {
                betaResponseWsCreated?.Invoke(BetaResponseWsCreated!);
            }
            else if (IsBetaResponseFileSearchCallWsCompleted)
            {
                betaResponseFileSearchCallWsCompleted?.Invoke(BetaResponseFileSearchCallWsCompleted!);
            }
            else if (IsBetaResponseFileSearchCallInWsProgress)
            {
                betaResponseFileSearchCallInWsProgress?.Invoke(BetaResponseFileSearchCallInWsProgress!);
            }
            else if (IsBetaResponseFileSearchCallWsSearching)
            {
                betaResponseFileSearchCallWsSearching?.Invoke(BetaResponseFileSearchCallWsSearching!);
            }
            else if (IsBetaResponseFunctionCallArgumentsWsDelta)
            {
                betaResponseFunctionCallArgumentsWsDelta?.Invoke(BetaResponseFunctionCallArgumentsWsDelta!);
            }
            else if (IsBetaResponseFunctionCallArgumentsWsDone)
            {
                betaResponseFunctionCallArgumentsWsDone?.Invoke(BetaResponseFunctionCallArgumentsWsDone!);
            }
            else if (IsBetaResponseShellCallCommandWsAdded)
            {
                betaResponseShellCallCommandWsAdded?.Invoke(BetaResponseShellCallCommandWsAdded!);
            }
            else if (IsBetaResponseShellCallCommandWsDelta)
            {
                betaResponseShellCallCommandWsDelta?.Invoke(BetaResponseShellCallCommandWsDelta!);
            }
            else if (IsBetaResponseShellCallCommandWsDone)
            {
                betaResponseShellCallCommandWsDone?.Invoke(BetaResponseShellCallCommandWsDone!);
            }
            else if (IsBetaResponseShellCallOutputContentWsDelta)
            {
                betaResponseShellCallOutputContentWsDelta?.Invoke(BetaResponseShellCallOutputContentWsDelta!);
            }
            else if (IsBetaResponseShellCallOutputContentWsDone)
            {
                betaResponseShellCallOutputContentWsDone?.Invoke(BetaResponseShellCallOutputContentWsDone!);
            }
            else if (IsBetaResponseInWsProgress)
            {
                betaResponseInWsProgress?.Invoke(BetaResponseInWsProgress!);
            }
            else if (IsBetaResponseWsFailed)
            {
                betaResponseWsFailed?.Invoke(BetaResponseWsFailed!);
            }
            else if (IsBetaResponseWsIncomplete)
            {
                betaResponseWsIncomplete?.Invoke(BetaResponseWsIncomplete!);
            }
            else if (IsBetaResponseOutputItemWsAdded)
            {
                betaResponseOutputItemWsAdded?.Invoke(BetaResponseOutputItemWsAdded!);
            }
            else if (IsBetaResponseOutputItemWsDone)
            {
                betaResponseOutputItemWsDone?.Invoke(BetaResponseOutputItemWsDone!);
            }
            else if (IsBetaResponseReasoningSummaryPartWsAdded)
            {
                betaResponseReasoningSummaryPartWsAdded?.Invoke(BetaResponseReasoningSummaryPartWsAdded!);
            }
            else if (IsBetaResponseReasoningSummaryPartWsDone)
            {
                betaResponseReasoningSummaryPartWsDone?.Invoke(BetaResponseReasoningSummaryPartWsDone!);
            }
            else if (IsBetaResponseReasoningSummaryTextWsDelta)
            {
                betaResponseReasoningSummaryTextWsDelta?.Invoke(BetaResponseReasoningSummaryTextWsDelta!);
            }
            else if (IsBetaResponseReasoningSummaryTextWsDone)
            {
                betaResponseReasoningSummaryTextWsDone?.Invoke(BetaResponseReasoningSummaryTextWsDone!);
            }
            else if (IsBetaResponseReasoningTextWsDelta)
            {
                betaResponseReasoningTextWsDelta?.Invoke(BetaResponseReasoningTextWsDelta!);
            }
            else if (IsBetaResponseReasoningTextWsDone)
            {
                betaResponseReasoningTextWsDone?.Invoke(BetaResponseReasoningTextWsDone!);
            }
            else if (IsBetaResponseRefusalWsDelta)
            {
                betaResponseRefusalWsDelta?.Invoke(BetaResponseRefusalWsDelta!);
            }
            else if (IsBetaResponseRefusalWsDone)
            {
                betaResponseRefusalWsDone?.Invoke(BetaResponseRefusalWsDone!);
            }
            else if (IsBetaResponseTextWsDelta)
            {
                betaResponseTextWsDelta?.Invoke(BetaResponseTextWsDelta!);
            }
            else if (IsBetaResponseTextWsDone)
            {
                betaResponseTextWsDone?.Invoke(BetaResponseTextWsDone!);
            }
            else if (IsBetaResponseWebSearchCallWsCompleted)
            {
                betaResponseWebSearchCallWsCompleted?.Invoke(BetaResponseWebSearchCallWsCompleted!);
            }
            else if (IsBetaResponseWebSearchCallInWsProgress)
            {
                betaResponseWebSearchCallInWsProgress?.Invoke(BetaResponseWebSearchCallInWsProgress!);
            }
            else if (IsBetaResponseWebSearchCallWsSearching)
            {
                betaResponseWebSearchCallWsSearching?.Invoke(BetaResponseWebSearchCallWsSearching!);
            }
            else if (IsBetaResponseImageGenCallWsCompleted)
            {
                betaResponseImageGenCallWsCompleted?.Invoke(BetaResponseImageGenCallWsCompleted!);
            }
            else if (IsBetaResponseImageGenCallWsGenerating)
            {
                betaResponseImageGenCallWsGenerating?.Invoke(BetaResponseImageGenCallWsGenerating!);
            }
            else if (IsBetaResponseImageGenCallInWsProgress)
            {
                betaResponseImageGenCallInWsProgress?.Invoke(BetaResponseImageGenCallInWsProgress!);
            }
            else if (IsBetaResponseImageGenCallPartialWsImage)
            {
                betaResponseImageGenCallPartialWsImage?.Invoke(BetaResponseImageGenCallPartialWsImage!);
            }
            else if (IsBetaResponseMcpCallArgumentsWsDelta)
            {
                betaResponseMcpCallArgumentsWsDelta?.Invoke(BetaResponseMcpCallArgumentsWsDelta!);
            }
            else if (IsBetaResponseMcpCallArgumentsWsDone)
            {
                betaResponseMcpCallArgumentsWsDone?.Invoke(BetaResponseMcpCallArgumentsWsDone!);
            }
            else if (IsBetaResponseMcpCallWsCompleted)
            {
                betaResponseMcpCallWsCompleted?.Invoke(BetaResponseMcpCallWsCompleted!);
            }
            else if (IsBetaResponseMcpCallWsFailed)
            {
                betaResponseMcpCallWsFailed?.Invoke(BetaResponseMcpCallWsFailed!);
            }
            else if (IsBetaResponseMcpCallInWsProgress)
            {
                betaResponseMcpCallInWsProgress?.Invoke(BetaResponseMcpCallInWsProgress!);
            }
            else if (IsBetaResponseMcpListToolsWsCompleted)
            {
                betaResponseMcpListToolsWsCompleted?.Invoke(BetaResponseMcpListToolsWsCompleted!);
            }
            else if (IsBetaResponseMcpListToolsWsFailed)
            {
                betaResponseMcpListToolsWsFailed?.Invoke(BetaResponseMcpListToolsWsFailed!);
            }
            else if (IsBetaResponseMcpListToolsInWsProgress)
            {
                betaResponseMcpListToolsInWsProgress?.Invoke(BetaResponseMcpListToolsInWsProgress!);
            }
            else if (IsBetaResponseOutputTextAnnotationWsAdded)
            {
                betaResponseOutputTextAnnotationWsAdded?.Invoke(BetaResponseOutputTextAnnotationWsAdded!);
            }
            else if (IsBetaResponseWsQueued)
            {
                betaResponseWsQueued?.Invoke(BetaResponseWsQueued!);
            }
            else if (IsBetaResponseCustomToolCallInputWsDelta)
            {
                betaResponseCustomToolCallInputWsDelta?.Invoke(BetaResponseCustomToolCallInputWsDelta!);
            }
            else if (IsBetaResponseCustomToolCallInputWsDone)
            {
                betaResponseCustomToolCallInputWsDone?.Invoke(BetaResponseCustomToolCallInputWsDone!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
            else if (IsResponseSteerAccepted)
            {
                responseSteerAccepted?.Invoke(ResponseSteerAccepted!);
            }
            else if (IsResponseSteerPending)
            {
                responseSteerPending?.Invoke(ResponseSteerPending!);
            }
            else if (IsResponseSteerFailed)
            {
                responseSteerFailed?.Invoke(ResponseSteerFailed!);
            }
            else if (IsResponseInjectCreated)
            {
                responseInjectCreated?.Invoke(ResponseInjectCreated!);
            }
            else if (IsResponseInjectFailed)
            {
                responseInjectFailed?.Invoke(ResponseInjectFailed!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BetaResponseAudioWsDelta,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDelta2>),
                BetaResponseAudioWsDone,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDone2>),
                BetaResponseAudioTranscriptWsDelta,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDelta2>),
                BetaResponseAudioTranscriptWsDone,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDone2>),
                BetaResponseCodeInterpreterCallCodeWsDelta,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDelta2>),
                BetaResponseCodeInterpreterCallCodeWsDone,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDone2>),
                BetaResponseCodeInterpreterCallWsCompleted,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsCompleted2>),
                BetaResponseCodeInterpreterCallInWsProgress,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallInWsProgress2>),
                BetaResponseCodeInterpreterCallWsInterpreting,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsInterpreting2>),
                BetaResponseCompactionWsCompacting,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCompactionWsCompacting2>),
                BetaResponseWsCompleted,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCompleted2>),
                BetaResponseContentPartWsAdded,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsAdded2>),
                BetaResponseContentPartWsDone,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsDone2>),
                BetaResponseWsCreated,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCreatedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCreated2>),
                BetaResponseFileSearchCallWsCompleted,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsCompleted2>),
                BetaResponseFileSearchCallInWsProgress,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallInWsProgress2>),
                BetaResponseFileSearchCallWsSearching,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsSearching2>),
                BetaResponseFunctionCallArgumentsWsDelta,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDelta2>),
                BetaResponseFunctionCallArgumentsWsDone,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2>),
                BetaResponseShellCallCommandWsAdded,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsAdded2>),
                BetaResponseShellCallCommandWsDelta,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDelta2>),
                BetaResponseShellCallCommandWsDone,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDone2>),
                BetaResponseShellCallOutputContentWsDelta,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDelta2>),
                BetaResponseShellCallOutputContentWsDone,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDone2>),
                BetaResponseInWsProgress,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseInWsProgress2>),
                BetaResponseWsFailed,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsFailed2>),
                BetaResponseWsIncomplete,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseIncompleteEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsIncomplete2>),
                BetaResponseOutputItemWsAdded,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsAdded2>),
                BetaResponseOutputItemWsDone,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsDone2>),
                BetaResponseReasoningSummaryPartWsAdded,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsAdded2>),
                BetaResponseReasoningSummaryPartWsDone,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsDone2>),
                BetaResponseReasoningSummaryTextWsDelta,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDelta2>),
                BetaResponseReasoningSummaryTextWsDone,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDone2>),
                BetaResponseReasoningTextWsDelta,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDelta2>),
                BetaResponseReasoningTextWsDone,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDone2>),
                BetaResponseRefusalWsDelta,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDelta2>),
                BetaResponseRefusalWsDone,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDone2>),
                BetaResponseTextWsDelta,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDelta2>),
                BetaResponseTextWsDone,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDone2>),
                BetaResponseWebSearchCallWsCompleted,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsCompleted2>),
                BetaResponseWebSearchCallInWsProgress,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallInWsProgress2>),
                BetaResponseWebSearchCallWsSearching,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsSearching2>),
                BetaResponseImageGenCallWsCompleted,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsCompleted2>),
                BetaResponseImageGenCallWsGenerating,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsGenerating2>),
                BetaResponseImageGenCallInWsProgress,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallInWsProgress2>),
                BetaResponseImageGenCallPartialWsImage,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallPartialWsImage2>),
                BetaResponseMcpCallArgumentsWsDelta,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDelta2>),
                BetaResponseMcpCallArgumentsWsDone,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDone2>),
                BetaResponseMcpCallWsCompleted,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsCompleted2>),
                BetaResponseMcpCallWsFailed,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsFailed2>),
                BetaResponseMcpCallInWsProgress,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallInWsProgress2>),
                BetaResponseMcpListToolsWsCompleted,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsCompleted2>),
                BetaResponseMcpListToolsWsFailed,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsFailed2>),
                BetaResponseMcpListToolsInWsProgress,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsInWsProgress2>),
                BetaResponseOutputTextAnnotationWsAdded,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputTextAnnotationWsAdded2>),
                BetaResponseWsQueued,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseQueuedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsQueued2>),
                BetaResponseCustomToolCallInputWsDelta,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDelta2>),
                BetaResponseCustomToolCallInputWsDone,
                typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDone2>),
                Error,
                typeof(global::tryAGI.OpenAI.BetaResponseWsError),
                ResponseSteerAccepted,
                typeof(global::tryAGI.OpenAI.BetaResponseSteerAcceptedEvent),
                ResponseSteerPending,
                typeof(global::tryAGI.OpenAI.BetaResponseSteerPendingEvent),
                ResponseSteerFailed,
                typeof(global::tryAGI.OpenAI.BetaResponseSteerFailedEvent),
                ResponseInjectCreated,
                typeof(global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent),
                ResponseInjectFailed,
                typeof(global::tryAGI.OpenAI.BetaResponseInjectFailedEvent),
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
        public bool Equals(BetaResponsesServerEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDelta2>?>.Default.Equals(BetaResponseAudioWsDelta, other.BetaResponseAudioWsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDone2>?>.Default.Equals(BetaResponseAudioWsDone, other.BetaResponseAudioWsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDelta2>?>.Default.Equals(BetaResponseAudioTranscriptWsDelta, other.BetaResponseAudioTranscriptWsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDone2>?>.Default.Equals(BetaResponseAudioTranscriptWsDone, other.BetaResponseAudioTranscriptWsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDelta2>?>.Default.Equals(BetaResponseCodeInterpreterCallCodeWsDelta, other.BetaResponseCodeInterpreterCallCodeWsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDone2>?>.Default.Equals(BetaResponseCodeInterpreterCallCodeWsDone, other.BetaResponseCodeInterpreterCallCodeWsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsCompleted2>?>.Default.Equals(BetaResponseCodeInterpreterCallWsCompleted, other.BetaResponseCodeInterpreterCallWsCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallInWsProgress2>?>.Default.Equals(BetaResponseCodeInterpreterCallInWsProgress, other.BetaResponseCodeInterpreterCallInWsProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsInterpreting2>?>.Default.Equals(BetaResponseCodeInterpreterCallWsInterpreting, other.BetaResponseCodeInterpreterCallWsInterpreting) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCompactionWsCompacting2>?>.Default.Equals(BetaResponseCompactionWsCompacting, other.BetaResponseCompactionWsCompacting) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCompleted2>?>.Default.Equals(BetaResponseWsCompleted, other.BetaResponseWsCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsAdded2>?>.Default.Equals(BetaResponseContentPartWsAdded, other.BetaResponseContentPartWsAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsDone2>?>.Default.Equals(BetaResponseContentPartWsDone, other.BetaResponseContentPartWsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCreatedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCreated2>?>.Default.Equals(BetaResponseWsCreated, other.BetaResponseWsCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsCompleted2>?>.Default.Equals(BetaResponseFileSearchCallWsCompleted, other.BetaResponseFileSearchCallWsCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallInWsProgress2>?>.Default.Equals(BetaResponseFileSearchCallInWsProgress, other.BetaResponseFileSearchCallInWsProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsSearching2>?>.Default.Equals(BetaResponseFileSearchCallWsSearching, other.BetaResponseFileSearchCallWsSearching) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDelta2>?>.Default.Equals(BetaResponseFunctionCallArgumentsWsDelta, other.BetaResponseFunctionCallArgumentsWsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2>?>.Default.Equals(BetaResponseFunctionCallArgumentsWsDone, other.BetaResponseFunctionCallArgumentsWsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsAdded2>?>.Default.Equals(BetaResponseShellCallCommandWsAdded, other.BetaResponseShellCallCommandWsAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDelta2>?>.Default.Equals(BetaResponseShellCallCommandWsDelta, other.BetaResponseShellCallCommandWsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDone2>?>.Default.Equals(BetaResponseShellCallCommandWsDone, other.BetaResponseShellCallCommandWsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDelta2>?>.Default.Equals(BetaResponseShellCallOutputContentWsDelta, other.BetaResponseShellCallOutputContentWsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDone2>?>.Default.Equals(BetaResponseShellCallOutputContentWsDone, other.BetaResponseShellCallOutputContentWsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseInWsProgress2>?>.Default.Equals(BetaResponseInWsProgress, other.BetaResponseInWsProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsFailed2>?>.Default.Equals(BetaResponseWsFailed, other.BetaResponseWsFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseIncompleteEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsIncomplete2>?>.Default.Equals(BetaResponseWsIncomplete, other.BetaResponseWsIncomplete) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsAdded2>?>.Default.Equals(BetaResponseOutputItemWsAdded, other.BetaResponseOutputItemWsAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsDone2>?>.Default.Equals(BetaResponseOutputItemWsDone, other.BetaResponseOutputItemWsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsAdded2>?>.Default.Equals(BetaResponseReasoningSummaryPartWsAdded, other.BetaResponseReasoningSummaryPartWsAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsDone2>?>.Default.Equals(BetaResponseReasoningSummaryPartWsDone, other.BetaResponseReasoningSummaryPartWsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDelta2>?>.Default.Equals(BetaResponseReasoningSummaryTextWsDelta, other.BetaResponseReasoningSummaryTextWsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDone2>?>.Default.Equals(BetaResponseReasoningSummaryTextWsDone, other.BetaResponseReasoningSummaryTextWsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDelta2>?>.Default.Equals(BetaResponseReasoningTextWsDelta, other.BetaResponseReasoningTextWsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDone2>?>.Default.Equals(BetaResponseReasoningTextWsDone, other.BetaResponseReasoningTextWsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDelta2>?>.Default.Equals(BetaResponseRefusalWsDelta, other.BetaResponseRefusalWsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDone2>?>.Default.Equals(BetaResponseRefusalWsDone, other.BetaResponseRefusalWsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDelta2>?>.Default.Equals(BetaResponseTextWsDelta, other.BetaResponseTextWsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDone2>?>.Default.Equals(BetaResponseTextWsDone, other.BetaResponseTextWsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsCompleted2>?>.Default.Equals(BetaResponseWebSearchCallWsCompleted, other.BetaResponseWebSearchCallWsCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallInWsProgress2>?>.Default.Equals(BetaResponseWebSearchCallInWsProgress, other.BetaResponseWebSearchCallInWsProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsSearching2>?>.Default.Equals(BetaResponseWebSearchCallWsSearching, other.BetaResponseWebSearchCallWsSearching) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsCompleted2>?>.Default.Equals(BetaResponseImageGenCallWsCompleted, other.BetaResponseImageGenCallWsCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsGenerating2>?>.Default.Equals(BetaResponseImageGenCallWsGenerating, other.BetaResponseImageGenCallWsGenerating) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallInWsProgress2>?>.Default.Equals(BetaResponseImageGenCallInWsProgress, other.BetaResponseImageGenCallInWsProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallPartialWsImage2>?>.Default.Equals(BetaResponseImageGenCallPartialWsImage, other.BetaResponseImageGenCallPartialWsImage) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDelta2>?>.Default.Equals(BetaResponseMcpCallArgumentsWsDelta, other.BetaResponseMcpCallArgumentsWsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDone2>?>.Default.Equals(BetaResponseMcpCallArgumentsWsDone, other.BetaResponseMcpCallArgumentsWsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsCompleted2>?>.Default.Equals(BetaResponseMcpCallWsCompleted, other.BetaResponseMcpCallWsCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsFailed2>?>.Default.Equals(BetaResponseMcpCallWsFailed, other.BetaResponseMcpCallWsFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallInWsProgress2>?>.Default.Equals(BetaResponseMcpCallInWsProgress, other.BetaResponseMcpCallInWsProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsCompleted2>?>.Default.Equals(BetaResponseMcpListToolsWsCompleted, other.BetaResponseMcpListToolsWsCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsFailed2>?>.Default.Equals(BetaResponseMcpListToolsWsFailed, other.BetaResponseMcpListToolsWsFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsInWsProgress2>?>.Default.Equals(BetaResponseMcpListToolsInWsProgress, other.BetaResponseMcpListToolsInWsProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputTextAnnotationWsAdded2>?>.Default.Equals(BetaResponseOutputTextAnnotationWsAdded, other.BetaResponseOutputTextAnnotationWsAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseQueuedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsQueued2>?>.Default.Equals(BetaResponseWsQueued, other.BetaResponseWsQueued) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDelta2>?>.Default.Equals(BetaResponseCustomToolCallInputWsDelta, other.BetaResponseCustomToolCallInputWsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDone2>?>.Default.Equals(BetaResponseCustomToolCallInputWsDone, other.BetaResponseCustomToolCallInputWsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseWsError?>.Default.Equals(Error, other.Error) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseSteerAcceptedEvent?>.Default.Equals(ResponseSteerAccepted, other.ResponseSteerAccepted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseSteerPendingEvent?>.Default.Equals(ResponseSteerPending, other.ResponseSteerPending) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseSteerFailedEvent?>.Default.Equals(ResponseSteerFailed, other.ResponseSteerFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent?>.Default.Equals(ResponseInjectCreated, other.ResponseInjectCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseInjectFailedEvent?>.Default.Equals(ResponseInjectFailed, other.ResponseInjectFailed)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaResponsesServerEvent obj1, BetaResponsesServerEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaResponsesServerEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaResponsesServerEvent obj1, BetaResponsesServerEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaResponsesServerEvent o && Equals(o);
        }
    }
}
