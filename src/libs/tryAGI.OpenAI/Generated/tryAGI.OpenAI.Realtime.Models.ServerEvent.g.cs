#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ServerEvent : global::System.IEquatable<ServerEvent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.ServerEventDiscriminatorType? Type { get; }

        /// <summary>
        /// Returned when an error occurs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.ErrorPayload? Error { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.ErrorPayload? Error { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;

        /// <summary>
        /// Returned when a session is created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.SessionCreatedPayload? SessionCreated { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.SessionCreatedPayload? SessionCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionCreated))]
#endif
        public bool IsSessionCreated => SessionCreated != null;

        /// <summary>
        /// Returned when a session is updated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.SessionUpdatedPayload? SessionUpdated { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.SessionUpdatedPayload? SessionUpdated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionUpdated))]
#endif
        public bool IsSessionUpdated => SessionUpdated != null;

        /// <summary>
        /// Returned when a conversation is created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.ConversationCreatedPayload? ConversationCreated { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.ConversationCreatedPayload? ConversationCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationCreated))]
#endif
        public bool IsConversationCreated => ConversationCreated != null;

        /// <summary>
        /// Returned when a conversation item is created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.ConversationItemCreatedPayload? ConversationItemCreated { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.ConversationItemCreatedPayload? ConversationItemCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemCreated))]
#endif
        public bool IsConversationItemCreated => ConversationItemCreated != null;

        /// <summary>
        /// Returned when input audio transcription succeeds.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionCompletedPayload? ConversationItemInputAudioTranscriptionCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionCompletedPayload? ConversationItemInputAudioTranscriptionCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemInputAudioTranscriptionCompleted))]
#endif
        public bool IsConversationItemInputAudioTranscriptionCompleted => ConversationItemInputAudioTranscriptionCompleted != null;

        /// <summary>
        /// Returned when input audio transcription fails.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionFailedPayload? ConversationItemInputAudioTranscriptionFailed { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionFailedPayload? ConversationItemInputAudioTranscriptionFailed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemInputAudioTranscriptionFailed))]
#endif
        public bool IsConversationItemInputAudioTranscriptionFailed => ConversationItemInputAudioTranscriptionFailed != null;

        /// <summary>
        /// Returned when an assistant audio message item is truncated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.ConversationItemTruncatedPayload? ConversationItemTruncated { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.ConversationItemTruncatedPayload? ConversationItemTruncated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemTruncated))]
#endif
        public bool IsConversationItemTruncated => ConversationItemTruncated != null;

        /// <summary>
        /// Returned when an item in the conversation is deleted.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.ConversationItemDeletedPayload? ConversationItemDeleted { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.ConversationItemDeletedPayload? ConversationItemDeleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemDeleted))]
#endif
        public bool IsConversationItemDeleted => ConversationItemDeleted != null;

        /// <summary>
        /// Returned when an input audio buffer is committed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.InputAudioBufferCommittedPayload? InputAudioBufferCommitted { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.InputAudioBufferCommittedPayload? InputAudioBufferCommitted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudioBufferCommitted))]
#endif
        public bool IsInputAudioBufferCommitted => InputAudioBufferCommitted != null;

        /// <summary>
        /// Returned when the input audio buffer is cleared.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.InputAudioBufferClearedPayload? InputAudioBufferCleared { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.InputAudioBufferClearedPayload? InputAudioBufferCleared { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudioBufferCleared))]
#endif
        public bool IsInputAudioBufferCleared => InputAudioBufferCleared != null;

        /// <summary>
        /// Returned when speech is detected in server VAD mode.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.InputAudioBufferSpeechStartedPayload? InputAudioBufferSpeechStarted { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.InputAudioBufferSpeechStartedPayload? InputAudioBufferSpeechStarted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudioBufferSpeechStarted))]
#endif
        public bool IsInputAudioBufferSpeechStarted => InputAudioBufferSpeechStarted != null;

        /// <summary>
        /// Returned when speech stops in server VAD mode.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.InputAudioBufferSpeechStoppedPayload? InputAudioBufferSpeechStopped { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.InputAudioBufferSpeechStoppedPayload? InputAudioBufferSpeechStopped { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudioBufferSpeechStopped))]
#endif
        public bool IsInputAudioBufferSpeechStopped => InputAudioBufferSpeechStopped != null;

        /// <summary>
        /// Returned when a new Response is created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.ResponseCreatedPayload? ResponseCreated { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.ResponseCreatedPayload? ResponseCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCreated))]
#endif
        public bool IsResponseCreated => ResponseCreated != null;

        /// <summary>
        /// Returned when a Response is done streaming.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.ResponseDonePayload? ResponseDone { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.ResponseDonePayload? ResponseDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseDone))]
#endif
        public bool IsResponseDone => ResponseDone != null;

        /// <summary>
        /// Returned when a new Item is created during response generation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.ResponseOutputItemAddedPayload? ResponseOutputItemAdded { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.ResponseOutputItemAddedPayload? ResponseOutputItemAdded { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputItemAdded))]
#endif
        public bool IsResponseOutputItemAdded => ResponseOutputItemAdded != null;

        /// <summary>
        /// Returned when an Item is done streaming.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.ResponseOutputItemDonePayload? ResponseOutputItemDone { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.ResponseOutputItemDonePayload? ResponseOutputItemDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputItemDone))]
#endif
        public bool IsResponseOutputItemDone => ResponseOutputItemDone != null;

        /// <summary>
        /// Returned when a new content part is added to an assistant message item.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.ResponseContentPartAddedPayload? ResponseContentPartAdded { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.ResponseContentPartAddedPayload? ResponseContentPartAdded { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseContentPartAdded))]
