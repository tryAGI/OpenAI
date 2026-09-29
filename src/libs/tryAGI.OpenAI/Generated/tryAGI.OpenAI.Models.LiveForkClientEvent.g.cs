#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Client events for a Live fork WebSocket. First send session.start with an overrides object (which may be empty), then wait for session.started before sending other commands. The model and conversation are inherited from the stored session.
    /// </summary>
    public readonly partial struct LiveForkClientEvent : global::System.IEquatable<LiveForkClientEvent>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkClientEventDiscriminatorType? Type { get; }

        /// <summary>
        /// Start a Live session after connecting to a stored session’s fork WebSocket. Send an empty `session` object to use the stored configuration.<br/>
        /// Example: {"type":"session.start","session":{}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveForkSessionStartEvent? SessionStart { get; init; }
#else
        public global::tryAGI.OpenAI.LiveForkSessionStartEvent? SessionStart { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionStart))]
#endif
        public bool IsSessionStart => SessionStart != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSessionStart(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveForkSessionStartEvent? value)
        {
            value = SessionStart;
            return IsSessionStart;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveForkSessionStartEvent PickSessionStart() => SessionStart is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionStart' but the value was {ToString()}.");

        /// <summary>
        /// Update the delegation settings of an active Live session. The server acknowledges accepted changes with `session.updated`.<br/>
        /// Example: {"type":"session.update","event_id":"evt_update_001","session":{"delegation":{"type":"responses","responses":{"instructions":"Check restaurant availability. Ask before confirming a booking.","max_output_tokens":1024}}}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveSessionUpdateParam? SessionUpdate { get; init; }
#else
        public global::tryAGI.OpenAI.LiveSessionUpdateParam? SessionUpdate { get; }
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
        public bool TryPickSessionUpdate(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveSessionUpdateParam? value)
        {
            value = SessionUpdate;
            return IsSessionUpdate;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUpdateParam PickSessionUpdate() => SessionUpdate is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionUpdate' but the value was {ToString()}.");

        /// <summary>
        /// Send audio to a Live session over its primary WebSocket. WebRTC and SIP sessions send audio over their media transport.<br/>
        /// Example: {"type":"session.input_audio.append","audio":"AACAAIAAAIAAAP9/AIAAgA=="}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveInputAudioAppendEvent? SessionInputAudioAppend { get; init; }
#else
        public global::tryAGI.OpenAI.LiveInputAudioAppendEvent? SessionInputAudioAppend { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionInputAudioAppend))]
#endif
        public bool IsSessionInputAudioAppend => SessionInputAudioAppend != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSessionInputAudioAppend(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveInputAudioAppendEvent? value)
        {
            value = SessionInputAudioAppend;
            return IsSessionInputAudioAppend;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioAppendEvent PickSessionInputAudioAppend() => SessionInputAudioAppend is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionInputAudioAppend' but the value was {ToString()}.");

        /// <summary>
        /// Mute audio input to the Live model without closing the session. The server acknowledges with `session.input_audio.muted`.<br/>
        /// Example: {"type":"session.input_audio.mute","event_id":"evt_mute_001"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveInputAudioMuteParam? SessionInputAudioMute { get; init; }
#else
        public global::tryAGI.OpenAI.LiveInputAudioMuteParam? SessionInputAudioMute { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionInputAudioMute))]
#endif
        public bool IsSessionInputAudioMute => SessionInputAudioMute != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSessionInputAudioMute(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveInputAudioMuteParam? value)
        {
            value = SessionInputAudioMute;
            return IsSessionInputAudioMute;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioMuteParam PickSessionInputAudioMute() => SessionInputAudioMute is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionInputAudioMute' but the value was {ToString()}.");

        /// <summary>
        /// Resume audio input to a Live model after muting it. The server acknowledges with `session.input_audio.unmuted`.<br/>
        /// Example: {"type":"session.input_audio.unmute","event_id":"evt_unmute_001"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveInputAudioUnmuteParam? SessionInputAudioUnmute { get; init; }
#else
        public global::tryAGI.OpenAI.LiveInputAudioUnmuteParam? SessionInputAudioUnmute { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionInputAudioUnmute))]
