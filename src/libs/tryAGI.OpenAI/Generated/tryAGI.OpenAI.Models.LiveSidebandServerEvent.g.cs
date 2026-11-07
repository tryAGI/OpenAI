#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Server events received by an attached Live sideband WebSocket. Audio deltas are delivered over the primary connection.
    /// </summary>
    public readonly partial struct LiveSidebandServerEvent : global::System.IEquatable<LiveSidebandServerEvent>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSidebandServerEventDiscriminatorType? Type { get; }

        /// <summary>
        /// The outbound SIP provider leg is ringing or providing early media. Delivered only to sideband observers.<br/>
        /// Example: {"type":"transport.ringing","event_id":"event_call_1","session_id":"live_u0_123"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveTransportRinging? TransportRinging { get; init; }
#else
        public global::tryAGI.OpenAI.LiveTransportRinging? TransportRinging { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TransportRinging))]
#endif
        public bool IsTransportRinging => TransportRinging != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTransportRinging(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveTransportRinging? value)
        {
            value = TransportRinging;
            return IsTransportRinging;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportRinging PickTransportRinging() => TransportRinging is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TransportRinging' but the value was {ToString()}.");

        /// <summary>
        /// The outbound SIP provider leg answered and media is established. Delivered only to sideband observers.<br/>
        /// Example: {"type":"transport.answered","event_id":"event_call_2","session_id":"live_u0_123"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveTransportAnswered? TransportAnswered { get; init; }
#else
        public global::tryAGI.OpenAI.LiveTransportAnswered? TransportAnswered { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TransportAnswered))]
#endif
        public bool IsTransportAnswered => TransportAnswered != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTransportAnswered(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveTransportAnswered? value)
        {
            value = TransportAnswered;
            return IsTransportAnswered;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportAnswered PickTransportAnswered() => TransportAnswered is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TransportAnswered' but the value was {ToString()}.");

        /// <summary>
        /// An asynchronous outbound SIP setup failure. Delivered only to sideband observers.<br/>
        /// Example: {"type":"transport.failed","event_id":"event_call_4","session_id":"live_u0_123","error":{"type":"call_error","code":"provider_invite_failed","message":"provider rejected the call","param":""}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveTransportFailed? TransportFailed { get; init; }
#else
        public global::tryAGI.OpenAI.LiveTransportFailed? TransportFailed { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TransportFailed))]
#endif
        public bool IsTransportFailed => TransportFailed != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTransportFailed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveTransportFailed? value)
        {
            value = TransportFailed;
            return IsTransportFailed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportFailed PickTransportFailed() => TransportFailed is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TransportFailed' but the value was {ToString()}.");

        /// <summary>
        /// A SIP DTMF keypress received from the caller. Delivered only to sideband observers.<br/>
        /// Example: {"type":"transport.dtmf.received","event_id":"event_dtmf_1","event":"5"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveTransportDTMFReceived? TransportDtmfReceived { get; init; }
#else
        public global::tryAGI.OpenAI.LiveTransportDTMFReceived? TransportDtmfReceived { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TransportDtmfReceived))]
#endif
        public bool IsTransportDtmfReceived => TransportDtmfReceived != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTransportDtmfReceived(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveTransportDTMFReceived? value)
        {
            value = TransportDtmfReceived;
            return IsTransportDtmfReceived;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportDTMFReceived PickTransportDtmfReceived() => TransportDtmfReceived is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TransportDtmfReceived' but the value was {ToString()}.");

        /// <summary>
        /// A SIP DTMF keypress successfully sent to the SIP trunk. Delivered only to sideband observers; this is not a client command.<br/>
        /// Example: {"type":"transport.dtmf.sent","event_id":"event_dtmf_2","event":"#"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveTransportDTMFSent? TransportDtmfSent { get; init; }
#else
        public global::tryAGI.OpenAI.LiveTransportDTMFSent? TransportDtmfSent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TransportDtmfSent))]
#endif
        public bool IsTransportDtmfSent => TransportDtmfSent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTransportDtmfSent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveTransportDTMFSent? value)
        {
            value = TransportDtmfSent;
            return IsTransportDtmfSent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportDTMFSent PickTransportDtmfSent() => TransportDtmfSent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TransportDtmfSent' but the value was {ToString()}.");

        /// <summary>
        /// Returned when a Live session has started. Contains the resolved session configuration, including server defaults.<br/>
        /// Example: {"type":"session.started","event_id":"evt_started_001","client_event_id":"evt_start_001","session":{"id":"live_abc123","model":"gpt-live-1","status":"active","expires_at":1788555600,"instructions":"Help the caller plan a restaurant reservation. Confirm details before booking.","input":[],"audio":{"format":{"type":"audio/pcm","rate":24000},"output":{"voice":"marin"}},"delegation":{"type":"client"}}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveSessionStarted? SessionStarted { get; init; }
#else
        public global::tryAGI.OpenAI.LiveSessionStarted? SessionStarted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionStarted))]
#endif
        public bool IsSessionStarted => SessionStarted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSessionStarted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveSessionStarted? value)
        {
            value = SessionStarted;
            return IsSessionStarted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionStarted PickSessionStarted() => SessionStarted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionStarted' but the value was {ToString()}.");

        /// <summary>
        /// Returned when a Live session update is accepted. Contains the resolved session configuration after the update.<br/>
        /// Example: {"type":"session.updated","event_id":"evt_updated_001","client_event_id":"evt_update_001","session":{"id":"live_def456","model":"gpt-live-1","status":"active","expires_at":1788555600,"instructions":"Help the caller plan a restaurant reservation. Confirm details before booking.","input":[],"audio":{"format":{"type":"audio/pcm","rate":24000},"output":{"voice":"marin"}},"delegation":{"type":"responses","responses":{"model":"gpt-6-astra","instructions":"Check restaurant availability. Ask before confirming a booking.","max_output_tokens":1024,"tools":[]}}}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveSessionUpdated? SessionUpdated { get; init; }
#else
        public global::tryAGI.OpenAI.LiveSessionUpdated? SessionUpdated { get; }
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
            out global::tryAGI.OpenAI.LiveSessionUpdated? value)
        {
            value = SessionUpdated;
            return IsSessionUpdated;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUpdated PickSessionUpdated() => SessionUpdated is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionUpdated' but the value was {ToString()}.");

        /// <summary>
        /// Acknowledges a session.input_audio.mute command. An independent input mute sends silence to the model and preserves sideband audio reflection. Fixture playback does not emit this event.<br/>
        /// Example: {"type":"session.input_audio.muted","event_id":"evt_muted_001","client_event_id":"evt_mute_001"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveInputAudioMuted? SessionInputAudioMuted { get; init; }
#else
        public global::tryAGI.OpenAI.LiveInputAudioMuted? SessionInputAudioMuted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionInputAudioMuted))]
#endif
        public bool IsSessionInputAudioMuted => SessionInputAudioMuted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSessionInputAudioMuted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveInputAudioMuted? value)
        {
            value = SessionInputAudioMuted;
            return IsSessionInputAudioMuted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioMuted PickSessionInputAudioMuted() => SessionInputAudioMuted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionInputAudioMuted' but the value was {ToString()}.");

        /// <summary>
        /// Acknowledges a session.input_audio.unmute command, removing the independent input mute. An active audio fixture still pauses inference until playback finishes. Fixture playback does not emit this event.<br/>
        /// Example: {"type":"session.input_audio.unmuted","event_id":"evt_unmuted_001","client_event_id":"evt_unmute_001"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveInputAudioUnmuted? SessionInputAudioUnmuted { get; init; }
#else
        public global::tryAGI.OpenAI.LiveInputAudioUnmuted? SessionInputAudioUnmuted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionInputAudioUnmuted))]
#endif
        public bool IsSessionInputAudioUnmuted => SessionInputAudioUnmuted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSessionInputAudioUnmuted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveInputAudioUnmuted? value)
        {
            value = SessionInputAudioUnmuted;
            return IsSessionInputAudioUnmuted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioUnmuted PickSessionInputAudioUnmuted() => SessionInputAudioUnmuted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionInputAudioUnmuted' but the value was {ToString()}.");

        /// <summary>
        /// The existing playback path has accepted the validated audio fixture. This acknowledgment does not identify when the listener receives the first sample. The optional client_event_id echoes the play command.<br/>
        /// Example: {"type":"session.output_audio.fixture.playing","event_id":"evt_playing_001","client_event_id":"evt_play_001"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveOutputAudioFixturePlaying? SessionOutputAudioFixturePlaying { get; init; }
#else
        public global::tryAGI.OpenAI.LiveOutputAudioFixturePlaying? SessionOutputAudioFixturePlaying { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionOutputAudioFixturePlaying))]
#endif
        public bool IsSessionOutputAudioFixturePlaying => SessionOutputAudioFixturePlaying != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSessionOutputAudioFixturePlaying(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveOutputAudioFixturePlaying? value)
        {
            value = SessionOutputAudioFixturePlaying;
            return IsSessionOutputAudioFixturePlaying;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputAudioFixturePlaying PickSessionOutputAudioFixturePlaying() => SessionOutputAudioFixturePlaying is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionOutputAudioFixturePlaying' but the value was {ToString()}.");

        /// <summary>
        /// The complete audio fixture has drained from the server mixer and normal inference has resumed. Transport buffers may still contain audio; this event does not prove listener-side completion. The optional client_event_id echoes the play command. This event is not emitted for canceled or failed playback.<br/>
        /// Example: {"type":"session.output_audio.fixture.played","event_id":"evt_played_001","client_event_id":"evt_play_001"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveOutputAudioFixturePlayed? SessionOutputAudioFixturePlayed { get; init; }
#else
        public global::tryAGI.OpenAI.LiveOutputAudioFixturePlayed? SessionOutputAudioFixturePlayed { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionOutputAudioFixturePlayed))]
