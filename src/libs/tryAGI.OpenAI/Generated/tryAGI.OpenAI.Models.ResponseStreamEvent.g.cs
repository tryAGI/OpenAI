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
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseAudioDeltaEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseAudioDeltaEvent?)value);

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
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseAudioDoneEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseAudioDoneEvent?)value);

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
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent?)value);

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
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent?)value);

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
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent?)value);

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
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent?)value);

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
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent?)value);

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
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent?)value);

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
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent?)value);

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
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseCompletedEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseCompletedEvent?)value);

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
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseContentPartAddedEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseContentPartAddedEvent?)value);

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
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseContentPartDoneEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseContentPartDoneEvent?)value);

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
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseCreatedEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseCreatedEvent?)value);

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
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent?)value);

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
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent?)value);

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
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent?)value);

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
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent?)value);

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
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent?)value);

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
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseInProgressEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseInProgressEvent?)value);

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
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseFailedEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseFailedEvent?)value);

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
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseIncompleteEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseIncompleteEvent?)value);

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
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseOutputItemAddedEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseOutputItemAddedEvent?)value);

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
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseOutputItemDoneEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseOutputItemDoneEvent?)value);

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
        /// Emitted when a new reasoning summary part is added.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent? ReasoningSummaryPartAdded { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent? ReasoningSummaryPartAdded { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningSummaryPartAdded))]
#endif
        public bool IsReasoningSummaryPartAdded => ReasoningSummaryPartAdded != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent?(ResponseStreamEvent @this) => @this.ReasoningSummaryPartAdded;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent? value)
        {
            ReasoningSummaryPartAdded = value;
        }

        /// <summary>
        /// Emitted when a reasoning summary part is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent? ReasoningSummaryPartDone { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent? ReasoningSummaryPartDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningSummaryPartDone))]
#endif
        public bool IsReasoningSummaryPartDone => ReasoningSummaryPartDone != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent?(ResponseStreamEvent @this) => @this.ReasoningSummaryPartDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent? value)
        {
            ReasoningSummaryPartDone = value;
        }

        /// <summary>
        /// Emitted when a delta is added to a reasoning summary text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent? ReasoningSummaryTextDelta { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent? ReasoningSummaryTextDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningSummaryTextDelta))]
#endif
        public bool IsReasoningSummaryTextDelta => ReasoningSummaryTextDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent?(ResponseStreamEvent @this) => @this.ReasoningSummaryTextDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent? value)
        {
            ReasoningSummaryTextDelta = value;
        }

        /// <summary>
        /// Emitted when a reasoning summary text is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent? ReasoningSummaryTextDone { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent? ReasoningSummaryTextDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningSummaryTextDone))]
#endif
        public bool IsReasoningSummaryTextDone => ReasoningSummaryTextDone != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent?(ResponseStreamEvent @this) => @this.ReasoningSummaryTextDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent? value)
        {
            ReasoningSummaryTextDone = value;
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
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseRefusalDeltaEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseRefusalDeltaEvent?)value);

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
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseRefusalDoneEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseRefusalDoneEvent?)value);

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
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseTextDeltaEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseTextDeltaEvent?)value);

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
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseTextDoneEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseTextDoneEvent?)value);

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
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent?)value);

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
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent?)value);

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
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent?)value);

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
        /// Emitted when an image generation tool call has completed and the final image is available.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent? ImageGenCallCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent? ImageGenCallCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageGenCallCompleted))]
#endif
        public bool IsImageGenCallCompleted => ImageGenCallCompleted != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent?(ResponseStreamEvent @this) => @this.ImageGenCallCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent? value)
        {
            ImageGenCallCompleted = value;
        }

        /// <summary>
        /// Emitted when an image generation tool call is actively generating an image (intermediate state).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent? ImageGenCallGenerating { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent? ImageGenCallGenerating { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageGenCallGenerating))]
#endif
        public bool IsImageGenCallGenerating => ImageGenCallGenerating != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent?(ResponseStreamEvent @this) => @this.ImageGenCallGenerating;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent? value)
        {
            ImageGenCallGenerating = value;
        }

        /// <summary>
        /// Emitted when an image generation tool call is in progress.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent? ImageGenCallInProgress { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent? ImageGenCallInProgress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageGenCallInProgress))]