#endif
        public bool IsSessionInputAudioUnmute => SessionInputAudioUnmute != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSessionInputAudioUnmute(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveInputAudioUnmuteParam? value)
        {
            value = SessionInputAudioUnmute;
            return IsSessionInputAudioUnmute;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioUnmuteParam PickSessionInputAudioUnmute() => SessionInputAudioUnmute is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionInputAudioUnmute' but the value was {ToString()}.");

        /// <summary>
        /// Append instructions to the Live conversation while it is running, optionally associating them with an existing client delegation.<br/>
        /// Example: {"type":"session.instructions.append","event_id":"evt_instructions_001","delegation_id":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","content":"The caller prefers outdoor seating."}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveInstructionsAppendParam? SessionInstructionsAppend { get; init; }
#else
        public global::tryAGI.OpenAI.LiveInstructionsAppendParam? SessionInstructionsAppend { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionInstructionsAppend))]
#endif
        public bool IsSessionInstructionsAppend => SessionInstructionsAppend != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSessionInstructionsAppend(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveInstructionsAppendParam? value)
        {
            value = SessionInstructionsAppend;
            return IsSessionInstructionsAppend;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInstructionsAppendParam PickSessionInstructionsAppend() => SessionInstructionsAppend is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionInstructionsAppend' but the value was {ToString()}.");

        /// <summary>
        /// Provide silent reasoning or progress context to the Live model, optionally for an existing client delegation.<br/>
        /// Example: {"type":"session.thinking.append","event_id":"evt_thinking_001","delegation_id":"del_abc123","content":"Checking availability for two guests at 7 PM."}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveThinkingAppendParam? SessionThinkingAppend { get; init; }
#else
        public global::tryAGI.OpenAI.LiveThinkingAppendParam? SessionThinkingAppend { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionThinkingAppend))]
#endif
        public bool IsSessionThinkingAppend => SessionThinkingAppend != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSessionThinkingAppend(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveThinkingAppendParam? value)
        {
            value = SessionThinkingAppend;
            return IsSessionThinkingAppend;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveThinkingAppendParam PickSessionThinkingAppend() => SessionThinkingAppend is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionThinkingAppend' but the value was {ToString()}.");

        /// <summary>
        /// Provide context the Live model can communicate to the user, optionally for an existing client delegation.<br/>
        /// Example: {"type":"session.commentary.append","event_id":"evt_commentary_001","delegation_id":"del_abc123","content":"There is an outdoor table for two at 7 PM. Ask whether to reserve it."}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveCommentaryAppendParam? SessionCommentaryAppend { get; init; }
#else
        public global::tryAGI.OpenAI.LiveCommentaryAppendParam? SessionCommentaryAppend { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionCommentaryAppend))]
#endif
        public bool IsSessionCommentaryAppend => SessionCommentaryAppend != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSessionCommentaryAppend(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveCommentaryAppendParam? value)
        {
            value = SessionCommentaryAppend;
            return IsSessionCommentaryAppend;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCommentaryAppendParam PickSessionCommentaryAppend() => SessionCommentaryAppend is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionCommentaryAppend' but the value was {ToString()}.");

        /// <summary>
        /// Add an input item to the Live session’s Responses backend. Requires Responses delegation; use `response.create` to request a response.<br/>
        /// Example: {"type":"response.item.create","event_id":"evt_item_001","item":{"type":"message","role":"user","content":[{"type":"input_text","text":"Please check for a table for two at 7 PM."}]}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveResponseItemCreateParam? ResponseItemCreate { get; init; }
#else
        public global::tryAGI.OpenAI.LiveResponseItemCreateParam? ResponseItemCreate { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseItemCreate))]