#endif
        public bool IsSessionOutputAudioFixturePlayed => SessionOutputAudioFixturePlayed != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSessionOutputAudioFixturePlayed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveOutputAudioFixturePlayed? value)
        {
            value = SessionOutputAudioFixturePlayed;
            return IsSessionOutputAudioFixturePlayed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputAudioFixturePlayed PickSessionOutputAudioFixturePlayed() => SessionOutputAudioFixturePlayed is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionOutputAudioFixturePlayed' but the value was {ToString()}.");

        /// <summary>
        /// Returned when a session.instructions.append command is accepted into the Live session timeline. Acknowledges the appended instructions without guaranteeing that the model has acted on them.<br/>
        /// Example: {"type":"session.instructions.appended","event_id":"evt_instructions_002","client_event_id":"evt_instructions_001","start_ms":1200,"end_ms":1400}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveInstructionsAppended? SessionInstructionsAppended { get; init; }
#else
        public global::tryAGI.OpenAI.LiveInstructionsAppended? SessionInstructionsAppended { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionInstructionsAppended))]
#endif
        public bool IsSessionInstructionsAppended => SessionInstructionsAppended != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSessionInstructionsAppended(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveInstructionsAppended? value)
        {
            value = SessionInstructionsAppended;
            return IsSessionInstructionsAppended;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInstructionsAppended PickSessionInstructionsAppended() => SessionInstructionsAppended is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionInstructionsAppended' but the value was {ToString()}.");

        /// <summary>
        /// Returned when a session.thinking.append command is accepted into the Live session timeline. Acknowledges the added reasoning context without guaranteeing any spoken output.<br/>
        /// Example: {"type":"session.thinking.appended","event_id":"evt_thinking_002","client_event_id":"evt_thinking_001","start_ms":4600,"end_ms":4800}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveThinkingAppended? SessionThinkingAppended { get; init; }
#else
        public global::tryAGI.OpenAI.LiveThinkingAppended? SessionThinkingAppended { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionThinkingAppended))]
#endif
        public bool IsSessionThinkingAppended => SessionThinkingAppended != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSessionThinkingAppended(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveThinkingAppended? value)
        {
            value = SessionThinkingAppended;
            return IsSessionThinkingAppended;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveThinkingAppended PickSessionThinkingAppended() => SessionThinkingAppended is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionThinkingAppended' but the value was {ToString()}.");

        /// <summary>
        /// Returned when a session.commentary.append command is accepted into the Live session timeline. Acknowledges the added commentary without guaranteeing exact wording or completed audio playback.<br/>
        /// Example: {"type":"session.commentary.appended","event_id":"evt_commentary_002","client_event_id":"evt_commentary_001","start_ms":5200,"end_ms":5400}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveCommentaryAppended? SessionCommentaryAppended { get; init; }
#else
        public global::tryAGI.OpenAI.LiveCommentaryAppended? SessionCommentaryAppended { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionCommentaryAppended))]
#endif
        public bool IsSessionCommentaryAppended => SessionCommentaryAppended != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSessionCommentaryAppended(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveCommentaryAppended? value)
        {
            value = SessionCommentaryAppended;
            return IsSessionCommentaryAppended;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCommentaryAppended PickSessionCommentaryAppended() => SessionCommentaryAppended is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionCommentaryAppended' but the value was {ToString()}.");

        /// <summary>
        /// A transcript fragment for user input audio in the Live session. Accumulate fragments in delivery order; these events do not define complete turns or include a transcript-done event.<br/>
        /// Example: {"type":"session.input_transcript.delta","event_id":"evt_input_transcript_001","delta":"A table for two at seven, please.","start_ms":1600,"end_ms":3400}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveInputTranscriptDelta? SessionInputTranscriptDelta { get; init; }
#else
        public global::tryAGI.OpenAI.LiveInputTranscriptDelta? SessionInputTranscriptDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionInputTranscriptDelta))]
#endif
        public bool IsSessionInputTranscriptDelta => SessionInputTranscriptDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSessionInputTranscriptDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveInputTranscriptDelta? value)
        {
            value = SessionInputTranscriptDelta;
            return IsSessionInputTranscriptDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputTranscriptDelta PickSessionInputTranscriptDelta() => SessionInputTranscriptDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionInputTranscriptDelta' but the value was {ToString()}.");

        /// <summary>
        /// A transcript fragment for assistant output audio in the Live session. Accumulate fragments in delivery order; these events do not define complete turns or include a transcript-done event.<br/>
        /// Example: {"type":"session.output_transcript.delta","event_id":"evt_output_transcript_001","delta":"Would you like me to reserve that table?","start_ms":5400,"end_ms":7200}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveOutputTranscriptDelta? SessionOutputTranscriptDelta { get; init; }
#else
        public global::tryAGI.OpenAI.LiveOutputTranscriptDelta? SessionOutputTranscriptDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionOutputTranscriptDelta))]
#endif
        public bool IsSessionOutputTranscriptDelta => SessionOutputTranscriptDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSessionOutputTranscriptDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveOutputTranscriptDelta? value)
        {
            value = SessionOutputTranscriptDelta;
            return IsSessionOutputTranscriptDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputTranscriptDelta PickSessionOutputTranscriptDelta() => SessionOutputTranscriptDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionOutputTranscriptDelta' but the value was {ToString()}.");

        /// <summary>
        /// Returned when the Live model delegates work to your application, Responses, or Decisions. Contains delegation metadata and the position on the session timeline where the work was delegated.<br/>
        /// Example: {"type":"session.delegation.created","event_id":"evt_delegation_001","offset_ms":3600,"delegation":{"id":"del_abc123","type":"delegation","target":"client"}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveDelegationCreated? SessionDelegationCreated { get; init; }
#else
        public global::tryAGI.OpenAI.LiveDelegationCreated? SessionDelegationCreated { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionDelegationCreated))]
#endif
        public bool IsSessionDelegationCreated => SessionDelegationCreated != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSessionDelegationCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveDelegationCreated? value)
        {
            value = SessionDelegationCreated;
            return IsSessionDelegationCreated;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDelegationCreated PickSessionDelegationCreated() => SessionDelegationCreated is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionDelegationCreated' but the value was {ToString()}.");

        /// <summary>
        /// A Decision API event for a Live delegation or transcript trigger. For a trigger, source_event_id identifies the transcript delta that caused this evaluation.<br/>
        /// Example: {"type":"decision.event","event_id":"evt_decision_1","delegation_id":"del_abc123","trigger_id":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","source_event_type":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","source_event_id":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","event":{"type":"decision.completed","decision":{"model":"gpt-6-luna","answers":[{"type":"predicate","name":"damaged","probability":0.95}],"usage":{"input_tokens":42,"input_tokens_details":{"cached_tokens":0,"cache_write_tokens":0},"output_tokens":0,"output_tokens_details":{"reasoning_tokens":0},"total_tokens":42}}}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveDecisionEvent? DecisionEvent { get; init; }
#else
        public global::tryAGI.OpenAI.LiveDecisionEvent? DecisionEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DecisionEvent))]
#endif
        public bool IsDecisionEvent => DecisionEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDecisionEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveDecisionEvent? value)
        {
            value = DecisionEvent;
            return IsDecisionEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionEvent PickDecisionEvent() => DecisionEvent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DecisionEvent' but the value was {ToString()}.");

        /// <summary>
        /// An input item was appended for future decisions.<br/>
        /// Example: {"type":"decision.item.created","event_id":"evt_item_1","client_event_id":"browser_1","item":{"id":"msg_browser_1","type":"message","role":"user","content":[{"type":"input_text","text":"Wikipedia is open."}]}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveDecisionItemCreated? DecisionItemCreated { get; init; }
#else
        public global::tryAGI.OpenAI.LiveDecisionItemCreated? DecisionItemCreated { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DecisionItemCreated))]
#endif
        public bool IsDecisionItemCreated => DecisionItemCreated != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDecisionItemCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveDecisionItemCreated? value)
        {
            value = DecisionItemCreated;
            return IsDecisionItemCreated;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionItemCreated PickDecisionItemCreated() => DecisionItemCreated is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DecisionItemCreated' but the value was {ToString()}.");

        /// <summary>
        /// An input item was removed from future decisions.<br/>
        /// Example: {"type":"decision.item.deleted","event_id":"evt_item_deleted_1","client_event_id":"remove_browser_1","item_id":"msg_browser_1"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveDecisionItemDeleted? DecisionItemDeleted { get; init; }
#else
        public global::tryAGI.OpenAI.LiveDecisionItemDeleted? DecisionItemDeleted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DecisionItemDeleted))]
