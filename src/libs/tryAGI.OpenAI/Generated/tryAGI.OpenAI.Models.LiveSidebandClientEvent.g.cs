#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Client events accepted by an attached Live sideband WebSocket. The session has already started. Send input audio over the primary connection.
    /// </summary>
    public readonly partial struct LiveSidebandClientEvent : global::System.IEquatable<LiveSidebandClientEvent>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandClientEventDiscriminatorType? Type { get; }

        /// <summary>
        /// Update the delegation settings or transcript triggers of an active Live session. The server acknowledges accepted changes with `session.updated`.<br/>
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
        /// Resume audio input to a Live model after muting it. The server acknowledges with `session.input_audio.unmuted`. An active audio fixture still pauses inference until playback finishes.<br/>
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
        /// Play one complete audio fixture through the session output. Send this event over the primary WebSocket or a server sideband. Audio must be raw mono PCM16 little-endian at 24 kHz, regardless of the session audio format, and at most 30 seconds. The entire payload is validated before model speech is interrupted and input is muted. Only one fixture can be active. fixture.playing acknowledges acceptance and fixture.played reports server mixer drain. These notifications are not exact transport-media boundaries. Input arriving during playback is dropped and not replayed.<br/>
        /// Example: {"type":"session.output_audio.fixture.play","event_id":"evt_play_001","audio":"AAAAAA=="}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveOutputAudioFixturePlayParam? SessionOutputAudioFixturePlay { get; init; }
#else
        public global::tryAGI.OpenAI.LiveOutputAudioFixturePlayParam? SessionOutputAudioFixturePlay { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionOutputAudioFixturePlay))]
#endif
        public bool IsSessionOutputAudioFixturePlay => SessionOutputAudioFixturePlay != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSessionOutputAudioFixturePlay(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveOutputAudioFixturePlayParam? value)
        {
            value = SessionOutputAudioFixturePlay;
            return IsSessionOutputAudioFixturePlay;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputAudioFixturePlayParam PickSessionOutputAudioFixturePlay() => SessionOutputAudioFixturePlay is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionOutputAudioFixturePlay' but the value was {ToString()}.");

        /// <summary>
        /// Send one DTMF keypress to the SIP trunk through a Live sideband connection. This command is supported only for SIP calls. A successful send emits `transport.dtmf.sent` on sideband. If you provide `event_id`, the success notification includes it as `client_event_id`; a failure includes it as `error.client_event_id`. Send separate events for multiple keypresses.<br/>
        /// Example: {"type":"transport.dtmf.send","event_id":"evt_dtmf_001","event":"#"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveTransportDTMFSendParam? TransportDtmfSend { get; init; }
#else
        public global::tryAGI.OpenAI.LiveTransportDTMFSendParam? TransportDtmfSend { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TransportDtmfSend))]
#endif
        public bool IsTransportDtmfSend => TransportDtmfSend != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTransportDtmfSend(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveTransportDTMFSendParam? value)
        {
            value = TransportDtmfSend;
            return IsTransportDtmfSend;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportDTMFSendParam PickTransportDtmfSend() => TransportDtmfSend is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TransportDtmfSend' but the value was {ToString()}.");

        /// <summary>
        /// Append developer instructions to the Live conversation while it is running, optionally associating them with an existing client delegation. Rejected while an audio fixture is active. These instructions remain in conversation history through compaction and are included in future backend delegations. For external audio, describe content already delivered so the assistant does not repeat it.<br/>
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
        /// Provide silent reasoning or progress context to the Live model, optionally for an existing client delegation. Rejected while an audio fixture is active.<br/>
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
        /// Provide context the Live model can communicate to the user, optionally for an existing client delegation. Rejected while an audio fixture is active.<br/>
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
        /// Evaluate the configured questions using the current conversation and Decision inputs. Reusing an event_id is rejected for the lifetime of the session.<br/>
        /// Example: {"type":"decision.create","event_id":"decision_1"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveDecisionCreateParam? DecisionCreate { get; init; }
#else
        public global::tryAGI.OpenAI.LiveDecisionCreateParam? DecisionCreate { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DecisionCreate))]