#endif
        public bool IsResponseItemCreate => ResponseItemCreate != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseItemCreate(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveResponseItemCreateParam? value)
        {
            value = ResponseItemCreate;
            return IsResponseItemCreate;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponseItemCreateParam PickResponseItemCreate() => ResponseItemCreate is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseItemCreate' but the value was {ToString()}.");

        /// <summary>
        /// Request a response from the Live session’s Responses backend, or continue a delegated response waiting for tool results. Requires Responses delegation.<br/>
        /// Example: {"type":"response.create","event_id":"evt_response_001"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveResponseCreateParam? ResponseCreate { get; init; }
#else
        public global::tryAGI.OpenAI.LiveResponseCreateParam? ResponseCreate { get; }
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
        public bool TryPickResponseCreate(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveResponseCreateParam? value)
        {
            value = ResponseCreate;
            return IsResponseCreate;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponseCreateParam PickResponseCreate() => ResponseCreate is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCreate' but the value was {ToString()}.");

        /// <summary>
        /// Request that the Live session close. The terminal `session.closed` event contains the close reason and final usage.<br/>
        /// Example: {"type":"session.close","event_id":"evt_close_001"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveSessionCloseParam? SessionClose { get; init; }
#else
        public global::tryAGI.OpenAI.LiveSessionCloseParam? SessionClose { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionClose))]
