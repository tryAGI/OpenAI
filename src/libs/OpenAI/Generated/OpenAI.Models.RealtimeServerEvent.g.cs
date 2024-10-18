using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RealtimeServerEvent : global::System.IEquatable<RealtimeServerEvent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::OpenAI.RealtimeServerEventDiscriminatorType? Type { get; }

        /// <summary>
        /// Returned when an error occurs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RealtimeError? Error { get; init; }
#else
        public global::OpenAI.RealtimeError? Error { get; }
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
        public static implicit operator RealtimeServerEvent(global::OpenAI.RealtimeError value) => new RealtimeServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RealtimeError?(RealtimeServerEvent @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::OpenAI.RealtimeError? value)
        {
            Error = value;
        }

        /// <summary>
        /// Returned when a session is created. Emitted automatically when a new connection is established.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RealtimeSessionCreated? SessionCreated { get; init; }
#else
        public global::OpenAI.RealtimeSessionCreated? SessionCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionCreated))]
#endif
        public bool IsSessionCreated => SessionCreated != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::OpenAI.RealtimeSessionCreated value) => new RealtimeServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RealtimeSessionCreated?(RealtimeServerEvent @this) => @this.SessionCreated;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::OpenAI.RealtimeSessionCreated? value)
        {
            SessionCreated = value;
        }

        /// <summary>
        /// Returned when a session is updated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RealtimeSessionUpdated? SessionUpdated { get; init; }
#else
        public global::OpenAI.RealtimeSessionUpdated? SessionUpdated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionUpdated))]
#endif
        public bool IsSessionUpdated => SessionUpdated != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::OpenAI.RealtimeSessionUpdated value) => new RealtimeServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RealtimeSessionUpdated?(RealtimeServerEvent @this) => @this.SessionUpdated;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::OpenAI.RealtimeSessionUpdated? value)
        {
            SessionUpdated = value;
        }

        /// <summary>
        /// Returned when a conversation is created. Emitted right after session creation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RealtimeConversationCreated? ConversationCreated { get; init; }
#else
        public global::OpenAI.RealtimeConversationCreated? ConversationCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationCreated))]
#endif
        public bool IsConversationCreated => ConversationCreated != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::OpenAI.RealtimeConversationCreated value) => new RealtimeServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RealtimeConversationCreated?(RealtimeServerEvent @this) => @this.ConversationCreated;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::OpenAI.RealtimeConversationCreated? value)
        {
            ConversationCreated = value;
        }

        /// <summary>
        /// Returned when a conversation item is created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RealtimeConversationItemCreated? ConversationItemCreated { get; init; }
#else
        public global::OpenAI.RealtimeConversationItemCreated? ConversationItemCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemCreated))]
#endif
        public bool IsConversationItemCreated => ConversationItemCreated != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::OpenAI.RealtimeConversationItemCreated value) => new RealtimeServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RealtimeConversationItemCreated?(RealtimeServerEvent @this) => @this.ConversationItemCreated;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::OpenAI.RealtimeConversationItemCreated? value)
        {
            ConversationItemCreated = value;
        }

        /// <summary>
        /// Returned when input audio transcription is enabled and a transcription succeeds.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RealtimeConversationItemInputAudioTranscriptionCompleted? ConversationItemInputAudioTranscriptionCompleted { get; init; }
#else
        public global::OpenAI.RealtimeConversationItemInputAudioTranscriptionCompleted? ConversationItemInputAudioTranscriptionCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemInputAudioTranscriptionCompleted))]
#endif
        public bool IsConversationItemInputAudioTranscriptionCompleted => ConversationItemInputAudioTranscriptionCompleted != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::OpenAI.RealtimeConversationItemInputAudioTranscriptionCompleted value) => new RealtimeServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RealtimeConversationItemInputAudioTranscriptionCompleted?(RealtimeServerEvent @this) => @this.ConversationItemInputAudioTranscriptionCompleted;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::OpenAI.RealtimeConversationItemInputAudioTranscriptionCompleted? value)
        {
            ConversationItemInputAudioTranscriptionCompleted = value;
        }

        /// <summary>
        /// Returned when input audio transcription is configured, and a transcription request for a user message failed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RealtimeConversationItemInputAudioTranscriptionFailed? ConversationItemInputAudioTranscriptionFailed { get; init; }
#else
        public global::OpenAI.RealtimeConversationItemInputAudioTranscriptionFailed? ConversationItemInputAudioTranscriptionFailed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemInputAudioTranscriptionFailed))]
