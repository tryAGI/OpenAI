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
        public global::tryAGI.OpenAI.ResponseAudioDeltaEvent? AudioDelta { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseAudioDeltaEvent? AudioDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioDelta))]
#endif
        public bool IsAudioDelta => AudioDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseAudioDeltaEvent value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseAudioDeltaEvent?(ResponseStreamEvent @this) => @this.AudioDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseAudioDeltaEvent? value)
        {
            AudioDelta = value;
        }

        /// <summary>
        /// Emitted when the audio response is complete.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseAudioDoneEvent? AudioDone { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseAudioDoneEvent? AudioDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioDone))]
#endif
        public bool IsAudioDone => AudioDone != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseAudioDoneEvent value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseAudioDoneEvent?(ResponseStreamEvent @this) => @this.AudioDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseAudioDoneEvent? value)
        {
            AudioDone = value;
        }

        /// <summary>
        /// Emitted when there is a partial transcript of audio.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent? AudioTranscriptDelta { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent? AudioTranscriptDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioTranscriptDelta))]
#endif
        public bool IsAudioTranscriptDelta => AudioTranscriptDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent?(ResponseStreamEvent @this) => @this.AudioTranscriptDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent? value)
        {
            AudioTranscriptDelta = value;
        }

        /// <summary>
        /// Emitted when the full audio transcript is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent? AudioTranscriptDone { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent? AudioTranscriptDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioTranscriptDone))]
#endif
        public bool IsAudioTranscriptDone => AudioTranscriptDone != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent?(ResponseStreamEvent @this) => @this.AudioTranscriptDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent? value)
        {
            AudioTranscriptDone = value;
        }

        /// <summary>
        /// Emitted when a partial code snippet is added by the code interpreter.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent? CodeInterpreterCallDelta { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent? CodeInterpreterCallDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreterCallDelta))]
#endif
        public bool IsCodeInterpreterCallDelta => CodeInterpreterCallDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent?(ResponseStreamEvent @this) => @this.CodeInterpreterCallDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent? value)
        {
            CodeInterpreterCallDelta = value;
        }

        /// <summary>
        /// Emitted when code snippet output is finalized by the code interpreter.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent? CodeInterpreterCallDone { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent? CodeInterpreterCallDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreterCallDone))]
#endif
        public bool IsCodeInterpreterCallDone => CodeInterpreterCallDone != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent?(ResponseStreamEvent @this) => @this.CodeInterpreterCallDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent? value)
        {
            CodeInterpreterCallDone = value;
        }

        /// <summary>
        /// Emitted when the code interpreter call is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent? CodeInterpreterCallCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent? CodeInterpreterCallCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreterCallCompleted))]
#endif
        public bool IsCodeInterpreterCallCompleted => CodeInterpreterCallCompleted != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent?(ResponseStreamEvent @this) => @this.CodeInterpreterCallCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent? value)
        {
            CodeInterpreterCallCompleted = value;
        }

        /// <summary>
        /// Emitted when a code interpreter call is in progress.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent? CodeInterpreterCallInProgress { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent? CodeInterpreterCallInProgress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreterCallInProgress))]
#endif
        public bool IsCodeInterpreterCallInProgress => CodeInterpreterCallInProgress != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent?(ResponseStreamEvent @this) => @this.CodeInterpreterCallInProgress;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent? value)
        {
            CodeInterpreterCallInProgress = value;
        }

        /// <summary>
        /// Emitted when the code interpreter is actively interpreting the code snippet.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent? CodeInterpreterCallInterpreting { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent? CodeInterpreterCallInterpreting { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreterCallInterpreting))]
#endif
        public bool IsCodeInterpreterCallInterpreting => CodeInterpreterCallInterpreting != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent?(ResponseStreamEvent @this) => @this.CodeInterpreterCallInterpreting;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent? value)
        {
            CodeInterpreterCallInterpreting = value;
        }

        /// <summary>
        /// Emitted when the model response is complete.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseCompletedEvent? Completed { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseCompletedEvent? Completed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Completed))]
#endif
        public bool IsCompleted => Completed != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseCompletedEvent value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseCompletedEvent?(ResponseStreamEvent @this) => @this.Completed;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseCompletedEvent? value)
        {
            Completed = value;
        }

        /// <summary>
        /// Emitted when a new content part is added.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseContentPartAddedEvent? ContentPartAdded { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseContentPartAddedEvent? ContentPartAdded { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentPartAdded))]
