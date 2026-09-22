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
        public global::tryAGI.OpenAI.LiveSessionStarted PickSessionStarted() => IsSessionStarted
            ? SessionStarted!
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
        public global::tryAGI.OpenAI.LiveSessionUpdated PickSessionUpdated() => IsSessionUpdated
            ? SessionUpdated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionUpdated' but the value was {ToString()}.");

        /// <summary>
        /// Returned when a session.input_audio.mute command is accepted. Input audio is no longer sent to the model; sideband audio reflection continues.<br/>
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
        public global::tryAGI.OpenAI.LiveInputAudioMuted PickSessionInputAudioMuted() => IsSessionInputAudioMuted
            ? SessionInputAudioMuted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionInputAudioMuted' but the value was {ToString()}.");

        /// <summary>
        /// Returned when a session.input_audio.unmute command is accepted. Input audio is sent to the model again.<br/>
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
        public global::tryAGI.OpenAI.LiveInputAudioUnmuted PickSessionInputAudioUnmuted() => IsSessionInputAudioUnmuted
            ? SessionInputAudioUnmuted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionInputAudioUnmuted' but the value was {ToString()}.");

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
        public global::tryAGI.OpenAI.LiveInstructionsAppended PickSessionInstructionsAppended() => IsSessionInstructionsAppended
            ? SessionInstructionsAppended!
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
        public global::tryAGI.OpenAI.LiveThinkingAppended PickSessionThinkingAppended() => IsSessionThinkingAppended
            ? SessionThinkingAppended!
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
        public global::tryAGI.OpenAI.LiveCommentaryAppended PickSessionCommentaryAppended() => IsSessionCommentaryAppended
            ? SessionCommentaryAppended!
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
        public global::tryAGI.OpenAI.LiveInputTranscriptDelta PickSessionInputTranscriptDelta() => IsSessionInputTranscriptDelta
            ? SessionInputTranscriptDelta!
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
        public global::tryAGI.OpenAI.LiveOutputTranscriptDelta PickSessionOutputTranscriptDelta() => IsSessionOutputTranscriptDelta
            ? SessionOutputTranscriptDelta!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionOutputTranscriptDelta' but the value was {ToString()}.");

        /// <summary>
        /// Returned when the Live model delegates work to your application or a Responses backend. Contains delegation metadata and the position on the session timeline where the work was delegated.<br/>
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
        public global::tryAGI.OpenAI.LiveDelegationCreated PickSessionDelegationCreated() => IsSessionDelegationCreated
            ? SessionDelegationCreated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionDelegationCreated' but the value was {ToString()}.");

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
        public global::tryAGI.OpenAI.LiveResponseEvent PickResponseEvent() => IsResponseEvent
            ? ResponseEvent!
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
        public global::tryAGI.OpenAI.LiveSessionUsageUpdated PickSessionUsageUpdated() => IsSessionUsageUpdated
            ? SessionUsageUpdated!
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
        public global::tryAGI.OpenAI.LiveSessionClosed PickSessionClosed() => IsSessionClosed
            ? SessionClosed!
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
        public global::tryAGI.OpenAI.LiveErrorEvent PickError() => IsError
            ? Error!
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
        public global::tryAGI.OpenAI.LiveInfoEvent PickInfo() => IsInfo
            ? Info!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Info' but the value was {ToString()}.");
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
            global::tryAGI.OpenAI.LiveSessionStarted? sessionStarted,
            global::tryAGI.OpenAI.LiveSessionUpdated? sessionUpdated,
            global::tryAGI.OpenAI.LiveInputAudioMuted? sessionInputAudioMuted,
            global::tryAGI.OpenAI.LiveInputAudioUnmuted? sessionInputAudioUnmuted,
            global::tryAGI.OpenAI.LiveInstructionsAppended? sessionInstructionsAppended,
            global::tryAGI.OpenAI.LiveThinkingAppended? sessionThinkingAppended,
            global::tryAGI.OpenAI.LiveCommentaryAppended? sessionCommentaryAppended,
            global::tryAGI.OpenAI.LiveInputTranscriptDelta? sessionInputTranscriptDelta,
            global::tryAGI.OpenAI.LiveOutputTranscriptDelta? sessionOutputTranscriptDelta,
            global::tryAGI.OpenAI.LiveDelegationCreated? sessionDelegationCreated,
            global::tryAGI.OpenAI.LiveResponseEvent? responseEvent,
            global::tryAGI.OpenAI.LiveSessionUsageUpdated? sessionUsageUpdated,
            global::tryAGI.OpenAI.LiveSessionClosed? sessionClosed,
            global::tryAGI.OpenAI.LiveErrorEvent? error,
            global::tryAGI.OpenAI.LiveInfoEvent? info
            )
        {
            Type = type;

            SessionStarted = sessionStarted;
            SessionUpdated = sessionUpdated;
            SessionInputAudioMuted = sessionInputAudioMuted;
            SessionInputAudioUnmuted = sessionInputAudioUnmuted;
            SessionInstructionsAppended = sessionInstructionsAppended;
            SessionThinkingAppended = sessionThinkingAppended;
            SessionCommentaryAppended = sessionCommentaryAppended;
            SessionInputTranscriptDelta = sessionInputTranscriptDelta;
            SessionOutputTranscriptDelta = sessionOutputTranscriptDelta;
            SessionDelegationCreated = sessionDelegationCreated;
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
            SessionDelegationCreated as object ??
            SessionOutputTranscriptDelta as object ??
            SessionInputTranscriptDelta as object ??
            SessionCommentaryAppended as object ??
            SessionThinkingAppended as object ??
            SessionInstructionsAppended as object ??
            SessionInputAudioUnmuted as object ??
            SessionInputAudioMuted as object ??
            SessionUpdated as object ??
            SessionStarted as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            SessionStarted?.ToString() ??
            SessionUpdated?.ToString() ??
            SessionInputAudioMuted?.ToString() ??
            SessionInputAudioUnmuted?.ToString() ??
            SessionInstructionsAppended?.ToString() ??
            SessionThinkingAppended?.ToString() ??
            SessionCommentaryAppended?.ToString() ??
            SessionInputTranscriptDelta?.ToString() ??
            SessionOutputTranscriptDelta?.ToString() ??
            SessionDelegationCreated?.ToString() ??
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
            return IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo || !IsSessionStarted && IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo || !IsSessionStarted && !IsSessionUpdated && IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo || !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && IsSessionInputAudioUnmuted && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo || !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo || !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionInstructionsAppended && IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo || !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && IsSessionCommentaryAppended && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo || !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo || !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputTranscriptDelta && IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo || !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && IsSessionDelegationCreated && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo || !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo || !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsResponseEvent && IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo || !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsResponseEvent && !IsSessionUsageUpdated && IsSessionClosed && !IsError && !IsInfo || !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && IsError && !IsInfo || !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && IsInfo;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.LiveSessionStarted, TResult>? sessionStarted = null,
            global::System.Func<global::tryAGI.OpenAI.LiveSessionUpdated, TResult>? sessionUpdated = null,
            global::System.Func<global::tryAGI.OpenAI.LiveInputAudioMuted, TResult>? sessionInputAudioMuted = null,
            global::System.Func<global::tryAGI.OpenAI.LiveInputAudioUnmuted, TResult>? sessionInputAudioUnmuted = null,
            global::System.Func<global::tryAGI.OpenAI.LiveInstructionsAppended, TResult>? sessionInstructionsAppended = null,
            global::System.Func<global::tryAGI.OpenAI.LiveThinkingAppended, TResult>? sessionThinkingAppended = null,
            global::System.Func<global::tryAGI.OpenAI.LiveCommentaryAppended, TResult>? sessionCommentaryAppended = null,
            global::System.Func<global::tryAGI.OpenAI.LiveInputTranscriptDelta, TResult>? sessionInputTranscriptDelta = null,
            global::System.Func<global::tryAGI.OpenAI.LiveOutputTranscriptDelta, TResult>? sessionOutputTranscriptDelta = null,
            global::System.Func<global::tryAGI.OpenAI.LiveDelegationCreated, TResult>? sessionDelegationCreated = null,
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

            if (IsSessionStarted && sessionStarted != null)
            {
                return sessionStarted(SessionStarted!);
            }
            else if (IsSessionUpdated && sessionUpdated != null)
            {
                return sessionUpdated(SessionUpdated!);
            }
            else if (IsSessionInputAudioMuted && sessionInputAudioMuted != null)
            {
                return sessionInputAudioMuted(SessionInputAudioMuted!);
            }
            else if (IsSessionInputAudioUnmuted && sessionInputAudioUnmuted != null)
            {
                return sessionInputAudioUnmuted(SessionInputAudioUnmuted!);
            }
            else if (IsSessionInstructionsAppended && sessionInstructionsAppended != null)
            {
                return sessionInstructionsAppended(SessionInstructionsAppended!);
            }
            else if (IsSessionThinkingAppended && sessionThinkingAppended != null)
            {
                return sessionThinkingAppended(SessionThinkingAppended!);
            }
            else if (IsSessionCommentaryAppended && sessionCommentaryAppended != null)
            {
                return sessionCommentaryAppended(SessionCommentaryAppended!);
            }
            else if (IsSessionInputTranscriptDelta && sessionInputTranscriptDelta != null)
            {
                return sessionInputTranscriptDelta(SessionInputTranscriptDelta!);
            }
            else if (IsSessionOutputTranscriptDelta && sessionOutputTranscriptDelta != null)
            {
                return sessionOutputTranscriptDelta(SessionOutputTranscriptDelta!);
            }
            else if (IsSessionDelegationCreated && sessionDelegationCreated != null)
            {
                return sessionDelegationCreated(SessionDelegationCreated!);
            }
            else if (IsResponseEvent && responseEvent != null)
            {
                return responseEvent(ResponseEvent!);
            }
            else if (IsSessionUsageUpdated && sessionUsageUpdated != null)
            {
                return sessionUsageUpdated(SessionUsageUpdated!);
            }
            else if (IsSessionClosed && sessionClosed != null)
            {
                return sessionClosed(SessionClosed!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }
            else if (IsInfo && info != null)
            {
                return info(Info!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.LiveSessionStarted>? sessionStarted = null,

            global::System.Action<global::tryAGI.OpenAI.LiveSessionUpdated>? sessionUpdated = null,

            global::System.Action<global::tryAGI.OpenAI.LiveInputAudioMuted>? sessionInputAudioMuted = null,

            global::System.Action<global::tryAGI.OpenAI.LiveInputAudioUnmuted>? sessionInputAudioUnmuted = null,

            global::System.Action<global::tryAGI.OpenAI.LiveInstructionsAppended>? sessionInstructionsAppended = null,

            global::System.Action<global::tryAGI.OpenAI.LiveThinkingAppended>? sessionThinkingAppended = null,

            global::System.Action<global::tryAGI.OpenAI.LiveCommentaryAppended>? sessionCommentaryAppended = null,

            global::System.Action<global::tryAGI.OpenAI.LiveInputTranscriptDelta>? sessionInputTranscriptDelta = null,

            global::System.Action<global::tryAGI.OpenAI.LiveOutputTranscriptDelta>? sessionOutputTranscriptDelta = null,

            global::System.Action<global::tryAGI.OpenAI.LiveDelegationCreated>? sessionDelegationCreated = null,

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

            if (IsSessionStarted)
            {
                sessionStarted?.Invoke(SessionStarted!);
            }
            else if (IsSessionUpdated)
            {
                sessionUpdated?.Invoke(SessionUpdated!);
            }
            else if (IsSessionInputAudioMuted)
            {
                sessionInputAudioMuted?.Invoke(SessionInputAudioMuted!);
            }
            else if (IsSessionInputAudioUnmuted)
            {
                sessionInputAudioUnmuted?.Invoke(SessionInputAudioUnmuted!);
            }
            else if (IsSessionInstructionsAppended)
            {
                sessionInstructionsAppended?.Invoke(SessionInstructionsAppended!);
            }
            else if (IsSessionThinkingAppended)
            {
                sessionThinkingAppended?.Invoke(SessionThinkingAppended!);
            }
            else if (IsSessionCommentaryAppended)
            {
                sessionCommentaryAppended?.Invoke(SessionCommentaryAppended!);
            }
            else if (IsSessionInputTranscriptDelta)
            {
                sessionInputTranscriptDelta?.Invoke(SessionInputTranscriptDelta!);
            }
            else if (IsSessionOutputTranscriptDelta)
            {
                sessionOutputTranscriptDelta?.Invoke(SessionOutputTranscriptDelta!);
            }
            else if (IsSessionDelegationCreated)
            {
                sessionDelegationCreated?.Invoke(SessionDelegationCreated!);
            }
            else if (IsResponseEvent)
            {
                responseEvent?.Invoke(ResponseEvent!);
            }
            else if (IsSessionUsageUpdated)
            {
                sessionUsageUpdated?.Invoke(SessionUsageUpdated!);
            }
            else if (IsSessionClosed)
            {
                sessionClosed?.Invoke(SessionClosed!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
            else if (IsInfo)
            {
                info?.Invoke(Info!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.LiveSessionStarted>? sessionStarted = null,
            global::System.Action<global::tryAGI.OpenAI.LiveSessionUpdated>? sessionUpdated = null,
            global::System.Action<global::tryAGI.OpenAI.LiveInputAudioMuted>? sessionInputAudioMuted = null,
            global::System.Action<global::tryAGI.OpenAI.LiveInputAudioUnmuted>? sessionInputAudioUnmuted = null,
            global::System.Action<global::tryAGI.OpenAI.LiveInstructionsAppended>? sessionInstructionsAppended = null,
            global::System.Action<global::tryAGI.OpenAI.LiveThinkingAppended>? sessionThinkingAppended = null,
            global::System.Action<global::tryAGI.OpenAI.LiveCommentaryAppended>? sessionCommentaryAppended = null,
            global::System.Action<global::tryAGI.OpenAI.LiveInputTranscriptDelta>? sessionInputTranscriptDelta = null,
            global::System.Action<global::tryAGI.OpenAI.LiveOutputTranscriptDelta>? sessionOutputTranscriptDelta = null,
            global::System.Action<global::tryAGI.OpenAI.LiveDelegationCreated>? sessionDelegationCreated = null,
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

            if (IsSessionStarted)
            {
                sessionStarted?.Invoke(SessionStarted!);
            }
            else if (IsSessionUpdated)
            {
                sessionUpdated?.Invoke(SessionUpdated!);
            }
            else if (IsSessionInputAudioMuted)
            {
                sessionInputAudioMuted?.Invoke(SessionInputAudioMuted!);
            }
            else if (IsSessionInputAudioUnmuted)
            {
                sessionInputAudioUnmuted?.Invoke(SessionInputAudioUnmuted!);
            }
            else if (IsSessionInstructionsAppended)
            {
                sessionInstructionsAppended?.Invoke(SessionInstructionsAppended!);
            }
            else if (IsSessionThinkingAppended)
            {
                sessionThinkingAppended?.Invoke(SessionThinkingAppended!);
            }
            else if (IsSessionCommentaryAppended)
            {
                sessionCommentaryAppended?.Invoke(SessionCommentaryAppended!);
            }
            else if (IsSessionInputTranscriptDelta)
            {
                sessionInputTranscriptDelta?.Invoke(SessionInputTranscriptDelta!);
            }
            else if (IsSessionOutputTranscriptDelta)
            {
                sessionOutputTranscriptDelta?.Invoke(SessionOutputTranscriptDelta!);
            }
            else if (IsSessionDelegationCreated)
            {
                sessionDelegationCreated?.Invoke(SessionDelegationCreated!);
            }
            else if (IsResponseEvent)
            {
                responseEvent?.Invoke(ResponseEvent!);
            }
            else if (IsSessionUsageUpdated)
            {
                sessionUsageUpdated?.Invoke(SessionUsageUpdated!);
            }
            else if (IsSessionClosed)
            {
                sessionClosed?.Invoke(SessionClosed!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
            else if (IsInfo)
            {
                info?.Invoke(Info!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SessionStarted,
                typeof(global::tryAGI.OpenAI.LiveSessionStarted),
                SessionUpdated,
                typeof(global::tryAGI.OpenAI.LiveSessionUpdated),
                SessionInputAudioMuted,
                typeof(global::tryAGI.OpenAI.LiveInputAudioMuted),
                SessionInputAudioUnmuted,
                typeof(global::tryAGI.OpenAI.LiveInputAudioUnmuted),
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
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveSessionStarted?>.Default.Equals(SessionStarted, other.SessionStarted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveSessionUpdated?>.Default.Equals(SessionUpdated, other.SessionUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveInputAudioMuted?>.Default.Equals(SessionInputAudioMuted, other.SessionInputAudioMuted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveInputAudioUnmuted?>.Default.Equals(SessionInputAudioUnmuted, other.SessionInputAudioUnmuted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveInstructionsAppended?>.Default.Equals(SessionInstructionsAppended, other.SessionInstructionsAppended) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveThinkingAppended?>.Default.Equals(SessionThinkingAppended, other.SessionThinkingAppended) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveCommentaryAppended?>.Default.Equals(SessionCommentaryAppended, other.SessionCommentaryAppended) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveInputTranscriptDelta?>.Default.Equals(SessionInputTranscriptDelta, other.SessionInputTranscriptDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveOutputTranscriptDelta?>.Default.Equals(SessionOutputTranscriptDelta, other.SessionOutputTranscriptDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveDelegationCreated?>.Default.Equals(SessionDelegationCreated, other.SessionDelegationCreated) &&
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
