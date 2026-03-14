#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
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
        public global::tryAGI.OpenAI.RealtimeServerEventConversationCreated? ConversationCreated { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventConversationCreated? ConversationCreated { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreated? ConversationItemCreated { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreated? ConversationItemCreated { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemDeleted? ConversationItemDeleted { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemDeleted? ConversationItemDeleted { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted? ConversationItemInputAudioTranscriptionCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted? ConversationItemInputAudioTranscriptionCompleted { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionDelta? ConversationItemInputAudioTranscriptionDelta { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionDelta? ConversationItemInputAudioTranscriptionDelta { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailed? ConversationItemInputAudioTranscriptionFailed { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailed? ConversationItemInputAudioTranscriptionFailed { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemRetrieved? ConversationItemRetrieved { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemRetrieved? ConversationItemRetrieved { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemTruncated? ConversationItemTruncated { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemTruncated? ConversationItemTruncated { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventError? Error { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventError? Error { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCleared? InputAudioBufferCleared { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCleared? InputAudioBufferCleared { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCommitted? InputAudioBufferCommitted { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCommitted? InputAudioBufferCommitted { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceived? InputAudioBufferDtmfEventReceived { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceived? InputAudioBufferDtmfEventReceived { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStarted? InputAudioBufferSpeechStarted { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStarted? InputAudioBufferSpeechStarted { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStopped? InputAudioBufferSpeechStopped { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStopped? InputAudioBufferSpeechStopped { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdated? RateLimitsUpdated { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdated? RateLimitsUpdated { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDelta? ResponseOutputAudioDelta { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDelta? ResponseOutputAudioDelta { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDone? ResponseOutputAudioDone { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDone? ResponseOutputAudioDone { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDelta? ResponseOutputAudioTranscriptDelta { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDelta? ResponseOutputAudioTranscriptDelta { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDone? ResponseOutputAudioTranscriptDone { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDone? ResponseOutputAudioTranscriptDone { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAdded? ResponseContentPartAdded { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAdded? ResponseContentPartAdded { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDone? ResponseContentPartDone { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDone? ResponseContentPartDone { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventResponseCreated? ResponseCreated { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventResponseCreated? ResponseCreated { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventResponseDone? ResponseDone { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventResponseDone? ResponseDone { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDelta? ResponseFunctionCallArgumentsDelta { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDelta? ResponseFunctionCallArgumentsDelta { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDone? ResponseFunctionCallArgumentsDone { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDone? ResponseFunctionCallArgumentsDone { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAdded? ResponseOutputItemAdded { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAdded? ResponseOutputItemAdded { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemDone? ResponseOutputItemDone { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemDone? ResponseOutputItemDone { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventResponseTextDelta? ResponseOutputTextDelta { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventResponseTextDelta? ResponseOutputTextDelta { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventResponseTextDone? ResponseOutputTextDone { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventResponseTextDone? ResponseOutputTextDone { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventSessionCreated? SessionCreated { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventSessionCreated? SessionCreated { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventSessionUpdated? SessionUpdated { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventSessionUpdated? SessionUpdated { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStarted? OutputAudioBufferStarted { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStarted? OutputAudioBufferStarted { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStopped? OutputAudioBufferStopped { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStopped? OutputAudioBufferStopped { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferCleared? OutputAudioBufferCleared { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferCleared? OutputAudioBufferCleared { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemAdded? ConversationItemAdded { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemAdded? ConversationItemAdded { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemDone? ConversationItemDone { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemDone? ConversationItemDone { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggered? InputAudioBufferTimeoutTriggered { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggered? InputAudioBufferTimeoutTriggered { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegment? ConversationItemInputAudioTranscriptionSegment { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegment? ConversationItemInputAudioTranscriptionSegment { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgress? McpListToolsInProgress { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgress? McpListToolsInProgress { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsCompleted? McpListToolsCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsCompleted? McpListToolsCompleted { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsFailed? McpListToolsFailed { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsFailed? McpListToolsFailed { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDelta? ResponseMcpCallArgumentsDelta { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDelta? ResponseMcpCallArgumentsDelta { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDone? ResponseMcpCallArgumentsDone { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDone? ResponseMcpCallArgumentsDone { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallInProgress? ResponseMcpCallInProgress { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallInProgress? ResponseMcpCallInProgress { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallCompleted? ResponseMcpCallCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallCompleted? ResponseMcpCallCompleted { get; }
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
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallFailed? ResponseMcpCallFailed { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallFailed? ResponseMcpCallFailed { get; }
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
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventConversationCreated value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventConversationCreated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventConversationCreated?(RealtimeServerEvent @this) => @this.ConversationCreated;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventConversationCreated? value)
        {
            ConversationCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreated value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreated?(RealtimeServerEvent @this) => @this.ConversationItemCreated;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreated? value)
        {
            ConversationItemCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventConversationItemDeleted value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventConversationItemDeleted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventConversationItemDeleted?(RealtimeServerEvent @this) => @this.ConversationItemDeleted;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventConversationItemDeleted? value)
        {
            ConversationItemDeleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted?(RealtimeServerEvent @this) => @this.ConversationItemInputAudioTranscriptionCompleted;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted? value)
        {
            ConversationItemInputAudioTranscriptionCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionDelta value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionDelta?(RealtimeServerEvent @this) => @this.ConversationItemInputAudioTranscriptionDelta;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionDelta? value)
        {
            ConversationItemInputAudioTranscriptionDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailed value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailed?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailed?(RealtimeServerEvent @this) => @this.ConversationItemInputAudioTranscriptionFailed;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailed? value)
        {
            ConversationItemInputAudioTranscriptionFailed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventConversationItemRetrieved value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventConversationItemRetrieved?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventConversationItemRetrieved?(RealtimeServerEvent @this) => @this.ConversationItemRetrieved;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventConversationItemRetrieved? value)
        {
            ConversationItemRetrieved = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventConversationItemTruncated value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventConversationItemTruncated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventConversationItemTruncated?(RealtimeServerEvent @this) => @this.ConversationItemTruncated;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventConversationItemTruncated? value)
        {
            ConversationItemTruncated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventError value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventError?(RealtimeServerEvent @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventError? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCleared value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCleared?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCleared?(RealtimeServerEvent @this) => @this.InputAudioBufferCleared;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCleared? value)
        {
            InputAudioBufferCleared = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCommitted value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCommitted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCommitted?(RealtimeServerEvent @this) => @this.InputAudioBufferCommitted;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCommitted? value)
        {
            InputAudioBufferCommitted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceived value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceived?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceived?(RealtimeServerEvent @this) => @this.InputAudioBufferDtmfEventReceived;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceived? value)
        {
            InputAudioBufferDtmfEventReceived = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStarted value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStarted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStarted?(RealtimeServerEvent @this) => @this.InputAudioBufferSpeechStarted;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStarted? value)
        {
            InputAudioBufferSpeechStarted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStopped value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStopped?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStopped?(RealtimeServerEvent @this) => @this.InputAudioBufferSpeechStopped;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStopped? value)
        {
            InputAudioBufferSpeechStopped = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdated value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdated?(RealtimeServerEvent @this) => @this.RateLimitsUpdated;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdated? value)
        {
            RateLimitsUpdated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDelta value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDelta?(RealtimeServerEvent @this) => @this.ResponseOutputAudioDelta;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDelta? value)
        {
            ResponseOutputAudioDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDone value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDone?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDone?(RealtimeServerEvent @this) => @this.ResponseOutputAudioDone;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDone? value)
        {
            ResponseOutputAudioDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDelta value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDelta?(RealtimeServerEvent @this) => @this.ResponseOutputAudioTranscriptDelta;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDelta? value)
        {
            ResponseOutputAudioTranscriptDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDone value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDone?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDone?(RealtimeServerEvent @this) => @this.ResponseOutputAudioTranscriptDone;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDone? value)
        {
            ResponseOutputAudioTranscriptDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAdded value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAdded?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAdded?(RealtimeServerEvent @this) => @this.ResponseContentPartAdded;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAdded? value)
        {
            ResponseContentPartAdded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDone value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDone?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDone?(RealtimeServerEvent @this) => @this.ResponseContentPartDone;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDone? value)
        {
            ResponseContentPartDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventResponseCreated value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventResponseCreated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventResponseCreated?(RealtimeServerEvent @this) => @this.ResponseCreated;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventResponseCreated? value)
        {
            ResponseCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventResponseDone value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventResponseDone?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventResponseDone?(RealtimeServerEvent @this) => @this.ResponseDone;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventResponseDone? value)
        {
            ResponseDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDelta value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDelta?(RealtimeServerEvent @this) => @this.ResponseFunctionCallArgumentsDelta;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDelta? value)
        {
            ResponseFunctionCallArgumentsDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDone value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDone?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDone?(RealtimeServerEvent @this) => @this.ResponseFunctionCallArgumentsDone;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDone? value)
        {
            ResponseFunctionCallArgumentsDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAdded value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAdded?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAdded?(RealtimeServerEvent @this) => @this.ResponseOutputItemAdded;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAdded? value)
        {
            ResponseOutputItemAdded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemDone value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemDone?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemDone?(RealtimeServerEvent @this) => @this.ResponseOutputItemDone;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemDone? value)
        {
            ResponseOutputItemDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventResponseTextDelta value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventResponseTextDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventResponseTextDelta?(RealtimeServerEvent @this) => @this.ResponseOutputTextDelta;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventResponseTextDelta? value)
        {
            ResponseOutputTextDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventResponseTextDone value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventResponseTextDone?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventResponseTextDone?(RealtimeServerEvent @this) => @this.ResponseOutputTextDone;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventResponseTextDone? value)
        {
            ResponseOutputTextDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventSessionCreated value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventSessionCreated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventSessionCreated?(RealtimeServerEvent @this) => @this.SessionCreated;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventSessionCreated? value)
        {
            SessionCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventSessionUpdated value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventSessionUpdated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventSessionUpdated?(RealtimeServerEvent @this) => @this.SessionUpdated;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventSessionUpdated? value)
        {
            SessionUpdated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStarted value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStarted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStarted?(RealtimeServerEvent @this) => @this.OutputAudioBufferStarted;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStarted? value)
        {
            OutputAudioBufferStarted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStopped value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStopped?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStopped?(RealtimeServerEvent @this) => @this.OutputAudioBufferStopped;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStopped? value)
        {
            OutputAudioBufferStopped = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferCleared value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferCleared?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferCleared?(RealtimeServerEvent @this) => @this.OutputAudioBufferCleared;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferCleared? value)
        {
            OutputAudioBufferCleared = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventConversationItemAdded value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventConversationItemAdded?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventConversationItemAdded?(RealtimeServerEvent @this) => @this.ConversationItemAdded;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventConversationItemAdded? value)
        {
            ConversationItemAdded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventConversationItemDone value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventConversationItemDone?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventConversationItemDone?(RealtimeServerEvent @this) => @this.ConversationItemDone;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventConversationItemDone? value)
        {
            ConversationItemDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggered value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggered?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggered?(RealtimeServerEvent @this) => @this.InputAudioBufferTimeoutTriggered;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggered? value)
        {
            InputAudioBufferTimeoutTriggered = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegment value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegment?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegment?(RealtimeServerEvent @this) => @this.ConversationItemInputAudioTranscriptionSegment;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegment? value)
        {
            ConversationItemInputAudioTranscriptionSegment = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgress value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgress?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgress?(RealtimeServerEvent @this) => @this.McpListToolsInProgress;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgress? value)
        {
            McpListToolsInProgress = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsCompleted value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsCompleted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsCompleted?(RealtimeServerEvent @this) => @this.McpListToolsCompleted;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsCompleted? value)
        {
            McpListToolsCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsFailed value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsFailed?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsFailed?(RealtimeServerEvent @this) => @this.McpListToolsFailed;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsFailed? value)
        {
            McpListToolsFailed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDelta value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDelta?(RealtimeServerEvent @this) => @this.ResponseMcpCallArgumentsDelta;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDelta? value)
        {
            ResponseMcpCallArgumentsDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDone value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDone?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDone?(RealtimeServerEvent @this) => @this.ResponseMcpCallArgumentsDone;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDone? value)
        {
            ResponseMcpCallArgumentsDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallInProgress value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallInProgress?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallInProgress?(RealtimeServerEvent @this) => @this.ResponseMcpCallInProgress;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallInProgress? value)
        {
            ResponseMcpCallInProgress = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallCompleted value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallCompleted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallCompleted?(RealtimeServerEvent @this) => @this.ResponseMcpCallCompleted;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallCompleted? value)
        {
            ResponseMcpCallCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallFailed value) => new RealtimeServerEvent((global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallFailed?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallFailed?(RealtimeServerEvent @this) => @this.ResponseMcpCallFailed;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallFailed? value)
        {
            ResponseMcpCallFailed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RealtimeServerEvent(
            global::tryAGI.OpenAI.RealtimeServerEventConversationCreated? conversationCreated,
            global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreated? conversationItemCreated,
            global::tryAGI.OpenAI.RealtimeServerEventConversationItemDeleted? conversationItemDeleted,
            global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted? conversationItemInputAudioTranscriptionCompleted,
            global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionDelta? conversationItemInputAudioTranscriptionDelta,
            global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailed? conversationItemInputAudioTranscriptionFailed,
            global::tryAGI.OpenAI.RealtimeServerEventConversationItemRetrieved? conversationItemRetrieved,
            global::tryAGI.OpenAI.RealtimeServerEventConversationItemTruncated? conversationItemTruncated,
            global::tryAGI.OpenAI.RealtimeServerEventError? error,
            global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCleared? inputAudioBufferCleared,
            global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCommitted? inputAudioBufferCommitted,
            global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceived? inputAudioBufferDtmfEventReceived,
            global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStarted? inputAudioBufferSpeechStarted,
            global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStopped? inputAudioBufferSpeechStopped,
            global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdated? rateLimitsUpdated,
            global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDelta? responseOutputAudioDelta,
            global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDone? responseOutputAudioDone,
            global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDelta? responseOutputAudioTranscriptDelta,
            global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDone? responseOutputAudioTranscriptDone,
            global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAdded? responseContentPartAdded,
            global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDone? responseContentPartDone,
            global::tryAGI.OpenAI.RealtimeServerEventResponseCreated? responseCreated,
            global::tryAGI.OpenAI.RealtimeServerEventResponseDone? responseDone,
            global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDelta? responseFunctionCallArgumentsDelta,
            global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDone? responseFunctionCallArgumentsDone,
            global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAdded? responseOutputItemAdded,
            global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemDone? responseOutputItemDone,
            global::tryAGI.OpenAI.RealtimeServerEventResponseTextDelta? responseOutputTextDelta,
            global::tryAGI.OpenAI.RealtimeServerEventResponseTextDone? responseOutputTextDone,
            global::tryAGI.OpenAI.RealtimeServerEventSessionCreated? sessionCreated,
            global::tryAGI.OpenAI.RealtimeServerEventSessionUpdated? sessionUpdated,
            global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStarted? outputAudioBufferStarted,
            global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStopped? outputAudioBufferStopped,
            global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferCleared? outputAudioBufferCleared,
            global::tryAGI.OpenAI.RealtimeServerEventConversationItemAdded? conversationItemAdded,
            global::tryAGI.OpenAI.RealtimeServerEventConversationItemDone? conversationItemDone,
            global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggered? inputAudioBufferTimeoutTriggered,
            global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegment? conversationItemInputAudioTranscriptionSegment,
            global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgress? mcpListToolsInProgress,
            global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsCompleted? mcpListToolsCompleted,
            global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsFailed? mcpListToolsFailed,
            global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDelta? responseMcpCallArgumentsDelta,
            global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDone? responseMcpCallArgumentsDone,
            global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallInProgress? responseMcpCallInProgress,
            global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallCompleted? responseMcpCallCompleted,
            global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallFailed? responseMcpCallFailed
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
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventConversationCreated?, TResult>? conversationCreated = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreated?, TResult>? conversationItemCreated = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventConversationItemDeleted?, TResult>? conversationItemDeleted = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted?, TResult>? conversationItemInputAudioTranscriptionCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionDelta?, TResult>? conversationItemInputAudioTranscriptionDelta = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailed?, TResult>? conversationItemInputAudioTranscriptionFailed = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventConversationItemRetrieved?, TResult>? conversationItemRetrieved = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventConversationItemTruncated?, TResult>? conversationItemTruncated = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventError?, TResult>? error = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCleared?, TResult>? inputAudioBufferCleared = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCommitted?, TResult>? inputAudioBufferCommitted = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceived?, TResult>? inputAudioBufferDtmfEventReceived = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStarted?, TResult>? inputAudioBufferSpeechStarted = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStopped?, TResult>? inputAudioBufferSpeechStopped = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdated?, TResult>? rateLimitsUpdated = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDelta?, TResult>? responseOutputAudioDelta = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDone?, TResult>? responseOutputAudioDone = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDelta?, TResult>? responseOutputAudioTranscriptDelta = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDone?, TResult>? responseOutputAudioTranscriptDone = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAdded?, TResult>? responseContentPartAdded = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDone?, TResult>? responseContentPartDone = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventResponseCreated?, TResult>? responseCreated = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventResponseDone?, TResult>? responseDone = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDelta?, TResult>? responseFunctionCallArgumentsDelta = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDone?, TResult>? responseFunctionCallArgumentsDone = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAdded?, TResult>? responseOutputItemAdded = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemDone?, TResult>? responseOutputItemDone = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventResponseTextDelta?, TResult>? responseOutputTextDelta = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventResponseTextDone?, TResult>? responseOutputTextDone = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventSessionCreated?, TResult>? sessionCreated = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventSessionUpdated?, TResult>? sessionUpdated = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStarted?, TResult>? outputAudioBufferStarted = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStopped?, TResult>? outputAudioBufferStopped = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferCleared?, TResult>? outputAudioBufferCleared = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventConversationItemAdded?, TResult>? conversationItemAdded = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventConversationItemDone?, TResult>? conversationItemDone = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggered?, TResult>? inputAudioBufferTimeoutTriggered = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegment?, TResult>? conversationItemInputAudioTranscriptionSegment = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgress?, TResult>? mcpListToolsInProgress = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsCompleted?, TResult>? mcpListToolsCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsFailed?, TResult>? mcpListToolsFailed = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDelta?, TResult>? responseMcpCallArgumentsDelta = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDone?, TResult>? responseMcpCallArgumentsDone = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallInProgress?, TResult>? responseMcpCallInProgress = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallCompleted?, TResult>? responseMcpCallCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallFailed?, TResult>? responseMcpCallFailed = null,
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
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventConversationCreated?>? conversationCreated = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreated?>? conversationItemCreated = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventConversationItemDeleted?>? conversationItemDeleted = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted?>? conversationItemInputAudioTranscriptionCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionDelta?>? conversationItemInputAudioTranscriptionDelta = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailed?>? conversationItemInputAudioTranscriptionFailed = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventConversationItemRetrieved?>? conversationItemRetrieved = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventConversationItemTruncated?>? conversationItemTruncated = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventError?>? error = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCleared?>? inputAudioBufferCleared = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCommitted?>? inputAudioBufferCommitted = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceived?>? inputAudioBufferDtmfEventReceived = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStarted?>? inputAudioBufferSpeechStarted = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStopped?>? inputAudioBufferSpeechStopped = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdated?>? rateLimitsUpdated = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDelta?>? responseOutputAudioDelta = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDone?>? responseOutputAudioDone = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDelta?>? responseOutputAudioTranscriptDelta = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDone?>? responseOutputAudioTranscriptDone = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAdded?>? responseContentPartAdded = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDone?>? responseContentPartDone = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventResponseCreated?>? responseCreated = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventResponseDone?>? responseDone = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDelta?>? responseFunctionCallArgumentsDelta = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDone?>? responseFunctionCallArgumentsDone = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAdded?>? responseOutputItemAdded = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemDone?>? responseOutputItemDone = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventResponseTextDelta?>? responseOutputTextDelta = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventResponseTextDone?>? responseOutputTextDone = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventSessionCreated?>? sessionCreated = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventSessionUpdated?>? sessionUpdated = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStarted?>? outputAudioBufferStarted = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStopped?>? outputAudioBufferStopped = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferCleared?>? outputAudioBufferCleared = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventConversationItemAdded?>? conversationItemAdded = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventConversationItemDone?>? conversationItemDone = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggered?>? inputAudioBufferTimeoutTriggered = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegment?>? conversationItemInputAudioTranscriptionSegment = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgress?>? mcpListToolsInProgress = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsCompleted?>? mcpListToolsCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsFailed?>? mcpListToolsFailed = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDelta?>? responseMcpCallArgumentsDelta = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDone?>? responseMcpCallArgumentsDone = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallInProgress?>? responseMcpCallInProgress = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallCompleted?>? responseMcpCallCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallFailed?>? responseMcpCallFailed = null,
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
                typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationCreated),
                ConversationItemCreated,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreated),
                ConversationItemDeleted,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemDeleted),
                ConversationItemInputAudioTranscriptionCompleted,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted),
                ConversationItemInputAudioTranscriptionDelta,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionDelta),
                ConversationItemInputAudioTranscriptionFailed,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailed),
                ConversationItemRetrieved,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemRetrieved),
                ConversationItemTruncated,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemTruncated),
                Error,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventError),
                InputAudioBufferCleared,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCleared),
                InputAudioBufferCommitted,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCommitted),
                InputAudioBufferDtmfEventReceived,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceived),
                InputAudioBufferSpeechStarted,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStarted),
                InputAudioBufferSpeechStopped,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStopped),
                RateLimitsUpdated,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdated),
                ResponseOutputAudioDelta,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDelta),
                ResponseOutputAudioDone,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDone),
                ResponseOutputAudioTranscriptDelta,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDelta),
                ResponseOutputAudioTranscriptDone,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDone),
                ResponseContentPartAdded,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAdded),
                ResponseContentPartDone,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDone),
                ResponseCreated,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseCreated),
                ResponseDone,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseDone),
                ResponseFunctionCallArgumentsDelta,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDelta),
                ResponseFunctionCallArgumentsDone,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDone),
                ResponseOutputItemAdded,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAdded),
                ResponseOutputItemDone,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemDone),
                ResponseOutputTextDelta,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseTextDelta),
                ResponseOutputTextDone,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseTextDone),
                SessionCreated,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventSessionCreated),
                SessionUpdated,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventSessionUpdated),
                OutputAudioBufferStarted,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStarted),
                OutputAudioBufferStopped,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStopped),
                OutputAudioBufferCleared,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferCleared),
                ConversationItemAdded,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemAdded),
                ConversationItemDone,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemDone),
                InputAudioBufferTimeoutTriggered,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggered),
                ConversationItemInputAudioTranscriptionSegment,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegment),
                McpListToolsInProgress,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgress),
                McpListToolsCompleted,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsCompleted),
                McpListToolsFailed,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsFailed),
                ResponseMcpCallArgumentsDelta,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDelta),
                ResponseMcpCallArgumentsDone,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDone),
                ResponseMcpCallInProgress,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallInProgress),
                ResponseMcpCallCompleted,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallCompleted),
                ResponseMcpCallFailed,
                typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallFailed),
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
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventConversationCreated?>.Default.Equals(ConversationCreated, other.ConversationCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreated?>.Default.Equals(ConversationItemCreated, other.ConversationItemCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventConversationItemDeleted?>.Default.Equals(ConversationItemDeleted, other.ConversationItemDeleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted?>.Default.Equals(ConversationItemInputAudioTranscriptionCompleted, other.ConversationItemInputAudioTranscriptionCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionDelta?>.Default.Equals(ConversationItemInputAudioTranscriptionDelta, other.ConversationItemInputAudioTranscriptionDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailed?>.Default.Equals(ConversationItemInputAudioTranscriptionFailed, other.ConversationItemInputAudioTranscriptionFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventConversationItemRetrieved?>.Default.Equals(ConversationItemRetrieved, other.ConversationItemRetrieved) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventConversationItemTruncated?>.Default.Equals(ConversationItemTruncated, other.ConversationItemTruncated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventError?>.Default.Equals(Error, other.Error) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCleared?>.Default.Equals(InputAudioBufferCleared, other.InputAudioBufferCleared) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCommitted?>.Default.Equals(InputAudioBufferCommitted, other.InputAudioBufferCommitted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceived?>.Default.Equals(InputAudioBufferDtmfEventReceived, other.InputAudioBufferDtmfEventReceived) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStarted?>.Default.Equals(InputAudioBufferSpeechStarted, other.InputAudioBufferSpeechStarted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStopped?>.Default.Equals(InputAudioBufferSpeechStopped, other.InputAudioBufferSpeechStopped) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdated?>.Default.Equals(RateLimitsUpdated, other.RateLimitsUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDelta?>.Default.Equals(ResponseOutputAudioDelta, other.ResponseOutputAudioDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDone?>.Default.Equals(ResponseOutputAudioDone, other.ResponseOutputAudioDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDelta?>.Default.Equals(ResponseOutputAudioTranscriptDelta, other.ResponseOutputAudioTranscriptDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDone?>.Default.Equals(ResponseOutputAudioTranscriptDone, other.ResponseOutputAudioTranscriptDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAdded?>.Default.Equals(ResponseContentPartAdded, other.ResponseContentPartAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDone?>.Default.Equals(ResponseContentPartDone, other.ResponseContentPartDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventResponseCreated?>.Default.Equals(ResponseCreated, other.ResponseCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventResponseDone?>.Default.Equals(ResponseDone, other.ResponseDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDelta?>.Default.Equals(ResponseFunctionCallArgumentsDelta, other.ResponseFunctionCallArgumentsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDone?>.Default.Equals(ResponseFunctionCallArgumentsDone, other.ResponseFunctionCallArgumentsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAdded?>.Default.Equals(ResponseOutputItemAdded, other.ResponseOutputItemAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemDone?>.Default.Equals(ResponseOutputItemDone, other.ResponseOutputItemDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventResponseTextDelta?>.Default.Equals(ResponseOutputTextDelta, other.ResponseOutputTextDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventResponseTextDone?>.Default.Equals(ResponseOutputTextDone, other.ResponseOutputTextDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventSessionCreated?>.Default.Equals(SessionCreated, other.SessionCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventSessionUpdated?>.Default.Equals(SessionUpdated, other.SessionUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStarted?>.Default.Equals(OutputAudioBufferStarted, other.OutputAudioBufferStarted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStopped?>.Default.Equals(OutputAudioBufferStopped, other.OutputAudioBufferStopped) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferCleared?>.Default.Equals(OutputAudioBufferCleared, other.OutputAudioBufferCleared) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventConversationItemAdded?>.Default.Equals(ConversationItemAdded, other.ConversationItemAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventConversationItemDone?>.Default.Equals(ConversationItemDone, other.ConversationItemDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggered?>.Default.Equals(InputAudioBufferTimeoutTriggered, other.InputAudioBufferTimeoutTriggered) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegment?>.Default.Equals(ConversationItemInputAudioTranscriptionSegment, other.ConversationItemInputAudioTranscriptionSegment) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgress?>.Default.Equals(McpListToolsInProgress, other.McpListToolsInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsCompleted?>.Default.Equals(McpListToolsCompleted, other.McpListToolsCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsFailed?>.Default.Equals(McpListToolsFailed, other.McpListToolsFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDelta?>.Default.Equals(ResponseMcpCallArgumentsDelta, other.ResponseMcpCallArgumentsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDone?>.Default.Equals(ResponseMcpCallArgumentsDone, other.ResponseMcpCallArgumentsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallInProgress?>.Default.Equals(ResponseMcpCallInProgress, other.ResponseMcpCallInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallCompleted?>.Default.Equals(ResponseMcpCallCompleted, other.ResponseMcpCallCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallFailed?>.Default.Equals(ResponseMcpCallFailed, other.ResponseMcpCallFailed) 
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