#endif
        public bool IsImageGenCallInProgress => ImageGenCallInProgress != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent?(ResponseStreamEvent @this) => @this.ImageGenCallInProgress;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent? value)
        {
            ImageGenCallInProgress = value;
        }

        /// <summary>
        /// Emitted when a partial image is available during image generation streaming.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent? ImageGenCallPartial { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent? ImageGenCallPartial { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageGenCallPartial))]
#endif
        public bool IsImageGenCallPartial => ImageGenCallPartial != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent?(ResponseStreamEvent @this) => @this.ImageGenCallPartial;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent? value)
        {
            ImageGenCallPartial = value;
        }

        /// <summary>
        /// Emitted when there is a delta (partial update) to the arguments of an MCP tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent? MCPCallArgumentsDelta { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent? MCPCallArgumentsDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MCPCallArgumentsDelta))]
#endif
        public bool IsMCPCallArgumentsDelta => MCPCallArgumentsDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent?(ResponseStreamEvent @this) => @this.MCPCallArgumentsDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent? value)
        {
            MCPCallArgumentsDelta = value;
        }

        /// <summary>
        /// Emitted when the arguments for an MCP tool call are finalized.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent? MCPCallArgumentsDone { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent? MCPCallArgumentsDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MCPCallArgumentsDone))]
#endif
        public bool IsMCPCallArgumentsDone => MCPCallArgumentsDone != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent?(ResponseStreamEvent @this) => @this.MCPCallArgumentsDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent? value)
        {
            MCPCallArgumentsDone = value;
        }

        /// <summary>
        /// Emitted when an MCP  tool call has completed successfully.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent? MCPCallCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent? MCPCallCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MCPCallCompleted))]
#endif
        public bool IsMCPCallCompleted => MCPCallCompleted != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent?(ResponseStreamEvent @this) => @this.MCPCallCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent? value)
        {
            MCPCallCompleted = value;
        }

        /// <summary>
        /// Emitted when an MCP  tool call has failed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseMCPCallFailedEvent? MCPCallFailed { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseMCPCallFailedEvent? MCPCallFailed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MCPCallFailed))]
#endif
        public bool IsMCPCallFailed => MCPCallFailed != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseMCPCallFailedEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseMCPCallFailedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseMCPCallFailedEvent?(ResponseStreamEvent @this) => @this.MCPCallFailed;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseMCPCallFailedEvent? value)
        {
            MCPCallFailed = value;
        }

        /// <summary>
        /// Emitted when an MCP  tool call is in progress.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent? MCPCallInProgress { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent? MCPCallInProgress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MCPCallInProgress))]
#endif
        public bool IsMCPCallInProgress => MCPCallInProgress != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent?(ResponseStreamEvent @this) => @this.MCPCallInProgress;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent? value)
        {
            MCPCallInProgress = value;
        }

        /// <summary>
        /// Emitted when the list of available MCP tools has been successfully retrieved.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent? MCPListToolsCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent? MCPListToolsCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MCPListToolsCompleted))]
#endif
        public bool IsMCPListToolsCompleted => MCPListToolsCompleted != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent?(ResponseStreamEvent @this) => @this.MCPListToolsCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent? value)
        {
            MCPListToolsCompleted = value;
        }

        /// <summary>
        /// Emitted when the attempt to list available MCP tools has failed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent? MCPListToolsFailed { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent? MCPListToolsFailed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MCPListToolsFailed))]
#endif
        public bool IsMCPListToolsFailed => MCPListToolsFailed != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent?(ResponseStreamEvent @this) => @this.MCPListToolsFailed;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent? value)
        {
            MCPListToolsFailed = value;
        }

        /// <summary>
        /// Emitted when the system is in the process of retrieving the list of available MCP tools.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent? MCPListToolsInProgress { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent? MCPListToolsInProgress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MCPListToolsInProgress))]
#endif
        public bool IsMCPListToolsInProgress => MCPListToolsInProgress != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent?(ResponseStreamEvent @this) => @this.MCPListToolsInProgress;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent? value)
        {
            MCPListToolsInProgress = value;
        }

        /// <summary>
        /// Emitted when an annotation is added to output text content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent? OutputTextAnnotationAdded { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent? OutputTextAnnotationAdded { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputTextAnnotationAdded))]
