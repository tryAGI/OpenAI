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
        /// 
        /// </summary>
        public bool TryPickConversationCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreated? value)
        {
            value = ConversationCreated;
            return IsConversationCreated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreated PickConversationCreated() => IsConversationCreated
            ? ConversationCreated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConversationCreated' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickConversationItemAdded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemAdded? value)
        {
            value = ConversationItemAdded;
            return IsConversationItemAdded;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemAdded PickConversationItemAdded() => IsConversationItemAdded
            ? ConversationItemAdded!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConversationItemAdded' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickConversationItemCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemCreated? value)
        {
            value = ConversationItemCreated;
            return IsConversationItemCreated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemCreated PickConversationItemCreated() => IsConversationItemCreated
            ? ConversationItemCreated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConversationItemCreated' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickConversationItemDeleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeleted? value)
        {
            value = ConversationItemDeleted;
            return IsConversationItemDeleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeleted PickConversationItemDeleted() => IsConversationItemDeleted
            ? ConversationItemDeleted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConversationItemDeleted' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickConversationItemDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDone? value)
        {
            value = ConversationItemDone;
            return IsConversationItemDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDone PickConversationItemDone() => IsConversationItemDone
            ? ConversationItemDone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConversationItemDone' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickConversationItemInputAudioTranscriptionCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted? value)
        {
            value = ConversationItemInputAudioTranscriptionCompleted;
            return IsConversationItemInputAudioTranscriptionCompleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted PickConversationItemInputAudioTranscriptionCompleted() => IsConversationItemInputAudioTranscriptionCompleted
            ? ConversationItemInputAudioTranscriptionCompleted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConversationItemInputAudioTranscriptionCompleted' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickConversationItemInputAudioTranscriptionDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDelta? value)
        {
            value = ConversationItemInputAudioTranscriptionDelta;
            return IsConversationItemInputAudioTranscriptionDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDelta PickConversationItemInputAudioTranscriptionDelta() => IsConversationItemInputAudioTranscriptionDelta
            ? ConversationItemInputAudioTranscriptionDelta!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConversationItemInputAudioTranscriptionDelta' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickConversationItemInputAudioTranscriptionFailed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailed? value)
        {
            value = ConversationItemInputAudioTranscriptionFailed;
            return IsConversationItemInputAudioTranscriptionFailed;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailed PickConversationItemInputAudioTranscriptionFailed() => IsConversationItemInputAudioTranscriptionFailed
            ? ConversationItemInputAudioTranscriptionFailed!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConversationItemInputAudioTranscriptionFailed' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickConversationItemInputAudioTranscriptionSegment(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionSegment? value)
        {
            value = ConversationItemInputAudioTranscriptionSegment;
            return IsConversationItemInputAudioTranscriptionSegment;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionSegment PickConversationItemInputAudioTranscriptionSegment() => IsConversationItemInputAudioTranscriptionSegment
            ? ConversationItemInputAudioTranscriptionSegment!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConversationItemInputAudioTranscriptionSegment' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickConversationItemRetrieved(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrieved? value)
        {
            value = ConversationItemRetrieved;
            return IsConversationItemRetrieved;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrieved PickConversationItemRetrieved() => IsConversationItemRetrieved
            ? ConversationItemRetrieved!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConversationItemRetrieved' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickConversationItemTruncated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemTruncated? value)
        {
            value = ConversationItemTruncated;
            return IsConversationItemTruncated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemTruncated PickConversationItemTruncated() => IsConversationItemTruncated
            ? ConversationItemTruncated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConversationItemTruncated' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventError? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventError PickError() => IsError
            ? Error!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Error' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickInputAudioBufferCleared(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCleared? value)
        {
            value = InputAudioBufferCleared;
            return IsInputAudioBufferCleared;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCleared PickInputAudioBufferCleared() => IsInputAudioBufferCleared
            ? InputAudioBufferCleared!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputAudioBufferCleared' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickInputAudioBufferCommitted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommitted? value)
        {
            value = InputAudioBufferCommitted;
            return IsInputAudioBufferCommitted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommitted PickInputAudioBufferCommitted() => IsInputAudioBufferCommitted
            ? InputAudioBufferCommitted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputAudioBufferCommitted' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickInputAudioBufferDtmfEventReceived(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferDtmfEventReceived? value)
        {
            value = InputAudioBufferDtmfEventReceived;
            return IsInputAudioBufferDtmfEventReceived;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferDtmfEventReceived PickInputAudioBufferDtmfEventReceived() => IsInputAudioBufferDtmfEventReceived
            ? InputAudioBufferDtmfEventReceived!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputAudioBufferDtmfEventReceived' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickInputAudioBufferSpeechStarted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStarted? value)
        {
            value = InputAudioBufferSpeechStarted;
            return IsInputAudioBufferSpeechStarted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStarted PickInputAudioBufferSpeechStarted() => IsInputAudioBufferSpeechStarted
            ? InputAudioBufferSpeechStarted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputAudioBufferSpeechStarted' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickInputAudioBufferSpeechStopped(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStopped? value)
        {
            value = InputAudioBufferSpeechStopped;
            return IsInputAudioBufferSpeechStopped;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStopped PickInputAudioBufferSpeechStopped() => IsInputAudioBufferSpeechStopped
            ? InputAudioBufferSpeechStopped!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputAudioBufferSpeechStopped' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickInputAudioBufferTimeoutTriggered(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferTimeoutTriggered? value)
        {
            value = InputAudioBufferTimeoutTriggered;
            return IsInputAudioBufferTimeoutTriggered;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferTimeoutTriggered PickInputAudioBufferTimeoutTriggered() => IsInputAudioBufferTimeoutTriggered
            ? InputAudioBufferTimeoutTriggered!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputAudioBufferTimeoutTriggered' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickMcpListToolsCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompleted? value)
        {
            value = McpListToolsCompleted;
            return IsMcpListToolsCompleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompleted PickMcpListToolsCompleted() => IsMcpListToolsCompleted
            ? McpListToolsCompleted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpListToolsCompleted' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickMcpListToolsFailed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailed? value)
        {
            value = McpListToolsFailed;
            return IsMcpListToolsFailed;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailed PickMcpListToolsFailed() => IsMcpListToolsFailed
            ? McpListToolsFailed!
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpListToolsFailed' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickMcpListToolsInProgress(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgress? value)
        {
            value = McpListToolsInProgress;
            return IsMcpListToolsInProgress;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgress PickMcpListToolsInProgress() => IsMcpListToolsInProgress
            ? McpListToolsInProgress!
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpListToolsInProgress' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickOutputAudioBufferCleared(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferCleared? value)
        {
            value = OutputAudioBufferCleared;
            return IsOutputAudioBufferCleared;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferCleared PickOutputAudioBufferCleared() => IsOutputAudioBufferCleared
            ? OutputAudioBufferCleared!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputAudioBufferCleared' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickOutputAudioBufferStarted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStarted? value)
        {
            value = OutputAudioBufferStarted;
            return IsOutputAudioBufferStarted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStarted PickOutputAudioBufferStarted() => IsOutputAudioBufferStarted
            ? OutputAudioBufferStarted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputAudioBufferStarted' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickOutputAudioBufferStopped(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStopped? value)
        {
            value = OutputAudioBufferStopped;
            return IsOutputAudioBufferStopped;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStopped PickOutputAudioBufferStopped() => IsOutputAudioBufferStopped
            ? OutputAudioBufferStopped!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputAudioBufferStopped' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickRateLimitsUpdated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdated? value)
        {
            value = RateLimitsUpdated;
            return IsRateLimitsUpdated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdated PickRateLimitsUpdated() => IsRateLimitsUpdated
            ? RateLimitsUpdated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RateLimitsUpdated' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickResponseContentPartAdded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAdded? value)
        {
            value = ResponseContentPartAdded;
            return IsResponseContentPartAdded;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAdded PickResponseContentPartAdded() => IsResponseContentPartAdded
            ? ResponseContentPartAdded!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseContentPartAdded' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickResponseContentPartDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDone? value)
        {
            value = ResponseContentPartDone;
            return IsResponseContentPartDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDone PickResponseContentPartDone() => IsResponseContentPartDone
            ? ResponseContentPartDone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseContentPartDone' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickResponseCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseCreated? value)
        {
            value = ResponseCreated;
            return IsResponseCreated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseCreated PickResponseCreated() => IsResponseCreated
            ? ResponseCreated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCreated' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickResponseDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseDone? value)
        {
            value = ResponseDone;
            return IsResponseDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseDone PickResponseDone() => IsResponseDone
            ? ResponseDone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseDone' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickResponseFunctionCallArgumentsDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDelta? value)
        {
            value = ResponseFunctionCallArgumentsDelta;
            return IsResponseFunctionCallArgumentsDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDelta PickResponseFunctionCallArgumentsDelta() => IsResponseFunctionCallArgumentsDelta
            ? ResponseFunctionCallArgumentsDelta!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseFunctionCallArgumentsDelta' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickResponseFunctionCallArgumentsDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDone? value)
        {
            value = ResponseFunctionCallArgumentsDone;
            return IsResponseFunctionCallArgumentsDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDone PickResponseFunctionCallArgumentsDone() => IsResponseFunctionCallArgumentsDone
            ? ResponseFunctionCallArgumentsDone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseFunctionCallArgumentsDone' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickResponseMcpCallCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompleted? value)
        {
            value = ResponseMcpCallCompleted;
            return IsResponseMcpCallCompleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompleted PickResponseMcpCallCompleted() => IsResponseMcpCallCompleted
            ? ResponseMcpCallCompleted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseMcpCallCompleted' but the value was {ToString()}.");

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
        public bool TryPickResponseMcpCallFailed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailed? value)
        {
            value = ResponseMcpCallFailed;
            return IsResponseMcpCallFailed;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailed PickResponseMcpCallFailed() => IsResponseMcpCallFailed
            ? ResponseMcpCallFailed!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseMcpCallFailed' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickResponseMcpCallInProgress(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgress? value)
        {
            value = ResponseMcpCallInProgress;
            return IsResponseMcpCallInProgress;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgress PickResponseMcpCallInProgress() => IsResponseMcpCallInProgress
            ? ResponseMcpCallInProgress!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseMcpCallInProgress' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickResponseMcpCallArgumentsDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDelta? value)
        {
            value = ResponseMcpCallArgumentsDelta;
            return IsResponseMcpCallArgumentsDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDelta PickResponseMcpCallArgumentsDelta() => IsResponseMcpCallArgumentsDelta
            ? ResponseMcpCallArgumentsDelta!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseMcpCallArgumentsDelta' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickResponseMcpCallArgumentsDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDone? value)
        {
            value = ResponseMcpCallArgumentsDone;
            return IsResponseMcpCallArgumentsDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDone PickResponseMcpCallArgumentsDone() => IsResponseMcpCallArgumentsDone
            ? ResponseMcpCallArgumentsDone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseMcpCallArgumentsDone' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickResponseOutputAudioDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDelta? value)
        {
            value = ResponseOutputAudioDelta;
            return IsResponseOutputAudioDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDelta PickResponseOutputAudioDelta() => IsResponseOutputAudioDelta
            ? ResponseOutputAudioDelta!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputAudioDelta' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickResponseOutputAudioDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDone? value)
        {
            value = ResponseOutputAudioDone;
            return IsResponseOutputAudioDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDone PickResponseOutputAudioDone() => IsResponseOutputAudioDone
            ? ResponseOutputAudioDone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputAudioDone' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickResponseOutputAudioTranscriptDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDelta? value)
        {
            value = ResponseOutputAudioTranscriptDelta;
            return IsResponseOutputAudioTranscriptDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDelta PickResponseOutputAudioTranscriptDelta() => IsResponseOutputAudioTranscriptDelta
            ? ResponseOutputAudioTranscriptDelta!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputAudioTranscriptDelta' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickResponseOutputAudioTranscriptDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDone? value)
        {
            value = ResponseOutputAudioTranscriptDone;
            return IsResponseOutputAudioTranscriptDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDone PickResponseOutputAudioTranscriptDone() => IsResponseOutputAudioTranscriptDone
            ? ResponseOutputAudioTranscriptDone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputAudioTranscriptDone' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickResponseOutputItemAdded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAdded? value)
        {
            value = ResponseOutputItemAdded;
            return IsResponseOutputItemAdded;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAdded PickResponseOutputItemAdded() => IsResponseOutputItemAdded
            ? ResponseOutputItemAdded!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputItemAdded' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickResponseOutputItemDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDone? value)
        {
            value = ResponseOutputItemDone;
            return IsResponseOutputItemDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDone PickResponseOutputItemDone() => IsResponseOutputItemDone
            ? ResponseOutputItemDone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputItemDone' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickResponseOutputTextDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDelta? value)
        {
            value = ResponseOutputTextDelta;
            return IsResponseOutputTextDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDelta PickResponseOutputTextDelta() => IsResponseOutputTextDelta
            ? ResponseOutputTextDelta!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputTextDelta' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickResponseOutputTextDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDone? value)
        {
            value = ResponseOutputTextDone;
            return IsResponseOutputTextDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDone PickResponseOutputTextDone() => IsResponseOutputTextDone
            ? ResponseOutputTextDone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputTextDone' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickSessionCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreated? value)
        {
            value = SessionCreated;
            return IsSessionCreated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreated PickSessionCreated() => IsSessionCreated
            ? SessionCreated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionCreated' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickSessionUpdated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdated? value)
        {
            value = SessionUpdated;
            return IsSessionUpdated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdated PickSessionUpdated() => IsSessionUpdated
            ? SessionUpdated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionUpdated' but the value was {ToString()}.");

        /// <summary>
        /// Returned when a transcription session is updated with a `transcription_session.update` event, unless <br/>
        /// there is an error.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventTranscriptionSessionUpdated? TranscriptionSessionUpdated { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventTranscriptionSessionUpdated? TranscriptionSessionUpdated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TranscriptionSessionUpdated))]
#endif
        public bool IsTranscriptionSessionUpdated => TranscriptionSessionUpdated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTranscriptionSessionUpdated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeServerEventTranscriptionSessionUpdated? value)
        {
            value = TranscriptionSessionUpdated;
            return IsTranscriptionSessionUpdated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventTranscriptionSessionUpdated PickTranscriptionSessionUpdated() => IsTranscriptionSessionUpdated
            ? TranscriptionSessionUpdated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TranscriptionSessionUpdated' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreated value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreated?(ServerEvent @this) => @this.ConversationCreated;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreated? value)
        {
            ConversationCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromConversationCreated(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreated? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemAdded value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemAdded?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemAdded?(ServerEvent @this) => @this.ConversationItemAdded;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemAdded? value)
        {
            ConversationItemAdded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromConversationItemAdded(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemAdded? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemCreated value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemCreated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemCreated?(ServerEvent @this) => @this.ConversationItemCreated;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemCreated? value)
        {
            ConversationItemCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromConversationItemCreated(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemCreated? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeleted value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeleted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeleted?(ServerEvent @this) => @this.ConversationItemDeleted;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeleted? value)
        {
            ConversationItemDeleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromConversationItemDeleted(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeleted? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDone value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDone?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDone?(ServerEvent @this) => @this.ConversationItemDone;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDone? value)
        {
            ConversationItemDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromConversationItemDone(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDone? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted?(ServerEvent @this) => @this.ConversationItemInputAudioTranscriptionCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted? value)
        {
            ConversationItemInputAudioTranscriptionCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromConversationItemInputAudioTranscriptionCompleted(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDelta value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDelta?(ServerEvent @this) => @this.ConversationItemInputAudioTranscriptionDelta;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDelta? value)
        {
            ConversationItemInputAudioTranscriptionDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromConversationItemInputAudioTranscriptionDelta(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDelta? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailed value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailed?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailed?(ServerEvent @this) => @this.ConversationItemInputAudioTranscriptionFailed;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailed? value)
        {
            ConversationItemInputAudioTranscriptionFailed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromConversationItemInputAudioTranscriptionFailed(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailed? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionSegment value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionSegment?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionSegment?(ServerEvent @this) => @this.ConversationItemInputAudioTranscriptionSegment;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionSegment? value)
        {
            ConversationItemInputAudioTranscriptionSegment = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromConversationItemInputAudioTranscriptionSegment(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionSegment? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrieved value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrieved?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrieved?(ServerEvent @this) => @this.ConversationItemRetrieved;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrieved? value)
        {
            ConversationItemRetrieved = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromConversationItemRetrieved(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrieved? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemTruncated value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemTruncated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemTruncated?(ServerEvent @this) => @this.ConversationItemTruncated;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemTruncated? value)
        {
            ConversationItemTruncated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromConversationItemTruncated(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemTruncated? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventError value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventError?(ServerEvent @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventError? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromError(global::tryAGI.OpenAI.Realtime.RealtimeServerEventError? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCleared value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCleared?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCleared?(ServerEvent @this) => @this.InputAudioBufferCleared;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCleared? value)
        {
            InputAudioBufferCleared = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromInputAudioBufferCleared(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCleared? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommitted value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommitted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommitted?(ServerEvent @this) => @this.InputAudioBufferCommitted;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommitted? value)
        {
            InputAudioBufferCommitted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromInputAudioBufferCommitted(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommitted? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferDtmfEventReceived value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferDtmfEventReceived?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferDtmfEventReceived?(ServerEvent @this) => @this.InputAudioBufferDtmfEventReceived;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferDtmfEventReceived? value)
        {
            InputAudioBufferDtmfEventReceived = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromInputAudioBufferDtmfEventReceived(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferDtmfEventReceived? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStarted value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStarted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStarted?(ServerEvent @this) => @this.InputAudioBufferSpeechStarted;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStarted? value)
        {
            InputAudioBufferSpeechStarted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromInputAudioBufferSpeechStarted(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStarted? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStopped value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStopped?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStopped?(ServerEvent @this) => @this.InputAudioBufferSpeechStopped;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStopped? value)
        {
            InputAudioBufferSpeechStopped = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromInputAudioBufferSpeechStopped(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStopped? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferTimeoutTriggered value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferTimeoutTriggered?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferTimeoutTriggered?(ServerEvent @this) => @this.InputAudioBufferTimeoutTriggered;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferTimeoutTriggered? value)
        {
            InputAudioBufferTimeoutTriggered = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromInputAudioBufferTimeoutTriggered(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferTimeoutTriggered? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompleted value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompleted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompleted?(ServerEvent @this) => @this.McpListToolsCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompleted? value)
        {
            McpListToolsCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromMcpListToolsCompleted(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompleted? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailed value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailed?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailed?(ServerEvent @this) => @this.McpListToolsFailed;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailed? value)
        {
            McpListToolsFailed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromMcpListToolsFailed(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailed? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgress value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgress?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgress?(ServerEvent @this) => @this.McpListToolsInProgress;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgress? value)
        {
            McpListToolsInProgress = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromMcpListToolsInProgress(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgress? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferCleared value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferCleared?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferCleared?(ServerEvent @this) => @this.OutputAudioBufferCleared;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferCleared? value)
        {
            OutputAudioBufferCleared = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromOutputAudioBufferCleared(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferCleared? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStarted value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStarted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStarted?(ServerEvent @this) => @this.OutputAudioBufferStarted;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStarted? value)
        {
            OutputAudioBufferStarted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromOutputAudioBufferStarted(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStarted? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStopped value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStopped?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStopped?(ServerEvent @this) => @this.OutputAudioBufferStopped;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStopped? value)
        {
            OutputAudioBufferStopped = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromOutputAudioBufferStopped(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStopped? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdated value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdated?(ServerEvent @this) => @this.RateLimitsUpdated;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdated? value)
        {
            RateLimitsUpdated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromRateLimitsUpdated(global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdated? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAdded value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAdded?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAdded?(ServerEvent @this) => @this.ResponseContentPartAdded;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAdded? value)
        {
            ResponseContentPartAdded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromResponseContentPartAdded(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAdded? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDone value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDone?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDone?(ServerEvent @this) => @this.ResponseContentPartDone;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDone? value)
        {
            ResponseContentPartDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromResponseContentPartDone(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDone? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseCreated value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseCreated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseCreated?(ServerEvent @this) => @this.ResponseCreated;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseCreated? value)
        {
            ResponseCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromResponseCreated(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseCreated? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseDone value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseDone?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseDone?(ServerEvent @this) => @this.ResponseDone;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseDone? value)
        {
            ResponseDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromResponseDone(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseDone? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDelta value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDelta?(ServerEvent @this) => @this.ResponseFunctionCallArgumentsDelta;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDelta? value)
        {
            ResponseFunctionCallArgumentsDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromResponseFunctionCallArgumentsDelta(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDelta? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDone value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDone?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDone?(ServerEvent @this) => @this.ResponseFunctionCallArgumentsDone;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDone? value)
        {
            ResponseFunctionCallArgumentsDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromResponseFunctionCallArgumentsDone(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDone? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompleted value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompleted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompleted?(ServerEvent @this) => @this.ResponseMcpCallCompleted;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompleted? value)
        {
            ResponseMcpCallCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromResponseMcpCallCompleted(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompleted? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailed value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailed?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailed?(ServerEvent @this) => @this.ResponseMcpCallFailed;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailed? value)
        {
            ResponseMcpCallFailed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromResponseMcpCallFailed(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailed? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgress value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgress?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgress?(ServerEvent @this) => @this.ResponseMcpCallInProgress;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgress? value)
        {
            ResponseMcpCallInProgress = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromResponseMcpCallInProgress(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgress? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDelta value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDelta?(ServerEvent @this) => @this.ResponseMcpCallArgumentsDelta;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDelta? value)
        {
            ResponseMcpCallArgumentsDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromResponseMcpCallArgumentsDelta(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDelta? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDone value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDone?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDone?(ServerEvent @this) => @this.ResponseMcpCallArgumentsDone;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDone? value)
        {
            ResponseMcpCallArgumentsDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromResponseMcpCallArgumentsDone(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDone? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDelta value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDelta?(ServerEvent @this) => @this.ResponseOutputAudioDelta;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDelta? value)
        {
            ResponseOutputAudioDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromResponseOutputAudioDelta(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDelta? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDone value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDone?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDone?(ServerEvent @this) => @this.ResponseOutputAudioDone;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDone? value)
        {
            ResponseOutputAudioDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromResponseOutputAudioDone(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDone? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDelta value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDelta?(ServerEvent @this) => @this.ResponseOutputAudioTranscriptDelta;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDelta? value)
        {
            ResponseOutputAudioTranscriptDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromResponseOutputAudioTranscriptDelta(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDelta? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDone value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDone?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDone?(ServerEvent @this) => @this.ResponseOutputAudioTranscriptDone;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDone? value)
        {
            ResponseOutputAudioTranscriptDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromResponseOutputAudioTranscriptDone(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDone? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAdded value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAdded?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAdded?(ServerEvent @this) => @this.ResponseOutputItemAdded;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAdded? value)
        {
            ResponseOutputItemAdded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromResponseOutputItemAdded(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAdded? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDone value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDone?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDone?(ServerEvent @this) => @this.ResponseOutputItemDone;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDone? value)
        {
            ResponseOutputItemDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromResponseOutputItemDone(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDone? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDelta value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDelta?(ServerEvent @this) => @this.ResponseOutputTextDelta;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDelta? value)
        {
            ResponseOutputTextDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromResponseOutputTextDelta(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDelta? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDone value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDone?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDone?(ServerEvent @this) => @this.ResponseOutputTextDone;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDone? value)
        {
            ResponseOutputTextDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromResponseOutputTextDone(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDone? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreated value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreated?(ServerEvent @this) => @this.SessionCreated;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreated? value)
        {
            SessionCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromSessionCreated(global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreated? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdated value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdated?(ServerEvent @this) => @this.SessionUpdated;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdated? value)
        {
            SessionUpdated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromSessionUpdated(global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdated? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventTranscriptionSessionUpdated value) => new ServerEvent((global::tryAGI.OpenAI.Realtime.RealtimeServerEventTranscriptionSessionUpdated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeServerEventTranscriptionSessionUpdated?(ServerEvent @this) => @this.TranscriptionSessionUpdated;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::tryAGI.OpenAI.Realtime.RealtimeServerEventTranscriptionSessionUpdated? value)
        {
            TranscriptionSessionUpdated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromTranscriptionSessionUpdated(global::tryAGI.OpenAI.Realtime.RealtimeServerEventTranscriptionSessionUpdated? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(
            global::tryAGI.OpenAI.Realtime.ServerEventDiscriminatorType? type,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreated? conversationCreated,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemAdded? conversationItemAdded,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemCreated? conversationItemCreated,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeleted? conversationItemDeleted,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDone? conversationItemDone,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted? conversationItemInputAudioTranscriptionCompleted,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDelta? conversationItemInputAudioTranscriptionDelta,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailed? conversationItemInputAudioTranscriptionFailed,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionSegment? conversationItemInputAudioTranscriptionSegment,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrieved? conversationItemRetrieved,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemTruncated? conversationItemTruncated,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventError? error,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCleared? inputAudioBufferCleared,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommitted? inputAudioBufferCommitted,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferDtmfEventReceived? inputAudioBufferDtmfEventReceived,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStarted? inputAudioBufferSpeechStarted,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStopped? inputAudioBufferSpeechStopped,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferTimeoutTriggered? inputAudioBufferTimeoutTriggered,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompleted? mcpListToolsCompleted,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailed? mcpListToolsFailed,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgress? mcpListToolsInProgress,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferCleared? outputAudioBufferCleared,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStarted? outputAudioBufferStarted,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStopped? outputAudioBufferStopped,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdated? rateLimitsUpdated,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAdded? responseContentPartAdded,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDone? responseContentPartDone,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseCreated? responseCreated,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseDone? responseDone,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDelta? responseFunctionCallArgumentsDelta,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDone? responseFunctionCallArgumentsDone,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompleted? responseMcpCallCompleted,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailed? responseMcpCallFailed,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgress? responseMcpCallInProgress,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDelta? responseMcpCallArgumentsDelta,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDone? responseMcpCallArgumentsDone,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDelta? responseOutputAudioDelta,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDone? responseOutputAudioDone,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDelta? responseOutputAudioTranscriptDelta,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDone? responseOutputAudioTranscriptDone,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAdded? responseOutputItemAdded,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDone? responseOutputItemDone,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDelta? responseOutputTextDelta,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDone? responseOutputTextDone,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreated? sessionCreated,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdated? sessionUpdated,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventTranscriptionSessionUpdated? transcriptionSessionUpdated
            )
        {
            Type = type;

            ConversationCreated = conversationCreated;
            ConversationItemAdded = conversationItemAdded;
            ConversationItemCreated = conversationItemCreated;
            ConversationItemDeleted = conversationItemDeleted;
            ConversationItemDone = conversationItemDone;
            ConversationItemInputAudioTranscriptionCompleted = conversationItemInputAudioTranscriptionCompleted;
            ConversationItemInputAudioTranscriptionDelta = conversationItemInputAudioTranscriptionDelta;
            ConversationItemInputAudioTranscriptionFailed = conversationItemInputAudioTranscriptionFailed;
            ConversationItemInputAudioTranscriptionSegment = conversationItemInputAudioTranscriptionSegment;
            ConversationItemRetrieved = conversationItemRetrieved;
            ConversationItemTruncated = conversationItemTruncated;
            Error = error;
            InputAudioBufferCleared = inputAudioBufferCleared;
            InputAudioBufferCommitted = inputAudioBufferCommitted;
            InputAudioBufferDtmfEventReceived = inputAudioBufferDtmfEventReceived;
            InputAudioBufferSpeechStarted = inputAudioBufferSpeechStarted;
            InputAudioBufferSpeechStopped = inputAudioBufferSpeechStopped;
            InputAudioBufferTimeoutTriggered = inputAudioBufferTimeoutTriggered;
            McpListToolsCompleted = mcpListToolsCompleted;
            McpListToolsFailed = mcpListToolsFailed;
            McpListToolsInProgress = mcpListToolsInProgress;
            OutputAudioBufferCleared = outputAudioBufferCleared;
            OutputAudioBufferStarted = outputAudioBufferStarted;
            OutputAudioBufferStopped = outputAudioBufferStopped;
            RateLimitsUpdated = rateLimitsUpdated;
            ResponseContentPartAdded = responseContentPartAdded;
            ResponseContentPartDone = responseContentPartDone;
            ResponseCreated = responseCreated;
            ResponseDone = responseDone;
            ResponseFunctionCallArgumentsDelta = responseFunctionCallArgumentsDelta;
            ResponseFunctionCallArgumentsDone = responseFunctionCallArgumentsDone;
            ResponseMcpCallCompleted = responseMcpCallCompleted;
            ResponseMcpCallFailed = responseMcpCallFailed;
            ResponseMcpCallInProgress = responseMcpCallInProgress;
            ResponseMcpCallArgumentsDelta = responseMcpCallArgumentsDelta;
            ResponseMcpCallArgumentsDone = responseMcpCallArgumentsDone;
            ResponseOutputAudioDelta = responseOutputAudioDelta;
            ResponseOutputAudioDone = responseOutputAudioDone;
            ResponseOutputAudioTranscriptDelta = responseOutputAudioTranscriptDelta;
            ResponseOutputAudioTranscriptDone = responseOutputAudioTranscriptDone;
            ResponseOutputItemAdded = responseOutputItemAdded;
            ResponseOutputItemDone = responseOutputItemDone;
            ResponseOutputTextDelta = responseOutputTextDelta;
            ResponseOutputTextDone = responseOutputTextDone;
            SessionCreated = sessionCreated;
            SessionUpdated = sessionUpdated;
            TranscriptionSessionUpdated = transcriptionSessionUpdated;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TranscriptionSessionUpdated as object ??
            SessionUpdated as object ??
            SessionCreated as object ??
            ResponseOutputTextDone as object ??
            ResponseOutputTextDelta as object ??
            ResponseOutputItemDone as object ??
            ResponseOutputItemAdded as object ??
            ResponseOutputAudioTranscriptDone as object ??
            ResponseOutputAudioTranscriptDelta as object ??
            ResponseOutputAudioDone as object ??
            ResponseOutputAudioDelta as object ??
            ResponseMcpCallArgumentsDone as object ??
            ResponseMcpCallArgumentsDelta as object ??
            ResponseMcpCallInProgress as object ??
            ResponseMcpCallFailed as object ??
            ResponseMcpCallCompleted as object ??
            ResponseFunctionCallArgumentsDone as object ??
            ResponseFunctionCallArgumentsDelta as object ??
            ResponseDone as object ??
            ResponseCreated as object ??
            ResponseContentPartDone as object ??
            ResponseContentPartAdded as object ??
            RateLimitsUpdated as object ??
            OutputAudioBufferStopped as object ??
            OutputAudioBufferStarted as object ??
            OutputAudioBufferCleared as object ??
            McpListToolsInProgress as object ??
            McpListToolsFailed as object ??
            McpListToolsCompleted as object ??
            InputAudioBufferTimeoutTriggered as object ??
            InputAudioBufferSpeechStopped as object ??
            InputAudioBufferSpeechStarted as object ??
            InputAudioBufferDtmfEventReceived as object ??
            InputAudioBufferCommitted as object ??
            InputAudioBufferCleared as object ??
            Error as object ??
            ConversationItemTruncated as object ??
            ConversationItemRetrieved as object ??
            ConversationItemInputAudioTranscriptionSegment as object ??
            ConversationItemInputAudioTranscriptionFailed as object ??
            ConversationItemInputAudioTranscriptionDelta as object ??
            ConversationItemInputAudioTranscriptionCompleted as object ??
            ConversationItemDone as object ??
            ConversationItemDeleted as object ??
            ConversationItemCreated as object ??
            ConversationItemAdded as object ??
            ConversationCreated as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ConversationCreated?.ToString() ??
            ConversationItemAdded?.ToString() ??
            ConversationItemCreated?.ToString() ??
            ConversationItemDeleted?.ToString() ??
            ConversationItemDone?.ToString() ??
            ConversationItemInputAudioTranscriptionCompleted?.ToString() ??
            ConversationItemInputAudioTranscriptionDelta?.ToString() ??
            ConversationItemInputAudioTranscriptionFailed?.ToString() ??
            ConversationItemInputAudioTranscriptionSegment?.ToString() ??
            ConversationItemRetrieved?.ToString() ??
            ConversationItemTruncated?.ToString() ??
            Error?.ToString() ??
            InputAudioBufferCleared?.ToString() ??
            InputAudioBufferCommitted?.ToString() ??
            InputAudioBufferDtmfEventReceived?.ToString() ??
            InputAudioBufferSpeechStarted?.ToString() ??
            InputAudioBufferSpeechStopped?.ToString() ??
            InputAudioBufferTimeoutTriggered?.ToString() ??
            McpListToolsCompleted?.ToString() ??
            McpListToolsFailed?.ToString() ??
            McpListToolsInProgress?.ToString() ??
            OutputAudioBufferCleared?.ToString() ??
            OutputAudioBufferStarted?.ToString() ??
            OutputAudioBufferStopped?.ToString() ??
            RateLimitsUpdated?.ToString() ??
            ResponseContentPartAdded?.ToString() ??
            ResponseContentPartDone?.ToString() ??
            ResponseCreated?.ToString() ??
            ResponseDone?.ToString() ??
            ResponseFunctionCallArgumentsDelta?.ToString() ??
            ResponseFunctionCallArgumentsDone?.ToString() ??
            ResponseMcpCallCompleted?.ToString() ??
            ResponseMcpCallFailed?.ToString() ??
            ResponseMcpCallInProgress?.ToString() ??
            ResponseMcpCallArgumentsDelta?.ToString() ??
            ResponseMcpCallArgumentsDone?.ToString() ??
            ResponseOutputAudioDelta?.ToString() ??
            ResponseOutputAudioDone?.ToString() ??
            ResponseOutputAudioTranscriptDelta?.ToString() ??
            ResponseOutputAudioTranscriptDone?.ToString() ??
            ResponseOutputItemAdded?.ToString() ??
            ResponseOutputItemDone?.ToString() ??
            ResponseOutputTextDelta?.ToString() ??
            ResponseOutputTextDone?.ToString() ??
            SessionCreated?.ToString() ??
            SessionUpdated?.ToString() ??
            TranscriptionSessionUpdated?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && IsSessionCreated && !IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && IsSessionUpdated && !IsTranscriptionSessionUpdated || !IsConversationCreated && !IsConversationItemAdded && !IsConversationItemCreated && !IsConversationItemDeleted && !IsConversationItemDone && !IsConversationItemInputAudioTranscriptionCompleted && !IsConversationItemInputAudioTranscriptionDelta && !IsConversationItemInputAudioTranscriptionFailed && !IsConversationItemInputAudioTranscriptionSegment && !IsConversationItemRetrieved && !IsConversationItemTruncated && !IsError && !IsInputAudioBufferCleared && !IsInputAudioBufferCommitted && !IsInputAudioBufferDtmfEventReceived && !IsInputAudioBufferSpeechStarted && !IsInputAudioBufferSpeechStopped && !IsInputAudioBufferTimeoutTriggered && !IsMcpListToolsCompleted && !IsMcpListToolsFailed && !IsMcpListToolsInProgress && !IsOutputAudioBufferCleared && !IsOutputAudioBufferStarted && !IsOutputAudioBufferStopped && !IsRateLimitsUpdated && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseCreated && !IsResponseDone && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseMcpCallCompleted && !IsResponseMcpCallFailed && !IsResponseMcpCallInProgress && !IsResponseMcpCallArgumentsDelta && !IsResponseMcpCallArgumentsDone && !IsResponseOutputAudioDelta && !IsResponseOutputAudioDone && !IsResponseOutputAudioTranscriptDelta && !IsResponseOutputAudioTranscriptDone && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsSessionCreated && !IsSessionUpdated && IsTranscriptionSessionUpdated;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreated, TResult>? conversationCreated = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemAdded, TResult>? conversationItemAdded = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemCreated, TResult>? conversationItemCreated = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeleted, TResult>? conversationItemDeleted = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDone, TResult>? conversationItemDone = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted, TResult>? conversationItemInputAudioTranscriptionCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDelta, TResult>? conversationItemInputAudioTranscriptionDelta = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailed, TResult>? conversationItemInputAudioTranscriptionFailed = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionSegment, TResult>? conversationItemInputAudioTranscriptionSegment = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrieved, TResult>? conversationItemRetrieved = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemTruncated, TResult>? conversationItemTruncated = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventError, TResult>? error = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCleared, TResult>? inputAudioBufferCleared = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommitted, TResult>? inputAudioBufferCommitted = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferDtmfEventReceived, TResult>? inputAudioBufferDtmfEventReceived = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStarted, TResult>? inputAudioBufferSpeechStarted = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStopped, TResult>? inputAudioBufferSpeechStopped = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferTimeoutTriggered, TResult>? inputAudioBufferTimeoutTriggered = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompleted, TResult>? mcpListToolsCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailed, TResult>? mcpListToolsFailed = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgress, TResult>? mcpListToolsInProgress = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferCleared, TResult>? outputAudioBufferCleared = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStarted, TResult>? outputAudioBufferStarted = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStopped, TResult>? outputAudioBufferStopped = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdated, TResult>? rateLimitsUpdated = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAdded, TResult>? responseContentPartAdded = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDone, TResult>? responseContentPartDone = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseCreated, TResult>? responseCreated = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseDone, TResult>? responseDone = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDelta, TResult>? responseFunctionCallArgumentsDelta = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDone, TResult>? responseFunctionCallArgumentsDone = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompleted, TResult>? responseMcpCallCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailed, TResult>? responseMcpCallFailed = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgress, TResult>? responseMcpCallInProgress = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDelta, TResult>? responseMcpCallArgumentsDelta = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDone, TResult>? responseMcpCallArgumentsDone = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDelta, TResult>? responseOutputAudioDelta = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDone, TResult>? responseOutputAudioDone = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDelta, TResult>? responseOutputAudioTranscriptDelta = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDone, TResult>? responseOutputAudioTranscriptDone = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAdded, TResult>? responseOutputItemAdded = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDone, TResult>? responseOutputItemDone = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDelta, TResult>? responseOutputTextDelta = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDone, TResult>? responseOutputTextDone = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreated, TResult>? sessionCreated = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdated, TResult>? sessionUpdated = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeServerEventTranscriptionSessionUpdated, TResult>? transcriptionSessionUpdated = null,
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
            else if (IsConversationItemAdded && conversationItemAdded != null)
            {
                return conversationItemAdded(ConversationItemAdded!);
            }
            else if (IsConversationItemCreated && conversationItemCreated != null)
            {
                return conversationItemCreated(ConversationItemCreated!);
            }
            else if (IsConversationItemDeleted && conversationItemDeleted != null)
            {
                return conversationItemDeleted(ConversationItemDeleted!);
            }
            else if (IsConversationItemDone && conversationItemDone != null)
            {
                return conversationItemDone(ConversationItemDone!);
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
            else if (IsConversationItemInputAudioTranscriptionSegment && conversationItemInputAudioTranscriptionSegment != null)
            {
                return conversationItemInputAudioTranscriptionSegment(ConversationItemInputAudioTranscriptionSegment!);
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
            else if (IsInputAudioBufferTimeoutTriggered && inputAudioBufferTimeoutTriggered != null)
            {
                return inputAudioBufferTimeoutTriggered(InputAudioBufferTimeoutTriggered!);
            }
            else if (IsMcpListToolsCompleted && mcpListToolsCompleted != null)
            {
                return mcpListToolsCompleted(McpListToolsCompleted!);
            }
            else if (IsMcpListToolsFailed && mcpListToolsFailed != null)
            {
                return mcpListToolsFailed(McpListToolsFailed!);
            }
            else if (IsMcpListToolsInProgress && mcpListToolsInProgress != null)
            {
                return mcpListToolsInProgress(McpListToolsInProgress!);
            }
            else if (IsOutputAudioBufferCleared && outputAudioBufferCleared != null)
            {
                return outputAudioBufferCleared(OutputAudioBufferCleared!);
            }
            else if (IsOutputAudioBufferStarted && outputAudioBufferStarted != null)
            {
                return outputAudioBufferStarted(OutputAudioBufferStarted!);
            }
            else if (IsOutputAudioBufferStopped && outputAudioBufferStopped != null)
            {
                return outputAudioBufferStopped(OutputAudioBufferStopped!);
            }
            else if (IsRateLimitsUpdated && rateLimitsUpdated != null)
            {
                return rateLimitsUpdated(RateLimitsUpdated!);
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
            else if (IsResponseMcpCallArgumentsDelta && responseMcpCallArgumentsDelta != null)
            {
                return responseMcpCallArgumentsDelta(ResponseMcpCallArgumentsDelta!);
            }
            else if (IsResponseMcpCallArgumentsDone && responseMcpCallArgumentsDone != null)
            {
                return responseMcpCallArgumentsDone(ResponseMcpCallArgumentsDone!);
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
            else if (IsTranscriptionSessionUpdated && transcriptionSessionUpdated != null)
            {
                return transcriptionSessionUpdated(TranscriptionSessionUpdated!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreated>? conversationCreated = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemAdded>? conversationItemAdded = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemCreated>? conversationItemCreated = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeleted>? conversationItemDeleted = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDone>? conversationItemDone = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted>? conversationItemInputAudioTranscriptionCompleted = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDelta>? conversationItemInputAudioTranscriptionDelta = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailed>? conversationItemInputAudioTranscriptionFailed = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionSegment>? conversationItemInputAudioTranscriptionSegment = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrieved>? conversationItemRetrieved = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemTruncated>? conversationItemTruncated = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventError>? error = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCleared>? inputAudioBufferCleared = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommitted>? inputAudioBufferCommitted = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferDtmfEventReceived>? inputAudioBufferDtmfEventReceived = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStarted>? inputAudioBufferSpeechStarted = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStopped>? inputAudioBufferSpeechStopped = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferTimeoutTriggered>? inputAudioBufferTimeoutTriggered = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompleted>? mcpListToolsCompleted = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailed>? mcpListToolsFailed = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgress>? mcpListToolsInProgress = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferCleared>? outputAudioBufferCleared = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStarted>? outputAudioBufferStarted = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStopped>? outputAudioBufferStopped = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdated>? rateLimitsUpdated = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAdded>? responseContentPartAdded = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDone>? responseContentPartDone = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseCreated>? responseCreated = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseDone>? responseDone = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDelta>? responseFunctionCallArgumentsDelta = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDone>? responseFunctionCallArgumentsDone = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompleted>? responseMcpCallCompleted = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailed>? responseMcpCallFailed = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgress>? responseMcpCallInProgress = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDelta>? responseMcpCallArgumentsDelta = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDone>? responseMcpCallArgumentsDone = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDelta>? responseOutputAudioDelta = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDone>? responseOutputAudioDone = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDelta>? responseOutputAudioTranscriptDelta = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDone>? responseOutputAudioTranscriptDone = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAdded>? responseOutputItemAdded = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDone>? responseOutputItemDone = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDelta>? responseOutputTextDelta = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDone>? responseOutputTextDone = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreated>? sessionCreated = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdated>? sessionUpdated = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventTranscriptionSessionUpdated>? transcriptionSessionUpdated = null,
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
            else if (IsConversationItemAdded)
            {
                conversationItemAdded?.Invoke(ConversationItemAdded!);
            }
            else if (IsConversationItemCreated)
            {
                conversationItemCreated?.Invoke(ConversationItemCreated!);
            }
            else if (IsConversationItemDeleted)
            {
                conversationItemDeleted?.Invoke(ConversationItemDeleted!);
            }
            else if (IsConversationItemDone)
            {
                conversationItemDone?.Invoke(ConversationItemDone!);
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
            else if (IsConversationItemInputAudioTranscriptionSegment)
            {
                conversationItemInputAudioTranscriptionSegment?.Invoke(ConversationItemInputAudioTranscriptionSegment!);
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
            else if (IsInputAudioBufferTimeoutTriggered)
            {
                inputAudioBufferTimeoutTriggered?.Invoke(InputAudioBufferTimeoutTriggered!);
            }
            else if (IsMcpListToolsCompleted)
            {
                mcpListToolsCompleted?.Invoke(McpListToolsCompleted!);
            }
            else if (IsMcpListToolsFailed)
            {
                mcpListToolsFailed?.Invoke(McpListToolsFailed!);
            }
            else if (IsMcpListToolsInProgress)
            {
                mcpListToolsInProgress?.Invoke(McpListToolsInProgress!);
            }
            else if (IsOutputAudioBufferCleared)
            {
                outputAudioBufferCleared?.Invoke(OutputAudioBufferCleared!);
            }
            else if (IsOutputAudioBufferStarted)
            {
                outputAudioBufferStarted?.Invoke(OutputAudioBufferStarted!);
            }
            else if (IsOutputAudioBufferStopped)
            {
                outputAudioBufferStopped?.Invoke(OutputAudioBufferStopped!);
            }
            else if (IsRateLimitsUpdated)
            {
                rateLimitsUpdated?.Invoke(RateLimitsUpdated!);
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
            else if (IsResponseMcpCallArgumentsDelta)
            {
                responseMcpCallArgumentsDelta?.Invoke(ResponseMcpCallArgumentsDelta!);
            }
            else if (IsResponseMcpCallArgumentsDone)
            {
                responseMcpCallArgumentsDone?.Invoke(ResponseMcpCallArgumentsDone!);
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
            else if (IsTranscriptionSessionUpdated)
            {
                transcriptionSessionUpdated?.Invoke(TranscriptionSessionUpdated!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreated>? conversationCreated = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemAdded>? conversationItemAdded = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemCreated>? conversationItemCreated = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeleted>? conversationItemDeleted = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDone>? conversationItemDone = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted>? conversationItemInputAudioTranscriptionCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDelta>? conversationItemInputAudioTranscriptionDelta = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailed>? conversationItemInputAudioTranscriptionFailed = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionSegment>? conversationItemInputAudioTranscriptionSegment = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrieved>? conversationItemRetrieved = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemTruncated>? conversationItemTruncated = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventError>? error = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCleared>? inputAudioBufferCleared = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommitted>? inputAudioBufferCommitted = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferDtmfEventReceived>? inputAudioBufferDtmfEventReceived = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStarted>? inputAudioBufferSpeechStarted = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStopped>? inputAudioBufferSpeechStopped = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferTimeoutTriggered>? inputAudioBufferTimeoutTriggered = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompleted>? mcpListToolsCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailed>? mcpListToolsFailed = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgress>? mcpListToolsInProgress = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferCleared>? outputAudioBufferCleared = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStarted>? outputAudioBufferStarted = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStopped>? outputAudioBufferStopped = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdated>? rateLimitsUpdated = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAdded>? responseContentPartAdded = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDone>? responseContentPartDone = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseCreated>? responseCreated = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseDone>? responseDone = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDelta>? responseFunctionCallArgumentsDelta = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDone>? responseFunctionCallArgumentsDone = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompleted>? responseMcpCallCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailed>? responseMcpCallFailed = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgress>? responseMcpCallInProgress = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDelta>? responseMcpCallArgumentsDelta = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDone>? responseMcpCallArgumentsDone = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDelta>? responseOutputAudioDelta = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDone>? responseOutputAudioDone = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDelta>? responseOutputAudioTranscriptDelta = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDone>? responseOutputAudioTranscriptDone = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAdded>? responseOutputItemAdded = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDone>? responseOutputItemDone = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDelta>? responseOutputTextDelta = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDone>? responseOutputTextDone = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreated>? sessionCreated = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdated>? sessionUpdated = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeServerEventTranscriptionSessionUpdated>? transcriptionSessionUpdated = null,
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
            else if (IsConversationItemAdded)
            {
                conversationItemAdded?.Invoke(ConversationItemAdded!);
            }
            else if (IsConversationItemCreated)
            {
                conversationItemCreated?.Invoke(ConversationItemCreated!);
            }
            else if (IsConversationItemDeleted)
            {
                conversationItemDeleted?.Invoke(ConversationItemDeleted!);
            }
            else if (IsConversationItemDone)
            {
                conversationItemDone?.Invoke(ConversationItemDone!);
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
            else if (IsConversationItemInputAudioTranscriptionSegment)
            {
                conversationItemInputAudioTranscriptionSegment?.Invoke(ConversationItemInputAudioTranscriptionSegment!);
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
            else if (IsInputAudioBufferTimeoutTriggered)
            {
                inputAudioBufferTimeoutTriggered?.Invoke(InputAudioBufferTimeoutTriggered!);
            }
            else if (IsMcpListToolsCompleted)
            {
                mcpListToolsCompleted?.Invoke(McpListToolsCompleted!);
            }
            else if (IsMcpListToolsFailed)
            {
                mcpListToolsFailed?.Invoke(McpListToolsFailed!);
            }
            else if (IsMcpListToolsInProgress)
            {
                mcpListToolsInProgress?.Invoke(McpListToolsInProgress!);
            }
            else if (IsOutputAudioBufferCleared)
            {
                outputAudioBufferCleared?.Invoke(OutputAudioBufferCleared!);
            }
            else if (IsOutputAudioBufferStarted)
            {
                outputAudioBufferStarted?.Invoke(OutputAudioBufferStarted!);
            }
            else if (IsOutputAudioBufferStopped)
            {
                outputAudioBufferStopped?.Invoke(OutputAudioBufferStopped!);
            }
            else if (IsRateLimitsUpdated)
            {
                rateLimitsUpdated?.Invoke(RateLimitsUpdated!);
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
            else if (IsResponseMcpCallArgumentsDelta)
            {
                responseMcpCallArgumentsDelta?.Invoke(ResponseMcpCallArgumentsDelta!);
            }
            else if (IsResponseMcpCallArgumentsDone)
            {
                responseMcpCallArgumentsDone?.Invoke(ResponseMcpCallArgumentsDone!);
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
            else if (IsTranscriptionSessionUpdated)
            {
                transcriptionSessionUpdated?.Invoke(TranscriptionSessionUpdated!);
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
                ConversationItemAdded,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemAdded),
                ConversationItemCreated,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemCreated),
                ConversationItemDeleted,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeleted),
                ConversationItemDone,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDone),
                ConversationItemInputAudioTranscriptionCompleted,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted),
                ConversationItemInputAudioTranscriptionDelta,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDelta),
                ConversationItemInputAudioTranscriptionFailed,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailed),
                ConversationItemInputAudioTranscriptionSegment,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionSegment),
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
                InputAudioBufferTimeoutTriggered,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferTimeoutTriggered),
                McpListToolsCompleted,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompleted),
                McpListToolsFailed,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailed),
                McpListToolsInProgress,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgress),
                OutputAudioBufferCleared,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferCleared),
                OutputAudioBufferStarted,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStarted),
                OutputAudioBufferStopped,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStopped),
                RateLimitsUpdated,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdated),
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
                ResponseMcpCallCompleted,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompleted),
                ResponseMcpCallFailed,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailed),
                ResponseMcpCallInProgress,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgress),
                ResponseMcpCallArgumentsDelta,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDelta),
                ResponseMcpCallArgumentsDone,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDone),
                ResponseOutputAudioDelta,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDelta),
                ResponseOutputAudioDone,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDone),
                ResponseOutputAudioTranscriptDelta,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDelta),
                ResponseOutputAudioTranscriptDone,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDone),
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
                TranscriptionSessionUpdated,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventTranscriptionSessionUpdated),
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
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreated?>.Default.Equals(ConversationCreated, other.ConversationCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemAdded?>.Default.Equals(ConversationItemAdded, other.ConversationItemAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemCreated?>.Default.Equals(ConversationItemCreated, other.ConversationItemCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeleted?>.Default.Equals(ConversationItemDeleted, other.ConversationItemDeleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDone?>.Default.Equals(ConversationItemDone, other.ConversationItemDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted?>.Default.Equals(ConversationItemInputAudioTranscriptionCompleted, other.ConversationItemInputAudioTranscriptionCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDelta?>.Default.Equals(ConversationItemInputAudioTranscriptionDelta, other.ConversationItemInputAudioTranscriptionDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailed?>.Default.Equals(ConversationItemInputAudioTranscriptionFailed, other.ConversationItemInputAudioTranscriptionFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionSegment?>.Default.Equals(ConversationItemInputAudioTranscriptionSegment, other.ConversationItemInputAudioTranscriptionSegment) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrieved?>.Default.Equals(ConversationItemRetrieved, other.ConversationItemRetrieved) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemTruncated?>.Default.Equals(ConversationItemTruncated, other.ConversationItemTruncated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventError?>.Default.Equals(Error, other.Error) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCleared?>.Default.Equals(InputAudioBufferCleared, other.InputAudioBufferCleared) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommitted?>.Default.Equals(InputAudioBufferCommitted, other.InputAudioBufferCommitted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferDtmfEventReceived?>.Default.Equals(InputAudioBufferDtmfEventReceived, other.InputAudioBufferDtmfEventReceived) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStarted?>.Default.Equals(InputAudioBufferSpeechStarted, other.InputAudioBufferSpeechStarted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStopped?>.Default.Equals(InputAudioBufferSpeechStopped, other.InputAudioBufferSpeechStopped) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferTimeoutTriggered?>.Default.Equals(InputAudioBufferTimeoutTriggered, other.InputAudioBufferTimeoutTriggered) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompleted?>.Default.Equals(McpListToolsCompleted, other.McpListToolsCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailed?>.Default.Equals(McpListToolsFailed, other.McpListToolsFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgress?>.Default.Equals(McpListToolsInProgress, other.McpListToolsInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferCleared?>.Default.Equals(OutputAudioBufferCleared, other.OutputAudioBufferCleared) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStarted?>.Default.Equals(OutputAudioBufferStarted, other.OutputAudioBufferStarted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStopped?>.Default.Equals(OutputAudioBufferStopped, other.OutputAudioBufferStopped) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdated?>.Default.Equals(RateLimitsUpdated, other.RateLimitsUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAdded?>.Default.Equals(ResponseContentPartAdded, other.ResponseContentPartAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDone?>.Default.Equals(ResponseContentPartDone, other.ResponseContentPartDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseCreated?>.Default.Equals(ResponseCreated, other.ResponseCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseDone?>.Default.Equals(ResponseDone, other.ResponseDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDelta?>.Default.Equals(ResponseFunctionCallArgumentsDelta, other.ResponseFunctionCallArgumentsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDone?>.Default.Equals(ResponseFunctionCallArgumentsDone, other.ResponseFunctionCallArgumentsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompleted?>.Default.Equals(ResponseMcpCallCompleted, other.ResponseMcpCallCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailed?>.Default.Equals(ResponseMcpCallFailed, other.ResponseMcpCallFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgress?>.Default.Equals(ResponseMcpCallInProgress, other.ResponseMcpCallInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDelta?>.Default.Equals(ResponseMcpCallArgumentsDelta, other.ResponseMcpCallArgumentsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDone?>.Default.Equals(ResponseMcpCallArgumentsDone, other.ResponseMcpCallArgumentsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDelta?>.Default.Equals(ResponseOutputAudioDelta, other.ResponseOutputAudioDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDone?>.Default.Equals(ResponseOutputAudioDone, other.ResponseOutputAudioDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDelta?>.Default.Equals(ResponseOutputAudioTranscriptDelta, other.ResponseOutputAudioTranscriptDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDone?>.Default.Equals(ResponseOutputAudioTranscriptDone, other.ResponseOutputAudioTranscriptDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAdded?>.Default.Equals(ResponseOutputItemAdded, other.ResponseOutputItemAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDone?>.Default.Equals(ResponseOutputItemDone, other.ResponseOutputItemDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDelta?>.Default.Equals(ResponseOutputTextDelta, other.ResponseOutputTextDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDone?>.Default.Equals(ResponseOutputTextDone, other.ResponseOutputTextDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreated?>.Default.Equals(SessionCreated, other.SessionCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdated?>.Default.Equals(SessionUpdated, other.SessionUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeServerEventTranscriptionSessionUpdated?>.Default.Equals(TranscriptionSessionUpdated, other.TranscriptionSessionUpdated) 
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