#endif
        public bool IsContentPartAdded => ContentPartAdded != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseContentPartAddedEvent value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseContentPartAddedEvent?(ResponseStreamEvent @this) => @this.ContentPartAdded;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseContentPartAddedEvent? value)
        {
            ContentPartAdded = value;
        }

        /// <summary>
        /// Emitted when a content part is done.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseContentPartDoneEvent? ContentPartDone { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseContentPartDoneEvent? ContentPartDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentPartDone))]
#endif
        public bool IsContentPartDone => ContentPartDone != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseContentPartDoneEvent value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseContentPartDoneEvent?(ResponseStreamEvent @this) => @this.ContentPartDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseContentPartDoneEvent? value)
        {
            ContentPartDone = value;
        }

        /// <summary>
        /// An event that is emitted when a response is created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseCreatedEvent? Created { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseCreatedEvent? Created { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Created))]
#endif
        public bool IsCreated => Created != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseCreatedEvent value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseCreatedEvent?(ResponseStreamEvent @this) => @this.Created;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseCreatedEvent? value)
        {
            Created = value;
        }

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
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseErrorEvent value) => new ResponseStreamEvent(value);

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
        /// Emitted when a file search call is completed (results found).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent? FileSearchCallCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent? FileSearchCallCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileSearchCallCompleted))]
#endif
        public bool IsFileSearchCallCompleted => FileSearchCallCompleted != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent?(ResponseStreamEvent @this) => @this.FileSearchCallCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent? value)
        {
            FileSearchCallCompleted = value;
        }

        /// <summary>
        /// Emitted when a file search call is initiated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent? FileSearchCallInProgress { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent? FileSearchCallInProgress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileSearchCallInProgress))]
#endif
        public bool IsFileSearchCallInProgress => FileSearchCallInProgress != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent?(ResponseStreamEvent @this) => @this.FileSearchCallInProgress;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent? value)
        {
            FileSearchCallInProgress = value;
        }

        /// <summary>
        /// Emitted when a file search is currently searching.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent? FileSearchCallSearching { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent? FileSearchCallSearching { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileSearchCallSearching))]
#endif
        public bool IsFileSearchCallSearching => FileSearchCallSearching != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent?(ResponseStreamEvent @this) => @this.FileSearchCallSearching;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent? value)
        {
            FileSearchCallSearching = value;
        }

        /// <summary>
        /// Emitted when there is a partial function-call arguments delta.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent? FunctionCallArgumentsDelta { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent? FunctionCallArgumentsDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCallArgumentsDelta))]
#endif
        public bool IsFunctionCallArgumentsDelta => FunctionCallArgumentsDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent?(ResponseStreamEvent @this) => @this.FunctionCallArgumentsDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent? value)
        {
            FunctionCallArgumentsDelta = value;
        }

        /// <summary>
        /// Emitted when function-call arguments are finalized.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent? FunctionCallArgumentsDone { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent? FunctionCallArgumentsDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCallArgumentsDone))]
#endif
        public bool IsFunctionCallArgumentsDone => FunctionCallArgumentsDone != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent?(ResponseStreamEvent @this) => @this.FunctionCallArgumentsDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent? value)
        {
            FunctionCallArgumentsDone = value;
        }

        /// <summary>
        /// Emitted when the response is in progress.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseInProgressEvent? InProgress { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseInProgressEvent? InProgress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InProgress))]
#endif
        public bool IsInProgress => InProgress != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseInProgressEvent value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseInProgressEvent?(ResponseStreamEvent @this) => @this.InProgress;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseInProgressEvent? value)
        {
            InProgress = value;
        }

        /// <summary>
        /// An event that is emitted when a response fails.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseFailedEvent? Failed { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseFailedEvent? Failed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Failed))]
#endif
        public bool IsFailed => Failed != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseFailedEvent value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseFailedEvent?(ResponseStreamEvent @this) => @this.Failed;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseFailedEvent? value)
        {
            Failed = value;
        }

        /// <summary>
        /// An event that is emitted when a response finishes as incomplete.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseIncompleteEvent? Incomplete { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseIncompleteEvent? Incomplete { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Incomplete))]
#endif
        public bool IsIncomplete => Incomplete != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseIncompleteEvent value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseIncompleteEvent?(ResponseStreamEvent @this) => @this.Incomplete;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseIncompleteEvent? value)
        {
            Incomplete = value;
        }

        /// <summary>
        /// Emitted when a new output item is added.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseOutputItemAddedEvent? OutputItemAdded { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseOutputItemAddedEvent? OutputItemAdded { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputItemAdded))]