#endif
        public bool IsOutputTextAnnotationAdded => OutputTextAnnotationAdded != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent?(ResponseStreamEvent @this) => @this.OutputTextAnnotationAdded;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent? value)
        {
            OutputTextAnnotationAdded = value;
        }

        /// <summary>
        /// Emitted when a response is queued and waiting to be processed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseQueuedEvent? Queued { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseQueuedEvent? Queued { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Queued))]
#endif
        public bool IsQueued => Queued != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseQueuedEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseQueuedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseQueuedEvent?(ResponseStreamEvent @this) => @this.Queued;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseQueuedEvent? value)
        {
            Queued = value;
        }

        /// <summary>
        /// Emitted when there is a delta (partial update) to the reasoning content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseReasoningDeltaEvent? ReasoningDelta { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseReasoningDeltaEvent? ReasoningDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningDelta))]
#endif
        public bool IsReasoningDelta => ReasoningDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseReasoningDeltaEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseReasoningDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseReasoningDeltaEvent?(ResponseStreamEvent @this) => @this.ReasoningDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseReasoningDeltaEvent? value)
        {
            ReasoningDelta = value;
        }

        /// <summary>
        /// Emitted when the reasoning content is finalized for an item.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseReasoningDoneEvent? ReasoningDone { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseReasoningDoneEvent? ReasoningDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningDone))]
#endif
        public bool IsReasoningDone => ReasoningDone != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseReasoningDoneEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseReasoningDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseReasoningDoneEvent?(ResponseStreamEvent @this) => @this.ReasoningDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseReasoningDoneEvent? value)
        {
            ReasoningDone = value;
        }

        /// <summary>
        /// Emitted when there is a delta (partial update) to the reasoning summary content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseReasoningSummaryDeltaEvent? ReasoningSummaryDelta { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseReasoningSummaryDeltaEvent? ReasoningSummaryDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningSummaryDelta))]
#endif
        public bool IsReasoningSummaryDelta => ReasoningSummaryDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseReasoningSummaryDeltaEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseReasoningSummaryDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseReasoningSummaryDeltaEvent?(ResponseStreamEvent @this) => @this.ReasoningSummaryDelta;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseReasoningSummaryDeltaEvent? value)
        {
            ReasoningSummaryDelta = value;
        }

        /// <summary>
        /// Emitted when the reasoning summary content is finalized for an item.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseReasoningSummaryDoneEvent? ReasoningSummaryDone { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseReasoningSummaryDoneEvent? ReasoningSummaryDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningSummaryDone))]
