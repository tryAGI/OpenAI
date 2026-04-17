#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// A realtime server event.
    /// </summary>
    public readonly partial struct RealtimeServerEvent : global::System.IEquatable<RealtimeServerEvent>
    {
        /// <summary>
        /// Returned when a conversation is created. Emitted right after session creation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreated? ConversationCreated { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreated? ConversationCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationCreated))]
#endif
        public bool IsConversationCreated => ConversationCreated != null;

        /// <summary>
        /// Returned when a conversation item is created. There are several scenarios that produce this event:<br/>
        ///   - The server is generating a Response, which if successful will produce<br/>
        ///     either one or two Items, which will be of type `message`<br/>
        ///     (role `assistant`) or type `function_call`.<br/>
        ///   - The input audio buffer has been committed, either by the client or the<br/>
        ///     server (in `server_vad` mode). The server will take the content of the<br/>
        ///     input audio buffer and add it to a new user message Item.<br/>
        ///   - The client has sent a `conversation.item.create` event to add a new Item<br/>
        ///     to the Conversation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemCreated? ConversationItemCreated { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemCreated? ConversationItemCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemCreated))]
#endif
        public bool IsConversationItemCreated => ConversationItemCreated != null;

        /// <summary>
        /// Returned when an item in the conversation is deleted by the client with a <br/>
        /// `conversation.item.delete` event. This event is used to synchronize the <br/>
        /// server's understanding of the conversation history with the client's view.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeleted? ConversationItemDeleted { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeleted? ConversationItemDeleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemDeleted))]
#endif
        public bool IsConversationItemDeleted => ConversationItemDeleted != null;

        /// <summary>
        /// This event is the output of audio transcription for user audio written to the<br/>
        /// user audio buffer. Transcription begins when the input audio buffer is<br/>
        /// committed by the client or server (when VAD is enabled). Transcription runs<br/>
        /// asynchronously with Response creation, so this event may come before or after<br/>
        /// the Response events.<br/>
        /// Realtime API models accept audio natively, and thus input transcription is a<br/>
        /// separate process run on a separate ASR (Automatic Speech Recognition) model.<br/>
        /// The transcript may diverge somewhat from the model's interpretation, and<br/>
        /// should be treated as a rough guide.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted? ConversationItemInputAudioTranscriptionCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted? ConversationItemInputAudioTranscriptionCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemInputAudioTranscriptionCompleted))]
#endif
        public bool IsConversationItemInputAudioTranscriptionCompleted => ConversationItemInputAudioTranscriptionCompleted != null;

        /// <summary>
        /// Returned when the text value of an input audio transcription content part is updated with incremental transcription results.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDelta? ConversationItemInputAudioTranscriptionDelta { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDelta? ConversationItemInputAudioTranscriptionDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemInputAudioTranscriptionDelta))]
#endif
        public bool IsConversationItemInputAudioTranscriptionDelta => ConversationItemInputAudioTranscriptionDelta != null;

        /// <summary>
        /// Returned when input audio transcription is configured, and a transcription <br/>
        /// request for a user message failed. These events are separate from other <br/>
        /// `error` events so that the client can identify the related Item.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailed? ConversationItemInputAudioTranscriptionFailed { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailed? ConversationItemInputAudioTranscriptionFailed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemInputAudioTranscriptionFailed))]
#endif
        public bool IsConversationItemInputAudioTranscriptionFailed => ConversationItemInputAudioTranscriptionFailed != null;

        /// <summary>
        /// Returned when a conversation item is retrieved with `conversation.item.retrieve`. This is provided as a way to fetch the server's representation of an item, for example to get access to the post-processed audio data after noise cancellation and VAD. It includes the full content of the Item, including audio data.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrieved? ConversationItemRetrieved { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrieved? ConversationItemRetrieved { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemRetrieved))]
#endif
        public bool IsConversationItemRetrieved => ConversationItemRetrieved != null;

        /// <summary>
        /// Returned when an earlier assistant audio message item is truncated by the <br/>
        /// client with a `conversation.item.truncate` event. This event is used to <br/>
        /// synchronize the server's understanding of the audio with the client's playback.<br/>
        /// This action will truncate the audio and remove the server-side text transcript <br/>
        /// to ensure there is no text in the context that hasn't been heard by the user.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemTruncated? ConversationItemTruncated { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemTruncated? ConversationItemTruncated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemTruncated))]
#endif
        public bool IsConversationItemTruncated => ConversationItemTruncated != null;

        /// <summary>
        /// Returned when an error occurs, which could be a client problem or a server<br/>
        /// problem. Most errors are recoverable and the session will stay open, we<br/>
        /// recommend to implementors to monitor and log error messages by default.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventError? Error { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventError? Error { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;

        /// <summary>
        /// Returned when the input audio buffer is cleared by the client with a <br/>
        /// `input_audio_buffer.clear` event.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCleared? InputAudioBufferCleared { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCleared? InputAudioBufferCleared { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudioBufferCleared))]
#endif
        public bool IsInputAudioBufferCleared => InputAudioBufferCleared != null;

        /// <summary>
        /// Returned when an input audio buffer is committed, either by the client or<br/>
        /// automatically in server VAD mode. The `item_id` property is the ID of the user<br/>
        /// message item that will be created, thus a `conversation.item.created` event<br/>
        /// will also be sent to the client.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommitted? InputAudioBufferCommitted { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommitted? InputAudioBufferCommitted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudioBufferCommitted))]
#endif
        public bool IsInputAudioBufferCommitted => InputAudioBufferCommitted != null;

        /// <summary>
        /// **SIP Only:** Returned when an DTMF event is received. A DTMF event is a message that<br/>
        /// represents a telephone keypad press (0–9, *, #, A–D). The `event` property<br/>
        /// is the keypad that the user press. The `received_at` is the UTC Unix Timestamp<br/>
        /// that the server received the event.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferDtmfEventReceived? InputAudioBufferDtmfEventReceived { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferDtmfEventReceived? InputAudioBufferDtmfEventReceived { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudioBufferDtmfEventReceived))]
#endif
        public bool IsInputAudioBufferDtmfEventReceived => InputAudioBufferDtmfEventReceived != null;

        /// <summary>
        /// Sent by the server when in `server_vad` mode to indicate that speech has been <br/>
        /// detected in the audio buffer. This can happen any time audio is added to the <br/>
        /// buffer (unless speech is already detected). The client may want to use this <br/>
        /// event to interrupt audio playback or provide visual feedback to the user. <br/>
        /// The client should expect to receive a `input_audio_buffer.speech_stopped` event <br/>
        /// when speech stops. The `item_id` property is the ID of the user message item <br/>
        /// that will be created when speech stops and will also be included in the <br/>
        /// `input_audio_buffer.speech_stopped` event (unless the client manually commits <br/>
        /// the audio buffer during VAD activation).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStarted? InputAudioBufferSpeechStarted { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStarted? InputAudioBufferSpeechStarted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudioBufferSpeechStarted))]
#endif
        public bool IsInputAudioBufferSpeechStarted => InputAudioBufferSpeechStarted != null;

        /// <summary>
        /// Returned in `server_vad` mode when the server detects the end of speech in <br/>
        /// the audio buffer. The server will also send an `conversation.item.created` <br/>
        /// event with the user message item that is created from the audio buffer.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStopped? InputAudioBufferSpeechStopped { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStopped? InputAudioBufferSpeechStopped { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudioBufferSpeechStopped))]
#endif
        public bool IsInputAudioBufferSpeechStopped => InputAudioBufferSpeechStopped != null;

        /// <summary>
        /// Emitted at the beginning of a Response to indicate the updated rate limits. <br/>
        /// When a Response is created some tokens will be "reserved" for the output <br/>
        /// tokens, the rate limits shown here reflect that reservation, which is then <br/>
        /// adjusted accordingly once the Response is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdated? RateLimitsUpdated { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdated? RateLimitsUpdated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RateLimitsUpdated))]
#endif
        public bool IsRateLimitsUpdated => RateLimitsUpdated != null;

        /// <summary>
        /// Returned when the model-generated audio is updated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDelta? ResponseOutputAudioDelta { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDelta? ResponseOutputAudioDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputAudioDelta))]
#endif
        public bool IsResponseOutputAudioDelta => ResponseOutputAudioDelta != null;

        /// <summary>
        /// Returned when the model-generated audio is done. Also emitted when a Response<br/>
        /// is interrupted, incomplete, or cancelled.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDone? ResponseOutputAudioDone { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDone? ResponseOutputAudioDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputAudioDone))]
#endif
        public bool IsResponseOutputAudioDone => ResponseOutputAudioDone != null;

        /// <summary>
        /// Returned when the model-generated transcription of audio output is updated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDelta? ResponseOutputAudioTranscriptDelta { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDelta? ResponseOutputAudioTranscriptDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputAudioTranscriptDelta))]
#endif
        public bool IsResponseOutputAudioTranscriptDelta => ResponseOutputAudioTranscriptDelta != null;

        /// <summary>
        /// Returned when the model-generated transcription of audio output is done<br/>
        /// streaming. Also emitted when a Response is interrupted, incomplete, or<br/>
        /// cancelled.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDone? ResponseOutputAudioTranscriptDone { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDone? ResponseOutputAudioTranscriptDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputAudioTranscriptDone))]
#endif
        public bool IsResponseOutputAudioTranscriptDone => ResponseOutputAudioTranscriptDone != null;

        /// <summary>
        /// Returned when a new content part is added to an assistant message item during<br/>
        /// response generation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAdded? ResponseContentPartAdded { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAdded? ResponseContentPartAdded { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseContentPartAdded))]
#endif
        public bool IsResponseContentPartAdded => ResponseContentPartAdded != null;

        /// <summary>
        /// Returned when a content part is done streaming in an assistant message item.<br/>
        /// Also emitted when a Response is interrupted, incomplete, or cancelled.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDone? ResponseContentPartDone { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDone? ResponseContentPartDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseContentPartDone))]
#endif
        public bool IsResponseContentPartDone => ResponseContentPartDone != null;

        /// <summary>
        /// Returned when a new Response is created. The first event of response creation,<br/>
        /// where the response is in an initial state of `in_progress`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseCreated? ResponseCreated { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseCreated? ResponseCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCreated))]
#endif
        public bool IsResponseCreated => ResponseCreated != null;

        /// <summary>
        /// Returned when a Response is done streaming. Always emitted, no matter the <br/>
        /// final state. The Response object included in the `response.done` event will <br/>
        /// include all output Items in the Response but will omit the raw audio data.<br/>
        /// Clients should check the `status` field of the Response to determine if it was successful<br/>
        /// (`completed`) or if there was another outcome: `cancelled`, `failed`, or `incomplete`.<br/>
        /// A response will contain all output items that were generated during the response, excluding<br/>
        /// any audio content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseDone? ResponseDone { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseDone? ResponseDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseDone))]
#endif
        public bool IsResponseDone => ResponseDone != null;

        /// <summary>
        /// Returned when the model-generated function call arguments are updated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDelta? ResponseFunctionCallArgumentsDelta { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDelta? ResponseFunctionCallArgumentsDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFunctionCallArgumentsDelta))]
#endif
        public bool IsResponseFunctionCallArgumentsDelta => ResponseFunctionCallArgumentsDelta != null;

        /// <summary>
        /// Returned when the model-generated function call arguments are done streaming.<br/>
        /// Also emitted when a Response is interrupted, incomplete, or cancelled.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDone? ResponseFunctionCallArgumentsDone { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDone? ResponseFunctionCallArgumentsDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFunctionCallArgumentsDone))]
#endif
        public bool IsResponseFunctionCallArgumentsDone => ResponseFunctionCallArgumentsDone != null;

        /// <summary>
        /// Returned when a new Item is created during Response generation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAdded? ResponseOutputItemAdded { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAdded? ResponseOutputItemAdded { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputItemAdded))]
#endif
        public bool IsResponseOutputItemAdded => ResponseOutputItemAdded != null;

        /// <summary>
        /// Returned when an Item is done streaming. Also emitted when a Response is <br/>
        /// interrupted, incomplete, or cancelled.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDone? ResponseOutputItemDone { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDone? ResponseOutputItemDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputItemDone))]
#endif
        public bool IsResponseOutputItemDone => ResponseOutputItemDone != null;

        /// <summary>
        /// Returned when the text value of an "output_text" content part is updated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDelta? ResponseOutputTextDelta { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDelta? ResponseOutputTextDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputTextDelta))]
#endif
        public bool IsResponseOutputTextDelta => ResponseOutputTextDelta != null;

        /// <summary>
        /// Returned when the text value of an "output_text" content part is done streaming. Also<br/>
        /// emitted when a Response is interrupted, incomplete, or cancelled.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDone? ResponseOutputTextDone { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDone? ResponseOutputTextDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputTextDone))]
#endif
        public bool IsResponseOutputTextDone => ResponseOutputTextDone != null;

        /// <summary>
        /// Returned when a Session is created. Emitted automatically when a new<br/>
        /// connection is established as the first server event. This event will contain<br/>
        /// the default Session configuration.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreated? SessionCreated { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreated? SessionCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionCreated))]
#endif
        public bool IsSessionCreated => SessionCreated != null;

        /// <summary>
        /// Returned when a session is updated with a `session.update` event, unless<br/>
        /// there is an error.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdated? SessionUpdated { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdated? SessionUpdated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionUpdated))]
#endif
        public bool IsSessionUpdated => SessionUpdated != null;

        /// <summary>
        /// **WebRTC/SIP Only:** Emitted when the server begins streaming audio to the client. This event is<br/>
        /// emitted after an audio content part has been added (`response.content_part.added`)<br/>
        /// to the response.<br/>
        /// [Learn more](/docs/guides/realtime-conversations#client-and-server-events-for-audio-in-webrtc).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStarted? OutputAudioBufferStarted { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStarted? OutputAudioBufferStarted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputAudioBufferStarted))]
#endif
        public bool IsOutputAudioBufferStarted => OutputAudioBufferStarted != null;

        /// <summary>
        /// **WebRTC/SIP Only:** Emitted when the output audio buffer has been completely drained on the server,<br/>
        /// and no more audio is forthcoming. This event is emitted after the full response<br/>
        /// data has been sent to the client (`response.done`).<br/>
        /// [Learn more](/docs/guides/realtime-conversations#client-and-server-events-for-audio-in-webrtc).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStopped? OutputAudioBufferStopped { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStopped? OutputAudioBufferStopped { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputAudioBufferStopped))]
#endif
        public bool IsOutputAudioBufferStopped => OutputAudioBufferStopped != null;

        /// <summary>
        /// **WebRTC/SIP Only:** Emitted when the output audio buffer is cleared. This happens either in VAD<br/>
        /// mode when the user has interrupted (`input_audio_buffer.speech_started`),<br/>
        /// or when the client has emitted the `output_audio_buffer.clear` event to manually<br/>
        /// cut off the current audio response.<br/>
        /// [Learn more](/docs/guides/realtime-conversations#client-and-server-events-for-audio-in-webrtc).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferCleared? OutputAudioBufferCleared { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferCleared? OutputAudioBufferCleared { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputAudioBufferCleared))]
#endif
        public bool IsOutputAudioBufferCleared => OutputAudioBufferCleared != null;

        /// <summary>
        /// Sent by the server when an Item is added to the default Conversation. This can happen in several cases:<br/>
        /// - When the client sends a `conversation.item.create` event.<br/>
        /// - When the input audio buffer is committed. In this case the item will be a user message containing the audio from the buffer.<br/>
        /// - When the model is generating a Response. In this case the `conversation.item.added` event will be sent when the model starts generating a specific Item, and thus it will not yet have any content (and `status` will be `in_progress`).<br/>
        /// The event will include the full content of the Item (except when model is generating a Response) except for audio data, which can be retrieved separately with a `conversation.item.retrieve` event if necessary.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemAdded? ConversationItemAdded { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemAdded? ConversationItemAdded { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemAdded))]
#endif
        public bool IsConversationItemAdded => ConversationItemAdded != null;

        /// <summary>
        /// Returned when a conversation item is finalized.<br/>
        /// The event will include the full content of the Item except for audio data, which can be retrieved separately with a `conversation.item.retrieve` event if needed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDone? ConversationItemDone { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDone? ConversationItemDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemDone))]
#endif
        public bool IsConversationItemDone => ConversationItemDone != null;

        /// <summary>
        /// Returned when the Server VAD timeout is triggered for the input audio buffer. This is configured<br/>
        /// with `idle_timeout_ms` in the `turn_detection` settings of the session, and it indicates that<br/>
        /// there hasn't been any speech detected for the configured duration.<br/>
        /// The `audio_start_ms` and `audio_end_ms` fields indicate the segment of audio after the last<br/>
        /// model response up to the triggering time, as an offset from the beginning of audio written<br/>
        /// to the input audio buffer. This means it demarcates the segment of audio that was silent and<br/>
        /// the difference between the start and end values will roughly match the configured timeout.<br/>
        /// The empty audio will be committed to the conversation as an `input_audio` item (there will be a<br/>
        /// `input_audio_buffer.committed` event) and a model response will be generated. There may be speech<br/>
        /// that didn't trigger VAD but is still detected by the model, so the model may respond with<br/>
        /// something relevant to the conversation or a prompt to continue speaking.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferTimeoutTriggered? InputAudioBufferTimeoutTriggered { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferTimeoutTriggered? InputAudioBufferTimeoutTriggered { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudioBufferTimeoutTriggered))]
#endif
        public bool IsInputAudioBufferTimeoutTriggered => InputAudioBufferTimeoutTriggered != null;

        /// <summary>
        /// Returned when an input audio transcription segment is identified for an item.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionSegment? ConversationItemInputAudioTranscriptionSegment { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionSegment? ConversationItemInputAudioTranscriptionSegment { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemInputAudioTranscriptionSegment))]
#endif
        public bool IsConversationItemInputAudioTranscriptionSegment => ConversationItemInputAudioTranscriptionSegment != null;

        /// <summary>
        /// Returned when listing MCP tools is in progress for an item.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgress? McpListToolsInProgress { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgress? McpListToolsInProgress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpListToolsInProgress))]
#endif
        public bool IsMcpListToolsInProgress => McpListToolsInProgress != null;

        /// <summary>
        /// Returned when listing MCP tools has completed for an item.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompleted? McpListToolsCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompleted? McpListToolsCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpListToolsCompleted))]
#endif
        public bool IsMcpListToolsCompleted => McpListToolsCompleted != null;

        /// <summary>
        /// Returned when listing MCP tools has failed for an item.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailed? McpListToolsFailed { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailed? McpListToolsFailed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpListToolsFailed))]
#endif
        public bool IsMcpListToolsFailed => McpListToolsFailed != null;

        /// <summary>
        /// Returned when MCP tool call arguments are updated during response generation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDelta? ResponseMcpCallArgumentsDelta { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDelta? ResponseMcpCallArgumentsDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseMcpCallArgumentsDelta))]
#endif
        public bool IsResponseMcpCallArgumentsDelta => ResponseMcpCallArgumentsDelta != null;

        /// <summary>
        /// Returned when MCP tool call arguments are finalized during response generation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDone? ResponseMcpCallArgumentsDone { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDone? ResponseMcpCallArgumentsDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseMcpCallArgumentsDone))]
#endif
        public bool IsResponseMcpCallArgumentsDone => ResponseMcpCallArgumentsDone != null;

        /// <summary>
        /// Returned when an MCP tool call has started and is in progress.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgress? ResponseMcpCallInProgress { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgress? ResponseMcpCallInProgress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseMcpCallInProgress))]
#endif
        public bool IsResponseMcpCallInProgress => ResponseMcpCallInProgress != null;

        /// <summary>
        /// Returned when an MCP tool call has completed successfully.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompleted? ResponseMcpCallCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompleted? ResponseMcpCallCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseMcpCallCompleted))]
#endif
        public bool IsResponseMcpCallCompleted => ResponseMcpCallCompleted != null;

        /// <summary>
        /// Returned when an MCP tool call has failed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailed? ResponseMcpCallFailed { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailed? ResponseMcpCallFailed { get; }
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
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreated value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreated?(RealtimeServerEvent @this) => @this.ConversationCreated;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreated? value)
        {
            ConversationCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemCreated value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemCreated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemCreated?(RealtimeServerEvent @this) => @this.ConversationItemCreated;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemCreated? value)
        {
            ConversationItemCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeleted value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeleted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeleted?(RealtimeServerEvent @this) => @this.ConversationItemDeleted;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeleted? value)
        {
            ConversationItemDeleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted?(RealtimeServerEvent @this) => @this.ConversationItemInputAudioTranscriptionCompleted;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted? value)
        {
            ConversationItemInputAudioTranscriptionCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDelta value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDelta?(RealtimeServerEvent @this) => @this.ConversationItemInputAudioTranscriptionDelta;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDelta? value)
        {
            ConversationItemInputAudioTranscriptionDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailed value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailed?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailed?(RealtimeServerEvent @this) => @this.ConversationItemInputAudioTranscriptionFailed;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailed? value)
        {
            ConversationItemInputAudioTranscriptionFailed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrieved value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrieved?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrieved?(RealtimeServerEvent @this) => @this.ConversationItemRetrieved;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrieved? value)
        {
            ConversationItemRetrieved = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemTruncated value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemTruncated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemTruncated?(RealtimeServerEvent @this) => @this.ConversationItemTruncated;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemTruncated? value)
        {
            ConversationItemTruncated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventError value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventError?(RealtimeServerEvent @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventError? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCleared value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCleared?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCleared?(RealtimeServerEvent @this) => @this.InputAudioBufferCleared;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCleared? value)
        {
            InputAudioBufferCleared = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommitted value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommitted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommitted?(RealtimeServerEvent @this) => @this.InputAudioBufferCommitted;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommitted? value)
        {
            InputAudioBufferCommitted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferDtmfEventReceived value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferDtmfEventReceived?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferDtmfEventReceived?(RealtimeServerEvent @this) => @this.InputAudioBufferDtmfEventReceived;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferDtmfEventReceived? value)
        {
            InputAudioBufferDtmfEventReceived = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStarted value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStarted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStarted?(RealtimeServerEvent @this) => @this.InputAudioBufferSpeechStarted;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStarted? value)
        {
            InputAudioBufferSpeechStarted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStopped value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStopped?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStopped?(RealtimeServerEvent @this) => @this.InputAudioBufferSpeechStopped;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStopped? value)
        {
            InputAudioBufferSpeechStopped = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdated value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdated?(RealtimeServerEvent @this) => @this.RateLimitsUpdated;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdated? value)
        {
            RateLimitsUpdated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDelta value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDelta?(RealtimeServerEvent @this) => @this.ResponseOutputAudioDelta;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDelta? value)
        {
            ResponseOutputAudioDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDone value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDone?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDone?(RealtimeServerEvent @this) => @this.ResponseOutputAudioDone;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDone? value)
        {
            ResponseOutputAudioDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDelta value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDelta?(RealtimeServerEvent @this) => @this.ResponseOutputAudioTranscriptDelta;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDelta? value)
        {
            ResponseOutputAudioTranscriptDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDone value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDone?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDone?(RealtimeServerEvent @this) => @this.ResponseOutputAudioTranscriptDone;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDone? value)
        {
            ResponseOutputAudioTranscriptDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAdded value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAdded?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAdded?(RealtimeServerEvent @this) => @this.ResponseContentPartAdded;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAdded? value)
        {
            ResponseContentPartAdded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDone value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDone?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDone?(RealtimeServerEvent @this) => @this.ResponseContentPartDone;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDone? value)
        {
            ResponseContentPartDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseCreated value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseCreated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseCreated?(RealtimeServerEvent @this) => @this.ResponseCreated;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseCreated? value)
        {
            ResponseCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseDone value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseDone?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseDone?(RealtimeServerEvent @this) => @this.ResponseDone;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseDone? value)
        {
            ResponseDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDelta value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDelta?(RealtimeServerEvent @this) => @this.ResponseFunctionCallArgumentsDelta;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDelta? value)
        {
            ResponseFunctionCallArgumentsDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDone value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDone?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDone?(RealtimeServerEvent @this) => @this.ResponseFunctionCallArgumentsDone;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDone? value)
        {
            ResponseFunctionCallArgumentsDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAdded value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAdded?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAdded?(RealtimeServerEvent @this) => @this.ResponseOutputItemAdded;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAdded? value)
        {
            ResponseOutputItemAdded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDone value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDone?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDone?(RealtimeServerEvent @this) => @this.ResponseOutputItemDone;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDone? value)
        {
            ResponseOutputItemDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDelta value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDelta?(RealtimeServerEvent @this) => @this.ResponseOutputTextDelta;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDelta? value)
        {
            ResponseOutputTextDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDone value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDone?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDone?(RealtimeServerEvent @this) => @this.ResponseOutputTextDone;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDone? value)
        {
            ResponseOutputTextDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreated value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreated?(RealtimeServerEvent @this) => @this.SessionCreated;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreated? value)
        {
            SessionCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdated value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdated?(RealtimeServerEvent @this) => @this.SessionUpdated;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdated? value)
        {
            SessionUpdated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStarted value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStarted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStarted?(RealtimeServerEvent @this) => @this.OutputAudioBufferStarted;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStarted? value)
        {
            OutputAudioBufferStarted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStopped value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStopped?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStopped?(RealtimeServerEvent @this) => @this.OutputAudioBufferStopped;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStopped? value)
        {
            OutputAudioBufferStopped = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferCleared value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferCleared?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferCleared?(RealtimeServerEvent @this) => @this.OutputAudioBufferCleared;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferCleared? value)
        {
            OutputAudioBufferCleared = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemAdded value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemAdded?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemAdded?(RealtimeServerEvent @this) => @this.ConversationItemAdded;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemAdded? value)
        {
            ConversationItemAdded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDone value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDone?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDone?(RealtimeServerEvent @this) => @this.ConversationItemDone;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDone? value)
        {
            ConversationItemDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferTimeoutTriggered value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferTimeoutTriggered?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferTimeoutTriggered?(RealtimeServerEvent @this) => @this.InputAudioBufferTimeoutTriggered;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferTimeoutTriggered? value)
        {
            InputAudioBufferTimeoutTriggered = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionSegment value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionSegment?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionSegment?(RealtimeServerEvent @this) => @this.ConversationItemInputAudioTranscriptionSegment;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionSegment? value)
        {
            ConversationItemInputAudioTranscriptionSegment = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgress value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgress?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgress?(RealtimeServerEvent @this) => @this.McpListToolsInProgress;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgress? value)
        {
            McpListToolsInProgress = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompleted value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompleted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompleted?(RealtimeServerEvent @this) => @this.McpListToolsCompleted;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompleted? value)
        {
            McpListToolsCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailed value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailed?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailed?(RealtimeServerEvent @this) => @this.McpListToolsFailed;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailed? value)
        {
            McpListToolsFailed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDelta value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDelta?(RealtimeServerEvent @this) => @this.ResponseMcpCallArgumentsDelta;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDelta? value)
        {
            ResponseMcpCallArgumentsDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDone value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDone?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDone?(RealtimeServerEvent @this) => @this.ResponseMcpCallArgumentsDone;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDone? value)
        {
            ResponseMcpCallArgumentsDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgress value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgress?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgress?(RealtimeServerEvent @this) => @this.ResponseMcpCallInProgress;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgress? value)
        {
            ResponseMcpCallInProgress = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompleted value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompleted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompleted?(RealtimeServerEvent @this) => @this.ResponseMcpCallCompleted;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompleted? value)
        {
            ResponseMcpCallCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailed value) => new RealtimeServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailed?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailed?(RealtimeServerEvent @this) => @this.ResponseMcpCallFailed;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailed? value)
        {
            ResponseMcpCallFailed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreated? conversationCreated,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemCreated? conversationItemCreated,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeleted? conversationItemDeleted,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted? conversationItemInputAudioTranscriptionCompleted,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDelta? conversationItemInputAudioTranscriptionDelta,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailed? conversationItemInputAudioTranscriptionFailed,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrieved? conversationItemRetrieved,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemTruncated? conversationItemTruncated,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventError? error,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCleared? inputAudioBufferCleared,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommitted? inputAudioBufferCommitted,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferDtmfEventReceived? inputAudioBufferDtmfEventReceived,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStarted? inputAudioBufferSpeechStarted,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStopped? inputAudioBufferSpeechStopped,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdated? rateLimitsUpdated,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDelta? responseOutputAudioDelta,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDone? responseOutputAudioDone,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDelta? responseOutputAudioTranscriptDelta,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDone? responseOutputAudioTranscriptDone,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAdded? responseContentPartAdded,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDone? responseContentPartDone,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseCreated? responseCreated,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseDone? responseDone,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDelta? responseFunctionCallArgumentsDelta,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDone? responseFunctionCallArgumentsDone,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAdded? responseOutputItemAdded,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDone? responseOutputItemDone,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDelta? responseOutputTextDelta,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDone? responseOutputTextDone,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreated? sessionCreated,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdated? sessionUpdated,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStarted? outputAudioBufferStarted,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStopped? outputAudioBufferStopped,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferCleared? outputAudioBufferCleared,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemAdded? conversationItemAdded,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDone? conversationItemDone,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferTimeoutTriggered? inputAudioBufferTimeoutTriggered,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionSegment? conversationItemInputAudioTranscriptionSegment,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgress? mcpListToolsInProgress,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompleted? mcpListToolsCompleted,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailed? mcpListToolsFailed,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDelta? responseMcpCallArgumentsDelta,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDone? responseMcpCallArgumentsDone,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgress? responseMcpCallInProgress,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompleted? responseMcpCallCompleted,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailed? responseMcpCallFailed
            )
        {
            ConversationCreated = conversationCreated;
            ConversationItemCreated = conversationItemCreated;
            ConversationItemDeleted = conversationItemDeleted;
            ConversationItemInputAudioTranscriptionCompleted = conversationItemInputAudioTranscriptionCompleted;
            ConversationItemInputAudioTranscriptionDelta = conversationItemInputAudioTranscriptionDelta;
            ConversationItemInputAudioTranscriptionFailed = conversationItemInputAudioTranscriptionFailed;
            ConversationItemRetrieved = conversationItemRetrieved;
            ConversationItemTruncated = conversationItemTruncated;
            Error = error;
            InputAudioBufferCleared = inputAudioBufferCleared;
            InputAudioBufferCommitted = inputAudioBufferCommitted;
            InputAudioBufferDtmfEventReceived = inputAudioBufferDtmfEventReceived;
            InputAudioBufferSpeechStarted = inputAudioBufferSpeechStarted;
            InputAudioBufferSpeechStopped = inputAudioBufferSpeechStopped;
            RateLimitsUpdated = rateLimitsUpdated;
            ResponseOutputAudioDelta = responseOutputAudioDelta;
            ResponseOutputAudioDone = responseOutputAudioDone;
            ResponseOutputAudioTranscriptDelta = responseOutputAudioTranscriptDelta;
            ResponseOutputAudioTranscriptDone = responseOutputAudioTranscriptDone;
            ResponseContentPartAdded = responseContentPartAdded;
            ResponseContentPartDone = responseContentPartDone;
            ResponseCreated = responseCreated;
            ResponseDone = responseDone;
            ResponseFunctionCallArgumentsDelta = responseFunctionCallArgumentsDelta;
            ResponseFunctionCallArgumentsDone = responseFunctionCallArgumentsDone;
            ResponseOutputItemAdded = responseOutputItemAdded;
            ResponseOutputItemDone = responseOutputItemDone;
            ResponseOutputTextDelta = responseOutputTextDelta;
            ResponseOutputTextDone = responseOutputTextDone;
            SessionCreated = sessionCreated;
            SessionUpdated = sessionUpdated;
            OutputAudioBufferStarted = outputAudioBufferStarted;
            OutputAudioBufferStopped = outputAudioBufferStopped;
            OutputAudioBufferCleared = outputAudioBufferCleared;
            ConversationItemAdded = conversationItemAdded;
            ConversationItemDone = conversationItemDone;
            InputAudioBufferTimeoutTriggered = inputAudioBufferTimeoutTriggered;
            ConversationItemInputAudioTranscriptionSegment = conversationItemInputAudioTranscriptionSegment;
            McpListToolsInProgress = mcpListToolsInProgress;
            McpListToolsCompleted = mcpListToolsCompleted;
            McpListToolsFailed = mcpListToolsFailed;
            ResponseMcpCallArgumentsDelta = responseMcpCallArgumentsDelta;
            ResponseMcpCallArgumentsDone = responseMcpCallArgumentsDone;
            ResponseMcpCallInProgress = responseMcpCallInProgress;
            ResponseMcpCallCompleted = responseMcpCallCompleted;
            ResponseMcpCallFailed = responseMcpCallFailed;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ResponseMcpCallFailed as object ??
            ResponseMcpCallCompleted as object ??
            ResponseMcpCallInProgress as object ??
            ResponseMcpCallArgumentsDone as object ??
            ResponseMcpCallArgumentsDelta as object ??
            McpListToolsFailed as object ??
            McpListToolsCompleted as object ??
            McpListToolsInProgress as object ??
            ConversationItemInputAudioTranscriptionSegment as object ??
            InputAudioBufferTimeoutTriggered as object ??
            ConversationItemDone as object ??
            ConversationItemAdded as object ??
            OutputAudioBufferCleared as object ??
            OutputAudioBufferStopped as object ??
            OutputAudioBufferStarted as object ??
            SessionUpdated as object ??
            SessionCreated as object ??
            ResponseOutputTextDone as object ??
            ResponseOutputTextDelta as object ??
            ResponseOutputItemDone as object ??
            ResponseOutputItemAdded as object ??
            ResponseFunctionCallArgumentsDone as object ??
            ResponseFunctionCallArgumentsDelta as object ??
            ResponseDone as object ??
            ResponseCreated as object ??
            ResponseContentPartDone as object ??
            ResponseContentPartAdded as object ??
            ResponseOutputAudioTranscriptDone as object ??
            ResponseOutputAudioTranscriptDelta as object ??
            ResponseOutputAudioDone as object ??
            ResponseOutputAudioDelta as object ??
            RateLimitsUpdated as object ??
            InputAudioBufferSpeechStopped as object ??
            InputAudioBufferSpeechStarted as object ??
            InputAudioBufferDtmfEventReceived as object ??
            InputAudioBufferCommitted as object ??
            InputAudioBufferCleared as object ??
            Error as object ??
            ConversationItemTruncated as object ??
            ConversationItemRetrieved as object ??
            ConversationItemInputAudioTranscriptionFailed as object ??
            ConversationItemInputAudioTranscriptionDelta as object ??
            ConversationItemInputAudioTranscriptionCompleted as object ??
            ConversationItemDeleted as object ??
            ConversationItemCreated as object ??
            ConversationCreated as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ConversationCreated?.ToString() ??
            ConversationItemCreated?.ToString() ??
            ConversationItemDeleted?.ToString() ??
            ConversationItemInputAudioTranscriptionCompleted?.ToString() ??
            ConversationItemInputAudioTranscriptionDelta?.ToString() ??
            ConversationItemInputAudioTranscriptionFailed?.ToString() ??
            ConversationItemRetrieved?.ToString() ??
            ConversationItemTruncated?.ToString() ??
            Error?.ToString() ??
            InputAudioBufferCleared?.ToString() ??
            InputAudioBufferCommitted?.ToString() ??
            InputAudioBufferDtmfEventReceived?.ToString() ??
            InputAudioBufferSpeechStarted?.ToString() ??
            InputAudioBufferSpeechStopped?.ToString() ??
            RateLimitsUpdated?.ToString() ??
            ResponseOutputAudioDelta?.ToString() ??
            ResponseOutputAudioDone?.ToString() ??
            ResponseOutputAudioTranscriptDelta?.ToString() ??
            ResponseOutputAudioTranscriptDone?.ToString() ??
            ResponseContentPartAdded?.ToString() ??
            ResponseContentPartDone?.ToString() ??
            ResponseCreated?.ToString() ??
            ResponseDone?.ToString() ??
            ResponseFunctionCallArgumentsDelta?.ToString() ??
            ResponseFunctionCallArgumentsDone?.ToString() ??
            ResponseOutputItemAdded?.ToString() ??
            ResponseOutputItemDone?.ToString() ??
            ResponseOutputTextDelta?.ToString() ??
            ResponseOutputTextDone?.ToString() ??
            SessionCreated?.ToString() ??
            SessionUpdated?.ToString() ??
            OutputAudioBufferStarted?.ToString() ??
            OutputAudioBufferStopped?.ToString() ??
            OutputAudioBufferCleared?.ToString() ??
            ConversationItemAdded?.ToString() ??
            ConversationItemDone?.ToString() ??
            InputAudioBufferTimeoutTriggered?.ToString() ??
            ConversationItemInputAudioTranscriptionSegment?.ToString() ??
            McpListToolsInProgress?.ToString() ??
            McpListToolsCompleted?.ToString() ??
            McpListToolsFailed?.ToString() ??
            ResponseMcpCallArgumentsDelta?.ToString() ??
            ResponseMcpCallArgumentsDone?.ToString() ??
            ResponseMcpCallInProgress?.ToString() ??
            ResponseMcpCallCompleted?.ToString() ??
            ResponseMcpCallFailed?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsConversationCreated || IsConversationItemCreated || IsConversationItemDeleted || IsConversationItemInputAudioTranscriptionCompleted || IsConversationItemInputAudioTranscriptionDelta || IsConversationItemInputAudioTranscriptionFailed || IsConversationItemRetrieved || IsConversationItemTruncated || IsError || IsInputAudioBufferCleared || IsInputAudioBufferCommitted || IsInputAudioBufferDtmfEventReceived || IsInputAudioBufferSpeechStarted || IsInputAudioBufferSpeechStopped || IsRateLimitsUpdated || IsResponseOutputAudioDelta || IsResponseOutputAudioDone || IsResponseOutputAudioTranscriptDelta || IsResponseOutputAudioTranscriptDone || IsResponseContentPartAdded || IsResponseContentPartDone || IsResponseCreated || IsResponseDone || IsResponseFunctionCallArgumentsDelta || IsResponseFunctionCallArgumentsDone || IsResponseOutputItemAdded || IsResponseOutputItemDone || IsResponseOutputTextDelta || IsResponseOutputTextDone || IsSessionCreated || IsSessionUpdated || IsOutputAudioBufferStarted || IsOutputAudioBufferStopped || IsOutputAudioBufferCleared || IsConversationItemAdded || IsConversationItemDone || IsInputAudioBufferTimeoutTriggered || IsConversationItemInputAudioTranscriptionSegment || IsMcpListToolsInProgress || IsMcpListToolsCompleted || IsMcpListToolsFailed || IsResponseMcpCallArgumentsDelta || IsResponseMcpCallArgumentsDone || IsResponseMcpCallInProgress || IsResponseMcpCallCompleted || IsResponseMcpCallFailed;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreated?, TResult>? conversationCreated = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemCreated?, TResult>? conversationItemCreated = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeleted?, TResult>? conversationItemDeleted = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted?, TResult>? conversationItemInputAudioTranscriptionCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDelta?, TResult>? conversationItemInputAudioTranscriptionDelta = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailed?, TResult>? conversationItemInputAudioTranscriptionFailed = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrieved?, TResult>? conversationItemRetrieved = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemTruncated?, TResult>? conversationItemTruncated = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventError?, TResult>? error = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCleared?, TResult>? inputAudioBufferCleared = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommitted?, TResult>? inputAudioBufferCommitted = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferDtmfEventReceived?, TResult>? inputAudioBufferDtmfEventReceived = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStarted?, TResult>? inputAudioBufferSpeechStarted = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStopped?, TResult>? inputAudioBufferSpeechStopped = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdated?, TResult>? rateLimitsUpdated = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDelta?, TResult>? responseOutputAudioDelta = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDone?, TResult>? responseOutputAudioDone = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDelta?, TResult>? responseOutputAudioTranscriptDelta = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDone?, TResult>? responseOutputAudioTranscriptDone = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAdded?, TResult>? responseContentPartAdded = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDone?, TResult>? responseContentPartDone = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseCreated?, TResult>? responseCreated = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseDone?, TResult>? responseDone = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDelta?, TResult>? responseFunctionCallArgumentsDelta = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDone?, TResult>? responseFunctionCallArgumentsDone = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAdded?, TResult>? responseOutputItemAdded = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDone?, TResult>? responseOutputItemDone = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDelta?, TResult>? responseOutputTextDelta = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDone?, TResult>? responseOutputTextDone = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreated?, TResult>? sessionCreated = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdated?, TResult>? sessionUpdated = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStarted?, TResult>? outputAudioBufferStarted = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStopped?, TResult>? outputAudioBufferStopped = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferCleared?, TResult>? outputAudioBufferCleared = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemAdded?, TResult>? conversationItemAdded = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDone?, TResult>? conversationItemDone = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferTimeoutTriggered?, TResult>? inputAudioBufferTimeoutTriggered = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionSegment?, TResult>? conversationItemInputAudioTranscriptionSegment = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgress?, TResult>? mcpListToolsInProgress = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompleted?, TResult>? mcpListToolsCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailed?, TResult>? mcpListToolsFailed = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDelta?, TResult>? responseMcpCallArgumentsDelta = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDone?, TResult>? responseMcpCallArgumentsDone = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgress?, TResult>? responseMcpCallInProgress = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompleted?, TResult>? responseMcpCallCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailed?, TResult>? responseMcpCallFailed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConversationCreated && conversationCreated != null)
            {
                return conversationCreated(ConversationCreated!);
            }
            else if (IsConversationItemCreated && conversationItemCreated != null)
            {
                return conversationItemCreated(ConversationItemCreated!);
            }
            else if (IsConversationItemDeleted && conversationItemDeleted != null)
            {
                return conversationItemDeleted(ConversationItemDeleted!);
            }
            else if (IsConversationItemInputAudioTranscriptionCompleted && conversationItemInputAudioTranscriptionCompleted != null)
            {
                return conversationItemInputAudioTranscriptionCompleted(ConversationItemInputAudioTranscriptionCompleted!);
            }
            else if (IsConversationItemInputAudioTranscriptionDelta && conversationItemInputAudioTranscriptionDelta != null)
            {
                return conversationItemInputAudioTranscriptionDelta(ConversationItemInputAudioTranscriptionDelta!);
            }
            else if (IsConversationItemInputAudioTranscriptionFailed && conversationItemInputAudioTranscriptionFailed != null)
            {
                return conversationItemInputAudioTranscriptionFailed(ConversationItemInputAudioTranscriptionFailed!);
            }
            else if (IsConversationItemRetrieved && conversationItemRetrieved != null)
            {
                return conversationItemRetrieved(ConversationItemRetrieved!);
            }
            else if (IsConversationItemTruncated && conversationItemTruncated != null)
            {
                return conversationItemTruncated(ConversationItemTruncated!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }
            else if (IsInputAudioBufferCleared && inputAudioBufferCleared != null)
            {
                return inputAudioBufferCleared(InputAudioBufferCleared!);
            }
            else if (IsInputAudioBufferCommitted && inputAudioBufferCommitted != null)
            {
                return inputAudioBufferCommitted(InputAudioBufferCommitted!);
            }
            else if (IsInputAudioBufferDtmfEventReceived && inputAudioBufferDtmfEventReceived != null)
            {
                return inputAudioBufferDtmfEventReceived(InputAudioBufferDtmfEventReceived!);
            }
            else if (IsInputAudioBufferSpeechStarted && inputAudioBufferSpeechStarted != null)
            {
                return inputAudioBufferSpeechStarted(InputAudioBufferSpeechStarted!);
            }
            else if (IsInputAudioBufferSpeechStopped && inputAudioBufferSpeechStopped != null)
            {
                return inputAudioBufferSpeechStopped(InputAudioBufferSpeechStopped!);
            }
            else if (IsRateLimitsUpdated && rateLimitsUpdated != null)
            {
                return rateLimitsUpdated(RateLimitsUpdated!);
            }
            else if (IsResponseOutputAudioDelta && responseOutputAudioDelta != null)
            {
                return responseOutputAudioDelta(ResponseOutputAudioDelta!);
            }
            else if (IsResponseOutputAudioDone && responseOutputAudioDone != null)
            {
                return responseOutputAudioDone(ResponseOutputAudioDone!);
            }
            else if (IsResponseOutputAudioTranscriptDelta && responseOutputAudioTranscriptDelta != null)
            {
                return responseOutputAudioTranscriptDelta(ResponseOutputAudioTranscriptDelta!);
            }
            else if (IsResponseOutputAudioTranscriptDone && responseOutputAudioTranscriptDone != null)
            {
                return responseOutputAudioTranscriptDone(ResponseOutputAudioTranscriptDone!);
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
            else if (IsResponseDone && responseDone != null)
            {
                return responseDone(ResponseDone!);
            }
            else if (IsResponseFunctionCallArgumentsDelta && responseFunctionCallArgumentsDelta != null)
            {
                return responseFunctionCallArgumentsDelta(ResponseFunctionCallArgumentsDelta!);
            }
            else if (IsResponseFunctionCallArgumentsDone && responseFunctionCallArgumentsDone != null)
            {
                return responseFunctionCallArgumentsDone(ResponseFunctionCallArgumentsDone!);
            }
            else if (IsResponseOutputItemAdded && responseOutputItemAdded != null)
            {
                return responseOutputItemAdded(ResponseOutputItemAdded!);
            }
            else if (IsResponseOutputItemDone && responseOutputItemDone != null)
            {
                return responseOutputItemDone(ResponseOutputItemDone!);
            }
            else if (IsResponseOutputTextDelta && responseOutputTextDelta != null)
            {
                return responseOutputTextDelta(ResponseOutputTextDelta!);
            }
            else if (IsResponseOutputTextDone && responseOutputTextDone != null)
            {
                return responseOutputTextDone(ResponseOutputTextDone!);
            }
            else if (IsSessionCreated && sessionCreated != null)
            {
                return sessionCreated(SessionCreated!);
            }
            else if (IsSessionUpdated && sessionUpdated != null)
            {
                return sessionUpdated(SessionUpdated!);
            }
            else if (IsOutputAudioBufferStarted && outputAudioBufferStarted != null)
            {
                return outputAudioBufferStarted(OutputAudioBufferStarted!);
            }
            else if (IsOutputAudioBufferStopped && outputAudioBufferStopped != null)
            {
                return outputAudioBufferStopped(OutputAudioBufferStopped!);
            }
            else if (IsOutputAudioBufferCleared && outputAudioBufferCleared != null)
            {
                return outputAudioBufferCleared(OutputAudioBufferCleared!);
            }
            else if (IsConversationItemAdded && conversationItemAdded != null)
            {
                return conversationItemAdded(ConversationItemAdded!);
            }
            else if (IsConversationItemDone && conversationItemDone != null)
            {
                return conversationItemDone(ConversationItemDone!);
            }
            else if (IsInputAudioBufferTimeoutTriggered && inputAudioBufferTimeoutTriggered != null)
            {
                return inputAudioBufferTimeoutTriggered(InputAudioBufferTimeoutTriggered!);
            }
            else if (IsConversationItemInputAudioTranscriptionSegment && conversationItemInputAudioTranscriptionSegment != null)
            {
                return conversationItemInputAudioTranscriptionSegment(ConversationItemInputAudioTranscriptionSegment!);
            }
            else if (IsMcpListToolsInProgress && mcpListToolsInProgress != null)
            {
                return mcpListToolsInProgress(McpListToolsInProgress!);
            }
            else if (IsMcpListToolsCompleted && mcpListToolsCompleted != null)
            {
                return mcpListToolsCompleted(McpListToolsCompleted!);
            }
            else if (IsMcpListToolsFailed && mcpListToolsFailed != null)
            {
                return mcpListToolsFailed(McpListToolsFailed!);
            }
            else if (IsResponseMcpCallArgumentsDelta && responseMcpCallArgumentsDelta != null)
            {
                return responseMcpCallArgumentsDelta(ResponseMcpCallArgumentsDelta!);
            }
            else if (IsResponseMcpCallArgumentsDone && responseMcpCallArgumentsDone != null)
            {
                return responseMcpCallArgumentsDone(ResponseMcpCallArgumentsDone!);
            }
            else if (IsResponseMcpCallInProgress && responseMcpCallInProgress != null)
            {
                return responseMcpCallInProgress(ResponseMcpCallInProgress!);
            }
            else if (IsResponseMcpCallCompleted && responseMcpCallCompleted != null)
            {
                return responseMcpCallCompleted(ResponseMcpCallCompleted!);
            }
            else if (IsResponseMcpCallFailed && responseMcpCallFailed != null)
            {
                return responseMcpCallFailed(ResponseMcpCallFailed!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreated?>? conversationCreated = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemCreated?>? conversationItemCreated = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeleted?>? conversationItemDeleted = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted?>? conversationItemInputAudioTranscriptionCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDelta?>? conversationItemInputAudioTranscriptionDelta = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailed?>? conversationItemInputAudioTranscriptionFailed = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrieved?>? conversationItemRetrieved = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemTruncated?>? conversationItemTruncated = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventError?>? error = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCleared?>? inputAudioBufferCleared = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommitted?>? inputAudioBufferCommitted = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferDtmfEventReceived?>? inputAudioBufferDtmfEventReceived = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStarted?>? inputAudioBufferSpeechStarted = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStopped?>? inputAudioBufferSpeechStopped = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdated?>? rateLimitsUpdated = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDelta?>? responseOutputAudioDelta = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDone?>? responseOutputAudioDone = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDelta?>? responseOutputAudioTranscriptDelta = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDone?>? responseOutputAudioTranscriptDone = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAdded?>? responseContentPartAdded = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDone?>? responseContentPartDone = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseCreated?>? responseCreated = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseDone?>? responseDone = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDelta?>? responseFunctionCallArgumentsDelta = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDone?>? responseFunctionCallArgumentsDone = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAdded?>? responseOutputItemAdded = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDone?>? responseOutputItemDone = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDelta?>? responseOutputTextDelta = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDone?>? responseOutputTextDone = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreated?>? sessionCreated = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdated?>? sessionUpdated = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStarted?>? outputAudioBufferStarted = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStopped?>? outputAudioBufferStopped = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferCleared?>? outputAudioBufferCleared = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemAdded?>? conversationItemAdded = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDone?>? conversationItemDone = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferTimeoutTriggered?>? inputAudioBufferTimeoutTriggered = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionSegment?>? conversationItemInputAudioTranscriptionSegment = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgress?>? mcpListToolsInProgress = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompleted?>? mcpListToolsCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailed?>? mcpListToolsFailed = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDelta?>? responseMcpCallArgumentsDelta = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDone?>? responseMcpCallArgumentsDone = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgress?>? responseMcpCallInProgress = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompleted?>? responseMcpCallCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailed?>? responseMcpCallFailed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConversationCreated)
            {
                conversationCreated?.Invoke(ConversationCreated!);
            }
            else if (IsConversationItemCreated)
            {
                conversationItemCreated?.Invoke(ConversationItemCreated!);
            }
            else if (IsConversationItemDeleted)
            {
                conversationItemDeleted?.Invoke(ConversationItemDeleted!);
            }
            else if (IsConversationItemInputAudioTranscriptionCompleted)
            {
                conversationItemInputAudioTranscriptionCompleted?.Invoke(ConversationItemInputAudioTranscriptionCompleted!);
            }
            else if (IsConversationItemInputAudioTranscriptionDelta)
            {
                conversationItemInputAudioTranscriptionDelta?.Invoke(ConversationItemInputAudioTranscriptionDelta!);
            }
            else if (IsConversationItemInputAudioTranscriptionFailed)
            {
                conversationItemInputAudioTranscriptionFailed?.Invoke(ConversationItemInputAudioTranscriptionFailed!);
            }
            else if (IsConversationItemRetrieved)
            {
                conversationItemRetrieved?.Invoke(ConversationItemRetrieved!);
            }
            else if (IsConversationItemTruncated)
            {
                conversationItemTruncated?.Invoke(ConversationItemTruncated!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
            else if (IsInputAudioBufferCleared)
            {
                inputAudioBufferCleared?.Invoke(InputAudioBufferCleared!);
            }
            else if (IsInputAudioBufferCommitted)
            {
                inputAudioBufferCommitted?.Invoke(InputAudioBufferCommitted!);
            }
            else if (IsInputAudioBufferDtmfEventReceived)
            {
                inputAudioBufferDtmfEventReceived?.Invoke(InputAudioBufferDtmfEventReceived!);
            }
            else if (IsInputAudioBufferSpeechStarted)
            {
                inputAudioBufferSpeechStarted?.Invoke(InputAudioBufferSpeechStarted!);
            }
            else if (IsInputAudioBufferSpeechStopped)
            {
                inputAudioBufferSpeechStopped?.Invoke(InputAudioBufferSpeechStopped!);
            }
            else if (IsRateLimitsUpdated)
            {
                rateLimitsUpdated?.Invoke(RateLimitsUpdated!);
            }
            else if (IsResponseOutputAudioDelta)
            {
                responseOutputAudioDelta?.Invoke(ResponseOutputAudioDelta!);
            }
            else if (IsResponseOutputAudioDone)
            {
                responseOutputAudioDone?.Invoke(ResponseOutputAudioDone!);
            }
            else if (IsResponseOutputAudioTranscriptDelta)
            {
                responseOutputAudioTranscriptDelta?.Invoke(ResponseOutputAudioTranscriptDelta!);
            }
            else if (IsResponseOutputAudioTranscriptDone)
            {
                responseOutputAudioTranscriptDone?.Invoke(ResponseOutputAudioTranscriptDone!);
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
            else if (IsResponseDone)
            {
                responseDone?.Invoke(ResponseDone!);
            }
            else if (IsResponseFunctionCallArgumentsDelta)
            {
                responseFunctionCallArgumentsDelta?.Invoke(ResponseFunctionCallArgumentsDelta!);
            }
            else if (IsResponseFunctionCallArgumentsDone)
            {
                responseFunctionCallArgumentsDone?.Invoke(ResponseFunctionCallArgumentsDone!);
            }
            else if (IsResponseOutputItemAdded)
            {
                responseOutputItemAdded?.Invoke(ResponseOutputItemAdded!);
            }
            else if (IsResponseOutputItemDone)
            {
                responseOutputItemDone?.Invoke(ResponseOutputItemDone!);
            }
            else if (IsResponseOutputTextDelta)
            {
                responseOutputTextDelta?.Invoke(ResponseOutputTextDelta!);
            }
            else if (IsResponseOutputTextDone)
            {
                responseOutputTextDone?.Invoke(ResponseOutputTextDone!);
            }
            else if (IsSessionCreated)
            {
                sessionCreated?.Invoke(SessionCreated!);
            }
            else if (IsSessionUpdated)
            {
                sessionUpdated?.Invoke(SessionUpdated!);
            }
            else if (IsOutputAudioBufferStarted)
            {
                outputAudioBufferStarted?.Invoke(OutputAudioBufferStarted!);
            }
            else if (IsOutputAudioBufferStopped)
            {
                outputAudioBufferStopped?.Invoke(OutputAudioBufferStopped!);
            }
            else if (IsOutputAudioBufferCleared)
            {
                outputAudioBufferCleared?.Invoke(OutputAudioBufferCleared!);
            }
            else if (IsConversationItemAdded)
            {
                conversationItemAdded?.Invoke(ConversationItemAdded!);
            }
            else if (IsConversationItemDone)
            {
                conversationItemDone?.Invoke(ConversationItemDone!);
            }
            else if (IsInputAudioBufferTimeoutTriggered)
            {
                inputAudioBufferTimeoutTriggered?.Invoke(InputAudioBufferTimeoutTriggered!);
            }
            else if (IsConversationItemInputAudioTranscriptionSegment)
            {
                conversationItemInputAudioTranscriptionSegment?.Invoke(ConversationItemInputAudioTranscriptionSegment!);
            }
            else if (IsMcpListToolsInProgress)
            {
                mcpListToolsInProgress?.Invoke(McpListToolsInProgress!);
            }
            else if (IsMcpListToolsCompleted)
            {
                mcpListToolsCompleted?.Invoke(McpListToolsCompleted!);
            }
            else if (IsMcpListToolsFailed)
            {
                mcpListToolsFailed?.Invoke(McpListToolsFailed!);
            }
            else if (IsResponseMcpCallArgumentsDelta)
            {
                responseMcpCallArgumentsDelta?.Invoke(ResponseMcpCallArgumentsDelta!);
            }
            else if (IsResponseMcpCallArgumentsDone)
            {
                responseMcpCallArgumentsDone?.Invoke(ResponseMcpCallArgumentsDone!);
            }
            else if (IsResponseMcpCallInProgress)
            {
                responseMcpCallInProgress?.Invoke(ResponseMcpCallInProgress!);
            }
            else if (IsResponseMcpCallCompleted)
            {
                responseMcpCallCompleted?.Invoke(ResponseMcpCallCompleted!);
            }
            else if (IsResponseMcpCallFailed)
            {
                responseMcpCallFailed?.Invoke(ResponseMcpCallFailed!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ConversationCreated,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreated),
                ConversationItemCreated,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemCreated),
                ConversationItemDeleted,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeleted),
                ConversationItemInputAudioTranscriptionCompleted,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted),
                ConversationItemInputAudioTranscriptionDelta,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDelta),
                ConversationItemInputAudioTranscriptionFailed,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailed),
                ConversationItemRetrieved,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrieved),
                ConversationItemTruncated,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemTruncated),
                Error,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventError),
                InputAudioBufferCleared,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCleared),
                InputAudioBufferCommitted,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommitted),
                InputAudioBufferDtmfEventReceived,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferDtmfEventReceived),
                InputAudioBufferSpeechStarted,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStarted),
                InputAudioBufferSpeechStopped,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStopped),
                RateLimitsUpdated,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdated),
                ResponseOutputAudioDelta,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDelta),
                ResponseOutputAudioDone,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDone),
                ResponseOutputAudioTranscriptDelta,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDelta),
                ResponseOutputAudioTranscriptDone,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDone),
                ResponseContentPartAdded,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAdded),
                ResponseContentPartDone,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDone),
                ResponseCreated,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseCreated),
                ResponseDone,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseDone),
                ResponseFunctionCallArgumentsDelta,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDelta),
                ResponseFunctionCallArgumentsDone,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDone),
                ResponseOutputItemAdded,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAdded),
                ResponseOutputItemDone,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDone),
                ResponseOutputTextDelta,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDelta),
                ResponseOutputTextDone,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDone),
                SessionCreated,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreated),
                SessionUpdated,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdated),
                OutputAudioBufferStarted,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStarted),
                OutputAudioBufferStopped,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStopped),
                OutputAudioBufferCleared,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferCleared),
                ConversationItemAdded,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemAdded),
                ConversationItemDone,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDone),
                InputAudioBufferTimeoutTriggered,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferTimeoutTriggered),
                ConversationItemInputAudioTranscriptionSegment,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionSegment),
                McpListToolsInProgress,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgress),
                McpListToolsCompleted,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompleted),
                McpListToolsFailed,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailed),
                ResponseMcpCallArgumentsDelta,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDelta),
                ResponseMcpCallArgumentsDone,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDone),
                ResponseMcpCallInProgress,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgress),
                ResponseMcpCallCompleted,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompleted),
                ResponseMcpCallFailed,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailed),
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
        public bool Equals(RealtimeServerEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreated?>.Default.Equals(ConversationCreated, other.ConversationCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemCreated?>.Default.Equals(ConversationItemCreated, other.ConversationItemCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeleted?>.Default.Equals(ConversationItemDeleted, other.ConversationItemDeleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted?>.Default.Equals(ConversationItemInputAudioTranscriptionCompleted, other.ConversationItemInputAudioTranscriptionCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDelta?>.Default.Equals(ConversationItemInputAudioTranscriptionDelta, other.ConversationItemInputAudioTranscriptionDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailed?>.Default.Equals(ConversationItemInputAudioTranscriptionFailed, other.ConversationItemInputAudioTranscriptionFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrieved?>.Default.Equals(ConversationItemRetrieved, other.ConversationItemRetrieved) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemTruncated?>.Default.Equals(ConversationItemTruncated, other.ConversationItemTruncated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventError?>.Default.Equals(Error, other.Error) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCleared?>.Default.Equals(InputAudioBufferCleared, other.InputAudioBufferCleared) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommitted?>.Default.Equals(InputAudioBufferCommitted, other.InputAudioBufferCommitted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferDtmfEventReceived?>.Default.Equals(InputAudioBufferDtmfEventReceived, other.InputAudioBufferDtmfEventReceived) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStarted?>.Default.Equals(InputAudioBufferSpeechStarted, other.InputAudioBufferSpeechStarted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStopped?>.Default.Equals(InputAudioBufferSpeechStopped, other.InputAudioBufferSpeechStopped) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdated?>.Default.Equals(RateLimitsUpdated, other.RateLimitsUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDelta?>.Default.Equals(ResponseOutputAudioDelta, other.ResponseOutputAudioDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDone?>.Default.Equals(ResponseOutputAudioDone, other.ResponseOutputAudioDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDelta?>.Default.Equals(ResponseOutputAudioTranscriptDelta, other.ResponseOutputAudioTranscriptDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDone?>.Default.Equals(ResponseOutputAudioTranscriptDone, other.ResponseOutputAudioTranscriptDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAdded?>.Default.Equals(ResponseContentPartAdded, other.ResponseContentPartAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDone?>.Default.Equals(ResponseContentPartDone, other.ResponseContentPartDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseCreated?>.Default.Equals(ResponseCreated, other.ResponseCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseDone?>.Default.Equals(ResponseDone, other.ResponseDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDelta?>.Default.Equals(ResponseFunctionCallArgumentsDelta, other.ResponseFunctionCallArgumentsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDone?>.Default.Equals(ResponseFunctionCallArgumentsDone, other.ResponseFunctionCallArgumentsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAdded?>.Default.Equals(ResponseOutputItemAdded, other.ResponseOutputItemAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDone?>.Default.Equals(ResponseOutputItemDone, other.ResponseOutputItemDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDelta?>.Default.Equals(ResponseOutputTextDelta, other.ResponseOutputTextDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDone?>.Default.Equals(ResponseOutputTextDone, other.ResponseOutputTextDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreated?>.Default.Equals(SessionCreated, other.SessionCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdated?>.Default.Equals(SessionUpdated, other.SessionUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStarted?>.Default.Equals(OutputAudioBufferStarted, other.OutputAudioBufferStarted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStopped?>.Default.Equals(OutputAudioBufferStopped, other.OutputAudioBufferStopped) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferCleared?>.Default.Equals(OutputAudioBufferCleared, other.OutputAudioBufferCleared) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemAdded?>.Default.Equals(ConversationItemAdded, other.ConversationItemAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDone?>.Default.Equals(ConversationItemDone, other.ConversationItemDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferTimeoutTriggered?>.Default.Equals(InputAudioBufferTimeoutTriggered, other.InputAudioBufferTimeoutTriggered) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionSegment?>.Default.Equals(ConversationItemInputAudioTranscriptionSegment, other.ConversationItemInputAudioTranscriptionSegment) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgress?>.Default.Equals(McpListToolsInProgress, other.McpListToolsInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompleted?>.Default.Equals(McpListToolsCompleted, other.McpListToolsCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailed?>.Default.Equals(McpListToolsFailed, other.McpListToolsFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDelta?>.Default.Equals(ResponseMcpCallArgumentsDelta, other.ResponseMcpCallArgumentsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDone?>.Default.Equals(ResponseMcpCallArgumentsDone, other.ResponseMcpCallArgumentsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgress?>.Default.Equals(ResponseMcpCallInProgress, other.ResponseMcpCallInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompleted?>.Default.Equals(ResponseMcpCallCompleted, other.ResponseMcpCallCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailed?>.Default.Equals(ResponseMcpCallFailed, other.ResponseMcpCallFailed) 
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
    }
}