#endif
        public bool IsConversationItemInputAudioTranscriptionFailed => ConversationItemInputAudioTranscriptionFailed != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::OpenAI.RealtimeConversationItemInputAudioTranscriptionFailed value) => new RealtimeServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RealtimeConversationItemInputAudioTranscriptionFailed?(RealtimeServerEvent @this) => @this.ConversationItemInputAudioTranscriptionFailed;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::OpenAI.RealtimeConversationItemInputAudioTranscriptionFailed? value)
        {
            ConversationItemInputAudioTranscriptionFailed = value;
        }

        /// <summary>
        /// Returned when an earlier assistant audio message item is truncated by the client.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RealtimeConversationItemTruncated? ConversationItemTruncated { get; init; }
#else
        public global::OpenAI.RealtimeConversationItemTruncated? ConversationItemTruncated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemTruncated))]
#endif
        public bool IsConversationItemTruncated => ConversationItemTruncated != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::OpenAI.RealtimeConversationItemTruncated value) => new RealtimeServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RealtimeConversationItemTruncated?(RealtimeServerEvent @this) => @this.ConversationItemTruncated;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::OpenAI.RealtimeConversationItemTruncated? value)
        {
            ConversationItemTruncated = value;
        }

        /// <summary>
        /// Returned when an item in the conversation is deleted.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RealtimeConversationItemDeleted? ConversationItemDeleted { get; init; }
#else
        public global::OpenAI.RealtimeConversationItemDeleted? ConversationItemDeleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemDeleted))]
#endif
        public bool IsConversationItemDeleted => ConversationItemDeleted != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::OpenAI.RealtimeConversationItemDeleted value) => new RealtimeServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RealtimeConversationItemDeleted?(RealtimeServerEvent @this) => @this.ConversationItemDeleted;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::OpenAI.RealtimeConversationItemDeleted? value)
        {
            ConversationItemDeleted = value;
        }

        /// <summary>
        /// Returned when an input audio buffer is committed, either by the client or automatically in server VAD mode.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RealtimeInputAudioBufferCommitted? InputAudioBufferCommitted { get; init; }
#else
        public global::OpenAI.RealtimeInputAudioBufferCommitted? InputAudioBufferCommitted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudioBufferCommitted))]
#endif
        public bool IsInputAudioBufferCommitted => InputAudioBufferCommitted != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::OpenAI.RealtimeInputAudioBufferCommitted value) => new RealtimeServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RealtimeInputAudioBufferCommitted?(RealtimeServerEvent @this) => @this.InputAudioBufferCommitted;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::OpenAI.RealtimeInputAudioBufferCommitted? value)
        {
            InputAudioBufferCommitted = value;
        }

        /// <summary>
        /// Returned when the input audio buffer is cleared by the client.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RealtimeInputAudioBufferCleared? InputAudioBufferCleared { get; init; }
#else
        public global::OpenAI.RealtimeInputAudioBufferCleared? InputAudioBufferCleared { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudioBufferCleared))]
#endif
        public bool IsInputAudioBufferCleared => InputAudioBufferCleared != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::OpenAI.RealtimeInputAudioBufferCleared value) => new RealtimeServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RealtimeInputAudioBufferCleared?(RealtimeServerEvent @this) => @this.InputAudioBufferCleared;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::OpenAI.RealtimeInputAudioBufferCleared? value)
        {
            InputAudioBufferCleared = value;
        }

        /// <summary>
        /// Returned in server turn detection mode when speech is detected.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RealtimeInputAudioBufferSpeechStarted? InputAudioBufferSpeechStarted { get; init; }
#else
        public global::OpenAI.RealtimeInputAudioBufferSpeechStarted? InputAudioBufferSpeechStarted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudioBufferSpeechStarted))]
#endif
        public bool IsInputAudioBufferSpeechStarted => InputAudioBufferSpeechStarted != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::OpenAI.RealtimeInputAudioBufferSpeechStarted value) => new RealtimeServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RealtimeInputAudioBufferSpeechStarted?(RealtimeServerEvent @this) => @this.InputAudioBufferSpeechStarted;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::OpenAI.RealtimeInputAudioBufferSpeechStarted? value)
        {
            InputAudioBufferSpeechStarted = value;
        }

        /// <summary>
        /// Returned in server turn detection mode when speech stops.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RealtimeInputAudioBufferSpeechStopped? InputAudioBufferSpeechStopped { get; init; }
#else
        public global::OpenAI.RealtimeInputAudioBufferSpeechStopped? InputAudioBufferSpeechStopped { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudioBufferSpeechStopped))]