#endif
        public bool IsDecisionCreate => DecisionCreate != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDecisionCreate(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveDecisionCreateParam? value)
        {
            value = DecisionCreate;
            return IsDecisionCreate;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionCreateParam PickDecisionCreate() => DecisionCreate is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DecisionCreate' but the value was {ToString()}.");

        /// <summary>
        /// Append an input item for future decisions without starting an evaluation or changing Live voice context.<br/>
        /// Example: {"type":"decision.item.create","event_id":"browser_1","item":{"type":"message","role":"user","content":[{"type":"input_text","text":"Wikipedia is open."}]}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveDecisionItemCreateParam? DecisionItemCreate { get; init; }
#else
        public global::tryAGI.OpenAI.LiveDecisionItemCreateParam? DecisionItemCreate { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DecisionItemCreate))]
#endif
        public bool IsDecisionItemCreate => DecisionItemCreate != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDecisionItemCreate(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveDecisionItemCreateParam? value)
        {
            value = DecisionItemCreate;
            return IsDecisionItemCreate;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionItemCreateParam PickDecisionItemCreate() => DecisionItemCreate is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DecisionItemCreate' but the value was {ToString()}.");

        /// <summary>
        /// Delete an input item from future decisions without starting an evaluation or changing Live voice context.<br/>
        /// Example: {"type":"decision.item.delete","event_id":"remove_browser_1","item_id":"msg_browser_1"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveDecisionItemDeleteParam? DecisionItemDelete { get; init; }
#else
        public global::tryAGI.OpenAI.LiveDecisionItemDeleteParam? DecisionItemDelete { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DecisionItemDelete))]
