#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A realtime client event.
    /// </summary>
    public readonly partial struct RealtimeClientEvent : global::System.IEquatable<RealtimeClientEvent>
    {
        /// <summary>
        /// Add a new Item to the Conversation's context, including messages, function <br/>
        /// calls, and function call responses. This event can be used both to populate a <br/>
        /// "history" of the conversation and to add new items mid-stream, but has the <br/>
        /// current limitation that it cannot populate assistant audio messages.<br/>
        /// If successful, the server will respond with a `conversation.item.created` <br/>
        /// event, otherwise an `error` event will be sent.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeClientEventConversationItemCreate? ConversationItemCreate { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeClientEventConversationItemCreate? ConversationItemCreate { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemCreate))]
#endif
        public bool IsConversationItemCreate => ConversationItemCreate != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeClientEvent(global::tryAGI.OpenAI.RealtimeClientEventConversationItemCreate value) => new RealtimeClientEvent((global::tryAGI.OpenAI.RealtimeClientEventConversationItemCreate?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeClientEventConversationItemCreate?(RealtimeClientEvent @this) => @this.ConversationItemCreate;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeClientEvent(global::tryAGI.OpenAI.RealtimeClientEventConversationItemCreate? value)
        {
            ConversationItemCreate = value;
        }

        /// <summary>
        /// Send this event when you want to remove any item from the conversation <br/>
        /// history. The server will respond with a `conversation.item.deleted` event, <br/>
        /// unless the item does not exist in the conversation history, in which case the <br/>
        /// server will respond with an error.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeClientEventConversationItemDelete? ConversationItemDelete { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeClientEventConversationItemDelete? ConversationItemDelete { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemDelete))]
#endif
        public bool IsConversationItemDelete => ConversationItemDelete != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeClientEvent(global::tryAGI.OpenAI.RealtimeClientEventConversationItemDelete value) => new RealtimeClientEvent((global::tryAGI.OpenAI.RealtimeClientEventConversationItemDelete?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeClientEventConversationItemDelete?(RealtimeClientEvent @this) => @this.ConversationItemDelete;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeClientEvent(global::tryAGI.OpenAI.RealtimeClientEventConversationItemDelete? value)
        {
            ConversationItemDelete = value;
        }

        /// <summary>
        /// Send this event when you want to retrieve the server's representation of a specific item in the conversation history. This is useful, for example, to inspect user audio after noise cancellation and VAD.<br/>
        /// The server will respond with a `conversation.item.retrieved` event, <br/>
        /// unless the item does not exist in the conversation history, in which case the <br/>
        /// server will respond with an error.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeClientEventConversationItemRetrieve? ConversationItemRetrieve { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeClientEventConversationItemRetrieve? ConversationItemRetrieve { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemRetrieve))]
#endif
        public bool IsConversationItemRetrieve => ConversationItemRetrieve != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeClientEvent(global::tryAGI.OpenAI.RealtimeClientEventConversationItemRetrieve value) => new RealtimeClientEvent((global::tryAGI.OpenAI.RealtimeClientEventConversationItemRetrieve?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeClientEventConversationItemRetrieve?(RealtimeClientEvent @this) => @this.ConversationItemRetrieve;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeClientEvent(global::tryAGI.OpenAI.RealtimeClientEventConversationItemRetrieve? value)
        {
            ConversationItemRetrieve = value;
        }

        /// <summary>
        /// Send this event to truncate a previous assistant message’s audio. The server <br/>
        /// will produce audio faster than realtime, so this event is useful when the user <br/>
        /// interrupts to truncate audio that has already been sent to the client but not <br/>
        /// yet played. This will synchronize the server's understanding of the audio with <br/>
        /// the client's playback.<br/>
        /// Truncating audio will delete the server-side text transcript to ensure there <br/>
        /// is not text in the context that hasn't been heard by the user.<br/>
        /// If successful, the server will respond with a `conversation.item.truncated` <br/>
        /// event. 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeClientEventConversationItemTruncate? ConversationItemTruncate { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeClientEventConversationItemTruncate? ConversationItemTruncate { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationItemTruncate))]
#endif
        public bool IsConversationItemTruncate => ConversationItemTruncate != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeClientEvent(global::tryAGI.OpenAI.RealtimeClientEventConversationItemTruncate value) => new RealtimeClientEvent((global::tryAGI.OpenAI.RealtimeClientEventConversationItemTruncate?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeClientEventConversationItemTruncate?(RealtimeClientEvent @this) => @this.ConversationItemTruncate;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeClientEvent(global::tryAGI.OpenAI.RealtimeClientEventConversationItemTruncate? value)
        {
            ConversationItemTruncate = value;
        }

        /// <summary>
        /// Send this event to append audio bytes to the input audio buffer. The audio <br/>
        /// buffer is temporary storage you can write to and later commit. A "commit" will create a new<br/>
        /// user message item in the conversation history from the buffer content and clear the buffer.<br/>
        /// Input audio transcription (if enabled) will be generated when the buffer is committed.<br/>
        /// If VAD is enabled the audio buffer is used to detect speech and the server will decide <br/>
        /// when to commit. When Server VAD is disabled, you must commit the audio buffer<br/>
        /// manually. Input audio noise reduction operates on writes to the audio buffer.<br/>
        /// The client may choose how much audio to place in each event up to a maximum <br/>
        /// of 15 MiB, for example streaming smaller chunks from the client may allow the <br/>
        /// VAD to be more responsive. Unlike most other client events, the server will <br/>
        /// not send a confirmation response to this event.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferAppend? InputAudioBufferAppend { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferAppend? InputAudioBufferAppend { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudioBufferAppend))]
#endif
        public bool IsInputAudioBufferAppend => InputAudioBufferAppend != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeClientEvent(global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferAppend value) => new RealtimeClientEvent((global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferAppend?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferAppend?(RealtimeClientEvent @this) => @this.InputAudioBufferAppend;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeClientEvent(global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferAppend? value)
        {
            InputAudioBufferAppend = value;
        }

        /// <summary>
        /// Send this event to clear the audio bytes in the buffer. The server will <br/>
        /// respond with an `input_audio_buffer.cleared` event.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferClear? InputAudioBufferClear { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferClear? InputAudioBufferClear { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudioBufferClear))]
#endif
        public bool IsInputAudioBufferClear => InputAudioBufferClear != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeClientEvent(global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferClear value) => new RealtimeClientEvent((global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferClear?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferClear?(RealtimeClientEvent @this) => @this.InputAudioBufferClear;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeClientEvent(global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferClear? value)
        {
            InputAudioBufferClear = value;
        }

        /// <summary>
        /// **WebRTC Only:** Emit to cut off the current audio response. This will trigger the server to<br/>
        /// stop generating audio and emit a `output_audio_buffer.cleared` event. This <br/>
        /// event should be preceded by a `response.cancel` client event to stop the <br/>
        /// generation of the current response.<br/>
        /// [Learn more](https://platform.openai.com/docs/guides/realtime-conversations#client-and-server-events-for-audio-in-webrtc).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeClientEventOutputAudioBufferClear? OutputAudioBufferClear { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeClientEventOutputAudioBufferClear? OutputAudioBufferClear { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputAudioBufferClear))]
#endif
        public bool IsOutputAudioBufferClear => OutputAudioBufferClear != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeClientEvent(global::tryAGI.OpenAI.RealtimeClientEventOutputAudioBufferClear value) => new RealtimeClientEvent((global::tryAGI.OpenAI.RealtimeClientEventOutputAudioBufferClear?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeClientEventOutputAudioBufferClear?(RealtimeClientEvent @this) => @this.OutputAudioBufferClear;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeClientEvent(global::tryAGI.OpenAI.RealtimeClientEventOutputAudioBufferClear? value)
        {
            OutputAudioBufferClear = value;
        }

        /// <summary>
        /// Send this event to commit the user input audio buffer, which will create a  new user message item in the conversation. This event will produce an error  if the input audio buffer is empty. When in Server VAD mode, the client does  not need to send this event, the server will commit the audio buffer  automatically.<br/>
        /// Committing the input audio buffer will trigger input audio transcription  (if enabled in session configuration), but it will not create a response  from the model. The server will respond with an `input_audio_buffer.committed` event.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferCommit? InputAudioBufferCommit { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferCommit? InputAudioBufferCommit { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudioBufferCommit))]
#endif
        public bool IsInputAudioBufferCommit => InputAudioBufferCommit != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeClientEvent(global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferCommit value) => new RealtimeClientEvent((global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferCommit?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferCommit?(RealtimeClientEvent @this) => @this.InputAudioBufferCommit;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeClientEvent(global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferCommit? value)
        {
            InputAudioBufferCommit = value;
        }

        /// <summary>
        /// Send this event to cancel an in-progress response. The server will respond <br/>
        /// with a `response.done` event with a status of `response.status=cancelled`. If <br/>
        /// there is no response to cancel, the server will respond with an error. It's safe<br/>
        /// to call `response.cancel` even if no response is in progress, an error will be<br/>
        /// returned the session will remain unaffected.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeClientEventResponseCancel? ResponseCancel { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeClientEventResponseCancel? ResponseCancel { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCancel))]
#endif
        public bool IsResponseCancel => ResponseCancel != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeClientEvent(global::tryAGI.OpenAI.RealtimeClientEventResponseCancel value) => new RealtimeClientEvent((global::tryAGI.OpenAI.RealtimeClientEventResponseCancel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeClientEventResponseCancel?(RealtimeClientEvent @this) => @this.ResponseCancel;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeClientEvent(global::tryAGI.OpenAI.RealtimeClientEventResponseCancel? value)
        {
            ResponseCancel = value;
        }

        /// <summary>
        /// This event instructs the server to create a Response, which means triggering <br/>
        /// model inference. When in Server VAD mode, the server will create Responses <br/>
        /// automatically.<br/>
        /// A Response will include at least one Item, and may have two, in which case <br/>
        /// the second will be a function call. These Items will be appended to the <br/>
        /// conversation history by default.<br/>
        /// The server will respond with a `response.created` event, events for Items <br/>
        /// and content created, and finally a `response.done` event to indicate the <br/>
        /// Response is complete.<br/>
        /// The `response.create` event includes inference configuration like <br/>
        /// `instructions` and `tools`. If these are set, they will override the Session's <br/>
        /// configuration for this Response only.<br/>
        /// Responses can be created out-of-band of the default Conversation, meaning that they can<br/>
        /// have arbitrary input, and it's possible to disable writing the output to the Conversation.<br/>
        /// Only one Response can write to the default Conversation at a time, but otherwise multiple<br/>
        /// Responses can be created in parallel. The `metadata` field is a good way to disambiguate<br/>
        /// multiple simultaneous Responses.<br/>
        /// Clients can set `conversation` to `none` to create a Response that does not write to the default<br/>
        /// Conversation. Arbitrary input can be provided with the `input` field, which is an array accepting<br/>
        /// raw Items and references to existing Items.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeClientEventResponseCreate? ResponseCreate { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeClientEventResponseCreate? ResponseCreate { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCreate))]
#endif
        public bool IsResponseCreate => ResponseCreate != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeClientEvent(global::tryAGI.OpenAI.RealtimeClientEventResponseCreate value) => new RealtimeClientEvent((global::tryAGI.OpenAI.RealtimeClientEventResponseCreate?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeClientEventResponseCreate?(RealtimeClientEvent @this) => @this.ResponseCreate;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeClientEvent(global::tryAGI.OpenAI.RealtimeClientEventResponseCreate? value)
        {
            ResponseCreate = value;
        }

        /// <summary>
        /// Send this event to update the session’s configuration.<br/>
        /// The client may send this event at any time to update any field<br/>
        /// except for `voice` and `model`. `voice` can be updated only if there have been no other audio outputs yet.<br/>
        /// When the server receives a `session.update`, it will respond<br/>
        /// with a `session.updated` event showing the full, effective configuration.<br/>
        /// Only the fields that are present in the `session.update` are updated. To clear a field like<br/>
        /// `instructions`, pass an empty string. To clear a field like `tools`, pass an empty array.<br/>
        /// To clear a field like `turn_detection`, pass `null`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeClientEventSessionUpdate? SessionUpdate { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeClientEventSessionUpdate? SessionUpdate { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionUpdate))]
#endif
        public bool IsSessionUpdate => SessionUpdate != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeClientEvent(global::tryAGI.OpenAI.RealtimeClientEventSessionUpdate value) => new RealtimeClientEvent((global::tryAGI.OpenAI.RealtimeClientEventSessionUpdate?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeClientEventSessionUpdate?(RealtimeClientEvent @this) => @this.SessionUpdate;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeClientEvent(global::tryAGI.OpenAI.RealtimeClientEventSessionUpdate? value)
        {
            SessionUpdate = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RealtimeClientEvent(
            global::tryAGI.OpenAI.RealtimeClientEventConversationItemCreate? conversationItemCreate,
            global::tryAGI.OpenAI.RealtimeClientEventConversationItemDelete? conversationItemDelete,
            global::tryAGI.OpenAI.RealtimeClientEventConversationItemRetrieve? conversationItemRetrieve,
            global::tryAGI.OpenAI.RealtimeClientEventConversationItemTruncate? conversationItemTruncate,
            global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferAppend? inputAudioBufferAppend,
            global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferClear? inputAudioBufferClear,
            global::tryAGI.OpenAI.RealtimeClientEventOutputAudioBufferClear? outputAudioBufferClear,
            global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferCommit? inputAudioBufferCommit,
            global::tryAGI.OpenAI.RealtimeClientEventResponseCancel? responseCancel,
            global::tryAGI.OpenAI.RealtimeClientEventResponseCreate? responseCreate,
            global::tryAGI.OpenAI.RealtimeClientEventSessionUpdate? sessionUpdate
            )
        {
            ConversationItemCreate = conversationItemCreate;
            ConversationItemDelete = conversationItemDelete;
            ConversationItemRetrieve = conversationItemRetrieve;
            ConversationItemTruncate = conversationItemTruncate;
            InputAudioBufferAppend = inputAudioBufferAppend;
            InputAudioBufferClear = inputAudioBufferClear;
            OutputAudioBufferClear = outputAudioBufferClear;
            InputAudioBufferCommit = inputAudioBufferCommit;
            ResponseCancel = responseCancel;
            ResponseCreate = responseCreate;
            SessionUpdate = sessionUpdate;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SessionUpdate as object ??
            ResponseCreate as object ??
            ResponseCancel as object ??
            InputAudioBufferCommit as object ??
            OutputAudioBufferClear as object ??
            InputAudioBufferClear as object ??
            InputAudioBufferAppend as object ??
            ConversationItemTruncate as object ??
            ConversationItemRetrieve as object ??
            ConversationItemDelete as object ??
            ConversationItemCreate as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ConversationItemCreate?.ToString() ??
            ConversationItemDelete?.ToString() ??
            ConversationItemRetrieve?.ToString() ??
            ConversationItemTruncate?.ToString() ??
            InputAudioBufferAppend?.ToString() ??
            InputAudioBufferClear?.ToString() ??
            OutputAudioBufferClear?.ToString() ??
            InputAudioBufferCommit?.ToString() ??
            ResponseCancel?.ToString() ??
            ResponseCreate?.ToString() ??
            SessionUpdate?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsConversationItemCreate || IsConversationItemDelete || IsConversationItemRetrieve || IsConversationItemTruncate || IsInputAudioBufferAppend || IsInputAudioBufferClear || IsOutputAudioBufferClear || IsInputAudioBufferCommit || IsResponseCancel || IsResponseCreate || IsSessionUpdate;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.RealtimeClientEventConversationItemCreate?, TResult>? conversationItemCreate = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeClientEventConversationItemDelete?, TResult>? conversationItemDelete = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeClientEventConversationItemRetrieve?, TResult>? conversationItemRetrieve = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeClientEventConversationItemTruncate?, TResult>? conversationItemTruncate = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferAppend?, TResult>? inputAudioBufferAppend = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferClear?, TResult>? inputAudioBufferClear = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeClientEventOutputAudioBufferClear?, TResult>? outputAudioBufferClear = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferCommit?, TResult>? inputAudioBufferCommit = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeClientEventResponseCancel?, TResult>? responseCancel = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeClientEventResponseCreate?, TResult>? responseCreate = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeClientEventSessionUpdate?, TResult>? sessionUpdate = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConversationItemCreate && conversationItemCreate != null)
            {
                return conversationItemCreate(ConversationItemCreate!);
            }
            else if (IsConversationItemDelete && conversationItemDelete != null)
            {
                return conversationItemDelete(ConversationItemDelete!);
            }
            else if (IsConversationItemRetrieve && conversationItemRetrieve != null)
            {
                return conversationItemRetrieve(ConversationItemRetrieve!);
            }
            else if (IsConversationItemTruncate && conversationItemTruncate != null)
            {
                return conversationItemTruncate(ConversationItemTruncate!);
            }
            else if (IsInputAudioBufferAppend && inputAudioBufferAppend != null)
            {
                return inputAudioBufferAppend(InputAudioBufferAppend!);
            }
            else if (IsInputAudioBufferClear && inputAudioBufferClear != null)
            {
                return inputAudioBufferClear(InputAudioBufferClear!);
            }
            else if (IsOutputAudioBufferClear && outputAudioBufferClear != null)
            {
                return outputAudioBufferClear(OutputAudioBufferClear!);
            }
            else if (IsInputAudioBufferCommit && inputAudioBufferCommit != null)
            {
                return inputAudioBufferCommit(InputAudioBufferCommit!);
            }
            else if (IsResponseCancel && responseCancel != null)
            {
                return responseCancel(ResponseCancel!);
            }
            else if (IsResponseCreate && responseCreate != null)
            {
                return responseCreate(ResponseCreate!);
            }
            else if (IsSessionUpdate && sessionUpdate != null)
            {
                return sessionUpdate(SessionUpdate!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.RealtimeClientEventConversationItemCreate?>? conversationItemCreate = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeClientEventConversationItemDelete?>? conversationItemDelete = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeClientEventConversationItemRetrieve?>? conversationItemRetrieve = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeClientEventConversationItemTruncate?>? conversationItemTruncate = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferAppend?>? inputAudioBufferAppend = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferClear?>? inputAudioBufferClear = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeClientEventOutputAudioBufferClear?>? outputAudioBufferClear = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferCommit?>? inputAudioBufferCommit = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeClientEventResponseCancel?>? responseCancel = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeClientEventResponseCreate?>? responseCreate = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeClientEventSessionUpdate?>? sessionUpdate = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConversationItemCreate)
            {
                conversationItemCreate?.Invoke(ConversationItemCreate!);
            }
            else if (IsConversationItemDelete)
            {
                conversationItemDelete?.Invoke(ConversationItemDelete!);
            }
            else if (IsConversationItemRetrieve)
            {
                conversationItemRetrieve?.Invoke(ConversationItemRetrieve!);
            }
            else if (IsConversationItemTruncate)
            {
                conversationItemTruncate?.Invoke(ConversationItemTruncate!);
            }
            else if (IsInputAudioBufferAppend)
            {
                inputAudioBufferAppend?.Invoke(InputAudioBufferAppend!);
            }
            else if (IsInputAudioBufferClear)
            {
                inputAudioBufferClear?.Invoke(InputAudioBufferClear!);
            }
            else if (IsOutputAudioBufferClear)
            {
                outputAudioBufferClear?.Invoke(OutputAudioBufferClear!);
            }
            else if (IsInputAudioBufferCommit)
            {
                inputAudioBufferCommit?.Invoke(InputAudioBufferCommit!);
            }
            else if (IsResponseCancel)
            {
                responseCancel?.Invoke(ResponseCancel!);
            }
            else if (IsResponseCreate)
            {
                responseCreate?.Invoke(ResponseCreate!);
            }
            else if (IsSessionUpdate)
            {
                sessionUpdate?.Invoke(SessionUpdate!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ConversationItemCreate,
                typeof(global::tryAGI.OpenAI.RealtimeClientEventConversationItemCreate),
                ConversationItemDelete,
                typeof(global::tryAGI.OpenAI.RealtimeClientEventConversationItemDelete),
                ConversationItemRetrieve,
                typeof(global::tryAGI.OpenAI.RealtimeClientEventConversationItemRetrieve),
                ConversationItemTruncate,
                typeof(global::tryAGI.OpenAI.RealtimeClientEventConversationItemTruncate),
                InputAudioBufferAppend,
                typeof(global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferAppend),
                InputAudioBufferClear,
                typeof(global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferClear),
                OutputAudioBufferClear,
                typeof(global::tryAGI.OpenAI.RealtimeClientEventOutputAudioBufferClear),
                InputAudioBufferCommit,
                typeof(global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferCommit),
                ResponseCancel,
                typeof(global::tryAGI.OpenAI.RealtimeClientEventResponseCancel),
                ResponseCreate,
                typeof(global::tryAGI.OpenAI.RealtimeClientEventResponseCreate),
                SessionUpdate,
                typeof(global::tryAGI.OpenAI.RealtimeClientEventSessionUpdate),
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
        public bool Equals(RealtimeClientEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeClientEventConversationItemCreate?>.Default.Equals(ConversationItemCreate, other.ConversationItemCreate) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeClientEventConversationItemDelete?>.Default.Equals(ConversationItemDelete, other.ConversationItemDelete) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeClientEventConversationItemRetrieve?>.Default.Equals(ConversationItemRetrieve, other.ConversationItemRetrieve) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeClientEventConversationItemTruncate?>.Default.Equals(ConversationItemTruncate, other.ConversationItemTruncate) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferAppend?>.Default.Equals(InputAudioBufferAppend, other.InputAudioBufferAppend) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferClear?>.Default.Equals(InputAudioBufferClear, other.InputAudioBufferClear) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeClientEventOutputAudioBufferClear?>.Default.Equals(OutputAudioBufferClear, other.OutputAudioBufferClear) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferCommit?>.Default.Equals(InputAudioBufferCommit, other.InputAudioBufferCommit) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeClientEventResponseCancel?>.Default.Equals(ResponseCancel, other.ResponseCancel) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeClientEventResponseCreate?>.Default.Equals(ResponseCreate, other.ResponseCreate) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeClientEventSessionUpdate?>.Default.Equals(SessionUpdate, other.SessionUpdate) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RealtimeClientEvent obj1, RealtimeClientEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RealtimeClientEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RealtimeClientEvent obj1, RealtimeClientEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RealtimeClientEvent o && Equals(o);
        }
    }
}