#endif
        public bool IsOutputItemAdded => OutputItemAdded != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseOutputItemAddedEvent value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseOutputItemAddedEvent?(ResponseStreamEvent @this) => @this.OutputItemAdded;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseOutputItemAddedEvent? value)
        {
            OutputItemAdded = value;
        }

        /// <summary>
        /// Emitted when an output item is marked done.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseOutputItemDoneEvent? OutputItemDone { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseOutputItemDoneEvent? OutputItemDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputItemDone))]
#endif
        public bool IsOutputItemDone => OutputItemDone != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseOutputItemDoneEvent value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseOutputItemDoneEvent?(ResponseStreamEvent @this) => @this.OutputItemDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseOutputItemDoneEvent? value)
        {
            OutputItemDone = value;
        }

        /// <summary>
        /// Emitted when there is a partial refusal text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseRefusalDeltaEvent? RefusalDelta { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseRefusalDeltaEvent? RefusalDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RefusalDelta))]
#endif
        public bool IsRefusalDelta => RefusalDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseRefusalDeltaEvent value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseRefusalDeltaEvent?(ResponseStreamEvent @this) => @this.RefusalDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseRefusalDeltaEvent? value)
        {
            RefusalDelta = value;
        }

        /// <summary>
        /// Emitted when refusal text is finalized.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseRefusalDoneEvent? RefusalDone { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseRefusalDoneEvent? RefusalDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RefusalDone))]
#endif
        public bool IsRefusalDone => RefusalDone != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseRefusalDoneEvent value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseRefusalDoneEvent?(ResponseStreamEvent @this) => @this.RefusalDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseRefusalDoneEvent? value)
        {
            RefusalDone = value;
        }

        /// <summary>
        /// Emitted when a text annotation is added.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseTextAnnotationDeltaEvent? TextAnnotationDelta { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseTextAnnotationDeltaEvent? TextAnnotationDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextAnnotationDelta))]
#endif
        public bool IsTextAnnotationDelta => TextAnnotationDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseTextAnnotationDeltaEvent value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseTextAnnotationDeltaEvent?(ResponseStreamEvent @this) => @this.TextAnnotationDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseTextAnnotationDeltaEvent? value)
        {
            TextAnnotationDelta = value;
        }

        /// <summary>
        /// Emitted when there is an additional text delta.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseTextDeltaEvent? TextDelta { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseTextDeltaEvent? TextDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextDelta))]
#endif
        public bool IsTextDelta => TextDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseTextDeltaEvent value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseTextDeltaEvent?(ResponseStreamEvent @this) => @this.TextDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseTextDeltaEvent? value)
        {
            TextDelta = value;
        }

        /// <summary>
        /// Emitted when text content is finalized.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseTextDoneEvent? TextDone { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseTextDoneEvent? TextDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextDone))]
#endif
        public bool IsTextDone => TextDone != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseTextDoneEvent value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseTextDoneEvent?(ResponseStreamEvent @this) => @this.TextDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseTextDoneEvent? value)
        {
            TextDone = value;
        }

        /// <summary>
        /// Emitted when a web search call is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent? WebSearchCallCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent? WebSearchCallCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearchCallCompleted))]
#endif
        public bool IsWebSearchCallCompleted => WebSearchCallCompleted != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent?(ResponseStreamEvent @this) => @this.WebSearchCallCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent? value)
        {
            WebSearchCallCompleted = value;
        }

        /// <summary>
        /// Emitted when a web search call is initiated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent? WebSearchCallInProgress { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent? WebSearchCallInProgress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearchCallInProgress))]
#endif
        public bool IsWebSearchCallInProgress => WebSearchCallInProgress != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent?(ResponseStreamEvent @this) => @this.WebSearchCallInProgress;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent? value)
        {
            WebSearchCallInProgress = value;
        }

        /// <summary>
        /// Emitted when a web search call is executing.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent? WebSearchCallSearching { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent? WebSearchCallSearching { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearchCallSearching))]