#endif
        public bool IsInputAudioBufferSpeechStopped => InputAudioBufferSpeechStopped != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::OpenAI.RealtimeInputAudioBufferSpeechStopped value) => new RealtimeServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RealtimeInputAudioBufferSpeechStopped?(RealtimeServerEvent @this) => @this.InputAudioBufferSpeechStopped;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::OpenAI.RealtimeInputAudioBufferSpeechStopped? value)
        {
            InputAudioBufferSpeechStopped = value;
        }

        /// <summary>
        /// Returned when a new Response is created. The first event of response creation, where the response is in an initial state of "in_progress".
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RealtimeResponseCreated? ResponseCreated { get; init; }
#else
        public global::OpenAI.RealtimeResponseCreated? ResponseCreated { get; }
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
        public static implicit operator RealtimeServerEvent(global::OpenAI.RealtimeResponseCreated value) => new RealtimeServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RealtimeResponseCreated?(RealtimeServerEvent @this) => @this.ResponseCreated;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::OpenAI.RealtimeResponseCreated? value)
        {
            ResponseCreated = value;
        }

        /// <summary>
        /// Returned when a Response is done streaming. Always emitted, no matter the final state.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RealtimeResponseDone? ResponseDone { get; init; }
#else
        public global::OpenAI.RealtimeResponseDone? ResponseDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseDone))]
#endif
        public bool IsResponseDone => ResponseDone != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::OpenAI.RealtimeResponseDone value) => new RealtimeServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RealtimeResponseDone?(RealtimeServerEvent @this) => @this.ResponseDone;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::OpenAI.RealtimeResponseDone? value)
        {
            ResponseDone = value;
        }

        /// <summary>
        /// Returned when a new Item is created during response generation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RealtimeResponseOutputItemAdded? ResponseOutputItemAdded { get; init; }
#else
        public global::OpenAI.RealtimeResponseOutputItemAdded? ResponseOutputItemAdded { get; }
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
        public static implicit operator RealtimeServerEvent(global::OpenAI.RealtimeResponseOutputItemAdded value) => new RealtimeServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RealtimeResponseOutputItemAdded?(RealtimeServerEvent @this) => @this.ResponseOutputItemAdded;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::OpenAI.RealtimeResponseOutputItemAdded? value)
        {
            ResponseOutputItemAdded = value;
        }

        /// <summary>
        /// Returned when an Item is done streaming. Also emitted when a Response is interrupted, incomplete, or cancelled.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RealtimeResponseOutputItemDone? ResponseOutputItemDone { get; init; }
#else
        public global::OpenAI.RealtimeResponseOutputItemDone? ResponseOutputItemDone { get; }
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
        public static implicit operator RealtimeServerEvent(global::OpenAI.RealtimeResponseOutputItemDone value) => new RealtimeServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RealtimeResponseOutputItemDone?(RealtimeServerEvent @this) => @this.ResponseOutputItemDone;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::OpenAI.RealtimeResponseOutputItemDone? value)
        {
            ResponseOutputItemDone = value;
        }

        /// <summary>
        /// Returned when a new content part is added to an assistant message item during response generation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RealtimeResponseContentPartAdded? ResponseContentPartAdded { get; init; }
#else
        public global::OpenAI.RealtimeResponseContentPartAdded? ResponseContentPartAdded { get; }
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
        public static implicit operator RealtimeServerEvent(global::OpenAI.RealtimeResponseContentPartAdded value) => new RealtimeServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RealtimeResponseContentPartAdded?(RealtimeServerEvent @this) => @this.ResponseContentPartAdded;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::OpenAI.RealtimeResponseContentPartAdded? value)
        {
            ResponseContentPartAdded = value;
        }

        /// <summary>
        /// Returned when a content part is done streaming in an assistant message item. Also emitted when a Response is interrupted, incomplete, or cancelled.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RealtimeResponseContentPartDone? ResponseContentPartDone { get; init; }
#else
        public global::OpenAI.RealtimeResponseContentPartDone? ResponseContentPartDone { get; }
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
        public static implicit operator RealtimeServerEvent(global::OpenAI.RealtimeResponseContentPartDone value) => new RealtimeServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RealtimeResponseContentPartDone?(RealtimeServerEvent @this) => @this.ResponseContentPartDone;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::OpenAI.RealtimeResponseContentPartDone? value)
        {
            ResponseContentPartDone = value;
        }

        /// <summary>
        /// Returned when the text value of a "text" content part is updated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RealtimeResponseTextDelta? ResponseTextDelta { get; init; }
#else
        public global::OpenAI.RealtimeResponseTextDelta? ResponseTextDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseTextDelta))]
#endif
        public bool IsResponseTextDelta => ResponseTextDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::OpenAI.RealtimeResponseTextDelta value) => new RealtimeServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RealtimeResponseTextDelta?(RealtimeServerEvent @this) => @this.ResponseTextDelta;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::OpenAI.RealtimeResponseTextDelta? value)
        {
            ResponseTextDelta = value;
        }

        /// <summary>
        /// Returned when the text value of a "text" content part is done streaming. Also emitted when a Response is interrupted, incomplete, or cancelled.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RealtimeResponseTextDone? ResponseTextDone { get; init; }
