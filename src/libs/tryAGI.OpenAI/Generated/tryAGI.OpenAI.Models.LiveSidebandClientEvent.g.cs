#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Client events accepted by an attached Live sideband WebSocket. The session is already started; send audio over the primary connection.
    /// </summary>
    public readonly partial struct LiveSidebandClientEvent : global::System.IEquatable<LiveSidebandClientEvent>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandClientEventDiscriminatorType? Type { get; }

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
        public global::tryAGI.OpenAI.LiveSessionUpdateParam PickSessionUpdate() => IsSessionUpdate
            ? SessionUpdate!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionUpdate' but the value was {ToString()}.");

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
        public global::tryAGI.OpenAI.LiveInputAudioMuteParam PickSessionInputAudioMute() => IsSessionInputAudioMute
            ? SessionInputAudioMute!
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
        public global::tryAGI.OpenAI.LiveInputAudioUnmuteParam PickSessionInputAudioUnmute() => IsSessionInputAudioUnmute
            ? SessionInputAudioUnmute!
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
        public global::tryAGI.OpenAI.LiveInstructionsAppendParam PickSessionInstructionsAppend() => IsSessionInstructionsAppend
            ? SessionInstructionsAppend!
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
        public global::tryAGI.OpenAI.LiveThinkingAppendParam PickSessionThinkingAppend() => IsSessionThinkingAppend
            ? SessionThinkingAppend!
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
        public global::tryAGI.OpenAI.LiveCommentaryAppendParam PickSessionCommentaryAppend() => IsSessionCommentaryAppend
            ? SessionCommentaryAppend!
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
        public global::tryAGI.OpenAI.LiveResponseItemCreateParam PickResponseItemCreate() => IsResponseItemCreate
            ? ResponseItemCreate!
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
        public global::tryAGI.OpenAI.LiveResponseCreateParam PickResponseCreate() => IsResponseCreate
            ? ResponseCreate!
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
        public global::tryAGI.OpenAI.LiveSessionCloseParam PickSessionClose() => IsSessionClose
            ? SessionClose!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionClose' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveSidebandClientEvent(global::tryAGI.OpenAI.LiveSessionUpdateParam value) => new LiveSidebandClientEvent((global::tryAGI.OpenAI.LiveSessionUpdateParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveSessionUpdateParam?(LiveSidebandClientEvent @this) => @this.SessionUpdate;

        /// <summary>
        ///
        /// </summary>
        public LiveSidebandClientEvent(global::tryAGI.OpenAI.LiveSessionUpdateParam? value)
        {
            SessionUpdate = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveSidebandClientEvent FromSessionUpdate(global::tryAGI.OpenAI.LiveSessionUpdateParam? value) => new LiveSidebandClientEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveSidebandClientEvent(global::tryAGI.OpenAI.LiveInputAudioMuteParam value) => new LiveSidebandClientEvent((global::tryAGI.OpenAI.LiveInputAudioMuteParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveInputAudioMuteParam?(LiveSidebandClientEvent @this) => @this.SessionInputAudioMute;

        /// <summary>
        ///
        /// </summary>
        public LiveSidebandClientEvent(global::tryAGI.OpenAI.LiveInputAudioMuteParam? value)
        {
            SessionInputAudioMute = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveSidebandClientEvent FromSessionInputAudioMute(global::tryAGI.OpenAI.LiveInputAudioMuteParam? value) => new LiveSidebandClientEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveSidebandClientEvent(global::tryAGI.OpenAI.LiveInputAudioUnmuteParam value) => new LiveSidebandClientEvent((global::tryAGI.OpenAI.LiveInputAudioUnmuteParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveInputAudioUnmuteParam?(LiveSidebandClientEvent @this) => @this.SessionInputAudioUnmute;

        /// <summary>
        ///
        /// </summary>
        public LiveSidebandClientEvent(global::tryAGI.OpenAI.LiveInputAudioUnmuteParam? value)
        {
            SessionInputAudioUnmute = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveSidebandClientEvent FromSessionInputAudioUnmute(global::tryAGI.OpenAI.LiveInputAudioUnmuteParam? value) => new LiveSidebandClientEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveSidebandClientEvent(global::tryAGI.OpenAI.LiveInstructionsAppendParam value) => new LiveSidebandClientEvent((global::tryAGI.OpenAI.LiveInstructionsAppendParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveInstructionsAppendParam?(LiveSidebandClientEvent @this) => @this.SessionInstructionsAppend;

        /// <summary>
        ///
        /// </summary>
        public LiveSidebandClientEvent(global::tryAGI.OpenAI.LiveInstructionsAppendParam? value)
        {
            SessionInstructionsAppend = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveSidebandClientEvent FromSessionInstructionsAppend(global::tryAGI.OpenAI.LiveInstructionsAppendParam? value) => new LiveSidebandClientEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveSidebandClientEvent(global::tryAGI.OpenAI.LiveThinkingAppendParam value) => new LiveSidebandClientEvent((global::tryAGI.OpenAI.LiveThinkingAppendParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveThinkingAppendParam?(LiveSidebandClientEvent @this) => @this.SessionThinkingAppend;

        /// <summary>
        ///
        /// </summary>
        public LiveSidebandClientEvent(global::tryAGI.OpenAI.LiveThinkingAppendParam? value)
        {
            SessionThinkingAppend = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveSidebandClientEvent FromSessionThinkingAppend(global::tryAGI.OpenAI.LiveThinkingAppendParam? value) => new LiveSidebandClientEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveSidebandClientEvent(global::tryAGI.OpenAI.LiveCommentaryAppendParam value) => new LiveSidebandClientEvent((global::tryAGI.OpenAI.LiveCommentaryAppendParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveCommentaryAppendParam?(LiveSidebandClientEvent @this) => @this.SessionCommentaryAppend;

        /// <summary>
        ///
        /// </summary>
        public LiveSidebandClientEvent(global::tryAGI.OpenAI.LiveCommentaryAppendParam? value)
        {
            SessionCommentaryAppend = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveSidebandClientEvent FromSessionCommentaryAppend(global::tryAGI.OpenAI.LiveCommentaryAppendParam? value) => new LiveSidebandClientEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveSidebandClientEvent(global::tryAGI.OpenAI.LiveResponseItemCreateParam value) => new LiveSidebandClientEvent((global::tryAGI.OpenAI.LiveResponseItemCreateParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveResponseItemCreateParam?(LiveSidebandClientEvent @this) => @this.ResponseItemCreate;

        /// <summary>
        ///
        /// </summary>
        public LiveSidebandClientEvent(global::tryAGI.OpenAI.LiveResponseItemCreateParam? value)
        {
            ResponseItemCreate = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveSidebandClientEvent FromResponseItemCreate(global::tryAGI.OpenAI.LiveResponseItemCreateParam? value) => new LiveSidebandClientEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveSidebandClientEvent(global::tryAGI.OpenAI.LiveResponseCreateParam value) => new LiveSidebandClientEvent((global::tryAGI.OpenAI.LiveResponseCreateParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveResponseCreateParam?(LiveSidebandClientEvent @this) => @this.ResponseCreate;

        /// <summary>
        ///
        /// </summary>
        public LiveSidebandClientEvent(global::tryAGI.OpenAI.LiveResponseCreateParam? value)
        {
            ResponseCreate = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveSidebandClientEvent FromResponseCreate(global::tryAGI.OpenAI.LiveResponseCreateParam? value) => new LiveSidebandClientEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveSidebandClientEvent(global::tryAGI.OpenAI.LiveSessionCloseParam value) => new LiveSidebandClientEvent((global::tryAGI.OpenAI.LiveSessionCloseParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveSessionCloseParam?(LiveSidebandClientEvent @this) => @this.SessionClose;

        /// <summary>
        ///
        /// </summary>
        public LiveSidebandClientEvent(global::tryAGI.OpenAI.LiveSessionCloseParam? value)
        {
            SessionClose = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveSidebandClientEvent FromSessionClose(global::tryAGI.OpenAI.LiveSessionCloseParam? value) => new LiveSidebandClientEvent(value);

        /// <summary>
        ///
        /// </summary>
        public LiveSidebandClientEvent(
            global::tryAGI.OpenAI.LiveSidebandClientEventDiscriminatorType? type,
            global::tryAGI.OpenAI.LiveSessionUpdateParam? sessionUpdate,
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

            SessionUpdate = sessionUpdate;
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
            SessionUpdate as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            SessionUpdate?.ToString() ??
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
            return IsSessionUpdate && !IsSessionInputAudioMute && !IsSessionInputAudioUnmute && !IsSessionInstructionsAppend && !IsSessionThinkingAppend && !IsSessionCommentaryAppend && !IsResponseItemCreate && !IsResponseCreate && !IsSessionClose || !IsSessionUpdate && IsSessionInputAudioMute && !IsSessionInputAudioUnmute && !IsSessionInstructionsAppend && !IsSessionThinkingAppend && !IsSessionCommentaryAppend && !IsResponseItemCreate && !IsResponseCreate && !IsSessionClose || !IsSessionUpdate && !IsSessionInputAudioMute && IsSessionInputAudioUnmute && !IsSessionInstructionsAppend && !IsSessionThinkingAppend && !IsSessionCommentaryAppend && !IsResponseItemCreate && !IsResponseCreate && !IsSessionClose || !IsSessionUpdate && !IsSessionInputAudioMute && !IsSessionInputAudioUnmute && IsSessionInstructionsAppend && !IsSessionThinkingAppend && !IsSessionCommentaryAppend && !IsResponseItemCreate && !IsResponseCreate && !IsSessionClose || !IsSessionUpdate && !IsSessionInputAudioMute && !IsSessionInputAudioUnmute && !IsSessionInstructionsAppend && IsSessionThinkingAppend && !IsSessionCommentaryAppend && !IsResponseItemCreate && !IsResponseCreate && !IsSessionClose || !IsSessionUpdate && !IsSessionInputAudioMute && !IsSessionInputAudioUnmute && !IsSessionInstructionsAppend && !IsSessionThinkingAppend && IsSessionCommentaryAppend && !IsResponseItemCreate && !IsResponseCreate && !IsSessionClose || !IsSessionUpdate && !IsSessionInputAudioMute && !IsSessionInputAudioUnmute && !IsSessionInstructionsAppend && !IsSessionThinkingAppend && !IsSessionCommentaryAppend && IsResponseItemCreate && !IsResponseCreate && !IsSessionClose || !IsSessionUpdate && !IsSessionInputAudioMute && !IsSessionInputAudioUnmute && !IsSessionInstructionsAppend && !IsSessionThinkingAppend && !IsSessionCommentaryAppend && !IsResponseItemCreate && IsResponseCreate && !IsSessionClose || !IsSessionUpdate && !IsSessionInputAudioMute && !IsSessionInputAudioUnmute && !IsSessionInstructionsAppend && !IsSessionThinkingAppend && !IsSessionCommentaryAppend && !IsResponseItemCreate && !IsResponseCreate && IsSessionClose;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.LiveSessionUpdateParam, TResult>? sessionUpdate = null,
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

            if (IsSessionUpdate && sessionUpdate != null)
            {
                return sessionUpdate(SessionUpdate!);
            }
            else if (IsSessionInputAudioMute && sessionInputAudioMute != null)
            {
                return sessionInputAudioMute(SessionInputAudioMute!);
            }
            else if (IsSessionInputAudioUnmute && sessionInputAudioUnmute != null)
            {
                return sessionInputAudioUnmute(SessionInputAudioUnmute!);
            }
            else if (IsSessionInstructionsAppend && sessionInstructionsAppend != null)
            {
                return sessionInstructionsAppend(SessionInstructionsAppend!);
            }
            else if (IsSessionThinkingAppend && sessionThinkingAppend != null)
            {
                return sessionThinkingAppend(SessionThinkingAppend!);
            }
            else if (IsSessionCommentaryAppend && sessionCommentaryAppend != null)
            {
                return sessionCommentaryAppend(SessionCommentaryAppend!);
            }
            else if (IsResponseItemCreate && responseItemCreate != null)
            {
                return responseItemCreate(ResponseItemCreate!);
            }
            else if (IsResponseCreate && responseCreate != null)
            {
                return responseCreate(ResponseCreate!);
            }
            else if (IsSessionClose && sessionClose != null)
            {
                return sessionClose(SessionClose!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.LiveSessionUpdateParam>? sessionUpdate = null,

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

            if (IsSessionUpdate)
            {
                sessionUpdate?.Invoke(SessionUpdate!);
            }
            else if (IsSessionInputAudioMute)
            {
                sessionInputAudioMute?.Invoke(SessionInputAudioMute!);
            }
            else if (IsSessionInputAudioUnmute)
            {
                sessionInputAudioUnmute?.Invoke(SessionInputAudioUnmute!);
            }
            else if (IsSessionInstructionsAppend)
            {
                sessionInstructionsAppend?.Invoke(SessionInstructionsAppend!);
            }
            else if (IsSessionThinkingAppend)
            {
                sessionThinkingAppend?.Invoke(SessionThinkingAppend!);
            }
            else if (IsSessionCommentaryAppend)
            {
                sessionCommentaryAppend?.Invoke(SessionCommentaryAppend!);
            }
            else if (IsResponseItemCreate)
            {
                responseItemCreate?.Invoke(ResponseItemCreate!);
            }
            else if (IsResponseCreate)
            {
                responseCreate?.Invoke(ResponseCreate!);
            }
            else if (IsSessionClose)
            {
                sessionClose?.Invoke(SessionClose!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.LiveSessionUpdateParam>? sessionUpdate = null,
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

            if (IsSessionUpdate)
            {
                sessionUpdate?.Invoke(SessionUpdate!);
            }
            else if (IsSessionInputAudioMute)
            {
                sessionInputAudioMute?.Invoke(SessionInputAudioMute!);
            }
            else if (IsSessionInputAudioUnmute)
            {
                sessionInputAudioUnmute?.Invoke(SessionInputAudioUnmute!);
            }
            else if (IsSessionInstructionsAppend)
            {
                sessionInstructionsAppend?.Invoke(SessionInstructionsAppend!);
            }
            else if (IsSessionThinkingAppend)
            {
                sessionThinkingAppend?.Invoke(SessionThinkingAppend!);
            }
            else if (IsSessionCommentaryAppend)
            {
                sessionCommentaryAppend?.Invoke(SessionCommentaryAppend!);
            }
            else if (IsResponseItemCreate)
            {
                responseItemCreate?.Invoke(ResponseItemCreate!);
            }
            else if (IsResponseCreate)
            {
                responseCreate?.Invoke(ResponseCreate!);
            }
            else if (IsSessionClose)
            {
                sessionClose?.Invoke(SessionClose!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SessionUpdate,
                typeof(global::tryAGI.OpenAI.LiveSessionUpdateParam),
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
        public bool Equals(LiveSidebandClientEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveSessionUpdateParam?>.Default.Equals(SessionUpdate, other.SessionUpdate) &&
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
        public static bool operator ==(LiveSidebandClientEvent obj1, LiveSidebandClientEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LiveSidebandClientEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(LiveSidebandClientEvent obj1, LiveSidebandClientEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LiveSidebandClientEvent o && Equals(o);
        }
    }
}