#endif
        public bool IsWebSearchCallSearching => WebSearchCallSearching != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent value) => new ResponseStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent?(ResponseStreamEvent @this) => @this.WebSearchCallSearching;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent? value)
        {
            WebSearchCallSearching = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(
            global::tryAGI.OpenAI.ResponseAudioDeltaEvent? audioDelta,
            global::tryAGI.OpenAI.ResponseAudioDoneEvent? audioDone,
            global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent? audioTranscriptDelta,
            global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent? audioTranscriptDone,
            global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent? codeInterpreterCallDelta,
            global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent? codeInterpreterCallDone,
            global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent? codeInterpreterCallCompleted,
            global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent? codeInterpreterCallInProgress,
            global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent? codeInterpreterCallInterpreting,
            global::tryAGI.OpenAI.ResponseCompletedEvent? completed,
            global::tryAGI.OpenAI.ResponseContentPartAddedEvent? contentPartAdded,
            global::tryAGI.OpenAI.ResponseContentPartDoneEvent? contentPartDone,
            global::tryAGI.OpenAI.ResponseCreatedEvent? created,
            global::tryAGI.OpenAI.ResponseErrorEvent? error,
            global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent? fileSearchCallCompleted,
            global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent? fileSearchCallInProgress,
            global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent? fileSearchCallSearching,
            global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent? functionCallArgumentsDelta,
            global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent? functionCallArgumentsDone,
            global::tryAGI.OpenAI.ResponseInProgressEvent? inProgress,
            global::tryAGI.OpenAI.ResponseFailedEvent? failed,
            global::tryAGI.OpenAI.ResponseIncompleteEvent? incomplete,
            global::tryAGI.OpenAI.ResponseOutputItemAddedEvent? outputItemAdded,
            global::tryAGI.OpenAI.ResponseOutputItemDoneEvent? outputItemDone,
            global::tryAGI.OpenAI.ResponseRefusalDeltaEvent? refusalDelta,
            global::tryAGI.OpenAI.ResponseRefusalDoneEvent? refusalDone,
            global::tryAGI.OpenAI.ResponseTextAnnotationDeltaEvent? textAnnotationDelta,
            global::tryAGI.OpenAI.ResponseTextDeltaEvent? textDelta,
            global::tryAGI.OpenAI.ResponseTextDoneEvent? textDone,
            global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent? webSearchCallCompleted,
            global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent? webSearchCallInProgress,
            global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent? webSearchCallSearching
            )
        {
            AudioDelta = audioDelta;
            AudioDone = audioDone;
            AudioTranscriptDelta = audioTranscriptDelta;
            AudioTranscriptDone = audioTranscriptDone;
            CodeInterpreterCallDelta = codeInterpreterCallDelta;
            CodeInterpreterCallDone = codeInterpreterCallDone;
            CodeInterpreterCallCompleted = codeInterpreterCallCompleted;
            CodeInterpreterCallInProgress = codeInterpreterCallInProgress;
            CodeInterpreterCallInterpreting = codeInterpreterCallInterpreting;
            Completed = completed;
            ContentPartAdded = contentPartAdded;
            ContentPartDone = contentPartDone;
            Created = created;
            Error = error;
            FileSearchCallCompleted = fileSearchCallCompleted;
            FileSearchCallInProgress = fileSearchCallInProgress;
            FileSearchCallSearching = fileSearchCallSearching;
            FunctionCallArgumentsDelta = functionCallArgumentsDelta;
            FunctionCallArgumentsDone = functionCallArgumentsDone;
            InProgress = inProgress;
            Failed = failed;
            Incomplete = incomplete;
            OutputItemAdded = outputItemAdded;
            OutputItemDone = outputItemDone;
            RefusalDelta = refusalDelta;
            RefusalDone = refusalDone;
            TextAnnotationDelta = textAnnotationDelta;
            TextDelta = textDelta;
            TextDone = textDone;
            WebSearchCallCompleted = webSearchCallCompleted;
            WebSearchCallInProgress = webSearchCallInProgress;
            WebSearchCallSearching = webSearchCallSearching;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WebSearchCallSearching as object ??
            WebSearchCallInProgress as object ??
            WebSearchCallCompleted as object ??
            TextDone as object ??
            TextDelta as object ??
            TextAnnotationDelta as object ??
            RefusalDone as object ??
            RefusalDelta as object ??
            OutputItemDone as object ??
            OutputItemAdded as object ??
            Incomplete as object ??
            Failed as object ??
            InProgress as object ??
            FunctionCallArgumentsDone as object ??
            FunctionCallArgumentsDelta as object ??
            FileSearchCallSearching as object ??
            FileSearchCallInProgress as object ??
            FileSearchCallCompleted as object ??
            Error as object ??
            Created as object ??
            ContentPartDone as object ??
            ContentPartAdded as object ??
            Completed as object ??
            CodeInterpreterCallInterpreting as object ??
            CodeInterpreterCallInProgress as object ??
            CodeInterpreterCallCompleted as object ??
            CodeInterpreterCallDone as object ??
            CodeInterpreterCallDelta as object ??
            AudioTranscriptDone as object ??
            AudioTranscriptDelta as object ??
            AudioDone as object ??
            AudioDelta as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAudioDelta || IsAudioDone || IsAudioTranscriptDelta || IsAudioTranscriptDone || IsCodeInterpreterCallDelta || IsCodeInterpreterCallDone || IsCodeInterpreterCallCompleted || IsCodeInterpreterCallInProgress || IsCodeInterpreterCallInterpreting || IsCompleted || IsContentPartAdded || IsContentPartDone || IsCreated || IsError || IsFileSearchCallCompleted || IsFileSearchCallInProgress || IsFileSearchCallSearching || IsFunctionCallArgumentsDelta || IsFunctionCallArgumentsDone || IsInProgress || IsFailed || IsIncomplete || IsOutputItemAdded || IsOutputItemDone || IsRefusalDelta || IsRefusalDone || IsTextAnnotationDelta || IsTextDelta || IsTextDone || IsWebSearchCallCompleted || IsWebSearchCallInProgress || IsWebSearchCallSearching;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ResponseAudioDeltaEvent?, TResult>? audioDelta = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseAudioDoneEvent?, TResult>? audioDone = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent?, TResult>? audioTranscriptDelta = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent?, TResult>? audioTranscriptDone = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent?, TResult>? codeInterpreterCallDelta = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent?, TResult>? codeInterpreterCallDone = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent?, TResult>? codeInterpreterCallCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent?, TResult>? codeInterpreterCallInProgress = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent?, TResult>? codeInterpreterCallInterpreting = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseCompletedEvent?, TResult>? completed = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseContentPartAddedEvent?, TResult>? contentPartAdded = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseContentPartDoneEvent?, TResult>? contentPartDone = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseCreatedEvent?, TResult>? created = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseErrorEvent?, TResult>? error = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent?, TResult>? fileSearchCallCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent?, TResult>? fileSearchCallInProgress = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent?, TResult>? fileSearchCallSearching = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent?, TResult>? functionCallArgumentsDelta = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent?, TResult>? functionCallArgumentsDone = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseInProgressEvent?, TResult>? inProgress = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseFailedEvent?, TResult>? failed = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseIncompleteEvent?, TResult>? incomplete = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent?, TResult>? outputItemAdded = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent?, TResult>? outputItemDone = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent?, TResult>? refusalDelta = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseRefusalDoneEvent?, TResult>? refusalDone = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseTextAnnotationDeltaEvent?, TResult>? textAnnotationDelta = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseTextDeltaEvent?, TResult>? textDelta = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseTextDoneEvent?, TResult>? textDone = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent?, TResult>? webSearchCallCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent?, TResult>? webSearchCallInProgress = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent?, TResult>? webSearchCallSearching = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAudioDelta && audioDelta != null)
            {
                return audioDelta(AudioDelta!);
            }
            else if (IsAudioDone && audioDone != null)
            {
                return audioDone(AudioDone!);
            }
            else if (IsAudioTranscriptDelta && audioTranscriptDelta != null)
            {
                return audioTranscriptDelta(AudioTranscriptDelta!);
            }
            else if (IsAudioTranscriptDone && audioTranscriptDone != null)
            {
                return audioTranscriptDone(AudioTranscriptDone!);
            }
            else if (IsCodeInterpreterCallDelta && codeInterpreterCallDelta != null)
            {
                return codeInterpreterCallDelta(CodeInterpreterCallDelta!);
            }
            else if (IsCodeInterpreterCallDone && codeInterpreterCallDone != null)
            {
                return codeInterpreterCallDone(CodeInterpreterCallDone!);
            }
            else if (IsCodeInterpreterCallCompleted && codeInterpreterCallCompleted != null)
            {
                return codeInterpreterCallCompleted(CodeInterpreterCallCompleted!);
            }
            else if (IsCodeInterpreterCallInProgress && codeInterpreterCallInProgress != null)
            {
                return codeInterpreterCallInProgress(CodeInterpreterCallInProgress!);
            }
            else if (IsCodeInterpreterCallInterpreting && codeInterpreterCallInterpreting != null)
            {
                return codeInterpreterCallInterpreting(CodeInterpreterCallInterpreting!);
            }
            else if (IsCompleted && completed != null)
            {
                return completed(Completed!);
            }
            else if (IsContentPartAdded && contentPartAdded != null)
            {
                return contentPartAdded(ContentPartAdded!);
            }
            else if (IsContentPartDone && contentPartDone != null)
            {
                return contentPartDone(ContentPartDone!);
            }
            else if (IsCreated && created != null)
            {
                return created(Created!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }
            else if (IsFileSearchCallCompleted && fileSearchCallCompleted != null)
            {
                return fileSearchCallCompleted(FileSearchCallCompleted!);
            }
            else if (IsFileSearchCallInProgress && fileSearchCallInProgress != null)
            {
                return fileSearchCallInProgress(FileSearchCallInProgress!);
            }
            else if (IsFileSearchCallSearching && fileSearchCallSearching != null)
            {
                return fileSearchCallSearching(FileSearchCallSearching!);
            }
            else if (IsFunctionCallArgumentsDelta && functionCallArgumentsDelta != null)
            {
                return functionCallArgumentsDelta(FunctionCallArgumentsDelta!);
            }
            else if (IsFunctionCallArgumentsDone && functionCallArgumentsDone != null)
            {
                return functionCallArgumentsDone(FunctionCallArgumentsDone!);
            }
            else if (IsInProgress && inProgress != null)
            {
                return inProgress(InProgress!);
            }
            else if (IsFailed && failed != null)
            {
                return failed(Failed!);
            }
            else if (IsIncomplete && incomplete != null)
            {
                return incomplete(Incomplete!);
            }
            else if (IsOutputItemAdded && outputItemAdded != null)
            {
                return outputItemAdded(OutputItemAdded!);
            }
            else if (IsOutputItemDone && outputItemDone != null)
            {
                return outputItemDone(OutputItemDone!);
            }
            else if (IsRefusalDelta && refusalDelta != null)
            {
                return refusalDelta(RefusalDelta!);
            }
            else if (IsRefusalDone && refusalDone != null)
            {
                return refusalDone(RefusalDone!);
            }
            else if (IsTextAnnotationDelta && textAnnotationDelta != null)
            {
                return textAnnotationDelta(TextAnnotationDelta!);
            }
            else if (IsTextDelta && textDelta != null)
            {
                return textDelta(TextDelta!);
            }
            else if (IsTextDone && textDone != null)
            {
                return textDone(TextDone!);
            }
            else if (IsWebSearchCallCompleted && webSearchCallCompleted != null)
            {
                return webSearchCallCompleted(WebSearchCallCompleted!);
            }
            else if (IsWebSearchCallInProgress && webSearchCallInProgress != null)
            {
                return webSearchCallInProgress(WebSearchCallInProgress!);
            }
            else if (IsWebSearchCallSearching && webSearchCallSearching != null)
            {
                return webSearchCallSearching(WebSearchCallSearching!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.ResponseAudioDeltaEvent?>? audioDelta = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseAudioDoneEvent?>? audioDone = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent?>? audioTranscriptDelta = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent?>? audioTranscriptDone = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent?>? codeInterpreterCallDelta = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent?>? codeInterpreterCallDone = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent?>? codeInterpreterCallCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent?>? codeInterpreterCallInProgress = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent?>? codeInterpreterCallInterpreting = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseCompletedEvent?>? completed = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseContentPartAddedEvent?>? contentPartAdded = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseContentPartDoneEvent?>? contentPartDone = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseCreatedEvent?>? created = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseErrorEvent?>? error = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent?>? fileSearchCallCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent?>? fileSearchCallInProgress = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent?>? fileSearchCallSearching = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent?>? functionCallArgumentsDelta = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent?>? functionCallArgumentsDone = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseInProgressEvent?>? inProgress = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseFailedEvent?>? failed = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseIncompleteEvent?>? incomplete = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent?>? outputItemAdded = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent?>? outputItemDone = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent?>? refusalDelta = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseRefusalDoneEvent?>? refusalDone = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseTextAnnotationDeltaEvent?>? textAnnotationDelta = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseTextDeltaEvent?>? textDelta = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseTextDoneEvent?>? textDone = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent?>? webSearchCallCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent?>? webSearchCallInProgress = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent?>? webSearchCallSearching = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAudioDelta)
            {
                audioDelta?.Invoke(AudioDelta!);
            }
            else if (IsAudioDone)
            {
                audioDone?.Invoke(AudioDone!);
            }
            else if (IsAudioTranscriptDelta)
            {
                audioTranscriptDelta?.Invoke(AudioTranscriptDelta!);
            }
            else if (IsAudioTranscriptDone)
            {
                audioTranscriptDone?.Invoke(AudioTranscriptDone!);
            }
            else if (IsCodeInterpreterCallDelta)
            {
                codeInterpreterCallDelta?.Invoke(CodeInterpreterCallDelta!);
            }
            else if (IsCodeInterpreterCallDone)
            {
                codeInterpreterCallDone?.Invoke(CodeInterpreterCallDone!);
            }
            else if (IsCodeInterpreterCallCompleted)
            {
                codeInterpreterCallCompleted?.Invoke(CodeInterpreterCallCompleted!);
            }
            else if (IsCodeInterpreterCallInProgress)
            {
                codeInterpreterCallInProgress?.Invoke(CodeInterpreterCallInProgress!);
            }
            else if (IsCodeInterpreterCallInterpreting)
            {
                codeInterpreterCallInterpreting?.Invoke(CodeInterpreterCallInterpreting!);
            }
            else if (IsCompleted)
            {
                completed?.Invoke(Completed!);
            }
            else if (IsContentPartAdded)
            {
                contentPartAdded?.Invoke(ContentPartAdded!);
            }
            else if (IsContentPartDone)
            {
                contentPartDone?.Invoke(ContentPartDone!);
            }
            else if (IsCreated)
            {
                created?.Invoke(Created!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
            else if (IsFileSearchCallCompleted)
            {
                fileSearchCallCompleted?.Invoke(FileSearchCallCompleted!);
            }
            else if (IsFileSearchCallInProgress)
            {
                fileSearchCallInProgress?.Invoke(FileSearchCallInProgress!);
            }
            else if (IsFileSearchCallSearching)
            {
                fileSearchCallSearching?.Invoke(FileSearchCallSearching!);
            }
            else if (IsFunctionCallArgumentsDelta)
            {
                functionCallArgumentsDelta?.Invoke(FunctionCallArgumentsDelta!);
            }
            else if (IsFunctionCallArgumentsDone)
            {
                functionCallArgumentsDone?.Invoke(FunctionCallArgumentsDone!);
            }
            else if (IsInProgress)
            {
                inProgress?.Invoke(InProgress!);
            }
            else if (IsFailed)
            {
                failed?.Invoke(Failed!);
            }
            else if (IsIncomplete)
            {
                incomplete?.Invoke(Incomplete!);
            }
            else if (IsOutputItemAdded)
            {
                outputItemAdded?.Invoke(OutputItemAdded!);
            }
            else if (IsOutputItemDone)
            {
                outputItemDone?.Invoke(OutputItemDone!);
            }
            else if (IsRefusalDelta)
            {
                refusalDelta?.Invoke(RefusalDelta!);
            }
            else if (IsRefusalDone)
            {
                refusalDone?.Invoke(RefusalDone!);
            }
            else if (IsTextAnnotationDelta)
            {
                textAnnotationDelta?.Invoke(TextAnnotationDelta!);
            }
            else if (IsTextDelta)
            {
                textDelta?.Invoke(TextDelta!);
            }
            else if (IsTextDone)
            {
                textDone?.Invoke(TextDone!);
            }
            else if (IsWebSearchCallCompleted)
            {
                webSearchCallCompleted?.Invoke(WebSearchCallCompleted!);
            }
            else if (IsWebSearchCallInProgress)
            {
                webSearchCallInProgress?.Invoke(WebSearchCallInProgress!);
            }
            else if (IsWebSearchCallSearching)
            {
                webSearchCallSearching?.Invoke(WebSearchCallSearching!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AudioDelta,
                typeof(global::tryAGI.OpenAI.ResponseAudioDeltaEvent),
                AudioDone,
                typeof(global::tryAGI.OpenAI.ResponseAudioDoneEvent),
                AudioTranscriptDelta,
                typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent),
                AudioTranscriptDone,
                typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent),
                CodeInterpreterCallDelta,
                typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent),
                CodeInterpreterCallDone,
                typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent),
                CodeInterpreterCallCompleted,
                typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent),
                CodeInterpreterCallInProgress,
                typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent),
                CodeInterpreterCallInterpreting,
                typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent),
                Completed,
                typeof(global::tryAGI.OpenAI.ResponseCompletedEvent),
                ContentPartAdded,
                typeof(global::tryAGI.OpenAI.ResponseContentPartAddedEvent),
                ContentPartDone,
                typeof(global::tryAGI.OpenAI.ResponseContentPartDoneEvent),
                Created,
                typeof(global::tryAGI.OpenAI.ResponseCreatedEvent),
                Error,
                typeof(global::tryAGI.OpenAI.ResponseErrorEvent),
                FileSearchCallCompleted,
                typeof(global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent),
                FileSearchCallInProgress,
                typeof(global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent),
                FileSearchCallSearching,
                typeof(global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent),
                FunctionCallArgumentsDelta,
                typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent),
                FunctionCallArgumentsDone,
                typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent),
                InProgress,
                typeof(global::tryAGI.OpenAI.ResponseInProgressEvent),
                Failed,
                typeof(global::tryAGI.OpenAI.ResponseFailedEvent),
                Incomplete,
                typeof(global::tryAGI.OpenAI.ResponseIncompleteEvent),
                OutputItemAdded,
                typeof(global::tryAGI.OpenAI.ResponseOutputItemAddedEvent),
                OutputItemDone,
                typeof(global::tryAGI.OpenAI.ResponseOutputItemDoneEvent),
                RefusalDelta,
                typeof(global::tryAGI.OpenAI.ResponseRefusalDeltaEvent),
                RefusalDone,
                typeof(global::tryAGI.OpenAI.ResponseRefusalDoneEvent),
                TextAnnotationDelta,
                typeof(global::tryAGI.OpenAI.ResponseTextAnnotationDeltaEvent),
                TextDelta,
                typeof(global::tryAGI.OpenAI.ResponseTextDeltaEvent),
                TextDone,
                typeof(global::tryAGI.OpenAI.ResponseTextDoneEvent),
                WebSearchCallCompleted,
                typeof(global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent),
                WebSearchCallInProgress,
                typeof(global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent),
                WebSearchCallSearching,
                typeof(global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent),
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
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseAudioDeltaEvent?>.Default.Equals(AudioDelta, other.AudioDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseAudioDoneEvent?>.Default.Equals(AudioDone, other.AudioDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent?>.Default.Equals(AudioTranscriptDelta, other.AudioTranscriptDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent?>.Default.Equals(AudioTranscriptDone, other.AudioTranscriptDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent?>.Default.Equals(CodeInterpreterCallDelta, other.CodeInterpreterCallDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent?>.Default.Equals(CodeInterpreterCallDone, other.CodeInterpreterCallDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent?>.Default.Equals(CodeInterpreterCallCompleted, other.CodeInterpreterCallCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent?>.Default.Equals(CodeInterpreterCallInProgress, other.CodeInterpreterCallInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent?>.Default.Equals(CodeInterpreterCallInterpreting, other.CodeInterpreterCallInterpreting) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseCompletedEvent?>.Default.Equals(Completed, other.Completed) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseContentPartAddedEvent?>.Default.Equals(ContentPartAdded, other.ContentPartAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseContentPartDoneEvent?>.Default.Equals(ContentPartDone, other.ContentPartDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseCreatedEvent?>.Default.Equals(Created, other.Created) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseErrorEvent?>.Default.Equals(Error, other.Error) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent?>.Default.Equals(FileSearchCallCompleted, other.FileSearchCallCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent?>.Default.Equals(FileSearchCallInProgress, other.FileSearchCallInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent?>.Default.Equals(FileSearchCallSearching, other.FileSearchCallSearching) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent?>.Default.Equals(FunctionCallArgumentsDelta, other.FunctionCallArgumentsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent?>.Default.Equals(FunctionCallArgumentsDone, other.FunctionCallArgumentsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseInProgressEvent?>.Default.Equals(InProgress, other.InProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseFailedEvent?>.Default.Equals(Failed, other.Failed) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseIncompleteEvent?>.Default.Equals(Incomplete, other.Incomplete) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent?>.Default.Equals(OutputItemAdded, other.OutputItemAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent?>.Default.Equals(OutputItemDone, other.OutputItemDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent?>.Default.Equals(RefusalDelta, other.RefusalDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseRefusalDoneEvent?>.Default.Equals(RefusalDone, other.RefusalDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseTextAnnotationDeltaEvent?>.Default.Equals(TextAnnotationDelta, other.TextAnnotationDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseTextDeltaEvent?>.Default.Equals(TextDelta, other.TextDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseTextDoneEvent?>.Default.Equals(TextDone, other.TextDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent?>.Default.Equals(WebSearchCallCompleted, other.WebSearchCallCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent?>.Default.Equals(WebSearchCallInProgress, other.WebSearchCallInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent?>.Default.Equals(WebSearchCallSearching, other.WebSearchCallSearching) 
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