#endif
        public bool IsResponseContentPartAdded => ResponseContentPartAdded != null;

        /// <summary>
        /// Returned when a content part is done streaming.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.ResponseContentPartDonePayload? ResponseContentPartDone { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.ResponseContentPartDonePayload? ResponseContentPartDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseContentPartDone))]
#endif
        public bool IsResponseContentPartDone => ResponseContentPartDone != null;

        /// <summary>
        /// Returned when the text value of a content part is updated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.ResponseTextDeltaPayload? ResponseTextDelta { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.ResponseTextDeltaPayload? ResponseTextDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseTextDelta))]
#endif
        public bool IsResponseTextDelta => ResponseTextDelta != null;

        /// <summary>
        /// Returned when the text value of a content part is done streaming.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.ResponseTextDonePayload? ResponseTextDone { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.ResponseTextDonePayload? ResponseTextDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseTextDone))]
#endif
        public bool IsResponseTextDone => ResponseTextDone != null;

        /// <summary>
        /// Returned when the model-generated transcription of audio output is updated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.ResponseAudioTranscriptDeltaPayload? ResponseAudioTranscriptDelta { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.ResponseAudioTranscriptDeltaPayload? ResponseAudioTranscriptDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseAudioTranscriptDelta))]
#endif
        public bool IsResponseAudioTranscriptDelta => ResponseAudioTranscriptDelta != null;

        /// <summary>
        /// Returned when the model-generated transcription of audio output is done.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.ResponseAudioTranscriptDonePayload? ResponseAudioTranscriptDone { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.ResponseAudioTranscriptDonePayload? ResponseAudioTranscriptDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseAudioTranscriptDone))]
#endif
        public bool IsResponseAudioTranscriptDone => ResponseAudioTranscriptDone != null;

        /// <summary>
        /// Returned when the model-generated audio is updated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.ResponseAudioDeltaPayload? ResponseAudioDelta { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.ResponseAudioDeltaPayload? ResponseAudioDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseAudioDelta))]
#endif
        public bool IsResponseAudioDelta => ResponseAudioDelta != null;

        /// <summary>
        /// Returned when the model-generated audio is done.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.ResponseAudioDonePayload? ResponseAudioDone { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.ResponseAudioDonePayload? ResponseAudioDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseAudioDone))]
#endif
        public bool IsResponseAudioDone => ResponseAudioDone != null;

        /// <summary>
        /// Returned when the model-generated function call arguments are updated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.ResponseFunctionCallArgumentsDeltaPayload? ResponseFunctionCallArgumentsDelta { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.ResponseFunctionCallArgumentsDeltaPayload? ResponseFunctionCallArgumentsDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFunctionCallArgumentsDelta))]
#endif
        public bool IsResponseFunctionCallArgumentsDelta => ResponseFunctionCallArgumentsDelta != null;

        /// <summary>
        /// Returned when the model-generated function call arguments are done streaming.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.ResponseFunctionCallArgumentsDonePayload? ResponseFunctionCallArgumentsDone { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.ResponseFunctionCallArgumentsDonePayload? ResponseFunctionCallArgumentsDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFunctionCallArgumentsDone))]
#endif
        public bool IsResponseFunctionCallArgumentsDone => ResponseFunctionCallArgumentsDone != null;

        /// <summary>
        /// Emitted after every response.done event to indicate updated rate limits.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RateLimitsUpdatedPayload? RateLimitsUpdated { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RateLimitsUpdatedPayload? RateLimitsUpdated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RateLimitsUpdated))]