#endif
        public bool IsReasoningSummaryDone => ReasoningSummaryDone != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::tryAGI.OpenAI.ResponseReasoningSummaryDoneEvent value) => new ResponseStreamEvent((global::tryAGI.OpenAI.ResponseReasoningSummaryDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseReasoningSummaryDoneEvent?(ResponseStreamEvent @this) => @this.ReasoningSummaryDone;

        /// <summary>
        /// 
        /// </summary>
        public ResponseStreamEvent(global::tryAGI.OpenAI.ResponseReasoningSummaryDoneEvent? value)
        {
            ReasoningSummaryDone = value;
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
            global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent? reasoningSummaryPartAdded,
            global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent? reasoningSummaryPartDone,
            global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent? reasoningSummaryTextDelta,
            global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent? reasoningSummaryTextDone,
            global::tryAGI.OpenAI.ResponseRefusalDeltaEvent? refusalDelta,
            global::tryAGI.OpenAI.ResponseRefusalDoneEvent? refusalDone,
            global::tryAGI.OpenAI.ResponseTextDeltaEvent? textDelta,
            global::tryAGI.OpenAI.ResponseTextDoneEvent? textDone,
            global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent? webSearchCallCompleted,
            global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent? webSearchCallInProgress,
            global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent? webSearchCallSearching,
            global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent? imageGenCallCompleted,
            global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent? imageGenCallGenerating,
            global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent? imageGenCallInProgress,
            global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent? imageGenCallPartial,
            global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent? mCPCallArgumentsDelta,
            global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent? mCPCallArgumentsDone,
            global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent? mCPCallCompleted,
            global::tryAGI.OpenAI.ResponseMCPCallFailedEvent? mCPCallFailed,
            global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent? mCPCallInProgress,
            global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent? mCPListToolsCompleted,
            global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent? mCPListToolsFailed,
            global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent? mCPListToolsInProgress,
            global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent? outputTextAnnotationAdded,
            global::tryAGI.OpenAI.ResponseQueuedEvent? queued,
            global::tryAGI.OpenAI.ResponseReasoningDeltaEvent? reasoningDelta,
            global::tryAGI.OpenAI.ResponseReasoningDoneEvent? reasoningDone,
            global::tryAGI.OpenAI.ResponseReasoningSummaryDeltaEvent? reasoningSummaryDelta,
            global::tryAGI.OpenAI.ResponseReasoningSummaryDoneEvent? reasoningSummaryDone
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
            ReasoningSummaryPartAdded = reasoningSummaryPartAdded;
            ReasoningSummaryPartDone = reasoningSummaryPartDone;
            ReasoningSummaryTextDelta = reasoningSummaryTextDelta;
            ReasoningSummaryTextDone = reasoningSummaryTextDone;
            RefusalDelta = refusalDelta;
            RefusalDone = refusalDone;
            TextDelta = textDelta;
            TextDone = textDone;
            WebSearchCallCompleted = webSearchCallCompleted;
            WebSearchCallInProgress = webSearchCallInProgress;
            WebSearchCallSearching = webSearchCallSearching;
            ImageGenCallCompleted = imageGenCallCompleted;
            ImageGenCallGenerating = imageGenCallGenerating;
            ImageGenCallInProgress = imageGenCallInProgress;
            ImageGenCallPartial = imageGenCallPartial;
            MCPCallArgumentsDelta = mCPCallArgumentsDelta;
            MCPCallArgumentsDone = mCPCallArgumentsDone;
            MCPCallCompleted = mCPCallCompleted;
            MCPCallFailed = mCPCallFailed;
            MCPCallInProgress = mCPCallInProgress;
            MCPListToolsCompleted = mCPListToolsCompleted;
            MCPListToolsFailed = mCPListToolsFailed;
            MCPListToolsInProgress = mCPListToolsInProgress;
            OutputTextAnnotationAdded = outputTextAnnotationAdded;
            Queued = queued;
            ReasoningDelta = reasoningDelta;
            ReasoningDone = reasoningDone;
            ReasoningSummaryDelta = reasoningSummaryDelta;
            ReasoningSummaryDone = reasoningSummaryDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ReasoningSummaryDone as object ??
            ReasoningSummaryDelta as object ??
            ReasoningDone as object ??
            ReasoningDelta as object ??
            Queued as object ??
            OutputTextAnnotationAdded as object ??
            MCPListToolsInProgress as object ??
            MCPListToolsFailed as object ??
            MCPListToolsCompleted as object ??
            MCPCallInProgress as object ??
            MCPCallFailed as object ??
            MCPCallCompleted as object ??
            MCPCallArgumentsDone as object ??
            MCPCallArgumentsDelta as object ??
            ImageGenCallPartial as object ??
            ImageGenCallInProgress as object ??
            ImageGenCallGenerating as object ??
            ImageGenCallCompleted as object ??
            WebSearchCallSearching as object ??
            WebSearchCallInProgress as object ??
            WebSearchCallCompleted as object ??
            TextDone as object ??
            TextDelta as object ??
            RefusalDone as object ??
            RefusalDelta as object ??
            ReasoningSummaryTextDone as object ??
            ReasoningSummaryTextDelta as object ??
            ReasoningSummaryPartDone as object ??
            ReasoningSummaryPartAdded as object ??
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
        public override string? ToString() =>
            AudioDelta?.ToString() ??
            AudioDone?.ToString() ??
            AudioTranscriptDelta?.ToString() ??
            AudioTranscriptDone?.ToString() ??
            CodeInterpreterCallDelta?.ToString() ??
            CodeInterpreterCallDone?.ToString() ??
            CodeInterpreterCallCompleted?.ToString() ??
            CodeInterpreterCallInProgress?.ToString() ??
            CodeInterpreterCallInterpreting?.ToString() ??
            Completed?.ToString() ??
            ContentPartAdded?.ToString() ??
            ContentPartDone?.ToString() ??
            Created?.ToString() ??
            Error?.ToString() ??
            FileSearchCallCompleted?.ToString() ??
            FileSearchCallInProgress?.ToString() ??
            FileSearchCallSearching?.ToString() ??
            FunctionCallArgumentsDelta?.ToString() ??
            FunctionCallArgumentsDone?.ToString() ??
            InProgress?.ToString() ??
            Failed?.ToString() ??
            Incomplete?.ToString() ??
            OutputItemAdded?.ToString() ??
            OutputItemDone?.ToString() ??
            ReasoningSummaryPartAdded?.ToString() ??
            ReasoningSummaryPartDone?.ToString() ??
            ReasoningSummaryTextDelta?.ToString() ??
            ReasoningSummaryTextDone?.ToString() ??
            RefusalDelta?.ToString() ??
            RefusalDone?.ToString() ??
            TextDelta?.ToString() ??
            TextDone?.ToString() ??
            WebSearchCallCompleted?.ToString() ??
            WebSearchCallInProgress?.ToString() ??
            WebSearchCallSearching?.ToString() ??
            ImageGenCallCompleted?.ToString() ??
            ImageGenCallGenerating?.ToString() ??
            ImageGenCallInProgress?.ToString() ??
            ImageGenCallPartial?.ToString() ??
            MCPCallArgumentsDelta?.ToString() ??
            MCPCallArgumentsDone?.ToString() ??
            MCPCallCompleted?.ToString() ??
            MCPCallFailed?.ToString() ??
            MCPCallInProgress?.ToString() ??
            MCPListToolsCompleted?.ToString() ??
            MCPListToolsFailed?.ToString() ??
            MCPListToolsInProgress?.ToString() ??
            OutputTextAnnotationAdded?.ToString() ??
            Queued?.ToString() ??
            ReasoningDelta?.ToString() ??
            ReasoningDone?.ToString() ??
            ReasoningSummaryDelta?.ToString() ??
            ReasoningSummaryDone?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAudioDelta || IsAudioDone || IsAudioTranscriptDelta || IsAudioTranscriptDone || IsCodeInterpreterCallDelta || IsCodeInterpreterCallDone || IsCodeInterpreterCallCompleted || IsCodeInterpreterCallInProgress || IsCodeInterpreterCallInterpreting || IsCompleted || IsContentPartAdded || IsContentPartDone || IsCreated || IsError || IsFileSearchCallCompleted || IsFileSearchCallInProgress || IsFileSearchCallSearching || IsFunctionCallArgumentsDelta || IsFunctionCallArgumentsDone || IsInProgress || IsFailed || IsIncomplete || IsOutputItemAdded || IsOutputItemDone || IsReasoningSummaryPartAdded || IsReasoningSummaryPartDone || IsReasoningSummaryTextDelta || IsReasoningSummaryTextDone || IsRefusalDelta || IsRefusalDone || IsTextDelta || IsTextDone || IsWebSearchCallCompleted || IsWebSearchCallInProgress || IsWebSearchCallSearching || IsImageGenCallCompleted || IsImageGenCallGenerating || IsImageGenCallInProgress || IsImageGenCallPartial || IsMCPCallArgumentsDelta || IsMCPCallArgumentsDone || IsMCPCallCompleted || IsMCPCallFailed || IsMCPCallInProgress || IsMCPListToolsCompleted || IsMCPListToolsFailed || IsMCPListToolsInProgress || IsOutputTextAnnotationAdded || IsQueued || IsReasoningDelta || IsReasoningDone || IsReasoningSummaryDelta || IsReasoningSummaryDone;
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
            global::System.Func<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent?, TResult>? reasoningSummaryPartAdded = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent?, TResult>? reasoningSummaryPartDone = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent?, TResult>? reasoningSummaryTextDelta = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent?, TResult>? reasoningSummaryTextDone = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent?, TResult>? refusalDelta = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseRefusalDoneEvent?, TResult>? refusalDone = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseTextDeltaEvent?, TResult>? textDelta = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseTextDoneEvent?, TResult>? textDone = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent?, TResult>? webSearchCallCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent?, TResult>? webSearchCallInProgress = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent?, TResult>? webSearchCallSearching = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent?, TResult>? imageGenCallCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent?, TResult>? imageGenCallGenerating = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent?, TResult>? imageGenCallInProgress = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent?, TResult>? imageGenCallPartial = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent?, TResult>? mCPCallArgumentsDelta = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent?, TResult>? mCPCallArgumentsDone = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent?, TResult>? mCPCallCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent?, TResult>? mCPCallFailed = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent?, TResult>? mCPCallInProgress = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent?, TResult>? mCPListToolsCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent?, TResult>? mCPListToolsFailed = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent?, TResult>? mCPListToolsInProgress = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent?, TResult>? outputTextAnnotationAdded = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseQueuedEvent?, TResult>? queued = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseReasoningDeltaEvent?, TResult>? reasoningDelta = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseReasoningDoneEvent?, TResult>? reasoningDone = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseReasoningSummaryDeltaEvent?, TResult>? reasoningSummaryDelta = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseReasoningSummaryDoneEvent?, TResult>? reasoningSummaryDone = null,
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
            else if (IsReasoningSummaryPartAdded && reasoningSummaryPartAdded != null)
            {
                return reasoningSummaryPartAdded(ReasoningSummaryPartAdded!);
            }
            else if (IsReasoningSummaryPartDone && reasoningSummaryPartDone != null)
            {
                return reasoningSummaryPartDone(ReasoningSummaryPartDone!);
            }
            else if (IsReasoningSummaryTextDelta && reasoningSummaryTextDelta != null)
            {
                return reasoningSummaryTextDelta(ReasoningSummaryTextDelta!);
            }
            else if (IsReasoningSummaryTextDone && reasoningSummaryTextDone != null)
            {
                return reasoningSummaryTextDone(ReasoningSummaryTextDone!);
            }
            else if (IsRefusalDelta && refusalDelta != null)
            {
                return refusalDelta(RefusalDelta!);
            }
            else if (IsRefusalDone && refusalDone != null)
            {
                return refusalDone(RefusalDone!);
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
            else if (IsImageGenCallCompleted && imageGenCallCompleted != null)
            {
                return imageGenCallCompleted(ImageGenCallCompleted!);
            }
            else if (IsImageGenCallGenerating && imageGenCallGenerating != null)
            {
                return imageGenCallGenerating(ImageGenCallGenerating!);
            }
            else if (IsImageGenCallInProgress && imageGenCallInProgress != null)
            {
                return imageGenCallInProgress(ImageGenCallInProgress!);
            }
            else if (IsImageGenCallPartial && imageGenCallPartial != null)
            {
                return imageGenCallPartial(ImageGenCallPartial!);
            }
            else if (IsMCPCallArgumentsDelta && mCPCallArgumentsDelta != null)
            {
                return mCPCallArgumentsDelta(MCPCallArgumentsDelta!);
            }
            else if (IsMCPCallArgumentsDone && mCPCallArgumentsDone != null)
            {
                return mCPCallArgumentsDone(MCPCallArgumentsDone!);
            }
            else if (IsMCPCallCompleted && mCPCallCompleted != null)
            {
                return mCPCallCompleted(MCPCallCompleted!);
            }
            else if (IsMCPCallFailed && mCPCallFailed != null)
            {
                return mCPCallFailed(MCPCallFailed!);
            }
            else if (IsMCPCallInProgress && mCPCallInProgress != null)
            {
                return mCPCallInProgress(MCPCallInProgress!);
            }
            else if (IsMCPListToolsCompleted && mCPListToolsCompleted != null)
            {
                return mCPListToolsCompleted(MCPListToolsCompleted!);
            }
            else if (IsMCPListToolsFailed && mCPListToolsFailed != null)
            {
                return mCPListToolsFailed(MCPListToolsFailed!);
            }
            else if (IsMCPListToolsInProgress && mCPListToolsInProgress != null)
            {
                return mCPListToolsInProgress(MCPListToolsInProgress!);
            }
            else if (IsOutputTextAnnotationAdded && outputTextAnnotationAdded != null)
            {
                return outputTextAnnotationAdded(OutputTextAnnotationAdded!);
            }
            else if (IsQueued && queued != null)
            {
                return queued(Queued!);
            }
            else if (IsReasoningDelta && reasoningDelta != null)
            {
                return reasoningDelta(ReasoningDelta!);
            }
            else if (IsReasoningDone && reasoningDone != null)
            {
                return reasoningDone(ReasoningDone!);
            }
            else if (IsReasoningSummaryDelta && reasoningSummaryDelta != null)
            {
                return reasoningSummaryDelta(ReasoningSummaryDelta!);
            }
            else if (IsReasoningSummaryDone && reasoningSummaryDone != null)
            {
                return reasoningSummaryDone(ReasoningSummaryDone!);
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
            global::System.Action<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent?>? reasoningSummaryPartAdded = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent?>? reasoningSummaryPartDone = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent?>? reasoningSummaryTextDelta = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent?>? reasoningSummaryTextDone = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent?>? refusalDelta = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseRefusalDoneEvent?>? refusalDone = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseTextDeltaEvent?>? textDelta = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseTextDoneEvent?>? textDone = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent?>? webSearchCallCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent?>? webSearchCallInProgress = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent?>? webSearchCallSearching = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent?>? imageGenCallCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent?>? imageGenCallGenerating = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent?>? imageGenCallInProgress = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent?>? imageGenCallPartial = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent?>? mCPCallArgumentsDelta = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent?>? mCPCallArgumentsDone = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent?>? mCPCallCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent?>? mCPCallFailed = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent?>? mCPCallInProgress = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent?>? mCPListToolsCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent?>? mCPListToolsFailed = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent?>? mCPListToolsInProgress = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent?>? outputTextAnnotationAdded = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseQueuedEvent?>? queued = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseReasoningDeltaEvent?>? reasoningDelta = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseReasoningDoneEvent?>? reasoningDone = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseReasoningSummaryDeltaEvent?>? reasoningSummaryDelta = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseReasoningSummaryDoneEvent?>? reasoningSummaryDone = null,
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
            else if (IsReasoningSummaryPartAdded)
            {
                reasoningSummaryPartAdded?.Invoke(ReasoningSummaryPartAdded!);
            }
            else if (IsReasoningSummaryPartDone)
            {
                reasoningSummaryPartDone?.Invoke(ReasoningSummaryPartDone!);
            }
            else if (IsReasoningSummaryTextDelta)
            {
                reasoningSummaryTextDelta?.Invoke(ReasoningSummaryTextDelta!);
            }
            else if (IsReasoningSummaryTextDone)
            {
                reasoningSummaryTextDone?.Invoke(ReasoningSummaryTextDone!);
            }
            else if (IsRefusalDelta)
            {
                refusalDelta?.Invoke(RefusalDelta!);
            }
            else if (IsRefusalDone)
            {
                refusalDone?.Invoke(RefusalDone!);
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
            else if (IsImageGenCallCompleted)
            {
                imageGenCallCompleted?.Invoke(ImageGenCallCompleted!);
            }
            else if (IsImageGenCallGenerating)
            {
                imageGenCallGenerating?.Invoke(ImageGenCallGenerating!);
            }
            else if (IsImageGenCallInProgress)
            {
                imageGenCallInProgress?.Invoke(ImageGenCallInProgress!);
            }
            else if (IsImageGenCallPartial)
            {
                imageGenCallPartial?.Invoke(ImageGenCallPartial!);
            }
            else if (IsMCPCallArgumentsDelta)
            {
                mCPCallArgumentsDelta?.Invoke(MCPCallArgumentsDelta!);
            }
            else if (IsMCPCallArgumentsDone)
            {
                mCPCallArgumentsDone?.Invoke(MCPCallArgumentsDone!);
            }
            else if (IsMCPCallCompleted)
            {
                mCPCallCompleted?.Invoke(MCPCallCompleted!);
            }
            else if (IsMCPCallFailed)
            {
                mCPCallFailed?.Invoke(MCPCallFailed!);
            }
            else if (IsMCPCallInProgress)
            {
                mCPCallInProgress?.Invoke(MCPCallInProgress!);
            }
            else if (IsMCPListToolsCompleted)
            {
                mCPListToolsCompleted?.Invoke(MCPListToolsCompleted!);
            }
            else if (IsMCPListToolsFailed)
            {
                mCPListToolsFailed?.Invoke(MCPListToolsFailed!);
            }
            else if (IsMCPListToolsInProgress)
            {
                mCPListToolsInProgress?.Invoke(MCPListToolsInProgress!);
            }
            else if (IsOutputTextAnnotationAdded)
            {
                outputTextAnnotationAdded?.Invoke(OutputTextAnnotationAdded!);
            }
            else if (IsQueued)
            {
                queued?.Invoke(Queued!);
            }
            else if (IsReasoningDelta)
            {
                reasoningDelta?.Invoke(ReasoningDelta!);
            }
            else if (IsReasoningDone)
            {
                reasoningDone?.Invoke(ReasoningDone!);
            }
            else if (IsReasoningSummaryDelta)
            {
                reasoningSummaryDelta?.Invoke(ReasoningSummaryDelta!);
            }
            else if (IsReasoningSummaryDone)
            {
                reasoningSummaryDone?.Invoke(ReasoningSummaryDone!);
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
                ReasoningSummaryPartAdded,
                typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent),
                ReasoningSummaryPartDone,
                typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent),
                ReasoningSummaryTextDelta,
                typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent),
                ReasoningSummaryTextDone,
                typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent),
                RefusalDelta,
                typeof(global::tryAGI.OpenAI.ResponseRefusalDeltaEvent),
                RefusalDone,
                typeof(global::tryAGI.OpenAI.ResponseRefusalDoneEvent),
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
                ImageGenCallCompleted,
                typeof(global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent),
                ImageGenCallGenerating,
                typeof(global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent),
                ImageGenCallInProgress,
                typeof(global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent),
                ImageGenCallPartial,
                typeof(global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent),
                MCPCallArgumentsDelta,
                typeof(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent),
                MCPCallArgumentsDone,
                typeof(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent),
                MCPCallCompleted,
                typeof(global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent),
                MCPCallFailed,
                typeof(global::tryAGI.OpenAI.ResponseMCPCallFailedEvent),
                MCPCallInProgress,
                typeof(global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent),
                MCPListToolsCompleted,
                typeof(global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent),
                MCPListToolsFailed,
                typeof(global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent),
                MCPListToolsInProgress,
                typeof(global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent),
                OutputTextAnnotationAdded,
                typeof(global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent),
                Queued,
                typeof(global::tryAGI.OpenAI.ResponseQueuedEvent),
                ReasoningDelta,
                typeof(global::tryAGI.OpenAI.ResponseReasoningDeltaEvent),
                ReasoningDone,
                typeof(global::tryAGI.OpenAI.ResponseReasoningDoneEvent),
                ReasoningSummaryDelta,
                typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryDeltaEvent),
                ReasoningSummaryDone,
                typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryDoneEvent),
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
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent?>.Default.Equals(ReasoningSummaryPartAdded, other.ReasoningSummaryPartAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent?>.Default.Equals(ReasoningSummaryPartDone, other.ReasoningSummaryPartDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent?>.Default.Equals(ReasoningSummaryTextDelta, other.ReasoningSummaryTextDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent?>.Default.Equals(ReasoningSummaryTextDone, other.ReasoningSummaryTextDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent?>.Default.Equals(RefusalDelta, other.RefusalDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseRefusalDoneEvent?>.Default.Equals(RefusalDone, other.RefusalDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseTextDeltaEvent?>.Default.Equals(TextDelta, other.TextDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseTextDoneEvent?>.Default.Equals(TextDone, other.TextDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent?>.Default.Equals(WebSearchCallCompleted, other.WebSearchCallCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent?>.Default.Equals(WebSearchCallInProgress, other.WebSearchCallInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent?>.Default.Equals(WebSearchCallSearching, other.WebSearchCallSearching) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent?>.Default.Equals(ImageGenCallCompleted, other.ImageGenCallCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent?>.Default.Equals(ImageGenCallGenerating, other.ImageGenCallGenerating) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent?>.Default.Equals(ImageGenCallInProgress, other.ImageGenCallInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent?>.Default.Equals(ImageGenCallPartial, other.ImageGenCallPartial) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent?>.Default.Equals(MCPCallArgumentsDelta, other.MCPCallArgumentsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent?>.Default.Equals(MCPCallArgumentsDone, other.MCPCallArgumentsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent?>.Default.Equals(MCPCallCompleted, other.MCPCallCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent?>.Default.Equals(MCPCallFailed, other.MCPCallFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent?>.Default.Equals(MCPCallInProgress, other.MCPCallInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent?>.Default.Equals(MCPListToolsCompleted, other.MCPListToolsCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent?>.Default.Equals(MCPListToolsFailed, other.MCPListToolsFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent?>.Default.Equals(MCPListToolsInProgress, other.MCPListToolsInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent?>.Default.Equals(OutputTextAnnotationAdded, other.OutputTextAnnotationAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseQueuedEvent?>.Default.Equals(Queued, other.Queued) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseReasoningDeltaEvent?>.Default.Equals(ReasoningDelta, other.ReasoningDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseReasoningDoneEvent?>.Default.Equals(ReasoningDone, other.ReasoningDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseReasoningSummaryDeltaEvent?>.Default.Equals(ReasoningSummaryDelta, other.ReasoningSummaryDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseReasoningSummaryDoneEvent?>.Default.Equals(ReasoningSummaryDone, other.ReasoningSummaryDone) 
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