#else
        public global::OpenAI.RealtimeResponseTextDone? ResponseTextDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseTextDone))]
#endif
        public bool IsResponseTextDone => ResponseTextDone != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::OpenAI.RealtimeResponseTextDone value) => new RealtimeServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RealtimeResponseTextDone?(RealtimeServerEvent @this) => @this.ResponseTextDone;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::OpenAI.RealtimeResponseTextDone? value)
        {
            ResponseTextDone = value;
        }

        /// <summary>
        /// Returned when the model-generated transcription of audio output is updated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RealtimeResponseAudioTranscriptDelta? ResponseAudioTranscriptDelta { get; init; }
#else
        public global::OpenAI.RealtimeResponseAudioTranscriptDelta? ResponseAudioTranscriptDelta { get; }
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
        public static implicit operator RealtimeServerEvent(global::OpenAI.RealtimeResponseAudioTranscriptDelta value) => new RealtimeServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RealtimeResponseAudioTranscriptDelta?(RealtimeServerEvent @this) => @this.ResponseAudioTranscriptDelta;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::OpenAI.RealtimeResponseAudioTranscriptDelta? value)
        {
            ResponseAudioTranscriptDelta = value;
        }

        /// <summary>
        /// Returned when the model-generated transcription of audio output is done streaming. Also emitted when a Response is interrupted, incomplete, or cancelled.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RealtimeResponseAudioTranscriptDone? ResponseAudioTranscriptDone { get; init; }
#else
        public global::OpenAI.RealtimeResponseAudioTranscriptDone? ResponseAudioTranscriptDone { get; }
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
        public static implicit operator RealtimeServerEvent(global::OpenAI.RealtimeResponseAudioTranscriptDone value) => new RealtimeServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RealtimeResponseAudioTranscriptDone?(RealtimeServerEvent @this) => @this.ResponseAudioTranscriptDone;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::OpenAI.RealtimeResponseAudioTranscriptDone? value)
        {
            ResponseAudioTranscriptDone = value;
        }

        /// <summary>
        /// Returned when the model-generated audio is updated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RealtimeResponseAudioDelta? ResponseAudioDelta { get; init; }
#else
        public global::OpenAI.RealtimeResponseAudioDelta? ResponseAudioDelta { get; }
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
        public static implicit operator RealtimeServerEvent(global::OpenAI.RealtimeResponseAudioDelta value) => new RealtimeServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RealtimeResponseAudioDelta?(RealtimeServerEvent @this) => @this.ResponseAudioDelta;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::OpenAI.RealtimeResponseAudioDelta? value)
        {
            ResponseAudioDelta = value;
        }

        /// <summary>
        /// Returned when the model-generated audio is done. Also emitted when a Response is interrupted, incomplete, or cancelled.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RealtimeResponseAudioDone? ResponseAudioDone { get; init; }
#else
        public global::OpenAI.RealtimeResponseAudioDone? ResponseAudioDone { get; }
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
        public static implicit operator RealtimeServerEvent(global::OpenAI.RealtimeResponseAudioDone value) => new RealtimeServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RealtimeResponseAudioDone?(RealtimeServerEvent @this) => @this.ResponseAudioDone;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::OpenAI.RealtimeResponseAudioDone? value)
        {
            ResponseAudioDone = value;
        }

        /// <summary>
        /// Returned when the model-generated function call arguments are updated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RealtimeResponseFunctionCallArgumentsDelta? ResponseFunctionCallArgumentsDelta { get; init; }
#else
        public global::OpenAI.RealtimeResponseFunctionCallArgumentsDelta? ResponseFunctionCallArgumentsDelta { get; }
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
        public static implicit operator RealtimeServerEvent(global::OpenAI.RealtimeResponseFunctionCallArgumentsDelta value) => new RealtimeServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RealtimeResponseFunctionCallArgumentsDelta?(RealtimeServerEvent @this) => @this.ResponseFunctionCallArgumentsDelta;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::OpenAI.RealtimeResponseFunctionCallArgumentsDelta? value)
        {
            ResponseFunctionCallArgumentsDelta = value;
        }

        /// <summary>
        /// Returned when the model-generated function call arguments are done streaming. Also emitted when a Response is interrupted, incomplete, or cancelled.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RealtimeResponseFunctionCallArgumentsDone? ResponseFunctionCallArgumentsDone { get; init; }