#endif
        public bool IsDecisionItemDeleted => DecisionItemDeleted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDecisionItemDeleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveDecisionItemDeleted? value)
        {
            value = DecisionItemDeleted;
            return IsDecisionItemDeleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionItemDeleted PickDecisionItemDeleted() => DecisionItemDeleted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DecisionItemDeleted' but the value was {ToString()}.");

        /// <summary>
        /// A streaming Responses API event from a backend delegated to by the Live session. Use the outer delegation_id to associate the nested stream with its Live delegation.<br/>
        /// Example: {"type":"response.event","event_id":"evt_response_002","delegation_id":"del_responses123","event":{"type":"response.output_text.delta","item_id":"msg_abc123","output_index":0,"content_index":0,"delta":"An outdoor table is available at 7 PM.","sequence_number":3,"logprobs":[]}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveResponseEvent? ResponseEvent { get; init; }
#else
        public global::tryAGI.OpenAI.LiveResponseEvent? ResponseEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseEvent))]
#endif
        public bool IsResponseEvent => ResponseEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveResponseEvent? value)
        {
            value = ResponseEvent;
            return IsResponseEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponseEvent PickResponseEvent() => ResponseEvent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseEvent' but the value was {ToString()}.");

        /// <summary>
        /// Reports cumulative Live audio usage and, when available, the most recent context-window usage. Delegated Responses token usage is reported separately in response.event events.<br/>
        /// Example: {"type":"session.usage.updated","event_id":"evt_usage_001","usage":{"seconds":32.5},"context_window":{"usage_ratio":0.12}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveSessionUsageUpdated? SessionUsageUpdated { get; init; }
#else
        public global::tryAGI.OpenAI.LiveSessionUsageUpdated? SessionUsageUpdated { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionUsageUpdated))]
#endif
        public bool IsSessionUsageUpdated => SessionUsageUpdated != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSessionUsageUpdated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveSessionUsageUpdated? value)
        {
            value = SessionUsageUpdated;
            return IsSessionUsageUpdated;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUsageUpdated PickSessionUsageUpdated() => SessionUsageUpdated is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionUsageUpdated' but the value was {ToString()}.");

        /// <summary>
        /// Returned after the Live session finishes finalizing, with the close reason, final session snapshot, and cumulative audio usage. A connection closing without this event does not confirm successful finalization.<br/>
        /// Example: {"type":"session.closed","event_id":"evt_closed_001","client_event_id":"evt_close_001","reason":"close_requested","session":{"id":"live_abc123","model":"gpt-live-1","status":"active","expires_at":1788555600,"instructions":"Help the caller plan a restaurant reservation. Confirm details before booking.","input":[],"audio":{"format":{"type":"audio/pcm","rate":24000},"output":{"voice":"marin"}},"delegation":{"type":"client"}},"usage":{"seconds":45.8}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveSessionClosed? SessionClosed { get; init; }
#else
        public global::tryAGI.OpenAI.LiveSessionClosed? SessionClosed { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionClosed))]
#endif
        public bool IsSessionClosed => SessionClosed != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSessionClosed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveSessionClosed? value)
        {
            value = SessionClosed;
            return IsSessionClosed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionClosed PickSessionClosed() => SessionClosed is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionClosed' but the value was {ToString()}.");

        /// <summary>
        /// Reports an error in the Live session, such as an invalid client command. Use error.client_event_id, when present, to identify the command that caused the error.<br/>
        /// Example: {"type":"error","event_id":"evt_error_001","error":{"type":"invalid_request_error","code":"unknown_parameter","message":"Unknown parameter: \u0027session.voice\u0027.","param":"session.voice","client_event_id":"evt_invalid_001"}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveErrorEvent? Error { get; init; }
#else
        public global::tryAGI.OpenAI.LiveErrorEvent? Error { get; }
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
            out global::tryAGI.OpenAI.LiveErrorEvent? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveErrorEvent PickError() => Error is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Error' but the value was {ToString()}.");

        /// <summary>
        /// An informational notice about the Live session, such as the event permissions applied to a frontend data channel.<br/>
        /// Example: {"type":"info","event_id":"evt_info_001","code":"data_channel_permissions","message":"The frontend data channel is configured with restricted event permissions."}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveInfoEvent? Info { get; init; }
#else
        public global::tryAGI.OpenAI.LiveInfoEvent? Info { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Info))]