#endif
        public bool IsRateLimitsUpdated => RateLimitsUpdated != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.ErrorPayload value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.ErrorPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.ErrorPayload?(ServerEvent @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.ErrorPayload? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.SessionCreatedPayload value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.SessionCreatedPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.SessionCreatedPayload?(ServerEvent @this) => @this.SessionCreated;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.SessionCreatedPayload? value)
        {
            SessionCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.SessionUpdatedPayload value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.SessionUpdatedPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.SessionUpdatedPayload?(ServerEvent @this) => @this.SessionUpdated;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.SessionUpdatedPayload? value)
        {
            SessionUpdated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.ConversationCreatedPayload value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.ConversationCreatedPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.ConversationCreatedPayload?(ServerEvent @this) => @this.ConversationCreated;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.ConversationCreatedPayload? value)
        {
            ConversationCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.ConversationItemCreatedPayload value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.ConversationItemCreatedPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.ConversationItemCreatedPayload?(ServerEvent @this) => @this.ConversationItemCreated;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.ConversationItemCreatedPayload? value)
        {
            ConversationItemCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionCompletedPayload value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionCompletedPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionCompletedPayload?(ServerEvent @this) => @this.ConversationItemInputAudioTranscriptionCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionCompletedPayload? value)
        {
            ConversationItemInputAudioTranscriptionCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionFailedPayload value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionFailedPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionFailedPayload?(ServerEvent @this) => @this.ConversationItemInputAudioTranscriptionFailed;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionFailedPayload? value)
        {
            ConversationItemInputAudioTranscriptionFailed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.ConversationItemTruncatedPayload value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.ConversationItemTruncatedPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.ConversationItemTruncatedPayload?(ServerEvent @this) => @this.ConversationItemTruncated;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.ConversationItemTruncatedPayload? value)
        {
            ConversationItemTruncated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.ConversationItemDeletedPayload value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.ConversationItemDeletedPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.ConversationItemDeletedPayload?(ServerEvent @this) => @this.ConversationItemDeleted;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.ConversationItemDeletedPayload? value)
        {
            ConversationItemDeleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.InputAudioBufferCommittedPayload value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.InputAudioBufferCommittedPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.InputAudioBufferCommittedPayload?(ServerEvent @this) => @this.InputAudioBufferCommitted;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.InputAudioBufferCommittedPayload? value)
        {
            InputAudioBufferCommitted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.InputAudioBufferClearedPayload value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.InputAudioBufferClearedPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.InputAudioBufferClearedPayload?(ServerEvent @this) => @this.InputAudioBufferCleared;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.InputAudioBufferClearedPayload? value)
        {
            InputAudioBufferCleared = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.InputAudioBufferSpeechStartedPayload value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.InputAudioBufferSpeechStartedPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.InputAudioBufferSpeechStartedPayload?(ServerEvent @this) => @this.InputAudioBufferSpeechStarted;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.InputAudioBufferSpeechStartedPayload? value)
        {
            InputAudioBufferSpeechStarted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.InputAudioBufferSpeechStoppedPayload value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.InputAudioBufferSpeechStoppedPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.InputAudioBufferSpeechStoppedPayload?(ServerEvent @this) => @this.InputAudioBufferSpeechStopped;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.InputAudioBufferSpeechStoppedPayload? value)
        {
            InputAudioBufferSpeechStopped = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.ResponseCreatedPayload value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.ResponseCreatedPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.ResponseCreatedPayload?(ServerEvent @this) => @this.ResponseCreated;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.ResponseCreatedPayload? value)
        {
            ResponseCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.ResponseDonePayload value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.ResponseDonePayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.ResponseDonePayload?(ServerEvent @this) => @this.ResponseDone;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.ResponseDonePayload? value)
        {
            ResponseDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.ResponseOutputItemAddedPayload value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.ResponseOutputItemAddedPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.ResponseOutputItemAddedPayload?(ServerEvent @this) => @this.ResponseOutputItemAdded;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.ResponseOutputItemAddedPayload? value)
        {
            ResponseOutputItemAdded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.ResponseOutputItemDonePayload value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.ResponseOutputItemDonePayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.ResponseOutputItemDonePayload?(ServerEvent @this) => @this.ResponseOutputItemDone;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.ResponseOutputItemDonePayload? value)
        {
            ResponseOutputItemDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.ResponseContentPartAddedPayload value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.ResponseContentPartAddedPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.ResponseContentPartAddedPayload?(ServerEvent @this) => @this.ResponseContentPartAdded;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.ResponseContentPartAddedPayload? value)
        {
            ResponseContentPartAdded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.ResponseContentPartDonePayload value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.ResponseContentPartDonePayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.ResponseContentPartDonePayload?(ServerEvent @this) => @this.ResponseContentPartDone;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.ResponseContentPartDonePayload? value)
        {
            ResponseContentPartDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.ResponseTextDeltaPayload value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.ResponseTextDeltaPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.ResponseTextDeltaPayload?(ServerEvent @this) => @this.ResponseTextDelta;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.ResponseTextDeltaPayload? value)
        {
            ResponseTextDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.ResponseTextDonePayload value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.ResponseTextDonePayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.ResponseTextDonePayload?(ServerEvent @this) => @this.ResponseTextDone;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.ResponseTextDonePayload? value)
        {
            ResponseTextDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.ResponseAudioTranscriptDeltaPayload value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.ResponseAudioTranscriptDeltaPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.ResponseAudioTranscriptDeltaPayload?(ServerEvent @this) => @this.ResponseAudioTranscriptDelta;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.ResponseAudioTranscriptDeltaPayload? value)
        {
            ResponseAudioTranscriptDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.ResponseAudioTranscriptDonePayload value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.ResponseAudioTranscriptDonePayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.ResponseAudioTranscriptDonePayload?(ServerEvent @this) => @this.ResponseAudioTranscriptDone;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.ResponseAudioTranscriptDonePayload? value)
        {
            ResponseAudioTranscriptDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.ResponseAudioDeltaPayload value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.ResponseAudioDeltaPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.ResponseAudioDeltaPayload?(ServerEvent @this) => @this.ResponseAudioDelta;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.ResponseAudioDeltaPayload? value)
        {
            ResponseAudioDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.ResponseAudioDonePayload value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.ResponseAudioDonePayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.ResponseAudioDonePayload?(ServerEvent @this) => @this.ResponseAudioDone;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.ResponseAudioDonePayload? value)
        {
            ResponseAudioDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.ResponseFunctionCallArgumentsDeltaPayload value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.ResponseFunctionCallArgumentsDeltaPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.ResponseFunctionCallArgumentsDeltaPayload?(ServerEvent @this) => @this.ResponseFunctionCallArgumentsDelta;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.ResponseFunctionCallArgumentsDeltaPayload? value)
        {
            ResponseFunctionCallArgumentsDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.ResponseFunctionCallArgumentsDonePayload value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.ResponseFunctionCallArgumentsDonePayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.ResponseFunctionCallArgumentsDonePayload?(ServerEvent @this) => @this.ResponseFunctionCallArgumentsDone;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.ResponseFunctionCallArgumentsDonePayload? value)
        {
            ResponseFunctionCallArgumentsDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RateLimitsUpdatedPayload value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RateLimitsUpdatedPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RateLimitsUpdatedPayload?(ServerEvent @this) => @this.RateLimitsUpdated;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RateLimitsUpdatedPayload? value)
        {
            RateLimitsUpdated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(
            global::tryAGI.OpenAI.Realtime.ServerEventDiscriminatorType? type,
            global::tryAGI.OpenAI.Realtime.ErrorPayload? error,
            global::tryAGI.OpenAI.Realtime.SessionCreatedPayload? sessionCreated,
            global::tryAGI.OpenAI.Realtime.SessionUpdatedPayload? sessionUpdated,
            global::tryAGI.OpenAI.Realtime.ConversationCreatedPayload? conversationCreated,
            global::tryAGI.OpenAI.Realtime.ConversationItemCreatedPayload? conversationItemCreated,
            global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionCompletedPayload? conversationItemInputAudioTranscriptionCompleted,
            global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionFailedPayload? conversationItemInputAudioTranscriptionFailed,
            global::tryAGI.OpenAI.Realtime.ConversationItemTruncatedPayload? conversationItemTruncated,
            global::tryAGI.OpenAI.Realtime.ConversationItemDeletedPayload? conversationItemDeleted,
            global::tryAGI.OpenAI.Realtime.InputAudioBufferCommittedPayload? inputAudioBufferCommitted,
            global::tryAGI.OpenAI.Realtime.InputAudioBufferClearedPayload? inputAudioBufferCleared,
            global::tryAGI.OpenAI.Realtime.InputAudioBufferSpeechStartedPayload? inputAudioBufferSpeechStarted,
            global::tryAGI.OpenAI.Realtime.InputAudioBufferSpeechStoppedPayload? inputAudioBufferSpeechStopped,
            global::tryAGI.OpenAI.Realtime.ResponseCreatedPayload? responseCreated,
            global::tryAGI.OpenAI.Realtime.ResponseDonePayload? responseDone,
            global::tryAGI.OpenAI.Realtime.ResponseOutputItemAddedPayload? responseOutputItemAdded,
            global::tryAGI.OpenAI.Realtime.ResponseOutputItemDonePayload? responseOutputItemDone,
            global::tryAGI.OpenAI.Realtime.ResponseContentPartAddedPayload? responseContentPartAdded,
            global::tryAGI.OpenAI.Realtime.ResponseContentPartDonePayload? responseContentPartDone,
            global::tryAGI.OpenAI.Realtime.ResponseTextDeltaPayload? responseTextDelta,
            global::tryAGI.OpenAI.Realtime.ResponseTextDonePayload? responseTextDone,
            global::tryAGI.OpenAI.Realtime.ResponseAudioTranscriptDeltaPayload? responseAudioTranscriptDelta,
            global::tryAGI.OpenAI.Realtime.ResponseAudioTranscriptDonePayload? responseAudioTranscriptDone,
            global::tryAGI.OpenAI.Realtime.ResponseAudioDeltaPayload? responseAudioDelta,
            global::tryAGI.OpenAI.Realtime.ResponseAudioDonePayload? responseAudioDone,
            global::tryAGI.OpenAI.Realtime.ResponseFunctionCallArgumentsDeltaPayload? responseFunctionCallArgumentsDelta,
            global::tryAGI.OpenAI.Realtime.ResponseFunctionCallArgumentsDonePayload? responseFunctionCallArgumentsDone,
            global::tryAGI.OpenAI.Realtime.RateLimitsUpdatedPayload? rateLimitsUpdated
            )
        {
            Type = type;

            Error = error;
            SessionCreated = sessionCreated;
            SessionUpdated = sessionUpdated;
            ConversationCreated = conversationCreated;
            ConversationItemCreated = conversationItemCreated;
            ConversationItemInputAudioTranscriptionCompleted = conversationItemInputAudioTranscriptionCompleted;
            ConversationItemInputAudioTranscriptionFailed = conversationItemInputAudioTranscriptionFailed;
            ConversationItemTruncated = conversationItemTruncated;
            ConversationItemDeleted = conversationItemDeleted;
            InputAudioBufferCommitted = inputAudioBufferCommitted;
            InputAudioBufferCleared = inputAudioBufferCleared;
            InputAudioBufferSpeechStarted = inputAudioBufferSpeechStarted;
            InputAudioBufferSpeechStopped = inputAudioBufferSpeechStopped;
            ResponseCreated = responseCreated;
            ResponseDone = responseDone;
            ResponseOutputItemAdded = responseOutputItemAdded;
            ResponseOutputItemDone = responseOutputItemDone;
            ResponseContentPartAdded = responseContentPartAdded;
            ResponseContentPartDone = responseContentPartDone;
            ResponseTextDelta = responseTextDelta;
            ResponseTextDone = responseTextDone;
            ResponseAudioTranscriptDelta = responseAudioTranscriptDelta;
            ResponseAudioTranscriptDone = responseAudioTranscriptDone;
            ResponseAudioDelta = responseAudioDelta;
            ResponseAudioDone = responseAudioDone;
            ResponseFunctionCallArgumentsDelta = responseFunctionCallArgumentsDelta;
            ResponseFunctionCallArgumentsDone = responseFunctionCallArgumentsDone;
            RateLimitsUpdated = rateLimitsUpdated;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RateLimitsUpdated as object ??
            ResponseFunctionCallArgumentsDone as object ??
            ResponseFunctionCallArgumentsDelta as object ??
            ResponseAudioDone as object ??
            ResponseAudioDelta as object ??
            ResponseAudioTranscriptDone as object ??
            ResponseAudioTranscriptDelta as object ??
            ResponseTextDone as object ??
            ResponseTextDelta as object ??
            ResponseContentPartDone as object ??
            ResponseContentPartAdded as object ??
            ResponseOutputItemDone as object ??
            ResponseOutputItemAdded as object ??
            ResponseDone as object ??
            ResponseCreated as object ??
            InputAudioBufferSpeechStopped as object ??
            InputAudioBufferSpeechStarted as object ??
            InputAudioBufferCleared as object ??
            InputAudioBufferCommitted as object ??
            ConversationItemDeleted as object ??
            ConversationItemTruncated as object ??
            ConversationItemInputAudioTranscriptionFailed as object ??
            ConversationItemInputAudioTranscriptionCompleted as object ??
            ConversationItemCreated as object ??
            ConversationCreated as object ??
            SessionUpdated as object ??
            SessionCreated as object ??
            Error as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Error?.ToString() ??
            SessionCreated?.ToString() ??
            SessionUpdated?.ToString() ??
            ConversationCreated?.ToString() ??
            ConversationItemCreated?.ToString() ??
            ConversationItemInputAudioTranscriptionCompleted?.ToString() ??
            ConversationItemInputAudioTranscriptionFailed?.ToString() ??
            ConversationItemTruncated?.ToString() ??
            ConversationItemDeleted?.ToString() ??
            InputAudioBufferCommitted?.ToString() ??
            InputAudioBufferCleared?.ToString() ??
            InputAudioBufferSpeechStarted?.ToString() ??
            InputAudioBufferSpeechStopped?.ToString() ??
            ResponseCreated?.ToString() ??
            ResponseDone?.ToString() ??
            ResponseOutputItemAdded?.ToString() ??
            ResponseOutputItemDone?.ToString() ??
            ResponseContentPartAdded?.ToString() ??
            ResponseContentPartDone?.ToString() ??
            ResponseTextDelta?.ToString() ??
            ResponseTextDone?.ToString() ??
            ResponseAudioTranscriptDelta?.ToString() ??
            ResponseAudioTranscriptDone?.ToString() ??
            ResponseAudioDelta?.ToString() ??
            ResponseAudioDone?.ToString() ??
            ResponseFunctionCallArgumentsDelta?.ToString() ??
            ResponseFunctionCallArgumentsDone?.ToString() ??
            RateLimitsUpdated?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && IsRateLimitsUpdated;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.Realtime.ErrorPayload?, TResult>? error = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.SessionCreatedPayload?, TResult>? sessionCreated = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.SessionUpdatedPayload?, TResult>? sessionUpdated = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.ConversationCreatedPayload?, TResult>? conversationCreated = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.ConversationItemCreatedPayload?, TResult>? conversationItemCreated = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionCompletedPayload?, TResult>? conversationItemInputAudioTranscriptionCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionFailedPayload?, TResult>? conversationItemInputAudioTranscriptionFailed = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.ConversationItemTruncatedPayload?, TResult>? conversationItemTruncated = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.ConversationItemDeletedPayload?, TResult>? conversationItemDeleted = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.InputAudioBufferCommittedPayload?, TResult>? inputAudioBufferCommitted = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.InputAudioBufferClearedPayload?, TResult>? inputAudioBufferCleared = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.InputAudioBufferSpeechStartedPayload?, TResult>? inputAudioBufferSpeechStarted = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.InputAudioBufferSpeechStoppedPayload?, TResult>? inputAudioBufferSpeechStopped = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.ResponseCreatedPayload?, TResult>? responseCreated = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.ResponseDonePayload?, TResult>? responseDone = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.ResponseOutputItemAddedPayload?, TResult>? responseOutputItemAdded = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.ResponseOutputItemDonePayload?, TResult>? responseOutputItemDone = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.ResponseContentPartAddedPayload?, TResult>? responseContentPartAdded = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.ResponseContentPartDonePayload?, TResult>? responseContentPartDone = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.ResponseTextDeltaPayload?, TResult>? responseTextDelta = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.ResponseTextDonePayload?, TResult>? responseTextDone = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.ResponseAudioTranscriptDeltaPayload?, TResult>? responseAudioTranscriptDelta = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.ResponseAudioTranscriptDonePayload?, TResult>? responseAudioTranscriptDone = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.ResponseAudioDeltaPayload?, TResult>? responseAudioDelta = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.ResponseAudioDonePayload?, TResult>? responseAudioDone = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.ResponseFunctionCallArgumentsDeltaPayload?, TResult>? responseFunctionCallArgumentsDelta = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.ResponseFunctionCallArgumentsDonePayload?, TResult>? responseFunctionCallArgumentsDone = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RateLimitsUpdatedPayload?, TResult>? rateLimitsUpdated = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsError && error != null)
            {
                return error(Error!);
            }
            else if (IsSessionCreated && sessionCreated != null)
            {
                return sessionCreated(SessionCreated!);
            }
            else if (IsSessionUpdated && sessionUpdated != null)
            {
                return sessionUpdated(SessionUpdated!);
            }
            else if (IsConversationCreated && conversationCreated != null)
            {
                return conversationCreated(ConversationCreated!);
            }
            else if (IsConversationItemCreated && conversationItemCreated != null)
            {
                return conversationItemCreated(ConversationItemCreated!);
            }
            else if (IsConversationItemInputAudioTranscriptionCompleted && conversationItemInputAudioTranscriptionCompleted != null)
            {
                return conversationItemInputAudioTranscriptionCompleted(ConversationItemInputAudioTranscriptionCompleted!);
            }
            else if (IsConversationItemInputAudioTranscriptionFailed && conversationItemInputAudioTranscriptionFailed != null)
            {
                return conversationItemInputAudioTranscriptionFailed(ConversationItemInputAudioTranscriptionFailed!);
            }
            else if (IsConversationItemTruncated && conversationItemTruncated != null)
            {
                return conversationItemTruncated(ConversationItemTruncated!);
            }
            else if (IsConversationItemDeleted && conversationItemDeleted != null)
            {
                return conversationItemDeleted(ConversationItemDeleted!);
            }
            else if (IsInputAudioBufferCommitted && inputAudioBufferCommitted != null)
            {
                return inputAudioBufferCommitted(InputAudioBufferCommitted!);
            }
            else if (IsInputAudioBufferCleared && inputAudioBufferCleared != null)
            {
                return inputAudioBufferCleared(InputAudioBufferCleared!);
            }
            else if (IsInputAudioBufferSpeechStarted && inputAudioBufferSpeechStarted != null)
            {
                return inputAudioBufferSpeechStarted(InputAudioBufferSpeechStarted!);
            }
            else if (IsInputAudioBufferSpeechStopped && inputAudioBufferSpeechStopped != null)
            {
                return inputAudioBufferSpeechStopped(InputAudioBufferSpeechStopped!);
            }
            else if (IsResponseCreated && responseCreated != null)
            {
                return responseCreated(ResponseCreated!);
            }
            else if (IsResponseDone && responseDone != null)
            {
                return responseDone(ResponseDone!);
            }
            else if (IsResponseOutputItemAdded && responseOutputItemAdded != null)
            {
                return responseOutputItemAdded(ResponseOutputItemAdded!);
            }
            else if (IsResponseOutputItemDone && responseOutputItemDone != null)
            {
                return responseOutputItemDone(ResponseOutputItemDone!);
            }
            else if (IsResponseContentPartAdded && responseContentPartAdded != null)
            {
                return responseContentPartAdded(ResponseContentPartAdded!);
            }
            else if (IsResponseContentPartDone && responseContentPartDone != null)
            {
                return responseContentPartDone(ResponseContentPartDone!);
            }
            else if (IsResponseTextDelta && responseTextDelta != null)
            {
                return responseTextDelta(ResponseTextDelta!);
            }
            else if (IsResponseTextDone && responseTextDone != null)
            {
                return responseTextDone(ResponseTextDone!);
            }
            else if (IsResponseAudioTranscriptDelta && responseAudioTranscriptDelta != null)
            {
                return responseAudioTranscriptDelta(ResponseAudioTranscriptDelta!);
            }
            else if (IsResponseAudioTranscriptDone && responseAudioTranscriptDone != null)
            {
                return responseAudioTranscriptDone(ResponseAudioTranscriptDone!);
            }
            else if (IsResponseAudioDelta && responseAudioDelta != null)
            {
                return responseAudioDelta(ResponseAudioDelta!);
            }
            else if (IsResponseAudioDone && responseAudioDone != null)
            {
                return responseAudioDone(ResponseAudioDone!);
            }
            else if (IsResponseFunctionCallArgumentsDelta && responseFunctionCallArgumentsDelta != null)
            {
                return responseFunctionCallArgumentsDelta(ResponseFunctionCallArgumentsDelta!);
            }
            else if (IsResponseFunctionCallArgumentsDone && responseFunctionCallArgumentsDone != null)
            {
                return responseFunctionCallArgumentsDone(ResponseFunctionCallArgumentsDone!);
            }
            else if (IsRateLimitsUpdated && rateLimitsUpdated != null)
            {
                return rateLimitsUpdated(RateLimitsUpdated!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.Realtime.ErrorPayload?>? error = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.SessionCreatedPayload?>? sessionCreated = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.SessionUpdatedPayload?>? sessionUpdated = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.ConversationCreatedPayload?>? conversationCreated = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.ConversationItemCreatedPayload?>? conversationItemCreated = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionCompletedPayload?>? conversationItemInputAudioTranscriptionCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionFailedPayload?>? conversationItemInputAudioTranscriptionFailed = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.ConversationItemTruncatedPayload?>? conversationItemTruncated = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.ConversationItemDeletedPayload?>? conversationItemDeleted = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.InputAudioBufferCommittedPayload?>? inputAudioBufferCommitted = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.InputAudioBufferClearedPayload?>? inputAudioBufferCleared = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.InputAudioBufferSpeechStartedPayload?>? inputAudioBufferSpeechStarted = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.InputAudioBufferSpeechStoppedPayload?>? inputAudioBufferSpeechStopped = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.ResponseCreatedPayload?>? responseCreated = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.ResponseDonePayload?>? responseDone = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.ResponseOutputItemAddedPayload?>? responseOutputItemAdded = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.ResponseOutputItemDonePayload?>? responseOutputItemDone = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.ResponseContentPartAddedPayload?>? responseContentPartAdded = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.ResponseContentPartDonePayload?>? responseContentPartDone = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.ResponseTextDeltaPayload?>? responseTextDelta = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.ResponseTextDonePayload?>? responseTextDone = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.ResponseAudioTranscriptDeltaPayload?>? responseAudioTranscriptDelta = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.ResponseAudioTranscriptDonePayload?>? responseAudioTranscriptDone = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.ResponseAudioDeltaPayload?>? responseAudioDelta = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.ResponseAudioDonePayload?>? responseAudioDone = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.ResponseFunctionCallArgumentsDeltaPayload?>? responseFunctionCallArgumentsDelta = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.ResponseFunctionCallArgumentsDonePayload?>? responseFunctionCallArgumentsDone = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RateLimitsUpdatedPayload?>? rateLimitsUpdated = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsError)
            {
                error?.Invoke(Error!);
            }
            else if (IsSessionCreated)
            {
                sessionCreated?.Invoke(SessionCreated!);
            }
            else if (IsSessionUpdated)
            {
                sessionUpdated?.Invoke(SessionUpdated!);
            }
            else if (IsConversationCreated)
            {
                conversationCreated?.Invoke(ConversationCreated!);
            }
            else if (IsConversationItemCreated)
            {
                conversationItemCreated?.Invoke(ConversationItemCreated!);
            }
            else if (IsConversationItemInputAudioTranscriptionCompleted)
            {
                conversationItemInputAudioTranscriptionCompleted?.Invoke(ConversationItemInputAudioTranscriptionCompleted!);
            }
            else if (IsConversationItemInputAudioTranscriptionFailed)
            {
                conversationItemInputAudioTranscriptionFailed?.Invoke(ConversationItemInputAudioTranscriptionFailed!);
            }
            else if (IsConversationItemTruncated)
            {
                conversationItemTruncated?.Invoke(ConversationItemTruncated!);
            }
            else if (IsConversationItemDeleted)
            {
                conversationItemDeleted?.Invoke(ConversationItemDeleted!);
            }
            else if (IsInputAudioBufferCommitted)
            {
                inputAudioBufferCommitted?.Invoke(InputAudioBufferCommitted!);
            }
            else if (IsInputAudioBufferCleared)
            {
                inputAudioBufferCleared?.Invoke(InputAudioBufferCleared!);
            }
            else if (IsInputAudioBufferSpeechStarted)
            {
                inputAudioBufferSpeechStarted?.Invoke(InputAudioBufferSpeechStarted!);
            }
            else if (IsInputAudioBufferSpeechStopped)
            {
                inputAudioBufferSpeechStopped?.Invoke(InputAudioBufferSpeechStopped!);
            }
            else if (IsResponseCreated)
            {
                responseCreated?.Invoke(ResponseCreated!);
            }
            else if (IsResponseDone)
            {
                responseDone?.Invoke(ResponseDone!);
            }
            else if (IsResponseOutputItemAdded)
            {
                responseOutputItemAdded?.Invoke(ResponseOutputItemAdded!);
            }
            else if (IsResponseOutputItemDone)
            {
                responseOutputItemDone?.Invoke(ResponseOutputItemDone!);
            }
            else if (IsResponseContentPartAdded)
            {
                responseContentPartAdded?.Invoke(ResponseContentPartAdded!);
            }
            else if (IsResponseContentPartDone)
            {
                responseContentPartDone?.Invoke(ResponseContentPartDone!);
            }
            else if (IsResponseTextDelta)
            {
                responseTextDelta?.Invoke(ResponseTextDelta!);
            }
            else if (IsResponseTextDone)
            {
                responseTextDone?.Invoke(ResponseTextDone!);
            }
            else if (IsResponseAudioTranscriptDelta)
            {
                responseAudioTranscriptDelta?.Invoke(ResponseAudioTranscriptDelta!);
            }
            else if (IsResponseAudioTranscriptDone)
            {
                responseAudioTranscriptDone?.Invoke(ResponseAudioTranscriptDone!);
            }
            else if (IsResponseAudioDelta)
            {
                responseAudioDelta?.Invoke(ResponseAudioDelta!);
            }
            else if (IsResponseAudioDone)
            {
                responseAudioDone?.Invoke(ResponseAudioDone!);
            }
            else if (IsResponseFunctionCallArgumentsDelta)
            {
                responseFunctionCallArgumentsDelta?.Invoke(ResponseFunctionCallArgumentsDelta!);
            }
            else if (IsResponseFunctionCallArgumentsDone)
            {
                responseFunctionCallArgumentsDone?.Invoke(ResponseFunctionCallArgumentsDone!);
            }
            else if (IsRateLimitsUpdated)
            {
                rateLimitsUpdated?.Invoke(RateLimitsUpdated!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Error,
                typeof(global::tryAGI.OpenAI.Realtime.ErrorPayload),
                SessionCreated,
                typeof(global::tryAGI.OpenAI.Realtime.SessionCreatedPayload),
                SessionUpdated,
                typeof(global::tryAGI.OpenAI.Realtime.SessionUpdatedPayload),
                ConversationCreated,
                typeof(global::tryAGI.OpenAI.Realtime.ConversationCreatedPayload),
                ConversationItemCreated,
                typeof(global::tryAGI.OpenAI.Realtime.ConversationItemCreatedPayload),
                ConversationItemInputAudioTranscriptionCompleted,
                typeof(global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionCompletedPayload),
                ConversationItemInputAudioTranscriptionFailed,
                typeof(global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionFailedPayload),
                ConversationItemTruncated,
                typeof(global::tryAGI.OpenAI.Realtime.ConversationItemTruncatedPayload),
                ConversationItemDeleted,
                typeof(global::tryAGI.OpenAI.Realtime.ConversationItemDeletedPayload),
                InputAudioBufferCommitted,
                typeof(global::tryAGI.OpenAI.Realtime.InputAudioBufferCommittedPayload),
                InputAudioBufferCleared,
                typeof(global::tryAGI.OpenAI.Realtime.InputAudioBufferClearedPayload),
                InputAudioBufferSpeechStarted,
                typeof(global::tryAGI.OpenAI.Realtime.InputAudioBufferSpeechStartedPayload),
                InputAudioBufferSpeechStopped,
                typeof(global::tryAGI.OpenAI.Realtime.InputAudioBufferSpeechStoppedPayload),
                ResponseCreated,
                typeof(global::tryAGI.OpenAI.Realtime.ResponseCreatedPayload),
                ResponseDone,
                typeof(global::tryAGI.OpenAI.Realtime.ResponseDonePayload),
                ResponseOutputItemAdded,
                typeof(global::tryAGI.OpenAI.Realtime.ResponseOutputItemAddedPayload),
                ResponseOutputItemDone,
                typeof(global::tryAGI.OpenAI.Realtime.ResponseOutputItemDonePayload),
                ResponseContentPartAdded,
                typeof(global::tryAGI.OpenAI.Realtime.ResponseContentPartAddedPayload),
                ResponseContentPartDone,
                typeof(global::tryAGI.OpenAI.Realtime.ResponseContentPartDonePayload),
                ResponseTextDelta,
                typeof(global::tryAGI.OpenAI.Realtime.ResponseTextDeltaPayload),
                ResponseTextDone,
                typeof(global::tryAGI.OpenAI.Realtime.ResponseTextDonePayload),
                ResponseAudioTranscriptDelta,
                typeof(global::tryAGI.OpenAI.Realtime.ResponseAudioTranscriptDeltaPayload),
                ResponseAudioTranscriptDone,
                typeof(global::tryAGI.OpenAI.Realtime.ResponseAudioTranscriptDonePayload),
                ResponseAudioDelta,
                typeof(global::tryAGI.OpenAI.Realtime.ResponseAudioDeltaPayload),
                ResponseAudioDone,
                typeof(global::tryAGI.OpenAI.Realtime.ResponseAudioDonePayload),
                ResponseFunctionCallArgumentsDelta,
                typeof(global::tryAGI.OpenAI.Realtime.ResponseFunctionCallArgumentsDeltaPayload),
                ResponseFunctionCallArgumentsDone,
                typeof(global::tryAGI.OpenAI.Realtime.ResponseFunctionCallArgumentsDonePayload),
                RateLimitsUpdated,
                typeof(global::tryAGI.OpenAI.Realtime.RateLimitsUpdatedPayload),
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
        public bool Equals(ServerEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.ErrorPayload?>.Default.Equals(Error, other.Error) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.SessionCreatedPayload?>.Default.Equals(SessionCreated, other.SessionCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.SessionUpdatedPayload?>.Default.Equals(SessionUpdated, other.SessionUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.ConversationCreatedPayload?>.Default.Equals(ConversationCreated, other.ConversationCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.ConversationItemCreatedPayload?>.Default.Equals(ConversationItemCreated, other.ConversationItemCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionCompletedPayload?>.Default.Equals(ConversationItemInputAudioTranscriptionCompleted, other.ConversationItemInputAudioTranscriptionCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionFailedPayload?>.Default.Equals(ConversationItemInputAudioTranscriptionFailed, other.ConversationItemInputAudioTranscriptionFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.ConversationItemTruncatedPayload?>.Default.Equals(ConversationItemTruncated, other.ConversationItemTruncated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.ConversationItemDeletedPayload?>.Default.Equals(ConversationItemDeleted, other.ConversationItemDeleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.InputAudioBufferCommittedPayload?>.Default.Equals(InputAudioBufferCommitted, other.InputAudioBufferCommitted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.InputAudioBufferClearedPayload?>.Default.Equals(InputAudioBufferCleared, other.InputAudioBufferCleared) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.InputAudioBufferSpeechStartedPayload?>.Default.Equals(InputAudioBufferSpeechStarted, other.InputAudioBufferSpeechStarted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.InputAudioBufferSpeechStoppedPayload?>.Default.Equals(InputAudioBufferSpeechStopped, other.InputAudioBufferSpeechStopped) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.ResponseCreatedPayload?>.Default.Equals(ResponseCreated, other.ResponseCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.ResponseDonePayload?>.Default.Equals(ResponseDone, other.ResponseDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.ResponseOutputItemAddedPayload?>.Default.Equals(ResponseOutputItemAdded, other.ResponseOutputItemAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.ResponseOutputItemDonePayload?>.Default.Equals(ResponseOutputItemDone, other.ResponseOutputItemDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.ResponseContentPartAddedPayload?>.Default.Equals(ResponseContentPartAdded, other.ResponseContentPartAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.ResponseContentPartDonePayload?>.Default.Equals(ResponseContentPartDone, other.ResponseContentPartDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.ResponseTextDeltaPayload?>.Default.Equals(ResponseTextDelta, other.ResponseTextDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.ResponseTextDonePayload?>.Default.Equals(ResponseTextDone, other.ResponseTextDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.ResponseAudioTranscriptDeltaPayload?>.Default.Equals(ResponseAudioTranscriptDelta, other.ResponseAudioTranscriptDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.ResponseAudioTranscriptDonePayload?>.Default.Equals(ResponseAudioTranscriptDone, other.ResponseAudioTranscriptDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.ResponseAudioDeltaPayload?>.Default.Equals(ResponseAudioDelta, other.ResponseAudioDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.ResponseAudioDonePayload?>.Default.Equals(ResponseAudioDone, other.ResponseAudioDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.ResponseFunctionCallArgumentsDeltaPayload?>.Default.Equals(ResponseFunctionCallArgumentsDelta, other.ResponseFunctionCallArgumentsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.ResponseFunctionCallArgumentsDonePayload?>.Default.Equals(ResponseFunctionCallArgumentsDone, other.ResponseFunctionCallArgumentsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RateLimitsUpdatedPayload?>.Default.Equals(RateLimitsUpdated, other.RateLimitsUpdated) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ServerEvent obj1, ServerEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ServerEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ServerEvent obj1, ServerEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ServerEvent o && Equals(o);
        }
    }
}