#else
        public global::OpenAI.RealtimeResponseFunctionCallArgumentsDone? ResponseFunctionCallArgumentsDone { get; }
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
        public static implicit operator RealtimeServerEvent(global::OpenAI.RealtimeResponseFunctionCallArgumentsDone value) => new RealtimeServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RealtimeResponseFunctionCallArgumentsDone?(RealtimeServerEvent @this) => @this.ResponseFunctionCallArgumentsDone;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::OpenAI.RealtimeResponseFunctionCallArgumentsDone? value)
        {
            ResponseFunctionCallArgumentsDone = value;
        }

        /// <summary>
        /// Emitted after every "response.done" event to indicate the updated rate limits.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RealtimeRateLimitsUpdated? RateLimitsUpdated { get; init; }
#else
        public global::OpenAI.RealtimeRateLimitsUpdated? RateLimitsUpdated { get; }
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
        public static implicit operator RealtimeServerEvent(global::OpenAI.RealtimeRateLimitsUpdated value) => new RealtimeServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RealtimeRateLimitsUpdated?(RealtimeServerEvent @this) => @this.RateLimitsUpdated;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::OpenAI.RealtimeRateLimitsUpdated? value)
        {
            RateLimitsUpdated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(
            global::OpenAI.RealtimeServerEventDiscriminatorType? type,
            global::OpenAI.RealtimeError? error,
            global::OpenAI.RealtimeSessionCreated? sessionCreated,
            global::OpenAI.RealtimeSessionUpdated? sessionUpdated,
            global::OpenAI.RealtimeConversationCreated? conversationCreated,
            global::OpenAI.RealtimeConversationItemCreated? conversationItemCreated,
            global::OpenAI.RealtimeConversationItemInputAudioTranscriptionCompleted? conversationItemInputAudioTranscriptionCompleted,
            global::OpenAI.RealtimeConversationItemInputAudioTranscriptionFailed? conversationItemInputAudioTranscriptionFailed,
            global::OpenAI.RealtimeConversationItemTruncated? conversationItemTruncated,
            global::OpenAI.RealtimeConversationItemDeleted? conversationItemDeleted,
            global::OpenAI.RealtimeInputAudioBufferCommitted? inputAudioBufferCommitted,
            global::OpenAI.RealtimeInputAudioBufferCleared? inputAudioBufferCleared,
            global::OpenAI.RealtimeInputAudioBufferSpeechStarted? inputAudioBufferSpeechStarted,
            global::OpenAI.RealtimeInputAudioBufferSpeechStopped? inputAudioBufferSpeechStopped,
            global::OpenAI.RealtimeResponseCreated? responseCreated,
            global::OpenAI.RealtimeResponseDone? responseDone,
            global::OpenAI.RealtimeResponseOutputItemAdded? responseOutputItemAdded,
            global::OpenAI.RealtimeResponseOutputItemDone? responseOutputItemDone,
            global::OpenAI.RealtimeResponseContentPartAdded? responseContentPartAdded,
            global::OpenAI.RealtimeResponseContentPartDone? responseContentPartDone,
            global::OpenAI.RealtimeResponseTextDelta? responseTextDelta,
            global::OpenAI.RealtimeResponseTextDone? responseTextDone,
            global::OpenAI.RealtimeResponseAudioTranscriptDelta? responseAudioTranscriptDelta,
            global::OpenAI.RealtimeResponseAudioTranscriptDone? responseAudioTranscriptDone,
            global::OpenAI.RealtimeResponseAudioDelta? responseAudioDelta,
            global::OpenAI.RealtimeResponseAudioDone? responseAudioDone,
            global::OpenAI.RealtimeResponseFunctionCallArgumentsDelta? responseFunctionCallArgumentsDelta,
            global::OpenAI.RealtimeResponseFunctionCallArgumentsDone? responseFunctionCallArgumentsDone,
            global::OpenAI.RealtimeRateLimitsUpdated? rateLimitsUpdated
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
        public bool Validate()
        {
            return IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && IsResponseFunctionCallArgumentsDone && !IsRateLimitsUpdated || !IsError && !IsSessionCreated && !IsSessionUpdated && !IsConversationCreated && !IsConversationItemCreated && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemTruncated && !IsConversationItemDeleted && !IsInputAudioBufferCommitted && !IsInputAudioBufferCleared && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsResponseCreated && !IsResponseDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseTextDelta && !IsResponseTextDone && !IsResponseAudioTranscriptDelta && !IsResponseAudioTranscriptDone && !IsResponseAudioDelta && !IsResponseAudioDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && IsRateLimitsUpdated;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenAI.RealtimeError?, TResult>? error = null,
            global::System.Func<global::OpenAI.RealtimeSessionCreated?, TResult>? sessionCreated = null,
            global::System.Func<global::OpenAI.RealtimeSessionUpdated?, TResult>? sessionUpdated = null,
            global::System.Func<global::OpenAI.RealtimeConversationCreated?, TResult>? conversationCreated = null,
            global::System.Func<global::OpenAI.RealtimeConversationItemCreated?, TResult>? conversationItemCreated = null,
            global::System.Func<global::OpenAI.RealtimeConversationItemInputAudioTranscriptionCompleted?, TResult>? conversationItemInputAudioTranscriptionCompleted = null,
            global::System.Func<global::OpenAI.RealtimeConversationItemInputAudioTranscriptionFailed?, TResult>? conversationItemInputAudioTranscriptionFailed = null,
            global::System.Func<global::OpenAI.RealtimeConversationItemTruncated?, TResult>? conversationItemTruncated = null,
            global::System.Func<global::OpenAI.RealtimeConversationItemDeleted?, TResult>? conversationItemDeleted = null,
            global::System.Func<global::OpenAI.RealtimeInputAudioBufferCommitted?, TResult>? inputAudioBufferCommitted = null,
            global::System.Func<global::OpenAI.RealtimeInputAudioBufferCleared?, TResult>? inputAudioBufferCleared = null,
            global::System.Func<global::OpenAI.RealtimeInputAudioBufferSpeechStarted?, TResult>? inputAudioBufferSpeechStarted = null,
            global::System.Func<global::OpenAI.RealtimeInputAudioBufferSpeechStopped?, TResult>? inputAudioBufferSpeechStopped = null,
            global::System.Func<global::OpenAI.RealtimeResponseCreated?, TResult>? responseCreated = null,
            global::System.Func<global::OpenAI.RealtimeResponseDone?, TResult>? responseDone = null,
            global::System.Func<global::OpenAI.RealtimeResponseOutputItemAdded?, TResult>? responseOutputItemAdded = null,
            global::System.Func<global::OpenAI.RealtimeResponseOutputItemDone?, TResult>? responseOutputItemDone = null,
            global::System.Func<global::OpenAI.RealtimeResponseContentPartAdded?, TResult>? responseContentPartAdded = null,
            global::System.Func<global::OpenAI.RealtimeResponseContentPartDone?, TResult>? responseContentPartDone = null,
            global::System.Func<global::OpenAI.RealtimeResponseTextDelta?, TResult>? responseTextDelta = null,
            global::System.Func<global::OpenAI.RealtimeResponseTextDone?, TResult>? responseTextDone = null,
            global::System.Func<global::OpenAI.RealtimeResponseAudioTranscriptDelta?, TResult>? responseAudioTranscriptDelta = null,
            global::System.Func<global::OpenAI.RealtimeResponseAudioTranscriptDone?, TResult>? responseAudioTranscriptDone = null,
            global::System.Func<global::OpenAI.RealtimeResponseAudioDelta?, TResult>? responseAudioDelta = null,
            global::System.Func<global::OpenAI.RealtimeResponseAudioDone?, TResult>? responseAudioDone = null,
            global::System.Func<global::OpenAI.RealtimeResponseFunctionCallArgumentsDelta?, TResult>? responseFunctionCallArgumentsDelta = null,
            global::System.Func<global::OpenAI.RealtimeResponseFunctionCallArgumentsDone?, TResult>? responseFunctionCallArgumentsDone = null,
            global::System.Func<global::OpenAI.RealtimeRateLimitsUpdated?, TResult>? rateLimitsUpdated = null,
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
            global::System.Action<global::OpenAI.RealtimeError?>? error = null,
            global::System.Action<global::OpenAI.RealtimeSessionCreated?>? sessionCreated = null,
            global::System.Action<global::OpenAI.RealtimeSessionUpdated?>? sessionUpdated = null,
            global::System.Action<global::OpenAI.RealtimeConversationCreated?>? conversationCreated = null,
            global::System.Action<global::OpenAI.RealtimeConversationItemCreated?>? conversationItemCreated = null,
            global::System.Action<global::OpenAI.RealtimeConversationItemInputAudioTranscriptionCompleted?>? conversationItemInputAudioTranscriptionCompleted = null,
            global::System.Action<global::OpenAI.RealtimeConversationItemInputAudioTranscriptionFailed?>? conversationItemInputAudioTranscriptionFailed = null,
            global::System.Action<global::OpenAI.RealtimeConversationItemTruncated?>? conversationItemTruncated = null,
            global::System.Action<global::OpenAI.RealtimeConversationItemDeleted?>? conversationItemDeleted = null,
            global::System.Action<global::OpenAI.RealtimeInputAudioBufferCommitted?>? inputAudioBufferCommitted = null,
            global::System.Action<global::OpenAI.RealtimeInputAudioBufferCleared?>? inputAudioBufferCleared = null,
            global::System.Action<global::OpenAI.RealtimeInputAudioBufferSpeechStarted?>? inputAudioBufferSpeechStarted = null,
            global::System.Action<global::OpenAI.RealtimeInputAudioBufferSpeechStopped?>? inputAudioBufferSpeechStopped = null,
            global::System.Action<global::OpenAI.RealtimeResponseCreated?>? responseCreated = null,
            global::System.Action<global::OpenAI.RealtimeResponseDone?>? responseDone = null,
            global::System.Action<global::OpenAI.RealtimeResponseOutputItemAdded?>? responseOutputItemAdded = null,
            global::System.Action<global::OpenAI.RealtimeResponseOutputItemDone?>? responseOutputItemDone = null,
            global::System.Action<global::OpenAI.RealtimeResponseContentPartAdded?>? responseContentPartAdded = null,
            global::System.Action<global::OpenAI.RealtimeResponseContentPartDone?>? responseContentPartDone = null,
            global::System.Action<global::OpenAI.RealtimeResponseTextDelta?>? responseTextDelta = null,
            global::System.Action<global::OpenAI.RealtimeResponseTextDone?>? responseTextDone = null,
            global::System.Action<global::OpenAI.RealtimeResponseAudioTranscriptDelta?>? responseAudioTranscriptDelta = null,
            global::System.Action<global::OpenAI.RealtimeResponseAudioTranscriptDone?>? responseAudioTranscriptDone = null,
            global::System.Action<global::OpenAI.RealtimeResponseAudioDelta?>? responseAudioDelta = null,
            global::System.Action<global::OpenAI.RealtimeResponseAudioDone?>? responseAudioDone = null,
            global::System.Action<global::OpenAI.RealtimeResponseFunctionCallArgumentsDelta?>? responseFunctionCallArgumentsDelta = null,
            global::System.Action<global::OpenAI.RealtimeResponseFunctionCallArgumentsDone?>? responseFunctionCallArgumentsDone = null,
            global::System.Action<global::OpenAI.RealtimeRateLimitsUpdated?>? rateLimitsUpdated = null,
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
                typeof(global::OpenAI.RealtimeError),
                SessionCreated,
                typeof(global::OpenAI.RealtimeSessionCreated),
                SessionUpdated,
                typeof(global::OpenAI.RealtimeSessionUpdated),
                ConversationCreated,
                typeof(global::OpenAI.RealtimeConversationCreated),
                ConversationItemCreated,
                typeof(global::OpenAI.RealtimeConversationItemCreated),
                ConversationItemInputAudioTranscriptionCompleted,
                typeof(global::OpenAI.RealtimeConversationItemInputAudioTranscriptionCompleted),
                ConversationItemInputAudioTranscriptionFailed,
                typeof(global::OpenAI.RealtimeConversationItemInputAudioTranscriptionFailed),
                ConversationItemTruncated,
                typeof(global::OpenAI.RealtimeConversationItemTruncated),
                ConversationItemDeleted,
                typeof(global::OpenAI.RealtimeConversationItemDeleted),
                InputAudioBufferCommitted,
                typeof(global::OpenAI.RealtimeInputAudioBufferCommitted),
                InputAudioBufferCleared,
                typeof(global::OpenAI.RealtimeInputAudioBufferCleared),
                InputAudioBufferSpeechStarted,
                typeof(global::OpenAI.RealtimeInputAudioBufferSpeechStarted),
                InputAudioBufferSpeechStopped,
                typeof(global::OpenAI.RealtimeInputAudioBufferSpeechStopped),
                ResponseCreated,
                typeof(global::OpenAI.RealtimeResponseCreated),
                ResponseDone,
                typeof(global::OpenAI.RealtimeResponseDone),
                ResponseOutputItemAdded,
                typeof(global::OpenAI.RealtimeResponseOutputItemAdded),
                ResponseOutputItemDone,
                typeof(global::OpenAI.RealtimeResponseOutputItemDone),
                ResponseContentPartAdded,
                typeof(global::OpenAI.RealtimeResponseContentPartAdded),
                ResponseContentPartDone,
                typeof(global::OpenAI.RealtimeResponseContentPartDone),
                ResponseTextDelta,
                typeof(global::OpenAI.RealtimeResponseTextDelta),
                ResponseTextDone,
                typeof(global::OpenAI.RealtimeResponseTextDone),
                ResponseAudioTranscriptDelta,
                typeof(global::OpenAI.RealtimeResponseAudioTranscriptDelta),
                ResponseAudioTranscriptDone,
                typeof(global::OpenAI.RealtimeResponseAudioTranscriptDone),
                ResponseAudioDelta,
                typeof(global::OpenAI.RealtimeResponseAudioDelta),
                ResponseAudioDone,
                typeof(global::OpenAI.RealtimeResponseAudioDone),
                ResponseFunctionCallArgumentsDelta,
                typeof(global::OpenAI.RealtimeResponseFunctionCallArgumentsDelta),
                ResponseFunctionCallArgumentsDone,
                typeof(global::OpenAI.RealtimeResponseFunctionCallArgumentsDone),
                RateLimitsUpdated,
                typeof(global::OpenAI.RealtimeRateLimitsUpdated),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(RealtimeServerEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RealtimeError?>.Default.Equals(Error, other.Error) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RealtimeSessionCreated?>.Default.Equals(SessionCreated, other.SessionCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RealtimeSessionUpdated?>.Default.Equals(SessionUpdated, other.SessionUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RealtimeConversationCreated?>.Default.Equals(ConversationCreated, other.ConversationCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RealtimeConversationItemCreated?>.Default.Equals(ConversationItemCreated, other.ConversationItemCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RealtimeConversationItemInputAudioTranscriptionCompleted?>.Default.Equals(ConversationItemInputAudioTranscriptionCompleted, other.ConversationItemInputAudioTranscriptionCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RealtimeConversationItemInputAudioTranscriptionFailed?>.Default.Equals(ConversationItemInputAudioTranscriptionFailed, other.ConversationItemInputAudioTranscriptionFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RealtimeConversationItemTruncated?>.Default.Equals(ConversationItemTruncated, other.ConversationItemTruncated) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RealtimeConversationItemDeleted?>.Default.Equals(ConversationItemDeleted, other.ConversationItemDeleted) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RealtimeInputAudioBufferCommitted?>.Default.Equals(InputAudioBufferCommitted, other.InputAudioBufferCommitted) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RealtimeInputAudioBufferCleared?>.Default.Equals(InputAudioBufferCleared, other.InputAudioBufferCleared) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RealtimeInputAudioBufferSpeechStarted?>.Default.Equals(InputAudioBufferSpeechStarted, other.InputAudioBufferSpeechStarted) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RealtimeInputAudioBufferSpeechStopped?>.Default.Equals(InputAudioBufferSpeechStopped, other.InputAudioBufferSpeechStopped) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RealtimeResponseCreated?>.Default.Equals(ResponseCreated, other.ResponseCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RealtimeResponseDone?>.Default.Equals(ResponseDone, other.ResponseDone) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RealtimeResponseOutputItemAdded?>.Default.Equals(ResponseOutputItemAdded, other.ResponseOutputItemAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RealtimeResponseOutputItemDone?>.Default.Equals(ResponseOutputItemDone, other.ResponseOutputItemDone) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RealtimeResponseContentPartAdded?>.Default.Equals(ResponseContentPartAdded, other.ResponseContentPartAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RealtimeResponseContentPartDone?>.Default.Equals(ResponseContentPartDone, other.ResponseContentPartDone) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RealtimeResponseTextDelta?>.Default.Equals(ResponseTextDelta, other.ResponseTextDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RealtimeResponseTextDone?>.Default.Equals(ResponseTextDone, other.ResponseTextDone) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RealtimeResponseAudioTranscriptDelta?>.Default.Equals(ResponseAudioTranscriptDelta, other.ResponseAudioTranscriptDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RealtimeResponseAudioTranscriptDone?>.Default.Equals(ResponseAudioTranscriptDone, other.ResponseAudioTranscriptDone) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RealtimeResponseAudioDelta?>.Default.Equals(ResponseAudioDelta, other.ResponseAudioDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RealtimeResponseAudioDone?>.Default.Equals(ResponseAudioDone, other.ResponseAudioDone) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RealtimeResponseFunctionCallArgumentsDelta?>.Default.Equals(ResponseFunctionCallArgumentsDelta, other.ResponseFunctionCallArgumentsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RealtimeResponseFunctionCallArgumentsDone?>.Default.Equals(ResponseFunctionCallArgumentsDone, other.ResponseFunctionCallArgumentsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RealtimeRateLimitsUpdated?>.Default.Equals(RateLimitsUpdated, other.RateLimitsUpdated) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RealtimeServerEvent obj1, RealtimeServerEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RealtimeServerEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RealtimeServerEvent obj1, RealtimeServerEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RealtimeServerEvent o && Equals(o);
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::OpenAI.RealtimeServerEvent? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::OpenAI.RealtimeServerEvent),
                jsonSerializerContext) as global::OpenAI.RealtimeServerEvent?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::OpenAI.RealtimeServerEvent? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::OpenAI.RealtimeServerEvent>(
                json,
                jsonSerializerOptions);
        }

    }
}