#endif
        public bool IsInfo => Info != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInfo(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveInfoEvent? value)
        {
            value = Info;
            return IsInfo;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInfoEvent PickInfo() => Info is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Info' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveTransportRinging value) => new LiveSidebandServerEvent((global::tryAGI.OpenAI.LiveTransportRinging?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveTransportRinging?(LiveSidebandServerEvent @this) => @this.TransportRinging;

        /// <summary>
        ///
        /// </summary>
        public LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveTransportRinging? value)
        {
            TransportRinging = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveSidebandServerEvent FromTransportRinging(global::tryAGI.OpenAI.LiveTransportRinging? value) => new LiveSidebandServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveTransportAnswered value) => new LiveSidebandServerEvent((global::tryAGI.OpenAI.LiveTransportAnswered?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveTransportAnswered?(LiveSidebandServerEvent @this) => @this.TransportAnswered;

        /// <summary>
        ///
        /// </summary>
        public LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveTransportAnswered? value)
        {
            TransportAnswered = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveSidebandServerEvent FromTransportAnswered(global::tryAGI.OpenAI.LiveTransportAnswered? value) => new LiveSidebandServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveTransportFailed value) => new LiveSidebandServerEvent((global::tryAGI.OpenAI.LiveTransportFailed?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveTransportFailed?(LiveSidebandServerEvent @this) => @this.TransportFailed;

        /// <summary>
        ///
        /// </summary>
        public LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveTransportFailed? value)
        {
            TransportFailed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveSidebandServerEvent FromTransportFailed(global::tryAGI.OpenAI.LiveTransportFailed? value) => new LiveSidebandServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveTransportDTMFReceived value) => new LiveSidebandServerEvent((global::tryAGI.OpenAI.LiveTransportDTMFReceived?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveTransportDTMFReceived?(LiveSidebandServerEvent @this) => @this.TransportDtmfReceived;

        /// <summary>
        ///
        /// </summary>
        public LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveTransportDTMFReceived? value)
        {
            TransportDtmfReceived = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveSidebandServerEvent FromTransportDtmfReceived(global::tryAGI.OpenAI.LiveTransportDTMFReceived? value) => new LiveSidebandServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveTransportDTMFSent value) => new LiveSidebandServerEvent((global::tryAGI.OpenAI.LiveTransportDTMFSent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveTransportDTMFSent?(LiveSidebandServerEvent @this) => @this.TransportDtmfSent;

        /// <summary>
        ///
        /// </summary>
        public LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveTransportDTMFSent? value)
        {
            TransportDtmfSent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveSidebandServerEvent FromTransportDtmfSent(global::tryAGI.OpenAI.LiveTransportDTMFSent? value) => new LiveSidebandServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveSessionStarted value) => new LiveSidebandServerEvent((global::tryAGI.OpenAI.LiveSessionStarted?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveSessionStarted?(LiveSidebandServerEvent @this) => @this.SessionStarted;

        /// <summary>
        ///
        /// </summary>
        public LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveSessionStarted? value)
        {
            SessionStarted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveSidebandServerEvent FromSessionStarted(global::tryAGI.OpenAI.LiveSessionStarted? value) => new LiveSidebandServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveSessionUpdated value) => new LiveSidebandServerEvent((global::tryAGI.OpenAI.LiveSessionUpdated?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveSessionUpdated?(LiveSidebandServerEvent @this) => @this.SessionUpdated;

        /// <summary>
        ///
        /// </summary>
        public LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveSessionUpdated? value)
        {
            SessionUpdated = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveSidebandServerEvent FromSessionUpdated(global::tryAGI.OpenAI.LiveSessionUpdated? value) => new LiveSidebandServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveInputAudioMuted value) => new LiveSidebandServerEvent((global::tryAGI.OpenAI.LiveInputAudioMuted?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveInputAudioMuted?(LiveSidebandServerEvent @this) => @this.SessionInputAudioMuted;

        /// <summary>
        ///
        /// </summary>
        public LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveInputAudioMuted? value)
        {
            SessionInputAudioMuted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveSidebandServerEvent FromSessionInputAudioMuted(global::tryAGI.OpenAI.LiveInputAudioMuted? value) => new LiveSidebandServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveInputAudioUnmuted value) => new LiveSidebandServerEvent((global::tryAGI.OpenAI.LiveInputAudioUnmuted?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveInputAudioUnmuted?(LiveSidebandServerEvent @this) => @this.SessionInputAudioUnmuted;

        /// <summary>
        ///
        /// </summary>
        public LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveInputAudioUnmuted? value)
        {
            SessionInputAudioUnmuted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveSidebandServerEvent FromSessionInputAudioUnmuted(global::tryAGI.OpenAI.LiveInputAudioUnmuted? value) => new LiveSidebandServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveOutputAudioFixturePlaying value) => new LiveSidebandServerEvent((global::tryAGI.OpenAI.LiveOutputAudioFixturePlaying?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveOutputAudioFixturePlaying?(LiveSidebandServerEvent @this) => @this.SessionOutputAudioFixturePlaying;

        /// <summary>
        ///
        /// </summary>
        public LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveOutputAudioFixturePlaying? value)
        {
            SessionOutputAudioFixturePlaying = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveSidebandServerEvent FromSessionOutputAudioFixturePlaying(global::tryAGI.OpenAI.LiveOutputAudioFixturePlaying? value) => new LiveSidebandServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveOutputAudioFixturePlayed value) => new LiveSidebandServerEvent((global::tryAGI.OpenAI.LiveOutputAudioFixturePlayed?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveOutputAudioFixturePlayed?(LiveSidebandServerEvent @this) => @this.SessionOutputAudioFixturePlayed;

        /// <summary>
        ///
        /// </summary>
        public LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveOutputAudioFixturePlayed? value)
        {
            SessionOutputAudioFixturePlayed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveSidebandServerEvent FromSessionOutputAudioFixturePlayed(global::tryAGI.OpenAI.LiveOutputAudioFixturePlayed? value) => new LiveSidebandServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveInstructionsAppended value) => new LiveSidebandServerEvent((global::tryAGI.OpenAI.LiveInstructionsAppended?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveInstructionsAppended?(LiveSidebandServerEvent @this) => @this.SessionInstructionsAppended;

        /// <summary>
        ///
        /// </summary>
        public LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveInstructionsAppended? value)
        {
            SessionInstructionsAppended = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveSidebandServerEvent FromSessionInstructionsAppended(global::tryAGI.OpenAI.LiveInstructionsAppended? value) => new LiveSidebandServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveThinkingAppended value) => new LiveSidebandServerEvent((global::tryAGI.OpenAI.LiveThinkingAppended?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveThinkingAppended?(LiveSidebandServerEvent @this) => @this.SessionThinkingAppended;

        /// <summary>
        ///
        /// </summary>
        public LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveThinkingAppended? value)
        {
            SessionThinkingAppended = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveSidebandServerEvent FromSessionThinkingAppended(global::tryAGI.OpenAI.LiveThinkingAppended? value) => new LiveSidebandServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveCommentaryAppended value) => new LiveSidebandServerEvent((global::tryAGI.OpenAI.LiveCommentaryAppended?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveCommentaryAppended?(LiveSidebandServerEvent @this) => @this.SessionCommentaryAppended;

        /// <summary>
        ///
        /// </summary>
        public LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveCommentaryAppended? value)
        {
            SessionCommentaryAppended = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveSidebandServerEvent FromSessionCommentaryAppended(global::tryAGI.OpenAI.LiveCommentaryAppended? value) => new LiveSidebandServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveInputTranscriptDelta value) => new LiveSidebandServerEvent((global::tryAGI.OpenAI.LiveInputTranscriptDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveInputTranscriptDelta?(LiveSidebandServerEvent @this) => @this.SessionInputTranscriptDelta;

        /// <summary>
        ///
        /// </summary>
        public LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveInputTranscriptDelta? value)
        {
            SessionInputTranscriptDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveSidebandServerEvent FromSessionInputTranscriptDelta(global::tryAGI.OpenAI.LiveInputTranscriptDelta? value) => new LiveSidebandServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveOutputTranscriptDelta value) => new LiveSidebandServerEvent((global::tryAGI.OpenAI.LiveOutputTranscriptDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveOutputTranscriptDelta?(LiveSidebandServerEvent @this) => @this.SessionOutputTranscriptDelta;

        /// <summary>
        ///
        /// </summary>
        public LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveOutputTranscriptDelta? value)
        {
            SessionOutputTranscriptDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveSidebandServerEvent FromSessionOutputTranscriptDelta(global::tryAGI.OpenAI.LiveOutputTranscriptDelta? value) => new LiveSidebandServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveDelegationCreated value) => new LiveSidebandServerEvent((global::tryAGI.OpenAI.LiveDelegationCreated?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveDelegationCreated?(LiveSidebandServerEvent @this) => @this.SessionDelegationCreated;

        /// <summary>
        ///
        /// </summary>
        public LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveDelegationCreated? value)
        {
            SessionDelegationCreated = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveSidebandServerEvent FromSessionDelegationCreated(global::tryAGI.OpenAI.LiveDelegationCreated? value) => new LiveSidebandServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveDecisionEvent value) => new LiveSidebandServerEvent((global::tryAGI.OpenAI.LiveDecisionEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveDecisionEvent?(LiveSidebandServerEvent @this) => @this.DecisionEvent;

        /// <summary>
        ///
        /// </summary>
        public LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveDecisionEvent? value)
        {
            DecisionEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveSidebandServerEvent FromDecisionEvent(global::tryAGI.OpenAI.LiveDecisionEvent? value) => new LiveSidebandServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveDecisionItemCreated value) => new LiveSidebandServerEvent((global::tryAGI.OpenAI.LiveDecisionItemCreated?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveDecisionItemCreated?(LiveSidebandServerEvent @this) => @this.DecisionItemCreated;

        /// <summary>
        ///
        /// </summary>
        public LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveDecisionItemCreated? value)
        {
            DecisionItemCreated = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveSidebandServerEvent FromDecisionItemCreated(global::tryAGI.OpenAI.LiveDecisionItemCreated? value) => new LiveSidebandServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveDecisionItemDeleted value) => new LiveSidebandServerEvent((global::tryAGI.OpenAI.LiveDecisionItemDeleted?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveDecisionItemDeleted?(LiveSidebandServerEvent @this) => @this.DecisionItemDeleted;

        /// <summary>
        ///
        /// </summary>
        public LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveDecisionItemDeleted? value)
        {
            DecisionItemDeleted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveSidebandServerEvent FromDecisionItemDeleted(global::tryAGI.OpenAI.LiveDecisionItemDeleted? value) => new LiveSidebandServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveResponseEvent value) => new LiveSidebandServerEvent((global::tryAGI.OpenAI.LiveResponseEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveResponseEvent?(LiveSidebandServerEvent @this) => @this.ResponseEvent;

        /// <summary>
        ///
        /// </summary>
        public LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveResponseEvent? value)
        {
            ResponseEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveSidebandServerEvent FromResponseEvent(global::tryAGI.OpenAI.LiveResponseEvent? value) => new LiveSidebandServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveSessionUsageUpdated value) => new LiveSidebandServerEvent((global::tryAGI.OpenAI.LiveSessionUsageUpdated?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveSessionUsageUpdated?(LiveSidebandServerEvent @this) => @this.SessionUsageUpdated;

        /// <summary>
        ///
        /// </summary>
        public LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveSessionUsageUpdated? value)
        {
            SessionUsageUpdated = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveSidebandServerEvent FromSessionUsageUpdated(global::tryAGI.OpenAI.LiveSessionUsageUpdated? value) => new LiveSidebandServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveSessionClosed value) => new LiveSidebandServerEvent((global::tryAGI.OpenAI.LiveSessionClosed?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveSessionClosed?(LiveSidebandServerEvent @this) => @this.SessionClosed;

        /// <summary>
        ///
        /// </summary>
        public LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveSessionClosed? value)
        {
            SessionClosed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveSidebandServerEvent FromSessionClosed(global::tryAGI.OpenAI.LiveSessionClosed? value) => new LiveSidebandServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveErrorEvent value) => new LiveSidebandServerEvent((global::tryAGI.OpenAI.LiveErrorEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveErrorEvent?(LiveSidebandServerEvent @this) => @this.Error;

        /// <summary>
        ///
        /// </summary>
        public LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveErrorEvent? value)
        {
            Error = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveSidebandServerEvent FromError(global::tryAGI.OpenAI.LiveErrorEvent? value) => new LiveSidebandServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveInfoEvent value) => new LiveSidebandServerEvent((global::tryAGI.OpenAI.LiveInfoEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveInfoEvent?(LiveSidebandServerEvent @this) => @this.Info;

        /// <summary>
        ///
        /// </summary>
        public LiveSidebandServerEvent(global::tryAGI.OpenAI.LiveInfoEvent? value)
        {
            Info = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveSidebandServerEvent FromInfo(global::tryAGI.OpenAI.LiveInfoEvent? value) => new LiveSidebandServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public LiveSidebandServerEvent(
            global::tryAGI.OpenAI.LiveSidebandServerEventDiscriminatorType? type,
            global::tryAGI.OpenAI.LiveTransportRinging? transportRinging,
            global::tryAGI.OpenAI.LiveTransportAnswered? transportAnswered,
            global::tryAGI.OpenAI.LiveTransportFailed? transportFailed,
            global::tryAGI.OpenAI.LiveTransportDTMFReceived? transportDtmfReceived,
            global::tryAGI.OpenAI.LiveTransportDTMFSent? transportDtmfSent,
            global::tryAGI.OpenAI.LiveSessionStarted? sessionStarted,
            global::tryAGI.OpenAI.LiveSessionUpdated? sessionUpdated,
            global::tryAGI.OpenAI.LiveInputAudioMuted? sessionInputAudioMuted,
            global::tryAGI.OpenAI.LiveInputAudioUnmuted? sessionInputAudioUnmuted,
            global::tryAGI.OpenAI.LiveOutputAudioFixturePlaying? sessionOutputAudioFixturePlaying,
            global::tryAGI.OpenAI.LiveOutputAudioFixturePlayed? sessionOutputAudioFixturePlayed,
            global::tryAGI.OpenAI.LiveInstructionsAppended? sessionInstructionsAppended,
            global::tryAGI.OpenAI.LiveThinkingAppended? sessionThinkingAppended,
            global::tryAGI.OpenAI.LiveCommentaryAppended? sessionCommentaryAppended,
            global::tryAGI.OpenAI.LiveInputTranscriptDelta? sessionInputTranscriptDelta,
            global::tryAGI.OpenAI.LiveOutputTranscriptDelta? sessionOutputTranscriptDelta,
            global::tryAGI.OpenAI.LiveDelegationCreated? sessionDelegationCreated,
            global::tryAGI.OpenAI.LiveDecisionEvent? decisionEvent,
            global::tryAGI.OpenAI.LiveDecisionItemCreated? decisionItemCreated,
            global::tryAGI.OpenAI.LiveDecisionItemDeleted? decisionItemDeleted,
            global::tryAGI.OpenAI.LiveResponseEvent? responseEvent,
            global::tryAGI.OpenAI.LiveSessionUsageUpdated? sessionUsageUpdated,
            global::tryAGI.OpenAI.LiveSessionClosed? sessionClosed,
            global::tryAGI.OpenAI.LiveErrorEvent? error,
            global::tryAGI.OpenAI.LiveInfoEvent? info
            )
        {
            Type = type;

            TransportRinging = transportRinging;
            TransportAnswered = transportAnswered;
            TransportFailed = transportFailed;
            TransportDtmfReceived = transportDtmfReceived;
            TransportDtmfSent = transportDtmfSent;
            SessionStarted = sessionStarted;
            SessionUpdated = sessionUpdated;
            SessionInputAudioMuted = sessionInputAudioMuted;
            SessionInputAudioUnmuted = sessionInputAudioUnmuted;
            SessionOutputAudioFixturePlaying = sessionOutputAudioFixturePlaying;
            SessionOutputAudioFixturePlayed = sessionOutputAudioFixturePlayed;
            SessionInstructionsAppended = sessionInstructionsAppended;
            SessionThinkingAppended = sessionThinkingAppended;
            SessionCommentaryAppended = sessionCommentaryAppended;
            SessionInputTranscriptDelta = sessionInputTranscriptDelta;
            SessionOutputTranscriptDelta = sessionOutputTranscriptDelta;
            SessionDelegationCreated = sessionDelegationCreated;
            DecisionEvent = decisionEvent;
            DecisionItemCreated = decisionItemCreated;
            DecisionItemDeleted = decisionItemDeleted;
            ResponseEvent = responseEvent;
            SessionUsageUpdated = sessionUsageUpdated;
            SessionClosed = sessionClosed;
            Error = error;
            Info = info;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Info as object ??
            Error as object ??
            SessionClosed as object ??
            SessionUsageUpdated as object ??
            ResponseEvent as object ??
            DecisionItemDeleted as object ??
            DecisionItemCreated as object ??
            DecisionEvent as object ??
            SessionDelegationCreated as object ??
            SessionOutputTranscriptDelta as object ??
            SessionInputTranscriptDelta as object ??
            SessionCommentaryAppended as object ??
            SessionThinkingAppended as object ??
            SessionInstructionsAppended as object ??
            SessionOutputAudioFixturePlayed as object ??
            SessionOutputAudioFixturePlaying as object ??
            SessionInputAudioUnmuted as object ??
            SessionInputAudioMuted as object ??
            SessionUpdated as object ??
            SessionStarted as object ??
            TransportDtmfSent as object ??
            TransportDtmfReceived as object ??
            TransportFailed as object ??
            TransportAnswered as object ??
            TransportRinging as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            TransportRinging?.ToString() ??
            TransportAnswered?.ToString() ??
            TransportFailed?.ToString() ??
            TransportDtmfReceived?.ToString() ??
            TransportDtmfSent?.ToString() ??
            SessionStarted?.ToString() ??
            SessionUpdated?.ToString() ??
            SessionInputAudioMuted?.ToString() ??
            SessionInputAudioUnmuted?.ToString() ??
            SessionOutputAudioFixturePlaying?.ToString() ??
            SessionOutputAudioFixturePlayed?.ToString() ??
            SessionInstructionsAppended?.ToString() ??
            SessionThinkingAppended?.ToString() ??
            SessionCommentaryAppended?.ToString() ??
            SessionInputTranscriptDelta?.ToString() ??
            SessionOutputTranscriptDelta?.ToString() ??
            SessionDelegationCreated?.ToString() ??
            DecisionEvent?.ToString() ??
            DecisionItemCreated?.ToString() ??
            DecisionItemDeleted?.ToString() ??
            ResponseEvent?.ToString() ??
            SessionUsageUpdated?.ToString() ??
            SessionClosed?.ToString() ??
            Error?.ToString() ??
            Info?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsTransportRinging && !IsTransportAnswered && !IsTransportFailed && !IsTransportDtmfReceived && !IsTransportDtmfSent && !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionOutputAudioFixturePlaying && !IsSessionOutputAudioFixturePlayed && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsDecisionEvent && !IsDecisionItemCreated && !IsDecisionItemDeleted && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo || !IsTransportRinging && IsTransportAnswered && !IsTransportFailed && !IsTransportDtmfReceived && !IsTransportDtmfSent && !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionOutputAudioFixturePlaying && !IsSessionOutputAudioFixturePlayed && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsDecisionEvent && !IsDecisionItemCreated && !IsDecisionItemDeleted && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo || !IsTransportRinging && !IsTransportAnswered && IsTransportFailed && !IsTransportDtmfReceived && !IsTransportDtmfSent && !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionOutputAudioFixturePlaying && !IsSessionOutputAudioFixturePlayed && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsDecisionEvent && !IsDecisionItemCreated && !IsDecisionItemDeleted && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo || !IsTransportRinging && !IsTransportAnswered && !IsTransportFailed && IsTransportDtmfReceived && !IsTransportDtmfSent && !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionOutputAudioFixturePlaying && !IsSessionOutputAudioFixturePlayed && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsDecisionEvent && !IsDecisionItemCreated && !IsDecisionItemDeleted && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo || !IsTransportRinging && !IsTransportAnswered && !IsTransportFailed && !IsTransportDtmfReceived && IsTransportDtmfSent && !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionOutputAudioFixturePlaying && !IsSessionOutputAudioFixturePlayed && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsDecisionEvent && !IsDecisionItemCreated && !IsDecisionItemDeleted && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo || !IsTransportRinging && !IsTransportAnswered && !IsTransportFailed && !IsTransportDtmfReceived && !IsTransportDtmfSent && IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionOutputAudioFixturePlaying && !IsSessionOutputAudioFixturePlayed && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsDecisionEvent && !IsDecisionItemCreated && !IsDecisionItemDeleted && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo || !IsTransportRinging && !IsTransportAnswered && !IsTransportFailed && !IsTransportDtmfReceived && !IsTransportDtmfSent && !IsSessionStarted && IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionOutputAudioFixturePlaying && !IsSessionOutputAudioFixturePlayed && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsDecisionEvent && !IsDecisionItemCreated && !IsDecisionItemDeleted && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo || !IsTransportRinging && !IsTransportAnswered && !IsTransportFailed && !IsTransportDtmfReceived && !IsTransportDtmfSent && !IsSessionStarted && !IsSessionUpdated && IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionOutputAudioFixturePlaying && !IsSessionOutputAudioFixturePlayed && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsDecisionEvent && !IsDecisionItemCreated && !IsDecisionItemDeleted && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo || !IsTransportRinging && !IsTransportAnswered && !IsTransportFailed && !IsTransportDtmfReceived && !IsTransportDtmfSent && !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && IsSessionInputAudioUnmuted && !IsSessionOutputAudioFixturePlaying && !IsSessionOutputAudioFixturePlayed && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsDecisionEvent && !IsDecisionItemCreated && !IsDecisionItemDeleted && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo || !IsTransportRinging && !IsTransportAnswered && !IsTransportFailed && !IsTransportDtmfReceived && !IsTransportDtmfSent && !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && IsSessionOutputAudioFixturePlaying && !IsSessionOutputAudioFixturePlayed && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsDecisionEvent && !IsDecisionItemCreated && !IsDecisionItemDeleted && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo || !IsTransportRinging && !IsTransportAnswered && !IsTransportFailed && !IsTransportDtmfReceived && !IsTransportDtmfSent && !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionOutputAudioFixturePlaying && IsSessionOutputAudioFixturePlayed && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsDecisionEvent && !IsDecisionItemCreated && !IsDecisionItemDeleted && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo || !IsTransportRinging && !IsTransportAnswered && !IsTransportFailed && !IsTransportDtmfReceived && !IsTransportDtmfSent && !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionOutputAudioFixturePlaying && !IsSessionOutputAudioFixturePlayed && IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsDecisionEvent && !IsDecisionItemCreated && !IsDecisionItemDeleted && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo || !IsTransportRinging && !IsTransportAnswered && !IsTransportFailed && !IsTransportDtmfReceived && !IsTransportDtmfSent && !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionOutputAudioFixturePlaying && !IsSessionOutputAudioFixturePlayed && !IsSessionInstructionsAppended && IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsDecisionEvent && !IsDecisionItemCreated && !IsDecisionItemDeleted && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo || !IsTransportRinging && !IsTransportAnswered && !IsTransportFailed && !IsTransportDtmfReceived && !IsTransportDtmfSent && !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionOutputAudioFixturePlaying && !IsSessionOutputAudioFixturePlayed && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && IsSessionCommentaryAppended && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsDecisionEvent && !IsDecisionItemCreated && !IsDecisionItemDeleted && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo || !IsTransportRinging && !IsTransportAnswered && !IsTransportFailed && !IsTransportDtmfReceived && !IsTransportDtmfSent && !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionOutputAudioFixturePlaying && !IsSessionOutputAudioFixturePlayed && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsDecisionEvent && !IsDecisionItemCreated && !IsDecisionItemDeleted && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo || !IsTransportRinging && !IsTransportAnswered && !IsTransportFailed && !IsTransportDtmfReceived && !IsTransportDtmfSent && !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionOutputAudioFixturePlaying && !IsSessionOutputAudioFixturePlayed && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputTranscriptDelta && IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsDecisionEvent && !IsDecisionItemCreated && !IsDecisionItemDeleted && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo || !IsTransportRinging && !IsTransportAnswered && !IsTransportFailed && !IsTransportDtmfReceived && !IsTransportDtmfSent && !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionOutputAudioFixturePlaying && !IsSessionOutputAudioFixturePlayed && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && IsSessionDelegationCreated && !IsDecisionEvent && !IsDecisionItemCreated && !IsDecisionItemDeleted && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo || !IsTransportRinging && !IsTransportAnswered && !IsTransportFailed && !IsTransportDtmfReceived && !IsTransportDtmfSent && !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionOutputAudioFixturePlaying && !IsSessionOutputAudioFixturePlayed && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && IsDecisionEvent && !IsDecisionItemCreated && !IsDecisionItemDeleted && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo || !IsTransportRinging && !IsTransportAnswered && !IsTransportFailed && !IsTransportDtmfReceived && !IsTransportDtmfSent && !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionOutputAudioFixturePlaying && !IsSessionOutputAudioFixturePlayed && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsDecisionEvent && IsDecisionItemCreated && !IsDecisionItemDeleted && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo || !IsTransportRinging && !IsTransportAnswered && !IsTransportFailed && !IsTransportDtmfReceived && !IsTransportDtmfSent && !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionOutputAudioFixturePlaying && !IsSessionOutputAudioFixturePlayed && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsDecisionEvent && !IsDecisionItemCreated && IsDecisionItemDeleted && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo || !IsTransportRinging && !IsTransportAnswered && !IsTransportFailed && !IsTransportDtmfReceived && !IsTransportDtmfSent && !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionOutputAudioFixturePlaying && !IsSessionOutputAudioFixturePlayed && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsDecisionEvent && !IsDecisionItemCreated && !IsDecisionItemDeleted && IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo || !IsTransportRinging && !IsTransportAnswered && !IsTransportFailed && !IsTransportDtmfReceived && !IsTransportDtmfSent && !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionOutputAudioFixturePlaying && !IsSessionOutputAudioFixturePlayed && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsDecisionEvent && !IsDecisionItemCreated && !IsDecisionItemDeleted && !IsResponseEvent && IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo || !IsTransportRinging && !IsTransportAnswered && !IsTransportFailed && !IsTransportDtmfReceived && !IsTransportDtmfSent && !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionOutputAudioFixturePlaying && !IsSessionOutputAudioFixturePlayed && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsDecisionEvent && !IsDecisionItemCreated && !IsDecisionItemDeleted && !IsResponseEvent && !IsSessionUsageUpdated && IsSessionClosed && !IsError && !IsInfo || !IsTransportRinging && !IsTransportAnswered && !IsTransportFailed && !IsTransportDtmfReceived && !IsTransportDtmfSent && !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionOutputAudioFixturePlaying && !IsSessionOutputAudioFixturePlayed && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsDecisionEvent && !IsDecisionItemCreated && !IsDecisionItemDeleted && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && IsError && !IsInfo || !IsTransportRinging && !IsTransportAnswered && !IsTransportFailed && !IsTransportDtmfReceived && !IsTransportDtmfSent && !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionOutputAudioFixturePlaying && !IsSessionOutputAudioFixturePlayed && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsDecisionEvent && !IsDecisionItemCreated && !IsDecisionItemDeleted && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && IsInfo;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.LiveTransportRinging, TResult>? transportRinging = null,
            global::System.Func<global::tryAGI.OpenAI.LiveTransportAnswered, TResult>? transportAnswered = null,
            global::System.Func<global::tryAGI.OpenAI.LiveTransportFailed, TResult>? transportFailed = null,
            global::System.Func<global::tryAGI.OpenAI.LiveTransportDTMFReceived, TResult>? transportDtmfReceived = null,
            global::System.Func<global::tryAGI.OpenAI.LiveTransportDTMFSent, TResult>? transportDtmfSent = null,
            global::System.Func<global::tryAGI.OpenAI.LiveSessionStarted, TResult>? sessionStarted = null,
            global::System.Func<global::tryAGI.OpenAI.LiveSessionUpdated, TResult>? sessionUpdated = null,
            global::System.Func<global::tryAGI.OpenAI.LiveInputAudioMuted, TResult>? sessionInputAudioMuted = null,
            global::System.Func<global::tryAGI.OpenAI.LiveInputAudioUnmuted, TResult>? sessionInputAudioUnmuted = null,
            global::System.Func<global::tryAGI.OpenAI.LiveOutputAudioFixturePlaying, TResult>? sessionOutputAudioFixturePlaying = null,
            global::System.Func<global::tryAGI.OpenAI.LiveOutputAudioFixturePlayed, TResult>? sessionOutputAudioFixturePlayed = null,
            global::System.Func<global::tryAGI.OpenAI.LiveInstructionsAppended, TResult>? sessionInstructionsAppended = null,
            global::System.Func<global::tryAGI.OpenAI.LiveThinkingAppended, TResult>? sessionThinkingAppended = null,
            global::System.Func<global::tryAGI.OpenAI.LiveCommentaryAppended, TResult>? sessionCommentaryAppended = null,
            global::System.Func<global::tryAGI.OpenAI.LiveInputTranscriptDelta, TResult>? sessionInputTranscriptDelta = null,
            global::System.Func<global::tryAGI.OpenAI.LiveOutputTranscriptDelta, TResult>? sessionOutputTranscriptDelta = null,
            global::System.Func<global::tryAGI.OpenAI.LiveDelegationCreated, TResult>? sessionDelegationCreated = null,
            global::System.Func<global::tryAGI.OpenAI.LiveDecisionEvent, TResult>? decisionEvent = null,
            global::System.Func<global::tryAGI.OpenAI.LiveDecisionItemCreated, TResult>? decisionItemCreated = null,
            global::System.Func<global::tryAGI.OpenAI.LiveDecisionItemDeleted, TResult>? decisionItemDeleted = null,
            global::System.Func<global::tryAGI.OpenAI.LiveResponseEvent, TResult>? responseEvent = null,
            global::System.Func<global::tryAGI.OpenAI.LiveSessionUsageUpdated, TResult>? sessionUsageUpdated = null,
            global::System.Func<global::tryAGI.OpenAI.LiveSessionClosed, TResult>? sessionClosed = null,
            global::System.Func<global::tryAGI.OpenAI.LiveErrorEvent, TResult>? error = null,
            global::System.Func<global::tryAGI.OpenAI.LiveInfoEvent, TResult>? info = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TransportRinging is { } __value0 && transportRinging != null)
            {
                return transportRinging(__value0);
            }
            else if (TransportAnswered is { } __value1 && transportAnswered != null)
            {
                return transportAnswered(__value1);
            }
            else if (TransportFailed is { } __value2 && transportFailed != null)
            {
                return transportFailed(__value2);
            }
            else if (TransportDtmfReceived is { } __value3 && transportDtmfReceived != null)
            {
                return transportDtmfReceived(__value3);
            }
            else if (TransportDtmfSent is { } __value4 && transportDtmfSent != null)
            {
                return transportDtmfSent(__value4);
            }
            else if (SessionStarted is { } __value5 && sessionStarted != null)
            {
                return sessionStarted(__value5);
            }
            else if (SessionUpdated is { } __value6 && sessionUpdated != null)
            {
                return sessionUpdated(__value6);
            }
            else if (SessionInputAudioMuted is { } __value7 && sessionInputAudioMuted != null)
            {
                return sessionInputAudioMuted(__value7);
            }
            else if (SessionInputAudioUnmuted is { } __value8 && sessionInputAudioUnmuted != null)
            {
                return sessionInputAudioUnmuted(__value8);
            }
            else if (SessionOutputAudioFixturePlaying is { } __value9 && sessionOutputAudioFixturePlaying != null)
            {
                return sessionOutputAudioFixturePlaying(__value9);
            }
            else if (SessionOutputAudioFixturePlayed is { } __value10 && sessionOutputAudioFixturePlayed != null)
            {
                return sessionOutputAudioFixturePlayed(__value10);
            }
            else if (SessionInstructionsAppended is { } __value11 && sessionInstructionsAppended != null)
            {
                return sessionInstructionsAppended(__value11);
            }
            else if (SessionThinkingAppended is { } __value12 && sessionThinkingAppended != null)
            {
                return sessionThinkingAppended(__value12);
            }
            else if (SessionCommentaryAppended is { } __value13 && sessionCommentaryAppended != null)
            {
                return sessionCommentaryAppended(__value13);
            }
            else if (SessionInputTranscriptDelta is { } __value14 && sessionInputTranscriptDelta != null)
            {
                return sessionInputTranscriptDelta(__value14);
            }
            else if (SessionOutputTranscriptDelta is { } __value15 && sessionOutputTranscriptDelta != null)
            {
                return sessionOutputTranscriptDelta(__value15);
            }
            else if (SessionDelegationCreated is { } __value16 && sessionDelegationCreated != null)
            {
                return sessionDelegationCreated(__value16);
            }
            else if (DecisionEvent is { } __value17 && decisionEvent != null)
            {
                return decisionEvent(__value17);
            }
            else if (DecisionItemCreated is { } __value18 && decisionItemCreated != null)
            {
                return decisionItemCreated(__value18);
            }
            else if (DecisionItemDeleted is { } __value19 && decisionItemDeleted != null)
            {
                return decisionItemDeleted(__value19);
            }
            else if (ResponseEvent is { } __value20 && responseEvent != null)
            {
                return responseEvent(__value20);
            }
            else if (SessionUsageUpdated is { } __value21 && sessionUsageUpdated != null)
            {
                return sessionUsageUpdated(__value21);
            }
            else if (SessionClosed is { } __value22 && sessionClosed != null)
            {
                return sessionClosed(__value22);
            }
            else if (Error is { } __value23 && error != null)
            {
                return error(__value23);
            }
            else if (Info is { } __value24 && info != null)
            {
                return info(__value24);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.LiveTransportRinging>? transportRinging = null,

            global::System.Action<global::tryAGI.OpenAI.LiveTransportAnswered>? transportAnswered = null,

            global::System.Action<global::tryAGI.OpenAI.LiveTransportFailed>? transportFailed = null,

            global::System.Action<global::tryAGI.OpenAI.LiveTransportDTMFReceived>? transportDtmfReceived = null,

            global::System.Action<global::tryAGI.OpenAI.LiveTransportDTMFSent>? transportDtmfSent = null,

            global::System.Action<global::tryAGI.OpenAI.LiveSessionStarted>? sessionStarted = null,

            global::System.Action<global::tryAGI.OpenAI.LiveSessionUpdated>? sessionUpdated = null,

            global::System.Action<global::tryAGI.OpenAI.LiveInputAudioMuted>? sessionInputAudioMuted = null,

            global::System.Action<global::tryAGI.OpenAI.LiveInputAudioUnmuted>? sessionInputAudioUnmuted = null,

            global::System.Action<global::tryAGI.OpenAI.LiveOutputAudioFixturePlaying>? sessionOutputAudioFixturePlaying = null,

            global::System.Action<global::tryAGI.OpenAI.LiveOutputAudioFixturePlayed>? sessionOutputAudioFixturePlayed = null,

            global::System.Action<global::tryAGI.OpenAI.LiveInstructionsAppended>? sessionInstructionsAppended = null,

            global::System.Action<global::tryAGI.OpenAI.LiveThinkingAppended>? sessionThinkingAppended = null,

            global::System.Action<global::tryAGI.OpenAI.LiveCommentaryAppended>? sessionCommentaryAppended = null,

            global::System.Action<global::tryAGI.OpenAI.LiveInputTranscriptDelta>? sessionInputTranscriptDelta = null,

            global::System.Action<global::tryAGI.OpenAI.LiveOutputTranscriptDelta>? sessionOutputTranscriptDelta = null,

            global::System.Action<global::tryAGI.OpenAI.LiveDelegationCreated>? sessionDelegationCreated = null,

            global::System.Action<global::tryAGI.OpenAI.LiveDecisionEvent>? decisionEvent = null,

            global::System.Action<global::tryAGI.OpenAI.LiveDecisionItemCreated>? decisionItemCreated = null,

            global::System.Action<global::tryAGI.OpenAI.LiveDecisionItemDeleted>? decisionItemDeleted = null,

            global::System.Action<global::tryAGI.OpenAI.LiveResponseEvent>? responseEvent = null,

            global::System.Action<global::tryAGI.OpenAI.LiveSessionUsageUpdated>? sessionUsageUpdated = null,

            global::System.Action<global::tryAGI.OpenAI.LiveSessionClosed>? sessionClosed = null,

            global::System.Action<global::tryAGI.OpenAI.LiveErrorEvent>? error = null,

            global::System.Action<global::tryAGI.OpenAI.LiveInfoEvent>? info = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TransportRinging is { } __value0)
            {
                transportRinging?.Invoke(__value0);
            }
            else if (TransportAnswered is { } __value1)
            {
                transportAnswered?.Invoke(__value1);
            }
            else if (TransportFailed is { } __value2)
            {
                transportFailed?.Invoke(__value2);
            }
            else if (TransportDtmfReceived is { } __value3)
            {
                transportDtmfReceived?.Invoke(__value3);
            }
            else if (TransportDtmfSent is { } __value4)
            {
                transportDtmfSent?.Invoke(__value4);
            }
            else if (SessionStarted is { } __value5)
            {
                sessionStarted?.Invoke(__value5);
            }
            else if (SessionUpdated is { } __value6)
            {
                sessionUpdated?.Invoke(__value6);
            }
            else if (SessionInputAudioMuted is { } __value7)
            {
                sessionInputAudioMuted?.Invoke(__value7);
            }
            else if (SessionInputAudioUnmuted is { } __value8)
            {
                sessionInputAudioUnmuted?.Invoke(__value8);
            }
            else if (SessionOutputAudioFixturePlaying is { } __value9)
            {
                sessionOutputAudioFixturePlaying?.Invoke(__value9);
            }
            else if (SessionOutputAudioFixturePlayed is { } __value10)
            {
                sessionOutputAudioFixturePlayed?.Invoke(__value10);
            }
            else if (SessionInstructionsAppended is { } __value11)
            {
                sessionInstructionsAppended?.Invoke(__value11);
            }
            else if (SessionThinkingAppended is { } __value12)
            {
                sessionThinkingAppended?.Invoke(__value12);
            }
            else if (SessionCommentaryAppended is { } __value13)
            {
                sessionCommentaryAppended?.Invoke(__value13);
            }
            else if (SessionInputTranscriptDelta is { } __value14)
            {
                sessionInputTranscriptDelta?.Invoke(__value14);
            }
            else if (SessionOutputTranscriptDelta is { } __value15)
            {
                sessionOutputTranscriptDelta?.Invoke(__value15);
            }
            else if (SessionDelegationCreated is { } __value16)
            {
                sessionDelegationCreated?.Invoke(__value16);
            }
            else if (DecisionEvent is { } __value17)
            {
                decisionEvent?.Invoke(__value17);
            }
            else if (DecisionItemCreated is { } __value18)
            {
                decisionItemCreated?.Invoke(__value18);
            }
            else if (DecisionItemDeleted is { } __value19)
            {
                decisionItemDeleted?.Invoke(__value19);
            }
            else if (ResponseEvent is { } __value20)
            {
                responseEvent?.Invoke(__value20);
            }
            else if (SessionUsageUpdated is { } __value21)
            {
                sessionUsageUpdated?.Invoke(__value21);
            }
            else if (SessionClosed is { } __value22)
            {
                sessionClosed?.Invoke(__value22);
            }
            else if (Error is { } __value23)
            {
                error?.Invoke(__value23);
            }
            else if (Info is { } __value24)
            {
                info?.Invoke(__value24);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.LiveTransportRinging>? transportRinging = null,
            global::System.Action<global::tryAGI.OpenAI.LiveTransportAnswered>? transportAnswered = null,
            global::System.Action<global::tryAGI.OpenAI.LiveTransportFailed>? transportFailed = null,
            global::System.Action<global::tryAGI.OpenAI.LiveTransportDTMFReceived>? transportDtmfReceived = null,
            global::System.Action<global::tryAGI.OpenAI.LiveTransportDTMFSent>? transportDtmfSent = null,
            global::System.Action<global::tryAGI.OpenAI.LiveSessionStarted>? sessionStarted = null,
            global::System.Action<global::tryAGI.OpenAI.LiveSessionUpdated>? sessionUpdated = null,
            global::System.Action<global::tryAGI.OpenAI.LiveInputAudioMuted>? sessionInputAudioMuted = null,
            global::System.Action<global::tryAGI.OpenAI.LiveInputAudioUnmuted>? sessionInputAudioUnmuted = null,
            global::System.Action<global::tryAGI.OpenAI.LiveOutputAudioFixturePlaying>? sessionOutputAudioFixturePlaying = null,
            global::System.Action<global::tryAGI.OpenAI.LiveOutputAudioFixturePlayed>? sessionOutputAudioFixturePlayed = null,
            global::System.Action<global::tryAGI.OpenAI.LiveInstructionsAppended>? sessionInstructionsAppended = null,
            global::System.Action<global::tryAGI.OpenAI.LiveThinkingAppended>? sessionThinkingAppended = null,
            global::System.Action<global::tryAGI.OpenAI.LiveCommentaryAppended>? sessionCommentaryAppended = null,
            global::System.Action<global::tryAGI.OpenAI.LiveInputTranscriptDelta>? sessionInputTranscriptDelta = null,
            global::System.Action<global::tryAGI.OpenAI.LiveOutputTranscriptDelta>? sessionOutputTranscriptDelta = null,
            global::System.Action<global::tryAGI.OpenAI.LiveDelegationCreated>? sessionDelegationCreated = null,
            global::System.Action<global::tryAGI.OpenAI.LiveDecisionEvent>? decisionEvent = null,
            global::System.Action<global::tryAGI.OpenAI.LiveDecisionItemCreated>? decisionItemCreated = null,
            global::System.Action<global::tryAGI.OpenAI.LiveDecisionItemDeleted>? decisionItemDeleted = null,
            global::System.Action<global::tryAGI.OpenAI.LiveResponseEvent>? responseEvent = null,
            global::System.Action<global::tryAGI.OpenAI.LiveSessionUsageUpdated>? sessionUsageUpdated = null,
            global::System.Action<global::tryAGI.OpenAI.LiveSessionClosed>? sessionClosed = null,
            global::System.Action<global::tryAGI.OpenAI.LiveErrorEvent>? error = null,
            global::System.Action<global::tryAGI.OpenAI.LiveInfoEvent>? info = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TransportRinging is { } __value0)
            {
                transportRinging?.Invoke(__value0);
            }
            else if (TransportAnswered is { } __value1)
            {
                transportAnswered?.Invoke(__value1);
            }
            else if (TransportFailed is { } __value2)
            {
                transportFailed?.Invoke(__value2);
            }
            else if (TransportDtmfReceived is { } __value3)
            {
                transportDtmfReceived?.Invoke(__value3);
            }
            else if (TransportDtmfSent is { } __value4)
            {
                transportDtmfSent?.Invoke(__value4);
            }
            else if (SessionStarted is { } __value5)
            {
                sessionStarted?.Invoke(__value5);
            }
            else if (SessionUpdated is { } __value6)
            {
                sessionUpdated?.Invoke(__value6);
            }
            else if (SessionInputAudioMuted is { } __value7)
            {
                sessionInputAudioMuted?.Invoke(__value7);
            }
            else if (SessionInputAudioUnmuted is { } __value8)
            {
                sessionInputAudioUnmuted?.Invoke(__value8);
            }
            else if (SessionOutputAudioFixturePlaying is { } __value9)
            {
                sessionOutputAudioFixturePlaying?.Invoke(__value9);
            }
            else if (SessionOutputAudioFixturePlayed is { } __value10)
            {
                sessionOutputAudioFixturePlayed?.Invoke(__value10);
            }
            else if (SessionInstructionsAppended is { } __value11)
            {
                sessionInstructionsAppended?.Invoke(__value11);
            }
            else if (SessionThinkingAppended is { } __value12)
            {
                sessionThinkingAppended?.Invoke(__value12);
            }
            else if (SessionCommentaryAppended is { } __value13)
            {
                sessionCommentaryAppended?.Invoke(__value13);
            }
            else if (SessionInputTranscriptDelta is { } __value14)
            {
                sessionInputTranscriptDelta?.Invoke(__value14);
            }
            else if (SessionOutputTranscriptDelta is { } __value15)
            {
                sessionOutputTranscriptDelta?.Invoke(__value15);
            }
            else if (SessionDelegationCreated is { } __value16)
            {
                sessionDelegationCreated?.Invoke(__value16);
            }
            else if (DecisionEvent is { } __value17)
            {
                decisionEvent?.Invoke(__value17);
            }
            else if (DecisionItemCreated is { } __value18)
            {
                decisionItemCreated?.Invoke(__value18);
            }
            else if (DecisionItemDeleted is { } __value19)
            {
                decisionItemDeleted?.Invoke(__value19);
            }
            else if (ResponseEvent is { } __value20)
            {
                responseEvent?.Invoke(__value20);
            }
            else if (SessionUsageUpdated is { } __value21)
            {
                sessionUsageUpdated?.Invoke(__value21);
            }
            else if (SessionClosed is { } __value22)
            {
                sessionClosed?.Invoke(__value22);
            }
            else if (Error is { } __value23)
            {
                error?.Invoke(__value23);
            }
            else if (Info is { } __value24)
            {
                info?.Invoke(__value24);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TransportRinging,
                typeof(global::tryAGI.OpenAI.LiveTransportRinging),
                TransportAnswered,
                typeof(global::tryAGI.OpenAI.LiveTransportAnswered),
                TransportFailed,
                typeof(global::tryAGI.OpenAI.LiveTransportFailed),
                TransportDtmfReceived,
                typeof(global::tryAGI.OpenAI.LiveTransportDTMFReceived),
                TransportDtmfSent,
                typeof(global::tryAGI.OpenAI.LiveTransportDTMFSent),
                SessionStarted,
                typeof(global::tryAGI.OpenAI.LiveSessionStarted),
                SessionUpdated,
                typeof(global::tryAGI.OpenAI.LiveSessionUpdated),
                SessionInputAudioMuted,
                typeof(global::tryAGI.OpenAI.LiveInputAudioMuted),
                SessionInputAudioUnmuted,
                typeof(global::tryAGI.OpenAI.LiveInputAudioUnmuted),
                SessionOutputAudioFixturePlaying,
                typeof(global::tryAGI.OpenAI.LiveOutputAudioFixturePlaying),
                SessionOutputAudioFixturePlayed,
                typeof(global::tryAGI.OpenAI.LiveOutputAudioFixturePlayed),
                SessionInstructionsAppended,
                typeof(global::tryAGI.OpenAI.LiveInstructionsAppended),
                SessionThinkingAppended,
                typeof(global::tryAGI.OpenAI.LiveThinkingAppended),
                SessionCommentaryAppended,
                typeof(global::tryAGI.OpenAI.LiveCommentaryAppended),
                SessionInputTranscriptDelta,
                typeof(global::tryAGI.OpenAI.LiveInputTranscriptDelta),
                SessionOutputTranscriptDelta,
                typeof(global::tryAGI.OpenAI.LiveOutputTranscriptDelta),
                SessionDelegationCreated,
                typeof(global::tryAGI.OpenAI.LiveDelegationCreated),
                DecisionEvent,
                typeof(global::tryAGI.OpenAI.LiveDecisionEvent),
                DecisionItemCreated,
                typeof(global::tryAGI.OpenAI.LiveDecisionItemCreated),
                DecisionItemDeleted,
                typeof(global::tryAGI.OpenAI.LiveDecisionItemDeleted),
                ResponseEvent,
                typeof(global::tryAGI.OpenAI.LiveResponseEvent),
                SessionUsageUpdated,
                typeof(global::tryAGI.OpenAI.LiveSessionUsageUpdated),
                SessionClosed,
                typeof(global::tryAGI.OpenAI.LiveSessionClosed),
                Error,
                typeof(global::tryAGI.OpenAI.LiveErrorEvent),
                Info,
                typeof(global::tryAGI.OpenAI.LiveInfoEvent),
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
        public bool Equals(LiveSidebandServerEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveTransportRinging?>.Default.Equals(TransportRinging, other.TransportRinging) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveTransportAnswered?>.Default.Equals(TransportAnswered, other.TransportAnswered) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveTransportFailed?>.Default.Equals(TransportFailed, other.TransportFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveTransportDTMFReceived?>.Default.Equals(TransportDtmfReceived, other.TransportDtmfReceived) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveTransportDTMFSent?>.Default.Equals(TransportDtmfSent, other.TransportDtmfSent) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveSessionStarted?>.Default.Equals(SessionStarted, other.SessionStarted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveSessionUpdated?>.Default.Equals(SessionUpdated, other.SessionUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveInputAudioMuted?>.Default.Equals(SessionInputAudioMuted, other.SessionInputAudioMuted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveInputAudioUnmuted?>.Default.Equals(SessionInputAudioUnmuted, other.SessionInputAudioUnmuted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveOutputAudioFixturePlaying?>.Default.Equals(SessionOutputAudioFixturePlaying, other.SessionOutputAudioFixturePlaying) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveOutputAudioFixturePlayed?>.Default.Equals(SessionOutputAudioFixturePlayed, other.SessionOutputAudioFixturePlayed) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveInstructionsAppended?>.Default.Equals(SessionInstructionsAppended, other.SessionInstructionsAppended) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveThinkingAppended?>.Default.Equals(SessionThinkingAppended, other.SessionThinkingAppended) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveCommentaryAppended?>.Default.Equals(SessionCommentaryAppended, other.SessionCommentaryAppended) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveInputTranscriptDelta?>.Default.Equals(SessionInputTranscriptDelta, other.SessionInputTranscriptDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveOutputTranscriptDelta?>.Default.Equals(SessionOutputTranscriptDelta, other.SessionOutputTranscriptDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveDelegationCreated?>.Default.Equals(SessionDelegationCreated, other.SessionDelegationCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveDecisionEvent?>.Default.Equals(DecisionEvent, other.DecisionEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveDecisionItemCreated?>.Default.Equals(DecisionItemCreated, other.DecisionItemCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveDecisionItemDeleted?>.Default.Equals(DecisionItemDeleted, other.DecisionItemDeleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveResponseEvent?>.Default.Equals(ResponseEvent, other.ResponseEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveSessionUsageUpdated?>.Default.Equals(SessionUsageUpdated, other.SessionUsageUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveSessionClosed?>.Default.Equals(SessionClosed, other.SessionClosed) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveErrorEvent?>.Default.Equals(Error, other.Error) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveInfoEvent?>.Default.Equals(Info, other.Info)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(LiveSidebandServerEvent obj1, LiveSidebandServerEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LiveSidebandServerEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(LiveSidebandServerEvent obj1, LiveSidebandServerEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LiveSidebandServerEvent o && Equals(o);
        }
    }
}