#endif
        public bool IsDecisionItemDelete => DecisionItemDelete != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDecisionItemDelete(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveDecisionItemDeleteParam? value)
        {
            value = DecisionItemDelete;
            return IsDecisionItemDelete;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionItemDeleteParam PickDecisionItemDelete() => DecisionItemDelete is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DecisionItemDelete' but the value was {ToString()}.");

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
        public static implicit operator LiveSidebandClientEvent(global::tryAGI.OpenAI.LiveOutputAudioFixturePlayParam value) => new LiveSidebandClientEvent((global::tryAGI.OpenAI.LiveOutputAudioFixturePlayParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveOutputAudioFixturePlayParam?(LiveSidebandClientEvent @this) => @this.SessionOutputAudioFixturePlay;

        /// <summary>
        ///
        /// </summary>
        public LiveSidebandClientEvent(global::tryAGI.OpenAI.LiveOutputAudioFixturePlayParam? value)
        {
            SessionOutputAudioFixturePlay = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveSidebandClientEvent FromSessionOutputAudioFixturePlay(global::tryAGI.OpenAI.LiveOutputAudioFixturePlayParam? value) => new LiveSidebandClientEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveSidebandClientEvent(global::tryAGI.OpenAI.LiveTransportDTMFSendParam value) => new LiveSidebandClientEvent((global::tryAGI.OpenAI.LiveTransportDTMFSendParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveTransportDTMFSendParam?(LiveSidebandClientEvent @this) => @this.TransportDtmfSend;

        /// <summary>
        ///
        /// </summary>
        public LiveSidebandClientEvent(global::tryAGI.OpenAI.LiveTransportDTMFSendParam? value)
        {
            TransportDtmfSend = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveSidebandClientEvent FromTransportDtmfSend(global::tryAGI.OpenAI.LiveTransportDTMFSendParam? value) => new LiveSidebandClientEvent(value);

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
        public static implicit operator LiveSidebandClientEvent(global::tryAGI.OpenAI.LiveDecisionCreateParam value) => new LiveSidebandClientEvent((global::tryAGI.OpenAI.LiveDecisionCreateParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveDecisionCreateParam?(LiveSidebandClientEvent @this) => @this.DecisionCreate;

        /// <summary>
        ///
        /// </summary>
        public LiveSidebandClientEvent(global::tryAGI.OpenAI.LiveDecisionCreateParam? value)
        {
            DecisionCreate = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveSidebandClientEvent FromDecisionCreate(global::tryAGI.OpenAI.LiveDecisionCreateParam? value) => new LiveSidebandClientEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveSidebandClientEvent(global::tryAGI.OpenAI.LiveDecisionItemCreateParam value) => new LiveSidebandClientEvent((global::tryAGI.OpenAI.LiveDecisionItemCreateParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveDecisionItemCreateParam?(LiveSidebandClientEvent @this) => @this.DecisionItemCreate;

        /// <summary>
        ///
        /// </summary>
        public LiveSidebandClientEvent(global::tryAGI.OpenAI.LiveDecisionItemCreateParam? value)
        {
            DecisionItemCreate = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveSidebandClientEvent FromDecisionItemCreate(global::tryAGI.OpenAI.LiveDecisionItemCreateParam? value) => new LiveSidebandClientEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveSidebandClientEvent(global::tryAGI.OpenAI.LiveDecisionItemDeleteParam value) => new LiveSidebandClientEvent((global::tryAGI.OpenAI.LiveDecisionItemDeleteParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveDecisionItemDeleteParam?(LiveSidebandClientEvent @this) => @this.DecisionItemDelete;

        /// <summary>
        ///
        /// </summary>
        public LiveSidebandClientEvent(global::tryAGI.OpenAI.LiveDecisionItemDeleteParam? value)
        {
            DecisionItemDelete = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveSidebandClientEvent FromDecisionItemDelete(global::tryAGI.OpenAI.LiveDecisionItemDeleteParam? value) => new LiveSidebandClientEvent(value);

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
            global::tryAGI.OpenAI.LiveOutputAudioFixturePlayParam? sessionOutputAudioFixturePlay,
            global::tryAGI.OpenAI.LiveTransportDTMFSendParam? transportDtmfSend,
            global::tryAGI.OpenAI.LiveInstructionsAppendParam? sessionInstructionsAppend,
            global::tryAGI.OpenAI.LiveThinkingAppendParam? sessionThinkingAppend,
            global::tryAGI.OpenAI.LiveCommentaryAppendParam? sessionCommentaryAppend,
            global::tryAGI.OpenAI.LiveDecisionCreateParam? decisionCreate,
            global::tryAGI.OpenAI.LiveDecisionItemCreateParam? decisionItemCreate,
            global::tryAGI.OpenAI.LiveDecisionItemDeleteParam? decisionItemDelete,
            global::tryAGI.OpenAI.LiveResponseItemCreateParam? responseItemCreate,
            global::tryAGI.OpenAI.LiveResponseCreateParam? responseCreate,
            global::tryAGI.OpenAI.LiveSessionCloseParam? sessionClose
            )
        {
            Type = type;

            SessionUpdate = sessionUpdate;
            SessionInputAudioMute = sessionInputAudioMute;
            SessionInputAudioUnmute = sessionInputAudioUnmute;
            SessionOutputAudioFixturePlay = sessionOutputAudioFixturePlay;
            TransportDtmfSend = transportDtmfSend;
            SessionInstructionsAppend = sessionInstructionsAppend;
            SessionThinkingAppend = sessionThinkingAppend;
            SessionCommentaryAppend = sessionCommentaryAppend;
            DecisionCreate = decisionCreate;
            DecisionItemCreate = decisionItemCreate;
            DecisionItemDelete = decisionItemDelete;
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
            DecisionItemDelete as object ??
            DecisionItemCreate as object ??
            DecisionCreate as object ??
            SessionCommentaryAppend as object ??
            SessionThinkingAppend as object ??
            SessionInstructionsAppend as object ??
            TransportDtmfSend as object ??
            SessionOutputAudioFixturePlay as object ??
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
            SessionOutputAudioFixturePlay?.ToString() ??
            TransportDtmfSend?.ToString() ??
            SessionInstructionsAppend?.ToString() ??
            SessionThinkingAppend?.ToString() ??
            SessionCommentaryAppend?.ToString() ??
            DecisionCreate?.ToString() ??
            DecisionItemCreate?.ToString() ??
            DecisionItemDelete?.ToString() ??
            ResponseItemCreate?.ToString() ??
            ResponseCreate?.ToString() ??
            SessionClose?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSessionUpdate && !IsSessionInputAudioMute && !IsSessionInputAudioUnmute && !IsSessionOutputAudioFixturePlay && !IsTransportDtmfSend && !IsSessionInstructionsAppend && !IsSessionThinkingAppend && !IsSessionCommentaryAppend && !IsDecisionCreate && !IsDecisionItemCreate && !IsDecisionItemDelete && !IsResponseItemCreate && !IsResponseCreate && !IsSessionClose || !IsSessionUpdate && IsSessionInputAudioMute && !IsSessionInputAudioUnmute && !IsSessionOutputAudioFixturePlay && !IsTransportDtmfSend && !IsSessionInstructionsAppend && !IsSessionThinkingAppend && !IsSessionCommentaryAppend && !IsDecisionCreate && !IsDecisionItemCreate && !IsDecisionItemDelete && !IsResponseItemCreate && !IsResponseCreate && !IsSessionClose || !IsSessionUpdate && !IsSessionInputAudioMute && IsSessionInputAudioUnmute && !IsSessionOutputAudioFixturePlay && !IsTransportDtmfSend && !IsSessionInstructionsAppend && !IsSessionThinkingAppend && !IsSessionCommentaryAppend && !IsDecisionCreate && !IsDecisionItemCreate && !IsDecisionItemDelete && !IsResponseItemCreate && !IsResponseCreate && !IsSessionClose || !IsSessionUpdate && !IsSessionInputAudioMute && !IsSessionInputAudioUnmute && IsSessionOutputAudioFixturePlay && !IsTransportDtmfSend && !IsSessionInstructionsAppend && !IsSessionThinkingAppend && !IsSessionCommentaryAppend && !IsDecisionCreate && !IsDecisionItemCreate && !IsDecisionItemDelete && !IsResponseItemCreate && !IsResponseCreate && !IsSessionClose || !IsSessionUpdate && !IsSessionInputAudioMute && !IsSessionInputAudioUnmute && !IsSessionOutputAudioFixturePlay && IsTransportDtmfSend && !IsSessionInstructionsAppend && !IsSessionThinkingAppend && !IsSessionCommentaryAppend && !IsDecisionCreate && !IsDecisionItemCreate && !IsDecisionItemDelete && !IsResponseItemCreate && !IsResponseCreate && !IsSessionClose || !IsSessionUpdate && !IsSessionInputAudioMute && !IsSessionInputAudioUnmute && !IsSessionOutputAudioFixturePlay && !IsTransportDtmfSend && IsSessionInstructionsAppend && !IsSessionThinkingAppend && !IsSessionCommentaryAppend && !IsDecisionCreate && !IsDecisionItemCreate && !IsDecisionItemDelete && !IsResponseItemCreate && !IsResponseCreate && !IsSessionClose || !IsSessionUpdate && !IsSessionInputAudioMute && !IsSessionInputAudioUnmute && !IsSessionOutputAudioFixturePlay && !IsTransportDtmfSend && !IsSessionInstructionsAppend && IsSessionThinkingAppend && !IsSessionCommentaryAppend && !IsDecisionCreate && !IsDecisionItemCreate && !IsDecisionItemDelete && !IsResponseItemCreate && !IsResponseCreate && !IsSessionClose || !IsSessionUpdate && !IsSessionInputAudioMute && !IsSessionInputAudioUnmute && !IsSessionOutputAudioFixturePlay && !IsTransportDtmfSend && !IsSessionInstructionsAppend && !IsSessionThinkingAppend && IsSessionCommentaryAppend && !IsDecisionCreate && !IsDecisionItemCreate && !IsDecisionItemDelete && !IsResponseItemCreate && !IsResponseCreate && !IsSessionClose || !IsSessionUpdate && !IsSessionInputAudioMute && !IsSessionInputAudioUnmute && !IsSessionOutputAudioFixturePlay && !IsTransportDtmfSend && !IsSessionInstructionsAppend && !IsSessionThinkingAppend && !IsSessionCommentaryAppend && IsDecisionCreate && !IsDecisionItemCreate && !IsDecisionItemDelete && !IsResponseItemCreate && !IsResponseCreate && !IsSessionClose || !IsSessionUpdate && !IsSessionInputAudioMute && !IsSessionInputAudioUnmute && !IsSessionOutputAudioFixturePlay && !IsTransportDtmfSend && !IsSessionInstructionsAppend && !IsSessionThinkingAppend && !IsSessionCommentaryAppend && !IsDecisionCreate && IsDecisionItemCreate && !IsDecisionItemDelete && !IsResponseItemCreate && !IsResponseCreate && !IsSessionClose || !IsSessionUpdate && !IsSessionInputAudioMute && !IsSessionInputAudioUnmute && !IsSessionOutputAudioFixturePlay && !IsTransportDtmfSend && !IsSessionInstructionsAppend && !IsSessionThinkingAppend && !IsSessionCommentaryAppend && !IsDecisionCreate && !IsDecisionItemCreate && IsDecisionItemDelete && !IsResponseItemCreate && !IsResponseCreate && !IsSessionClose || !IsSessionUpdate && !IsSessionInputAudioMute && !IsSessionInputAudioUnmute && !IsSessionOutputAudioFixturePlay && !IsTransportDtmfSend && !IsSessionInstructionsAppend && !IsSessionThinkingAppend && !IsSessionCommentaryAppend && !IsDecisionCreate && !IsDecisionItemCreate && !IsDecisionItemDelete && IsResponseItemCreate && !IsResponseCreate && !IsSessionClose || !IsSessionUpdate && !IsSessionInputAudioMute && !IsSessionInputAudioUnmute && !IsSessionOutputAudioFixturePlay && !IsTransportDtmfSend && !IsSessionInstructionsAppend && !IsSessionThinkingAppend && !IsSessionCommentaryAppend && !IsDecisionCreate && !IsDecisionItemCreate && !IsDecisionItemDelete && !IsResponseItemCreate && IsResponseCreate && !IsSessionClose || !IsSessionUpdate && !IsSessionInputAudioMute && !IsSessionInputAudioUnmute && !IsSessionOutputAudioFixturePlay && !IsTransportDtmfSend && !IsSessionInstructionsAppend && !IsSessionThinkingAppend && !IsSessionCommentaryAppend && !IsDecisionCreate && !IsDecisionItemCreate && !IsDecisionItemDelete && !IsResponseItemCreate && !IsResponseCreate && IsSessionClose;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.LiveSessionUpdateParam, TResult>? sessionUpdate = null,
            global::System.Func<global::tryAGI.OpenAI.LiveInputAudioMuteParam, TResult>? sessionInputAudioMute = null,
            global::System.Func<global::tryAGI.OpenAI.LiveInputAudioUnmuteParam, TResult>? sessionInputAudioUnmute = null,
            global::System.Func<global::tryAGI.OpenAI.LiveOutputAudioFixturePlayParam, TResult>? sessionOutputAudioFixturePlay = null,
            global::System.Func<global::tryAGI.OpenAI.LiveTransportDTMFSendParam, TResult>? transportDtmfSend = null,
            global::System.Func<global::tryAGI.OpenAI.LiveInstructionsAppendParam, TResult>? sessionInstructionsAppend = null,
            global::System.Func<global::tryAGI.OpenAI.LiveThinkingAppendParam, TResult>? sessionThinkingAppend = null,
            global::System.Func<global::tryAGI.OpenAI.LiveCommentaryAppendParam, TResult>? sessionCommentaryAppend = null,
            global::System.Func<global::tryAGI.OpenAI.LiveDecisionCreateParam, TResult>? decisionCreate = null,
            global::System.Func<global::tryAGI.OpenAI.LiveDecisionItemCreateParam, TResult>? decisionItemCreate = null,
            global::System.Func<global::tryAGI.OpenAI.LiveDecisionItemDeleteParam, TResult>? decisionItemDelete = null,
            global::System.Func<global::tryAGI.OpenAI.LiveResponseItemCreateParam, TResult>? responseItemCreate = null,
            global::System.Func<global::tryAGI.OpenAI.LiveResponseCreateParam, TResult>? responseCreate = null,
            global::System.Func<global::tryAGI.OpenAI.LiveSessionCloseParam, TResult>? sessionClose = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SessionUpdate is { } __value0 && sessionUpdate != null)
            {
                return sessionUpdate(__value0);
            }
            else if (SessionInputAudioMute is { } __value1 && sessionInputAudioMute != null)
            {
                return sessionInputAudioMute(__value1);
            }
            else if (SessionInputAudioUnmute is { } __value2 && sessionInputAudioUnmute != null)
            {
                return sessionInputAudioUnmute(__value2);
            }
            else if (SessionOutputAudioFixturePlay is { } __value3 && sessionOutputAudioFixturePlay != null)
            {
                return sessionOutputAudioFixturePlay(__value3);
            }
            else if (TransportDtmfSend is { } __value4 && transportDtmfSend != null)
            {
                return transportDtmfSend(__value4);
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
            else if (DecisionCreate is { } __value8 && decisionCreate != null)
            {
                return decisionCreate(__value8);
            }
            else if (DecisionItemCreate is { } __value9 && decisionItemCreate != null)
            {
                return decisionItemCreate(__value9);
            }
            else if (DecisionItemDelete is { } __value10 && decisionItemDelete != null)
            {
                return decisionItemDelete(__value10);
            }
            else if (ResponseItemCreate is { } __value11 && responseItemCreate != null)
            {
                return responseItemCreate(__value11);
            }
            else if (ResponseCreate is { } __value12 && responseCreate != null)
            {
                return responseCreate(__value12);
            }
            else if (SessionClose is { } __value13 && sessionClose != null)
            {
                return sessionClose(__value13);
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

            global::System.Action<global::tryAGI.OpenAI.LiveOutputAudioFixturePlayParam>? sessionOutputAudioFixturePlay = null,

            global::System.Action<global::tryAGI.OpenAI.LiveTransportDTMFSendParam>? transportDtmfSend = null,

            global::System.Action<global::tryAGI.OpenAI.LiveInstructionsAppendParam>? sessionInstructionsAppend = null,

            global::System.Action<global::tryAGI.OpenAI.LiveThinkingAppendParam>? sessionThinkingAppend = null,

            global::System.Action<global::tryAGI.OpenAI.LiveCommentaryAppendParam>? sessionCommentaryAppend = null,

            global::System.Action<global::tryAGI.OpenAI.LiveDecisionCreateParam>? decisionCreate = null,

            global::System.Action<global::tryAGI.OpenAI.LiveDecisionItemCreateParam>? decisionItemCreate = null,

            global::System.Action<global::tryAGI.OpenAI.LiveDecisionItemDeleteParam>? decisionItemDelete = null,

            global::System.Action<global::tryAGI.OpenAI.LiveResponseItemCreateParam>? responseItemCreate = null,

            global::System.Action<global::tryAGI.OpenAI.LiveResponseCreateParam>? responseCreate = null,

            global::System.Action<global::tryAGI.OpenAI.LiveSessionCloseParam>? sessionClose = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SessionUpdate is { } __value0)
            {
                sessionUpdate?.Invoke(__value0);
            }
            else if (SessionInputAudioMute is { } __value1)
            {
                sessionInputAudioMute?.Invoke(__value1);
            }
            else if (SessionInputAudioUnmute is { } __value2)
            {
                sessionInputAudioUnmute?.Invoke(__value2);
            }
            else if (SessionOutputAudioFixturePlay is { } __value3)
            {
                sessionOutputAudioFixturePlay?.Invoke(__value3);
            }
            else if (TransportDtmfSend is { } __value4)
            {
                transportDtmfSend?.Invoke(__value4);
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
            else if (DecisionCreate is { } __value8)
            {
                decisionCreate?.Invoke(__value8);
            }
            else if (DecisionItemCreate is { } __value9)
            {
                decisionItemCreate?.Invoke(__value9);
            }
            else if (DecisionItemDelete is { } __value10)
            {
                decisionItemDelete?.Invoke(__value10);
            }
            else if (ResponseItemCreate is { } __value11)
            {
                responseItemCreate?.Invoke(__value11);
            }
            else if (ResponseCreate is { } __value12)
            {
                responseCreate?.Invoke(__value12);
            }
            else if (SessionClose is { } __value13)
            {
                sessionClose?.Invoke(__value13);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.LiveSessionUpdateParam>? sessionUpdate = null,
            global::System.Action<global::tryAGI.OpenAI.LiveInputAudioMuteParam>? sessionInputAudioMute = null,
            global::System.Action<global::tryAGI.OpenAI.LiveInputAudioUnmuteParam>? sessionInputAudioUnmute = null,
            global::System.Action<global::tryAGI.OpenAI.LiveOutputAudioFixturePlayParam>? sessionOutputAudioFixturePlay = null,
            global::System.Action<global::tryAGI.OpenAI.LiveTransportDTMFSendParam>? transportDtmfSend = null,
            global::System.Action<global::tryAGI.OpenAI.LiveInstructionsAppendParam>? sessionInstructionsAppend = null,
            global::System.Action<global::tryAGI.OpenAI.LiveThinkingAppendParam>? sessionThinkingAppend = null,
            global::System.Action<global::tryAGI.OpenAI.LiveCommentaryAppendParam>? sessionCommentaryAppend = null,
            global::System.Action<global::tryAGI.OpenAI.LiveDecisionCreateParam>? decisionCreate = null,
            global::System.Action<global::tryAGI.OpenAI.LiveDecisionItemCreateParam>? decisionItemCreate = null,
            global::System.Action<global::tryAGI.OpenAI.LiveDecisionItemDeleteParam>? decisionItemDelete = null,
            global::System.Action<global::tryAGI.OpenAI.LiveResponseItemCreateParam>? responseItemCreate = null,
            global::System.Action<global::tryAGI.OpenAI.LiveResponseCreateParam>? responseCreate = null,
            global::System.Action<global::tryAGI.OpenAI.LiveSessionCloseParam>? sessionClose = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SessionUpdate is { } __value0)
            {
                sessionUpdate?.Invoke(__value0);
            }
            else if (SessionInputAudioMute is { } __value1)
            {
                sessionInputAudioMute?.Invoke(__value1);
            }
            else if (SessionInputAudioUnmute is { } __value2)
            {
                sessionInputAudioUnmute?.Invoke(__value2);
            }
            else if (SessionOutputAudioFixturePlay is { } __value3)
            {
                sessionOutputAudioFixturePlay?.Invoke(__value3);
            }
            else if (TransportDtmfSend is { } __value4)
            {
                transportDtmfSend?.Invoke(__value4);
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
            else if (DecisionCreate is { } __value8)
            {
                decisionCreate?.Invoke(__value8);
            }
            else if (DecisionItemCreate is { } __value9)
            {
                decisionItemCreate?.Invoke(__value9);
            }
            else if (DecisionItemDelete is { } __value10)
            {
                decisionItemDelete?.Invoke(__value10);
            }
            else if (ResponseItemCreate is { } __value11)
            {
                responseItemCreate?.Invoke(__value11);
            }
            else if (ResponseCreate is { } __value12)
            {
                responseCreate?.Invoke(__value12);
            }
            else if (SessionClose is { } __value13)
            {
                sessionClose?.Invoke(__value13);
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
                SessionOutputAudioFixturePlay,
                typeof(global::tryAGI.OpenAI.LiveOutputAudioFixturePlayParam),
                TransportDtmfSend,
                typeof(global::tryAGI.OpenAI.LiveTransportDTMFSendParam),
                SessionInstructionsAppend,
                typeof(global::tryAGI.OpenAI.LiveInstructionsAppendParam),
                SessionThinkingAppend,
                typeof(global::tryAGI.OpenAI.LiveThinkingAppendParam),
                SessionCommentaryAppend,
                typeof(global::tryAGI.OpenAI.LiveCommentaryAppendParam),
                DecisionCreate,
                typeof(global::tryAGI.OpenAI.LiveDecisionCreateParam),
                DecisionItemCreate,
                typeof(global::tryAGI.OpenAI.LiveDecisionItemCreateParam),
                DecisionItemDelete,
                typeof(global::tryAGI.OpenAI.LiveDecisionItemDeleteParam),
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
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveOutputAudioFixturePlayParam?>.Default.Equals(SessionOutputAudioFixturePlay, other.SessionOutputAudioFixturePlay) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveTransportDTMFSendParam?>.Default.Equals(TransportDtmfSend, other.TransportDtmfSend) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveInstructionsAppendParam?>.Default.Equals(SessionInstructionsAppend, other.SessionInstructionsAppend) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveThinkingAppendParam?>.Default.Equals(SessionThinkingAppend, other.SessionThinkingAppend) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveCommentaryAppendParam?>.Default.Equals(SessionCommentaryAppend, other.SessionCommentaryAppend) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveDecisionCreateParam?>.Default.Equals(DecisionCreate, other.DecisionCreate) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveDecisionItemCreateParam?>.Default.Equals(DecisionItemCreate, other.DecisionItemCreate) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveDecisionItemDeleteParam?>.Default.Equals(DecisionItemDelete, other.DecisionItemDelete) &&
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