#endif
        public bool IsSessionClose => SessionClose != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSessionClose(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveSessionCloseParam? value)
        {
            value = SessionClose;
            return IsSessionClose;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCloseParam PickSessionClose() => SessionClose is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionClose' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveForkClientEvent(global::tryAGI.OpenAI.LiveForkSessionStartEvent value) => new LiveForkClientEvent((global::tryAGI.OpenAI.LiveForkSessionStartEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveForkSessionStartEvent?(LiveForkClientEvent @this) => @this.SessionStart;

        /// <summary>
        ///
        /// </summary>
        public LiveForkClientEvent(global::tryAGI.OpenAI.LiveForkSessionStartEvent? value)
        {
            SessionStart = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveForkClientEvent FromSessionStart(global::tryAGI.OpenAI.LiveForkSessionStartEvent? value) => new LiveForkClientEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveForkClientEvent(global::tryAGI.OpenAI.LiveSessionUpdateParam value) => new LiveForkClientEvent((global::tryAGI.OpenAI.LiveSessionUpdateParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveSessionUpdateParam?(LiveForkClientEvent @this) => @this.SessionUpdate;

        /// <summary>
        ///
        /// </summary>
        public LiveForkClientEvent(global::tryAGI.OpenAI.LiveSessionUpdateParam? value)
        {
            SessionUpdate = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveForkClientEvent FromSessionUpdate(global::tryAGI.OpenAI.LiveSessionUpdateParam? value) => new LiveForkClientEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveForkClientEvent(global::tryAGI.OpenAI.LiveInputAudioAppendEvent value) => new LiveForkClientEvent((global::tryAGI.OpenAI.LiveInputAudioAppendEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveInputAudioAppendEvent?(LiveForkClientEvent @this) => @this.SessionInputAudioAppend;

        /// <summary>
        ///
        /// </summary>
        public LiveForkClientEvent(global::tryAGI.OpenAI.LiveInputAudioAppendEvent? value)
        {
            SessionInputAudioAppend = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveForkClientEvent FromSessionInputAudioAppend(global::tryAGI.OpenAI.LiveInputAudioAppendEvent? value) => new LiveForkClientEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveForkClientEvent(global::tryAGI.OpenAI.LiveInputAudioMuteParam value) => new LiveForkClientEvent((global::tryAGI.OpenAI.LiveInputAudioMuteParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveInputAudioMuteParam?(LiveForkClientEvent @this) => @this.SessionInputAudioMute;

        /// <summary>
        ///
        /// </summary>
        public LiveForkClientEvent(global::tryAGI.OpenAI.LiveInputAudioMuteParam? value)
        {
            SessionInputAudioMute = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveForkClientEvent FromSessionInputAudioMute(global::tryAGI.OpenAI.LiveInputAudioMuteParam? value) => new LiveForkClientEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveForkClientEvent(global::tryAGI.OpenAI.LiveInputAudioUnmuteParam value) => new LiveForkClientEvent((global::tryAGI.OpenAI.LiveInputAudioUnmuteParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveInputAudioUnmuteParam?(LiveForkClientEvent @this) => @this.SessionInputAudioUnmute;

        /// <summary>
        ///
        /// </summary>
        public LiveForkClientEvent(global::tryAGI.OpenAI.LiveInputAudioUnmuteParam? value)
        {
            SessionInputAudioUnmute = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveForkClientEvent FromSessionInputAudioUnmute(global::tryAGI.OpenAI.LiveInputAudioUnmuteParam? value) => new LiveForkClientEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveForkClientEvent(global::tryAGI.OpenAI.LiveInstructionsAppendParam value) => new LiveForkClientEvent((global::tryAGI.OpenAI.LiveInstructionsAppendParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveInstructionsAppendParam?(LiveForkClientEvent @this) => @this.SessionInstructionsAppend;

        /// <summary>
        ///
        /// </summary>
        public LiveForkClientEvent(global::tryAGI.OpenAI.LiveInstructionsAppendParam? value)
        {
            SessionInstructionsAppend = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveForkClientEvent FromSessionInstructionsAppend(global::tryAGI.OpenAI.LiveInstructionsAppendParam? value) => new LiveForkClientEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveForkClientEvent(global::tryAGI.OpenAI.LiveThinkingAppendParam value) => new LiveForkClientEvent((global::tryAGI.OpenAI.LiveThinkingAppendParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveThinkingAppendParam?(LiveForkClientEvent @this) => @this.SessionThinkingAppend;

        /// <summary>
        ///
        /// </summary>
        public LiveForkClientEvent(global::tryAGI.OpenAI.LiveThinkingAppendParam? value)
        {
            SessionThinkingAppend = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveForkClientEvent FromSessionThinkingAppend(global::tryAGI.OpenAI.LiveThinkingAppendParam? value) => new LiveForkClientEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveForkClientEvent(global::tryAGI.OpenAI.LiveCommentaryAppendParam value) => new LiveForkClientEvent((global::tryAGI.OpenAI.LiveCommentaryAppendParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveCommentaryAppendParam?(LiveForkClientEvent @this) => @this.SessionCommentaryAppend;

        /// <summary>
        ///
        /// </summary>
        public LiveForkClientEvent(global::tryAGI.OpenAI.LiveCommentaryAppendParam? value)
        {
            SessionCommentaryAppend = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveForkClientEvent FromSessionCommentaryAppend(global::tryAGI.OpenAI.LiveCommentaryAppendParam? value) => new LiveForkClientEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveForkClientEvent(global::tryAGI.OpenAI.LiveResponseItemCreateParam value) => new LiveForkClientEvent((global::tryAGI.OpenAI.LiveResponseItemCreateParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveResponseItemCreateParam?(LiveForkClientEvent @this) => @this.ResponseItemCreate;

        /// <summary>
        ///
        /// </summary>
        public LiveForkClientEvent(global::tryAGI.OpenAI.LiveResponseItemCreateParam? value)
        {
            ResponseItemCreate = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveForkClientEvent FromResponseItemCreate(global::tryAGI.OpenAI.LiveResponseItemCreateParam? value) => new LiveForkClientEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveForkClientEvent(global::tryAGI.OpenAI.LiveResponseCreateParam value) => new LiveForkClientEvent((global::tryAGI.OpenAI.LiveResponseCreateParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveResponseCreateParam?(LiveForkClientEvent @this) => @this.ResponseCreate;

        /// <summary>
        ///
        /// </summary>
        public LiveForkClientEvent(global::tryAGI.OpenAI.LiveResponseCreateParam? value)
        {
            ResponseCreate = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveForkClientEvent FromResponseCreate(global::tryAGI.OpenAI.LiveResponseCreateParam? value) => new LiveForkClientEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveForkClientEvent(global::tryAGI.OpenAI.LiveSessionCloseParam value) => new LiveForkClientEvent((global::tryAGI.OpenAI.LiveSessionCloseParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveSessionCloseParam?(LiveForkClientEvent @this) => @this.SessionClose;

        /// <summary>
        ///
        /// </summary>
        public LiveForkClientEvent(global::tryAGI.OpenAI.LiveSessionCloseParam? value)
        {
            SessionClose = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveForkClientEvent FromSessionClose(global::tryAGI.OpenAI.LiveSessionCloseParam? value) => new LiveForkClientEvent(value);

        /// <summary>
        ///
        /// </summary>
        public LiveForkClientEvent(
            global::tryAGI.OpenAI.LiveForkClientEventDiscriminatorType? type,
            global::tryAGI.OpenAI.LiveForkSessionStartEvent? sessionStart,
            global::tryAGI.OpenAI.LiveSessionUpdateParam? sessionUpdate,
            global::tryAGI.OpenAI.LiveInputAudioAppendEvent? sessionInputAudioAppend,
            global::tryAGI.OpenAI.LiveInputAudioMuteParam? sessionInputAudioMute,
            global::tryAGI.OpenAI.LiveInputAudioUnmuteParam? sessionInputAudioUnmute,
            global::tryAGI.OpenAI.LiveInstructionsAppendParam? sessionInstructionsAppend,
            global::tryAGI.OpenAI.LiveThinkingAppendParam? sessionThinkingAppend,
            global::tryAGI.OpenAI.LiveCommentaryAppendParam? sessionCommentaryAppend,
            global::tryAGI.OpenAI.LiveResponseItemCreateParam? responseItemCreate,
            global::tryAGI.OpenAI.LiveResponseCreateParam? responseCreate,
            global::tryAGI.OpenAI.LiveSessionCloseParam? sessionClose
            )
        {
            Type = type;

            SessionStart = sessionStart;
            SessionUpdate = sessionUpdate;
            SessionInputAudioAppend = sessionInputAudioAppend;
            SessionInputAudioMute = sessionInputAudioMute;
            SessionInputAudioUnmute = sessionInputAudioUnmute;
            SessionInstructionsAppend = sessionInstructionsAppend;
            SessionThinkingAppend = sessionThinkingAppend;
            SessionCommentaryAppend = sessionCommentaryAppend;
            ResponseItemCreate = responseItemCreate;
            ResponseCreate = responseCreate;
            SessionClose = sessionClose;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            SessionClose as object ??
            ResponseCreate as object ??
            ResponseItemCreate as object ??
            SessionCommentaryAppend as object ??
            SessionThinkingAppend as object ??
            SessionInstructionsAppend as object ??
            SessionInputAudioUnmute as object ??
            SessionInputAudioMute as object ??
            SessionInputAudioAppend as object ??
            SessionUpdate as object ??
            SessionStart as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            SessionStart?.ToString() ??
            SessionUpdate?.ToString() ??
            SessionInputAudioAppend?.ToString() ??
            SessionInputAudioMute?.ToString() ??
            SessionInputAudioUnmute?.ToString() ??
            SessionInstructionsAppend?.ToString() ??
            SessionThinkingAppend?.ToString() ??
            SessionCommentaryAppend?.ToString() ??
            ResponseItemCreate?.ToString() ??
            ResponseCreate?.ToString() ??
            SessionClose?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSessionStart && !IsSessionUpdate && !IsSessionInputAudioAppend && !IsSessionInputAudioMute && !IsSessionInputAudioUnmute && !IsSessionInstructionsAppend && !IsSessionThinkingAppend && !IsSessionCommentaryAppend && !IsResponseItemCreate && !IsResponseCreate && !IsSessionClose || !IsSessionStart && IsSessionUpdate && !IsSessionInputAudioAppend && !IsSessionInputAudioMute && !IsSessionInputAudioUnmute && !IsSessionInstructionsAppend && !IsSessionThinkingAppend && !IsSessionCommentaryAppend && !IsResponseItemCreate && !IsResponseCreate && !IsSessionClose || !IsSessionStart && !IsSessionUpdate && IsSessionInputAudioAppend && !IsSessionInputAudioMute && !IsSessionInputAudioUnmute && !IsSessionInstructionsAppend && !IsSessionThinkingAppend && !IsSessionCommentaryAppend && !IsResponseItemCreate && !IsResponseCreate && !IsSessionClose || !IsSessionStart && !IsSessionUpdate && !IsSessionInputAudioAppend && IsSessionInputAudioMute && !IsSessionInputAudioUnmute && !IsSessionInstructionsAppend && !IsSessionThinkingAppend && !IsSessionCommentaryAppend && !IsResponseItemCreate && !IsResponseCreate && !IsSessionClose || !IsSessionStart && !IsSessionUpdate && !IsSessionInputAudioAppend && !IsSessionInputAudioMute && IsSessionInputAudioUnmute && !IsSessionInstructionsAppend && !IsSessionThinkingAppend && !IsSessionCommentaryAppend && !IsResponseItemCreate && !IsResponseCreate && !IsSessionClose || !IsSessionStart && !IsSessionUpdate && !IsSessionInputAudioAppend && !IsSessionInputAudioMute && !IsSessionInputAudioUnmute && IsSessionInstructionsAppend && !IsSessionThinkingAppend && !IsSessionCommentaryAppend && !IsResponseItemCreate && !IsResponseCreate && !IsSessionClose || !IsSessionStart && !IsSessionUpdate && !IsSessionInputAudioAppend && !IsSessionInputAudioMute && !IsSessionInputAudioUnmute && !IsSessionInstructionsAppend && IsSessionThinkingAppend && !IsSessionCommentaryAppend && !IsResponseItemCreate && !IsResponseCreate && !IsSessionClose || !IsSessionStart && !IsSessionUpdate && !IsSessionInputAudioAppend && !IsSessionInputAudioMute && !IsSessionInputAudioUnmute && !IsSessionInstructionsAppend && !IsSessionThinkingAppend && IsSessionCommentaryAppend && !IsResponseItemCreate && !IsResponseCreate && !IsSessionClose || !IsSessionStart && !IsSessionUpdate && !IsSessionInputAudioAppend && !IsSessionInputAudioMute && !IsSessionInputAudioUnmute && !IsSessionInstructionsAppend && !IsSessionThinkingAppend && !IsSessionCommentaryAppend && IsResponseItemCreate && !IsResponseCreate && !IsSessionClose || !IsSessionStart && !IsSessionUpdate && !IsSessionInputAudioAppend && !IsSessionInputAudioMute && !IsSessionInputAudioUnmute && !IsSessionInstructionsAppend && !IsSessionThinkingAppend && !IsSessionCommentaryAppend && !IsResponseItemCreate && IsResponseCreate && !IsSessionClose || !IsSessionStart && !IsSessionUpdate && !IsSessionInputAudioAppend && !IsSessionInputAudioMute && !IsSessionInputAudioUnmute && !IsSessionInstructionsAppend && !IsSessionThinkingAppend && !IsSessionCommentaryAppend && !IsResponseItemCreate && !IsResponseCreate && IsSessionClose;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.LiveForkSessionStartEvent, TResult>? sessionStart = null,
            global::System.Func<global::tryAGI.OpenAI.LiveSessionUpdateParam, TResult>? sessionUpdate = null,
            global::System.Func<global::tryAGI.OpenAI.LiveInputAudioAppendEvent, TResult>? sessionInputAudioAppend = null,
            global::System.Func<global::tryAGI.OpenAI.LiveInputAudioMuteParam, TResult>? sessionInputAudioMute = null,
            global::System.Func<global::tryAGI.OpenAI.LiveInputAudioUnmuteParam, TResult>? sessionInputAudioUnmute = null,
            global::System.Func<global::tryAGI.OpenAI.LiveInstructionsAppendParam, TResult>? sessionInstructionsAppend = null,
            global::System.Func<global::tryAGI.OpenAI.LiveThinkingAppendParam, TResult>? sessionThinkingAppend = null,
            global::System.Func<global::tryAGI.OpenAI.LiveCommentaryAppendParam, TResult>? sessionCommentaryAppend = null,
            global::System.Func<global::tryAGI.OpenAI.LiveResponseItemCreateParam, TResult>? responseItemCreate = null,
            global::System.Func<global::tryAGI.OpenAI.LiveResponseCreateParam, TResult>? responseCreate = null,
            global::System.Func<global::tryAGI.OpenAI.LiveSessionCloseParam, TResult>? sessionClose = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SessionStart is { } __value0 && sessionStart != null)
            {
                return sessionStart(__value0);
            }
            else if (SessionUpdate is { } __value1 && sessionUpdate != null)
            {
                return sessionUpdate(__value1);
            }
            else if (SessionInputAudioAppend is { } __value2 && sessionInputAudioAppend != null)
            {
                return sessionInputAudioAppend(__value2);
            }
            else if (SessionInputAudioMute is { } __value3 && sessionInputAudioMute != null)
            {
                return sessionInputAudioMute(__value3);
            }
            else if (SessionInputAudioUnmute is { } __value4 && sessionInputAudioUnmute != null)
            {
                return sessionInputAudioUnmute(__value4);
            }
            else if (SessionInstructionsAppend is { } __value5 && sessionInstructionsAppend != null)
            {
                return sessionInstructionsAppend(__value5);
            }
            else if (SessionThinkingAppend is { } __value6 && sessionThinkingAppend != null)
            {
                return sessionThinkingAppend(__value6);
            }
            else if (SessionCommentaryAppend is { } __value7 && sessionCommentaryAppend != null)
            {
                return sessionCommentaryAppend(__value7);
            }
            else if (ResponseItemCreate is { } __value8 && responseItemCreate != null)
            {
                return responseItemCreate(__value8);
            }
            else if (ResponseCreate is { } __value9 && responseCreate != null)
            {
                return responseCreate(__value9);
            }
            else if (SessionClose is { } __value10 && sessionClose != null)
            {
                return sessionClose(__value10);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.LiveForkSessionStartEvent>? sessionStart = null,

            global::System.Action<global::tryAGI.OpenAI.LiveSessionUpdateParam>? sessionUpdate = null,

            global::System.Action<global::tryAGI.OpenAI.LiveInputAudioAppendEvent>? sessionInputAudioAppend = null,

            global::System.Action<global::tryAGI.OpenAI.LiveInputAudioMuteParam>? sessionInputAudioMute = null,

            global::System.Action<global::tryAGI.OpenAI.LiveInputAudioUnmuteParam>? sessionInputAudioUnmute = null,

            global::System.Action<global::tryAGI.OpenAI.LiveInstructionsAppendParam>? sessionInstructionsAppend = null,

            global::System.Action<global::tryAGI.OpenAI.LiveThinkingAppendParam>? sessionThinkingAppend = null,

            global::System.Action<global::tryAGI.OpenAI.LiveCommentaryAppendParam>? sessionCommentaryAppend = null,

            global::System.Action<global::tryAGI.OpenAI.LiveResponseItemCreateParam>? responseItemCreate = null,

            global::System.Action<global::tryAGI.OpenAI.LiveResponseCreateParam>? responseCreate = null,

            global::System.Action<global::tryAGI.OpenAI.LiveSessionCloseParam>? sessionClose = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SessionStart is { } __value0)
            {
                sessionStart?.Invoke(__value0);
            }
            else if (SessionUpdate is { } __value1)
            {
                sessionUpdate?.Invoke(__value1);
            }
            else if (SessionInputAudioAppend is { } __value2)
            {
                sessionInputAudioAppend?.Invoke(__value2);
            }
            else if (SessionInputAudioMute is { } __value3)
            {
                sessionInputAudioMute?.Invoke(__value3);
            }
            else if (SessionInputAudioUnmute is { } __value4)
            {
                sessionInputAudioUnmute?.Invoke(__value4);
            }
            else if (SessionInstructionsAppend is { } __value5)
            {
                sessionInstructionsAppend?.Invoke(__value5);
            }
            else if (SessionThinkingAppend is { } __value6)
            {
                sessionThinkingAppend?.Invoke(__value6);
            }
            else if (SessionCommentaryAppend is { } __value7)
            {
                sessionCommentaryAppend?.Invoke(__value7);
            }
            else if (ResponseItemCreate is { } __value8)
            {
                responseItemCreate?.Invoke(__value8);
            }
            else if (ResponseCreate is { } __value9)
            {
                responseCreate?.Invoke(__value9);
            }
            else if (SessionClose is { } __value10)
            {
                sessionClose?.Invoke(__value10);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.LiveForkSessionStartEvent>? sessionStart = null,
            global::System.Action<global::tryAGI.OpenAI.LiveSessionUpdateParam>? sessionUpdate = null,
            global::System.Action<global::tryAGI.OpenAI.LiveInputAudioAppendEvent>? sessionInputAudioAppend = null,
            global::System.Action<global::tryAGI.OpenAI.LiveInputAudioMuteParam>? sessionInputAudioMute = null,
            global::System.Action<global::tryAGI.OpenAI.LiveInputAudioUnmuteParam>? sessionInputAudioUnmute = null,
            global::System.Action<global::tryAGI.OpenAI.LiveInstructionsAppendParam>? sessionInstructionsAppend = null,
            global::System.Action<global::tryAGI.OpenAI.LiveThinkingAppendParam>? sessionThinkingAppend = null,
            global::System.Action<global::tryAGI.OpenAI.LiveCommentaryAppendParam>? sessionCommentaryAppend = null,
            global::System.Action<global::tryAGI.OpenAI.LiveResponseItemCreateParam>? responseItemCreate = null,
            global::System.Action<global::tryAGI.OpenAI.LiveResponseCreateParam>? responseCreate = null,
            global::System.Action<global::tryAGI.OpenAI.LiveSessionCloseParam>? sessionClose = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SessionStart is { } __value0)
            {
                sessionStart?.Invoke(__value0);
            }
            else if (SessionUpdate is { } __value1)
            {
                sessionUpdate?.Invoke(__value1);
            }
            else if (SessionInputAudioAppend is { } __value2)
            {
                sessionInputAudioAppend?.Invoke(__value2);
            }
            else if (SessionInputAudioMute is { } __value3)
            {
                sessionInputAudioMute?.Invoke(__value3);
            }
            else if (SessionInputAudioUnmute is { } __value4)
            {
                sessionInputAudioUnmute?.Invoke(__value4);
            }
            else if (SessionInstructionsAppend is { } __value5)
            {
                sessionInstructionsAppend?.Invoke(__value5);
            }
            else if (SessionThinkingAppend is { } __value6)
            {
                sessionThinkingAppend?.Invoke(__value6);
            }
            else if (SessionCommentaryAppend is { } __value7)
            {
                sessionCommentaryAppend?.Invoke(__value7);
            }
            else if (ResponseItemCreate is { } __value8)
            {
                responseItemCreate?.Invoke(__value8);
            }
            else if (ResponseCreate is { } __value9)
            {
                responseCreate?.Invoke(__value9);
            }
            else if (SessionClose is { } __value10)
            {
                sessionClose?.Invoke(__value10);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SessionStart,
                typeof(global::tryAGI.OpenAI.LiveForkSessionStartEvent),
                SessionUpdate,
                typeof(global::tryAGI.OpenAI.LiveSessionUpdateParam),
                SessionInputAudioAppend,
                typeof(global::tryAGI.OpenAI.LiveInputAudioAppendEvent),
                SessionInputAudioMute,
                typeof(global::tryAGI.OpenAI.LiveInputAudioMuteParam),
                SessionInputAudioUnmute,
                typeof(global::tryAGI.OpenAI.LiveInputAudioUnmuteParam),
                SessionInstructionsAppend,
                typeof(global::tryAGI.OpenAI.LiveInstructionsAppendParam),
                SessionThinkingAppend,
                typeof(global::tryAGI.OpenAI.LiveThinkingAppendParam),
                SessionCommentaryAppend,
                typeof(global::tryAGI.OpenAI.LiveCommentaryAppendParam),
                ResponseItemCreate,
                typeof(global::tryAGI.OpenAI.LiveResponseItemCreateParam),
                ResponseCreate,
                typeof(global::tryAGI.OpenAI.LiveResponseCreateParam),
                SessionClose,
                typeof(global::tryAGI.OpenAI.LiveSessionCloseParam),
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
        public bool Equals(LiveForkClientEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveForkSessionStartEvent?>.Default.Equals(SessionStart, other.SessionStart) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveSessionUpdateParam?>.Default.Equals(SessionUpdate, other.SessionUpdate) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveInputAudioAppendEvent?>.Default.Equals(SessionInputAudioAppend, other.SessionInputAudioAppend) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveInputAudioMuteParam?>.Default.Equals(SessionInputAudioMute, other.SessionInputAudioMute) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveInputAudioUnmuteParam?>.Default.Equals(SessionInputAudioUnmute, other.SessionInputAudioUnmute) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveInstructionsAppendParam?>.Default.Equals(SessionInstructionsAppend, other.SessionInstructionsAppend) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveThinkingAppendParam?>.Default.Equals(SessionThinkingAppend, other.SessionThinkingAppend) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveCommentaryAppendParam?>.Default.Equals(SessionCommentaryAppend, other.SessionCommentaryAppend) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveResponseItemCreateParam?>.Default.Equals(ResponseItemCreate, other.ResponseItemCreate) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveResponseCreateParam?>.Default.Equals(ResponseCreate, other.ResponseCreate) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveSessionCloseParam?>.Default.Equals(SessionClose, other.SessionClose)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(LiveForkClientEvent obj1, LiveForkClientEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LiveForkClientEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(LiveForkClientEvent obj1, LiveForkClientEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LiveForkClientEvent o && Equals(o);
        }
    }
}
